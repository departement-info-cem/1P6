import { createClient } from "npm:@supabase/supabase-js@2";
import { challenges, challengeIds } from "../_shared/challenges.mjs";
import { judgeSubmission } from "../_shared/judge.mjs";

const supabaseUrl = Deno.env.get("SUPABASE_URL")!;
const serviceKey = Deno.env.get("SUPABASE_SERVICE_ROLE_KEY")!;
const anonKey = Deno.env.get("SUPABASE_ANON_KEY")!;
const admin = createClient(supabaseUrl, serviceKey, { auth: { persistSession: false } });
const authClient = createClient(supabaseUrl, anonKey, { auth: { persistSession: false } });
const allowedOrigins = (Deno.env.get("DEFIS_ALLOWED_ORIGINS") || "").split(",").map((value) => value.trim());

function cors(request: Request) {
  const origin = request.headers.get("Origin") || "";
  return {
    "Access-Control-Allow-Origin": allowedOrigins.includes(origin) ? origin : "null",
    "Access-Control-Allow-Headers": "authorization, apikey, content-type, x-client-info",
    "Access-Control-Allow-Methods": "POST, OPTIONS",
    "Vary": "Origin",
  };
}

function answer(request: Request, body: unknown, status = 200) {
  return new Response(JSON.stringify(body), {
    status,
    headers: { ...cors(request), "Content-Type": "application/json; charset=utf-8", "Cache-Control": "no-store" },
  });
}

async function userId(request: Request) {
  const match = /^Bearer (.+)$/.exec(request.headers.get("Authorization") || "");
  if (!match) return null;
  const { data, error } = await authClient.auth.getUser(match[1]);
  return error ? null : data.user?.id || null;
}

async function myProgress(uid: string) {
  const [profile, completions] = await Promise.all([
    admin.from("defi_profiles").select("nickname").eq("user_id", uid).maybeSingle(),
    admin.from("defi_completions").select("challenge_id,shared").eq("user_id", uid),
  ]);
  if (profile.error || completions.error) throw new Error("Lecture des résultats impossible.");
  return { nickname: profile.data?.nickname || null, completions: completions.data || [], score: completions.data?.length || 0 };
}

async function leaderboard() {
  const rows = [];
  for (let start = 0; ; start += 500) {
    const { data, error } = await admin.rpc("defi_leaderboard").range(start, start + 499);
    if (error) throw new Error("Classement indisponible.");
    rows.push(...(data || []));
    if (!data || data.length < 500) return rows;
  }
}

Deno.serve(async (request) => {
  if (request.method === "OPTIONS") return new Response(null, { headers: cors(request) });
  if (request.method !== "POST") return answer(request, { error: "Méthode non permise." }, 405);
  if (!allowedOrigins.includes(request.headers.get("Origin") || "")) return answer(request, { error: "Origine non permise." }, 403);
  let body: Record<string, unknown>;
  try { body = await request.json(); } catch { return answer(request, { error: "Requête invalide." }, 400); }
  try {
    if (body.action === "leaderboard") return answer(request, { rows: await leaderboard(), totalChallenges: challengeIds.length });

    const uid = await userId(request);
    if (!uid) return answer(request, { error: "Connecte-toi avec ton compte GitHub scolaire." }, 401);
    if (body.action === "my") return answer(request, await myProgress(uid));

    if (body.action === "nickname") {
      const nickname = String(body.nickname || "").trim().replace(/\s+/g, " ");
      if (!/^[\p{L}\p{N}_ -]{3,24}$/u.test(nickname) || /^\d+$/.test(nickname))
        return answer(request, { error: "Choisis un pseudonyme de 3 à 24 caractères, sans code étudiant." }, 400);
      const progress = await myProgress(uid);
      if (!progress.score) return answer(request, { error: "Valide d'abord un défi." }, 403);
      const { error } = await admin.from("defi_profiles").upsert({ user_id: uid, nickname }, { onConflict: "user_id" });
      if (error) return answer(request, { error: error.code === "23505" ? "Ce pseudonyme est déjà utilisé." : "Pseudonyme non enregistré." }, 409);
      return answer(request, { nickname });
    }

    const challengeId = String(body.challengeId || "");
    if (!Object.hasOwn(challenges, challengeId)) return answer(request, { error: "Défi inconnu." }, 400);

    if (body.action === "solutions") {
      const own = await admin.from("defi_completions").select("challenge_id")
        .eq("user_id", uid).eq("challenge_id", challengeId).maybeSingle();
      if (own.error || !own.data) return answer(request, { error: "Réussis ce défi pour voir les solutions partagées." }, 403);
      const [shared, profiles] = await Promise.all([
        admin.from("defi_completions").select("user_id,source_code,updated_at").eq("challenge_id", challengeId).eq("shared", true).order("updated_at", { ascending: false }).limit(50),
        admin.from("defi_profiles").select("user_id,nickname"),
      ]);
      if (shared.error || profiles.error) throw new Error("Solutions indisponibles.");
      const names = new Map((profiles.data || []).map((row) => [row.user_id, row.nickname]));
      return answer(request, { solutions: (shared.data || []).filter((row) => row.user_id !== uid && names.has(row.user_id))
        .map((row) => ({ nickname: names.get(row.user_id), source: row.source_code, updatedAt: row.updated_at })) });
    }

    if (body.action === "share") {
      if (typeof body.shared !== "boolean") return answer(request, { error: "Choix de partage invalide." }, 400);
      const { data, error } = await admin.from("defi_completions").update({ shared: body.shared })
        .eq("user_id", uid).eq("challenge_id", challengeId).select("shared").maybeSingle();
      if (error || !data) return answer(request, { error: "Défi non validé." }, 403);
      return answer(request, { shared: data.shared });
    }

    if (body.action === "submit") {
      const source = String(body.source || "");
      if (!source.trim() || source.length > 40000) return answer(request, { error: "Colle un fichier Program.cs de moins de 40 000 caractères." }, 400);
      const judgeUrl = Deno.env.get("JUDGE0_URL");
      if (!judgeUrl) return answer(request, { error: "La correction n'est pas encore disponible." }, 503);
      const reservation = await admin.rpc("reserve_defi_attempt", { p_user_id: uid });
      if (reservation.error) throw new Error("Limite de soumission indisponible.");
      if (!reservation.data) return answer(request, { error: "Attends 30 secondes entre deux essais (maximum 30 par jour)." }, 429);
      const headers = JSON.parse(Deno.env.get("JUDGE0_HEADERS_JSON") || "{}");
      const verdict = await judgeSubmission(challengeId, source, { url: judgeUrl, headers,
        languageId: Number(Deno.env.get("JUDGE0_CSHARP_ID") || "51") });
      if (!verdict.passed) return answer(request, { ...verdict, score: (await myProgress(uid)).score });
      const prior = await admin.from("defi_completions").select("shared").eq("user_id", uid)
        .eq("challenge_id", challengeId).maybeSingle();
      if (prior.error) throw new Error("Résultat non enregistré.");
      const { error } = await admin.from("defi_completions").upsert({ user_id: uid, challenge_id: challengeId,
        source_code: source, shared: prior.data?.shared || false, updated_at: new Date().toISOString() },
        { onConflict: "user_id,challenge_id" });
      if (error) throw new Error("Résultat non enregistré.");
      return answer(request, { ...verdict, score: (await myProgress(uid)).score });
    }
    return answer(request, { error: "Action inconnue." }, 400);
  } catch (error) {
    console.error(error);
    return answer(request, { error: "Le service des défis est temporairement indisponible." }, 503);
  }
});

import { challenges, checkResult } from "./challenges.mjs";

function encode(value) {
  const bytes = new TextEncoder().encode(value);
  let binary = "";
  for (let offset = 0; offset < bytes.length; offset += 8192)
    binary += String.fromCharCode(...bytes.subarray(offset, offset + 8192));
  return btoa(binary);
}

function decode(value) {
  if (!value) return "";
  return new TextDecoder().decode(Uint8Array.from(atob(value), (character) => character.charCodeAt(0)));
}

export function makeSource(studentSource) {
  return `${studentSource}\n
internal static class __DefisValidation {
  private static int Main() {
    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-CA");
    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA");
    try {
      System.Reflection.MethodInfo entry = null;
      foreach (var type in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()) {
        if (type == typeof(__DefisValidation)) continue;
        foreach (var method in type.GetMethods(System.Reflection.BindingFlags.Static |
          System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)) {
          var parameters = method.GetParameters();
          if (method.Name == "Main" && (parameters.Length == 0 ||
              (parameters.Length == 1 && parameters[0].ParameterType == typeof(string[])))) {
            entry = method; break;
          }
        }
        if (entry != null) break;
      }
      if (entry == null) throw new System.Exception("Méthode Main introuvable dans Program.cs.");
      var arguments = entry.GetParameters().Length == 0 ? null : new object[] { new string[0] };
      entry.Invoke(null, arguments);
      return 0;
    } catch (System.Exception ex) {
      System.Console.Error.WriteLine(ex.GetBaseException().Message);
      return 1;
    }
  }
}`;
}

export async function judgeSubmission(challengeId, source, options, fetcher = fetch) {
  if (!Object.hasOwn(challenges, challengeId)) throw new Error("Défi inconnu.");
  const challenge = challenges[challengeId];
  const results = [];
  for (const test of challenge.tests) {
    const response = await fetcher(`${options.url.replace(/\/$/, "")}/submissions?wait=true&base64_encoded=true`, {
      method: "POST",
      headers: { "Content-Type": "application/json", ...(options.headers || {}) },
      body: JSON.stringify({
        language_id: options.languageId || 51,
        source_code: encode(makeSource(source)),
        compiler_options: "-main:__DefisValidation",
        stdin: encode(test.input || ""),
        cpu_time_limit: 2,
        wall_time_limit: 5,
        memory_limit: 128000,
        max_file_size: 1024,
        enable_network: false,
      }),
      signal: AbortSignal.timeout(20000),
    });
    if (!response.ok) throw new Error(`Service de correction indisponible (${response.status}) : ${(await response.text()).slice(0, 250)}.`);
    const data = await response.json();
    if (!data.status || data.status.id < 3) throw new Error("Le service de correction n'a pas terminé le test.");
    const stdout = decode(data.stdout);
    const passed = data.status.id === 3 && checkResult(test, stdout);
    results.push({ name: test.name, passed, detail: passed ? "Réussi" :
      (decode(data.compile_output) || decode(data.stderr) || decode(data.message) ||
        `Résultat obtenu : ${stdout || "(aucune sortie)"}`).slice(0, 800) });
    if (data.compile_output) break;
  }
  return { passed: results.length === challenge.tests.length && results.every((result) => result.passed), results };
}

-- Les clients n'écrivent jamais directement les points : seule la fonction
-- de correction, après réussite des tests, utilise la clé de service.
create table public.defi_profiles (
  user_id uuid primary key references auth.users(id) on delete cascade,
  nickname text not null,
  created_at timestamptz not null default now(),
  constraint defi_nickname_format check (
    length(nickname) between 3 and 24 and nickname !~ '^[0-9]+$'
  )
);
create unique index defi_profiles_nickname_unique on public.defi_profiles (lower(nickname));

create table public.defi_completions (
  user_id uuid not null references auth.users(id) on delete cascade,
  challenge_id text not null,
  source_code text not null,
  shared boolean not null default false,
  completed_at timestamptz not null default now(),
  updated_at timestamptz not null default now(),
  primary key (user_id, challenge_id),
  constraint defi_source_size check (length(source_code) between 1 and 40000)
);
create index defi_completions_challenge_shared on public.defi_completions (challenge_id, shared);

-- Agréger en base évite de tronquer les réussites à la limite de lignes de l'API.
create or replace function public.defi_leaderboard()
returns table (rank integer, nickname text, score integer)
language sql
security definer
set search_path = public
as $$
  with totals as (
    select p.nickname, count(c.challenge_id)::integer as score
    from public.defi_profiles p
    join public.defi_completions c on c.user_id = p.user_id
    group by p.user_id, p.nickname
  )
  select rank() over (order by totals.score desc)::integer,
    totals.nickname, totals.score
  from totals
  order by totals.score desc, totals.nickname;
$$;
revoke all on function public.defi_leaderboard() from public, anon, authenticated;
grant execute on function public.defi_leaderboard() to service_role;

create table public.defi_attempt_limits (
  user_id uuid primary key references auth.users(id) on delete cascade,
  last_attempt_at timestamptz not null,
  day date not null,
  day_count integer not null
);

alter table public.defi_profiles enable row level security;
alter table public.defi_completions enable row level security;
alter table public.defi_attempt_limits enable row level security;
revoke all on public.defi_profiles, public.defi_completions, public.defi_attempt_limits from anon, authenticated;
grant all on public.defi_profiles, public.defi_completions, public.defi_attempt_limits to service_role;

create or replace function public.reserve_defi_attempt(p_user_id uuid)
returns boolean
language plpgsql
security definer
set search_path = public
as $$
declare
  accepted uuid;
begin
  insert into public.defi_attempt_limits (user_id, last_attempt_at, day, day_count)
  values (p_user_id, now(), current_date, 1)
  on conflict (user_id) do update
    set last_attempt_at = now(),
        day = current_date,
        day_count = case when defi_attempt_limits.day = current_date
          then defi_attempt_limits.day_count + 1 else 1 end
    where defi_attempt_limits.last_attempt_at < now() - interval '30 seconds'
      and (defi_attempt_limits.day <> current_date or defi_attempt_limits.day_count < 30)
  returning user_id into accepted;
  return accepted is not null;
end;
$$;
revoke all on function public.reserve_defi_attempt(uuid) from public, anon, authenticated;
grant execute on function public.reserve_defi_attempt(uuid) to service_role;

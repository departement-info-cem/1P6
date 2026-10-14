import React, {useEffect, useState} from 'react';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import {createClient} from '@supabase/supabase-js';

type Row = {rank: number; nickname: string; score: number};

export default function DefiLeaderboard() {
  const {siteConfig} = useDocusaurusContext();
  const fields = siteConfig.customFields || {};
  const [rows, setRows] = useState<Row[]>([]);
  const [ready, setReady] = useState(false);
  const [error, setError] = useState(false);

  useEffect(() => {
    const url = String(fields.defisSupabaseUrl || '');
    const key = String(fields.defisSupabaseAnonKey || '');
    if (!url || !key) return;
    const client = createClient(url, key);
    client.functions.invoke('defis', {body: {action: 'leaderboard'}}).then(({data, error}) => {
      if (error || data?.error) setError(true);
      else { setRows(data.rows || []); setReady(true); }
    });
  }, [fields.defisSupabaseUrl, fields.defisSupabaseAnonKey]);

  if (!fields.defisSupabaseUrl || !fields.defisSupabaseAnonKey) return null;
  return <section aria-label="Classement des défis">
    <h2>Classement des défis</h2>
    <p>Un défi validé vaut un point. Seuls les pseudonymes sont publics.</p>
    {error ? <p>Le classement est temporairement indisponible.</p> : !ready ? <p>Chargement du classement…</p> : rows.length === 0 ? <p>Personne n’a encore validé de défi.</p> :
      <table><thead><tr><th>Rang</th><th>Pseudonyme</th><th>Défis réussis</th></tr></thead>
        <tbody>{rows.map((row) => <tr key={row.nickname}><td>{row.rank}</td><td>{row.nickname}</td><td>{row.score}</td></tr>)}</tbody></table>}
  </section>;
}

import React, {useEffect, useState} from 'react';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import {createClient, SupabaseClient} from '@supabase/supabase-js';
import styles from './styles.module.css';

type Completion = {challenge_id: string; shared: boolean};
type Progress = {nickname: string | null; score: number; completions: Completion[]};
type TestResult = {name: string; passed: boolean; detail: string};
type Solution = {nickname: string; source: string; updatedAt: string};

function errorText(error: unknown) {
  return error instanceof Error ? error.message : 'Une erreur est survenue.';
}

export default function DefiSubmission({challengeId}: {challengeId: string}) {
  const {siteConfig} = useDocusaurusContext();
  const fields = siteConfig.customFields || {};
  const [client, setClient] = useState<SupabaseClient | null>(null);
  const [signedIn, setSignedIn] = useState(false);
  const [source, setSource] = useState('');
  const [progress, setProgress] = useState<Progress | null>(null);
  const [nickname, setNickname] = useState('');
  const [results, setResults] = useState<TestResult[] | null>(null);
  const [solutions, setSolutions] = useState<Solution[] | null>(null);
  const [busy, setBusy] = useState(false);
  const [message, setMessage] = useState('');

  useEffect(() => {
    const url = String(fields.defisSupabaseUrl || '');
    const key = String(fields.defisSupabaseAnonKey || '');
    if (!url || !key) return;
    const service = createClient(url, key);
    setClient(service);
    service.auth.getSession().then(({data}) => setSignedIn(!!data.session));
    const {data: listener} = service.auth.onAuthStateChange((_event, session) => setSignedIn(!!session));
    return () => listener.subscription.unsubscribe();
  }, [fields.defisSupabaseUrl, fields.defisSupabaseAnonKey]);

  useEffect(() => {
    if (!client || !signedIn) {
      setProgress(null);
      return;
    }
    client.functions.invoke('defis', {body: {action: 'my'}}).then(({data, error}) => {
      if (error || data?.error) setMessage(data?.error || errorText(error));
      else setProgress(data);
    });
  }, [client, signedIn]);

  async function call(body: Record<string, unknown>) {
    if (!client) throw new Error('Le service des défis n’est pas configuré.');
    const {data, error} = await client.functions.invoke('defis', {body});
    if (error || data?.error) throw new Error(data?.error || errorText(error));
    return data;
  }

  async function signIn() {
    if (!client) return;
    const {error} = await client.auth.signInWithOAuth({
      provider: 'github',
      options: {redirectTo: window.location.href},
    });
    if (error) setMessage(error.message);
  }

  async function submit() {
    setBusy(true);
    setMessage('');
    setResults(null);
    try {
      const verdict = await call({action: 'submit', challengeId, source});
      setResults(verdict.results);
      setMessage(verdict.passed ? 'Défi validé ! Un point a été ajouté si c’est ta première réussite.' :
        'Le défi n’est pas encore validé. Corrige ton programme et réessaie.');
      if (verdict.passed) setProgress(await call({action: 'my'}));
    } catch (error) { setMessage(errorText(error)); }
    finally { setBusy(false); }
  }

  async function saveNickname() {
    setBusy(true);
    setMessage('');
    try {
      await call({action: 'nickname', nickname});
      setProgress(await call({action: 'my'}));
      setMessage('Pseudonyme enregistré. Il sera affiché dans le classement.');
    } catch (error) { setMessage(errorText(error)); }
    finally { setBusy(false); }
  }

  async function changeSharing(shared: boolean) {
    setBusy(true);
    setMessage('');
    try {
      await call({action: 'share', challengeId, shared});
      setProgress(await call({action: 'my'}));
      setMessage(shared ? 'Ta solution validée est maintenant partagée.' : 'Ta solution n’est plus partagée.');
      if (solutions) setSolutions((await call({action: 'solutions', challengeId})).solutions);
    } catch (error) { setMessage(errorText(error)); }
    finally { setBusy(false); }
  }

  async function showSolutions() {
    setBusy(true);
    setMessage('');
    try { setSolutions((await call({action: 'solutions', challengeId})).solutions); }
    catch (error) { setMessage(errorText(error)); }
    finally { setBusy(false); }
  }

  const completion = progress?.completions.find((item) => item.challenge_id === challengeId);
  const configured = Boolean(fields.defisSupabaseUrl && fields.defisSupabaseAnonKey);

  return <section className={styles.panel} aria-label="Remettre ce défi">
    <h2>Faire valider ce défi</h2>
    <p>Termine et teste ton programme dans Visual Studio. Ouvre <code>Program.cs</code>, fais <kbd>Ctrl+A</kbd>, puis <kbd>Ctrl+C</kbd>. Colle <strong>tout le fichier</strong> ci-dessous. Tu n’as pas besoin d’utiliser Git ni de pousser ton code.</p>
    <p>Chaque défi réussi vaut <strong>1 point</strong>. Tu peux refaire un essai après 30 secondes, jusqu’à 30 essais par jour. Seule ta première réussite ajoute un point.</p>
    {!configured ? <p role="status">La remise en ligne sera disponible lorsque le service de correction sera configuré.</p> :
      !signedIn ? <button type="button" className="button button--primary" onClick={signIn}>Se connecter avec GitHub scolaire</button> : <>
        <label className={styles.label} htmlFor={`code-${challengeId}`}>Tout le contenu de Program.cs</label>
        <textarea id={`code-${challengeId}`} className={styles.editor} value={source} onChange={(event) => setSource(event.target.value)} spellCheck={false} placeholder="Colle ici ton Program.cs complet" />
        <button type="button" className="button button--primary" disabled={busy || !source.trim()} onClick={submit}>{busy ? 'Validation en cours…' : 'Valider mon code'}</button>
        {progress && <p>Ton score : <strong>{progress.score} défi{progress.score > 1 ? 's' : ''} réussi{progress.score > 1 ? 's' : ''}</strong>.</p>}
        {results && <ul className={styles.results}>{results.map((result) => <li key={result.name}>
          <strong>{result.passed ? '✓' : '✗'} {result.name}</strong>{!result.passed && <pre>{result.detail}</pre>}
        </li>)}</ul>}
        {progress && progress.score > 0 && !progress.nickname && <div className={styles.nickname}>
          <label htmlFor={`nickname-${challengeId}`}>Choisis un pseudonyme pour le classement public (sans ton code étudiant)</label>
          <input id={`nickname-${challengeId}`} value={nickname} maxLength={24} onChange={(event) => setNickname(event.target.value)} />
          <button type="button" className="button button--secondary" disabled={busy || nickname.trim().length < 3} onClick={saveNickname}>Enregistrer mon pseudonyme</button>
        </div>}
        {completion && progress?.nickname && <div className={styles.sharing}>
          <p>Ce défi est réussi. Partager ta solution validée est facultatif.</p>
          <label><input type="checkbox" checked={completion.shared} disabled={busy} onChange={(event) => changeSharing(event.target.checked)} /> Partager ma solution avec les autres étudiants qui ont réussi ce défi</label>
          <button type="button" className="button button--secondary" disabled={busy} onClick={showSolutions}>Voir les solutions des autres</button>
        </div>}
        {solutions && <div className={styles.solutions}>
          <h3>Solutions partagées</h3>
          {solutions.length === 0 ? <p>Aucune solution partagée pour l’instant.</p> : solutions.map((item, index) =>
            <details key={`${item.nickname}-${index}`}><summary>{item.nickname}</summary><pre><code>{item.source}</code></pre></details>)}
        </div>}
      </>}
    {message && <p role="status" className={styles.message}>{message}</p>}
  </section>;
}

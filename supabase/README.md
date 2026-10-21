# Validation des défis console

Pour la revue de la PR, suivre le [guide de test pas à pas](GUIDE-REVUE.md).

Cette partie ajoute la remise par copier-coller aux **11 défis console autonomes** de `web/docs/06-defis`. Les défis de lecture, de fichiers et `objets-classes` ne sont pas activés. Chaque défi validé rapporte un seul point; les essais suivants ne changent pas le score. Les résultats sont destinés à l'entraînement, pas à la note officielle.

## Parcours étudiant

1. Se connecter avec le compte GitHub scolaire, sans utiliser Git.
2. Copier tout `Program.cs` depuis Visual Studio et le coller dans la page du défi.
3. Cliquer sur **Valider mon code**; les tests et erreurs s'affichent sur place.
4. Après une première réussite, choisir un pseudonyme pour le classement public.
5. Choisir librement de partager ou non sa solution validée. Les solutions partagées d'un défi deviennent visibles après avoir réussi ce même défi.

Le pseudonyme est indépendant du nom GitHub et du code étudiant. Le code source et l'identifiant GitHub ne sont jamais envoyés dans la réponse du classement. Les tables n'accordent aucun accès direct aux rôles `anon` et `authenticated`; seule la fonction de correction écrit les réussites.

## Configuration requise avant publication

Le site reste compilable sans ces variables et affiche alors un message indiquant que la remise n'est pas encore disponible. Aucun service infonuagique n'a été créé par cette branche.

1. Créer un projet Supabase et appliquer `migrations/20261014000000_defis.sql` avec la CLI Supabase. Activer le fournisseur GitHub dans Supabase Auth et créer l'application OAuth GitHub correspondante. Autoriser les URL de retour du site `https://info.cegepmontpetit.ca/1P6/defis/*` et de l'environnement local. Voir [la procédure officielle GitHub Auth](https://supabase.com/docs/guides/auth/social-login/auth-github).
2. Déployer la fonction `functions/defis`. Lui fournir `DEFIS_ALLOWED_ORIGINS` (par exemple `https://info.cegepmontpetit.ca,http://localhost:3000`), `JUDGE0_URL`, `JUDGE0_HEADERS_JSON` et `JUDGE0_CSHARP_ID` si l'identifiant C# n'est pas `51`. Supabase fournit normalement `SUPABASE_URL`, `SUPABASE_ANON_KEY` et `SUPABASE_SERVICE_ROLE_KEY` à ses fonctions. Ne jamais exposer la clé de service ou la clé du correcteur au navigateur.
3. Utiliser un service Judge0 géré ou une instance isolée, avec C# disponible. Le correcteur lui envoie le code source, sans nom d'étudiant, avec réseau désactivé et limites de temps, mémoire et taille de fichier. Vérifier les règles du cégep sur le traitement infonuagique du code avant cette mise en service. L'instance de démonstration publique de Judge0 sert uniquement aux tests locaux, pas à la production.
4. Ajouter les variables GitHub Actions `DEFIS_SUPABASE_URL` et `DEFIS_SUPABASE_ANON_KEY` au dépôt `1P6`, puis redéployer le site. La clé anonyme est publique; la clé de service reste uniquement dans Supabase.

La fonction accepte au maximum 30 essais par compte et par jour, espacés d'au moins 30 secondes. Le test exécute le code C# dans le bac à sable Judge0 avec la culture `fr-CA`, ce qui conserve la saisie décimale à virgule enseignée dans le cours. La validation compare plusieurs sorties attendues, mais ne démontre pas l'originalité ni la qualité complète du programme.

## Vérification avant activation

Depuis la racine du dépôt :

```powershell
node --test supabase/functions/_shared/challenges.test.mjs
$env:JUDGE0_TEST_URL = 'https://URL_DU_CORRECTEUR'
node --test supabase/functions/_shared/challenges.test.mjs
Remove-Item Env:JUDGE0_TEST_URL
```

Le second passage doit accepter les 11 solutionnaires publiés avec le **même** fournisseur Judge0 que celui choisi pour la production. Depuis `web`, lancer `npm run build`. Tester ensuite avec deux comptes GitHub distincts : réussite et échec, pseudonyme unique, point attribué une seule fois, classement public, partage activé puis retiré, accès aux solutions refusé avant réussite.

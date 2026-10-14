# Guide de revue : validation des défis console

Ce guide accompagne la PR de la branche `defis-soumissions-classement`. La fonction concerne les 11 défis console autonomes. Les défis de lecture, de fichiers et celui avec `CompteFidelite` restent hors de ce parcours.

## 1. Vérifier le code localement

Depuis la racine du dépôt, avec Node.js 24 :

```powershell
node --test supabase/functions/_shared/challenges.test.mjs
cd web
npm ci
npm run build
```

Le premier test vérifie les règles des défis. Les tests qui exécutent réellement les 11 solutionnaires sont ignorés tant que `JUDGE0_TEST_URL` n'est pas défini. Pour les lancer avec le correcteur choisi pour l'environnement de test :

```powershell
cd ..
$env:JUDGE0_TEST_URL = 'https://URL_DU_CORRECTEUR'
node --test supabase/functions/_shared/challenges.test.mjs
Remove-Item Env:JUDGE0_TEST_URL
```

Résultat attendu : les 11 solutionnaires sont acceptés et le programme volontairement incorrect est refusé. Ne pas utiliser l'instance publique de démonstration comme preuve de fonctionnement en production.

## 2. Vérifier le parcours dans le navigateur

Il faut un **projet Supabase de test** avec la migration et la fonction `defis` déployées, GitHub Auth configuré pour l'adresse locale, et un correcteur Judge0 de test. La configuration de ces services est détaillée dans [README.md](README.md). Demander au propriétaire du projet de test son URL et sa clé **anonyme/publishable**; ne jamais demander ni placer dans le navigateur la clé `service_role`. Le projet de test utilisé pendant le développement a été vidé de ses comptes et réussites fictifs.

Dans PowerShell, depuis `web` :

```powershell
$env:DEFIS_SUPABASE_URL = 'https://PROJET_DE_TEST.supabase.co'
$env:DEFIS_SUPABASE_ANON_KEY = 'CLE_PUBLIQUE_DU_PROJET_DE_TEST'
npm run start -- --host 127.0.0.1 --port 3000
```

Ouvrir `http://127.0.0.1:3000/1P6/defis`. Utiliser deux comptes GitHub de test dans deux profils ou fenêtres privées distincts, sans échanger de mot de passe. Les essais ci-dessous créent des données uniquement dans le projet Supabase de test.

1. Dans le premier compte, ouvrir **Variables et calculs : Coût des brochures**. Coller `class Program { static void Main() { System.Console.WriteLine("bonjour"); } }`. La validation doit échouer et le score rester à zéro.
2. Coller ensuite **tout** le `Program.cs` du [solutionnaire](../web/docs/04-solution/solution-variables-calculs.md). La validation doit réussir, donner un seul point et permettre de choisir un pseudonyme. Revalider le même code ne doit pas ajouter de point.
3. Activer **Partager ma solution**. Dans le deuxième compte, vérifier que le code du premier n'est pas accessible avant la réussite du même défi. Valider ensuite ce défi avec le deuxième compte et choisir un autre pseudonyme : la solution partagée du premier doit devenir visible.
4. Depuis le premier compte, vérifier le classement : deux pseudonymes, chacun avec un point. Si le deuxième compte partage sa solution, le premier doit pouvoir la voir dans **Voir les solutions des autres**. Chaque étudiant ne voit pas sa propre solution dans cette liste.
5. Désactiver le partage dans le premier compte. Rafraîchir la liste du deuxième compte : la solution du premier doit disparaître. Le score et le classement doivent rester inchangés.
6. Vérifier qu'aucune adresse courriel, identité GitHub ou code étudiant n'apparaît dans le classement ni dans la liste des solutions.

Les solutions sont actuellement limitées aux **50 plus récentes** par défi; une pagination sera nécessaire avant une utilisation à grande échelle. La validation automatique vérifie les résultats des cas prévus, pas la qualité ou l'originalité du code.

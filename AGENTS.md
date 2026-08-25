# Reprise du travail Codex

## Objectif actif

Sur la branche `solutionCacher` uniquement, remplacer l'ouverture manuelle de
l'éditeur GitHub par une authentification GitHub pour les professeurs et une
mise à jour automatique de `web/src/data/solutions-defis.json` depuis les cases
à cocher de la page professeur.

Le professeur doit pouvoir cocher ou décocher une solution de défi, confirmer
la publication et laisser l'application créer automatiquement le commit qui
déclenchera le déploiement. Il ne doit plus devoir ouvrir, coller ou modifier le
fichier JSON dans l'interface GitHub.

## Contraintes obligatoires

- Ne jamais créer de PR et ne jamais fusionner dans `main` sans une nouvelle
  demande explicite de l'utilisateur.
- Travailler, committer et pousser uniquement sur `solutionCacher`.
- Ne gérer ici que les solutions des défis.
- Ne pas cacher, modifier ou retirer les solutions des laboratoires.
- Toutes les solutions de défis restent cachées par défaut.
- Le mot de passe actuel de l'espace professeur est
  `Solution-4201P6EM`. Ne pas inscrire de jeton GitHub, de secret OAuth ou de
  clé privée dans le dépôt ou dans le JavaScript livré au navigateur.
- Tester localement dans Chrome avant toute proposition de PR ou de fusion.

## État actuel

- `web/src/data/solutions-defis.json` contient les 17 solutions de défis avec
  `publie: false` par défaut.
- `web/solutions-defis.js`, `web/docusaurus.config.js` et `web/sidebars.js`
  excluent du build les solutions de défis non publiées.
- Les 22 solutions de laboratoires restent visibles et inchangées.
- La page professeur est
  `web/src/pages/professeurs/solutions.tsx`.
- Elle valide déjà le mot de passe et permet de cocher les 17 défis.
- Sa publication actuelle copie le JSON puis ouvre l'éditeur GitHub. Ce flux
  doit être remplacé par l'authentification et la publication automatiques.
- La branche d'édition est transmise par le champ Docusaurus
  `customFields.brancheEdition`; pendant les tests elle doit être
  `solutionCacher`, puis `main` seulement après une éventuelle fusion autorisée.
- Le workflow d'aperçu compile correctement, mais GitHub Pages refuse le
  déploiement de `solutionCacher` à cause des règles de protection de
  l'environnement `github-pages`.

## Architecture retenue

Le fichier JSON du dépôt GitHub reste la source de données; aucune base de
données supplémentaire n'est nécessaire. Utiliser l'API GitHub Contents pour
lire le SHA courant et remplacer le fichier avec un commit sur la branche
configurée.

L'authentification doit être réellement liée au compte GitHub du professeur.
Une application GitHub/OAuth et un petit relais d'authentification sans base de
données peuvent être nécessaires pour protéger le secret OAuth. Ne jamais
embarquer un jeton d'écriture permanent dans le site statique. Si la
configuration externe GitHub manque, préparer tout le code testable et fournir
la courte procédure permettant au propriétaire de l'organisation de créer ou
d'autoriser l'application et de renseigner son identifiant.

## Vérifications avant de terminer

1. Une case cochée peut produire automatiquement un commit sur
   `solutionCacher`, sans ouvrir l'éditeur GitHub.
2. Une erreur d'authentification ou de permission affiche un message clair et
   ne modifie pas l'interface comme si la publication avait réussi.
3. Le JSON envoyé conserve exactement les 17 entrées attendues et ne permet
   pas de changer leur `id` ou leur chemin de fichier.
4. `npm run typecheck` réussit dans `web`.
5. `npm run build` réussit avec la configuration normale et avec
   `GITHUB_EDIT_BRANCH=solutionCacher`.
6. Les solutions de laboratoires sont encore présentes dans le build.
7. Le diff ne contient aucun secret et `git diff --check` réussit.
8. Le résultat est committé et poussé sur `origin/solutionCacher` seulement.


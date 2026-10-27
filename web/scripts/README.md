# Vérifier une correction du site

Le contrat d'un exercice est défini dans son énoncé : entrées acceptées,
résultats attendus, noms et signatures des méthodes, règles de calcul et cas
invalides. Le corrigé doit satisfaire ce même contrat. Une erreur volontaire
dans une question de compréhension ou de débogage doit rester identifiable
comme telle; elle ne doit pas être corrigée pour faire passer un compilateur.

Pour chaque correction, relever l'énoncé et le corrigé concernés, le problème,
le contrat retenu et la preuve obtenue. Une inspection de code, un calcul,
une compilation et une exécution sont des preuves différentes. Une traduction
temporaire de pseudo-code ne prouve pas le fonctionnement du projet étudiant.

## Contrôles reproductibles

Depuis `web` :

```sh
npm ci
npm run build
npm run typecheck
npm test
npm run audit:site
```

Le premier build génère notamment `sidebarDocs.js`, nécessaire au contrôle
TypeScript dans une copie fraîche du dépôt.

- `typecheck` contrôle les composants TypeScript.
- `test` couvre les quiz publiés, leur lecture et validation, les réponses
  invalides ou hors délai, les dates et la navigation du calendrier.
- `build` contrôle la construction des pages MDX et les liens Docusaurus.
- `audit:site` recherche les caractères NUL indésirables dans le HTML, les liens
  et ancres introuvables, les pages inaccessibles
  depuis l'accueil, les images et données JSON statiques sans référence, ainsi
  que certains résidus de rédaction.
  Il ignore les anciennes métadonnées dont la source ou l'ID courant a disparu.
  Ce contrôle ne valide pas les sites externes ni le sens des consignes.
  Il détecte aussi les lignes placées directement sous une table HTML sans
  section explicite (`tbody`/`thead`), qui font diverger le rendu React du DOM
  réorganisé par le navigateur.

Le plugin `html-integrity` retire des fichiers HTML générés les NUL insérés par
le rendu serveur de React 18 aux frontières de blocs UTF-8. Le test reproduit
une ancre et un texte accentués affectés, et vérifie que les images restent
identiques. Le contrôle final rejette tout NUL qui subsisterait. Voir le
[signalement Docusaurus](https://github.com/facebook/docusaurus/issues/9985).

Pour une validation finale, utiliser un dossier de build neuf, par exemple
`npm run build -- --out-dir <dossier-temporaire>`, puis
`python scripts/audit-site.py --build-dir <dossier-temporaire> --json <rapport.json>`.
Servir ce même build et vérifier le site dans le navigateur : menus et liens de
retour, code lisible et copiable, illustrations, quiz et affichage sur écran étroit.

## Gel avant le contre-audit

1. Tous les auteurs annoncent la fin des écritures sur leur périmètre.
2. Le coordinateur crée un manifeste hors du dépôt :
   `python scripts/freeze-site.py create <manifest.json>`.
   Le manifeste inclut les pages, composants, ressources statiques et projets
   sources de `code/` proposés en téléchargement. Les sorties compilées et les
   métadonnées générées pendant le build en sont exclues.
3. L'auditeur contrôle les sources et leurs preuves sans les modifier.
4. Vérifier `python scripts/freeze-site.py check <manifest.json>` avant le verdict.
5. Toute correction ultérieure invalide le gel : noter le défaut, appliquer une
   correction ciblée, recontrôler les cas concernés, puis créer un nouveau gel.

Relire séparément les changements de français et ceux qui touchent le code.
Éviter les remplacements globaux de syllabes pouvant modifier les identifiants.
Comparer les fichiers orphelins au contenu conservé avant de les supprimer.

## Limites des preuves

Les tests JavaScript et le build du site ne compilent ni n'exécutent les exemples
C#. Leur revue et leurs essais doivent être rapportés séparément. Si un antivirus
interrompt un essai, conserver la quarantaine et suspendre les binaires concernés;
ne pas créer d'exclusion ou déclarer un faux positif sans confirmation.

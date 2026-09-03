---
sidebar_position: 3
sidebar_label: Analyser un problème
slug: /defis/analyser-probleme
---

# Défi — Analyse : Le prêt d'équipement

## Avant de commencer

:::tip Tu peux commencer ce défi maintenant
Ce défi ne demande aucun code. Tu dois transformer un mandat en une analyse assez précise pour qu'une autre personne puisse ensuite programmer la solution.
:::

## Mandat à lire

Le centre sportif prête des raquettes à neige et des bâtons de marche. Une paire de raquettes coûte `6,00 $` par jour et un ensemble de bâtons coûte `9,00 $` par jour. L'application traite un prêt à la fois. Elle demande le type d'équipement, une durée de `1` à `7` jours et si la personne est membre du centre.

Une personne membre reçoit une réduction de `20 %` sur le coût de location. Un dépôt remboursable de `25,00 $` est ensuite ajouté au montant à payer. Le dépôt ne reçoit jamais de réduction. L'application doit afficher le coût de location avant réduction, la réduction, le dépôt et le total à payer. Si la durée est à l'extérieur de l'intervalle permis, elle affiche une erreur et ne présente aucun montant. Les conditions de retour sont déjà expliquées sur le site Web du centre.

## Travail d'analyse

Ne décris pas les instructions C# à utiliser. Analyse plutôt le fonctionnement attendu de l'application.

### 1. Définir le problème

Reformule en une phrase le service que l'application doit rendre.

### 2. Construire le contrat de l'application

| Élément | Ton analyse |
| --- | --- |
| Données reçues par l'application |  |
| Résultats produits |  |
| Règles de calcul |  |
| Valeurs refusées |  |
| Information qui ne fait pas partie de l'application |  |

### 3. Ordonner les résultats

Place les quatre éléments suivants dans l'ordre logique où ils doivent être déterminés. Justifie les deux étapes qui dépendent d'un résultat précédent.

- dépôt;
- coût de location avant réduction;
- total à payer;
- réduction.

### 4. Préparer des cas d'essai

Invente trois prêts différents. Tes cas doivent permettre de vérifier :

- une location sans réduction;
- une location avec réduction;
- une durée à la limite permise ou une durée invalide.

Pour chaque cas, écris les données utilisées et tous les résultats attendus.

### 5. Repérer ce qui manque

Trouve une situation que le mandat n'explique pas suffisamment. Écris la question précise que tu poserais à la personne responsable du centre.

## Production attendue

Ton analyse doit être assez claire pour qu'une autre personne puisse :

- connaître les données à demander;
- effectuer les calculs dans un ordre cohérent;
- reconnaître une valeur invalide;
- vérifier sa future application avec tes trois cas d'essai.

## Critères de réussite

- Chaque règle du mandat apparaît dans l'analyse.
- L'ordre proposé respecte la réduction et le dépôt.
- Les résultats des cas d'essai sont calculés avant la programmation.
- La question de clarification porte sur une véritable information manquante.

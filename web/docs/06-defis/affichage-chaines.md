---
sidebar_position: 10
sidebar_label: Affichage et chaînes
slug: /defis/affichage-chaines
---

# Défi — Affichage et chaînes : Billet de bienvenue

## Avant de commencer

:::tip Tu peux commencer ce défi si…
- tu sais afficher du texte avec `Console.WriteLine()`;
- tu sais créer une variable de type `string`;
- tu sais concaténer du texte avec l'opérateur `+`.

Si une notion te manque, révise le cours [Introduction](../01-cours/01-introduction.md).
:::

## Contexte

Une journée d'accueil est organisée pour les nouvelles personnes qui arrivent dans la technique. Tu dois créer un programme qui affiche un billet de bienvenue clair et agréable à lire dans la console.

Le billet est destiné à une personne précise : les valeurs du nom, du groupe, du local et de l'heure doivent être conservées dans des variables afin de pouvoir être facilement modifiées.

## Besoins

Ton programme doit afficher :

- un titre pour la journée d'accueil ;
- le nom de l'étudiant ou de l'étudiante ;
- son groupe ;
- le local du premier cours ;
- l'heure de début ;
- un court message d'encouragement.

Le résultat doit être encadré ou organisé de manière à ressembler à un vrai billet.

## Valeurs à utiliser

Pour la version de base, place dans des variables les valeurs de l'exemple : `Alex Tremblay`, groupe `1090`, local `B-321` et début `8 h 00`. Tu n'as pas à demander ces valeurs à la personne qui lance le programme.

## Notions à utiliser

- `Console.WriteLine()`;
- variables de type `string`;
- concaténation de texte avec l'opérateur `+`.

## Contraintes

- Utilise uniquement ce qui a été vu dans les premiers pas en C#.
- Le programme doit être lisible et chacune des informations doit apparaître sur une ligne appropriée.
- Utilise les libellés `Nom`, `Groupe`, `Local` et `Début`, dans cet ordre. Tu peux choisir les bordures et les espaces du billet.

## Exemple de résultat

**Valeurs placées dans les variables :** nom `Alex Tremblay`, groupe `1090`, local `B-321` et début `8 h 00`.

```text
====================================
     BIENVENUE EN TECHNIQUE INFO
====================================
Nom     : Alex Tremblay
Groupe  : 1090
Local   : B-321
Début   : 8 h 00

Bonne première journée !
```

## Critères de réussite

- Toutes les informations demandées sont présentes.
- L'affichage est bien organisé et facile à lire.
- Le programme démarre et se termine sans erreur.

## Tests manuels et résultats attendus

| Valeurs à utiliser | Résultat attendu |
| --- | --- |
| Nom `Alex Tremblay`, groupe `1090`, local `B-321`, début `8 h 00` | Le titre, les quatre lignes `Nom`, `Groupe`, `Local` et `Début`, puis le message d'encouragement apparaissent dans un seul billet lisible. |
| Nom `Mia`, groupe `1080`, local `B-321`, début `8 h 00` | Les lignes affichent `Nom : Mia`, `Groupe : 1080`, `Local : B-321` et `Début : 8 h 00`; le titre et le message demeurent présents. |

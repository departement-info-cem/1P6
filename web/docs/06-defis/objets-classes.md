---
sidebar_position: 150
sidebar_label: Objets et classes
slug: /defis/objets-classes
---

# Défi — Objets et classes : Compte de fidélité

## Avant de commencer

:::tip Tu peux commencer ce défi si…
- tu sais instancier un objet avec `new`;
- tu sais appeler un constructeur;
- tu sais utiliser les propriétés et les méthodes d'un objet.

Si une notion te manque, révise le cours [Introduction à la programmation orientée objet](../01-cours/25-poo.md).
:::

## Contexte

Une boutique veut offrir un programme de fidélité. Le projet de départ contient déjà la classe `CompteFidelite`, qui représente un compte et protège son solde de points. Ton travail consiste à créer et à utiliser un objet de cette classe dans une application console.

### Télécharger le projet de départ

<GithubDownload
  repo="1P6"
  folder="code/defis/DefiObjetsClasses-CompteFidelite"
  label="📁 Défi - Objets et classes - Compte de fidélité"
/>

Télécharge le projet, extrais-le, puis ouvre `CompteFidelite.sln` dans Visual Studio. La classe est complète; ne la modifie pas.

## Besoins

Complète le programme afin de :

- créer un seul objet `CompteFidelite` au nom de `Maya`;
- afficher le nom et le nombre de points de l'objet;
- présenter un menu permettant d'ajouter des points, d'échanger des points ou de quitter;
- lire et valider le nombre de points demandé;
- appeler la méthode appropriée sur l'objet;
- afficher le résultat de chaque action et le nouveau solde de points;
- répéter le menu jusqu'à ce que l'utilisateur choisisse de quitter.

## Valeurs et classe fournies

La classe expose exactement les membres suivants :

- le constructeur `CompteFidelite(string nom)`;
- les propriétés en lecture `Nom` et `Points`;
- `AjouterPoints(int nombrePoints)`, qui retourne `true` seulement lorsque le nombre est supérieur à `0`;
- `EchangerPoints(int nombrePoints)`, qui retourne `true` seulement lorsque le nombre est supérieur à `0` et ne dépasse pas le solde.

Le solde initial est toujours `0` et il ne peut pas être modifié directement depuis le programme principal.

## Notions à utiliser

- instanciation avec `new`;
- constructeur, propriétés et méthodes d'un objet;
- objet conservé dans une variable locale;
- `switch`, boucle `while` ou `do while` et `TryParse`.

## Contraintes

- Ne modifie pas la classe `CompteFidelite`.
- Ne reproduis pas les règles de points dans le programme principal : utilise les valeurs retournées par les méthodes de l'objet.
- Si la saisie n'est pas un entier, affiche `Entrez un nombre entier de points.`.
- Après un ajout, affiche `Ajout effectué.` ou `Ajout refusé.`.
- Après un échange, affiche `Échange effectué.` ou `Échange refusé.`.
- Après chaque action, le solde affiché doit correspondre à la propriété `Points` de l'objet.

## Exemple de résultat

```text
Compte : Maya
Points disponibles : 0

1 - Ajouter des points
2 - Échanger des points
3 - Quitter
Choix : 1
Nombre de points : 100
Ajout effectué.
Points disponibles : 100

1 - Ajouter des points
2 - Échanger des points
3 - Quitter
Choix : 2
Nombre de points : 30
Échange effectué.
Points disponibles : 70
```

## Critères de réussite

- Un seul objet `CompteFidelite` est créé et conservé pendant toute l'exécution.
- Le programme utilise le constructeur, les propriétés et les méthodes fournis.
- Le menu reste disponible jusqu'au choix `3 - Quitter`.
- L'affichage demeure synchronisé avec l'état réel de l'objet.

## Tests manuels et résultats attendus

Effectue les tests dans l'ordre, à partir d'une nouvelle exécution de l'application.

| Action et valeur à saisir | Résultat attendu |
| --- | --- |
| Démarrer l'application | `Compte : Maya`, puis `Points disponibles : 0` et le menu. |
| Choisir `1`, puis saisir `100` | `Ajout effectué.` et `Points disponibles : 100`. |
| Choisir `2`, puis saisir `30` | `Échange effectué.` et `Points disponibles : 70`. |
| Choisir `2`, puis saisir `80` | `Échange refusé.` et `Points disponibles : 70`. |
| Choisir `1`, puis saisir `-10` | `Ajout refusé.` et `Points disponibles : 70`. |
| Choisir `1`, puis saisir `bonjour` | `Entrez un nombre entier de points.` et `Points disponibles : 70`. |
| Choisir `9` | `Choix invalide.` et le menu est affiché de nouveau. |
| Choisir `3` | `Au revoir!`, puis l'application se termine. |

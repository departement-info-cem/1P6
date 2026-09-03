---
sidebar_position: 60
sidebar_label: Boucle for
slug: /defis/boucle-for
---

# Défi — Boucle `for` : Préparation de trousses d'accueil

## Avant de commencer

:::tip Tu peux commencer ce défi si…
- tu sais répéter une instruction avec une boucle `for`;
- tu sais utiliser une variable d'accumulation;
- tu sais valider une valeur avec une condition.

Si une notion te manque, révise le cours [Boucles `for`](../01-cours/08-for.md).
:::

## Contexte

Le comité d'accueil prépare des trousses pour les nouvelles personnes inscrites. Chaque trousse contient le même nombre d'articles. Le comité veut afficher le nombre d'articles préparés après chaque trousse afin de suivre sa progression. Par exemple, avec `4` articles par trousse, la deuxième trousse correspond à `8` articles préparés au total.

## Besoins

Crée une application console qui demande :

- le nombre d'articles dans une trousse ;
- le nombre de trousses à préparer.

Le programme doit afficher un tableau indiquant le numéro de chaque trousse et le nombre d'articles cumulés. Il doit ensuite afficher le nombre total d'articles préparés.

## Valeurs à utiliser

Le nombre d'articles par trousse et le nombre de trousses sont des entiers supérieurs à `0`.

## Notions à utiliser

- boucle `for`;
- variable d'accumulation;
- conditions déjà vues pour vérifier les valeurs positives.

## Contraintes

- Utilise une boucle `for` pour produire le tableau.
- Ajoute le nombre d'articles de chaque nouvelle trousse à une variable d'accumulation.
- Les valeurs saisies doivent être positives.
- Si une valeur est nulle ou négative, affiche `Les valeurs doivent être supérieures à 0.` et n'affiche pas le tableau.
- La mise en forme doit permettre de lire facilement les colonnes.

## Exemple de résultat

**Entrées saisies :** `4` articles par trousse et `4` trousses à préparer.

```text
Trousse    Articles cumulés
1          4
2          8
3          12
4          16

Total d'articles préparés : 16
```

## Critères de réussite

- Une ligne est affichée pour chaque trousse.
- Le nombre d'articles cumulés et le total sont exacts.
- Les données invalides sont signalées clairement.

## Tests manuels et résultats attendus

| Articles par trousse | Nombre de trousses | Résultat attendu |
| ---: | ---: | --- |
| 4 | 4 | Quatre lignes avec 4, 8, 12 et 16 articles cumulés, puis `Total d'articles préparés : 16`. |
| 6 | 1 | Une ligne avec 6 articles cumulés, puis `Total d'articles préparés : 6`. |
| 0 | 4 | `Les valeurs doivent être supérieures à 0.`; aucun tableau ni total n'est affiché. |
| 4 | -1 | `Les valeurs doivent être supérieures à 0.`; aucun tableau ni total n'est affiché. |

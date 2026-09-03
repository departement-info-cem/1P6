---
sidebar_position: 20
sidebar_label: Variables et calculs
slug: /defis/variables-calculs
---

# Défi — Variables et calculs : Coût des brochures

## Avant de commencer

:::tip Tu peux commencer ce défi si…
- tu sais déclarer des variables `int` et `double`;
- tu sais lire et convertir une valeur saisie;
- tu sais effectuer un calcul et conserver son résultat.

Si une notion te manque, révise le cours [Variables et opérations](../01-cours/02-variables.md).
:::

## Contexte

Le comité étudiant prépare une activité et doit faire imprimer des brochures. L'imprimerie facture chaque page imprimée. Tu dois créer un petit programme qui calcule le coût de la commande.

Pour simplifier l'exercice, toutes les brochures ont le même nombre de pages et le prix par page est le même pour toute la commande. Les valeurs saisies seront valides : il n'est pas nécessaire de traiter les erreurs ou les cas particuliers.

## Besoins

Ton application console doit demander :

- le nombre de brochures à imprimer ;
- le nombre de pages par brochure ;
- le prix d'une page.

Elle doit ensuite afficher :

- le nombre total de pages imprimées ;
- le coût total de la commande.

Utilise les calculs suivants :

1. `pages imprimées = nombre de brochures × pages par brochure`;
2. `coût total = pages imprimées × prix d'une page`.

## Valeurs à utiliser

Le nombre de brochures et le nombre de pages par brochure sont des entiers supérieurs à `0`. Le prix par page est un nombre décimal supérieur à `0`, par exemple `0,15`.

## Notions à utiliser

- variables `int` et `double`;
- lecture d'une valeur avec `Console.ReadLine()` et conversion avec `int.Parse()` ou `double.Parse()`;
- multiplication et affectation du résultat dans une variable.

## Contraintes

- Utilise des variables de types appropriés, notamment `int` pour les quantités et `double` pour le prix.
- Utilise `Console.ReadLine()` et la conversion nécessaire pour lire les valeurs.
- Affiche les montants suivis du symbole `$`. À cette séance, `1,2 $` et `1,20 $` sont deux affichages acceptés pour le même montant.
- N'utilise pas encore de conditions, de boucles ou de fonctions : le défi porte sur les variables et les opérations.

## Analyse avant de coder — lecture guidée

1. Résume en une phrase le calcul que l'imprimerie veut automatiser.
2. Complète le tableau sans écrire de code.

| Élément à repérer | Ta réponse |
| --- | --- |
| Trois valeurs saisies |  |
| Deux résultats calculés |  |
| Valeurs que le défi considère toujours valides |  |
| Notions que tu ne dois pas utiliser |  |

3. Réécris les deux calculs avec tes propres mots, sans utiliser les formules déjà données.
4. Prévois le résultat pour `3` brochures de `4` pages à `0,10 $` la page.
5. Invente un autre cas d'essai et calcule son résultat attendu avant de programmer.

## Exemple de résultat

**Entrées saisies :** `4` brochures, `2` pages par brochure et `0,15` par page.

```text
Nombre de brochures : 4
Pages par brochure : 2
Prix par page : 0,15

Pages imprimées : 8
Coût total : 1,2 $
```

## Critères de réussite

- Les trois valeurs sont demandées et conservées dans des variables.
- Le nombre total de pages est exact.
- Le coût total est exact.
- Les unités et les montants sont clairement affichés.

## Tests manuels et résultats attendus

| Brochures | Pages par brochure | Prix par page | Résultat attendu |
| ---: | ---: | ---: | --- |
| 4 | 2 | 0,15 | `Pages imprimées : 8` et `Coût total : 1,2 $` ou `1,20 $` |
| 10 | 1 | 0,20 | `Pages imprimées : 10` et `Coût total : 2 $` ou `2,00 $` |
| 2 | 2 | 0,15 | `Pages imprimées : 4` et `Coût total : 0,6 $` ou `0,60 $` |

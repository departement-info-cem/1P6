---
sidebar_position: 70
sidebar_label: Tableaux 1D
slug: /defis/tableaux-1d
---

# Défi — Tableaux 1D : Bilan des températures

## Avant de commencer

:::tip Tu peux commencer ce défi si…
- tu sais créer un tableau à une dimension;
- tu sais parcourir un tableau avec une boucle `for`;
- tu sais utiliser la propriété `Length` et un indice.

Si une notion te manque, révise les cours [Tableaux 1D](../01-cours/07-tableaux1d.md) et [Boucles `for`](../01-cours/08-for.md).
:::

## Contexte

Une station météo a enregistré les températures maximales des sept derniers jours, du jour 1 au jour 7. Tu dois produire un bilan simple de la semaine.

## Besoins

Ton programme doit afficher :

- chaque journée avec sa température ;
- la température la plus basse et la plus haute ;
- la moyenne de la semaine ;
- le nombre de journées de 20 °C ou plus, la limite de 20 °C étant incluse ;
- le numéro de la première journée ayant la température maximale. Si plusieurs journées ont la même température maximale, conserve la première rencontrée.

## Valeurs à utiliser

Utilise exactement le tableau suivant, dans cet ordre du jour 1 au jour 7 : `18, 21, 17, 23, 25, 20, 16`. Les températures sont des entiers en degrés Celsius. Affiche la moyenne avec deux décimales.

## Notions à utiliser

- tableau 1D de nombres;
- boucle `for` et propriété `Length`;
- variables d'accumulation, minimum et maximum.

## Contraintes

- Utilise un tableau 1D et une ou plusieurs boucles `for`.
- N'écris pas les sept températures une à une dans les calculs.
- Les résultats doivent être obtenus à partir du contenu du tableau.

## Exemple de résultat

**Données de départ :** tableau de températures `18, 21, 17, 23, 25, 20, 16`.

```text
Jour 1 : 18 °C
Jour 2 : 21 °C
Jour 3 : 17 °C
Jour 4 : 23 °C
Jour 5 : 25 °C
Jour 6 : 20 °C
Jour 7 : 16 °C

Température minimale : 16 °C
Température maximale : 25 °C
Moyenne de la semaine : 20,00 °C
Journées de 20 °C ou plus : 4
Première journée la plus chaude : jour 5
```

## Critères de réussite

- Le tableau est parcouru correctement.
- Les statistiques correspondent aux données.
- Le programme reste correct si les températures changent.

## Tests manuels et résultats attendus

| Valeurs du tableau (jours 1 à 7) | Résultat attendu |
| --- | --- |
| `18, 21, 17, 23, 25, 20, 16` | Les sept lignes `Jour` sont affichées; minimum : 16 °C; maximum : 25 °C; moyenne : 20,00 °C; 4 journées de 20 °C ou plus; première journée la plus chaude : jour 5. |
| `20, 20, 20, 20, 20, 20, 20` | Les sept journées affichent 20 °C; minimum et maximum : 20 °C; moyenne : 20,00 °C; 7 journées de 20 °C ou plus; première journée la plus chaude : jour 1. |

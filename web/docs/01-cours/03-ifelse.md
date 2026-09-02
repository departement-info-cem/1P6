---
description: Trace d'exécution et intègration
---



# 🤔 Trace d'exécution et intègration

---

## 🏆 QUIZ de révision 
<Quiz file="/quiz/2.1-base.json" />

## 🎯 Objectif

Réaliser une trace d'exécution afin de suivre l'évolution des variables et comprendre le comportement d'un programme.

---
## Trace d'exécution
Une trace d'exécution consiste à suivre le programme instruction par instruction en notant l'évolution des variables.

C'est un peu comme suivre une recette de cuisine étape par étape pour voir comment les ingrédients se transforment jusqu'au résultat final.

À quoi sert une trace d'exécution ?

La trace d'exécution permet de :

* Comprendre le fonctionnement d'un programme.
* Vérifier qu'un algorithme produit le résultat attendu.
* Trouver des erreurs de logique.
* Prévoir le résultat d'un programme sans l'exécuter.
* **Développer sa capacité à raisonner comme un programmeur**.

:::tip
👉 Vous pouvez imprimer ce tableau de trace d'exécution pour pratiquer vos traces à la main.
:::
### Exemple simple


#### Programme
```csharp
1. int nombre = 18;
2. nombre = nombre + 2;
3. Console.WriteLine("Nombre  = " + nombre);
```
#### Trace d'exécution

| Ligne exécutée | age | Affichage |
| -------------- | --- | --------- |
| 1              | 18  |                         | 
| 2              | 20  |                        | 
| 3              | 20  |    Nombre : 20       |               
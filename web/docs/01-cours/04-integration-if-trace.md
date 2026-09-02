---
description: Intègration `if` et trace d'exécution
---



# 🤔 Intègration `if` et trace d'exécution

---

## 🏆 QUIZ de révision 
<Quiz file="/quiz/2.1-base.json" />

## 🎯 Objectif

Réaliser une trace d'exécution afin de suivre l'évolution des variables et comprendre le comportement d'un programme.

---
## Trace d'exécution
Une trace d'exécution consiste à suivre le programme instruction par instruction en notant l'évolution des variables.


## À quoi sert une trace d'exécution ?

La trace d'exécution permet de :

* Comprendre le fonctionnement d'un programme.
* Vérifier qu'un algorithme produit le résultat attendu.
* Trouver des erreurs de logique.
* Prévoir le résultat d'un programme sans l'exécuter.
* **Développer sa capacité à raisonner comme un programmeur**.

:::tip
👉 Vous pouvez imprimer ce tableau de trace d'exécution pour pratiquer vos traces à la main.
:::


### Exemple 1 — Code avec instructions simples

```csharp
1. int a = 10;
2. int b = 20;
3. int temp = a;
4. a = b;
5. b = temp;
```

| Instruction exécutée | `a` | `b` | `temp` |
| -------------------: | --: | --: | -----: |
|                    1 |  10 |   — |      — |
|                    2 |  10 |  20 |      — |
|                    3 |  10 |  20 |     10 |
|                    4 |  20 |  20 |     10 |
|                    5 |  20 |  10 |     10 |


### Exemple 2 — Code avec affichage sur la console

```csharp
1. int prix = 25;
2. int quantite = 3;
3. int total = prix * quantite;
4. Console.WriteLine($"Total : {total}");
```

**Trace d'exécution :**

| Instruction exécutée | `prix` | `quantite` | `total` | Affichage |
| -------------------: | -----: | ---------: | ------: | :-------: |
|                    1 |     25 |          — |       — |     —     |
|                    2 |     25 |          3 |       — |     —     |
|                    3 |     25 |          3 |      75 |     —     |
|                    4 |     25 |          3 |      75 |     Total : 75    |



### Exemple 3 — Code avec `if`

```csharp
1. int age = 20;
2. int score = 0;
3.
4. if (age >= 18)
5. {
6.     score = score + 10;
7. }
```

**Trace d'exécution :**

| Instruction exécutée | `age` | `score` |
| -------------------: | ----: | ------: |
|                    1 |    20 |       — |
|                    2 |    20 |       0 |
|                    4 |    20 |       0 |
|                    6 |    20 |      10 |

### Exemple 4 — Code avec `if` imbriquée

```csharp
1. int vie = 100;
2. int potions = 2;
3. bool estEmpoisonne = true;
4.
5. if (vie > 0)
6. {
7.     vie = vie - 20;
8.
9.     if (estEmpoisonne)
10.    {
11.        vie = vie - 10;
12.        potions = potions - 1;
13.    }
14. }
```

**Trace d'exécution :**

| Instruction exécutée | `vie` | `potions` | `estEmpoisonne` |
| -------------------: | ----: | --------: | :-------------: |
|                    1 |   100 |         — |        —        |
|                    2 |   100 |         2 |        —        |
|                    3 |   100 |         2 |      `true`     |
|                    5 |   100 |         2 |      `true`     |
|                    7 |    80 |         2 |      `true`     |
|                    9 |    80 |         2 |      `true`     |
|                   11 |    70 |         2 |      `true`     |
|                   12 |    70 |         1 |      `true`     |


Vous devez réaliser les labos suivants :
 [🧪 Labo 2.2A](/laboratoire/laboratoire2.2A)
 [🧪 Labo 2.2B](/laboratoire/laboratoire2.2B)
---
description: Débogueur de Visual Studio, points d'arrêt et trace d'exécution
---

# 🐞 Débogage et trace d'exécution

## 🎯 Objectif

Utiliser le **débogueur de Visual Studio** de façon systématique et réaliser une **trace d'exécution** pour comprendre et corriger un programme qui contient des boucles et des tableaux.

Jusqu'ici, tu as surtout tracé du code **simple** (variables, `if`) au [cours 2.2](/cours/integration-if-trace). Maintenant que tes programmes contiennent des **boucles `for` imbriquées** et des **tableaux 2D**, les lire de haut en bas ne suffit plus : il faut **observer** le programme pendant qu'il s'exécute.

---

## 1️⃣ Les trois familles d'erreurs

Avant de déboguer, il faut savoir **quel type d'erreur** on a devant soi.

| Type d'erreur | Quand ? | Exemple | Comment la trouver ? |
| --- | --- | --- | --- |
| **Compilation** (syntaxe) | Avant l'exécution | `Consol.WriteLine(...)`, `;` manquant | Visual Studio le souligne en rouge et refuse de compiler |
| **Exécution** (exception) | Pendant l'exécution | `IndexOutOfRangeException`, `FormatException` | Le programme **plante** et Visual Studio s'arrête sur la ligne fautive |
| **Logique** | Pendant l'exécution | Le total affiché est 0, la grille est décalée | ❗ Le programme fonctionne, mais le résultat est **faux** → c'est ici que le débogueur devient indispensable |

:::danger L'erreur de logique ne se signale jamais toute seule
Un programme qui compile et qui ne plante pas n'est **pas** un programme correct. C'est toi qui dois vérifier que le résultat est le bon.
:::

---

## 2️⃣ La boîte à outils du débogueur

### 🔴 Le point d'arrêt (*breakpoint*)

Un **point d'arrêt** dit au programme : « arrête-toi **juste avant** d'exécuter cette ligne ».

* Clique dans la **marge grise** à gauche du numéro de ligne, ou appuie sur `F9`.
* Un cercle rouge apparaît. Lance le programme avec `F5` : il s'arrête sur la ligne (surlignée en jaune).
* La ligne jaune n'est **pas encore exécutée**.

:::tip Où placer son premier point d'arrêt ?
Sur la **première ligne du bloc que tu soupçonnes**, pas au tout début de `Main`. Si le total d'une boucle est faux, place-le sur la ligne de la boucle, pas 40 lignes plus haut.
:::

### ⌨️ Les touches pour avancer

| Touche | Nom | Ce que ça fait |
| --- | --- | --- |
| `F5` | Continuer | Repart et court jusqu'au **prochain** point d'arrêt |
| `F10` | Pas à pas **principal** (*Step Over*) | Exécute la ligne courante **au complet** et s'arrête à la suivante |
| `F11` | Pas à pas **détaillé** (*Step Into*) | **Entre à l'intérieur** de la fonction appelée sur cette ligne |
| `Maj + F11` | Pas à pas **sortant** (*Step Out*) | Termine la fonction courante et revient à l'appelant |
| `Maj + F5` | Arrêter | Termine la session de débogage |

:::info `F10` ou `F11` ?
Utilise `F10` pour parcourir ton code ligne par ligne. Utilise `F11` seulement quand tu veux voir **ce qui se passe dans une de tes fonctions**. Sur un `Console.WriteLine(...)`, `F11` ne sert à rien : c'est du code de Microsoft.
:::

### 👀 Observer les variables

Pendant que le programme est arrêté, plusieurs façons de voir les valeurs :

* **Survoler** une variable avec la souris → une infobulle affiche sa valeur.
* Fenêtre **Variables locales** (*Locals*) → **toutes** les variables du bloc courant.
* Fenêtre **Automatique** (*Autos*) → seulement les variables des lignes autour.
* Fenêtre **Espion** (*Watch*) → tu y ajoutes **ce que tu veux suivre**, y compris une *expression*.

:::tip L'espion est ton meilleur ami avec les tableaux
Dans la fenêtre **Espion**, tu peux écrire une expression complète et la voir se mettre à jour à chaque `F10` :

* `grille[rangee, colonne]` → la case courante
* `grille.GetLength(0)` → le nombre de rangées
* `total / nbNotes` → vérifier un calcul **avant** qu'il soit faux

Menu : *Déboguer → Fenêtres → Espion → Espion 1* (`Ctrl + Alt + W`, `1`).
:::

### 🔀 Déplier un tableau

Dans **Variables locales**, clique sur la ▸ à gauche d'un tableau pour voir **toutes ses cases**. Pour un tableau 2D, les cases sont affichées sous la forme `[0, 0]`, `[0, 1]`, `[1, 0]`… C'est le moyen le plus rapide de voir qu'une rangée est restée vide (`0` partout).

---

## 3️⃣ Trace d'exécution d'une boucle

La **trace d'exécution** est la version **papier** du débogueur : on suit le programme instruction par instruction en notant l'évolution des variables. Tu en as besoin à l'examen, où il n'y a pas de Visual Studio.

### Exemple 1 — Boucle `for` avec accumulateur

```csharp
1. int[] notes = { 80, 90, 70 };
2. int total = 0;
3. for (int i = 0; i < notes.Length; i++)
4. {
5.     total = total + notes[i];
6. }
7. Console.WriteLine(total);
```

| Instruction exécutée | `i` | `notes[i]` | `total` | Affichage |
| -------------------: | --: | ---------: | ------: | :-------: |
|                    2 |   — |          — |       0 |     —     |
|                    3 |   0 |         80 |       0 |     —     |
|                    5 |   0 |         80 |      80 |     —     |
|                    3 |   1 |         90 |      80 |     —     |
|                    5 |   1 |         90 |     170 |     —     |
|                    3 |   2 |         70 |     170 |     —     |
|                    5 |   2 |         70 |     240 |     —     |
|                    3 |   3 |      ❌ n/a |     240 |     —     |
|                    7 |   3 |          — |     240 |    240    |

:::note Le dernier tour compte
Remarque l'avant-dernière ligne : `i` vaut **3**, le test `i < 3` est **`false`**, on **sort** de la boucle. C'est exactement ce que tu verras en appuyant sur `F10` une fois de trop.
:::

### Exemple 2 — Boucles imbriquées sur un tableau 2D

```csharp
1. int[,] grille = { { 1, 2 },
                     { 3, 4 } };
2. int somme = 0;
3. for (int rangee = 0; rangee < grille.GetLength(0); rangee++)
4. {
5.     for (int colonne = 0; colonne < grille.GetLength(1); colonne++)
6.     {
7.         somme = somme + grille[rangee, colonne];
8.     }
9. }
```

| Instruction exécutée | `rangee` | `colonne` | `grille[rangee, colonne]` | `somme` |
| -------------------: | -------: | --------: | ------------------------: | ------: |
|                    2 |        — |         — |                         — |       0 |
|                    3 |        0 |         — |                         — |       0 |
|                    5 |        0 |         0 |                         1 |       0 |
|                    7 |        0 |         0 |                         1 |       1 |
|                    5 |        0 |         1 |                         2 |       1 |
|                    7 |        0 |         1 |                         2 |       3 |
|                    5 |        0 |         2 |                    ❌ n/a |       3 |
|                    3 |        1 |         — |                         — |       3 |
|                    5 |        1 |         0 |                         3 |       3 |
|                    7 |        1 |         0 |                         3 |       6 |
|                    5 |        1 |         1 |                         4 |       6 |
|                    7 |        1 |         1 |                         4 |      10 |
|                    5 |        1 |         2 |                    ❌ n/a |      10 |
|                    3 |        2 |         — |                         — |      10 |

:::tip La boucle intérieure repart à zéro
`colonne` est **redéclarée à 0** à chaque tour de la boucle extérieure. La boucle intérieure fait donc **tous** ses tours pour **chaque** rangée : 2 rangées × 2 colonnes = **4** passages par la ligne 7.
:::

---

## 4️⃣ Les bogues classiques (et comment les repérer)

### ❌ `IndexOutOfRangeException`

```csharp
int[] notes = { 80, 90, 70 };
for (int i = 0; i <= notes.Length; i++)   // 💥 <= au lieu de <
{
    Console.WriteLine(notes[i]);
}
```

Un tableau de **3** éléments a les indices **0, 1, 2**. Avec `<=`, on essaie de lire `notes[3]` → 💥

👉 **Au débogueur** : le programme s'arrête sur la ligne fautive. Survole `i` et `notes.Length` : tu verras `3` et `3`.

### ❌ Les dimensions inversées

```csharp
for (int rangee = 0; rangee < grille.GetLength(1); rangee++)   // 💥 (1) au lieu de (0)
```

Sur une grille **carrée** (3 × 3), ce bogue ne plante **jamais** et ne se voit pas. Sur une grille 2 × 5, il plante ou saute des cases.

👉 **Au débogueur** : ajoute `grille.GetLength(0)` **et** `grille.GetLength(1)` dans la fenêtre **Espion**.

### ❌ L'accumulateur réinitialisé dans la boucle

```csharp
for (int i = 0; i < notes.Length; i++)
{
    int total = 0;              // 💥 remis à 0 à chaque tour
    total = total + notes[i];
}
```

👉 **Au débogueur** : place un point d'arrêt sur la ligne du `total` et appuie sur `F10` plusieurs fois. Tu verras `total` **retomber à 0** à chaque tour au lieu de grandir.

### ❌ Le `WriteLine` au mauvais endroit

Un affichage **dans** la boucle intérieure au lieu de la boucle extérieure (ou l'inverse) donne une grille en une seule colonne, ou toutes les valeurs collées sur une ligne.

👉 **Au débogueur** : `F10` pas à pas en gardant la fenêtre **Console** visible à côté de Visual Studio pour voir **quand** chaque caractère est écrit.

---

## 5️⃣ Une méthode en 5 étapes

Devant un programme qui ne fonctionne pas, ne modifie pas le code au hasard 🎲

1. **Reproduire** — quelles entrées provoquent le problème, à tous les coups ?
2. **Situer** — quelle est la **dernière** ligne dont tu es certain qu'elle est correcte ? Place ton point d'arrêt là.
3. **Formuler une hypothèse** — « je pense que `colonne` ne revient pas à 0 ».
4. **Vérifier** — `F10` pas à pas, en lisant les **Variables locales** ou l'**Espion**. L'hypothèse est confirmée ou éliminée.
5. **Corriger, puis retester** — et relancer aussi les cas qui fonctionnaient **avant** la correction.

:::danger Ne devine pas, mesure
« Ça devrait marcher » n'est pas un diagnostic. Le débogueur te donne la **vraie** valeur de chaque variable : sers-t'en au lieu de supposer.
:::

---

Vous devez réaliser le laboratoire suivant :

* [🧪 Labo 7.2](/laboratoire/laboratoire7.2)

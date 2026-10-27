---
title: "✅ Solutions — Laboratoire 7.2"
---

# ✅ Solutions — Laboratoire 7.2

[Retour au laboratoire 7.2](/laboratoire/laboratoire7.2)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

## Partie A — Traces d'exécution

Chaque ligne ci-dessous décrit un passage dans le corps de la boucle. La dernière vérification fausse est ajoutée séparément; elle n'exécute pas le corps.

### A1 — Accumulateur

| `i` | `total` après addition |
| ---: | ---: |
| 1 | 1 |
| 2 | 3 |
| 3 | 6 |
| 4 | 10 |
| 5 | Condition `i <= 4` fausse |

La ligne 4 est exécutée quatre fois. La dernière valeur testée de `i` est `5`, mais sa portée se termine avec la boucle. Affichage : `10`.

### A2 — Incrément de 2

| `i` | `valeurs[i]` | `somme` après addition |
| ---: | ---: | ---: |
| 0 | 5 | 5 |
| 2 | 15 | 20 |
| 4 | Aucun accès : condition fausse | 20 |

Les indices `0` et `2` sont visités; `1` et `3` sont sautés. Affichage : `20`.

### A3 — Maximum

Au départ, `max = 72` et `position = 0`.

| `i` | `notes[i]` | `notes[i] > max` | `max` après le test | `position` |
| ---: | ---: | --- | ---: | ---: |
| 1 | 95 | Vrai | 95 | 1 |
| 2 | 60 | Faux | 95 | 1 |
| 3 | 88 | Faux | 95 | 1 |
| 4 | Aucun accès : condition fausse | — | 95 | 1 |

La ligne 8 s'exécute seulement pour `i = 1`. L'indice `0` a déjà servi à initialiser le maximum. Affichage : `95 à la position 1`.

### A4 — Somme par rangée

| `r` | `c` | Case | `sommeRangee` après addition |
| ---: | ---: | ---: | ---: |
| 0 | 0 | 2 | 2 |
| 0 | 1 | 4 | 6 |
| 0 | 2 | 6 | 12 |
| 0 | 3 | Condition interne fausse | 12 |
| 1 | 0 | 1 | 1 |
| 1 | 1 | 3 | 4 |
| 1 | 2 | 5 | 9 |
| 1 | 3 | Condition interne fausse | 9 |
| 2 | — | Condition externe fausse | — |

La ligne 7 s'exécute six fois; l'initialisation de la ligne 4, deux fois. Affichage : `12`, puis `9`, chacun sur sa ligne. Si l'accumulateur était déclaré avant la boucle externe, il conserverait le total précédent et afficherait `12`, puis `21`.

### A5 — Parcours par colonne

`GetLength(0) = 3` et `GetLength(1) = 2`. L'ordre est `[0,0]`, `[1,0]`, `[2,0]`, `[0,1]`, `[1,1]`, `[2,1]`. Pour chaque colonne, la boucle interne termine au test `r = 3`; la boucle externe termine au test `c = 2`.

```text
1 3 5
2 4 6
```

Un espace suit aussi chaque dernier nombre, car le code utilise `Console.Write(valeur + " ")`.

### A6 — Appels de fonction

| `i` | `valeur` avant l'appel | Paramètre `n` | `resultat` / retour | `total` après addition | `valeur` après incrément |
| ---: | ---: | ---: | ---: | ---: | ---: |
| 0 | 3 | 3 | 6 | 6 | 4 |
| 1 | 4 | 4 | 8 | 14 | 5 |
| 2 | 5 | 5 | 10 | 24 | 6 |
| 3 | 6 | Aucun appel : condition fausse | — | 24 | 6 |

Trois appels reçoivent `3`, `4` et `5`. La variable locale `resultat` cesse d'exister à la fin de chaque appel; le suivant crée sa propre variable. Affichage : `24`.

### A7 — Bogue dans la somme

| `i` | `temperatures[i]` | `somme` affectée | `moyenne` entière |
| ---: | ---: | ---: | ---: |
| 0 | 12 | 12 | 3 |
| 1 | 18 | 18 | 4 |
| 2 | 25 | 25 | 6 |
| 3 | 21 | 21 | 5 |
| 4 | Condition fausse | 21 | 5 |

Le programme affiche `5`. La somme est remplacée à chaque tour. Remplacer la ligne 6 par `somme = somme + temperatures[i];` donne successivement les sommes `12`, `30`, `55`, `76` et les moyennes `3`, `7`, `13`, `19`. Pour ne calculer la moyenne qu'une fois, placer la ligne 7 après la boucle et avant l'affichage.

```csharp
int[] temperatures = { 12, 18, 25, 21 };
int somme = 0;
for (int i = 0; i < temperatures.Length; i++)
    somme += temperatures[i];
int moyenne = somme / temperatures.Length;
Console.WriteLine(moyenne); // 19
```

## Partie B — Observer avec le débogueur

Ces valeurs sont les résultats de référence à comparer aux fenêtres du débogueur. Les commandes `F10` et `F11` se pratiquent dans Visual Studio.

### B1 — Stock

Le point d'arrêt est placé **avant** l'addition.

| Arrêt | `entrepot` | `produit` | Case | `totalUnites` avant | `nbRuptures` avant |
| ---: | ---: | ---: | ---: | ---: | ---: |
| 1 | 0 | 0 | 4 | 0 | 0 |
| 2 | 0 | 1 | 0 | 4 | 0 |
| 3 | 0 | 2 | 7 | 4 | 1 |
| 4 | 0 | 3 | 2 | 11 | 1 |
| 5 | 1 | 0 | 0 | 13 | 1 |
| 6 | 1 | 1 | 9 | 13 | 2 |
| 7 | 1 | 2 | 0 | 22 | 2 |
| 8 | 1 | 3 | 5 | 22 | 3 |

Huit arrêts; dimensions `2` et `4`; `Length = 8`, soit leur produit. Le cinquième arrêt commence la deuxième rangée. Affichage final : `Unités : 27`, puis `Ruptures : 3`.

### B2 — Fonction Mystere

Au premier appel, `a = 1`, `b = 1`. Les retours sont `2`, `6`, `12`, `20`, `30`, `42`; les totaux cumulés sont `2`, `8`, `20`, `40`, `70`, `112`. La méthode ajoute `a` à la valeur initiale `a`, `b` fois : elle calcule `a × (b + 1)` pour les `b` positifs ou nuls utilisés ici. Affichage final : `112`.

`F10` passe l'appel en une étape; `F11` entre dans la méthode; `Maj + F11` en ressort. Entrer dans `Console.WriteLine` ne renseigne pas sur le calcul de `Mystere`, car il s'agit de l'affichage fourni par la bibliothèque.

### B3 — Cases non remplies

Les cases `[0,3]`, `[1,3]`, `[2,3]` restent à `0`. La condition `siege < 3` doit devenir `siege < plan.GetLength(1)`. Les cases d'un tableau d'entiers sont initialisées à `0` lors de sa création.

Après correction :

```text
10  11  12  13
20  21  22  23
30  31  32  33
```

Le programme sépare les nombres par des tabulations.

## Partie C — Chasse aux bogues

### C1 — Indice hors limites

L'exception est `IndexOutOfRangeException`. Au plantage, `i = 5` et `points.Length = 5`; le plus grand indice valide est `4`. Un point d'arrêt sur l'accès `points[i]` permet d'observer `i` avant le plantage. Remplacer `i <= points.Length` par `i < points.Length`.

### C2 — Portée et initialisation

Le bloc de la boucle limite la portée de `total`. Sa déclaration doit précéder la boucle pour permettre l'affichage et conserver les additions.

```csharp
int[] ventes = { 250, 300, 175, 425 };
int total = 0;
for (int i = 0; i < ventes.Length; i++)
    total += ventes[i];
Console.WriteLine($"Total des ventes : {total} $");
```

Un point d'arrêt sur l'addition montre les totaux après chaque passage : `250`, `550`, `725`, `1150`. L'initialisation n'a lieu qu'une seule fois.

### C3 — Dimensions inversées

`GetLength(0) = 2` rangées et `GetLength(1) = 5` colonnes. Le code visite deux colonnes par rangée, puis tente `[2,0]`, qui n'existe pas. Observer les deux indices sur l'accès au tableau révèle l'inversion.

```csharp
int[,] grille = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
for (int rangee = 0; rangee < grille.GetLength(0); rangee++)
{
    for (int colonne = 0; colonne < grille.GetLength(1); colonne++)
        Console.Write(grille[rangee, colonne] + " ");
    Console.WriteLine();
}
```

Sur un tableau carré `5 × 5`, les deux dimensions égales masqueraient le bogue : aucun dépassement ni affichage tronqué.

### C4 — Saut de ligne dans le mauvais bloc

Le saut de ligne s'exécute six fois, immédiatement après chaque nombre. Il doit s'exécuter deux fois, après la boucle interne, dans le bloc de la boucle externe. Un point d'arrêt sur `WriteLine`, puis `F10`, rend ce moment visible.

```csharp
int[,] grille = { { 1, 2, 3 }, { 4, 5, 6 } };
for (int rangee = 0; rangee < grille.GetLength(0); rangee++)
{
    for (int colonne = 0; colonne < grille.GetLength(1); colonne++)
        Console.Write(grille[rangee, colonne] + " ");
    Console.WriteLine();
}
```

### C5 — Indices transposés

Le tableau est carré : les indices inversés restent valides. Pour l'étudiant `0`, le code fautif additionne `80`, `60`, `88` (la colonne) au lieu de `80`, `70`, `90` (la rangée). Observer les deux expressions du laboratoire dans Espion montre ces valeurs différentes. Remplacer l'accès par `notes[etudiant, examen]`.

```csharp
int[,] notes = { { 80, 70, 90 }, { 60, 95, 75 }, { 88, 72, 65 } };
for (int etudiant = 0; etudiant < notes.GetLength(0); etudiant++)
{
    int somme = 0;
    for (int examen = 0; examen < notes.GetLength(1); examen++)
        somme += notes[etudiant, examen];
    Console.WriteLine($"Étudiant {etudiant} : moyenne {somme / notes.GetLength(1)}");
}
```

Les sommes sont `240`, `230`, `225`; les moyennes entières attendues sont `80`, `76`, `75`. La suppression des décimales est volontaire dans cet exercice.

### C6 — Maximum mal initialisé

Avec `max = 0`, l'affectation dans le `if` ne s'exécute jamais : toutes les températures sont négatives. Un point d'arrêt sur le `if` permet de le constater. Initialiser le maximum avec une valeur du tableau.

```csharp
int[] temperatures = { -8, -3, -12, -5 };
int max = temperatures[0];
for (int i = 1; i < temperatures.Length; i++)
    if (temperatures[i] > max) max = temperatures[i];
Console.WriteLine($"Température la plus chaude : {max} °C");
```

Le résultat est `-3 °C`. Le tableau positif `{ 8, 3, 12, 5 }` cachait le défaut parce qu'une valeur supérieure à zéro remplaçait l'initialisation incorrecte.

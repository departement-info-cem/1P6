---
title: Débogage et trace d'exécution
---

# 🧪 Labo 7.2 – Débogage et trace d'exécution

📎 **Référence** : [Cours 7.2 – Débogage et trace d'exécution](/cours/debogage-trace)

Ce laboratoire se fait en **trois parties** :

| Partie | Ce que tu fais | Outil |
| --- | --- | --- |
| **A** | Tu prédis le comportement du code **sans l'exécuter** | ✏️ Papier et crayon |
| **B** | Tu observes un programme qui fonctionne | 🔍 Débogueur |
| **C** | Tu répares un programme qui ne fonctionne pas | 🔍 Débogueur |

:::warning L'ordre compte
Fais la **partie A en premier, sans ordinateur**. C'est ce format qui est évalué à l'examen, où tu n'auras pas Visual Studio. Ensuite, valide tes réponses au débogueur : c'est là que tu apprends le plus.
:::

---

# ✏️ Partie A – Traces d'exécution

### **Consigne générale**

> Réalise une trace d'exécution afin de suivre l'évolution des variables et de comprendre le déroulement du programme. Indique aussi ce qui est **affiché** à la console, s'il y a lieu.

:::warning
Le tableau de trace d'exécution fourni est conçu pour être utilisé tout au long de la session. Il contient donc des éléments qui n'ont pas encore été vus.

Pour les exercices de cette section, **utilise uniquement les éléments qui ont été présentés en classe**.
:::

> 🖨️ [Imprimer le tableau de trace d'exécution pour pratiquer tes traces à la main.](https://info.cegepmontpetit.ca/420-SN1/assets/files/Traces_recto_verso-c4b18f20ba4ca97fa4a818fec269eae3.pdf)

:::tip Rappel : n'oublie pas le dernier tour
Une boucle `for` évalue sa condition **une fois de trop** : celle qui est fausse et qui fait sortir de la boucle. Ce tour-là doit apparaître dans ta trace.
:::

## 🟢 Exercice A1 – Boucle avec accumulateur

Colonnes suggérées : `i` | `total` | Affichage

```csharp
1. int total = 0;
2. for (int i = 1; i <= 4; i++)
3. {
4.     total = total + i;
5. }
6. Console.WriteLine(total);
```

**Questions :**
1. Combien de fois la ligne 4 est-elle exécutée ?
2. Que vaut `i` au moment où on sort de la boucle ?
3. Qu'affiche le programme ?

---

## 🟢 Exercice A2 – Incrément différent de 1

Colonnes suggérées : `i` | `valeurs[i]` | `somme` | Affichage

```csharp
1. int[] valeurs = { 5, 10, 15, 20 };
2. int somme = 0;
3. for (int i = 0; i < valeurs.Length; i = i + 2)
4. {
5.     somme = somme + valeurs[i];
6. }
7. Console.WriteLine(somme);
```

**Questions :**
1. Quelles cases du tableau sont **visitées** ? Lesquelles sont **sautées** ?
2. Qu'affiche le programme ?

---

## 🟢 Exercice A3 – Recherche du maximum

Colonnes suggérées : `i` | `notes[i]` | `max` | `position` | Affichage

```csharp
1. int[] notes = { 72, 95, 60, 88 };
2. int max = notes[0];
3. int position = 0;
4. for (int i = 1; i < notes.Length; i++)
5. {
6.     if (notes[i] > max)
7.     {
8.         max = notes[i];
9.         position = i;
10.    }
11. }
12. Console.WriteLine($"{max} à la position {position}");
```

**Questions :**
1. À quels tours la ligne 8 est-elle exécutée ? À quels tours est-elle **sautée** ?
2. Pourquoi la boucle commence-t-elle à `i = 1` et non à `i = 0` ?
3. Qu'affiche le programme ?

---

## 🟡 Exercice A4 – Boucles imbriquées : somme par rangée

Colonnes suggérées : `r` | `c` | `grille[r, c]` | `sommeRangee` | Affichage

```csharp
1. int[,] grille = { { 2, 4, 6 },
                     { 1, 3, 5 } };
2. for (int r = 0; r < grille.GetLength(0); r++)
3. {
4.     int sommeRangee = 0;
5.     for (int c = 0; c < grille.GetLength(1); c++)
6.     {
7.         sommeRangee = sommeRangee + grille[r, c];
8.     }
9.     Console.WriteLine(sommeRangee);
10. }
```

**Questions :**
1. Combien de fois la ligne 7 est-elle exécutée ? Et la ligne 4 ?
2. Que vaudrait l'affichage si la ligne 4 était placée **avant** la ligne 2 ?
3. Qu'affiche le programme ?

---

## 🟡 Exercice A5 – Parcours par colonne

Colonnes suggérées : `c` | `r` | `grille[r, c]` | Affichage

```csharp
1. int[,] grille = { { 1, 2 },
                     { 3, 4 },
                     { 5, 6 } };
2. for (int c = 0; c < grille.GetLength(1); c++)
3. {
4.     for (int r = 0; r < grille.GetLength(0); r++)
5.     {
6.         Console.Write(grille[r, c] + " ");
7.     }
8.     Console.WriteLine();
9. }
```

**Questions :**
1. Que retournent `grille.GetLength(0)` et `grille.GetLength(1)` ?
2. Dans quel **ordre** les 6 cases sont-elles visitées ?
3. Écris exactement ce qui apparaît à la console, ligne par ligne.

---

## 🟡 Exercice A6 – Appel de fonction dans une boucle

Colonnes suggérées : `i` | `valeur` | `n` | `resultat` | valeur retournée | `total`

```csharp
1. static int Doubler(int n)
2. {
3.     int resultat = n * 2;
4.     return resultat;
5. }
6.
7. static void Main()
8. {
9.     int valeur = 3;
10.    int total = 0;
11.    for (int i = 0; i < 3; i++)
12.    {
13.        total = total + Doubler(valeur);
14.        valeur = valeur + 1;
15.    }
16.    Console.WriteLine(total);
17. }
```

**Questions :**
1. Combien de fois la fonction `Doubler` est-elle appelée ?
2. Quelles valeurs le paramètre `n` prend-il, dans l'ordre ?
3. Que devient la variable `resultat` entre deux appels ? Pourquoi ?
4. Qu'affiche le programme ?

---

## 🔴 Exercice A7 – Trouver le bogue par la trace

Ce programme devrait afficher la **température moyenne**, soit `19`. Il affiche autre chose.

Colonnes suggérées : `i` | `temperatures[i]` | `somme` | `moyenne` | Affichage

```csharp
1. int[] temperatures = { 12, 18, 25, 21 };
2. int somme = 0;
3. int moyenne = 0;
4. for (int i = 0; i < temperatures.Length; i++)
5. {
6.     somme = temperatures[i];
7.     moyenne = somme / temperatures.Length;
8. }
9. Console.WriteLine(moyenne);
```

**Questions :**
1. Fais la trace. Qu'affiche réellement le programme ?
2. En regardant la colonne `somme` de ta trace, quel est le problème ?
3. Corrige **une seule** ligne pour obtenir `19`.
4. Où faudrait-il déplacer la ligne 7 pour que le calcul soit fait une seule fois ?

---

# 🔍 Partie B – Observer avec le débogueur

Pour cette partie, crée un **nouveau projet** dans Visual Studio et recopie le code.

Les réponses sont des **valeurs précises** : lis-les dans **Variables locales**, dans **Automatique** ou dans la fenêtre **Espion**, ne les devine pas.

## 🟢 Exercice B1 – Compter les passages et espionner une expression

🎯 **Objectif** : Placer un point d'arrêt, avancer avec `F10` et utiliser la fenêtre **Espion**.

```csharp
int[,] stock = { { 4, 0, 7, 2 },
                 { 0, 9, 0, 5 } };

int nbRuptures = 0;
int totalUnites = 0;

for (int entrepot = 0; entrepot < stock.GetLength(0); entrepot++)
{
    for (int produit = 0; produit < stock.GetLength(1); produit++)
    {
        totalUnites = totalUnites + stock[entrepot, produit];

        if (stock[entrepot, produit] == 0)
        {
            nbRuptures = nbRuptures + 1;
        }
    }
}

Console.WriteLine($"Unités : {totalUnites}");
Console.WriteLine($"Ruptures : {nbRuptures}");
```

🛠️ **Instructions** :
1. Place un point d'arrêt (`F9`) sur la ligne `totalUnites = totalUnites + ...`.
2. Lance avec `F5`, puis ajoute ces trois expressions dans la fenêtre **Espion** :
   * `stock[entrepot, produit]`
   * `stock.GetLength(0)`
   * `stock.GetLength(1)`
3. Appuie sur `F5` pour passer d'un arrêt au suivant et remplis le tableau ci-dessous.

| Arrêt no | `entrepot` | `produit` | `stock[entrepot, produit]` | `totalUnites` (avant) | `nbRuptures` (avant) |
| -------: | :--------: | :-------: | :------------------------: | :-------------------: | :------------------: |
|        1 |            |           |                            |                       |                      |
|        2 |            |           |                            |                       |                      |
|        3 |            |           |                            |                       |                      |
|        … |            |           |                            |                       |                      |

**Questions :**
1. Combien de fois au total le point d'arrêt est-il atteint ?
2. Que valent `stock.GetLength(0)`, `stock.GetLength(1)` et `stock.Length` ? Quel lien y a-t-il entre les trois ?
3. Au 5<sup>e</sup> arrêt, que valent `entrepot` et `produit` ? Est-ce que c'est le **début d'une nouvelle rangée** ?
4. Quelles sont les deux valeurs affichées à la fin ?

---

## 🟢 Exercice B2 – Entrer dans une fonction avec `F11`

🎯 **Objectif** : Distinguer `F10` de `F11` et suivre une valeur de retour.

```csharp
static int Mystere(int a, int b)
{
    int r = a;

    for (int i = 0; i < b; i++)
    {
        r = r + a;
    }

    return r;
}

static void Main()
{
    int resultat = 0;

    for (int i = 1; i <= 6; i++)
    {
        resultat = resultat + Mystere(i, i);
    }

    Console.WriteLine(resultat);
}
```

🛠️ **Instructions** :
1. Place un point d'arrêt sur la ligne `resultat = resultat + Mystere(i, i);`.
2. Au premier arrêt, appuie sur **`F10`** : observe que le programme passe la ligne au complet.
3. Relance (`Maj + F5` puis `F5`). Cette fois, appuie sur **`F11`** : tu entres **dans** `Mystere`.
4. Une fois à l'intérieur, appuie sur **`Maj + F11`** pour ressortir d'un coup.

**Questions :**
1. Quand tu entres dans `Mystere` au tout premier appel, que valent les paramètres `a` et `b` ?
2. Sans deviner : quelles valeurs `Mystere` retourne-t-elle à chacun des 6 appels ? *(Astuce : mets un point d'arrêt sur la ligne `return r;` et lis `r`.)*
3. En une phrase, que calcule `Mystere(a, b)` ?
4. Qu'affiche le programme à la fin ?
5. Pourquoi `F11` sur la ligne `Console.WriteLine(resultat);` ne t'apprend-il rien d'utile ?

---

## 🟡 Exercice B3 – Déplier un tableau dans Variables locales

🎯 **Objectif** : Repérer des cases jamais remplies en dépliant un tableau 2D.

Ce programme devrait remplir **toutes** les cases du plan de salle. Pourtant, une partie reste à `0`.

```csharp
int[,] plan = new int[3, 4];

for (int rangee = 0; rangee < 3; rangee++)
{
    for (int siege = 0; siege < 3; siege++)
    {
        plan[rangee, siege] = (rangee + 1) * 10 + siege;
    }
}

for (int rangee = 0; rangee < plan.GetLength(0); rangee++)
{
    for (int siege = 0; siege < plan.GetLength(1); siege++)
    {
        Console.Write(plan[rangee, siege] + "\t");
    }
    Console.WriteLine();
}
```

🛠️ **Instructions** :
1. Place un point d'arrêt sur la **première ligne du deuxième bloc de boucles** (celui qui affiche).
2. Lance avec `F5`. Dans **Variables locales**, clique sur la ▸ à gauche de `plan` pour déplier **toutes** ses cases.

**Questions :**
1. Quelles cases valent `0` ? Donne-les sous la forme `[rangee, siege]`.
2. Quelle **ligne** du premier bloc de boucles est responsable ? Quelle est la correction ?
3. Pourquoi le tableau contient-il des `0` plutôt que des cases vides ?
4. Une fois corrigé, qu'affiche le programme ?

:::tip Ne code pas « 3 » en dur
`plan.GetLength(1)` s'adapte automatiquement si la taille du tableau change ; un `3` écrit à la main, non. C'est exactement le bogue de cet exercice.
:::

---

# 🐞 Partie C – Chasse aux bogues

Pour chaque exercice : le **résultat attendu** est donné. Utilise le débogueur pour trouver la cause, puis corrige.

:::danger La méthode, pas le hasard
Avant de modifier une ligne, écris ton hypothèse : « je pense que _____ ». Ensuite, vérifie-la au débogueur. Modifier du code au hasard jusqu'à ce que ça fonctionne n'est pas du débogage 🎲
:::

Pour chacun, remets ces trois éléments :
* la **ligne** fautive;
* **comment** tu l'as trouvée (point d'arrêt placé où, quelle variable observée);
* la **correction**.

## 🟡 Exercice C1 – Le programme plante

```csharp
int[] points = { 12, 8, 15, 6, 20 };

for (int i = 0; i <= points.Length; i++)
{
    Console.WriteLine(points[i]);
}
```

❌ **Observé** : les 5 valeurs s'affichent, puis le programme plante.

✅ **Attendu** : les 5 valeurs s'affichent, puis le programme se termine normalement.

**Questions :**
1. Quel est le **nom** de l'exception affichée par Visual Studio ?
2. Au moment du plantage, que valent `i` et `points.Length` ?
3. Quel est le plus grand indice **valide** pour ce tableau ?

---

## 🟡 Exercice C2 – Le total ne s'additionne pas

```csharp
int[] ventes = { 250, 300, 175, 425 };

for (int i = 0; i < ventes.Length; i++)
{
    int total = 0;
    total = total + ventes[i];
}

Console.WriteLine($"Total des ventes : {total} $");
```

❌ **Observé** : le programme ne compile même pas. Visual Studio affiche `error CS0103 : Le nom 'total' n'existe pas dans le contexte actuel`.

✅ **Attendu** :
```
Total des ventes : 1150 $
```

**Questions :**
1. Pourquoi `total` n'existe-t-il pas à l'extérieur de la boucle ?
2. Déplace la déclaration pour que le programme compile. Il affiche maintenant `425`. Explique pourquoi avec ta trace de l'exercice A7.
3. Corrige complètement le programme.

:::note Deux bogues pour le prix d'un
Celui-ci enchaîne une **erreur de compilation** (portée de la variable) et une **erreur de logique** (accumulateur remis à zéro). C'est très fréquent : corriger la première révèle la seconde.
:::

---

## 🟡 Exercice C3 – La grille est tronquée

```csharp
int[,] grille = { { 1, 2, 3, 4, 5 },
                  { 6, 7, 8, 9, 10 } };

for (int rangee = 0; rangee < grille.GetLength(1); rangee++)
{
    for (int colonne = 0; colonne < grille.GetLength(0); colonne++)
    {
        Console.Write(grille[rangee, colonne] + " ");
    }
    Console.WriteLine();
}
```

❌ **Observé** :
```
1 2
6 7
```
… puis le programme plante.

✅ **Attendu** :
```
1 2 3 4 5
6 7 8 9 10
```

**Questions :**
1. Que retournent `grille.GetLength(0)` et `grille.GetLength(1)` ? Mets les deux dans la fenêtre **Espion**.
2. Pourquoi seulement **deux** valeurs par ligne, et **deux** lignes complètes avant le plantage ?
3. Corrige les deux lignes fautives.
4. Si la grille avait été de **5 × 5**, le programme aurait-il planté ? Aurais-tu vu le bogue ?

---

## 🟡 Exercice C4 – Tout s'affiche en colonne

```csharp
int[,] grille = { { 1, 2, 3 },
                  { 4, 5, 6 } };

for (int rangee = 0; rangee < grille.GetLength(0); rangee++)
{
    for (int colonne = 0; colonne < grille.GetLength(1); colonne++)
    {
        Console.Write(grille[rangee, colonne] + " ");
        Console.WriteLine();
    }
}
```

❌ **Observé** :
```
1
2
3
4
5
6
```

✅ **Attendu** :
```
1 2 3
4 5 6
```

**Questions :**
1. Combien de fois le `Console.WriteLine()` est-il exécuté actuellement ? Combien de fois **devrait-il** l'être ?
2. Dans quel bloc doit-il se trouver ?
3. Avance en `F10` en gardant la fenêtre de console visible à côté de Visual Studio : à quel moment précis le saut de ligne apparaît-il ?

---

## 🔴 Exercice C5 – Les moyennes sont fausses (sans plantage)

```csharp
int[,] notes = { { 80, 70, 90 },
                 { 60, 95, 75 },
                 { 88, 72, 65 } };

for (int etudiant = 0; etudiant < notes.GetLength(0); etudiant++)
{
    int somme = 0;

    for (int examen = 0; examen < notes.GetLength(1); examen++)
    {
        somme = somme + notes[examen, etudiant];
    }

    Console.WriteLine($"Étudiant {etudiant} : moyenne {somme / notes.GetLength(1)}");
}
```

❌ **Observé** :
```
Étudiant 0 : moyenne 76
Étudiant 1 : moyenne 79
Étudiant 2 : moyenne 76
```

✅ **Attendu** :
```
Étudiant 0 : moyenne 80
Étudiant 1 : moyenne 76
Étudiant 2 : moyenne 75
```

**Questions :**
1. Le programme ne plante **pas**. Pourquoi, alors que l'exercice C3 plantait ?
2. Ajoute `notes[examen, etudiant]` **et** `notes[etudiant, examen]` dans la fenêtre **Espion**, puis avance en `F10`. Que remarques-tu ?
3. Quelles valeurs sont réellement additionnées pour l'étudiant 0 ?
4. Corrige la ligne fautive.

:::danger Le pire genre de bogue
Un programme qui donne un résultat **plausible mais faux** ne se dénonce jamais. C'est pourquoi tu dois vérifier tes résultats avec un exemple calculé à la main.
:::

---

## 🔴 Exercice C6 – Le maximum est toujours le même

```csharp
int[] temperatures = { -8, -3, -12, -5 };
int max = 0;

for (int i = 0; i < temperatures.Length; i++)
{
    if (temperatures[i] > max)
    {
        max = temperatures[i];
    }
}

Console.WriteLine($"Température la plus chaude : {max} °C");
```

❌ **Observé** :
```
Température la plus chaude : 0 °C
```

✅ **Attendu** :
```
Température la plus chaude : -3 °C
```

**Questions :**
1. Place un point d'arrêt sur le `if` et avance en `F10`. Combien de fois la ligne `max = temperatures[i];` est-elle exécutée ?
2. Pourquoi `0` n'est-il pas une bonne valeur de départ pour `max` ?
3. Corrige l'initialisation. *(Astuce : relis l'exercice A3.)*
4. Avec le tableau `{ 8, 3, 12, 5 }`, le programme donnait le bon résultat. Pourquoi ce bogue est-il resté invisible aussi longtemps ?

---

# 🎁 Défi – Documenter un bogue

Reprends **un** des programmes de la partie C et rédige un court rapport de 5 lignes :

1. **Symptôme** — ce que le programme fait de travers.
2. **Point d'arrêt** — où tu l'as placé, et pourquoi là.
3. **Observation** — la variable observée et la valeur qui t'a mis sur la piste.
4. **Cause** — la ligne fautive et la raison.
5. **Correction** — le changement, et le test qui prouve que c'est réglé.

:::tip
Savoir expliquer un bogue clairement est aussi utile que savoir le corriger : c'est exactement ce qu'on te demandera de faire en stage et au travail.
:::

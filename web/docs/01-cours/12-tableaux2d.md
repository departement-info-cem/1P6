---
description: Tableaux 2D, boucles imbriquées et parcours par lignes et colonnes
---

# Tableaux 2D

## 1️⃣ Rappel : Tableaux 1D

Un tableau **1D** permet de stocker une liste d’éléments.

Reprenons notre exemple du cours sur les tableaux 1D et imaginons que nous devions stocker les notes de 5 élèves. Sans tableau, nous aurions :

```csharp
int note1 = 85;
int note2 = 90;
int note3 = 78;
int note4 = 92;
int note5 = 88;
```

La **solution** était alors d'utiliser un tableau **1D** permettant de stocker toutes les valeurs :

```csharp
int[] notes = { 85, 90, 78, 92, 88 };
```

---

## 2️⃣ Limites d’un tableau 1D

Parfois, les données que nous manipulons sont naturellement organisées en lignes et colonnes.

Poussons notre exemple plus loin et essayons maintenant de stocker toutes les notes de chaque élève d'une classe. Avec un simple tableau **1D**, nous aurions :

```csharp
int[] notesEleve1 = { 85, 90, 78, 92, 88, 99 };
int[] notesEleve2 = { 72, 81, 95, 68, 74, 44 };
int[] notesEleve3 = { 88, 79, 84, 91, 77, 37 };
int[] notesEleve4 = { 93, 87, 90, 85, 89, 78 };
int[] notesEleve5 = { 65, 70, 72, 60, 68, 21 };
```

❌ **Inconvénients** :
- Trop de variables à déclarer.
- Difficile à traiter automatiquement (par exemple pour calculer la moyenne de la classe).
- Impossible de retourner toutes les notes des élèves depuis une fonction.

✅ **Solution** : utiliser un seul conteneur capable de stocker toutes les valeurs : **un tableau 2D**.

---

## 3️⃣ Introduction sur les tableaux 2D

### 🧠 Définition 

Pour définir un tableau à plusieurs dimensions, il suffit d'initialiser un tableau à une dimension, puis d'y ajouter une virgule pour chaque dimension additionnelle. Voici un exemple :

**Syntaxe :**
```csharp
type[] variable; // Tableau à 1 dimension
type[,] variable; // Tableau à 2 dimension
type[,,] variable; // Tableau à 3 dimension
...
type[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] variable; // Tableau à 32 dimension

```
:::warning 
En C#, les tableaux sont limités à 32 dimensions. Il est toutefois important de noter qu'il est très rare d'utiliser des tableaux avec plus de 2D. 
:::

### ✅ Solution

Pour regrouper toutes les notes des élèves en une seule variable, il faut donc créer un tableau à deux dimensions. La première dimension servira pour les élèves, et la seconde dimension servira pour les notes. Voyons comment définir un tableau de notes d'élèves :

```csharp
int[,] notesEleves = {
    { 85, 90, 78, 92, 88, 99 }, // Élève 1
    { 72, 81, 95, 68, 74, 44 }, // Élève 2
    { 88, 79, 84, 91, 77, 37 }, // Élève 3
    { 93, 87, 90, 85, 89, 78 }, // Élève 4
    { 65, 70, 72, 60, 68, 21 }  // Élève 5
  };
```
👉 Avec un tableau **2D**, tout est regroupé sous une seule variable nommée (`notesEleves`). On peut ainsi accéder facilement à chaque élément. Dans le cas suivant, nous avons maintenant un tableau à **plusieurs dimensions**, possédant 5 rangées et 6 colonnes.

---

## 4️⃣ Visualisation d’un tableau 2D

Lorsqu'il est question d'un tableau à deux dimensions, les dimensions sont généralement nommées **rangées** et **colonnes**, puisqu'il est facile de s'imaginer un tableau selon la représentation visuelle suivante :

```
                            Notes
                 1    2    3    4    5    6
              ┌────┬────┬────┬────┬────┬────┐
          1   │ 85 │ 90 │ 78 │ 92 │ 88 │ 99 │
              ├────┼────┼────┼────┼────┼────┤
          2   │ 72 │ 81 │ 95 │ 68 │ 74 │ 44 │
              ├────┼────┼────┼────┼────┼────┤
Élèves    3   │ 88 │ 79 │ 84 │ 91 │ 77 │ 37 │
              ├────┼────┼────┼────┼────┼────┤
          4   │ 93 │ 87 │ 90 │ 85 │ 89 │ 78 │
              ├────┼────┼────┼────┼────┼────┤
          5   │ 65 │ 70 │ 72 │ 60 │ 68 │ 21 │
              └────┴────┴────┴────┴────┴────┘
```

---

## 5️⃣ Déclaration d’un tableau 2D

Il existe deux façons de déclarer un tableau à plusieurs dimensions : avec ou sans initialisation. 

### 📑 Déclaration **AVEC** initialisation
Il peut arriver que le contenu d'un tableau soit déjà connu d'avance. Dans ce cas-là, il suffit de déclarer un tableau et de lui attribuer directement les valeurs, comme dans le code suivant :

```csharp
// Tableaux à deux dimensions, sur une ligne.
int[,] notesEleves = {{ 85, 88, 99 },{ 68, 74, 44 }};

// Tableaux à deux dimensions, sur plusieurs lignes.
string[,] pouvoirsSuperheros = {
  { "Vol", "Super force", "Vision laser", "Invulnérabilité"}, // Superman
  { "Intelligence", "Arts martiaux", "Technologie", "Stratégie"}, // Batman
  { "Vitesse", "Voyage temporel", "Réflexes accrus", "Guérison rapide"}, // Flash
  { "Force divine", "Lasso de vérité", "Vol", "Agilité surhumaine"} // Wonder Woman
};
```
:::info
Il est possible de définir un tableau à plusieurs dimensions en une seule ligne. Cependant, il est important de s'assurer que le code reste lisible au premier regard. S'il est nécessaire d'utiliser la barre de défilement vertical pour voir l'entièreté du code, ajouter des sauts de lignes peut s'avérer utile.
:::

```csharp
string[,] pouvoirsSuperheros = {{ "Vol", "Super force", "Vision laser", "Invulnérabilité"},{ "Intelligence", "Arts martiaux", "Technologie", "Stratégie"},{ "Vitesse", "Voyage temporel", "Réflexes accrus", "Guérison rapide"},{ "Force divine", "Lasso de vérité", "Vol", "Agilité surhumaine"}};
```
:::

### 📄 Déclaration **SANS** initialisation
Cependant, il arrive parfois que les données du tableau soient créées pendant la vie du programme, à partir d'une logique métier. Dans ce cas, il faut être en mesure de créer un tableau sans données. Voici un exemple de déclaration d'un tableau sans initialisation :

```csharp
int[,] notesEleves = new int[3, 2]; // 3 rangées et 2 colonnes vides.
```
Lorsque le tableau n'est pas initialisé, chaque élément possède la valeur par défaut du type de données (les tableaux eux-mêmes ne sont pas `null` en C# lorsqu'ils sont créés avec `new`).

- L'opérateur `new` instancie (crée) l'objet tableau.
- Le type de données des valeurs qui seront assignées au tableau est défini.
- La taille du tableau est définie par le nombre de rangées suivi du nombre de colonnes.

Chacun des éléments contient la valeur par défaut du type de données du tableau :
| Type                           | Exemple de déclaration       | Valeur par défaut des éléments |
|--------------------------------|-----------------------------|--------------------------------|
| Entiers (`int`, `long`, etc.)  | `int[] a = new int[3];`     | 0                              |
| Flottants (`float`, `double`)  | `double[] b = new double[3];`| 0.0                           |
| Décimal (`decimal`)            | `decimal[] c = new decimal[3];` | 0.0m                        |
| Booléens (`bool`)              | `bool[] d = new bool[3];`   | false                          |
| Caractères (`char`)            | `char[] e = new char[3];`   | '\0' (caractère nul)           |
| Chaînes (`string`)             | `string[] f = new string[3];`| null                           |
| ...                            | ...                         | ...                             |

---

## 6️⃣ Accès aux éléments

Tout comme pour les tableaux **1D**, il suffit d'utiliser l'index pour récupérer la valeur à l'intérieur d'un tableau. L'index représente l'endroit où l'on souhaite accéder. Si un tableau possède `4` valeurs, on parcourra le tableau avec un indice allant de `0` à `3`.  

Le principe est identique pour les tableaux à plusieurs dimensions. Par contre, il faudra deux indices pour parcourir l'intégralité du tableau : 
* Le **premier index** désigne le numéro de rangée (ligne).
* Le **deuxième index** désigne le numéro de colonne.

**Exemples :**
```csharp
int[,] notesEleves = {{ 85, 88, 99 },{ 68, 74, 44 }};

string[,] pouvoirsSuperheros = {
  { "Vol", "Super force", "Vision laser", "Invulnérabilité"}, // Superman
  { "Intelligence", "Arts martiaux", "Technologie", "Stratégie"}, // Batman
  { "Vitesse", "Voyage temporel", "Réflexes accrus", "Guérison rapide"}, // Flash
  { "Force divine", "Lasso de vérité", "Vol", "Agilité surhumaine"} // Wonder Woman
};

int ligne = 1;
int colonne = 2;
Console.WriteLine($"notesEleves[{ligne},{colonne}] = {notesEleves[ligne,colonne]}");

ligne = 3;
colonne = 0;
Console.WriteLine($"pouvoirsSuperheros[{ligne},{colonne}] = {pouvoirsSuperheros[ligne,colonne]}");
```
**Résultat :** 
```
notesEleves[1,2] = 44
pouvoirsSuperheros[3,0] = Force divine
```

---

## 7️⃣ Modifications des éléments

Une fois la bonne rangée et la bonne colonne identifiées, il suffit de faire une assignation au tableau pour **modifier** son contenu à l'endroit spécifiquement choisi :

**Exemples :**
```csharp
string[,] pouvoirsSuperheros = {
  { "Vol", "Super force", "Vision laser", "Invulnérabilité"},
  { "Intelligence", "Arts martiaux", "Technologie", "Stratégie"},
  { "Vitesse", "Voyage temporel", "Réflexes accrus", "Guérison rapide"},
  { "Force divine", "Lasso de vérité", "Vol", "Agilité surhumaine"}
};

pouvoirsSuperheros[0,0] = "Superman";
pouvoirsSuperheros[1,0] = "Batman";
pouvoirsSuperheros[2,0] = "Flash";
pouvoirsSuperheros[3,0] = "Wonder Woman";
```

---

## 8️⃣ Propriété `.Length` et `.GetLength(dimension)`

Contrairement au tableau **1D**, la propriété `Length` ne suffit pas pour parcourir l'ensemble d'un tableau à plusieurs dimensions. Il nous faut également une méthode pour obtenir le nombre d'éléments dans chaque dimension du tableau.

- `.Length` : Retourne le nombre total d’éléments dans un tableau.
- `.GetLength(dimension)` : Retourne le nombre d'éléments présents dans une dimension spécifique.
  * `GetLength(0)` : Retourne le nombre de rangées.
  * `GetLength(1)` : Retourne le nombre de colonnes.

**Exemples :**

```csharp
string[,] pouvoirsSuperheros = {
  { "Vol", "Super force", "Vision laser", "Invulnérabilité"}, // Superman
  { "Intelligence", "Arts martiaux", "Technologie", "Stratégie"}, // Batman
  { "Vitesse", "Voyage temporel", "Réflexes accrus", "Guérison rapide"}, // Flash
  { "Force divine", "Lasso de vérité", "Vol", "Agilité surhumaine"}, // Wonder Woman
  { "Sens d’araignée", "Agilité surhumaine", "Toiles", "Escalade de murs"} // Spiderman
};

Console.WriteLine(pouvoirsSuperheros.Length); // Nombre total d'éléments
Console.WriteLine(pouvoirsSuperheros.GetLength(0)); // Nombre de Superheros (rangés)
Console.WriteLine(pouvoirsSuperheros.GetLength(1)); // Nombre de superPouvoir (colonnes)
```
**Résultat :** 
```
20
5
4
``` 

---

## 9️⃣ Parcours de tableaux 2D à l'aide de boucles `for` imbriquées

Pour un tableau **1D**, une seule boucle `for` suffisait pour parcourir tous les éléments.  
Avec un tableau **2D**, chaque élément est identifié par **deux indices** : un pour la **rangée** (ligne) et un pour la **colonne**.  

👉 Il est donc nécessaire d'utiliser **deux boucles `for` imbriquées** afin de parcourir l’ensemble des éléments.  

Deux stratégies principales existent :  

### ➡️ Parcours par **rangée**

On parcourt toutes les colonnes **d’une rangée à la fois**, puis on passe à la rangée suivante.

#### Visualisation du parcours

```
      Étape 1             Étape 2             Étape 3
┌─────┬─────┬─────┐ ┌─────┬─────┬─────┐ ┌─────┬─────┬─────┐
│ 85* │ 90  │ 78  │ │ 85  │ 90* │ 78  │ │ 85  │ 90  │ 78* │
├─────┼─────┼─────┤ ├─────┼─────┼─────┤ ├─────┼─────┼─────┤
│ 72  │ 81  │ 95  │ │ 72  │ 81  │ 95  │ │ 72  │ 81  │ 95  │
└─────┴─────┴─────┘ └─────┴─────┴─────┘ └─────┴─────┴─────┘

      Étape 4             Étape 5             Étape 6
┌─────┬─────┬─────┐ ┌─────┬─────┬─────┐ ┌─────┬─────┬─────┐
│ 85  │ 90  │ 78  │ │ 85  │ 90  │ 78  │ │ 85  │ 90  │ 78  │
├─────┼─────┼─────┤ ├─────┼─────┼─────┤ ├─────┼─────┼─────┤
│ 72* │ 81  │ 95  │ │ 72  │ 81* │ 95  │ │ 72  │ 81  │ 95* │
└─────┴─────┴─────┘ └─────┴─────┴─────┘ └─────┴─────┴─────┘
```
#### ❌ Sans boucle
```csharp
int[,] notes = {
    { 85, 90, 78 },
    { 72, 81, 95 }
};

Console.Write(notes[0,0] + " ");
Console.Write(notes[0,1] + " ");
Console.WriteLine(notes[0,2]);

Console.Write(notes[1,0] + " ");
Console.Write(notes[1,1] + " ");
Console.WriteLine(notes[1,2]);

```
#### ✅ Avec boucles
```csharp
int[,] notes = {
    { 85, 90, 78 },
    { 72, 81, 95 }
};

for (int rangee = 0; rangee < notes.GetLength(0); rangee++)
{
    for (int colonne = 0; colonne < notes.GetLength(1); colonne++)
    {
        Console.Write(notes[rangee, colonne] + " ");
    }
    Console.WriteLine();
}
```
**Résultat :** 
```
85 90 78
72 81 95
```

### ⬇️ Parcours par **colonne**

On parcourt toutes les rangées d’une colonne à la fois, puis on passe à la colonne suivante.

#### Visualisation du parcours

```
      Étape 1             Étape 2
┌─────┬─────┬─────┐ ┌─────┬─────┬─────┐ 
│ 85* │ 90  │ 78  │ │ 85  │ 90  │ 78  │
├─────┼─────┼─────┤ ├─────┼─────┼─────┤
│ 72  │ 81  │ 95  │ │ 72* │ 81  │ 95  │
└─────┴─────┴─────┘ └─────┴─────┴─────┘

      Étape 3             Étape 4
┌─────┬─────┬─────┐ ┌─────┬─────┬─────┐
│ 85  │ 90* │ 78  │ │ 85  │ 90  │ 78  │
├─────┼─────┼─────┤ ├─────┼─────┼─────┤
│ 72  │ 81  │ 95  │ │ 72  │ 81* │ 95  │
└─────┴─────┴─────┘ └─────┴─────┴─────┘

      Étape 5             Étape 6
┌─────┬─────┬─────┐ ┌─────┬─────┬─────┐
│ 85  │ 90  │ 78* │ │ 85  │ 90  │ 78  │
├─────┼─────┼─────┤ ├─────┼─────┼─────┤
│ 72  │ 81  │ 95  │ │ 72  │ 81  │ 95* │
└─────┴─────┴─────┘ └─────┴─────┴─────┘
```
#### ❌ Sans boucle
```csharp
int[,] notes = {
    { 85, 90, 78 },
    { 72, 81, 95 }
};

Console.Write(notes[0,0] + " ");
Console.WriteLine(notes[1,0]);

Console.Write(notes[0,1] + " ");
Console.WriteLine(notes[1,1]);

Console.Write(notes[0,2] + " ");
Console.WriteLine(notes[1,2]);

```
#### ✅ Avec boucles
```csharp
int[,] notes = {
    { 85, 90, 78 },
    { 72, 81, 95 }
};

for (int colonne = 0; colonne < notes.GetLength(1); colonne++)
{
    for (int rangee = 0; rangee < notes.GetLength(0); rangee++)
    {
        Console.Write(notes[rangee, colonne] + " ");
    }
    Console.WriteLine();
}
```
**Résultat :** 
```
85 72
90 81
78 95
```
---

## 📎 Références

👉 Documentation officielle : 
* [Tableaux en C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-1d)
* [Tableaux 2D en C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-2d)
  * [Déclaration **AVEC** initialisation](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-2d#d%C3%A9claration-avec-initialisation)
  * [Déclaration **SANS** initialisation](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-2d#d%C3%A9claration-sans-initialisation)
* [Boucles **for** imbriquées](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/for-imbrique)
* [Valeurs par défaut pour chaque type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values)

Vous devez réaliser les laboratoires suivants :



<!-- * [🧪 Labo 6.2A](/laboratoire/laboratoire6.2A)-->
<!-- * [🧪 Labo 6.2B](/laboratoire/laboratoire6.2B)-->

---
description: Travailler avec des tableaux en 2 dimensions
---

# Tableaux 2D

## 1️⃣ Rappel : Tableaux 1D

Un tableau **1D** permet de stocker une liste d’éléments.

Reprenons notre exemple du cours sur les tableaux 1D et imaginons que nous devions stocker les notes de 5 étudiants. Sans tableau, nous aurions :

```csharp
int note1 = 85;
int note2 = 90;
int note3 = 78;
int note4 = 92;
int note5 = 88;
```

La **Solution** était alors d'utiliser un un tableau **1D** permettant de stocker toutes les valeurs :

```csharp
int[] notes = { 85, 90, 78, 92, 88 };
```

---

## 2️⃣ Limites d’un tableau 1D

Parfois, les données que nous manipulons sont naturellement organisées en lignes et colonnes.

Poussons notre exemple plus loin et essayons maintenant de stocker tous les notes de chaque élève d'une classe. Avec un simple tableau **1D** nous aurions :

```csharp
int[] notesEleve1 = { 85, 90, 78, 92, 88, 99 };
int[] notesEleve2 = { 72, 81, 95, 68, 74, 44 };
int[] notesEleve3 = { 88, 79, 84, 91, 77, 37 };
int[] notesEleve4 = { 93, 87, 90, 85, 89, 78 };
int[] notesEleve5 = { 65, 70, 72, 60, 68, 21 };
```

❌ **Inconvénients** :
- Trop de variables à déclarer (encore).
- Difficile à traiter automatiquement (par exemple pour calculer la moyenne de la classe).
- Impossible de retourner tous les notes des élèves depuis une fonction.

✅ **Solution** : utiliser un seul conteneur capable de stocker toutes les valeurs : **un tableau 2D**.

---

## 3️⃣ Introduction sur les tableaux 2D

### 🧠 Définition 

Pour definir un tableau à plusieurs dimensions, il suffit d'initialiser un tableau a une dimension, puis d'y ajouter une virgule pour chaque dimension additionnel. Voici un exemple :

**Syntaxe :**
```csharp
type[] variable; // Tableau à 1 dimension
type[,] variable; // Tableau à 2 dimension
type[,,] variable; // Tableau à 3 dimension
...
type[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] variable; // Tableau à 32 dimension

```
:::warning 
en C#, les tableaux sont limités à 32 dimensions. Il est tout fois important de noter qu'il est très rare d'utiliser des tableaux avec plus de 2D. 
:::

### ✅ Solution

Pour regrouper tous les notes des élèves en une seule variable, il faut donc créer un tableau a deux dimensions. La première dimension servira pour les notes, et la seconde dimension servira pour chaque élève. Voyons comment definir un tableau de notes d'élèves :

```csharp
int[,] notesEleves = {
    { 85, 90, 78, 92, 88, 99 }, // Élève 1
    { 72, 81, 95, 68, 74, 44 }, // Élève 2
    { 88, 79, 84, 91, 77, 37 }, // Élève 3
    { 93, 87, 90, 85, 89, 78 }, // Élève 4
    { 65, 70, 72, 60, 68, 21 }  // Élève 5
  };
```
👉 Avec un tableau **2D**, tout est regroupé sous une seule variable nommée (`notesEleves`). On peut ainsi accéder facilement à chaque élément. Dans le cas suivant, nous avons maintenant un tableau à multiple dimensions, possedant 5 rangées et 6 colonnes.

---

## 4️⃣ Visualisation d’un tableau 2D

Lorsqu'il est mention d'un tableau a deux dimensions, les dimensions sont généralement nommé rangées et colonnes, puisqu'il est facile de s'imaginer un tableau, selon la représentation visuelle suivante :

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

Il existe deux façons de déclarer un tableau a plusieurs dimensions, avec et sans initialisation. 

### 📑 Déclaration **AVEC** initialisation
Il peut arriver que le contenu d'un tableau soit déjà connu d'avance. Dans ce cas la, il suffit de déclarer un tableau et de directement donner les valeurs aux tableaux, suivant le code suivant :

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
Il est possible de definir un tableau a plusieurs dimension en une seule ligne. Cependant, il est important de s'assurer que son code est lisible au premier regard. S'il est nécéssaire d'utiliser la barre de défilement vertical pour voir l'entièreté du code, ajouter des sauts de lignes pourrait s'avéré utile.

```csharp
string[,] pouvoirsSuperheros = {{ "Vol", "Super force", "Vision laser", "Invulnérabilité"},{ "Intelligence", "Arts martiaux", "Technologie", "Stratégie"},{ "Vitesse", "Voyage temporel", "Réflexes accrus", "Guérison rapide"},{ "Force divine", "Lasso de vérité", "Vol", "Agilité surhumaine"}};
```
:::

### 📄 Déclaration **SANS** initialisation
Cependant, il arrive parfois que les données du tableaux soit créer pendant la vie du programme, a partir d'une logique d'affaire. Dans le cas suivant, il faut être en mesure de créer un tableau sans données. Voici un exemple d'une déclaration de tableau sans initialisation :

```csharp
int[,] notesEleves = new int[3, 2]; // 3 rangées et 2 colonnes vides.
```
Lorsque le tableau n'est pas initialisé, le tableau possède la valeur `null`.

- L'opérateur `new` instancie (crée) l'objet tableau
- Le type de données des valeurs qui seront assignées au tableau est défini
- La taille du tableau est définie par le nombre de rangées suivi du nombre de colonnes.

Chacun des éléments contient la valeur par défaut du type de données du tableau :
| Type                           | Exemple de déclaration       | Valeur par défaut des éléments |
|--------------------------------|------------------------------|--------------------------------|
| Entiers (`int`, `long`, etc.)  | `int[] a = new int[3];`      | 0                              |
| Flottants (`float`, `double`)  | `double[] b = new double[3];`| 0.0                            |
| Décimal (`decimal`)            | `decimal[] c = new decimal[3];` | 0.0m                        |
| Booléens (`bool`)              | `bool[] d = new bool[3];`    | false                          |
| Caractères (`char`)            | `char[] e = new char[3];`    | '\0' (caractère nul)           |
| Chaînes (`string`)             | `string[] f = new string[3];`| null                           |
| ...                            | ...                          | ...                            |

---

## 6️⃣ Accès aux éléments

Tout comme pour les tableaux **1D**, il suffit d'utiliser l'index pour récupérer la valeur a l'intérieur d'un tableau. L'index représente l'endroit ou l'on souhaite regarder. Si un tableau possède `4` valeurs, l'on parcourera le tableau avec un indice allant de `0` à `3`.  

Le principe est identique pour les tableaux a plusieurs dimensions. Par contre, il nous faudra deux index pour parcourir l'entièreré du tableau. 
* Le **premier index** désignera le numéro de rangée (ligne).
* Le **deuxième index** désignera numéro de colonne.

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

Une fois la bonne rangée et la bonne colonne, il suffit de faire une assignation au tableau pour modifié son contenu a l'endroit spécifiquement choisi:

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
Contrairement au tableau **1D**, la proriété `Length` ne sera pas suffisante pour parcourir l'ensemble d'un tableau a plusieurs dimensions. Il nous faut également une fonction pour avoir le nombre d'élément dans chaque dimension du tableau.

- `.Length` : Retourne le nombre total d’éléments dans un tableau.
- `.GetLength(dimension)` : Retourne le nombre d'élément(s) présent dans une dimension spécifique.
  * `GetLength(0)` : Retourne le nombre de rangée(s).
  * `GetLength(1)` : Retourne le nombre de colonne(s).

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

 ## 📎 Référence

👉 Documentation officielle : 
* [Tableaux en C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-1d)
* [Tableaux 2D en c#](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-2d)
  * [Déclaration **AVEC** initialisation ](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-2d#d%C3%A9claration-avec-initialisation)
  * [Déclaration **SANS** initialisation](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-2d#d%C3%A9claration-sans-initialisation)
* [Boucles **For** imbriquées](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/for-imbrique)
* [ Valeur par défaut pour chaque Type](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values)

Vous devez réaliser les labos suivants :
 [🧪 Labo 4.2A](/laboratoire/laboratoire4.2A)
 [🧪 Labo 4.2B](/laboratoire/laboratoire4.2B)
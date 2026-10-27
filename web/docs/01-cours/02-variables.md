---
description: Variables, chaînes de caractères, opérations et debugger
---

# Variables, chaînes et opérations arithmétiques

## 🧠 Théorie Rencontre 2

[Variable](https://info.cegepmontpetit.ca/notions-csharp/documentation/variable/variable) : une variable est une zone mémoire identifiée permettant de stocker et modifier une valeur durant l'exécution d'un programme.

## 1. Déclaration et affectation

La déclaration d'une variable signifie que l'on réserve un espace mémoire pour stocker une valeur d'un type précis. L'affectation consiste à attribuer une valeur à cette variable.

### 🧱 Syntaxe générale
```csharp
type nomDeVariable = valeur;
```

### 📝 Règles de nommage
[Identificateur](https://info.cegepmontpetit.ca/notions-csharp/documentation/identificateur) : un identificateur est un nom choisi pour désigner variables, méthodes, etc., selon des conventions précises de style.
- Un nom de variable peut commencer par une lettre ou un soulignement (`_`), mais pas par un chiffre.
- Les caractères suivants peuvent être des lettres, des chiffres ou des soulignements; les espaces et le trait d'union ne sont pas permis.
- Convention : camelCase (`monNom`, `nombreTotal`)

### 🔹 Exemples
```csharp
int age = 25;
char lettre = 'C';
bool estValide = true;
string nom = "Louis";
```

### 🔄 Assignation après déclaration

[Assignation](https://info.cegepmontpetit.ca/notions-csharp/documentation/assignation) : l'assignation utilise `=` pour placer une valeur calculée ou littérale dans une variable.

Vous pouvez aussi déclarer une variable sans lui donner de valeur immédiatement, puis l'affecter plus tard :
```csharp
int score;
score = 100;
```
## 2. Types de base en C#

[Types de données](https://info.cegepmontpetit.ca/notions-csharp/documentation/types-de-donnees) : Types de données

Les types de base sont les types fondamentaux utilisés pour déclarer des variables. Voici les plus courants en C# :

### 🔢 int
- Représente un **entier** (positif ou négatif).
- Exemples :
```csharp
int age = 18;
int score = -10;
```

### 🔣 char
- Représente un **caractère unique**.
- Utilise des apostrophes : `'A'`, `'b'`
- Exemples :
```csharp
char lettre = 'A';
```

### 🧮 double
- Représente un **nombre décimal** avec plus de précision que `float`.
- Exemples :
```csharp
double pi = 3.14159;
double note = 87.5;
```

### 🔁 bool
- Représente un **booléen** : `true` ou `false`
- Utilisé pour les conditions
```csharp
bool estConnecte = true;
bool aFini = false;
```

### 🧵 string
- Représente une **chaîne de caractères**.
- Utilise des guillemets : "Bonjour"
```csharp
string nom = "Alice";
string message = "Bienvenue!";
```

## 3. Concaténation de chaînes

La concaténation consiste à assembler plusieurs chaînes de caractères en une seule.

### ➕ Opérateur `+`
L’opérateur `+` permet de combiner des chaînes et des variables de type `string`.
```csharp
string nom = "Alice";
string message = "Bonjour, " + nom + "!";
Console.WriteLine(message);
```

### 📦 Concaténation avec autres types
On peut concaténer des types différents (comme `int`) avec des chaînes : ils sont automatiquement convertis en texte.
```csharp
int age = 30;
Console.WriteLine("Âge : " + age);
```

### 📏 Mise en forme avancée : interpolation (facultatif)
On peut aussi utiliser l’interpolation (niveau plus avancé, à présenter plus tard) :
```csharp
string nom = "Bob";
Console.WriteLine($"Salut, {nom}!");
```
## 4. Opérations arithmétiques

Les opérations arithmétiques permettent de manipuler des valeurs numériques (`int`, `double`).

### ➕ Opérations de base
```csharp
int a = 10;
int b = 3;

int somme = a + b;       // Addition
int difference = a - b;  // Soustraction
int produit = a * b;     // Multiplication
int quotient = a / b;    // Division entière
int reste = a % b;       // Modulo (reste de la division)
```

### 🧠 Exemple
```csharp
int x = 7;
int y = 2;
Console.WriteLine("x + y = " + (x + y)); //Donne 9
Console.WriteLine("x % y = " + (x % y)); //Donne 1
```

### 🔢 Avec `double`
```csharp
double prix = 12.99;
double taxe = 0.15 * prix;
Console.WriteLine("Taxe : " + taxe); //Donne 1,9485
```

### ⚠️ Division entière
Lorsque vous divisez deux `int`, le résultat est un entier (la partie décimale est supprimée). Pour conserver les décimales, au moins un opérande doit être un `double` ou un autre type à virgule : `7.0 / 2` donne `3.5`. Placer `7 / 2` dans une variable `double` après le calcul donne toujours `3`.
```csharp
int a = 7;
int b = 2;
Console.WriteLine(a / b); // Résultat : 3 (pas 3.5)
```

### 📐 Priorité des opérateurs
En C#, certaines opérations sont effectuées avant d'autres, selon la priorité :
1. Parenthèses `()`
2. Multiplication `*`, division `/`, modulo `%`
3. Addition `+` et soustraction `-`

Exemple :
```csharp
int resultat = 2 + 3 * 4;      // Donne 14 (car 3*4 est calculé avant)
int correct = (2 + 3) * 4;     // Donne 20
```

### 🔁 Permutation de valeurs
Il arrive souvent qu’on veuille échanger la valeur de deux variables. Cette opération s’appelle une **permutation**.

```csharp
int a = 5;
int b = 10;

// Permuter les valeurs de a et b
int temporaire = a;
a = b;
b = temporaire;

Console.WriteLine("a = " + a); // a = 10
Console.WriteLine("b = " + b); // b = 5
```
## 5. Conversion de types

Lorsqu’on lit une entrée utilisateur via `Console.ReadLine()`, on obtient toujours une **chaîne de caractères (`string`)**. Pour utiliser cette entrée comme un nombre, il faut la convertir.

### 🔁 Convertir une `string` en `int`
```csharp
Console.Write("Entrez votre âge : ");
string saisie = Console.ReadLine();
int age = int.Parse(saisie);
```

### 🔁 Convertir en `double`
```csharp
Console.Write("Entrez un prix : ");
string entree = Console.ReadLine();
double prix = double.Parse(entree);
```


Le séparateur décimal attendu par `double.Parse()` dépend de la langue du système : généralement une virgule sur un poste configuré en français. Dans le **code C#**, les littéraux décimaux utilisent toujours un point, comme `12.99`.

### 🛑 Attention aux erreurs !
Si l’utilisateur entre un texte non numérique (ex: "abc"), `int.Parse()` ou `double.Parse()` déclencheront une **erreur d’exécution**.

### ✅ Astuce (plus tard) : `TryParse()`
Pour éviter les erreurs, on peut utiliser `TryParse()`, mais cette méthode sera vue plus tard dans le cours.

Voici les documents de référence :




- [Opérateur](https://info.cegepmontpetit.ca/notions-csharp/documentation/operateur) : un opérateur réalise des opérations arithmétiques, logiques ou d’assignation entre variables et littéraux.
- [Priorité des opérateurs](https://info.cegepmontpetit.ca/notions-csharp/documentation/operateur/priorite) : la priorité des opérateurs détermine l’ordre dans lequel les opérations sont évaluées, comme dans les expressions mathématiques.
- [Littéral](https://info.cegepmontpetit.ca/notions-csharp/documentation/litteral) : un littéral représente une valeur fixe directement inscrite dans le code, comme un nombre ou une chaîne de caractères.

Vous devez réaliser les labos suivants :
 [🧪 Labo 1.2A](/laboratoire/laboratoire1.2A)
 [🧪 Labo 1.2B](/laboratoire/laboratoire1.2B)

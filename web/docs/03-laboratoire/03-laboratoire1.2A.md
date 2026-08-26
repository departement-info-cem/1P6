---
title: A - Questions de compréhension
---

# 🧪 Labo 1.2A – Questions de compréhension

---

## 🟢 Je comprends

> 🧠 **Je comprends :** je peux lire un programme simple et déterminer s'il répond à l'objectif demandé.

> ⚠️ Ces questions doivent être réalisés sans utiliser l'ordinateur.
N'ouvrez pas Visual Studio pour écrire et exécutez le code. L'objectif est de développer votre capacité à comprendre et à analyser le code par vous-même.

Pour chaque question, **lisez l'objectif et le code fourni**.

**Le code est-il correct?**
Si le code est incorrect, **identifiez le problème**.


### Partie A — Variables et nommage

#### Question 1

On veut déclarer une variable pour stocker l'âge d'un étudiant.

```csharp
int age = 18;
```

**Le nom `age` respecte-t-il les standards habituels de nommage en C# ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui.

En C#, les variables utilisent généralement le **camelCase** : le premier mot commence par une minuscule et les mots suivants commencent par une majuscule.

`age` est donc un nom approprié.

</details>

---

#### Question 2

On veut stocker le prénom d'un étudiant.

```csharp
string Prenom = "Louis";
```

**Le code est-il correct ? Le nom `Prenom` respecte-t-il la convention habituelle pour une variable ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Le code est correct, mais le nom `Prenom` ne respecte pas la convention habituelle pour une variable.

On recommande :

```csharp
string prenom = "Louis";
```

Les variables utilisent généralement le **camelCase**.

</details>

---

#### Question 3

On veut stocker une note finale.

```csharp
double noteFinale = 85.5;
```

**Le nom `noteFinale` respecte-t-il les standards de nommage en C# ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui.

`noteFinale` utilise le **camelCase** et le nom décrit clairement le contenu de la variable.

</details>

---

#### Question 4

On veut stocker le nombre d'étudiants.

```csharp
int nb_etudiants = 25;
```

**Le nom `nb_etudiants` respecte-t-il la convention habituelle en C# ? Si non, comment pourrait-on l'améliorer ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non.

En C#, on recommande généralement le **camelCase** plutôt que d'utiliser des underscores pour séparer les mots.

On pourrait écrire :

```csharp
int nbEtudiants = 25;
```

</details>

---

#### Question 5

On veut stocker le prix d'un produit.

```csharp
double prixProduit = 19.99;
```

**Pourquoi `prixProduit` est-il préférable à `p` ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`prixProduit` est plus explicite.

Le nom permet de comprendre immédiatement ce que contient la variable, alors que `p` ne donne aucune information sur son contenu.

</details>

---

#### Question 6

Le code suivant est-il valide en C# ?

```csharp
int 2age = 18;
```

**Si non, quel est le problème ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non.

Un nom de variable ne peut pas commencer par un chiffre.

On pourrait écrire :

```csharp
int age2 = 18;
```

</details>

---

#### Question 7

Le code suivant est-il valide en C# ?

```csharp
int age-etudiant = 18;
```

**Si non, quel est le problème ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non.

Le caractère `-` n'est pas permis dans un identifiant de variable de cette façon. Il est interprété comme l'opérateur de soustraction.

On pourrait écrire :

```csharp
int ageEtudiant = 18;
```

</details>

---

#### Question 8

On veut déclarer une variable contenant le nombre d'heures travaillées.

Laquelle respecte le mieux les conventions de nommage en C# ?

**A.**

```csharp
int NombreHeures = 35;
```

**B.**

```csharp
int nombre_heures = 35;
```

**C.**

```csharp
int nombreHeures = 35;
```

**D.**

```csharp
int nh = 35;
```

<details>
<summary>💡 Vérifier ma réponse</summary>

**Réponse : C**

```csharp
int nombreHeures = 35;
```

Le nom utilise le **camelCase** et décrit clairement le contenu de la variable.

</details>

---

#### Question 9

On veut stocker si un étudiant a réussi son examen.

```csharp
bool reussi = true;
```

**Le nom `reussi` est-il acceptable ? Pourrait-on choisir un nom plus explicite ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui, `reussi` est un nom valide et compréhensible.

Cependant, pour une variable `bool`, un nom comme :

```csharp
bool aReussi = true;
```

est plus explicite, car il indique clairement qu'il s'agit d'une information vraie ou fausse.

</details>

---

#### Question 10

Lequel de ces noms est le plus approprié pour une variable contenant le prix d'un produit ?

**A.**

```csharp
double x = 19.99;
```

**B.**

```csharp
double prix = 19.99;
```

**C.**

```csharp
double PrixProduit = 19.99;
```

**D.**

```csharp
double prix_produit = 19.99;
```

<details>
<summary>💡 Vérifier ma réponse</summary>

**Réponse : B**

```csharp
double prix = 19.99;
```

Le nom est clair, simple et respecte le camelCase.

`PrixProduit` utilise plutôt une convention associée aux noms de types ou de membres publics en C#, tandis que `prix_produit` n'utilise pas la convention habituelle du camelCase.

</details>


### Partie B — Variables et types (8 questions)
#### Question 11

On veut stocker l'âge d'un étudiant.

```csharp
int age = 18;
```

**Le choix du type est-il approprié ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui. `int` permet de stocker un nombre entier.

</details>

---

#### Question 12

On veut stocker le prix d'un produit.

```csharp
double prix = 19.99;
```

**Le choix du type est-il approprié ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui. `double` permet de stocker un nombre qui peut contenir des décimales.

</details>

---

#### Question 13

On veut stocker la première lettre du prénom d'un étudiant.

```csharp
char initiale = 'A';
```

**Le choix du type est-il approprié ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui. `char` permet de stocker un seul caractère.

</details>

---

#### Question 14

On veut savoir si un étudiant a réussi un examen.

```csharp
bool aReussi = true;
```

**Le choix du type est-il approprié ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui. `bool` permet de stocker une valeur vraie ou fausse.

</details>

---

#### Question 15

On veut stocker le nombre d'heures travaillées.

```csharp
string heures = 35;
```

**Le code est-il correct ? Si non, quelle est l'erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non. `35` est un nombre entier, alors que `heures` est déclaré comme `string`.

Le type approprié serait :

```csharp
int heures = 35;
```

</details>

---

#### Question 16

On veut stocker une note sur 100.

```csharp
int note = 87.5;
```

**Le code est-il correct ? Si non, quelle est l'erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non. `87.5` est un nombre décimal. Le type `int` ne permet pas de stocker des décimales.

Le type approprié serait :

```csharp
double note = 87.5;
```

</details>

---

#### Question 17

On veut stocker une lettre.

```csharp
char lettre = "B";
```

**Le code est-il correct ? Si non, quelle est l'erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non. Un `char` doit être placé entre apostrophes.

La bonne déclaration est :

```csharp
char lettre = 'B';
```

</details>

---

#### Question 18

On veut stocker un prénom.

```csharp
string prenom = 'Louis';
```

**Le code est-il correct ? Si non, quelle est l'erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non. Une chaîne de caractères (`string`) doit être placée entre guillemets.

La bonne déclaration est :

```csharp
string prenom = "Louis";
```

</details>

---

### Partie C — Saisie et conversion

#### Question 19

On veut demander l'âge de l'utilisateur.

```csharp
Console.Write("Votre âge : ");
int age = int.Parse(Console.ReadLine());
```

**Le code permet-il de stocker correctement l'âge saisi ? Expliquez.**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui. `Console.ReadLine()` récupère la saisie sous forme de `string`, puis `int.Parse()` la convertit en entier.

</details>

---

#### Question 20

On veut demander un prix.

```csharp
Console.Write("Prix : ");
double prix = double.Parse(Console.ReadLine());
```

**Le code permet-il de stocker correctement le prix saisi ? Expliquez.**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui. `Console.ReadLine()` récupère la saisie comme une chaîne de caractères et `double.Parse()` la convertit en nombre décimal.

</details>

---

#### Question 21

On veut demander le nom d'un utilisateur.

```csharp
Console.Write("Nom : ");
string nom = Console.ReadLine();
```

**Le code est-il correct ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Oui. `Console.ReadLine()` retourne une chaîne de caractères et `nom` est de type `string`.

</details>

---

#### Question 22

```csharp
Console.Write("Votre âge : ");
int age = Console.ReadLine();
```

**Le code est-il correct ? Si non, quelle est l'erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non. `Console.ReadLine()` retourne une valeur de type `string`.

Il faut convertir la saisie avec `int.Parse()` :

```csharp
int age = int.Parse(Console.ReadLine());
```

</details>

---

#### Question 23

```csharp
Console.Write("Prix : ");
double prix = Console.ReadLine();
```

**Le code est-il correct ? Si non, quelle est l'erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non. `Console.ReadLine()` retourne une chaîne de caractères.

Il faut utiliser `double.Parse()` :

```csharp
double prix = double.Parse(Console.ReadLine());
```

</details>

---

#### Question 24

```csharp
Console.Write("Nom : ");
int nom = int.Parse(Console.ReadLine());
```

**Le code est-il correct ? Si non, quelle est l'erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Non. Un nom est une chaîne de caractères. Il faut utiliser le type `string`.

```csharp
string nom = Console.ReadLine();
```

</details>

---

### Affectation

#### Question 25

```csharp
int score;
score = 100;
score = 150;
```

**Quelle est la valeur de `score` à la fin de l'exécution ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

La valeur finale de `score` est **150**.

La deuxième affectation remplace la valeur 100 par 150.

</details>

---

#### Question 26

```csharp
int score = 50;
score = score + 10;
```

**Quelle est la valeur de `score` à la fin de l'exécution ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

La valeur finale de `score` est **60**.

On calcule d'abord `50 + 10`, puis le résultat est affecté à `score`.

</details>

---

### Partie D — Expressions arithmétiques

#### Question 27

```csharp
int resultat = 10 + 5 * 2;
```

**Quelle est la valeur de `resultat` ? Expliquez votre réponse.**

<details>
<summary>💡 Vérifier ma réponse</summary>

La valeur de `resultat` est **20**.

La multiplication est effectuée avant l'addition :

`5 * 2 = 10`

puis :

`10 + 10 = 20`

</details>

---

#### Question 28

```csharp
int resultat = (10 + 5) * 2;
```

**Quelle est la valeur de `resultat` ? Expliquez votre réponse.**

<details>
<summary>💡 Vérifier ma réponse</summary>

La valeur de `resultat` est **30**.

Les parenthèses sont évaluées en premier :

`10 + 5 = 15`

puis :

`15 * 2 = 30`

</details>

---

#### Question 29

```csharp
int resultat = 17 % 5;
```

**Quelle est la valeur de `resultat` ? Que représente l'opérateur `%` ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

La valeur de `resultat` est **2**.

L'opérateur `%` donne le reste de la division entière.

`17 ÷ 5` donne 3 avec un reste de **2**.

</details>

---

#### Question 30

```csharp
int resultat = 7 / 2;
```

**Quelle est la valeur de `resultat` ? Expliquez votre réponse.**

<details>
<summary>💡 Vérifier ma réponse</summary>

La valeur de `resultat` est **3**.

Les deux opérandes sont de type `int`. La division est donc une division entière et la partie décimale est supprimée.

</details>


---


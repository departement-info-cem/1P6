---
description: Fonctions, valeurs de retour et portée des variables
---

# 🧩 Fonctions et portée des variables


---

## 🏆 QUIZ de révision 
<Quiz file="/quiz/3.1-if.json" />



## 1️⃣ Introduction : Fonctions déjà vues

> 💡 **Définition**  
> Une fonction est un bloc de **code nommé**, conçu pour **exécuter** une **tâche** précise.

> Elle peut recevoir des informations en **entrée** (appelées **paramètres**) et retourner un résultat (appelé **valeur de retour**).


---

### 🔍 Exemples déjà utilisés (sans qu’on le dise)


| Fonction                        | Ce qu’elle fait                              | Type de Fonction                              |
|-------------------------------|----------------------------------------------|----------------------------------------------|
| `Console.WriteLine("Salut")`  | Affiche du texte à l’écran                   | Fonction avec paramètre, sans retour (`void`) |
| `Console.ReadLine()`          | Lit du texte saisi par l’utilisateur         | Fonction sans paramètre, avec retour (`string`) |
| `int.Parse("123")`            | Convertit une chaîne en entier (`int`)       | Fonction avec paramètre et retour (`int`)     |
---

> 📌 **À retenir**  
> - Une fonction peut appartenir à une **classe** (`Console`, `int`, etc.).  
> - On écrit : `Classe.Methode(paramètre)`  
> - Certaines fonctions **renvoient un résultat** (`int.Parse`), d’autres **non** (`Console.WriteLine`).
> - La fonction **Main()** est exécutée lorsqu'on déclenche l'exécution du programme.
> - On crée les nouvelles fonctions en dehors du **Main**.

[🔗 Lire plus sur les fonctions (Notions C#)](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/methode)

---

## ➕ Créer une fonction

:::note Structure de la fonction
```csharp
static void MaSuperFonction() 
{
    // Code à exécuter dans la fonction
}
```
 - **`static`** Mot clé, nous en reparlerons lorsque que la programmation objet sera introduite, pour l'instant ce n'est une mot clé obligatoire.
 - **`void`** Type de la valeur de retour (int, double, string, etc.). Ici void signifie qu'il n'y a aucun retour
 - **`MaSuperFonction`** Nom de la fonction, chaque fonction doit avoir un nom unique.
 - Les **`()`** Emplacement pour les paramètres de la fonctione, les `()`sont obligatoires même si l'on n'a pas de paramètre.
 - Les **`{ }`** Porté de la fonction. Tout le code entre les `{ }` sera exécuté lorsque nous ferons un appel à la fonction.
:::
:::danger Emplacement de la fonction
Attention! On ne peut pas placer une fonction à n'importe quel endroit, tant que nous n'avons pas vu la programmation objet, nous les placerons au même niveau que la fonction `Main`, voici un exemple. 👇
```csharp

namespace Laboratoire1_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ...
        }

        static void MaSuperFonction() 
        {
            // ...
        }

        static void FonctionEncorePlusSuper() 
        {
            // ...
        }

        static void SuperFonctionInfinie() 
        {
            // ...
        }
    }
}

```
:::

## 2️⃣ Déclaration d’une fonction (sans paramètre, sans retour)

> 🎯 **But** : éviter de copier-coller du code plusieurs fois, rendre le programme plus lisible et réutilisable.

---

### ❌ Code répétitif sans fonction

```csharp
Console.WriteLine("Bonjour Léa !");
Console.WriteLine("Bonjour Marco !");
Console.WriteLine("Bonjour Inès !");
Console.WriteLine("Bonjour Léa !");
Console.WriteLine("Bonjour Marco !");
Console.WriteLine("Bonjour Inès !");
````

> ⚠️ **Problème**
> Si on veut modifier une salutation ou ajouter un nom, il faut changer plusieurs lignes à la main.

---

### ✅ Avec fonction (sans paramètre, sans retour)

```csharp
static void DireBonjour()
{
    Console.WriteLine("Bonjour Léa !");
    Console.WriteLine("Bonjour Marco !");
    Console.WriteLine("Bonjour Inès !");
}

// Appels
DireBonjour();
DireBonjour();
```

> 💡 **Explication**
>
> * On crée une fonction nommée `DireBonjour`
> * Elle contient un **bloc de code** (délimité par `{ ... }`)
> * On peut **l'appeler plusieurs fois** sans copier le contenu

---

> 📌 **À retenir**
>
> * `void` signifie que la fonction **ne retourne rien**
> * Les instructions à l’intérieur du bloc sont exécutées **à chaque appel**
> * C’est un moyen de **réutiliser du code**

---

## 3️⃣ Fonction avec paramètre

---

### 🔄 Limitation d'une fonction sans paramètre

```csharp
static void DireBonjourLéa()
{
    Console.WriteLine("Bonjour Léa !");
}

static void DireBonjourMarco()
{
    Console.WriteLine("Bonjour Marco !");
}

static void DireBonjourInès()
{
    Console.WriteLine("Bonjour Inès !");
}

// Appels
DireBonjourLéa();
DireBonjourMarco();
DireBonjourInès();
```

> ⚠️ **Problème.**
> On a dû créer **une fonction par prénom**.
> Le code devient **lourd**, **non flexible**, et **pas maintenable**.

---

### ✅ Fonction avec paramètre

```csharp
static void Saluer(string prenom)
{
    Console.WriteLine("Bonjour " + prenom + " !");
}

// Appels
Saluer("Léa");
Saluer("Marco");
Saluer("Inès");
```

> ✅ **Solution propre**
> Une seule fonction pour **plusieurs cas**. On envoie une  **valeur de paramètre différente** à chaque appel.

---

> 📦 **Métaphore du sac à dos**
> Imagine que tu donnes un **sac** à la fonction. Tu y mets un **prénom**.
> La fonction ouvre le sac, lit le prénom, dit bonjour… puis **jette le sac** une fois le travail terminé.

---

> 📌 **À retenir**
>
> * Un **paramètre** est une **variable temporaire** envoyée à la fonction
> * Elle existe **uniquement à l’intérieur du bloc**
> * Elle permet de rendre la fonction **plus générale et réutilisable**

---

## 4️⃣ Fonction avec retour

> 🎯 **Objectif** : créer une fonction qui **renvoie un résultat** à utiliser ailleurs dans le programme.

---

### 🧪 Exemple : une addition

```csharp
static int Addition(int a, int b)
{
    int somme = a + b;
    return somme;
}

// Utilisation
int resultat = Addition(3, 4);
Console.WriteLine("La somme est : " + resultat);
```

---

> 💡 **Explication**
>
> * `int Addition(...)` signifie que la fonction **retourne un entier** (`int`)
> * Elle reçoit deux paramètres (`a` et `b`)
> * Elle effectue une opération, puis **renvoie le résultat** avec `return`
> * On peut **stocker le résultat** dans une variable (`resultat`) et l’utiliser ensuite

---

> ⚠️ **Attention : `return` interrompt l’exécution**
> Dès que l'instruction `return` est atteinte, la fonction **s'arrête immédiatement**.
> Aucune ligne après `return` ne sera exécutée.
> Cela permet de **sortir rapidement** avec une valeur, mais cela signifie aussi que **tout code placé après ne sera jamais lu**.

---

> 📌 **À retenir**
>
> * Le type avant le nom de la fonction (ex. `int`) = **type du résultat retourné**
> * `return` sert à **renvoyer une valeur**
> * Le résultat peut être affiché, stocké ou utilisé dans un calcul

---

## 5️⃣ Portée des variables

> 🎯 **Objectif** : comprendre **où une variable existe** (sa *portée*), pour éviter les erreurs courantes.

---

### 🌍 Contexte : Programme Console avec différentes portées


```csharp
using System;

class Program
{
    static int c = 100; // Variable de classe (globale à toutes les fonctions)

    static void Main()
    {
        int a = 10; // Variable locale à Main

        if (a > 5)
        {
            int b = 20; // Variable locale au bloc 'if'
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("c = " + c); // OK : c est globale
        }

        // Console.WriteLine(b);  // ❌ Erreur : b n'existe plus ici
        Console.WriteLine("a = " + a); // OK
        Console.WriteLine("c = " + c); // OK
    }

    static void AfficherC()
    {
        Console.WriteLine("Valeur de c : " + c); // OK : c est partagée entre les fonctions
        // Console.WriteLine(a); // ❌ Erreur : a est local à Main
    }
}
```

---

### 🔍 Explication

* `a` est locale à la fonction `Main`
* `b` est locale au bloc `if` → **disparaît après le bloc**
* `c` est **globale à la classe** → accessible dans toutes les fonctions

---

> 📌 **À retenir**
>
> * `{ ... }` = **bloc de code**
> * Une variable **locale** vit dans son bloc/fonction uniquement
> * Une variable **de classe** vit tant que l’objet existe

---

> ⚠️ **Erreurs fréquentes**
>
> * Utiliser une variable après sa disparition (ex : `b` hors du bloc)
> * Accéder à une variable locale depuis une autre fonction


[🔗 Lire plus sur la portée des variables (Notions C#)](https://info.cegepmontpetit.ca/notions-csharp/documentation/variable/portee-et-duree-de-vie)

---

## 6️⃣ Fonctions sur les chaînes (`string`)

> 🎯 **Objectif** : utiliser les fonctions intégrées pour **manipuler et formater** des chaînes de caractères.

---

### 🔧 Exemples pratiques

```csharp
string mot = "salut";
Console.WriteLine(mot.ToUpper());    // SALUT

string cri = "BONJOUR";
Console.WriteLine(cri.ToLower());    // bonjour

int age = 25;
Console.WriteLine(age.ToString());   // "25"
```

🔗 [Notions C# – Chaîne (string)](https://info.cegepmontpetit.ca/notions-csharp/documentation/chaine-string)

---

### 🧩 `ToString()` – Convertir une valeur en texte

#### 🛠️ Exemple concret : affichage combiné avec du texte

```csharp
int age = 21;
Console.WriteLine("Âge de l'utilisateur : " + age.ToString());
```

> 💡 `ToString()` transforme une valeur (comme un `int`) en texte, ce qui permet de la concaténer avec d'autres chaînes.

---

### ✅ Conversion automatique vers `string`

```csharp
int age = 21;
Console.WriteLine("Âge de l'utilisateur : " + age);  // ✅ fonctionne sans ToString()
```

Mais si on veut **stocker** une valeur numérique dans une variable `string` :

```csharp
int nombre = 42;
string texte = nombre.ToString(); // ✅ nécessaire ici
```

---

### ✨ Formatage courant avec `ToString()`

```csharp
double montant = 1234.56;

Console.WriteLine(montant.ToString("C"));     // "$1,234.56" (monétaire)
Console.WriteLine(montant.ToString("F2"));    // "1234.56" (2 décimales)
Console.WriteLine(montant.ToString("N0"));    // "1,235" (arrondi, séparateur)
```

> ℹ️ Le format dépend de la **langue du système** (ex. : `$` ou `€`, point ou virgule)

🔗 [Notions C# – Spécificateurs de formats d’affichage](https://info.cegepmontpetit.ca/notions-csharp/documentation/conversion-transtypage#sp%C3%A9cificateurs-de-formats-daffichage)

---

### 🧠 À retenir

| Expression          | Type    | Parenthèses | Renvoie           |
| ------------------- | ------- | ----------- | ----------------- |
| `mot.ToUpper()`     | Fonction | Oui         | Chaîne (`string`) |
| `mot.ToLower()`     | Fonction | Oui         | Chaîne (`string`) |
| `valeur.ToString()` | Fonction | Oui         | Chaîne (`string`) |

> ✅ Les **fonctions** permettent de transformer ou manipuler les données






Vous devez réaliser les labos suivants :
 [🧪 Labo 2.2A](/laboratoire/laboratoire2.2A)
 [🧪 Labo 2.2B](/laboratoire/laboratoire2.2B)
 [🧪 Labo 2.2C](/laboratoire/laboratoire2.2C)

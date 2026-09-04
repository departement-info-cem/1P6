---
title: A - Fonctions avec paramètres
---

# 🧪 Labo 3.1A – Fonctions avec paramètres

Nous allons réaliser une série d’exercices permettant de pratiquer la **définition de fonctions avec paramètres** en C#.

Pour **chaque exercice**, créez un **nouveau projet** dans Visual Studio.

---

## 📌 Rappel : Syntaxe d’une fonction avec paramètres

```csharp
static void NomDeLaFonction(type pParam1, type pParam2)
{
    // Instructions
}
```

### Exemple

```csharp
static void MessageDeBienvenue(string pPrenom, string pNom)
{
    Console.WriteLine("Bienvenue " + pPrenom + " " + pNom);
}
```

---

## 🧩 Exercices

### 🔹 Exercice 1 – Message personnalisé

Créez une fonction prenant **trois paramètres** : le nom, l'âge et la ville.

Elle doit afficher une phrase du style :

> Bonjour Benoit Caldairou, vous avez 20 ans et vous venez de Montréal.

---

### 🔹 Exercice 2 – Périmètre d’un rectangle

Créez une fonction qui affiche le **périmètre d’un rectangle**, à partir de sa largeur et de sa hauteur.

> Formule : périmètre = 2 \* (largeur + hauteur)

---

### 🔹 Exercice 3 – Table de multiplication

Créez une fonction prenant un **nombre entier** en paramètre et affichant sa **table de multiplication jusqu’à 10**.

Exemple pour 3 :

```
3 x 1 = 3
3 x 2 = 6
...
3 x 10 = 30
```

---

### 🔹 Exercice 4 – Pyramide d’étoiles

Créez une fonction qui affiche une pyramide comme ceci :

```
*
**
***
****
*****
```

Cette fonction doit prendre en paramètre le **nombre de lignes à afficher**.

---

### 🔹 Exercice 5 – Année bissextile

Créez une fonction prenant une **année** en paramètre et qui affiche si elle est **bissextile ou non**.

> Rappel : Une année est bissextile si :
>
> * Elle est divisible par 400, **ou**
> * Elle est divisible par 4 **sans** être divisible par 100

Exemples d'années bissextiles : 1600, 2000, 1996, 1992, 2024
Exemples **non** bissextiles : 1997, 2006, 1900

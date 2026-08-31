---
title: A - Questions de compréhension
---

# 🧪 Labo 2.1A – Questions de compréhension

---

## 🟢 Je comprends

> 🧠 **Je comprends :** je peux lire un programme simple et déterminer s'il répond à l'objectif demandé.

> ⚠️ Ces questions doivent être réalisés sans utiliser l'ordinateur.
N'ouvrez pas Visual Studio pour écrire et exécutez le code. L'objectif est de développer votre capacité à comprendre et à analyser le code par vous-même.

Pour chaque question, **lisez l'objectif et le code fourni**.

**Le code est-il correct?**
Si le code est incorrect, **identifiez le problème**.


### Partie A — Expressipon booléennes

#### Question 1

Dans un musée, les enfants de moins de 6 ans et les personnes de plus de 65 ans ont accès gratuitement.

Un étudiant propose l'expression suivante pour déterminer si une personne a droit à l'accès gratuit :

```csharp
age < 6 || age > 65
```
Cette expression répond-elle correctement au besoin ?

<details>
<summary>💡 Vérifier ma réponse</summary>

`Oui` 

</details>

---

#### Question 2

On veut vérifier si une note est entre 0 et 100 inclusivement.

L'expression suivante permet-elle de vérifier correctement ce besoin ?

```csharp
note >= 0 && nombre <= 100
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`oui` 

</details>

---

#### Question 3

On veut vérifier si un nombre est entre 10 et 20 inclusivement OU supérieur à 50.

L'expression suivante permet-elle de vérifier correctement ce besoin ?

```csharp
nombre >= 10 && nombre <= 20 || nombre > 50
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`Oui` 

</details>

---

#### Question 4

Une personne peut entrer si elle est majeure et possède un billet, ou si elle est accompagnée d'un adulte.

L'expression suivante permet-elle de vérifier correctement ce besoin ?

```csharp
(age >= 18 && aUnBillet) || !accompagnee
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non` 

La condition devrait être :

```csharp
(age >= 18 && aUnBillet) || accompagnee
```

</details>

---


#### Question 5

Quelle est la valeur de l'expression suivante ?

```csharp
(8 > 5 && 3 > 10) || !(4 == 7)
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`true` 

</details>

---


#### Question 6

Quelle est la valeur de resultat à la fin du programme ?

```csharp
int a = 20;
int resultat = 0;

if (a >= 18)
{
    resultat = 100;
}
if (a >= 10)
{
    resultat = 50;
}
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`50` 

</details>

---


#### Question 7

Quelle est la valeur de resultat à la fin du programme ?

```csharp
int a = 20;
int resultat = 0;

if (a >= 18)
{
    resultat = 100;
}
else if (a >= 10)
{
    resultat = 50;
}
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`100` 

</details>

---


#### Question 8

Quelle est la valeur de resultat à la fin du programme ?

```csharp
int age = 20;
int resultat = 0;

if (age >= 18)
{
    if (age >= 21)
    {
        resultat = 2;
    }
    else
    {
        resultat = 1;
    }
}
else
{
    resultat = 0;
}
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`1` 

</details>

---


#### Question 9

Que va afficher le programme suivant ?

```csharp
int age = 20;
bool aUnBillet = true;

if (age >= 18 && aUnBillet)
{
    Console.WriteLine("Accès autorisé");
}
else
{
    Console.WriteLine("Accès refusé");
}
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`Accès autorisé` 

</details>

---


#### Question 9

Que va afficher le programme suivant ?

```csharp
int age = 20;
bool aUnBillet = true;

if (age >= 18)
{
    if (aUnBillet)
    {
        Console.WriteLine("Accès autorisé");
    }
    else
    {
        Console.WriteLine("Accès refusé");
    }
}
else
{
    Console.WriteLine("Accès refusé");
}
```

<details>
<summary>💡 Vérifier ma réponse</summary>

`Accès autorisé` 

</details>

---


#### Question 10

Une personne peut accéder à une activité si elle est majeure et possède un billet.

Un étudiant propose les deux solutions présentées aux questions 8 et 9.

Les deux solutions répondent-elles au même besoin ?


<details>
<summary>💡 Vérifier ma réponse</summary>

`Oui` 

</details>

---
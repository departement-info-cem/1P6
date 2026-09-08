---
title: A - Questions de compréhension - Les méthodes
---

# 🧪 Labo 3.1A – Questions de compréhension - Les méthodes

---

## 🟢 Je comprends

> 🧠 **Je comprends :** je peux lire un programme simple et déterminer s'il répond à l'objectif demandé.

> ⚠️ Ces questions doivent être réalisés **sans utiliser l'ordinateur**.
N'ouvrez pas Visual Studio pour écrire et exécutez le code. L'objectif est de développer votre capacité à comprendre et à analyser le code par vous-même.

Pour chaque question, **lisez l'objectif et le code fourni**.

**Le code est-il correct?**
Si le code est incorrect, **identifiez le problème**.

### Question 1 — La méthode répond-elle au besoin ?

**Besoin :**
On veut afficher le nom et l’âge d’une personne. La méthode doit recevoir ces deux informations en paramètres.

```csharp
static void AfficherPersonne(string nom, int age)
{
    Console.WriteLine("Nom : " + nom);
    Console.WriteLine("Âge : " + age);
}
```

**Est-ce que cette méthode répond au besoin ? Justifiez votre réponse.**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Oui`.

La méthode reçoit bien le nom et l’âge en paramètres et les affiche.

</details>


---

### Question 2 — Comprendre un appel

On possède la méthode :

```csharp
static void AfficherAge(int age)
{
    Console.WriteLine(age);
}
```

Puis :

```csharp
int monAge = 20;
AfficherAge(monAge);
```

**Quelle valeur est reçue par le paramètre `age` lors de l’appel ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Le paramètre `age` reçoit la valeur `20`.

L’appel :

```csharp
AfficherAge(monAge);
```

transmet la valeur contenue dans `monAge`.

</details>

---

### Question 3 — Paramètre ou argument ?

```csharp
static void AfficherAge(int age)
{
    Console.WriteLine(age);
}

static void Main()
{
    int monAge = 20;
    AfficherAge(monAge);
}
```

**Dans ce code, identifiez :**

* le paramètre ;
* l’argument.

<details>
<summary>💡 Vérifier ma réponse</summary>

Le **paramètre** est :

```csharp
int age
```

L’**argument** est :

```csharp
monAge
```

Le paramètre apparaît dans la définition de la méthode et l’argument apparaît lors de l’appel.

</details>

---

### Question 4 — Prédire l’affichage

```csharp
static void AfficherMessage(string message)
{
    Console.WriteLine(message);
}

static void Main()
{
    AfficherMessage("Bonjour");
    AfficherMessage("Bienvenue");
}
```

**Qu’est-ce qui sera affiché ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

```text
Bonjour
Bienvenue
```

La méthode est appelée deux fois avec deux arguments différents.

</details>

---

### Question 5 — La méthode est-elle réutilisable ?

```csharp
static void AfficherPrix()
{
    double prix = 25.50;
    Console.WriteLine(prix);
}
```

**Un étudiant affirme :**

> « Cette méthode peut afficher n’importe quel prix sans modifier son code. »

**Cette affirmation est-elle vraie ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non`.

La valeur `25.50` est directement écrite dans la méthode.

La méthode affiche toujours cette valeur lorsqu'elle est appelée.

</details>

---

### Question 6 — Comprendre la portée d’une variable

```csharp
static void Main()
{
    int age = 20;

    if (age >= 18)
    {
        int permis = 1;
        Console.WriteLine(permis);
    }

    Console.WriteLine(age);
}
```

**Pourquoi peut-on utiliser `age` après le `if`, mais pas `permis` ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`age` a été déclarée dans `Main`. Elle est donc accessible dans le reste de `Main`.

`permis` a été déclarée à l’intérieur du bloc `if`. Sa portée est limitée à ce bloc.

</details>

---

### Question 7 — Portée entre deux méthodes

```csharp
static void Main()
{
    int age = 20;
    AfficherAge();
}

static void AfficherAge()
{
    Console.WriteLine(age);
}
```

**Le programme peut-il être compilé ? Expliquez l’erreur.**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non`.

`age` est une variable locale de `Main`.

Elle n'est pas accessible dans `AfficherAge()`.

Chaque méthode possède sa propre portée pour ses variables locales.

</details>

---

### Question 8 — Comprendre le rôle du paramètre

On modifie le code précédent :

```csharp
static void Main()
{
    int age = 20;
    AfficherAge(age);
}

static void AfficherAge(int age)
{
    Console.WriteLine(age);
}
```

**Pourquoi cette version fonctionne-t-elle alors que la précédente ne fonctionnait pas ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Parce que la valeur de `age` est maintenant **transmise à la méthode** lors de l'appel.

```csharp
AfficherAge(age);
```

La méthode reçoit cette valeur dans son paramètre :

```csharp
AfficherAge(int age)
```

</details>

---

### Question 9 — Erreur dans la définition

```csharp
static void AfficherPersonne(string nom, int)
{
    Console.WriteLine(nom);
}
```

**Cette définition contient-elle une erreur ? Si oui, laquelle ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Oui`.

Le deuxième paramètre possède un type (`int`), mais aucun nom.

Il faudrait par exemple :

```csharp
static void AfficherPersonne(string nom, int age)
```

</details>

---

### Question 10 — Erreur dans l’appel

```csharp
static void AfficherPersonne(string nom, int age)
{
    Console.WriteLine(nom);
    Console.WriteLine(age);
}
```

L’étudiant écrit :

```csharp
AfficherPersonne("Amine");
```

**L’appel est-il correct ? Expliquez.**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non`.

La méthode possède deux paramètres :

```text
string nom
int age
```

L'appel fournit seulement un argument.

Il manque donc l'âge.

</details>

---

### Question 11 — Erreur dans l’ordre des arguments

```csharp
static void AfficherPersonne(string nom, int age)
{
    Console.WriteLine(nom);
    Console.WriteLine(age);
}
```

L’étudiant écrit :

```csharp
AfficherPersonne(20, "Amine");
```

**L’appel est-il correct ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non`.

Le premier paramètre est un `string`, mais l'appel fournit un `int`.

Le deuxième paramètre est un `int`, mais l'appel fournit un `string`.

L'appel correct serait :

```csharp
AfficherPersonne("Amine", 20);
```

</details>

---

### Question 12 — Comprendre une valeur de retour

```csharp
static int CalculerSomme(int a, int b)
{
    return a + b;
}
```

**Que retourne la méthode lorsque l'on écrit :**

```csharp
CalculerSomme(10, 5);
```

<details>
<summary>💡 Vérifier ma réponse</summary>

La méthode retourne :

```text
15
```

car :

```text
10 + 5 = 15
```

</details>

---

### Question 13 — Comprendre l’utilisation du retour

```csharp
static int CalculerSomme(int a, int b)
{
    return a + b;
}

static void Main()
{
    int resultat = CalculerSomme(10, 5);
    Console.WriteLine(resultat);
}
```

**Quelle valeur sera affichée ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

```text
15
```

La méthode retourne `15`, qui est ensuite stocké dans `resultat`.

</details>

---

### Question 14 — Afficher ou retourner ?

Comparez :

```csharp
static void CalculerSomme1(int a, int b)
{
    Console.WriteLine(a + b);
}
```

et :

```csharp
static int CalculerSomme2(int a, int b)
{
    return a + b;
}
```

**Quelle méthode affiche directement le résultat ? Quelle méthode retourne le résultat ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`CalculerSomme1` **affiche** le résultat.

`CalculerSomme2` **retourne** le résultat.

La différence est importante : une valeur retournée peut être récupérée et réutilisée par le programme appelant.

</details>

---

### Question 15 — Erreur de type de retour

```csharp
static int CalculerSomme(int a, int b)
{
    Console.WriteLine(a + b);
}
```

**Pourquoi cette méthode provoque-t-elle une erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

La méthode est déclarée avec un type de retour `int` :

```csharp
static int CalculerSomme(...)
```

Elle doit donc retourner une valeur `int`.

Or, elle ne contient aucun `return`.

</details>

---

### Question 16 — `void` et `return`

```csharp
static void CalculerSomme(int a, int b)
{
    return a + b;
}
```

**Pourquoi cette méthode provoque-t-elle une erreur ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

Parce que la méthode est déclarée `void`.

Une méthode `void` ne retourne pas de valeur.

Ici :

```csharp
return a + b;
```

essaie de retourner une valeur.

</details>

---

### Question 17 — Mauvais type retourné

```csharp
static bool EstMajeur(int age)
{
    return age >= 18;
}
```

**Le type de retour `bool` est-il approprié ? Expliquez.**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Oui`.

L'expression :

```csharp
age >= 18
```

produit une valeur booléenne :

```text
true
```

ou :

```text
false
```

Le type `bool` est donc approprié.

</details>

---

### Question 18 — Identifier l’erreur

```csharp
static int EstMajeur(int age)
{
    return age >= 18;
}
```

**Cette méthode peut-elle être compilée ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non`.

La méthode est déclarée pour retourner un `int`, mais :

```csharp
age >= 18
```

produit un `bool`.

Le type de retour devrait être :

```csharp
bool
```

</details>

---

### Question 19 — Utiliser le résultat d’une méthode

```csharp
static int Doubler(int nombre)
{
    return nombre * 2;
}

static void Main()
{
    int resultat = Doubler(7);
    Console.WriteLine(resultat);
}
```

**Quelle est la valeur de `resultat` après l’appel de `Doubler` ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`resultat` vaut :

```text
14
```

La méthode reçoit `7` et retourne :

```text
7 × 2 = 14
```

</details>

---

### Question 20 — Comprendre la portée d’un paramètre

```csharp
static void Afficher(int nombre)
{
    Console.WriteLine(nombre);
}

static void Main()
{
    int valeur = 10;
    Afficher(valeur);

    Console.WriteLine(nombre);
}
```

**La dernière instruction peut-elle être compilée ? Pourquoi ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non`.

Le paramètre `nombre` appartient à la méthode `Afficher`.

Il n'est pas accessible dans `Main`.

La portée d'un paramètre est limitée à la méthode dans laquelle il est déclaré.

</details>

---

### Question 21 — Comprendre `return`

```csharp
static int Calculer(int nombre)
{
    int resultat = nombre * 2;
    return resultat;

    Console.WriteLine("Bonjour");
}
```

**L’instruction `Console.WriteLine("Bonjour")` sera-t-elle exécutée ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

`Non`.

L'instruction :

```csharp
return resultat;
```

termine immédiatement l'exécution de la méthode.

Les instructions placées après le `return` ne sont donc pas exécutées.

</details>

---

### Question 22 — Réutilisation d’une méthode retournant une valeur

```csharp
static int Doubler(int nombre)
{
    return nombre * 2;
}

static void Main()
{
    int resultat = Doubler(Doubler(5));
    Console.WriteLine(resultat);
}
```

**Quelle valeur sera affichée ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

```text
20
```

On calcule d'abord :

```text
Doubler(5) → 10
```

Puis :

```text
Doubler(10) → 20
```

Donc `resultat` vaut `20`.

</details>

---

### Question 23 — Comprendre une méthode plus complexe

```csharp
static bool EstPositif(int nombre)
{
    if (nombre > 0)
        return true;

    return false;
}
```

**Que retourne la méthode pour chacun des appels suivants ?**

```csharp
EstPositif(10);
EstPositif(-3);
EstPositif(0);
```

<details>
<summary>💡 Vérifier ma réponse</summary>

```text
EstPositif(10) → true
EstPositif(-3) → false
EstPositif(0)  → false
```

La condition est :

```csharp
nombre > 0
```

`0` n'est donc pas considéré comme positif.

</details>

---

### Question 24 — Comprendre l’erreur dans la récupération du résultat

```csharp
static double CalculerMoyenne(double a, double b)
{
    return (a + b) / 2;
}

static void Main()
{
    int moyenne = CalculerMoyenne(10, 15);
}
```

**Pourquoi cette instruction pose-t-elle problème ?**

<details>
<summary>💡 Vérifier ma réponse</summary>

La méthode retourne un `double` :

```csharp
static double CalculerMoyenne(...)
```

mais le programme essaie de placer le résultat dans une variable `int`.

```csharp
int moyenne
```

Les types ne correspondent pas.

</details>

---

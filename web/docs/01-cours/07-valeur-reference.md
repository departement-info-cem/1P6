
# Types valeur vs types référence

## 🎯 Objectifs de la séance

À la fin de cette séance, vous serez capable de :

- distinguer les **types valeur** et les **types référence**
- expliquer la différence de comportement lors d’une affectation
- prédire l’effet d’un passage en paramètre dans une méthode

---

## 🧠 Mise en situation

Considérons la méthode suivante :

```csharp
void Doubler(int val)
{
    val = val * 2;
}
```

Et le code suivant dans le `Main` :

```csharp
int x = 50;
Doubler(x);
Console.WriteLine(x);
```
**Question :**
Quelle valeur sera affichée dans la console ?

- A) 50
- B) 100

👉 **Réponse : 50**

Pourquoi ? Parce que la méthode `Doubler()` est définie avec un paramètre de type `int`, qui est un **type valeur**. Lors de l’appel de la méthode, la valeur de l’argument est copiée dans le paramètre. La méthode travaille donc sur une copie, pas sur la variable originale.

Globalement, voici ce qu’il se passe :

- Lorsque la variable `x` est créée, le programme lui alloue un espace mémoire et y stocke la valeur `50`.
- La variable `x` est ensuite passée comme argument à la méthode `Doubler()`.
- Lorsque `Doubler()` est appelée, le paramètre `val` est créé.
- Le programme lui alloue un **nouvel espace mémoire** et y stocke une **copie** de la valeur de `x`, soit `50`.
- Les variables `x` et `val` occupent donc **deux emplacements mémoire distincts**.

Ainsi, modifier la valeur de `val` n’a **aucun impact** sur la valeur de `x`.

> ⚠️ Ceci est vrai uniquement pour les **types valeur**.  
> Nous verrons qu’avec un **type référence**, le comportement sera très différent.

---

## 📦 Comprendre les types valeur

### Définition

Un type valeur est un type pour lequel la variable contient **directement la donnée elle-même**.

Conséquences :

- La variable stocke **sa propre valeur**
- Lors d’une affectation ou d’un passage en paramètre, la valeur est **copiée**
- Chaque variable possède donc **une copie indépendante**
- Modifier une variable n’affectera pas les autres variables obtenues par copie

En C#, les types valeur incluent notamment :

- `int`
- `double`
- `bool`
- `char`
- `decimal`
- `enum`

💡 Astuce *Visual Studio* : lorsque vous survolez un type valeur avec la souris, l’info-bulle indique généralement qu’il s’agit d’un `struct`.

---

### Exemple — Copie de valeur

```csharp
int nombre1 = 12;
int nombre2 = 99;

nombre1 = nombre2;
nombre2 = 5;
```

Quelles seront les valeurs finales ?

```
nombre1 = 99
nombre2 = 5
```

➡️ Une **copie** a été effectuée lors de l’affectation.


---

### ⚠️ Coût des copies
Copier un petit type valeur (comme *int, double, bool*) est peu coûteux.
Cependant, si une grosse structure volumineuse est copiée fréquemment, cela peut avoir un coût en performance !

**✅ Solution possible**

Selon la situation, on peut choisir d'utiliser plutôt un **type référence**.

---

## 🔗 Comprendre les types référence

### Définition

Un **type référence** est un type pour lequel la variable ne contient pas directement la donnée, mais plutôt **une référence vers un objet**.

>Une référence (ou une adresse) est une valeur numérique représentant l’emplacement d’un élément dans la mémoire vive de l’ordinateur. La référence est en quelque sorte une valeur numérique non modifiable contenant une adresse qui occupe 4 octets.

Conséquences :

- L’objet est stocké ailleurs en mémoire
- Plusieurs variables peuvent référencer **le même objet**
- Modifier l’objet affectera toutes les variables qui réfèrent vers ce même objet

En C#, les types référence incluent notamment :

- `class`
- `string`
- les tableaux (`int[]`, `double[]`, etc.)
- les collections (`List<T>`, `Dictionary<T>`, etc.)

💡 Astuce *Visual Studio* : lorsque vous survolez un type référence, l’info-bulle indique généralement qu’il s’agit d’une `class`.



---

### Exemple — Tableau

```csharp
int[] a = { -5 };
int[] b = a;

a[0] = 42;
Console.WriteLine(b[0]);
```

Résultat :

```
42
```

➡️ `a` et `b` pointent vers le **même objet tableau**

---

### Exemple — Passage par référence

Reprenons maintenant l'exemple initial en modifiant la méthode `Doubler()` pour que celle-ci ait comme paramètre un tableau d'entiers `int[]`, qui est un **type référence**.
```csharp
void Doubler(int[] val)
{
    val[0] = val[0] * 2;
}
```
```csharp
int[] x = { 50 };
Doubler(x);
Console.WriteLine(x[0]);
```

La valeur affichée dans la console sera cette fois-ci :

```
100
```

---

### Exemple — Affectation de références

```csharp
Thermostat t1 = new Thermostat(12);
Thermostat t2 = new Thermostat(12);

t1 = t2;
```

Après l’affectation :

- `t1` et `t2` pointent vers le **même objet**
- l’ancien objet de `t1` devient inaccessible
- il sera éventuellement nettoyé par le *garbage collector*

---

### 🚫 null

`null` représente **l’absence de référence vers un objet.**
Une variable de type référence peut contenir `null` :

```csharp
Thermostat t = null;
```

Cela signifie que la variable ne réfère vers **aucun objet.**

---
## 🧩 Petit *puzzle* pour voir si vous avez bien compris...

### 📘 Cas 1 — Liste de int

Liste de nombres : les valeurs sont stockées **directement dans la collection**.

```
Variable listeEntiers
     │
     ▼
+----------------------+
|   List<int> objet    |
|----------------------|
|  5   8   12   99     |
+----------------------+
```

➡️ La variable contient une **référence vers la liste**  
➡️ La liste contient **les valeurs**

---

### 📗 Cas 2 — Liste d’objets

Liste d’objets : la liste contient des **références vers des objets**

```
Variable listeObjets
      │
      ▼
+------------------------------+
|        List<Personne>        |
|------------------------------|
|   refA     refB     refC     |
+------------------------------+
     │         │         │
     ▼         ▼         ▼
  PersonneA  PersonneB  PersonneC
```

Double niveau de référence :

➡️ La variable contient une **référence vers la liste**  
➡️ La liste contient des **références vers les objets**

---


## Paramètre `out` - Passage par référence explicite

Jusqu’à présent, nous avons vu que les **types valeur** sont passés aux méthodes **par copie**.
La méthode travaille donc sur une variable locale indépendante de la variable passée comme argument.

Le mot-clé `out` permet de **passer un type valeur par référence** à une méthode.

👉 La méthode pourra ainsi modifier directement la variable d’origine.

>⚠️ Le type reste un type valeur — mais il est passé par référence.

Nous avons déjà manipulé le mot-clé `out` lorsque nous utilisions `TryParse`.

```csharp
string texte = "123";
int valeur;

bool ok = int.TryParse(texte, out valeur);
```

**Que se passe-t-il ici ?**
- La méthode retourne `true` ou `false` selon le succès du *parsing*
- Le résultat de la convertion est écrit dans le paramètre `out`
- La méthode modifie directement la variable `valeur` fournie en argument au `TryParse` !

---

### Exemple — sans `out` (copie)

```csharp
void Doubler(int x)
{
    x = x * 2;
}
```
```csharp
int a = 10;
Doubler(a);
// Après l'appel à Doubler(), la variable a vaut toujours 10
```
---
### Exemple — avec `out`

```csharp
void Doubler(int x, out int pResultat)
{
    pResultat = x * 2;
}
```
```csharp
int a = 10;
int resultat;
Doubler(a, out resultat);
```
---
## En Résumé

| Type valeur | Type référence |
|-------------|----------------|
Contient la valeur | Contient une adresse |
Copie la valeur à l’affectation | Référence copiée |
Indépendant | Objet partagé |
Ne peut pas être null | Peut être null |


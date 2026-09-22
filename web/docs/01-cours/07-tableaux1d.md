---
description: Introduction aux tableaux 1D et manipulation avancée des chaînes
---

# Tableaux 1D

## 1️⃣ Pourquoi utiliser un tableau ?

Imaginons que nous devions stocker les notes de 5 étudiants. Sans tableau, nous aurions :

```csharp
int note1 = 85;
int note2 = 90;
int note3 = 78;
int note4 = 92;
int note5 = 88;
```

❌ **Inconvénients** :
- Trop de variables à déclarer.
- Difficile à traiter automatiquement (par exemple pour calculer la moyenne).
- Peu pratique si le nombre d’éléments change.

✅ **Solution** : utiliser un seul conteneur capable de stocker toutes les valeurs : **un tableau**.

```csharp
int[] notes = { 85, 90, 78, 92, 88 };
```

👉 Avec un tableau, tout est regroupé sous un seul nom (`notes`) et on peut accéder facilement à chaque élément.

---

## 2️⃣ Qu’est-ce qu’un tableau ?

Un tableau est une **collection ordonnée d’éléments du même type**, repérés par un **index**.

**Avantages :**
- Regrouper plusieurs valeurs sous un seul nom.
- Accès rapide à n’importe quel élément via son index.
- Taille connue grâce à la propriété `.Length`.
- Compatible avec les **boucles** pour automatiser le traitement.

---

## 3️⃣ Déclaration et préinitialisation

Forme générale pour un tableau **préinitialisé** :

```csharp
type[] nomTableau = { elt1, elt2, ..., eltN };
```

Exemple :

```csharp
int[] notes = { 85, 90, 78, 92, 88 };
```

Forme générale pour un tableau **vide avec une taille définie** :

```csharp
type[] nomTableau = new type[taille];
```

Exemple :

```csharp
int[] tabNombres = new int[10]; // Tableau de 10 entiers initialisés à 0
```

---

## 4️⃣ Indexation – Comment accéder aux éléments ?

📌 L’index commence toujours à `0`.

```csharp
Console.WriteLine(notes[0]); // Premier élément (85)
Console.WriteLine(notes[4]); // Dernier élément (88)
```

### Illustration visuelle
```
┌────┬────┬────┬────┬────┐
│ 85 │ 90 │ 78 │ 92 │ 88 │   ← Valeurs
└────┴────┴────┴────┴────┘
 [0]  [1]  [2]  [3]  [4]    ← Index
```

---

## 5️⃣ Modifier un élément

```csharp
notes[2] = 80; // Change le 3e élément de 78 à 80
Console.WriteLine(notes[2]); // Affiche 80
```

---

## 6️⃣ Propriété `.Length`

Retourne le **nombre d’éléments** d’un tableau.

```csharp
Console.WriteLine(notes.Length); // 5
Console.WriteLine(notes[notes.Length - 1]); // 88, dernier élément
```

📌 Ce tableau contient 5 valeurs, mais l’index commence à `0`. Le dernier élément est donc à l’index `4` ou `notes.Length - 1`.

---

## 7️⃣ Les chaînes de caractères comme tableaux

Un `string` peut être vu comme un **tableau de caractères**.

```csharp
string mot = "Bonjour";
Console.WriteLine(mot[0]); // B
Console.WriteLine(mot[3]); // j
Console.WriteLine(mot[mot.Length - 1]); // r
```

---

## 8️⃣ Découper une chaîne avec `.Split()`

Découpe une chaîne en morceaux selon un **séparateur**.

```csharp
string texte = "pomme,banane,orange";
string[] fruits = texte.Split(',');

Console.WriteLine(fruits[0]); // pomme
Console.WriteLine(fruits[1]); // banane
Console.WriteLine(fruits[2]); // orange
```

---

## 9️⃣ Parcourir un tableau avec une boucle

Sans boucle :

```csharp
Console.WriteLine(notes[0]);
Console.WriteLine(notes[1]);
Console.WriteLine(notes[2]);
```

Avec `for` :

```csharp
int[] notes = { 85, 90, 78, 92, 88 };

for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine("Note " + i + " = " + notes[i]);
}
```

---

## 🔟 Trier un tableau avec `Array.Sort()`

```csharp
int[] nombres = { 42, 7, 19, 3, 88 };
Array.Sort(nombres);

for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i]);
}
/* Résultat :
3
7
19
42
88
*/
```

Fonctionne aussi avec les chaînes :

```csharp
string[] noms = { "Zara", "Alice", "Bob" };
Array.Sort(noms);
// Résultat : Alice, Bob, Zara
```

---

## 1️⃣1️⃣ Recréer une chaîne avec `string.Join()`

Recolle les éléments d’un tableau en une seule chaîne.

```csharp
string[] fruits = { "pomme", "banane", "orange" };
string phrase = string.Join(", ", fruits);
Console.WriteLine(phrase);
// Résultat : pomme, banane, orange
```

---

## 1️⃣2️⃣ Les constantes en C#

Une **constante** est une valeur qui **ne change jamais** pendant l’exécution du programme. On la déclare avec le mot-clé `const`.

### Exemple simple
```csharp
const double TAUX_TPS = 0.05;
const double TAUX_TVQ = 0.09975;

Console.WriteLine("TPS = " + TAUX_TPS);
Console.WriteLine("TVQ = " + TAUX_TVQ);
```

👉 L’avantage est que si le taux change, on modifie **une seule ligne** dans le code.

### Avec et sans constantes

Sans constante :
```csharp
double prix = 100;
double total = prix + prix * 0.05 + prix * 0.09975;
```

Avec constantes :
```csharp
const double TPS = 0.05;
const double TVQ = 0.09975;

double prix = 100;
double total = prix + prix * TPS + prix * TVQ;
```

✅ Le code est plus lisible et plus facile à maintenir.

### Constantes et tableaux

On peut aussi utiliser une constante pour définir la taille d’un tableau.

```csharp
const int NOMBRE_ETUDIANTS = 5;
int[] notes = new int[NOMBRE_ETUDIANTS];
```

Cela rend le code plus clair et permet de modifier facilement la taille du tableau en changeant une seule valeur.

---

## 📎 Référence

👉 Documentation officielle : [Tableaux en C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-1d)


Vous devez réaliser les labos suivants :
 [🧪 Labo 5.1A](/laboratoire/laboratoire5.1A)
 [🧪 Labo 5.1B](/laboratoire/laboratoire5.1B)
 [🧪 Labo 5.1C](/laboratoire/laboratoire5.1C)
 

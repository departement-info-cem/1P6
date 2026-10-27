---
title: "✅ Solutions — Laboratoire 5.1A"
---

# ✅ Solutions — Laboratoire 5.1A

[Retour au laboratoire 5.1A](/laboratoire/laboratoire5.1A)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

---

## 🔵 Exercice 1 – Lecture et affichage simple

```csharp
int[] valeurs = { 5, 10, 15, 20 };
Console.WriteLine("Premier élément : " + valeurs[0]);
Console.WriteLine("Dernier élément : " + valeurs[valeurs.Length - 1]);
```

---

## 🔵 Exercice 2 – Modification d’élément

```csharp
string[] jours = { "Lundi", "Mardi", "Mercredi" };
jours[2] = "Vendredi";

Console.WriteLine(jours[0]);
Console.WriteLine(jours[1]);
Console.WriteLine(jours[2]);
```

---

## 🔵 Exercice 3 – Utilisation de `Length`

```csharp
int[] nombres = { 2, 4, 6 };
Console.WriteLine("Nombre d’éléments : " + nombres.Length);
```

---

## 🔵 Exercice 4 – Calcul de moyenne

```csharp
double[] notes = { 12.5, 15.0, 20.0 };
double somme = notes[0] + notes[1] + notes[2];
double moyenne = somme / notes.Length;
Console.WriteLine("Moyenne : " + moyenne.ToString("F2"));
```

---

## 🔵 Exercice 5 – Interaction avec l’utilisateur

```csharp
string[] prenoms = new string[3];

Console.Write("Entrez le prénom 1 : ");
prenoms[0] = Console.ReadLine();

Console.Write("Entrez le prénom 2 : ");
prenoms[1] = Console.ReadLine();

Console.Write("Entrez le prénom 3 : ");
prenoms[2] = Console.ReadLine();

Console.WriteLine("Les prénoms sont : " + prenoms[0] + ", " + prenoms[1] + ", " + prenoms[2]);
```

---

## 🔵 Exercice 6 – Remplacement d'une valeur

```csharp
int[] tab = { 1, 2, 3, 4 };
tab[1] = tab[0] + tab[2];

Console.WriteLine("Valeurs : " + tab[0] + ", " + tab[1] + ", " + tab[2] + ", " + tab[3]);
```

---

## 🔵 Exercice 7 – Remplacement d'une valeur en utilisant Length

```csharp
double[] valeurs = { 100.0, 200.0, 300.0 };
valeurs[valeurs.Length - 1] *= 1.1;

Console.WriteLine(valeurs[0]);
Console.WriteLine(valeurs[1]);
Console.WriteLine(valeurs[2]);
```

---

## 🔵 Exercice 8 – Utilisation de `Split()`

```csharp
string texte = "pomme,banane,orange";
string[] fruits = texte.Split(',');

Console.WriteLine(fruits[0]);
Console.WriteLine(fruits[1]);
Console.WriteLine(fruits[2]);
```

---

## 🔵 Exercice 9 – Utilisation de `Array.Sort()`

```csharp
int[] nombres = { 42, 7, 19, 3 };
Array.Sort(nombres);

Console.WriteLine(nombres[0]);
Console.WriteLine(nombres[1]);
Console.WriteLine(nombres[2]);
Console.WriteLine(nombres[3]);
```

---

## 🔵 Exercice 10 – Utilisation de `string.Join()`

```csharp
string[] noms = { "Alice", "Bob", "Charlie" };
Console.WriteLine(string.Join(", ", noms));
```

---

## 🔵 Exercice 11 – Utilisation de constantes

```csharp
const double PI = 3.14159;

Console.Write("Entrez le rayon : ");
double rayon = double.Parse(Console.ReadLine());

double circonference = 2 * PI * rayon;
Console.WriteLine("Circonférence = " + circonference.ToString("F2"));
```

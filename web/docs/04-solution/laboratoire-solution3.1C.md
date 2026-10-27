---
title: "✅ Solutions — Laboratoire 3.1C"
---

# ✅ Solutions — Laboratoire 3.1C

[Retour au laboratoire 3.1C](/laboratoire/laboratoire3.1C)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

Les fonctions ci-dessous retournent des valeurs. C'est `Main` qui les affiche.

## Exercice 7 — Somme

```csharp
static long CalculerSomme(int a, int b)
{
    return (long)a + b;
}
static void Main()
{
    Console.Write("Entrez un premier nombre : ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Entrez un deuxième nombre : ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Résultat : " + CalculerSomme(a, b));
}
```

Les deux paramètres restent des `int`; leur somme est retournée dans un `long`. Ce type peut représenter des entiers plus grands qu’un `int` et contient la somme de n’importe quelles deux valeurs `int`. La conversion `(long)a` précède l’addition pour éviter un résultat intermédiaire en `int`. `Main` affiche directement la valeur `long` retournée.

**Tests avec les saisies de la console :** `5` et `7` → `12`; `2147483647` (`int.MaxValue`) et `1` → `2147483648`; `-2147483648` et `-2147483648` (deux `int.MinValue`) → `-4294967296`.

## Exercice 8 — Aire

```csharp
static double CalculerAireRectangle(double longueur, double largeur)
{
    return longueur * largeur;
}
static void Main()
{
    Console.WriteLine(CalculerAireRectangle(8, 5)); // 40
    Console.WriteLine(CalculerAireRectangle(2.5, 4)); // 10
}
```

Les deux dimensions peuvent être réelles; la méthode retourne donc un `double`.

## Exercice 9 — Maximum

```csharp
static int MaximumDeux(int a, int b)
{
    if (a > b) return a;
    return b;
}
static void Main()
{
    Console.Write("Entrez nombre 1 : ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Entrez nombre 2 : ");
    int b = int.Parse(Console.ReadLine());
    Console.Write("Entrez nombre 3 : ");
    int c = int.Parse(Console.ReadLine());
    Console.WriteLine("Le plus grand est : " + MaximumDeux(MaximumDeux(a, b), c));
}
```

Le premier appel retourne le maximum de `a` et `b`; ce résultat devient un argument du second appel. `12, 7, 4` donne `12`; `-5, -2, -8` donne `-2`.

## Exercice 10 — Année bissextile avec retour

```csharp
static bool EstBissextile(int annee)
{
    return annee % 400 == 0 || (annee % 4 == 0 && annee % 100 != 0);
}
static void Main()
{
    Console.Write("Entrez une année : ");
    int annee = int.Parse(Console.ReadLine());
    Console.WriteLine("Bissextile : " + EstBissextile(annee));
}
```

`2024` et `2000` donnent `True`; `1900` donne `False`. Retourner un booléen permet de réutiliser la décision dans une condition sans imposer un affichage.

## Exercice 11 — Palindrome à trois chiffres

```csharp
static bool EstPalindrome(int nombre)
{
    return nombre >= 100 && nombre <= 999 && nombre / 100 == nombre % 10;
}
static void Main()
{
    Console.WriteLine(EstPalindrome(121)); // True
    Console.WriteLine(EstPalindrome(343)); // True
    Console.WriteLine(EstPalindrome(123)); // False
}
```

La division entière par `100` extrait les centaines; le modulo `10` extrait les unités. Pour trois chiffres, le chiffre central ne change pas la symétrie.

## Exercice 12 — Triangle

```csharp
static bool EstTriangleValide(double a, double b, double c)
{
    return a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
}
static void Main()
{
    Console.WriteLine(EstTriangleValide(3, 4, 5)); // True
    Console.WriteLine(EstTriangleValide(1, 2, 3)); // False : triangle aplati
    Console.WriteLine(EstTriangleValide(0, 4, 5)); // False
}
```

Les trois inégalités sont nécessaires; les longueurs sont positives. Le résultat est un booléen.

## Exercice 13 — Mention

```csharp
static string DeterminerMention(double note1, double note2)
{
    double moyenne = (note1 + note2) / 2;
    if (moyenne >= 90) return "A";
    if (moyenne >= 80) return "B";
    if (moyenne >= 70) return "C";
    return "Échec";
}
static void Main()
{
    Console.WriteLine(DeterminerMention(85, 92)); // B : moyenne 88,5
    Console.WriteLine(DeterminerMention(89, 90)); // B : moyenne 89,5
    Console.WriteLine(DeterminerMention(79, 80)); // C : moyenne 79,5
    Console.WriteLine(DeterminerMention(90, 90)); // A
    Console.WriteLine(DeterminerMention(69, 69)); // Échec
}
```

Les deux notes et leur moyenne sont des `double`; la mention retournée est un `string`. Les comparaisons décroissantes couvrent aussi les moyennes décimales.

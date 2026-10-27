---
title: "✅ Solutions — Laboratoire 3.1B"
---

# ✅ Solutions — Laboratoire 3.1B

[Retour au laboratoire 3.1B](/laboratoire/laboratoire3.1B)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

## Exercice 1 — Message personnalisé

```csharp
static void AfficherMessage(string prenom, string nom, int age, string ville)
{
    Console.WriteLine($"Bonjour {prenom} {nom}, vous avez {age} ans et vous venez de {ville}.");
}
static void Main()
{
    AfficherMessage("Benoit", "Caldairou", 20, "Montréal");
    AfficherMessage("Maya", "Roy", 25, "Longueuil");
}
```

Le prénom, le nom et la ville sont des chaînes; l'âge est un entier. Les paramètres reçoivent les valeurs fournies à chaque appel.

## Exercice 2 — Périmètre

```csharp
static void AfficherPerimetre(double largeur, double hauteur)
{
    Console.WriteLine("Périmètre : " + 2 * (largeur + hauteur));
}
static void Main()
{
    AfficherPerimetre(5, 3); // 16
    AfficherPerimetre(2.5, 4); // 13
}
```

## Exercice 3 — Portée

- `nombreBloc` est utilisable dans le bloc `if`, après sa déclaration. Il n'est plus accessible après l'accolade fermante.
- `nombreMain` appartient à `Main`; une autre méthode doit recevoir sa valeur en paramètre.
- `nombreGlobal` est un champ de classe `static`, accessible aux méthodes `static` de cette classe.
- Les accolades délimitent des blocs. Une variable locale n'est accessible que dans son bloc et ses blocs imbriqués, après sa déclaration.

| Instruction à l'extérieur du `if` | Accessible ? | Raison |
| --- | --- | --- |
| Afficher `nombreGlobal` | Oui | Champ de la classe |
| Afficher `nombreMain` | Oui, dans `Main` | Variable locale de `Main` |
| Afficher `nombreBloc` | Non | Déclarée dans le bloc `if` |

Une correction possible transmet la valeur du bloc avant de le quitter et transmet la valeur de `Main` aux autres méthodes :

```csharp
using System;
class Program
{
    static int nombreGlobal = 42;
    static void Main()
    {
        int nombreMain = 10;
        if (nombreMain > 5)
        {
            int nombreBloc = 5;
            Console.WriteLine("Bloc if : " + nombreBloc);
            AfficherBloc(nombreBloc);
        }
        Console.WriteLine("Main : " + nombreMain);
        Console.WriteLine("Global : " + nombreGlobal);
        AutreMethode(nombreMain);
        AfficherGlobalEtLocal(nombreMain);
        AfficherGlobalEtLocal(25);
    }
    static void AfficherBloc(int nombre)
    {
        Console.WriteLine("Bloc : " + nombre);
    }
    static void AutreMethode(int nombre)
    {
        Console.WriteLine("Nombre reçu : " + nombre);
    }
    static void AfficherGlobalEtLocal(int valeurLocale)
    {
        Console.WriteLine("Global : " + nombreGlobal);
        Console.WriteLine("Valeur reçue : " + valeurLocale);
    }
}
```

La version sans paramètre ne reçoit aucune donnée de l'appelant. La version `AutreMethode(int nombre)` reçoit une copie de la valeur passée : `AutreMethode(nombreMain)` fournit `10`. Le paramètre est local à la méthode et rend celle-ci réutilisable avec d'autres valeurs.

## Exercice 4 — Table de multiplication

```csharp
static void AfficherTable(int nombre)
{
    for (int i = 1; i <= 10; i++)
        Console.WriteLine($"{nombre} x {i} = {(long)nombre * i}");
}
static void Main()
{
    AfficherTable(3);
    AfficherTable(7);
    AfficherTable(12);
}
```

Le paramètre reste un `int`. La conversion `(long)nombre` a lieu avant la multiplication : le produit est calculé dans un `long`, qui peut représenter tous les produits d’un `int` par les multiplicateurs de 1 à 10.

Pour l’essai avec une grande valeur, remplacez les trois appels de `Main` par `AfficherTable(300000000);`. La ligne du multiplicateur `8` affiche `300000000 x 8 = 2400000000`; la dernière affiche `300000000 x 10 = 3000000000`.

## Exercice 5 — Conversion

```csharp
static void AfficherFahrenheit(double celsius)
{
    double fahrenheit = celsius * 9.0 / 5.0 + 32;
    Console.WriteLine($"{celsius} °C → {fahrenheit} °F");
}
static void Main()
{
    AfficherFahrenheit(0);  // 32
    AfficherFahrenheit(20); // 68
    AfficherFahrenheit(30); // 86
}
```

Une température `double` est reçue. Cette version affiche le résultat et retourne donc `void`.

## Exercice 6 — Année bissextile

```csharp
static void AfficherBissextile(int annee)
{
    bool bissextile = annee % 400 == 0 || (annee % 4 == 0 && annee % 100 != 0);
    Console.WriteLine($"{annee} : bissextile = {bissextile}");
}
static void Main()
{
    AfficherBissextile(1600);
    AfficherBissextile(2000);
    AfficherBissextile(1996);
    AfficherBissextile(1992);
    AfficherBissextile(2024);
    AfficherBissextile(1997);
    AfficherBissextile(2006);
    AfficherBissextile(1900);
    AfficherBissextile(2100); // False
    AfficherBissextile(2400); // True
    AfficherBissextile(2028); // True
}
```

Les cinq premières années sont bissextiles; `1997`, `2006` et `1900` ne le sont pas. Le test de divisibilité par `400` conserve les siècles qui sont effectivement bissextiles.

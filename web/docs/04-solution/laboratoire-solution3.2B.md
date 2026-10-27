---
title: "✅ Solutions — Laboratoire 3.2B"
---

# ✅ Solutions — Laboratoire 3.2B

[Retour au laboratoire 3.2B](/laboratoire/laboratoire3.2B)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

```csharp
using System;

class Program
{
    static void Main()
    {
        // 1. Type de film
        Console.Write("Type de film (1: Standard, 2: 3D, 3: IMAX) : ");
        int typeFilm = int.Parse(Console.ReadLine());

        // 2. Âge du participant
        Console.Write("Âge du participant : ");
        int age = int.Parse(Console.ReadLine());

        if (typeFilm < 1 || typeFilm > 3 || age < 0)
        {
            Console.WriteLine("Entrée invalide");
            return;
        }

        // 3. Prix du billet
        double prixBillet = ObtenirPrixBillet(age, typeFilm);

        // 4. Choix de la collation
        Console.WriteLine("Choisissez une collation :");
        Console.WriteLine("1 - Popcorn (5.50 $)");
        Console.WriteLine("2 - Nachos (6.75 $)");
        Console.WriteLine("3 - Breuvage (4.25 $)");
        int choixCollation = int.Parse(Console.ReadLine());

        if (choixCollation < 1 || choixCollation > 3)
        {
            Console.WriteLine("Entrée invalide");
            return;
        }

        // 5. Prix de la collation
        double prixCollation = ObtenirPrixCollation(choixCollation);

        // 6. Calcul total avant taxes
        double totalAvantTaxes = CalculerTotal(prixBillet, prixCollation);

        // 7. Application des taxes
        double totalAvecTaxes = AjouterTaxes(totalAvantTaxes);

        // 8. Affichage du récapitulatif
        Console.WriteLine("--- Récapitulatif ---");
        string nomFilm = "Standard";
        if (typeFilm == 2) nomFilm = "3D";
        else if (typeFilm == 3) nomFilm = "IMAX";
        Console.WriteLine("Type de film : " + nomFilm);
        Console.WriteLine("Prix billet : " + prixBillet.ToString("F2") + " $");
        Console.WriteLine("Collation : " + prixCollation.ToString("F2") + " $");
        Console.WriteLine("Total avant taxes : " + totalAvantTaxes.ToString("F2") + " $");
        Console.WriteLine("Total avec taxes : " + totalAvecTaxes.ToString("F2") + " $");
    }

    static double ObtenirPrixBillet(int age, int typeFilm)
    {
        double prix = 0;

        if (typeFilm == 1) // Standard
        {
            if (age < 12) prix = 6.00;
            else if (age <= 17) prix = 8.00;
            else if (age <= 64) prix = 10.00;
            else prix = 7.00;
        }
        else if (typeFilm == 2) // 3D
        {
            if (age < 12) prix = 8.00;
            else if (age <= 17) prix = 10.00;
            else if (age <= 64) prix = 12.00;
            else prix = 9.00;
        }
        else if (typeFilm == 3) // IMAX
        {
            if (age < 12) prix = 10.00;
            else if (age <= 17) prix = 12.00;
            else if (age <= 64) prix = 14.00;
            else prix = 11.00;
        }

        return prix;
    }

    static double ObtenirPrixCollation(int choixCollation)
    {
        double prix = 0;
        if (choixCollation == 1) prix = 5.50;
        else if (choixCollation == 2) prix = 6.75;
        else if (choixCollation == 3) prix = 4.25;

        return prix;
    }

    static double CalculerTotal(double prixBillet, double prixCollation)
    {
        return prixBillet + prixCollation;
    }

    static double AjouterTaxes(double montant)
    {
        double total = montant + montant * 0.15;
        return Math.Round(total, 2, MidpointRounding.AwayFromZero);
    }
}
```

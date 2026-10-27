---
title: 🏆 Solution - Intégration des tableaux 1D
---

# 🏆 Solution — Tableaux 1D et fonctions : Pointages de Uno

Les pointages restent des `int`. Leur somme utilise un `long`, un entier de plus grande capacité; la conversion en `double` pour la moyenne intervient seulement après ce cumul. Le nombre de membres ne dépasse pas la taille du tableau et reste un `int`.

```csharp
using System;

class Program
{
    static void AfficherBilan(string[] noms, int[] points)
    {
        for (int i = 0; i < noms.Length; i++)
        {
            Console.WriteLine(noms[i] + " : " + points[i] + " points");
        }
    }

    static int TrouverIndiceMeilleurResultat(int[] points)
    {
        int indiceMeilleur = 0;

        for (int i = 1; i < points.Length; i++)
        {
            if (points[i] > points[indiceMeilleur])
            {
                indiceMeilleur = i;
            }
        }

        return indiceMeilleur;
    }

    static double CalculerMoyenne(int[] points)
    {
        long somme = 0;

        for (int i = 0; i < points.Length; i++)
        {
            somme = somme + points[i];
        }

        return (double)somme / points.Length;
    }

    static int CompterMembresAuSeuil(int[] points, int seuil)
    {
        int compteur = 0;

        for (int i = 0; i < points.Length; i++)
        {
            if (points[i] >= seuil)
            {
                compteur++;
            }
        }

        return compteur;
    }

    static void Main()
    {
        string[] noms = { "Amélie", "Bilal", "Chloé" };
        int[] points = { 12, 19, 19 };

        int indiceMeilleur = TrouverIndiceMeilleurResultat(points);
        double moyenne = CalculerMoyenne(points);
        int membresAuSeuil = CompterMembresAuSeuil(points, 15);

        Console.WriteLine("Bilan des pointages de Uno");
        AfficherBilan(noms, points);
        Console.WriteLine();
        Console.WriteLine("Meilleur résultat : " + noms[indiceMeilleur] + ", avec " + points[indiceMeilleur] + " points");
        Console.WriteLine("Moyenne : " + moyenne.ToString("F2") + " points");
        Console.WriteLine("Membres avec 15 points ou plus : " + membresAuSeuil);
        Console.WriteLine("Message : Bravo " + noms[indiceMeilleur] + " pour ta première position !");
    }
}
```

**Test de capacité :** deux membres ayant chacun `1500000000` points donnent une somme de `3000000000`, une moyenne de `1500000000,00` points, deux membres au seuil et le premier membre comme meilleur résultat (égalité).

---
title: 🏆 Solution - Intégration des conditions et fonctions
---

# 🏆 Solution — Conditions et fonctions : Bilan d'un atelier d'aide

Les saisies restent des `int`; le total utilise un `long`, un entier de plus grande capacité. La conversion en `long` précède l'addition. Le pourcentage affiché est arrondi à une décimale, mais le commentaire est choisi à partir du pourcentage exact avant cet arrondi : une valeur inférieure à 90 % peut donc s'afficher `90,0 %` tout en gardant `Bonne participation`.

```csharp
using System;

class Program
{
    static long CalculerTotal(int presentes, int absentes)
    {
        return (long)presentes + absentes;
    }

    static double CalculerPourcentagePresence(int presentes, long total)
    {
        return (double)presentes / total * 100;
    }

    static string ObtenirCommentaire(double pourcentage)
    {
        if (pourcentage >= 90)
        {
            return "Excellente participation";
        }
        else if (pourcentage >= 75)
        {
            return "Bonne participation";
        }

        return "Participation limitée";
    }

    static void Main()
    {
        Console.Write("Atelier : ");
        string atelier = Console.ReadLine();
        Console.Write("Personnes présentes : ");
        int presentes = int.Parse(Console.ReadLine());
        Console.Write("Personnes absentes : ");
        int absentes = int.Parse(Console.ReadLine());

        long total = CalculerTotal(presentes, absentes);
        double pourcentage = CalculerPourcentagePresence(presentes, total);

        Console.WriteLine();
        Console.WriteLine("Atelier : " + atelier);
        Console.WriteLine("Personnes présentes : " + presentes);
        Console.WriteLine("Personnes absentes : " + absentes);
        Console.WriteLine("Personnes inscrites : " + total);
        Console.WriteLine("Présence (arrondie à une décimale) : " + pourcentage.ToString("F1") + " %");
        Console.WriteLine("Commentaire : " + ObtenirCommentaire(pourcentage));
    }
}
```

**Tests :** `4` présentes et `1` absente donnent `5` inscrites, `80,0 %` et `Bonne participation`; `179` et `21` donnent `200`, `89,5 %` et `Bonne participation`. Avec `1` absente et `99` présentes, le programme affiche `99,0 %` et `Excellente participation`. Avec `8996` présentes et `1004` absentes, il affiche `90,0 %`, mais garde `Bonne participation`, car le pourcentage avant arrondi est `89,96 %`.

---
title: 🏆 Solution - Variables et calculs
---

# 🏆 Solution — Variables et calculs : Coût des brochures

## Analyse du mandat — éléments attendus

- **Besoin principal :** calculer le nombre de pages à imprimer et le prix de la commande.
- **Valeurs saisies :** nombre de brochures, pages par brochure et prix d'une page.
- **Résultats :** pages imprimées et coût total.
- **Valeurs considérées valides :** quantités `int` supérieures à `0` et prix `double` supérieur à `0`; on suppose que le coût total est représentable dans un `double`.
- **Notions exclues :** conditions, boucles et fonctions.

En mots, on trouve d'abord toutes les pages en multipliant le nombre de brochures par le nombre de pages de chacune. On multiplie ensuite ce résultat par le prix d'une page.

Pour `3` brochures de `4` pages à `0,10 $`, le programme doit obtenir `12` pages et un coût de `1,20 $`.

Un autre cas d'essai possible est `5` brochures de `6` pages à `0,25 $` : `30` pages et `7,50 $`.

## Exemple de code

Les saisies de quantités restent des `int`. Le total des pages utilise un `long`, un entier de plus grande capacité. La conversion en `long` doit avoir lieu **avant** la multiplication; convertir un produit `int` déjà calculé ne corrigerait pas son débordement. Le prix et le coût restent des `double`, comme dans les premiers exercices de calcul.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Nombre de brochures : ");
        int nombreBrochures = int.Parse(Console.ReadLine());

        Console.Write("Pages par brochure : ");
        int pagesParBrochure = int.Parse(Console.ReadLine());

        Console.Write("Prix par page : ");
        double prixParPage = double.Parse(Console.ReadLine());

        long pagesImprimees = (long)nombreBrochures * pagesParBrochure;
        double coutTotal = pagesImprimees * prixParPage;

        Console.WriteLine();
        Console.WriteLine("Pages imprimées : " + pagesImprimees);
        Console.WriteLine("Coût total : " + coutTotal + " $");
    }
}
```

**Test de capacité :** `50000` brochures de `50000` pages à `0,10 $` produisent `2500000000` pages et un coût de `250000000 $`.

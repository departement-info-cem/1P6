---
title: 🏆 Solution - Variables et calculs
---

# 🏆 Solution — Variables et calculs : Coût des brochures

## Analyse du mandat — éléments attendus

- **Besoin principal :** calculer le nombre de pages à imprimer et le prix de la commande.
- **Valeurs saisies :** nombre de brochures, pages par brochure et prix d'une page.
- **Résultats :** pages imprimées et coût total.
- **Valeurs considérées valides :** quantités entières supérieures à `0` et prix décimal supérieur à `0`.
- **Notions exclues :** conditions, boucles et fonctions.

En mots, on trouve d'abord toutes les pages en multipliant le nombre de brochures par le nombre de pages de chacune. On multiplie ensuite ce résultat par le prix d'une page.

Pour `3` brochures de `4` pages à `0,10 $`, le programme doit obtenir `12` pages et un coût de `1,20 $`.

Un autre cas d'essai possible est `5` brochures de `6` pages à `0,25 $` : `30` pages et `7,50 $`.

## Exemple de code

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

        int pagesImprimees = nombreBrochures * pagesParBrochure;
        double coutTotal = pagesImprimees * prixParPage;

        Console.WriteLine();
        Console.WriteLine("Pages imprimées : " + pagesImprimees);
        Console.WriteLine("Coût total : " + coutTotal + " $");
    }
}
```

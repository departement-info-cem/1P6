---
title: 🏆 Solution - Boucle for
---

# 🏆 Solution — Boucle `for` : Préparation de trousses d'accueil

Les deux saisies restent des `int` strictement positifs. Le cumul et le compteur de boucle sont des `long`, un type entier de plus grande capacité : le produit de deux `int` positifs tient dans un `long`, et le compteur peut dépasser la dernière valeur d'un `int` pour terminer la boucle.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Articles par trousse : ");
        int articlesParTrousse = int.Parse(Console.ReadLine());
        Console.Write("Nombre de trousses : ");
        int nombreTrousses = int.Parse(Console.ReadLine());

        if (articlesParTrousse <= 0 || nombreTrousses <= 0)
        {
            Console.WriteLine("Les valeurs doivent être supérieures à 0.");
        }
        else
        {
            long articlesCumules = 0;

            Console.WriteLine();
            Console.WriteLine("Trousse    Articles cumulés");

            for (long numeroTrousse = 1; numeroTrousse <= nombreTrousses; numeroTrousse++)
            {
                articlesCumules = articlesCumules + articlesParTrousse;
                Console.WriteLine(numeroTrousse + "          " + articlesCumules);
            }

            Console.WriteLine();
            Console.WriteLine("Total d'articles préparés : " + articlesCumules);
        }
    }
}
```

**Test de capacité :** `50000` articles et `50000` trousses donnent `Total d'articles préparés : 2500000000`. Les exemples `4 × 4` et `6 × 1` donnent toujours `16` et `6`.

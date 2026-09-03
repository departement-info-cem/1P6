---
title: 🏆 Solution - Variables et calculs
---

# 🏆 Solution — Variables et calculs : Coût des brochures

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

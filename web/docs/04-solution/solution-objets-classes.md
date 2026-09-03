---
title: 🏆 Solution - Objets et classes
---

# 🏆 Solution — Objets et classes : Compte de fidélité

La classe `CompteFidelite` fournie dans le projet de départ reste inchangée. Le programme crée un seul objet et utilise ses propriétés et ses méthodes pour toutes les opérations.

```csharp
using System;

namespace DefiCompteFidelite
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            CompteFidelite compte = new CompteFidelite("Maya");
            bool quitter = false;

            Console.WriteLine("Compte : " + compte.Nom);
            Console.WriteLine("Points disponibles : " + compte.Points);

            while (!quitter)
            {
                Console.WriteLine();
                Console.WriteLine("1 - Ajouter des points");
                Console.WriteLine("2 - Échanger des points");
                Console.WriteLine("3 - Quitter");
                Console.Write("Choix : ");
                string choix = Console.ReadLine();

                switch (choix)
                {
                    case "1":
                        Console.Write("Nombre de points : ");
                        int pointsAjouter;

                        if (!int.TryParse(Console.ReadLine(), out pointsAjouter))
                        {
                            Console.WriteLine("Entrez un nombre entier de points.");
                        }
                        else if (compte.AjouterPoints(pointsAjouter))
                        {
                            Console.WriteLine("Ajout effectué.");
                        }
                        else
                        {
                            Console.WriteLine("Ajout refusé.");
                        }

                        Console.WriteLine("Points disponibles : " + compte.Points);
                        break;

                    case "2":
                        Console.Write("Nombre de points : ");
                        int pointsEchanger;

                        if (!int.TryParse(Console.ReadLine(), out pointsEchanger))
                        {
                            Console.WriteLine("Entrez un nombre entier de points.");
                        }
                        else if (compte.EchangerPoints(pointsEchanger))
                        {
                            Console.WriteLine("Échange effectué.");
                        }
                        else
                        {
                            Console.WriteLine("Échange refusé.");
                        }

                        Console.WriteLine("Points disponibles : " + compte.Points);
                        break;

                    case "3":
                        quitter = true;
                        Console.WriteLine("Au revoir!");
                        break;

                    default:
                        Console.WriteLine("Choix invalide.");
                        break;
                }
            }
        }
    }
}
```

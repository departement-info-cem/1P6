---
title: 🏆 Solution - Fichiers CSV
---

# 🏆 Solution — Fichiers CSV : Rapport de ventes

Comme dans l’énoncé, la quantité et le prix sont des `int` strictement positifs. Les compteurs et les nombres d’articles sont des `long`; les revenus par ligne, maximal et total sont des `decimal`. La conversion en `decimal` précède la multiplication pour éviter un calcul intermédiaire en `int`. On suppose que les compteurs restent représentables dans un `long` et les revenus dans un `decimal`.

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string cheminVentes = @"C:\EspaceLabo\ventes.csv";
        string cheminRapport = @"C:\EspaceLabo\rapport-ventes.txt";

        if (!File.Exists(cheminVentes))
        {
            Console.WriteLine("Fichier ventes.csv introuvable.");
            return;
        }

        long ventesValides = 0;
        long lignesRejetees = 0;
        decimal revenuTotal = 0;
        long articlesVetements = 0;
        long articlesSouvenirs = 0;
        long articlesDecoration = 0;
        decimal revenuMaximum = 0;
        string produitPlusRentable = "";

        using (StreamReader lecteur = new StreamReader(cheminVentes))
        {
            lecteur.ReadLine(); // Ignorer l'en-tête.

            while (!lecteur.EndOfStream)
            {
                string ligne = lecteur.ReadLine();
                string[] parties = ligne.Split(',');
                int quantite;
                int prix;

                bool categorieValide = parties.Length == 4 &&
                    (parties[1] == "Vêtements" || parties[1] == "Souvenirs" || parties[1] == "Décoration");

                if (parties.Length != 4 || parties[0] == "" || !categorieValide ||
                    !int.TryParse(parties[2], out quantite) || quantite <= 0 ||
                    !int.TryParse(parties[3], out prix) || prix <= 0)
                {
                    lignesRejetees++;
                }
                else
                {
                    decimal revenu = (decimal)quantite * prix;
                    ventesValides++;
                    revenuTotal = revenuTotal + revenu;

                    if (parties[1] == "Vêtements")
                    {
                        articlesVetements = articlesVetements + quantite;
                    }
                    else if (parties[1] == "Souvenirs")
                    {
                        articlesSouvenirs = articlesSouvenirs + quantite;
                    }
                    else
                    {
                        articlesDecoration = articlesDecoration + quantite;
                    }

                    if (revenu > revenuMaximum)
                    {
                        revenuMaximum = revenu;
                        produitPlusRentable = parties[0];
                    }
                }
            }
        }

        using (StreamWriter rapport = new StreamWriter(cheminRapport))
        {
            rapport.WriteLine("Ventes valides : " + ventesValides);
            rapport.WriteLine("Lignes rejetées : " + lignesRejetees);
            rapport.WriteLine("Revenu total : " + revenuTotal.ToString("F2") + " $");

            if (ventesValides > 0)
            {
                rapport.WriteLine("Produit le plus rentable : " + produitPlusRentable + " (" + revenuMaximum.ToString("F2") + " $)");
            }
            else
            {
                rapport.WriteLine("Aucune vente valide.");
            }

            rapport.WriteLine("Vêtements : " + articlesVetements + " articles");
            rapport.WriteLine("Souvenirs : " + articlesSouvenirs + " articles");
            rapport.WriteLine("Décoration : " + articlesDecoration + " articles");
        }

        Console.WriteLine("Ventes valides : " + ventesValides);
        Console.WriteLine("Lignes rejetées : " + lignesRejetees);
        Console.WriteLine("Revenu total : " + revenuTotal.ToString("F2") + " $");

        if (ventesValides == 0)
        {
            Console.WriteLine("Aucune vente valide.");
        }
        else
        {
            Console.WriteLine("Produit le plus rentable : " + produitPlusRentable + " (" + revenuMaximum.ToString("F2") + " $)");
        }

        Console.WriteLine("Vêtements : " + articlesVetements + " articles");
        Console.WriteLine("Souvenirs : " + articlesSouvenirs + " articles");
        Console.WriteLine("Décoration : " + articlesDecoration + " articles");
        Console.WriteLine("Rapport : " + cheminRapport);
    }
}
```

> Le rapport contient les mêmes lignes de résultats que la console, sauf la ligne `Rapport`. Lorsqu'aucune vente valide n'est trouvée, la ligne `Aucune vente valide.` remplace la ligne `Produit le plus rentable`.

## Tests de calcul

Chaque essai utilise un nouveau fichier `ventes.csv` contenant l’en-tête, puis les lignes indiquées.

| Lignes de vente | Résultats à vérifier dans la console et le rapport |
| --- | --- |
| `T-shirt,Vêtements,3,18`<br />`Tasse,Souvenirs,2,12`<br />`Affiche,Décoration,5,7` | 3 ventes valides; 0 ligne rejetée; revenu total de 113,00 $; T-shirt est le plus rentable avec 54,00 $; catégories : 3, 2 et 5 articles. |
| `Test,Vêtements,50000,50000` | 1 vente valide; 0 ligne rejetée; revenu total de 2500000000,00 $; Test est le plus rentable avec 2500000000,00 $; Vêtements : 50000 articles. |
| `ProduitA,Vêtements,2147483647,1`<br />`ProduitB,Vêtements,2147483647,1` | 2 ventes valides; 0 ligne rejetée; revenu total de 4294967294,00 $; Vêtements : 4294967294 articles; ProduitA reste le plus rentable avec 2147483647,00 $ (premier produit en cas d’égalité). |

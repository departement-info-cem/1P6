---
title: "✅ Solutions — Laboratoire 9.1"
---

# ✅ Solutions — Laboratoire 9.1

[Retour au laboratoire 9.1](/laboratoire/laboratoire9.1)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

Le tableau comprend une rangée d'en-têtes à l'indice `0`. Les numéros de films `1` à `11` correspondent donc directement à leurs indices de rangée.

```csharp
using System;
class Program
{
    static void Main()
    {
        string[,] filmsDenis = {
            { "Num", "Année", "Titre", "Directeur", "Scénariste", "Producteur" },
            { "1", "1998", "Un 32 août sur terre", "Oui", "Oui", "Non" },
            { "2", "2000", "Maelström", "Oui", "Oui", "Non" },
            { "3", "2009", "Polytechnique", "Oui", "Oui", "Non" },
            { "4", "2010", "Incendies", "Oui", "Oui", "Non" },
            { "5", "2013", "Prisoners", "Oui", "Non", "Non" },
            { "6", "2013", "Enemy", "Oui", "Non", "Non" },
            { "7", "2015", "Sicario", "Oui", "Non", "Non" },
            { "8", "2016", "Premier Contact (Arrival)", "Oui", "Non", "Non" },
            { "9", "2017", "Blade Runner 2049", "Oui", "Non", "Non" },
            { "10", "2021", "Dune", "Oui", "Oui", "Oui" },
            { "11", "2024", "Dune, deuxième partie", "Oui", "Oui", "Oui" }};
        int choix;
        do
        {
            Console.Clear();
            Console.WriteLine("**********************************************************");
            Console.WriteLine("*            Les films de Denis Villeneuve               *");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("1. Lister tous les films (résumé)");
            Console.WriteLine("2. Lister tous les films (détails)");
            Console.WriteLine("3. Fiche technique d'un film");
            Console.WriteLine("4. Quitter");
            Console.Write("Votre choix : ");
            if (!int.TryParse(Console.ReadLine(), out choix)) choix = 0;
            Console.Clear();
            switch (choix)
            {
                case 1: ListerResume(filmsDenis); break;
                case 2: ListerDetails(filmsDenis); break;
                case 3: AfficherFiche(filmsDenis); break;
                case 4: Console.WriteLine("Au revoir !"); break;
                default: Console.WriteLine("Choix invalide."); break;
            }
            if (choix != 4)
            {
                Console.WriteLine("...Peser sur une touche pour revenir au menu principal...");
                Console.ReadKey(true);
            }
        } while (choix != 4);
    }
    static void ListerResume(string[,] films)
    {
        ListerColonnes(films, 3);
    }
    static void ListerDetails(string[,] films)
    {
        ListerColonnes(films, films.GetLength(1));
    }
    static void ListerColonnes(string[,] films, int nombreColonnes)
    {
        int[] largeurs = { 7, 7, 30, 15, 15, 15 };
        for (int rangee = 0; rangee < films.GetLength(0); rangee++)
        {
            for (int colonne = 0; colonne < nombreColonnes; colonne++)
            {
                string format = "{0,-" + largeurs[colonne] + "}";
                Console.Write(string.Format(format, films[rangee, colonne]));
            }
            Console.WriteLine();
        }
    }
    static void AfficherFiche(string[,] films)
    {
        Console.Write("Numéro du film (1 à 11) : ");
        int numero;
        if (!int.TryParse(Console.ReadLine(), out numero) ||
            numero < 1 || numero >= films.GetLength(0))
        {
            Console.WriteLine("Numéro de film invalide.");
            return;
        }
        Console.WriteLine("Voici les informations pour le film : " + films[numero, 2]);
        for (int colonne = 0; colonne < films.GetLength(1); colonne++)
            Console.WriteLine(films[0, colonne] + " : " + films[numero, colonne]);
    }
}
```

La fonction commune `ListerColonnes` conserve les deux parcours par rangée demandés, avec une limite de trois ou six colonnes. La fiche parcourt les colonnes d'une seule rangée après validation du numéro. Le choix `4` quitte; une autre saisie retourne au menu sans accéder à une case invalide.

Pour vérifier : le résumé contient les onze films et les trois premiers champs; les détails ajoutent les trois rôles. La fiche `2` affiche `Maelström`, `2000`, `Oui`, `Oui`, `Non`. Les numéros `0`, `12` et le texte `abc` produisent une erreur.

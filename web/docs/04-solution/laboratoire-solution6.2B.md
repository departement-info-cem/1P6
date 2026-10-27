---
title: "✅ Solutions — Laboratoire 6.2B"
---

# ✅ Solutions — Laboratoire 6.2B

[Retour au laboratoire 6.2B](/laboratoire/laboratoire6.2B)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

```csharp
using System;
class Program
{
    const int LONGUEUR_MIN = 8;
    const int LONGUEUR_MAX = 20;
    static void Main()
    {
        Console.Write("Entrez la longueur du mot de passe : ");
        int longueur = int.Parse(Console.ReadLine());
        if (longueur < LONGUEUR_MIN) longueur = LONGUEUR_MIN;
        else if (longueur > LONGUEUR_MAX) longueur = LONGUEUR_MAX;
        Console.Write("Inclure des symboles ? (oui/non) : ");
        bool inclureSymboles = Console.ReadLine().ToLower() == "oui";
        string motDePasse = GenererMotDePasse(longueur, inclureSymboles);
        Console.WriteLine("Votre mot de passe généré est :\n" + motDePasse);
    }
    static string GenererMotDePasse(int pLongueur, bool inclureSymboles)
    {
        string caractèresValides = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        string symboles = "!@#$%^&*-_=+:?";
        if (inclureSymboles) caractèresValides += symboles;
        Random generateur = new Random();
        string motDePasse = "";
        for (int i = 0; i < pLongueur; i++)
        {
            int indice = generateur.Next(0, caractèresValides.Length);
            motDePasse += caractèresValides[indice];
        }
        return motDePasse;
    }
}
```

`Next` inclut `0` et exclut `Length`, ce qui couvre tous les indices valides. La boucle produit exactement la longueur demandée après ajustement : `3` donne `8`, `10` donne `10`, `100` donne `20`. Sans symboles, tous les caractères sont alphanumériques; avec symboles, ceux-ci sont possibles sans être garantis. Les résultats aléatoires ne reproduisent pas nécessairement les exemples de l'énoncé.

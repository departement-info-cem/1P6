---
title: "✅ Solutions — Laboratoire 3.2A"
---

# ✅ Solutions — Laboratoire 3.2A

[Retour au laboratoire 3.2A](/laboratoire/laboratoire3.2A)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

## 📝 Version 1 – Code simple avec répétition
```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Random generateur = new Random();
        int nombreSecret = generateur.Next(1, 11); // Génère un nombre entre 1 et 10
        bool trouve = false;
        int proposition;
        string message;

        // Tentative 1
        Console.Write("Tentative 1 : Entrez un nombre entre 1 et 10 : ");
        proposition = int.Parse(Console.ReadLine());
        message = VerifierProposition(proposition, nombreSecret);
        Console.WriteLine(message);
        if (proposition == nombreSecret)
        {
            trouve = true;
        }

        // Tentative 2
        if (!trouve)
        {
            Console.Write("Tentative 2 : Entrez un nombre entre 1 et 10 : ");
            proposition = int.Parse(Console.ReadLine());
            message = VerifierProposition(proposition, nombreSecret);
            Console.WriteLine(message);
            if (proposition == nombreSecret)
            {
                trouve = true;
            }
        }

        // Tentative 3
        if (!trouve)
        {
            Console.Write("Tentative 3 : Entrez un nombre entre 1 et 10 : ");
            proposition = int.Parse(Console.ReadLine());
            message = VerifierProposition(proposition, nombreSecret);
            Console.WriteLine(message);
            if (proposition == nombreSecret)
            {
                trouve = true;
            }
        }

        // Résultat final
        string resultatFinal = ObtenirResultatFinal(trouve, nombreSecret);
        Console.WriteLine(resultatFinal);
    }

    static string VerifierProposition(int proposition, int nombreSecret)
    {
        if (proposition == nombreSecret)
        {
            return "Bravo ! Vous avez trouvé le nombre secret.";
        }
        else if (proposition < nombreSecret)
        {
            return "Le nombre secret est plus grand.";
        }
        else
        {
            return "Le nombre secret est plus petit.";
        }
    }

    static string ObtenirResultatFinal(bool trouve, int nombreSecret)
    {
        if (trouve)
        {
            return "🎉 Félicitations, vous avez gagné !";
        }
        else
        {
            return "😢 Vous avez perdu. Le nombre secret était : " + nombreSecret;
        }
    }
}
```

---

## 📝 Version 2 – Optimisée avec une méthode paramétrée pour chaque tentative
Dans cette version, on réduit la répétition du code en créant une méthode `FaireTentative` qui reçoit en paramètre **le numéro de la tentative**, **le nombre secret** et **l'état de victoire**.

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Random generateur = new Random();
        int nombreSecret = generateur.Next(1, 11);
        bool trouve = false;

        trouve = FaireTentative(1, nombreSecret, trouve);
        if (!trouve) trouve = FaireTentative(2, nombreSecret, trouve);
        if (!trouve) trouve = FaireTentative(3, nombreSecret, trouve);

        Console.WriteLine(ObtenirResultatFinal(trouve, nombreSecret));
    }

    static bool FaireTentative(int numero, int nombreSecret, bool trouve)
    {
        Console.Write($"Tentative {numero} : Entrez un nombre entre 1 et 10 : ");
        int proposition = int.Parse(Console.ReadLine());
        Console.WriteLine(VerifierProposition(proposition, nombreSecret));
        return proposition == nombreSecret;
    }

    static string VerifierProposition(int proposition, int nombreSecret)
    {
        if (proposition == nombreSecret)
        {
            return "Bravo ! Vous avez trouvé le nombre secret.";
        }
        else if (proposition < nombreSecret)
        {
            return "Le nombre secret est plus grand.";
        }
        else
        {
            return "Le nombre secret est plus petit.";
        }
    }

    static string ObtenirResultatFinal(bool trouve, int nombreSecret)
    {
        if (trouve)
        {
            return "🎉 Félicitations, vous avez gagné !";
        }
        else
        {
            return "😢 Vous avez perdu. Le nombre secret était : " + nombreSecret;
        }
    }
}
```

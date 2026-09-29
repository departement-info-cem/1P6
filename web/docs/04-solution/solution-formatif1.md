---
title: 🏆 Solution - Formatif 1
---

# 🏆 Solution — Examen formatif 1

Ces dix programmes corrigent les exercices du [Formatif 1](../01-cours/10-formatif1.md). Chaque bloc de code est un programme console **indépendant** : copiez un seul bloc à la fois dans `Program.cs` pour l'exécuter.

## 1. Types de variables et expressions arithmétiques

### 1.1. Salaire hebdomadaire

Le salaire est le produit des heures travaillées et du taux horaire. Le type `decimal` convient aux montants d'argent. La culture `fr-CA` permet de saisir et d'afficher les décimales avec une virgule.

```csharp
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // La même culture sert à lire les nombres et à afficher les montants.
        CultureInfo culture = CultureInfo.GetCultureInfo("fr-CA");

        Console.WriteLine("==================LA PAIE=================");
        Console.Write("Nom de l'employé : ");
        string nom = Console.ReadLine();
        Console.Write("Nombre d'heures : ");
        decimal heures = decimal.Parse(Console.ReadLine(), culture);
        Console.Write("Taux horaire : ");
        decimal tauxHoraire = decimal.Parse(Console.ReadLine(), culture);

        // Conserver le résultat du calcul avant de construire la phrase finale.
        decimal salaire = heures * tauxHoraire;
        Console.WriteLine();
        Console.WriteLine(nom + " a travaillé " + heures.ToString(culture)
            + " h par semaine avec un taux horaire de "
            + tauxHoraire.ToString("F2", culture) + "$. Son salaire est de "
            + salaire.ToString("F2", culture) + "$.");
    }
}
```

**À tester :** Mario, `32,5` heures, `19,75` $/h → salaire de `641,88` $.

## 2. Structures conditionnelles simples

### 2.1. Température

Les conditions sont vérifiées de la température la plus élevée à la plus basse. Chaque `else if` couvre ainsi la plage restante.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Quelle est la température : ");
        int temperature = int.Parse(Console.ReadLine());

        // Les limites sont inclusives : 16 appartient à la deuxième plage,
        // 12 aussi; 5 appartient à la troisième plage.
        if (temperature > 16)
        {
            Console.WriteLine("Il fait chaud!");
        }
        else if (temperature >= 12)
        {
            Console.WriteLine("C'est agréable!");
        }
        else if (temperature >= 5)
        {
            Console.WriteLine("C'est frais!");
        }
        else
        {
            Console.WriteLine("Il fait froid");
        }
    }
}
```

**À tester :** `17` → « Il fait chaud! »; `16` et `12` → « C'est agréable! »; `11` et `5` → « C'est frais! »; `4` → « Il fait froid ».

### 2.2. Score de deux dés

L'ordre des conditions compte : les doubles `6`, puis `5` et `4`, sont traités avant les autres doubles.

```csharp
using System;

class Program
{
    static void Main()
    {
        // L'énoncé demande deux saisies entre 1 et 6; aucun tirage n'est nécessaire.
        Console.Write("Valeur du dé 1 (1 à 6) : ");
        int de1 = int.Parse(Console.ReadLine());
        Console.Write("Valeur du dé 2 (1 à 6) : ");
        int de2 = int.Parse(Console.ReadLine());

        // Tester les cas particuliers avant le cas général des doubles.
        int score;
        if (de1 == 6 && de2 == 6)
        {
            score = 100;
        }
        else if (de1 == de2 && (de1 == 5 || de1 == 4))
        {
            score = 75;
        }
        else if (de1 == de2)
        {
            score = 50;
        }
        else
        {
            score = de1 + de2;
        }

        Console.WriteLine("Dé 1 = " + de1 + ", Dé 2 = " + de2
            + " → Score = " + score);
    }
}
```

**À saisir pour tester :** `(6, 6)` → `100`; `(5, 5)` et `(4, 4)` → `75`; `(3, 3)` et `(2, 2)` → `50`; `(2, 6)` → `8`. L'exercice suppose que les deux valeurs saisies sont des entiers de `1` à `6`.

## 3. Fonctions et structures conditionnelles

### 3.1. Prix après taxes

La fonction reçoit le prix et le choix de province, puis retourne le prix multiplié par `1 + taux`. Les taux ci-dessous sont ceux de **l'énoncé**.

```csharp
using System;
using System.Globalization;

class Program
{
    static decimal CalculerPrixApresTaxes(decimal prix, int province)
    {
        // Les trois choix reprennent exactement les taux de l'énoncé.
        decimal taux;
        if (province == 1)
        {
            taux = 0.15m;
        }
        else if (province == 2)
        {
            taux = 0.13m;
        }
        else
        {
            taux = 0.12m; // Choix 3 : Autre
        }

        // 1 représente le prix de départ; le taux ajoute la taxe.
        return prix * (1 + taux);
    }

    static void Main()
    {
        CultureInfo culture = CultureInfo.GetCultureInfo("fr-CA");
        Console.Write("Prix de l'article : ");
        decimal prix = decimal.Parse(Console.ReadLine(), culture);
        Console.WriteLine("Choisir la province? 1) QC, 2) ON, 3) Autre.");
        Console.Write("Votre choix : ");
        int province = int.Parse(Console.ReadLine());

        decimal prixFinal = CalculerPrixApresTaxes(prix, province);
        Console.WriteLine("Prix après taxes : "
            + prixFinal.ToString("F2", culture) + "$");
    }
}
```

**À tester avec un prix de `100` $ :** choix `1` → `115,00` $; choix `2` → `113,00` $; choix `3` → `112,00` $.

### 3.2. Formater le nom d'un étudiant

La fonction reçoit deux chaînes et retourne le nom de famille en majuscules, suivi d'une virgule et du prénom.

```csharp
using System;

class Program
{
    static string FormaterNom(string prenom, string nom)
    {
        // ToUpper transforme le nom; le prénom reste tel qu'il a été saisi.
        return nom.ToUpper() + ", " + prenom;
    }

    static void Main()
    {
        Console.WriteLine("------------------Je formaterai votre nom------------------");
        Console.Write("Entrez votre prénom : ");
        string prenom = Console.ReadLine();
        Console.Write("Entrez votre nom : ");
        string nom = Console.ReadLine();

        // Main affiche la chaîne retournée par la fonction.
        string nomFormate = FormaterNom(prenom, nom);
        Console.WriteLine("Nom formaté : " + nomFormate);
    }
}
```

**À tester :** `Mario` et `Tremblay` → `TREMBLAY, Mario`; `Émilie` et `Roy` → `ROY, Émilie`.

## 4. Boucle `for` et fonctions avec paramètres et retour

### 4.1. Compter les multiples

Un entier est un multiple du diviseur lorsque le reste de la division vaut zéro. On parcourt tous les entiers de `1` à la limite, inclusivement.

```csharp
using System;

class Program
{
    static int CompterMultiples(int limite, int diviseur)
    {
        int compteur = 0;

        // Commencer à 1 et inclure la limite dans le parcours.
        for (int nombre = 1; nombre <= limite; nombre++)
        {
            if (nombre % diviseur == 0)
            {
                compteur++;
            }
        }

        return compteur;
    }

    static void Main()
    {
        Console.Write("Entrez une limite : ");
        int limite = int.Parse(Console.ReadLine());
        Console.Write("Entrez un diviseur : ");
        int diviseur = int.Parse(Console.ReadLine());

        // Le diviseur doit être différent de zéro pour utiliser %.
        int nombreMultiples = CompterMultiples(limite, diviseur);
        string motMultiple = "multiples";
        if (nombreMultiples == 1)
        {
            motMultiple = "multiple";
        }
        Console.WriteLine("Il y a " + nombreMultiples + " " + motMultiple + " de "
            + diviseur + " entre 1 et " + limite);
    }
}
```

**À tester :** limite `20`, diviseur `3` → `6` multiples; limite `1`, diviseur `1` → `1` multiple; limite `5`, diviseur `7` → `0` multiple. L'exercice suppose un diviseur positif.

### 4.2. Somme des carrés

La boucle additionne `1² + 2² + ... + N²`. L'énoncé suppose que `N` est positif.

```csharp
using System;

class Program
{
    static int SommeDesCarres(int n)
    {
        int somme = 0;
        // On commence à 1 et on inclut n dans le calcul.
        for (int i = 1; i <= n; i++)
        {
            somme += i * i;
        }

        return somme;
    }

    static void Main()
    {
        Console.WriteLine("---Je peux vous aider à calculer la somme des carrés---");
        Console.Write("Entrez un nombre : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Le résultat est : " + SommeDesCarres(n));
    }
}
```

**À tester :** `5` → `55`; `1` → `1`.

## 5. Intégration : boucles, conditions et fonctions

### 5.1. Statistiques d'un groupe de notes

La boucle lit les notes une à une : aucun tableau n'est nécessaire. La première note initialise le minimum et le maximum, afin que les comparaisons suivantes aient un point de départ valide.

```csharp
using System;
using System.Globalization;

class Program
{
    static string DeterminerMention(decimal moyenne)
    {
        // Vérifier les seuils du plus élevé au plus bas.
        if (moyenne >= 90)
        {
            return "Excellent";
        }
        else if (moyenne >= 75)
        {
            return "Très bien";
        }
        else if (moyenne >= 60)
        {
            return "Réussite";
        }

        return "Échec";
    }

    static void Main()
    {
        CultureInfo culture = CultureInfo.GetCultureInfo("fr-CA");
        Console.Write("Combien de notes : ");
        int nombreNotes = int.Parse(Console.ReadLine());
        if (nombreNotes <= 0)
        {
            Console.WriteLine("Entrez au moins une note.");
            return; // Éviter une division par zéro.
        }

        decimal somme = 0;
        decimal maximum = 0;
        decimal minimum = 0;
        for (int i = 1; i <= nombreNotes; i++)
        {
            Console.Write("Note " + i + " : ");
            decimal note = decimal.Parse(Console.ReadLine(), culture);
            somme += note;

            // La première note fixe les deux valeurs de référence.
            if (i == 1)
            {
                maximum = note;
                minimum = note;
            }
            else
            {
                if (note > maximum)
                {
                    maximum = note;
                }
                if (note < minimum)
                {
                    minimum = note;
                }
            }
        }

        decimal moyenne = somme / nombreNotes;
        string mention = DeterminerMention(moyenne);
        Console.WriteLine();
        Console.WriteLine("Moyenne : " + moyenne.ToString("F2", culture));
        Console.WriteLine("Note la plus haute : " + maximum.ToString(culture));
        Console.WriteLine("Note la plus basse : " + minimum.ToString(culture));
        Console.WriteLine("Mention : " + mention);
    }
}
```

**À tester :** notes `85`, `72,5`, `91`, `64,5` → moyenne `78,25`, maximum `91`, minimum `64,5`, mention « Très bien ». Avec une seule note de `90`, la moyenne, le minimum et le maximum valent `90` et la mention est « Excellent ».

### 5.2. Deviner un nombre secret

Le nombre secret est une valeur fixe choisie dans le code. La condition de la boucle donne au plus cinq essais et cesse dès que le joueur trouve le nombre.

```csharp
using System;

class Program
{
    static string ComparerNombres(int essai, int nombreSecret)
    {
        if (essai < nombreSecret)
        {
            return "Trop petit!";
        }
        else if (essai > nombreSecret)
        {
            return "Trop grand!";
        }

        return "Exact!";
    }

    static void Main()
    {
        const int nombreSecret = 13; // Changer cette valeur pour varier le jeu.
        bool trouve = false;
        int essaisEffectues = 0;

        // Le booléen dans la condition arrête la boucle après la bonne réponse.
        for (int numeroEssai = 1; numeroEssai <= 5 && !trouve; numeroEssai++)
        {
            Console.Write("Essai " + numeroEssai + " : ");
            int proposition = int.Parse(Console.ReadLine());
            Console.WriteLine(ComparerNombres(proposition, nombreSecret));

            essaisEffectues = numeroEssai;
            trouve = proposition == nombreSecret;
        }

        if (trouve)
        {
            Console.WriteLine("Bravo! Trouvé en " + essaisEffectues + " essai(s).");
        }
        else
        {
            Console.WriteLine("Perdu! Le nombre était " + nombreSecret + ".");
        }
    }
}
```

**À tester :** avec le secret `13`, saisir `10`, `15`, `13` → « Trop petit! », « Trop grand! », « Exact! », puis « Bravo! Trouvé en 3 essai(s). ». Saisir cinq fois `1` → « Perdu! Le nombre était 13. ».

### 5.3. Dessiner un rectangle creux

La première et la dernière ligne, ainsi que la première et la dernière colonne, forment le contour. Toutes les autres positions sont des espaces.

```csharp
using System;

class Program
{
    static void DessinerRectangle(int largeur, int hauteur)
    {
        for (int ligne = 0; ligne < hauteur; ligne++)
        {
            for (int colonne = 0; colonne < largeur; colonne++)
            {
                // Une seule de ces quatre limites suffit pour être sur le bord.
                bool surLeBord = ligne == 0 || ligne == hauteur - 1
                    || colonne == 0 || colonne == largeur - 1;

                if (surLeBord)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine(); // Passer à la ligne suivante du rectangle.
        }
    }

    static void Main()
    {
        Console.Write("Largeur : ");
        int largeur = int.Parse(Console.ReadLine());
        Console.Write("Hauteur : ");
        int hauteur = int.Parse(Console.ReadLine());
        DessinerRectangle(largeur, hauteur);
    }
}
```

**À tester :** largeur `6`, hauteur `4` → quatre lignes : `******`, `*    *`, `*    *`, `******`. Largeur `3`, hauteur `3` → `***`, `* *`, `***`. Largeur `10`, hauteur `2` → deux lignes de dix astérisques.

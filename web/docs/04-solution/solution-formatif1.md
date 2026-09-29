---
title: 🏆 Solution - Formatif 1
---

# 🏆 Solution — Examen formatif 1

Ces dix programmes corrigent les exercices du [Formatif 1](../01-cours/10-formatif1.md). Chaque bloc de code est un programme console **indépendant** : copiez un seul bloc à la fois dans `Program.cs` pour l'exécuter. Les exemples de saisie utilisent la virgule décimale d'un poste configuré en français (Canada).

## 1. Types de variables et expressions arithmétiques

### 1.1. Salaire hebdomadaire

Le salaire est le produit des heures travaillées et du taux horaire. Le type `double` sert à conserver les valeurs à virgule dans cet exercice.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("==================LA PAIE=================");
        Console.Write("Nom de l'employé : ");
        string nom = Console.ReadLine();
        Console.Write("Nombre d'heures : ");
        double heures = double.Parse(Console.ReadLine());
        Console.Write("Taux horaire : ");
        double tauxHoraire = double.Parse(Console.ReadLine());

        // Conserver le résultat du calcul avant de construire la phrase finale.
        double salaire = heures * tauxHoraire;

        // ToString("F2") affiche le taux avec deux décimales.
        string tauxAffiche = tauxHoraire.ToString("F2");
        // ToString("F2") affiche le salaire avec deux décimales.
        string salaireAffiche = salaire.ToString("F2");

        Console.WriteLine();
        Console.WriteLine(nom + " a travaillé " + heures
            + " h par semaine avec un taux horaire de "
            + tauxAffiche + "$. Son salaire est de "
            + salaireAffiche + "$.");
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

class Program
{
    // Constantes de la classe : accessibles depuis Main et les autres méthodes.
    const double TAUX_QC = 0.15;
    const double TAUX_ON = 0.13;
    const double TAUX_AUTRE = 0.12;

    static void Main()
    {
        Console.Write("Prix de l'article : ");
        double prix = double.Parse(Console.ReadLine());
        Console.WriteLine("Choisir la province? 1) QC, 2) ON, 3) Autre.");
        Console.Write("Votre choix : ");
        int province = int.Parse(Console.ReadLine());

        double prixFinal = CalculerPrixApresTaxes(prix, province);
        // ToString("F2") affiche le prix avec deux décimales.
        string prixAffiche = prixFinal.ToString("F2");
        Console.WriteLine("Prix après taxes : " + prixAffiche + "$");
    }

    static double CalculerPrixApresTaxes(double prix, int province)
    {
        // Les trois choix reprennent exactement les taux de l'énoncé.
        double taux;
        if (province == 1)
        {
            taux = TAUX_QC;
        }
        else if (province == 2)
        {
            taux = TAUX_ON;
        }
        else
        {
            taux = TAUX_AUTRE; // Choix 3 : Autre
        }

        // 1 représente le prix de départ; le taux ajoute la taxe.
        return prix * (1 + taux);
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

    static string FormaterNom(string prenom, string nom)
    {
        // ToUpper transforme le nom; le prénom reste tel qu'il a été saisi.
        return nom.ToUpper() + ", " + prenom;
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
    static void Main()
    {
        Console.Write("Entrez une limite : ");
        int limite = int.Parse(Console.ReadLine());
        Console.Write("Entrez un diviseur : ");
        int diviseur = int.Parse(Console.ReadLine());

        int nombreMultiples = CompterMultiples(limite, diviseur);
        Console.WriteLine("Il y a " + nombreMultiples + " multiples de "
            + diviseur + " entre 1 et " + limite);
    }

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

}
```

**À tester :** limite `20`, diviseur `3` → `6` multiples; limite `6`, diviseur `2` → `3` multiples; limite `5`, diviseur `7` → compteur `0`.

**Défi facultatif — singulier ou pluriel :** Le calcul est correct, mais avec une limite de `1` et un diviseur de `1`, le programme affiche « Il y a 1 multiples de 1 entre 1 et 1 ». Comment adapter seulement le message pour afficher « 1 multiple » dans ce cas et conserver « 6 multiples » dans le premier test ?

### 4.2. Somme des carrés

La boucle additionne `1² + 2² + ... + N²`. L'énoncé suppose que `N` est positif.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("---Je peux vous aider à calculer la somme des carrés---");
        Console.Write("Entrez un nombre : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Le résultat est : " + SommeDesCarres(n));
    }

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

}
```

**À tester :** `5` → `55`; `1` → `1`.

## 5. Intégration : boucles, conditions et fonctions

### 5.1. Statistiques d'un groupe de notes

La boucle lit les notes une à une : aucun tableau n'est nécessaire. La première note initialise le minimum et le maximum, afin que les comparaisons suivantes aient un point de départ valide. La fonction place la mention dans une variable et la retourne à la fin.

```csharp
using System;

class Program
{
    // Les seuils sont partagés par toutes les méthodes de la classe.
    const double SEUIL_EXCELLENT = 90;
    const double SEUIL_TRES_BIEN = 75;
    const double SEUIL_REUSSITE = 60;

    static void Main()
    {
        Console.Write("Combien de notes : ");
        int nombreNotes = int.Parse(Console.ReadLine());

        double somme = 0;
        double maximum = 0;
        double minimum = 0;
        for (int i = 1; i <= nombreNotes; i++)
        {
            Console.Write("Note " + i + " : ");
            double note = double.Parse(Console.ReadLine());
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

        double moyenne = somme / nombreNotes;
        string mention = DeterminerMention(moyenne);
        // ToString("F2") affiche deux décimales sans modifier la moyenne calculée.
        string moyenneAffichee = moyenne.ToString("F2");

        Console.WriteLine();
        Console.WriteLine("Moyenne : " + moyenneAffichee);
        Console.WriteLine("Note la plus haute : " + maximum);
        Console.WriteLine("Note la plus basse : " + minimum);
        Console.WriteLine("Mention : " + mention);
    }

    static string DeterminerMention(double moyenne)
    {
        // Vérifier les seuils du plus élevé au plus bas.
        string mention;
        if (moyenne >= SEUIL_EXCELLENT)
        {
            mention = "Excellent";
        }
        else if (moyenne >= SEUIL_TRES_BIEN)
        {
            mention = "Très bien";
        }
        else if (moyenne >= SEUIL_REUSSITE)
        {
            mention = "Réussite";
        }
        else
        {
            mention = "Échec";
        }

        return mention;
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
    // Les constantes de portée de classe sont déclarées avant Main.
    const int NOMBRE_SECRET = 13; // Changer cette valeur pour varier le jeu.
    const int MAX_ESSAIS = 5;

    static void Main()
    {
        bool trouve = false;
        int essaisEffectues = 0;

        // Le booléen dans la condition arrête la boucle après la bonne réponse.
        for (int numeroEssai = 1; numeroEssai <= MAX_ESSAIS && !trouve; numeroEssai++)
        {
            Console.Write("Essai " + numeroEssai + " : ");
            int proposition = int.Parse(Console.ReadLine());
            Console.WriteLine(ComparerNombres(proposition, NOMBRE_SECRET));

            essaisEffectues = numeroEssai;
            trouve = proposition == NOMBRE_SECRET;
        }

        if (trouve)
        {
            Console.WriteLine("Bravo! Trouvé en " + essaisEffectues + " essai(s).");
        }
        else
        {
            Console.WriteLine("Perdu! Le nombre était " + NOMBRE_SECRET + ".");
        }
    }

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

}
```

**À tester :** avec le secret `13`, saisir `10`, `15`, `13` → « Trop petit! », « Trop grand! », « Exact! », puis « Bravo! Trouvé en 3 essai(s). ». Saisir cinq fois `1` → « Perdu! Le nombre était 13. ».

### 5.3. Dessiner un rectangle creux

La première et la dernière ligne, ainsi que la première et la dernière colonne, forment le contour. Toutes les autres positions sont des espaces.

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Largeur : ");
        int largeur = int.Parse(Console.ReadLine());
        Console.Write("Hauteur : ");
        int hauteur = int.Parse(Console.ReadLine());
        DessinerRectangle(largeur, hauteur);
    }

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

}
```

**À tester :** largeur `6`, hauteur `4` → quatre lignes : `******`, `*    *`, `*    *`, `******`. Largeur `3`, hauteur `3` → `***`, `* *`, `***`. Largeur `10`, hauteur `2` → deux lignes de dix astérisques.

---
title: "✅ Solutions — Laboratoire 8.2B"
---

# ✅ Solutions — Laboratoire 8.2B

[Retour au laboratoire 8.2B](/laboratoire/laboratoire8.2B)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

## 🔢Switch... case
### 🔵 Exercice S1.1 - Les jours de la semaine
```csharp
static void Main()
{
    string saisie;
    string jourTexte;
    int jour;

    Console.Write("Donne moi un numéro de jour de la semaine : ");
    saisie = Console.ReadLine();

    if (int.TryParse(saisie, out jour))
    {
        switch (jour)
        {
            case 1: jourTexte = "Dimanche"; break;
            case 2: jourTexte = "Lundi"; break;
            case 3: jourTexte = "Mardi"; break;
            case 4: jourTexte = "Mercredi"; break;
            case 5: jourTexte = "Jeudi"; break;
            case 6: jourTexte = "Vendredi"; break;
            case 7: jourTexte = "Samedi"; break;
            default: jourTexte = "ERREUR"; break;
        }

        if (jourTexte == "ERREUR") Console.WriteLine("ERREUR");
        else Console.WriteLine($"Le jour {jour} est le : {jourTexte}");
    }
    else
    {
        Console.WriteLine("ERREUR");
    }
}
```

---

### 🔵 Exercice S1.2 – Les mois de l’année
```csharp
static void Main()
{
    string saisie;
    string moisTexte;
    int mois;

    Console.Write("Donne-moi un numéro de mois (1-12) : ");
    saisie = Console.ReadLine();

    if (int.TryParse(saisie, out mois))
    {
        switch (mois)
        {
            case 1: moisTexte = "Janvier"; break;
            case 2: moisTexte = "Février"; break;
            case 3: moisTexte = "Mars"; break;
            case 4: moisTexte = "Avril"; break;
            case 5: moisTexte = "Mai"; break;
            case 6: moisTexte = "Juin"; break;
            case 7: moisTexte = "Juillet"; break;
            case 8: moisTexte = "Août"; break;
            case 9: moisTexte = "Septembre"; break;
            case 10: moisTexte = "Octobre"; break;
            case 11: moisTexte = "Novembre"; break;
            case 12: moisTexte = "Décembre"; break;
            default: moisTexte = "ERREUR"; break;
        }
        if (moisTexte == "ERREUR") Console.WriteLine("ERREUR");
        else Console.WriteLine($"Le mois {mois} correspond à {moisTexte.ToLower()}.");
    }
    else
    {
        Console.WriteLine("ERREUR");
    }
}
```
---

### 🔵 Exercice S1.3 – Calculer l’aire 1.0
```csharp
  static void Main()
 {
     string saisie, forme = "", formule = "";
     int choix;

     Console.WriteLine("=== Bienvenue dans votre assistant de calcul d’aire v1.0! ===");
     Console.WriteLine("Quelle formule désirez-vous consulter :");
     Console.WriteLine("1. Carré");
     Console.WriteLine("2. Rectangle");
     Console.WriteLine("3. Cercle");
     Console.WriteLine("4. Triangle");
     Console.Write("Votre choix : ");
     saisie = Console.ReadLine();

     if (int.TryParse(saisie, out choix) && choix >= 1 && choix <= 4)
     {
         switch (choix)
         {
             case 1: forme = "carré"; formule = "côté * côté"; break;
             case 2: forme = "rectangle"; formule = "longueur * largeur"; break;
             case 3: forme = "cercle"; formule = "3.1416 * (rayon * rayon)"; break;
             case 4: forme = "triangle"; formule = "(base × hauteur) / 2"; break;
         }
         Console.WriteLine($"\nPour calculer l'aire d'un {forme}, faites : {formule}");
     }
     else
         Console.WriteLine("ERREUR");
 }
```
---

### 🔵 Exercice S1.4 – Classes de permis 1.0
```csharp
static void Main()
{
    string saisie, description = "";
    int choix;

    // Données fictives pour pratiquer les tableaux et switch.
    string[,] permis = {
        { "C", "Véhicule" },
        { "1", "Tous" },
        { "2", "Autobus 24p+" },
        { "3", "Camion" },
        { "4", "Véhicules d'urgence" },
        { "5", "Automobiles" },
        { "6", "Motocyclettes" },
        { "7", "Apprenti" },
        { "8", "Tracteur" }
    };

    Console.Write("Quelle classe de permis voulez-vous vérifier (1-8) ? ");
    saisie = Console.ReadLine();

    if (int.TryParse(saisie, out choix) && choix >= 1 && choix <= 8)
    {
        switch (choix)
        {
            case 1: description = permis[1, 1]; break;
            case 2: description = permis[2, 1]; break;
            case 3: description = permis[3, 1]; break;
            case 4: description = permis[4, 1]; break;
            case 5: description = permis[5, 1]; break;
            case 6: description = permis[6, 1]; break;
            case 7: description = permis[7, 1]; break;
            case 8: description = permis[8, 1]; break;
        }

        Console.WriteLine($"\nLa classe {choix} autorise la conduite pour : {description}");
    }
    else
        Console.WriteLine("ERREUR : Veuillez entrer un chiffre entre 1 et 8.");
}
```
---

### 🔵 Exercice S1.5 – Cinéma 1.0
```csharp
static void Main()
{
    string saisie, film;
    int choix;

    string[] filmsHarry = {
        "À l'école des sorciers (2001)",
        "La Chambre des secrets (2002)",
        "Le Prisonnier d'Azkaban (2004)",
        "La Coupe de feu (2005)",
        "L'Ordre du Phénix (2007)",
        "Le Prince de sang-mêlé (2009)",
        "Les Reliques de la Mort, partie 1 (2010)",
        "Les Reliques de la Mort, partie 2 (2011)"
    };

    Console.Write("Quel film de Harry Potter voulez-vous consulter (1-8)? ");
    saisie = Console.ReadLine();

    if (int.TryParse(saisie, out choix))
    {
        switch (choix)
        {
            case 1: film = filmsHarry[0]; break;
            case 2: film = filmsHarry[1]; break;
            case 3: film = filmsHarry[2]; break;
            case 4: film = filmsHarry[3]; break;
            case 5: film = filmsHarry[4]; break;
            case 6: film = filmsHarry[5]; break;
            case 7: film = filmsHarry[6]; break;
            case 8: film = filmsHarry[7]; break;
            default: film = "ERREUR"; break;
        }
        Console.WriteLine(film);
    }
    else
        Console.WriteLine("ERREUR");
}
```
---

## 🌀WHILE
### 🔵 Exercice W1.1 – Compter de 1 à 100
```csharp

 static void Main()
    {
        int compteur = 1;

        while (compteur <= 100)
        {
            Console.WriteLine(compteur);
            compteur++;
        }
    }

```
---

### 🔵 Exercice W1.2 – Demander le code secret
```csharp
static void Main()
{
    string reponse = "";

    while (reponse != "Moi")
    {
        Console.Write("T’es qui, toi? ");
        reponse = Console.ReadLine();

        if (reponse != "Moi")
            Console.WriteLine("Mauvaise réponse… Essaie toi encore ;)");
    }
    Console.WriteLine("Bonne réponse ! :D");
}
```
---

### 🔵 Exercice W1.3 – Afficher le budget
```csharp
static void Main()
{
    int budget = 100, depense = 0;
    string saisie;

    Console.WriteLine($"Ton budget : {budget}$");

    while (budget > 0)
    {
        Console.Write("Combien as-tu dépensé? ");
        saisie = Console.ReadLine();

        if (int.TryParse(saisie, out depense) && depense >= 0)
        {
            budget -= depense;
            Console.WriteLine($"Il te reste: {budget}$");
        }
        else
            Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
    }
    Console.WriteLine("Oh no, pas encore!");
}
```
---

### 🔵 Exercice W1.4 – Quelle est la moitié de…
```csharp
static void Main()
{
    string saisie;
    double valeur;


    Console.Write("Trouvons la moitié de : ");
     saisie = Console.ReadLine();

    if (double.TryParse(saisie, out valeur))
    {
        while (valeur > 0.5)
        {
            valeur /= 2;
            Console.WriteLine(valeur);
        }
    }
    else
        Console.WriteLine("Entrée invalide. Veuillez entrer un nombre.");
}
```
---

### 🔵 Exercice W1.5 – Les amis à Harry
```csharp
static void Main()
{
    string reponse = "";

    while (reponse != "hermione" && reponse != "ron")
    {
        Console.Write("Nommez un des amis de Harry Potter : ");
        reponse = Console.ReadLine();
        reponse = reponse.ToLower();
    }
    Console.WriteLine("Bonne réponse !");
}
```
---

## ➡️🌀DO WHILE
### 🔵 Exercice DW1.1 – Majeurs
```csharp
static void Main(string[] args)
{
    int age;
    do
    {
        Console.Write("À quel âge on devient majeur ? ");
        if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Entrée invalide.");
            age = 0;
        }
    } while ( age !=18 && age!=21);
}
```
---

### 🔵 Exercice DW1.2 – Les épargnes
```csharp
static void Main(string[] args)
{
    double epargnes=0, total=0;
    do
    {
        Console.Write("Combien désirez-vous épargner ce mois-ci? ");
        if (double.TryParse(Console.ReadLine(), out epargnes) && epargnes >= 0)
        {
            total += epargnes;
        }
        else
        {
            Console.WriteLine("Entrée invalide.");
            epargnes = -1; // Redemander sans terminer la boucle.
        }
    } while (epargnes!=0);

    Console.WriteLine("\n----------------------------------------");
    Console.WriteLine("Vous avez cumulé : " + total.ToString("F2") + " $");
}
```
---

### 🔵 Exercice DW1.3 – Quai de Harry Potter
```csharp
static void Main()
{
    double station;
    string saisie;

    do
    {
        Console.Write("Quel est le numéro de quai de Harry Potter ? ");
        saisie=Console.ReadLine();

        double.TryParse(saisie, out station);

    } while (station != 9.75);

    Console.WriteLine("Bonne réponse !");
}
```
--- 

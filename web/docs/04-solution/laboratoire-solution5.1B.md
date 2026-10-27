---
title: "✅ Solutions — Laboratoire 5.1B"
---

# ✅ Solutions — Laboratoire 5.1B

[Retour au laboratoire 5.1B](/laboratoire/laboratoire5.1B)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

## 🟣 Exercice 1
```csharp
static void Main(string[] args)
{
    double[] notes = { 70.0, 80.5, 90.0 };

    double moyenne = CalculerMoyenneFinale(notes);

    Console.WriteLine("Notes : " + string.Join(", ", notes));
    Console.WriteLine("Moyenne : " + moyenne);
}

static double CalculerMoyenneFinale(double[] pNotes)
{
    double moyenne;
    moyenne = pNotes[0] * 0.3 + pNotes[1] * 0.2 + pNotes[2] * 0.5;
    return moyenne;
}
```
## 🟣 Exercice 2
```csharp
static void Main(string[] args)
{
    double[] notes = { -3, 80.5, 90 };

    double moyenne = CalculerMoyenneFinale(notes);

    Console.WriteLine("Notes : " + string.Join(", ", notes));
    Console.WriteLine("Moyenne : " + moyenne);
}


static double CalculerMoyenneFinale(double[] pNotes)
{
    if (pNotes.Length != 3)
    {
        Console.WriteLine("Erreur ! Il n'y a pas le bon nombre de notes !");
        return 0.0;
    }
    if (pNotes[0] < 0.0 || pNotes[1] < 0.0 || pNotes[2] < 0.0)
    {
        Console.WriteLine("Erreur ! Une note n'est pas valide !");
        return 0.0;
    }
    double moyenne;
    moyenne = pNotes[0] * 0.3 + pNotes[1] * 0.2 + pNotes[2] * 0.5;

    return moyenne;
    }
```
## 🟣 Exercice 3
```csharp
static void Main(string[] args)
{
    int[] tab1 = { 1, 2, 3, 4, 5 };
    int[] tab2 = { 11, 25, 50};

    int[] reponse = ObtenirPlusGrandTableau(tab1, tab2);

    Console.Write("Le plus grand tableau est : ");
    Console.WriteLine(string.Join(", ", reponse));

}

static int[] ObtenirPlusGrandTableau(int[] ptab1, int[] ptab2)
{
    if (ptab1.Length >= ptab2.Length)
    {
        return ptab1;
    }
    else
    {
        return ptab2;
    }
}
```
## 🟣 Exercice 4
```csharp
static void Main(string[] args)
{
    string[] profs = { "David", "Éric", "Jamil" };

    string resultat1 = ObtenirValeurParIndex(5, profs);
    string resultat2 = ObtenirValeurParIndex(1, profs);

    Console.WriteLine("Avec index 5 : " + resultat1);
    Console.WriteLine("Avec index 1 : " + resultat2);


}


static string ObtenirValeurParIndex(int pIndex, string[] pTableau)
{
    if (pIndex < 0 || pIndex >= pTableau.Length) 
    {
        return "Erreur, index non valide";
    }
    return pTableau[pIndex];
}
```

## 🟣 Exercice 5
```csharp
static void Main(string[] args)
{
    Console.Write("Entrez un mot : ");
    string mot = Console.ReadLine();

    Console.WriteLine("Mot saisi : " + mot);
    int nbA = CompterOccurrencesA(mot);

    Console.WriteLine("Nombre de lettres : " + mot.Length);
    Console.WriteLine("Nombre de 'a' : " + nbA);
}

static int CompterOccurrencesA(string pMot)
{
    int compteur = 0;
    for (int i = 0; i < pMot.Length; i++)
    {
        Console.WriteLine(pMot[i]); // affiche chaque lettre
        if (pMot[i] == 'a' || pMot[i] == 'A')
        {
            compteur++;
        }
    }
    return compteur;
}
```

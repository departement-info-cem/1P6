---
title: "✅ Solutions — Laboratoire 6.2A"
---

# ✅ Solutions — Laboratoire 6.2A

[Retour au laboratoire 6.2A](/laboratoire/laboratoire6.2A)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

```csharp
using System;
class Program
{
    static void Main()
    {
        string[] motsAVerifier = { "Tomate", "Radar", "Tôt", "Kayak", "Pomme", "Pop", "Jazz", "Anna", "Montréal", "Laval", "Toronto" };
        for (int i = 0; i < motsAVerifier.Length; i++)
        {
            if (EstUnPalindrome(motsAVerifier[i]))
                Console.WriteLine(motsAVerifier[i] + " est un palindrome");
            else
                Console.WriteLine(motsAVerifier[i] + " n'est PAS un palindrome");
        }
    }
    static string InverserMot(string pMotAInverser)
    {
        string nouveauMot = "";
        for (int i = pMotAInverser.Length - 1; i >= 0; i--)
            nouveauMot += pMotAInverser[i];
        return nouveauMot;
    }
    static bool EstUnPalindrome(string pMot)
    {
        string motMinuscule = pMot.ToLower();
        string motInverse = InverserMot(motMinuscule);
        return motMinuscule == motInverse;
    }
}
```

La boucle part du dernier indice et inclut l'indice `0`. Le passage en minuscules permet de reconnaître `Radar` et `Anna`. Les accents sont conservés : `Tôt` devient `tôt`, qui reste identique à son inverse. Les palindromes de la liste sont `Radar`, `Tôt`, `Kayak`, `Pop`, `Anna` et `Laval`.

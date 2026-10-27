---
title: "✅ Solutions — Laboratoire 6.2C"
---

# ✅ Solutions — Laboratoire 6.2C

[Retour au laboratoire 6.2C](/laboratoire/laboratoire6.2C)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

```csharp
using System;
class Program
{
    static void Main()
    {
        Console.Write("Entrez les notes de la classe : ");
        string[] textes = Console.ReadLine().Split('|');
        int[] notes = TransformerEnTableauDeInt(textes);
        Console.WriteLine($"Il y a {notes.Length} notes.");
        Console.WriteLine($"La moyenne est : {CalculerMoyenne(notes):F2}");
        Console.WriteLine($"Il y a {CompterNombreÉchecs(notes)} échecs");
    }
    static int[] TransformerEnTableauDeInt(string[] textes)
    {
        int[] notes = new int[textes.Length];
        for (int i = 0; i < textes.Length; i++)
            notes[i] = int.Parse(textes[i]);
        return notes;
    }
    static int CompterNombreÉchecs(int[] notes)
    {
        int echecs = 0;
        for (int i = 0; i < notes.Length; i++)
            if (notes[i] < 60) echecs++;
        return echecs;
    }
    static double CalculerMoyenne(int[] notes)
    {
        long somme = 0;
        for (int i = 0; i < notes.Length; i++) somme += notes[i];
        return (double)somme / notes.Length;
    }
}
```

Comme l'énoncé, cette solution suppose un ensemble non vide de notes entières valides entre `0` et `100`. La somme utilise un `long`, entier de plus grande capacité, afin que les additions ne débordent pas celle d'un `int`. La conversion en `double` avant la division conserve les décimales et le retour reste `double`.

Par calcul, sans allouer un grand tableau : `21474837` notes de `100` donneraient une somme de `2147483700` et une moyenne de `100,00`. Les trois ensembles habituels conservent les résultats ci-dessous.

| Ensemble du laboratoire | Nombre | Moyenne (`F2`) | Échecs |
| --- | ---: | ---: | ---: |
| Premier | 10 | 75,80 | 2 |
| Deuxième | 15 | 63,20 | 6 |
| Troisième | 11 | 50,00 | 6 |

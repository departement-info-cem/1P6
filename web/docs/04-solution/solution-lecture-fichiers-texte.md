---
title: 🏆 Solution - Lecture de fichiers texte
---

# 🏆 Solution — Lecture de fichiers texte : Analyseur de journal

Chaque durée est lue en `int`. Les compteurs et le total des minutes utilisent des `long`, des entiers de plus grande capacité : les additions sont ainsi faites directement en `long`. On suppose que ces cumuls restent représentables dans ce type. La durée maximale d'une seule tâche reste un `int` et la moyenne est calculée en `double`.

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string chemin = @"C:\EspaceLabo\taches.txt";

        if (!File.Exists(chemin))
        {
            Console.WriteLine("Fichier taches.txt introuvable.");
            return;
        }

        long nombreTaches = 0;
        long totalMinutes = 0;
        long taches30MinutesOuPlus = 0;
        long lignesRejetees = 0;
        int dureeMaximum = 0;
        string tachePlusLongue = "";

        using (StreamReader lecteur = new StreamReader(chemin))
        {
            while (!lecteur.EndOfStream)
            {
                string ligne = lecteur.ReadLine();
                string[] parties = ligne.Split(';');
                int duree;

                if (parties.Length != 2 || parties[0] == "" ||
                    !int.TryParse(parties[1], out duree) || duree <= 0)
                {
                    lignesRejetees++;
                }
                else
                {
                    nombreTaches++;
                    totalMinutes = totalMinutes + duree;

                    if (duree >= 30)
                    {
                        taches30MinutesOuPlus++;
                    }

                    if (duree > dureeMaximum)
                    {
                        dureeMaximum = duree;
                        tachePlusLongue = parties[0];
                    }
                }
            }
        }

        Console.WriteLine("Nombre de tâches : " + nombreTaches);
        Console.WriteLine("Total des minutes : " + totalMinutes);

        if (nombreTaches == 0)
        {
            Console.WriteLine("Lignes rejetées : " + lignesRejetees);
            Console.WriteLine("Aucune tâche valide.");
        }
        else
        {
            double moyenne = (double)totalMinutes / nombreTaches;
            Console.WriteLine("Durée moyenne : " + moyenne.ToString("F2") + " minutes");
            Console.WriteLine("Tâche la plus longue : " + tachePlusLongue);
            Console.WriteLine("Tâches de 30 minutes ou plus : " + taches30MinutesOuPlus);
            Console.WriteLine("Lignes rejetées : " + lignesRejetees);
        }
    }
}
```

**Test de capacité :** les lignes `A;1500000000` et `B;1500000000` donnent `2` tâches, `3000000000` minutes au total, une moyenne de `1500000000,00` minutes et `A` comme première tâche de durée maximale.

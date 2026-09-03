---
title: 🏆 Solution - Conditions
---

# 🏆 Solution — Conditions : Tarif du centre des sciences

## Analyse du mandat — éléments attendus

Le programme doit choisir un seul tarif à partir de l'âge et, seulement pour une personne de `18` à `64` ans, de la présence d'une carte étudiante.

La validation d'un âge impossible doit avoir lieu avant la tarification. Les tarifs déterminés uniquement par l'âge doivent aussi être distingués du tarif étudiant afin qu'une personne de `65` ans ou plus reçoive toujours le tarif aîné.

| Âge frontière | Résultat attendu |
| ---: | --- |
| 5 | Gratuit |
| 6 | `8 $`, tarif jeunesse |
| 17 | `8 $`, tarif jeunesse |
| 18 | Demander la carte; `10 $` avec carte ou `14 $` sans carte |
| 64 | Demander la carte; `10 $` avec carte ou `14 $` sans carte |
| 65 | `9 $`, tarif aîné, sans demander la carte |

Un cas valide supplémentaire pourrait être `40` ans avec la réponse `non`, pour un tarif adulte de `14 $`. Un cas invalide supplémentaire pourrait être `121` ans, qui doit produire une erreur sans tarif.

## Exemple de code

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.Write("Âge : ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0 || age > 120)
        {
            Console.WriteLine("Âge invalide.");
        }
        else if (age < 6)
        {
            Console.WriteLine("Tarif applicable : Gratuit");
            Console.WriteLine("Raison : enfant de moins de 6 ans");
        }
        else if (age <= 17)
        {
            Console.WriteLine("Tarif applicable : 8 $");
            Console.WriteLine("Raison : tarif jeunesse");
        }
        else if (age >= 65)
        {
            Console.WriteLine("Tarif applicable : 9 $");
            Console.WriteLine("Raison : tarif aîné");
        }
        else
        {
            Console.Write("Carte étudiante (oui/non) : ");
            string carteEtudiante = Console.ReadLine();

            if (age >= 18 && age <= 64 && carteEtudiante == "oui")
            {
                Console.WriteLine("Tarif applicable : 10 $");
                Console.WriteLine("Raison : tarif étudiant");
            }
            else
            {
                Console.WriteLine("Tarif applicable : 14 $");
                Console.WriteLine("Raison : tarif adulte");
            }
        }
    }
}
```

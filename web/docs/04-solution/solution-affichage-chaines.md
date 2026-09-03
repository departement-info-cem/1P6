---
title: 🏆 Solution - Affichage et chaînes
---

# 🏆 Solution — Affichage et chaînes : Billet de bienvenue

## Analyse du mandat — éléments attendus

| Question | Réponse possible |
| --- | --- |
| À qui le billet est-il destiné? | À une nouvelle personne qui arrive dans la technique. |
| Quelles valeurs doivent pouvoir être modifiées? | Le nom, le groupe, le local et l'heure de début. |
| Quels textes peuvent rester fixes? | Le titre, les libellés, le message d'encouragement et les bordures. |
| Quel ordre est obligatoire? | `Nom`, `Groupe`, `Local`, puis `Début`. |
| Quels choix de présentation sont libres? | Les espaces, les bordures et l'apparence générale du billet. |

Une variable conserve une information qui peut changer d'un billet à l'autre. Un texte fixe demeure normalement identique, comme le titre ou le libellé `Nom`.

Un cas d'essai valide pourrait utiliser `Sam`, groupe `1070`, local `D-130` et début `9 h 30`. Le billet attendu doit présenter exactement ces quatre nouvelles valeurs sans perdre le titre, les libellés ni le message d'encouragement.

## Exemple de code

```csharp
using System;

class Program
{
    static void Main()
    {
        string nom = "Alex Tremblay";
        string groupe = "1090";
        string local = "B-321";
        string debut = "8 h 00";

        Console.WriteLine("====================================");
        Console.WriteLine("     BIENVENUE EN TECHNIQUE INFO");
        Console.WriteLine("====================================");
        Console.WriteLine("Nom     : " + nom);
        Console.WriteLine("Groupe  : " + groupe);
        Console.WriteLine("Local   : " + local);
        Console.WriteLine("Début   : " + debut);
        Console.WriteLine();
        Console.WriteLine("Bonne première journée !");
    }
}
```

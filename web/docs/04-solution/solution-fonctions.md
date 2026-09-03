---
title: 🏆 Solution - Fonctions
---

# 🏆 Solution — Fonctions : Commande de pizzas

## Analyse du mandat — éléments attendus

- **Besoin :** calculer et détailler le montant total d'une commande de pizza.
- **Données reçues :** taille, nombre de garnitures et choix de livraison.
- **Résultats produits :** pizza et garnitures, livraison, montant taxable, taxes et total.
- **Règles :** petite pizza `12,00 $`; grande pizza `18,00 $`; garniture `1,50 $`; livraison `5,00 $`; taxe de `14,975 %` sur la pizza, les garnitures et la livraison.
- **Dépendances :** le montant taxable dépend des premiers montants; les taxes dépendent du montant taxable; le total dépend du montant taxable et des taxes.
- **Responsabilités possibles :** obtenir le prix de la taille, calculer la pizza et les garnitures, obtenir les frais de livraison, puis coordonner et afficher la commande.

Deux erreurs de compréhension possibles seraient d'oublier de taxer la livraison ou d'ajouter `14,975` au lieu de calculer `14,975 %` du montant taxable.

Un cas d'essai supplémentaire est une grande pizza avec une garniture et sans livraison : pizza et garnitures `19,50 $`, livraison `0,00 $`, montant taxable `19,50 $`, taxes `2,92 $` et total `22,42 $`.

Une question réaliste pour la pizzeria serait : « Comment l'application doit-elle réagir à une taille, une quantité ou une réponse de livraison invalide? » Le prototype actuel suppose que toutes les saisies sont valides.

## Exemple de code

```csharp
using System;

class Program
{
    static double ObtenirPrixPizza(string taille)
    {
        if (taille == "P")
        {
            return 12.00;
        }

        return 18.00;
    }

    static double CalculerPizzaEtGarnitures(string taille, int nombreGarnitures)
    {
        return ObtenirPrixPizza(taille) + nombreGarnitures * 1.50;
    }

    static double ObtenirFraisLivraison(string livraison)
    {
        if (livraison == "oui")
        {
            return 5.00;
        }

        return 0.00;
    }

    static void Main()
    {
        const double TAUX_TAXE = 0.14975;

        Console.Write("Taille (P ou G) : ");
        string taille = Console.ReadLine();
        Console.Write("Nombre de garnitures : ");
        int nombreGarnitures = int.Parse(Console.ReadLine());
        Console.Write("Livraison (oui/non) : ");
        string livraison = Console.ReadLine();

        double pizzaEtGarnitures = CalculerPizzaEtGarnitures(taille, nombreGarnitures);
        double fraisLivraison = ObtenirFraisLivraison(livraison);
        double montantTaxable = pizzaEtGarnitures + fraisLivraison;
        double taxes = montantTaxable * TAUX_TAXE;
        double total = montantTaxable + taxes;

        Console.WriteLine();
        Console.WriteLine("Pizza et garnitures : " + pizzaEtGarnitures.ToString("F2") + " $");
        Console.WriteLine("Frais de livraison : " + fraisLivraison.ToString("F2") + " $");
        Console.WriteLine("Montant taxable : " + montantTaxable.ToString("F2") + " $");
        Console.WriteLine("Taxes : " + taxes.ToString("F2") + " $");
        Console.WriteLine("Total à payer : " + total.ToString("F2") + " $");
    }
}
```

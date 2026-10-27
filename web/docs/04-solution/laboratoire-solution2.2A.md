---
title: "✅ Solutions — Laboratoire 2.2A"
---

# ✅ Solutions — Laboratoire 2.2A

[Retour au laboratoire 2.2A](/laboratoire/laboratoire2.2A)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

## Exercice 1 — Prime de rendement

Le `else if` empêche de cumuler les deux primes de base. La prime d'ancienneté est indépendante.

```csharp
Console.Write("Ventes : ");
double ventes = double.Parse(Console.ReadLine());
Console.Write("Heures : ");
int heures = int.Parse(Console.ReadLine());
Console.Write("Ancienneté : ");
int anciennete = int.Parse(Console.ReadLine());

if (ventes < 0 || heures < 0 || anciennete < 0)
{
    Console.WriteLine("Erreur : aucune valeur ne peut être négative.");
}
else
{
    int prime = 0;
    string raison = "";
    if (ventes >= 3000)
    {
        prime = 500;
        raison += "- Prime de rendement exceptionnelle : 500 $\n";
    }
    else if (ventes >= 2000 && heures >= 30)
    {
        prime = 300;
        raison += "- Prime de rendement : 300 $\n";
    }
    if (anciennete >= 5)
    {
        prime += 100;
        raison += "- Prime d'ancienneté : 100 $\n";
    }
    if (prime == 0) raison = "- Aucune condition de prime satisfaite.";
    Console.WriteLine($"Prime totale : {prime} $");
    Console.WriteLine("Raison :\n" + raison);
}
```

Les quatre cas valides du laboratoire donnent respectivement `600`, `300`, `100` et `0` dollars. Une valeur négative produit uniquement l'erreur.

## Exercice 2 — Admission

```csharp
Console.Write("Âge : ");
int age = int.Parse(Console.ReadLine());
Console.Write("Billet valide (oui/non) : ");
bool billet = Console.ReadLine() == "oui";
Console.Write("Accompagnateur (oui/non) : ");
bool accompagne = Console.ReadLine() == "oui";

if (age < 0 || age > 120)
{
    Console.WriteLine("Erreur : âge invalide.");
}
else if (billet && (age >= 18 || accompagne))
{
    Console.WriteLine("Admission autorisée");
    if (age >= 18)
        Console.WriteLine("Raison : majeur avec billet valide.");
    else
        Console.WriteLine("Raison : mineur accompagné avec billet valide.");
}
else
{
    Console.WriteLine("Admission refusée");
    if (!billet) Console.WriteLine("Raison : billet absent ou invalide.");
    else Console.WriteLine("Raison : mineur sans accompagnateur.");
}
```

Les cas `(20, oui, non)` et `(15, oui, oui)` sont acceptés. Sans billet, ou pour un mineur sans accompagnateur, l'admission est refusée. L'âge `-5` est invalide.

## Exercice 3 — Facture

La livraison dépend du montant initial. Le rabais est calculé sur la commande, jamais sur la livraison.

```csharp
Console.Write("Montant de la commande : ");
double montant = double.Parse(Console.ReadLine());
Console.Write("Client Premium (oui/non) : ");
bool premium = Console.ReadLine() == "oui";

if (montant < 0)
{
    Console.WriteLine("Erreur : montant invalide.");
}
else
{
    double livraison = 5;
    if (montant < 25) livraison = 8;
    if (premium) livraison = 0;
    double montantApresRabais = montant;
    if (montant > 100) montantApresRabais *= 0.90;
    double total = montantApresRabais + livraison;
    Console.WriteLine($"Montant après rabais : {montantApresRabais:F2} $");
    Console.WriteLine($"Frais de livraison : {livraison:F2} $");
    Console.WriteLine($"Total à payer : {total:F2} $");
}
```

Les tests du laboratoire donnent `113`, `108`, `28`, `20` dollars, puis une erreur. À `100` dollars exactement, aucun rabais; à `0` dollar sans Premium, le total est `8` dollars.

## Exercice 4 — Réussite

Les trois notes sont des entrées distinctes. On valide tout d'abord leur intervalle, puis chaque cause d'échec avec un `if` indépendant.

```csharp
Console.Write("Note d'examen : ");
double examen = double.Parse(Console.ReadLine());
Console.Write("Note des travaux : ");
double travaux = double.Parse(Console.ReadLine());
Console.Write("Moyenne finale : ");
double moyenne = double.Parse(Console.ReadLine());

if (examen < 0 || examen > 100 || travaux < 0 || travaux > 100 ||
    moyenne < 0 || moyenne > 100)
{
    Console.WriteLine("Erreur : notes invalides.");
}
else if (examen >= 60 && travaux >= 60 && moyenne >= 60)
{
    Console.WriteLine("Résultat : Réussite");
}
else
{
    Console.WriteLine("Résultat : Échec\nConditions non respectées :");
    if (examen < 60) Console.WriteLine("- Examen inférieur à 60 %");
    if (travaux < 60) Console.WriteLine("- Travaux inférieurs à 60 %");
    if (moyenne < 60) Console.WriteLine("- Moyenne finale inférieure à 60 %");
}
```

`55, 70, 58` donne deux raisons; `55, 50, 55` en donne trois. Les trois notes à `60` suffisent pour réussir.

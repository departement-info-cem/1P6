---
title: "✅ Solutions — Laboratoire 2.1B"
---

# ✅ Solutions — Laboratoire 2.1B

[Retour au laboratoire 2.1B](/laboratoire/laboratoire2.1B)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, comme à l’exercice 17, remplacez le contenu de `Program.cs`. Les exemples de saisie décimale supposent un poste configuré en français (Canada).

## Exercice 1 — Besoin de café

```csharp
bool jeSuisFatigue = true;

if (jeSuisFatigue)
{
    Console.WriteLine("Voici la solution : café");
}
```


## Exercice 2 — Contrôle de majorité

```csharp
Console.Write("Quel est ton âge ? ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
    Console.WriteLine("Tu es majeur.");
}
```


## Exercice 3 — Le mot magique

```csharp
Console.Write("Quel est le mot magique ? ");
string mot = Console.ReadLine();

if (mot == "abracadabra")
{
    Console.WriteLine("Tu connais la magie toi !");
}
else
{
    Console.WriteLine("Mot incorrect... essaie encore.");
}
```


## Exercice 4 — Pair ou impair

```csharp
Console.Write("Entrez un nombre : ");
int nombre = int.Parse(Console.ReadLine());

if (nombre % 2 == 0)
{
    Console.WriteLine("Nombre pair");
}
else
{
    Console.WriteLine("Nombre impair");
}
```


## Exercice 5 — LEGO

```csharp
Console.Write("Quel est ton âge ? ");
int age = int.Parse(Console.ReadLine());

if (age < 4 || age > 99)
{
    Console.WriteLine("Tu ne peux pas jouer avec des LEGO");
}
else
{
    Console.WriteLine("Tu peux jouer avec des LEGO");
}
```


## Exercice 6 — Es-tu prêt ?

```csharp
Console.Write("Es-tu prêt ? (true/false) ");
bool estPret = bool.Parse(Console.ReadLine());

if (!estPret)
{
    Console.WriteLine("Tu n’es pas prêt.");
}
```


## Exercice 7 — Jeune adulte fatigué

```csharp
Console.Write("Âge : ");
int age = int.Parse(Console.ReadLine());

Console.Write("Heures de sommeil : ");
int heures = int.Parse(Console.ReadLine());

if (age >= 18 && age <= 30 && heures < 6)
{
    Console.WriteLine("Jeune adulte fatigué");
}
else
{
    Console.WriteLine("Tu sembles en forme !");
}
```


## Exercice 8 — Prix du pantalon

```csharp
Console.Write("Prix : ");
double prix = double.Parse(Console.ReadLine());

if (prix >= 100)
{
    Console.WriteLine("Je vais chercher un rip-off cheap sur Amazon à la place");
}
else if (prix < 30)
{
    Console.WriteLine("Wow c'est un beau prix. C'est sus.");
}
else
{
    Console.WriteLine("Prix raisonnable");
}
```


## Exercice 9 — Température

```csharp
Console.Write("Température : ");
int temperature = int.Parse(Console.ReadLine());

if (temperature < 0)
{
    Console.WriteLine("Il gèle dehors !");
}
else if (temperature <= 25)
{
    Console.WriteLine("Température agréable");
}
else
{
    Console.WriteLine("Il fait chaud !");
}
```


## Exercice 10 — Plus grand des trois

```csharp
Console.Write("Nombre A : ");
int a = int.Parse(Console.ReadLine());

Console.Write("Nombre B : ");
int b = int.Parse(Console.ReadLine());

Console.Write("Nombre C : ");
int c = int.Parse(Console.ReadLine());

int plusGrand = a;

if (b > plusGrand)
{
    plusGrand = b;
}
if (c > plusGrand)
{
    plusGrand = c;
}

Console.WriteLine($"Le plus grand est : {plusGrand}");
```


## Exercice 11 — Questionnaire éclair

```csharp
int score = 0;

Console.Write("As-tu dormi 8h ? (true/false) ");
bool sommeil = bool.Parse(Console.ReadLine());
if (sommeil) score++;

Console.Write("As-tu mangé ce matin ? (true/false) ");
bool mange = bool.Parse(Console.ReadLine());
if (mange) score++;

Console.Write("As-tu fait tes devoirs ? (true/false) ");
bool devoirs = bool.Parse(Console.ReadLine());
if (devoirs) score++;

Console.WriteLine($"Score : {score}");

if (score == 3)
{
    Console.WriteLine("Tu es prêt pour la journée !");
}
else if (score >= 1)
{
    Console.WriteLine("Pas mal, mais tu peux faire mieux !");
}
else
{
    Console.WriteLine("Aïe... une journée difficile t'attend");
}
```


## Exercice 12 — Gym pour variables

```csharp
int score = 10;

score += 5;
score *= 2;
score++;
score--;
score--;

Console.WriteLine($"Score final : {score}");
```


## Exercice 13 — Aliment préféré

```csharp
Console.Write("Aliment préféré : ");
string aliment = Console.ReadLine();

if (aliment == "brocoli")
{
    Console.WriteLine("Miam. Un des aliments avec le plus de nutriments");
}
else
{
    Console.WriteLine("Huh, c'est mieux le brocoli");
}
```


## Exercice 14 — Code secret

```csharp
Console.Write("Prénom : ");
string prenom = Console.ReadLine();

Console.Write("Code : ");
int code = int.Parse(Console.ReadLine());

if (prenom == "Alice" && code == 1234)
{
    Console.WriteLine("Accès accordé");
}
else
{
    Console.WriteLine("Accès refusé");
}
```


## Exercice 15 — Loterie

```csharp
int nombreMystere = 7;

Console.Write("Choisis un chiffre : ");
int chiffre = int.Parse(Console.ReadLine());

if (chiffre == nombreMystere)
{
    Console.WriteLine("Félicitations, tu as gagné !");
}
else
{
    Console.WriteLine("Désolé, ce n’est pas le bon numéro");
}
```


## Exercice 16 — Film recommandé

```csharp
Console.Write("Quel est ton âge ? ");
int age = int.Parse(Console.ReadLine());

if (age < 13)
{
    Console.WriteLine("Tu peux regarder : Coco");
}
else if (age >= 13 && age <= 17)
{
    Console.WriteLine("Tu peux regarder : Spider-Man");
}
else
{
    Console.WriteLine("Tu peux regarder : Inception");
}
```


## Exercice 17 — Jeu des deux dés

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

        Console.WriteLine("Score : " + score);
    }
}
```

## Variantes avec deux `if` indépendants

Dans les exercices 3 et 4, les deux conditions doivent être complémentaires. Les blocs suivants remplacent uniquement le traitement après la saisie.

```csharp
// Exercice 3 : mot a déjà été saisi.
if (mot == "abracadabra")
{
    Console.WriteLine("Tu connais la magie toi !");
}
if (mot != "abracadabra")
{
    Console.WriteLine("Mot incorrect... essaie encore.");
}
```

```csharp
// Exercice 4 : nombre a déjà été saisi.
if (nombre % 2 == 0)
{
    Console.WriteLine("Nombre pair");
}
if (nombre % 2 != 0)
{
    Console.WriteLine("Nombre impair");
}
```

Pour l’exercice 5, une variable booléenne permet d’utiliser deux `if` sans `||` :

```csharp
// age a déjà été saisi.
bool peutJouer = age >= 4 && age <= 99;
if (peutJouer)
{
    Console.WriteLine("Tu peux jouer avec des LEGO");
}
if (!peutJouer)
{
    Console.WriteLine("Tu ne peux pas jouer avec des LEGO");
}
```

---
title: "✅ Solutions — Laboratoire 1.2B"
---

# ✅ Solutions — Laboratoire 1.2B

[Retour au laboratoire 1.2B](/laboratoire/laboratoire1.2B)

Chaque exercice est indépendant. Placez les instructions de chaque bloc dans la méthode `Main` de votre projet console. Les exemples de saisie décimale supposent un poste configuré en français (Canada).

## Exercice 1 — Déclarer et initialiser

```csharp
string prenom = "Adam";
string nom = "Gammoudi";
int age = 3;
double moyenne = 82.5;
char initiale = 'A';
bool estInscrit = true;
Console.WriteLine("Prénom : " + prenom);
Console.WriteLine("Nom : " + nom);
Console.WriteLine("Âge : " + age);
Console.WriteLine("Moyenne : " + moyenne);
Console.WriteLine("Initiale : " + initiale);
Console.WriteLine("Inscrit : " + estInscrit);
```


## Exercice 2 — Saisie et conversion

```csharp
Console.Write("Prénom : ");
string prenom = Console.ReadLine();
Console.Write("Nom : ");
string nom = Console.ReadLine();
Console.Write("Âge : ");
int age = int.Parse(Console.ReadLine());
Console.Write("Moyenne : ");
double moyenne = double.Parse(Console.ReadLine());
Console.WriteLine("--- Informations ---");
Console.WriteLine("Prénom : " + prenom);
Console.WriteLine("Nom : " + nom);
Console.WriteLine("Âge : " + age);
Console.WriteLine("Moyenne : " + moyenne);
```


## Exercice 3 — Concaténation

```csharp
string prenom = "Adam";
string nom = "Gammoudi";
string nomComplet = prenom + " " + nom;
Console.WriteLine("Prénom : " + prenom);
Console.WriteLine("Nom : " + nom);
Console.WriteLine("Nom complet : " + nomComplet);
```


## Exercice 4 — Coût d’un produit

```csharp
string nomProduit = "Clavier";
double prixUnitaire = 15.99;
int quantite = 3;
double sousTotal = prixUnitaire * quantite;
Console.WriteLine("Produit : " + nomProduit);
Console.WriteLine("Prix unitaire : " + prixUnitaire.ToString("F2") + " $");
Console.WriteLine("Quantité : " + quantite);
Console.WriteLine("Sous-total : " + sousTotal.ToString("F2") + " $");
```


## Exercice 5 — Boîtes complètes et reste

```csharp
int nombreProduits = 47;
int nbProduitsParBoites = 6;
int nombreBoites = nombreProduits / nbProduitsParBoites;
int nbProduitsRestants = nombreProduits % nbProduitsParBoites;
Console.WriteLine("Nombre de boîtes complétées : " + nombreBoites);
Console.WriteLine("Nombre de produits restants : " + nbProduitsRestants);
```


## Exercice 6 — Moyenne de deux notes

```csharp
Console.Write("Note 1 : ");
double note1 = double.Parse(Console.ReadLine());
Console.Write("Note 2 : ");
double note2 = double.Parse(Console.ReadLine());
Console.WriteLine("Moyenne : " + (note1 + note2) / 2);
```


## Exercice 7 — Double d’un nombre

```csharp
Console.Write("Prix : ");
double prix = double.Parse(Console.ReadLine());
Console.WriteLine("Double du prix : " + prix * 2);
```


## Exercice 8 — Permutation de deux valeurs

```csharp
Console.Write("Nombre A : ");
int a = int.Parse(Console.ReadLine());
Console.Write("Nombre B : ");
int b = int.Parse(Console.ReadLine());
int temporaire = a;
a = b;
b = temporaire;
Console.WriteLine("Après permutation : A = " + a + ", B = " + b);
```


## Exercice 9 — Fiche animal

```csharp
Console.Write("Nom de l'animal : ");
string nom = Console.ReadLine();
Console.Write("Âge : ");
int age = int.Parse(Console.ReadLine());
Console.Write("Poids (kg) : ");
double poids = double.Parse(Console.ReadLine());
Console.Write("Sexe (F/M) : ");
char sexe = char.Parse(Console.ReadLine());
Console.Write("Vacciné (true/false) : ");
bool vaccine = bool.Parse(Console.ReadLine());
Console.WriteLine("--- Informations de l'animal ---");
Console.WriteLine("Nom : " + nom);
Console.WriteLine("Âge : " + age);
Console.WriteLine("Poids : " + poids + " kg");
Console.WriteLine("Sexe : " + sexe);
Console.WriteLine("Vacciné : " + vaccine);
```


## Exercice 10 — Location de vélo

```csharp
Console.Write("Durée de location (heures) : ");
double duree = double.Parse(Console.ReadLine());
Console.Write("Tarif par heure : ");
double tarif = double.Parse(Console.ReadLine());
Console.WriteLine("Durée : " + duree + " heures");
Console.WriteLine("Tarif horaire : " + tarif.ToString("F2") + " $");
Console.WriteLine("Coût total : " + (duree * tarif).ToString("F2") + " $");
```


## Exercice 11 — Conversion de température

```csharp
Console.Write("Température : ");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine("En Fahrenheit : " + fahrenheit);
```


## Exercice 12 — Taxes et pourboire

```csharp
Console.Write("Prix du repas : ");
double prix = double.Parse(Console.ReadLine());
double taxe = prix * 0.15;
double pourboire = prix * 0.10;
double total = prix + taxe + pourboire;
Console.WriteLine("Taxe de 15 % : " + taxe.ToString("F2") + " $");
Console.WriteLine("Pourboire de 10 % : " + pourboire.ToString("F2") + " $");
Console.WriteLine("Total à payer : " + total.ToString("F2") + " $");
```


## Exercice 13 — Conversion de minutes

```csharp
Console.Write("Minutes : ");
int minutes = int.Parse(Console.ReadLine());
int heures = minutes / 60;
int jours = heures / 24;
Console.WriteLine("Heures : " + heures);
Console.WriteLine("Jours : " + jours);
```

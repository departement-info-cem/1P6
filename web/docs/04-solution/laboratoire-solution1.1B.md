---
title: "✅ Solutions — Laboratoire 1.1B"
---

# ✅ Solutions — Laboratoire 1.1B

[Retour au laboratoire 1.1B](/laboratoire/laboratoire1.1B)

## Questions de compréhension

| Question | Réponse attendue |
| --- | --- |
| 1 | Correct : `Bienvenue!` suivi d’un retour à la ligne. |
| 2 | Correct : `Bonjour` sans retour à la ligne. |
| 3 | Incorrect : les deux messages restent sur la même ligne (`BonjourBienvenue!`). Utiliser `WriteLine` pour le premier. |
| 4 | Incorrect : deux lignes sont produites. Utiliser `Write("Bonjour ")`, puis `WriteLine("Bienvenue!")`. |
| 5 | Correct : le prénom est conservé dans `prenom`. |
| 6 | Correct : le prénom saisi est affiché. |
| 7 | Correct : les espaces et le point d’exclamation sont bien concaténés. |
| 8 | Incorrect : `"prenom"` est un texte fixe. Retirer ses guillemets pour utiliser la variable. |
| 9 | Correct : les valeurs saisies sont concaténées, séparées par un espace. |
| 10 | Il manque `+` après `jeu` : `Console.WriteLine("Vous jouez à " + jeu + " sur " + plateforme + ".");`. |
| 11 | Ajouter la parenthèse fermante avant `;`. |
| 12 | Fermer les guillemets après `Bienvenue!`. |
| 13 | Ajouter le point-virgule. |
| 14 | Écrire `Console` avec une majuscule. |
| 15 | Écrire `WriteLine` avec un `L` majuscule. |
| 16 | Remplacer `prenon` par `prenom`. |
| 17 | Ajouter `+` avant `"!"` : `Console.WriteLine("Bonjour " + prenom + "!");`. La déclaration de `prenom` est déjà fournie. |
| 18 | Ajouter `)` avant `;` dans `Console.Write`. |
| 19 | Ajouter le point-virgule à la deuxième instruction. |
| 20 | Déclarer `prenom`, fermer la parenthèse de `Write` et terminer l’affectation par `;`. |

## Exercices de programmation

Les blocs suivants sont indépendants et se placent dans `Main`.
## Exercice 1 — Carte de visite

```csharp
Console.Write("Quel est ton prénom ? ");
string prenom = Console.ReadLine();
Console.Write("Quelle est ta passion ? ");
string passion = Console.ReadLine();
Console.Write("Quelle est ta couleur préférée ? ");
string couleur = Console.ReadLine();
Console.WriteLine("Bonjour " + prenom + ", ta passion est " + passion + " et ta couleur préférée est le " + couleur + ".");
```


## Exercice 2 — Film préféré

```csharp
Console.Write("Nom du film : ");
string film = Console.ReadLine();
Console.Write("Genre : ");
string genre = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Votre film préféré est " + film + ".");
Console.WriteLine("Le genre du film est " + genre + ".");
```


## Exercice 3 — Destination de voyage

```csharp
Console.Write("Destination : ");
string destination = Console.ReadLine();
Console.Write("Activité préférée : ");
string activite = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Vous allez à " + destination + ".");
Console.WriteLine("Votre activité préférée sera : " + activite + ".");
```


## Exercice 4 — Profil musical

```csharp
Console.Write("Prénom : ");
string prenom = Console.ReadLine();
Console.Write("Artiste préféré : ");
string artiste = Console.ReadLine();
Console.Write("Genre musical : ");
string genre = Console.ReadLine();
Console.Write("Chanson préférée : ");
string chanson = Console.ReadLine();
Console.WriteLine();
Console.WriteLine(prenom + " aime la musique " + genre + ".");
Console.WriteLine("Son artiste préféré est " + artiste + " et sa chanson préférée est " + chanson + ".");
```


## Exercice 5 — Billet de cinéma

```csharp
Console.Write("Prénom : ");
string prenom = Console.ReadLine();
Console.Write("Film : ");
string film = Console.ReadLine();
Console.Write("Heure : ");
string heure = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("----------------------------");
Console.WriteLine("       BILLET DE CINÉMA");
Console.WriteLine("----------------------------");
Console.WriteLine(prenom);
Console.WriteLine("Film : " + film);
Console.WriteLine("Séance : " + heure);
Console.WriteLine("----------------------------");
```


## Exercice 6 — Fiche d’un animal

```csharp
Console.Write("Nom de l'animal : ");
string nom = Console.ReadLine();
Console.Write("Type : ");
string type = Console.ReadLine();
Console.Write("Âge : ");
string age = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("----------------------------");
Console.WriteLine("       FICHE DE L'ANIMAL");
Console.WriteLine("----------------------------");
Console.WriteLine("Nom : " + nom);
Console.WriteLine("Type : " + type);
Console.WriteLine("Âge : " + age + " ans");
Console.WriteLine("----------------------------");
```

---
title: "✅ Solutions — Laboratoire 10.1"
---

# ✅ Solutions — Laboratoire 10.1

[Retour au laboratoire 10.1](/laboratoire/laboratoire10.1)

Ajoutez `using System.IO;` en haut du fichier pour utiliser `StreamReader`, `StreamWriter` et `File`. Créez le dossier `C:\EspaceLabo` avant les exercices.

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

---

## 🔵 Exercice 1 — Ciao Bye ✈️

```csharp

StreamWriter outputFile = new StreamWriter("C:\\EspaceLabo\\CiaoBye.txt");
outputFile.WriteLine("Destination de rêve : Chili");
outputFile.WriteLine("Moyen de transport : Voilier");
outputFile.WriteLine("Durée du voyage : 3 mois");
outputFile.WriteLine("Compagnon de voyage : Mr. Léo");
outputFile.WriteLine("Objet fétiche : ma caméra !");
outputFile.Close();
```

---

## 🔵 Exercice 2 — Retranscrire un tableau 1D

```csharp

string[] series = { "Game of Thrones", "Empathie", "Severance", "True Detective", "Avant le crash" };

StreamWriter outputFile = new StreamWriter("C:\\EspaceLabo\\SeriesFavories.txt");

for (int i = 0; i < series.Length; i++)
{
    outputFile.WriteLine(series[i]);
}

outputFile.Close();
```

---

## 🟣 Exercice 3 — MiniMoi 👶

Le nombre demandé reste un `int`; le compteur `long`, entier de plus grande capacité, peut dépasser `int.MaxValue` après le dernier tour pour terminer le parcours inclusif.

```csharp
string nomEnfant;

Console.Write("Combien d'enfants souhaitez-vous avoir ? ");
int nbEnfants = int.Parse(Console.ReadLine());

Console.Write("Entrez un nom de fichier (avec l'extension .txt) : ");
string nomFichier = Console.ReadLine();

StreamWriter fichierSortie = new StreamWriter("C:\\EspaceLabo\\" + nomFichier);

for (long i = 1; i <= nbEnfants; i++)
{
    Console.Write("Entrez le nom de l'enfant {0} : ", i);
    nomEnfant = Console.ReadLine();
    fichierSortie.WriteLine(nomEnfant);
}

fichierSortie.Close();
Console.WriteLine("Les noms ont été écrits avec succès.");
```

---

## 🟣 Exercice 4 — L’ajout surprise 🎁

```csharp
Console.Write("Entrez un nom de fichier (avec l'extension .txt) : ");
string nomFichier = Console.ReadLine();

StreamWriter fichierExistant = new StreamWriter($"C:\\EspaceLabo\\{nomFichier}", true);
string nomEnfant;
for (int i = 1; i <= 2; i++)
{
    Console.Write("Entrez le nom de l'enfant {0} : ", i);
    nomEnfant = Console.ReadLine();
    fichierExistant.WriteLine(nomEnfant);
}

fichierExistant.Close();
Console.WriteLine("Les noms ont été ajoutés avec succès.");
```

---

## 🟣 Exercice 5 — Les dés sont jetés 🎲

Le nombre de lancers reste un `int` strictement positif. Le compteur inclusif et le cumul sont des `long` : la somme maximale `10 × nombre de lancers` tient dans ce type entier de plus grande capacité. La moyenne reste un `double`.

```csharp

Console.Write("Combien de lancers souhaitez-vous effectuer ? ");
int nbLancers = int.Parse(Console.ReadLine());
if (nbLancers <= 0)
{
    Console.WriteLine("Le nombre de lancers doit être strictement positif.");
    return;
}
StreamWriter outputFile = new StreamWriter("C:\\EspaceLabo\\JeuDeDé.txt");

Random rnd = new Random();
int valeur;
long somme = 0;

for (long i = 1; i <= nbLancers; i++)
{
    valeur = rnd.Next(1, 11);
    outputFile.WriteLine($"Valeur du lancer {i} : {valeur}");
    somme += valeur;
}

double moyenne = somme / (double)nbLancers;
outputFile.WriteLine("Moyenne des lancers : " + moyenne.ToString("F2"));

outputFile.Close();
Console.WriteLine("Les lancers ont été effectués avec succès, il est maintenant temps d'aller voir le fichier texte !");
```

---

## 🟣 Exercice 6 — Journal des ventes

Le nombre de ventes reste un `int`, et le compteur inclusif est un `long` pour que son dernier incrément reste représentable. Le calcul d'une vente conserve un prix et un résultat `double`, ainsi qu'une quantité `int`.

```csharp

Console.Write("Nom du fichier journal (ex: journal_ventes.txt) : ");
string nomFichier = Console.ReadLine();

string cheminJournal = "C:\\EspaceLabo\\" + nomFichier;
bool ajouterSautDeLigne = false;
if (File.Exists(cheminJournal))
{
    string contenu = File.ReadAllText(cheminJournal);
    ajouterSautDeLigne = contenu.Length > 0 &&
        !contenu.EndsWith("\r") && !contenu.EndsWith("\n");
}
StreamWriter fichier = new StreamWriter(cheminJournal, true);
if (ajouterSautDeLigne) fichier.WriteLine(); // Séparer la première vente du texte existant.

bool nouvellesVentes;

do
{

    Console.Write("Combien de ventes souhaitez-vous enregistrer ? ");
    int nbVentes = int.Parse(Console.ReadLine());

    for (long i = 1; i <= nbVentes; i++)
    {
        Console.WriteLine($"\n--- Vente {i} ---");
        Console.Write("Nom du produit : ");
        string produit = Console.ReadLine();

        Console.Write("Prix unitaire : ");
        double prix = double.Parse(Console.ReadLine());

        Console.Write("Quantité : ");
        int quantite = int.Parse(Console.ReadLine());

        double total = prix * quantite;

        fichier.WriteLine($"{produit} : {quantite} × {prix:F2}$ = {total:F2}$");
    }

    fichier.WriteLine("-------------------------------------");

    Console.WriteLine($"\nToutes les ventes ont été enregistrées dans le fichier {nomFichier} !");

    

    Console.Write("Souhaitez-vous enregistrer de nouvelles ventes (oui/non) ? ");
    nouvellesVentes = Console.ReadLine() == "oui";


} while (nouvellesVentes);

fichier.Close();


```

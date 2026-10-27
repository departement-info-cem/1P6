---
title: "✅ Solutions — Laboratoire 11.1"
---

# ✅ Solutions — Laboratoire 11.1

[Retour au laboratoire 11.1](/laboratoire/laboratoire11.1)

Ajoutez `using System.IO;` en haut du fichier pour utiliser `StreamReader`, `StreamWriter` et `File`. Créez le dossier `C:\EspaceLabo` avant les exercices.

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

---

## 🔵 Exercice 1 : Créer un fichier CSV simple

```csharp
        string path = "C:/EspaceLabo/fruits.csv";

        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("Fruit,Couleur"); // En-tête
            writer.WriteLine("Pomme,Rouge");
            writer.WriteLine("Banane,Jaune");
            writer.WriteLine("Orange,Orange");
            writer.WriteLine("Raisin,Violet");
            writer.WriteLine("Citron,Jaune");
        }

        Console.WriteLine("Fichier créé avec succès !");
```

---

## 🔵 Exercice 2 : Lire et afficher le contenu d'un fichier CSV
```csharp
        string path = "C:/EspaceLabo/fruits.csv";

        if (!File.Exists(path))
        {
            Console.WriteLine("Le fichier n'existe pas !");
            return;
        }

        using (StreamReader reader = new StreamReader(path))
        {
            // Lire l'en-tête
            string ligne = reader.ReadLine();

            // Lire le reste du fichier
            while (!reader.EndOfStream)
            {
                ligne = reader.ReadLine();
                string[] valeurs = ligne.Split(',');
                Console.WriteLine(valeurs[0] + " est de couleur " + valeurs[1].ToLower() + ".");
            }
        }
```
---

## 🟣 Exercice 3 : Calculer la moyenne d’un groupe d’étudiants
```csharp
        // --- Étape 1 : Créer le fichier notes.csv ---
        using (StreamWriter sw = new StreamWriter("C:/EspaceLabo/notes.csv"))
        {
            sw.WriteLine("Nom,Note");
            sw.WriteLine("Éric,87");
            sw.WriteLine("Jamil,92");
            sw.WriteLine("David,76");
            sw.WriteLine("Tommy,95");
            sw.WriteLine("Pierre-Paul,84");
            sw.WriteLine("Jean-Michel,59");
            sw.WriteLine("Philippe,100");
        }

        // --- Étape 2 : Lire et calculer la moyenne ---
        string chemin = "C:/EspaceLabo/notes.csv";
        double somme = 0;
        int compteur = 0;

        using (StreamReader sr = new StreamReader(chemin))
        {
            // Lire l'en-tête
            string ligne = sr.ReadLine();

            // Lire le reste
            while (!sr.EndOfStream)
            {
                ligne = sr.ReadLine();
                string[] valeurs = ligne.Split(',');
                double note = double.Parse(valeurs[1]);
                somme += note;
                compteur++;
            }
        }

        double moyenne = somme / compteur;
        Console.WriteLine("La moyenne du groupe est de " + moyenne.ToString("F2") + " %");
```
---


## 🟣 Exercice 4 : Inverser les colonnes d'un CSV
```csharp

        string cheminSource = "C:/EspaceLabo/fruits.csv";
        string cheminDest = "C:/EspaceLabo/fruits_inverse.csv";

        if (!File.Exists(cheminSource))
        {
            Console.WriteLine("Fichier source introuvable !");
            return;
        }

        using (StreamReader sr = new StreamReader(cheminSource))
        using (StreamWriter sw = new StreamWriter(cheminDest))
        {
            // Lire l'en-tête
            string ligne = sr.ReadLine();
            string[] entetes = ligne.Split(',');
            sw.WriteLine(entetes[1] + "," + entetes[0]); // inverser

            // Lire et écrire les lignes inversées
            while (!sr.EndOfStream)
            {
                ligne = sr.ReadLine();
                string[] valeurs = ligne.Split(',');
                sw.WriteLine(valeurs[1] + "," + valeurs[0]);
            }
        }

        Console.WriteLine("Fichier fruits_inverse.csv créé !");


```


---

## 🟣 Exercice 5 : Construire une grille dynamique à partir d’un CSV

```csharp
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string chemin = "C:/EspaceLabo/donjon.csv";
        using (StreamWriter ecrivain = new StreamWriter(chemin))
        {
            ecrivain.WriteLine("🗿,💀,💎");
            ecrivain.WriteLine("👹,🧙‍,🗝");
            ecrivain.WriteLine("🚪,🧟,👺");
        }
        List<string> lignes = new List<string>();
        using (StreamReader lecteur = new StreamReader(chemin))
        {
            while (!lecteur.EndOfStream) lignes.Add(lecteur.ReadLine());
        }
        if (lignes.Count == 0)
        {
            Console.WriteLine("Le fichier est vide.");
            return;
        }
        int nbLignes = lignes.Count;
        int nbColonnes = lignes[0].Split(',').Length;
        string[,] grille = new string[nbLignes, nbColonnes];
        for (int i = 0; i < nbLignes; i++)
        {
            string[] cases = lignes[i].Split(',');
            if (cases.Length != nbColonnes)
            {
                Console.WriteLine("Les rangées doivent avoir le même nombre de colonnes.");
                return;
            }
            for (int j = 0; j < nbColonnes; j++) grille[i, j] = cases[j];
        }
        for (int i = 0; i < nbLignes; i++)
        {
            for (int j = 0; j < nbColonnes; j++)
                Console.Write(grille[i, j] + " ");
            Console.WriteLine();
        }
    }
}
```

La taille est lue depuis le fichier; elle ne dépend pas de la grille d'exemple. Une rangée correspond à une ligne et une colonne à un élément séparé par une virgule.

---

## 🟣 Exercice 6 :Sauvegarder et relire une matrice numérique
```csharp
        int[,] matrice = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        string chemin = "C:/EspaceLabo/matrice.csv";

        // --- Écrire la matrice dans le fichier ---
        using (StreamWriter sw = new StreamWriter(chemin))
        {
            int lignes = matrice.GetLength(0);
            int colonnes = matrice.GetLength(1);

            for (int i = 0; i < lignes; i++)
            {
                string ligne = "";
                for (int j = 0; j < colonnes; j++)
                {
                    ligne += matrice[i, j];
                    if (j != colonnes - 1)
                        ligne += ",";
                }
                sw.WriteLine(ligne);
            }
        }


        // Relire les lignesLues puis recréer une matrice d'entiers.
        List<string> lignesLues = new List<string>();
        using (StreamReader sr = new StreamReader(chemin))
        {
            while (!sr.EndOfStream) lignesLues.Add(sr.ReadLine());
        }
        int[,] matriceLue = new int[lignesLues.Count, lignesLues[0].Split(',').Length];
        for (int i = 0; i < matriceLue.GetLength(0); i++)
        {
            string[] valeurs = lignesLues[i].Split(',');
            for (int j = 0; j < matriceLue.GetLength(1); j++)
            {
                matriceLue[i, j] = int.Parse(valeurs[j]);
                Console.Write(matriceLue[i, j] + " ");
            }
            Console.WriteLine();
        }
```

---

## 🔥 Jeux intégrateurs - AVEC LISTE

### 💀 Bonhomme pendu (avec fichier .txt)

```csharp
using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // --- Étape 1 :Assurez-vous d'avoir créé le fichier mots.txt dans le bon répertoire ---

        
        // --- Étape 2 : Lire tous les mots depuis le fichier mots.txt ---
        string chemin = "C:/EspaceLabo/mots.txt";

        if (!File.Exists(chemin))
        {
            Console.WriteLine("Fichier mots.txt introuvable !");
            return;
        }

        List<string> listeMots = new List<string>();
        using (StreamReader sr = new StreamReader(chemin))
        {
            while (!sr.EndOfStream)
            {
                string mot = sr.ReadLine();
                if (mot != "") listeMots.Add(mot.ToUpper());
            }
        }


        if (listeMots.Count == 0)
        {
            Console.WriteLine("Le fichier ne contient aucun mot.");
            return;
        }
        // --- Étape 3 : Choisir un mot au hasard ---
        Random rnd = new Random();
        int index = rnd.Next(0, listeMots.Count);
        string motChoisi = listeMots[index];

        // --- Étape 4 : Créer le mot masqué ---
        char[] motCache = new char[motChoisi.Length];
        for (int i = 0; i < motChoisi.Length; i++)
            motCache[i] = '_';

        // --- Étape 5 : Initialiser les variables de jeu ---
        int tentativesRestantes = 6;
        bool gagne = false;

        // --- Étape 6 : Boucle de jeu ---
        while (tentativesRestantes > 0 && !gagne)
        {
            // Afficher le mot masqué
            Console.Write("Mot : ");
            for (int i = 0; i < motCache.Length; i++)
                Console.Write(motCache[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Tentatives restantes : " + tentativesRestantes);

            // Demander une lettre
            Console.Write("Lettre : ");
            string input = Console.ReadLine().ToUpper();

            if (input.Length != 1)
            {
                Console.WriteLine("Saisissez une seule lettre.");
                continue;
            }
            char lettre = input[0];

            // Vérifier si la lettre est dans le mot
            bool lettreTrouvee = false;
            for (int i = 0; i < motChoisi.Length; i++)
            {
                if (motChoisi[i] == lettre)
                {
                    motCache[i] = lettre;
                    lettreTrouvee = true;
                }
            }

            if (lettreTrouvee)
                Console.WriteLine("✅ Bonne lettre !");
            else
            {
                Console.WriteLine("❌ Mauvaise lettre !");
                tentativesRestantes--;
            }

            // Vérifier si le joueur a gagné
            gagne = true;
            for (int i = 0; i < motCache.Length; i++)
            {
                if (motCache[i] == '_')
                {
                    gagne = false;
                    break;
                }
            }
        }

        // --- Étape 7 : Fin du jeu ---
        if (gagne)
            Console.WriteLine("🎉 Bravo, vous avez trouvé : " + motChoisi);
        else
            Console.WriteLine("💀 Vous avez perdu ! Le mot était : " + motChoisi);
    }
}

```

---

### Bataille navale (avec fichier CSV) ⚓

**Partie A**

Ajoutez aussi `using System;` et `using System.Collections.Generic;` en haut du fichier.

```csharp
using System.IO;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string chemin = "C:/EspaceLabo/grille.csv";

        if (!File.Exists(chemin))
        {
            Console.WriteLine("Fichier introuvable !");
            return;
        }

        // Lire les lignes dans une liste
        List<string> lignes = new List<string>();
        using (StreamReader sr = new StreamReader(chemin))
        {
            while (!sr.EndOfStream)
            {
                string ligne = sr.ReadLine();
                if (!string.IsNullOrWhiteSpace(ligne)) lignes.Add(ligne);
            }
        }

        if (lignes.Count == 0)
        {
            Console.WriteLine("Le fichier est vide.");
            return;
        }

        // Créer un tableau 2D selon la taille du fichier
        int nbLignes = lignes.Count;
        int nbColonnes = lignes[0].Split(',').Length;
        string[,] grille = new string[nbLignes, nbColonnes];

        // Remplir le tableau et Afficher la grille
        for (int i = 0; i < nbLignes; i++)
        {
            string[] cases = lignes[i].Split(',');
            for (int j = 0; j < nbColonnes; j++)
            {
                grille[i, j] = cases[j];
                Console.Write(grille[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

```

**Partie B — Programme complet, à utiliser à la place de la partie A**

```csharp
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string chemin = "C:/EspaceLabo/grille.csv";
        if (!File.Exists(chemin))
        {
            Console.WriteLine("Fichier introuvable !");
            return;
        }
        List<string> lignes = new List<string>();
        using (StreamReader lecteur = new StreamReader(chemin))
        {
            while (!lecteur.EndOfStream)
            {
                string ligne = lecteur.ReadLine();
                if (!string.IsNullOrWhiteSpace(ligne)) lignes.Add(ligne);
            }
        }
        if (lignes.Count == 0)
        {
            Console.WriteLine("Le fichier est vide.");
            return;
        }
        int nbLignes = lignes.Count;
        int nbColonnes = lignes[0].Split(',').Length;
        string[,] grille = new string[nbLignes, nbColonnes];
        for (int i = 0; i < nbLignes; i++)
        {
            string[] cases = lignes[i].Split(',');
            if (cases.Length != nbColonnes)
            {
                Console.WriteLine("Les rangées doivent avoir le même nombre de colonnes.");
                return;
            }
            for (int j = 0; j < nbColonnes; j++) grille[i, j] = cases[j];
        }

        // --- Boucle de jeu ---
        bool fini = false;
        while (!fini)
        {
            // Demander les coordonnées
            Console.Write("Entrez la ligne : ");
            string inputL = Console.ReadLine();
            int numeroLigne;
            Console.Write("Entrez la colonne : ");
            string inputC = Console.ReadLine();
            int numeroColonne;
            if (!int.TryParse(inputL, out numeroLigne) ||
                !int.TryParse(inputC, out numeroColonne))
            {
                Console.WriteLine("Coordonnées invalides ! Réessayez.");
                continue;
            }
            int ligne = numeroLigne - 1;
            int colonne = numeroColonne - 1;

             if (ligne < 0 || ligne >= nbLignes || colonne < 0 || colonne >= nbColonnes)
            {
                Console.WriteLine("Coordonnées invalides ! Réessayez.");
                continue;
            }

            // Vérifier le contenu de la case
            if (grille[ligne, colonne] == "🚢")
            {
                grille[ligne, colonne] = "💥";
                Console.WriteLine("💥 Touché !");
            }
            else if (grille[ligne, colonne] == "🌊")
            {
                grille[ligne, colonne] = "💦";
                Console.WriteLine("💦 Raté !");
            }
            else
            {
                Console.WriteLine("Déjà visé !");
            }

            // Afficher la grille mise à jour
            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0; j < nbColonnes; j++)
                {
                    Console.Write(grille[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Vérifier si tous les bateaux sont coulés
            int compteBateaux = 0;
            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0; j < nbColonnes; j++)
                {
                    if (grille[i, j] == "🚢")
                    {
                        compteBateaux++;
                    }
                }
            }

            if (compteBateaux == 0)
            {
                fini = true;
                Console.WriteLine("🎉 Tous les bateaux sont coulés !");
            }
        }
    }
}
```

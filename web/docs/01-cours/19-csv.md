---
description: Lecture et écriture de fichiers CSV
---

# 11.1 — Lecture et écriture de fichiers CSV

## 🎯 Objectif

Apprendre à **lire et écrire des fichiers CSV** (`Comma-Separated Values`) à l’aide des classes `StreamReader` et `StreamWriter`.  Nous verrons également comment lire et stocker une grille de **taille inconnue** en introduisant le concept de liste (`List<T>`).

---

## 💡 Qu’est-ce qu’un fichier CSV ? Pourquoi est-ce utile ?

Un fichier CSV est un type de fichier texte utilisé pour stocker des données *tabulaires* - **données structurées en rangées et colonnes**. Chaque ligne d’un fichier CSV représente une rangée, et les valeurs à l’intérieur d’une rangée sont séparées par des virgules (`,`).

Le format CSV est largement utilisé pour l’import et l’export de données entre différentes applications logicielles. Les fichiers CSV peuvent être ouverts et modifiés aussi bien avec *Excel* qu’à l’aide d’un simple éditeur de texte, ce qui les rend accessibles à tous.

Exemple de contenu d'un fichier `etudiants.csv` :
```
Nom,Prenom,Note
Bond,James,100
Potter,Harry,87
Jones,Indiana,59
Snow,Jon,81
```

⚠️ Ici :
- la **première ligne** contient les **en-têtes de colonnes** ;
- les **lignes suivantes** contiennent les **valeurs** de chaque enregistrement.

---

## 🧰 Préparer l’environnement

Ajoutez la bibliothèque `System.IO` :
```csharp
using System.IO;
```

---

## ✍️ Écrire un fichier CSV avec `StreamWriter`

La méthode est identique à celle utilisée pour un fichier texte ordinaire, sauf qu’on sépare les valeurs par **`,`**.

```csharp
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("C:/EspaceLabo/etudiants.csv"))
        {
            writer.WriteLine("Nom,Prenom,Note"); // En-têtes
            writer.WriteLine("Bond,James,100");
            writer.WriteLine("Potter,Harry,87");
            writer.WriteLine("Jones,Indiana,59");
            writer.WriteLine("Snow,Jon,81");
        }

        Console.WriteLine("Fichier CSV créé avec succès !");
    }
}
```

🧾 **Résultat dans `etudiants.csv` :**
```
Nom,Prenom,Note
Bond,James,100
Potter,Harry,87
Jones,Indiana,59
Snow,Jon,81
```

---

## 📖 Lire un fichier CSV avec `StreamReader`

Pour lire un CSV, on lit **chaque ligne** du fichier, puis on **sépare les valeurs** à l’aide de la méthode `.Split(',')`.

```csharp
using System.IO;

class Program
{
    static void Main()
    {
        string path = "C:/EspaceLabo/etudiants.csv";

        // On vérifie si le fichier existe !
        if (!File.Exists(path)) 
        {
            Console.WriteLine("Fichier introuvable !");
            return;
        }

        // Ouvrir le fichier : 'using()' s'assure de fermer le fichier une fois la lecture terminée
        using (StreamReader reader = new StreamReader(path))
        {
            string ligne;

            // Lire l’en-tête (première ligne)
            string entete = reader.ReadLine();
            Console.WriteLine($"En-têtes : {entete}");

            // Lire le reste du fichier
            while (!reader.EndOfStream)
            {
                // Lire une ligne complète du fichier CSV
                ligne = reader.ReadLine();
                
                // Séparer la ligne en plusieurs éléments, en utilisant la virgule comme séparateur
                string[] valeurs = ligne.Split(','); 

                Console.WriteLine($"{valeurs[1]} {valeurs[0]} à {valeurs[2]}%");
            }
        }
    }
}
```

✅ **Sortie console :**
```
En-têtes : Nom,Prenom,Note
James Bond à 100%
Harry Potter à 87%
Indiana Jones à 59%
Jon Snow à 81%
```

---

## 🧮 Lire une grille et la stocker dans une liste

Dans le TP3, vous serez amenés à télécharger *un donjon* de taille inconnue à partir d'un fichier CSV.

Le donjon est représenté par une **grille**, où chaque case peut contenir un objet, un personnage ou un obstacle. 
Chaque **ligne du fichier** correspond à une **rangée** de la grille,
et chaque valeur séparée par une **virgule** correspond à une **case**.

📄 Exemple de fichier ``donjon.csv`` :

```
🗿,💀,💎
👹,🧙‍,🗝
🚪,🧟,👺
```

---

### ⚠️ Problématique : les tableaux ont une taille fixe

Jusqu’à maintenant, nous avons utilisé des **tableaux 1D ou 2D** (`string[]`, `string[,]`) pour stocker des données.
Mais ces structures ont une contrainte importante : 
>> Il faut connaître le nombre de lignes et de colonnes **avant** de les créer.
Une fois leur taille fixée, les tableaux ne peuvent **ni grandir ni rapetisser**.

Cela devient un problème lorsqu’on lit un fichier CSV **dont la taille est inconnue.**

👉 **Solution** : utiliser une liste (`List<T>`), une structure de données dynamique qui s'ajuste automatiquement à la quantité de données lue.

---

### 🧰 Les listes (`List<T>`)

Une **liste** est une structure de données **dynamique** :  
**Aucune taille n’a besoin d’être définie à la création, et on peut ajouter ou retirer des éléments librement.**

On peut la voir comme une version “flexible” d’un tableau.

| Type | Taille | Exemple de création |
|:--|:--|:--|
| `string[]` | Fixe | `string[] grille = new string[5];` |
| `List<string>` | Dynamique | `List<string> grille = new List<string>();` |

---

### 🧩 Deux éléments essentiels à connaître

| Élément | Type | Description | Exemple |
|:--|:--|:--|:--|
| `Add()` | Méthode | Ajoute un élément à la fin de la liste. | `grille.Add("🧙");` |
| `Count` | Propriété | Donne le **nombre d’éléments** actuellement contenus dans la liste. | `Console.WriteLine(grille.Count);` |

💡 La classe `List<T>` possède **plusieurs autres méthodes et propriétés utiles** (comme `Remove`, `Insert`, `Clear`, etc.).  
Pour en savoir plus, consultez la section *Ressources supplémentaires* au bas de cette page.

---

### 🧩 Démonstration : lire un fichier CSV contenant une grille de taille inconnue

Voici un exemple complet pour lire un fichier CSV représentant une grille de taille inconnue,
puis stocker le tout dans un tableau 2D.

```csharp
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {

        // Permet d'afficher correctement les icônes, symboles et émojis
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string cheminFichier = "C:/EspaceLabo/donjon.csv";

        // Liste temporaire pour stocker chaque ligne lue
        List<string> lignesTemp = new List<string>();

        // Vérifier que le fichier existe
        if (!File.Exists(cheminFichier))
        {
            Console.WriteLine("Le fichier n'existe pas !");
            return;
        }

        // Lire le fichier CSV
        using (StreamReader sr = new StreamReader(cheminFichier))
        {
            string ligne;
            while (!sr.EndOfStream)
            {
                ligne = sr.ReadLine();
                lignesTemp.Add(ligne); // Ajouter chaque ligne à la liste
            }
        }

        // Déterminer les dimensions du donjon
        int nbLignes = lignesTemp.Count;
        int nbColonnes = lignesTemp[0].Split(',').Length; // Nombre de colonnes à partir de la première ligne

        // Créer le tableau 2D
        string[,] donjon = new string[nbLignes, nbColonnes];

        // Remplir le tableau à partir de la liste et afficher le donjon
        for (int i = 0; i < nbLignes; i++)
        {
            string[] cases = lignesTemp[i].Split(',');
            for (int j = 0; j < nbColonnes; j++)
            {
                donjon[i, j] = cases[j];
                Console.Write(donjon[i, j] + " ");
            }
             Console.WriteLine();
        }
    }
}

```

✅ **Sortie console :**
```
🗿,💀,💎
👹,🧙‍,🗝
🚪,🧟,👺
```

---
## 🧭 À retenir

| Action | C# | Description |
|:--|:--|:--|
| Séparer les valeurs | `string.Split(',')` | retourne un tableau de chaînes |
| Stocker des données flexibles | `List<T>` | structure dynamique, extensible |

---

## 📚 Ressources supplémentaires

👉 Notions C# : [Liste générique](https://info.cegepmontpetit.ca/notions-csharp/documentation/liste-generique-list-t)


Vous devez réaliser le labo suivant :
 [🧪 Labo 10.1](/laboratoire/laboratoire10.1)

---

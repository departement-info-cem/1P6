---
title: "✅ Solutions — Laboratoire 10.2"
---

# ✅ Solutions — Laboratoire 10.2

[Retour au laboratoire 10.2](/laboratoire/laboratoire10.2)

Ajoutez `using System.IO;` en haut du fichier pour utiliser `StreamReader`, `StreamWriter` et `File`. Créez le dossier `C:\EspaceLabo` avant les exercices.

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

---

## 🔵 Exercice 1 : Découvrir StreamReader

```csharp
        using (StreamReader sr = new StreamReader("C:\\EspaceLabo\\sortileges.txt"))
        {
            while (!sr.EndOfStream)
            {
                string ligne = sr.ReadLine();
                Console.WriteLine(ligne);
            }
        }
```

---

## 🔵 Exercice 2 : ReadLine vs ReadToEnd
```csharp
        Console.WriteLine("--- Lecture avec ReadLine() ---");
        using (StreamReader sr = new StreamReader("C:\\EspaceLabo\\citations.txt"))
        {
            if (!sr.EndOfStream) // Simple mesure de vérification
            {
                string premiereLigne = sr.ReadLine();
                Console.WriteLine(premiereLigne);
            }
        }

        Console.WriteLine("\n--- Lecture avec ReadToEnd() ---");
        using (StreamReader sr2 = new StreamReader("C:\\EspaceLabo\\citations.txt"))
        {
            string toutLeTexte = sr2.ReadToEnd();
            Console.WriteLine(toutLeTexte);
        }
```
---

## 🔵 Exercice 3 : Découper le contenu lu avec ReadToEnd()
```csharp
        string toutLeTexte;

        using (StreamReader sr = new StreamReader("C:\\EspaceLabo\\citations.txt"))
        {
            toutLeTexte = sr.ReadToEnd();

        }

        string[] tabCitations = toutLeTexte.Replace("\r\n", "\n")
            .Split('\n', StringSplitOptions.RemoveEmptyEntries);

        if (tabCitations.Length == 0)
        {
            Console.WriteLine("Le fichier ne contient aucune citation.");
        }
        else
        {
            Console.WriteLine(tabCitations[tabCitations.Length - 1]);
        }
```
---


## 🟣 Exercice 4 : Créer et relire un fichier ✍️📖
```csharp

        string[] objectifs = new string[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Entrez votre objectif {i + 1} : ");
            objectifs[i] = Console.ReadLine();
        }

        using (StreamWriter sw = new StreamWriter("C:\\EspaceLabo\\objectifs.txt"))
        {
            for (int i = 0; i < objectifs.Length; i++)
            {
                sw.WriteLine(objectifs[i]);
            }
        }

        Console.WriteLine("Les objectifs ont été enregistrés !\n");

        Console.WriteLine("Mes objectifs sont :");
        using (StreamReader sr = new StreamReader("C:\\EspaceLabo\\objectifs.txt"))
        {
            while (!sr.EndOfStream)
            {
                string ligne = sr.ReadLine();
                Console.WriteLine(ligne);
            }
        }


```


---

## 🟣 Exercice 5 : Ajouter et relire du contenu existant 🧾
```csharp
if (File.Exists(@"C:\EspaceLabo\objectifs.txt"))
{
    using (StreamWriter sw = new StreamWriter(@"C:\EspaceLabo\objectifs.txt", true))
    {
        sw.WriteLine("Lire 5 livres cette année.");
        sw.WriteLine("Économiser pour un voyage.");
    }
    Console.WriteLine("Contenu complet du fichier :");
    using (StreamReader sr = new StreamReader(@"C:\EspaceLabo\objectifs.txt"))
    {
        while (!sr.EndOfStream)
        {
            Console.WriteLine(sr.ReadLine());
        }
    }
}
else
{
    Console.WriteLine("Le fichier objectifs.txt n'existe pas.");
}
```

---

## 🟣 Exercice 6 : Sauvegarder et relire un tableau 1D 🎵
```csharp
        string[] repas = { "Pizza hawaïenne", "Pizza toute garnie", "Pizzaghetti", "Pizza Meat Lover", "Pizza aux artichauts et aux olives noires" };
        using (StreamWriter sw = new StreamWriter("C:\\EspaceLabo\\mes_repas_prefs.txt"))
        {
            for (int i = 0; i < repas.Length; i++)
            {
                sw.WriteLine(repas[i]);
            }
        }

        Console.WriteLine("Voici vos repas préférés :");
        using (StreamReader sr = new StreamReader("C:\\EspaceLabo\\mes_repas_prefs.txt"))
        {
            while (!sr.EndOfStream)
            {
                string ligne = sr.ReadLine();
                Console.WriteLine(ligne);
            }
        }
```
---

## 🟣 Exercice 7 : Manipuler une matrice 2D 🔢 (préparation au laboratoire CSV 11.1)
```csharp
        int[,] matrice = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        using (StreamWriter sw = new StreamWriter("C:\\EspaceLabo\\matrice.txt"))
        {
            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                // Utilisation de Join pour transformer la ligne en chaîne séparée par des espaces
                string ligne = string.Join(" ", matrice[i, 0], matrice[i, 1], matrice[i, 2]);
                sw.WriteLine(ligne);
            }
        }

        Console.WriteLine("Matrice lue depuis le fichier :");
        using (StreamReader sr = new StreamReader("C:\\EspaceLabo\\matrice.txt"))
        {
            while (!sr.EndOfStream)
            {
                string ligne = sr.ReadLine();
                string[] nombres = ligne.Split(" ");
                for (int i = 0;i < nombres.Length; i++)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
        }
```

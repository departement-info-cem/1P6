---
title: B - Portée des variables
---

# 🧪 Labo 3.1B – Portée des variables

### 🎯 Objectif

Comprendre la différence entre :

* Variable **de classe** (portée globale)
* Variable **locale à une fonction**
* Variable **locale à un bloc** (ex. : dans un `if`)

---

### 📝 Étapes

1. Créez un nouveau projet **Console App** nommé `ExercicePortee`.
2. Copiez le code suivant, puis **essayez de le compiler tel quel** :

```csharp
using System;

class Program
{
    static int nombreGlobal = 42;  // portée : classe entière

    static void Main()
    {
        int nombreMain = 10;  // portée : fonction Main

        if (nombreMain > 5)
        {
            int nombreBloc = 5;  // portée : bloc if
            Console.WriteLine("Bloc if : " + nombreBloc);
        }

        Console.WriteLine("Main : " + nombreMain);     // ✅ OK
        Console.WriteLine("Global : " + nombreGlobal); // ✅ OK

        // Console.WriteLine("Bloc : " + nombreBloc);  // ❌ Erreur ici : nombreBloc hors portée
    }

    static void AutreMethode()
    {
        // Console.WriteLine(nombreMain);  // ❌ Erreur ici : nombreMain n'existe pas ici
        Console.WriteLine("Global dans AutreMethode : " + nombreGlobal); // ✅ OK
    }
}
```

---

### 🔍 Questions de réflexion

* Pourquoi ne peut-on pas accéder à `nombreBloc` hors du `if` ?
* Pourquoi `nombreMain` n’est pas accessible depuis `AutreMethode()` ?
* Quelle variable est visible **partout dans la classe** ?
* Qu’est-ce que `{ }` crée dans ce contexte ?

---

### ✅ À faire

1. Corrige les lignes commentées qui causent des erreurs.
2. Ajoute une nouvelle fonction `AfficherGlobalEtLocal()` qui essaie d’accéder aux différentes variables.
3. Dessine un petit schéma ou commente ton code pour indiquer la **portée de chaque variable**.

---

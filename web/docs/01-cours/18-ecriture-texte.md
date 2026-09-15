---
description: Écriture dans un fichier texte avec StreamWriter
---

# 🧾 10.1 — Écriture dans un fichier texte

## 🎯 Objectif

Apprendre à **écrire des données dans un fichier texte (.txt)** à l’aide de la classe `StreamWriter`.  
Nous verrons comment créer un fichier, y écrire du texte, et le fermer correctement pour que les données soient sauvegardées localement.

---

## 💡 Pourquoi écrire dans un fichier ?

Les programmes que vous avez écrits jusqu'à maintenant nécessitent de **ressaisir les données à chaque exécution**.  
Mais pourquoi donc? 🤔

Les **variables et objets** sont stockés dans la **mémoire vive (RAM)**, et celle-ci est **effacée à la fin de l’exécution** du programme.  
Résultat : toutes les données disparaissent à chaque redémarrage. 👻

❓ Alors comment faire pour les garder entre deux exécutions ?  
👉 En les **sauvegardant dans un fichier** sur ton disque 💾 !

Une fois les données écrites dans un fichier :
- elles restent accessibles après la fermeture du programme,
- elles peuvent être relues plus tard (ce sera le sujet de la **prochaine séance 9.2** 👀).

---

## 🪜 Les 4 étapes pour manipuler un fichier

1. **Ajouter la bonne bibliothèque** (`using System.IO;`)
2. **Ouvrir le fichier** — établir la connexion entre ton programme et le fichier.
3. **Lire ou écrire** les données.
4. **Fermer le fichier** quand tu as fini (sinon : 💥 données perdues ou fichier bloqué).

---

## 🧰 Étape 1 — Le package `System.IO`

Avant tout, assurez-vous d'ajouter **cette ligne au début de votre programme :**

```csharp
using System.IO;
```

Le _namespace_ `System.IO` contient toutes les classes utiles pour lire et écrire dans des fichiers (comme `StreamWriter` et `StreamReader`).

---

## ⚡ Étape 2 — Créer une instance de StreamWriter

La classe `StreamWriter` permet d’ouvrir un fichier en mode **Écriture** et de créer un lien entre le programme et ce fichier.

```csharp
StreamWriter outputFile = new StreamWriter("culture_quebecoise_101.txt");
```
➡️ Cela crée un fichier vide nommé `culture_quebecoise_101.txt` dans le répertoire courant (le dossier où ton programme s’exécute).

Si le fichier existe déjà, il sera **écrasé par défaut** ⚠️

### 💡 Astuce : Spécifier un chemin précis

Il est possible d'indiquer l’emplacement exact du fichier :

```csharp
StreamWriter outputFile = new StreamWriter("C:/EspaceLabo/culture_quebecoise_101.txt");
```
Ou
```csharp
StreamWriter outputFile = new StreamWriter("C:\\EspaceLabo\\culture_quebecoise_101.txt");
```

Ainsi, vous avez un meilleur contrôle sur l'emplacement où les fichiers sont sauvegardés. 🗂️

---

## ✍️ Étape 3 — Écrire des données avec Write et WriteLine

Vous connaissez déjà `Console.WriteLine` pour afficher des données dans la console.  
Avec `StreamWriter`, on utilise les mêmes méthodes **pour écrire dans un fichier** :

```csharp
outputFile.WriteLine("Avoir les yeux dans la graisse de bine");
outputFile.WriteLine("Avoir de la broue dans le toupet");
```
➡️ `WriteLine` écrit une ligne et saute à la ligne suivante.

```csharp
outputFile.Write("Attache ta tuque ");
outputFile.Write("avec d’la broche !");
```
➡️ `Write` écrit du texte sans retour à la ligne.

### 🧾 Résultat dans le fichier

```
Avoir les yeux dans la graisse de bine
Avoir de la broue dans le toupet
Attache ta tuque avec d’la broche !
```

---

## 🔒 Étape 4 — Fermer le fichier

Une fois l’écriture terminée, il faut fermer le fichier pour libérer la ressource :

```csharp
outputFile.Close();
```

💡 Si tu oublies de fermer le fichier, certaines données peuvent ne jamais être écrites !

---

## ➕ Ajouter du contenu à un fichier existant (Append)

Par défaut, `StreamWriter` écrase le contenu du fichier.  
Mais parfois, nous voulons simplement **ajouter des informations** à la fin d'un fichier, sans tout effacer.

Pour cela, il faut ajouter un **deuxième argument booléen** au constructeur `StreamWriter` :

```csharp
StreamWriter outputFile = new StreamWriter("culture_quebecoise_101.txt", true);
```
Le `true` indique que tu veux **ajouter** au fichier existant plutôt que de le recréer.
Par défaut, cet argument est à `false`.

---

## 🧩 Exemple complet

```csharp
using System.IO;

class Program
{
    static void Main()
    {

        // Création d'un fichier en mode ÉCRITURE
        StreamWriter outputFile = new StreamWriter("C:/EspaceLabo/culture_quebecoise_101.txt");

        outputFile.WriteLine("Avoir les yeux dans la graisse de bine");
        outputFile.WriteLine("Avoir de la broue dans le toupet");

        outputFile.Write("Attache ta tuque ");
        outputFile.Write("avec d’la broche !");

        outputFile.Close(); // Fermeture du fichier

        // Ouverture d'un fichier existant pour y ajouter du texte
        StreamWriter fichierExistant = new StreamWriter("C:/EspaceLabo/culture_quebecoise_101.txt", true);

        fichierExistant.WriteLine("Se faire passer un sapin");
        fichierExistant.WriteLine("Se tirer une bûche");

        fichierExistant.Close(); // Fermeture du fichier
    }
}
```

### 🧾 Résultat dans `culture_quebecoise_101.txt` :

```
Avoir les yeux dans la graisse de bine
Avoir de la broue dans le toupet
Attache ta tuque avec d’la broche !
Se faire passer un sapin
Se tirer une bûche
```

---

## 🧩 Résumé des étapes

| Étape | Action | Exemple |
|:--:|:--|:--|
| 1️⃣ | Ajouter `using System.IO;` | `using System.IO;` |
| 2️⃣ | Créer un objet `StreamWriter` | `StreamWriter file = new StreamWriter("fichier.txt");` |
| 3️⃣ | Écrire des données | `file.WriteLine("Bonjour !");` |
| 4️⃣ | Fermer le fichier | `file.Close();` |

---

## 🧭 À retenir
  
🔹 Toujours fermer le fichier avec `.Close()`.  
🔹 Ajouter `true` pour écrire à la fin d’un fichier existant.

---

## 📚 Ressources supplémentaires

👉 Notions C# : [Fichiers texte — StreamWriter](https://info.cegepmontpetit.ca/notions-csharp/documentation/fichier-texte#la-classe-streamwriter--%C3%A9criture-dans-un-fichier-texte)


Vous devez réaliser le labo suivant :
 [🧪 Labo 9.1](/laboratoire/laboratoire9.1)
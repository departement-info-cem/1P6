---
title: 🔴 Wizard
---

# 🧪 Labo 6.1C – 🔴 Wizard
---

## 🎯 Objectifs 

- Créer une application Windows Forms.
- Ajouter et positionner des contrôles.
- Ajouter un événement à un contrôle.
- Extraire du texte d'une boîte de texte.
- Retourner un calcul dans une boîte de texte.

---

## 🛠️ Instructions
Dans cet exercice, vous devez créer une application Windows Forms en c#. Les fenêtres sont déjà créées, mais vous aurez à les afficher et les cacher au bon moment.

Voici les fenêtres et l'ordre dans lesquels elles doivent apparaître:
1. La fenêtre du mot de passe (**`FormMotDePasse`**)
    - Elle doit permettre d'identifier un utilisateur par son nom et son mot de passe.
    - Utiliser les constantes **`UTILISATEUR`** et **`MOT_DE_PASSE`** pour valider les accès.
    - Si l'accès est refuser, indiquez le dans un **`MessageBox`**.
    - Lorsque l'utilisateur est validé, il faut passer à la fenêtre **`FormContratLicence`**.
2. La fenêtre du contrat de license **`FormContratLicence`**
    - Ajouter un événement sur la boîte de texte **`txtReponse`** qui vérifie si le texte à changé (**`TextChanged`**).
    - Dès que le texte est **oui**, il faut passer à la fenêtre **`FormRepertoireExistant`**.
3. La fenêtre du répertoire existant **`FormRepertoireExistant`**
    - Vous devrez ajouter un événement au bouton **`btnVerifier`** qui vérifie si le contenu de la boîte de texte est un fichier ou un répertoire existant.
        - Si le fichier ou le répertoire existe, changer le texte de **`lblReponse`** à **OUI!** en vert.
        - Sinon, changer le texte de **`lblReponse`** à **NON!** en rouge.
    - Vous devrez ajouter un événement au bouton **`btnQuitter`** pour fermer le logiciel.

:::tip
Pour comparer des chaînes de caractère entre elle, il est recommandé de transformer la case soit tout en minuscule(**`.ToLower()`**) ou tout en majuscule(**`.ToUpper()`**).
:::

---

## 🪟 Fermer une fenêtre
Il existe deux façons de fermer une fenêtre. La première est la méthode **`.Close()`**. Celle-ci va fermer la fenêtre et puisque souvent notre fenêtre est celle qui est exécuté comme fil principale du programme (**`Application.Run(new FenetrePrincipale());`**), l'application va aussi être fermé. Lorsque nous utilisons plusieurs fenêtre, il serait peut-être préférable de cacher la fenêtre au lieu de la fermer.

```csharp
// ceci ✅
this.Hide();
FormSecondaire liscence = new FormSecondaire();
liscence.Show();

// au lien de ceci ❌, qui va fermer l'application
this.Close();
FormSecondaire liscence = new FormSecondaire();
liscence.Show();
```

---

## 📂 Fichier ou répertoire existant

Nous avons appris avec les fichiers **.csv** que pour vérifier leur existance, nous utilisions **`File.Exists()`**. Il existe le même principe pour les répertoires.

```csharp
string repertoire = "c:/EspaceLabo";
bool existe = Directory.Exists(repertoire); // la valeur sera à true si vous êtes dans un laboratoire.
```

---

## 🏃💨 Quitter ou fermer l'application

Il est très simple de fermer notre programme. Il suffit tout simplement d'appeler la méthode **`Exit()`** de l'application. Cette méthode va informer toutes les fenêtres qu'elles doivent se fermer. Elles vont donc tous appeler leur propre méthode **`.Close()`** et tous les événements attachés (**`FormClosing`**, **`FormClosed`**) 

```csharp
Application.Exit();
```
---
description: Windows Forms (suite)
---

# Windows Forms

## 🎯 Objectifs
1. Consolider la connaissance de Windows Forms
2. Comment utiliser nos classes et objets avec Windows Form
3. Comprendre ce qu'est un modèle de domaine/métier (Domain model)
4. Tester notre modèle sans s'entremêler dans l'interface graphique
5. Introduction aux instructions de précompilation

## ✅ Introduction

- Testabilité
- Maintenance (entretien du système)
- Développement parallèle
- Séparation des responsabilités
- Réutilisation

## ✅ Où placer notre code?

### Modèle du domaine/métier (Domain Model)

### Créer un projet de biblothèque de classe

![Ajouter un nouveau projet Bibliothèque de classe](@site/static/img/R12/bibliothequeClasse.png)

### Ajouter une référence

![Ajouter une référence de la bibliothèque au projet Winforms](@site/static/img/R12/ajouterReference.png)

![Cochez la bibliothèque que l'on vient de créer](@site/static/img/R12/cocherBibliotheque.png)

### Utiliser l'objet provenant d'un autre espace de nom (Namespace)

```csharp
using Modele;

namespace FenetrePricipale
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class1 maClasse = new Class1();
            maClasse.Identifiant = "Rémond";
        }
    }
}
```

Remarquez que l'on doit spécifier d'utiliser l'espace de nom de notre clase, qui dans ce cas-ci, est **`Modele`** avec le mot clé **`using`**.

```csharp
namespace Modele
{
    public class Class1
    {
        public string Identifiant { get; set; }
        public Class1()
        {

        }
    }
}
```

## ✅ Écrire une suite de tests.

### Introduction aux instructions de précompilation
Ce sont des instructions qui sont exécutées avant la compilation.

```csharp

#define TEST_CHARGER 

// ...

#if TEST_AJOUTER_ATHLETE
// Insérer les méthodes relatives aux tests ici..
#endif

```

### Ajouter un dossier (répertoire) pour nos classes de tests.
![Ajouter un nouveau dossier dans notre projet de bibliothèque de classe](@site/static/img/R12/ajouterDossier.png)

![La structure de notre solution](@site/static/img/R12/apercuSolution.png)

### Structure d'une classe de test

### Comment rédiger de bons tests
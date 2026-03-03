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

Modèle du domaine/métier (Domain Model)

- Testabilité
- Maintenance (entretien du système)
- Développement parallèle
- Séparation des responsabilités
- Réutilisation

## ✅ Où placer notre code?

Nous allons ajouter une nouvelle structure pour bien placer nos objets du domaine.

### ✨ Créer un projet de biblothèque de classe

![Ajouter un nouveau projet Bibliothèque de classe](@site/static/img/R12/bibliothequeClasse.png)

### ➕ Ajouter une référence

![Ajouter une référence de la bibliothèque au projet Winforms](@site/static/img/R12/ajouterReference.png)

![Cochez la bibliothèque que l'on vient de créer](@site/static/img/R12/cocherBibliotheque.png)

### 🛂 Utiliser un objet provenant d'un autre espace de nom (Namespace)

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

### 🦖 Introduction aux instructions de précompilation
Ce sont des instructions qui sont exécutées avant la compilation.

```csharp

#define TEST_CHARGER 

// ...

#if TEST_AJOUTER_ATHLETE
// Insérer les méthodes relatives aux tests ici..
#endif

```

### ➕ Ajouter un dossier (répertoire) pour nos classes de tests.
![Ajouter un nouveau dossier dans notre projet de bibliothèque de classe](@site/static/img/R12/ajouterDossier.png)

![La structure de notre solution](@site/static/img/R12/apercuSolution.png)

### ⚙️ Structure d'une classe de test

### 👨‍💻 Comment rédiger de bons tests

#### 🎯 Cibler les comportements, pas l'implémentation
Même si une classe de modèle est simple (souvent juste des getters/setters), tu peux :

Vérifier la bonne initialisation des propriétés via le constructeur.
Tester des méthodes du mdodèle de domaine (validation, calculs dérivés, etc.).

#### 🏗️ Structure AAA (Arrange-Act-Assert)
Tout test bien structuré suit cette règle :

- Arrange : Prépare le contexte du test (données, instances).
- Act : Exécute l'action à tester.
- Assert : Vérifie que le résultat est celui attendu.

#### 🚧 Tester les valeurs limites et cas extrêmes
- Valeurs null
- Chaînes vides
- Valeurs négatives ou très grandes
- Cas par défaut (objet non initialisé)

#### 🔒 Indépendance des tests
Chaque test doit être autonome et ne pas dépendre de l'ordre d'exécution ou de l'état d'un autre test.

#### 🚫 Ne teste pas les getters/setters "purs"
Les propriétés sans traitement vont toujours fonctionner. 
```csharp
private int m_age;
private string m_prenom;
public string Prenom // 🙅 Ne pas tester! ❌ 
{ 
    get
    {
        return m_prenom;
    }
    set
    {
        m_prenom = value;
    }
}
public string Nom { get; set; } // 🙅 Ne pas tester! ❌ 
public bool EstMajeur // 💁 à tester! ✅
{
    get
    {
        return age < 18;
    }
}
```

#### 📋 Récapitulatif — Que tester sur un modèle ?


|À tester ✅	| À ne pas tester ❌| 
|---|---|
|Propriétés calculées (NomComplet)|	Getters/setters purs sans logique|
|Méthodes du domaine (EstMajeur())	|Dépendances externes (BD, réseau)|
|Contraintes / validations	|Code de l'infrastructure|
|Valeurs limites et cas null	|| 
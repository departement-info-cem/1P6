---
description: Windows Forms (suite)
---

# Windows Forms (suite)

## 🎯 Objectifs
1. Consolider la connaissance de Windows Forms
2. Comment utiliser nos classes et objets avec Windows Form
3. Comprendre ce qu'est un modèle de domaine/métier (Domain model)

## ✅ Introduction

Séparer le modèle (données/logique métier) de l'interface graphique (UI) permet d'améliorer 
la **maintenabilité**, la **testabilité** et la **flexibilité** du code. Cela permet de modifier l'apparence 
sans casser la logique, de **réutiliser** le modèle du domaine pour différentes plateformes (mobile, web) 
et facilite le travail en **équipe**.

## ✅ Où placer notre code?

Le principale enjeux qui nous intéresse pour l'instant est la **testabilité**. Pour ce faire, nous aurons besoin de séparer notre code
de notre interface graphique. Nous allons délibérément créer une frontière logique entre ces deux mondes. Cette frontière prendra la forme
d'un nouveau **projet**. Nous allons ajouter une **bibliothèque de classe**.

### ✨ Créer un projet de biblothèque de classe

Une bibliothèque de classe ressemble beaucoup aux autres projets que nous avons déjà créés. La grande différence, c'est qu'elle ne possède plus aucune référence externe. Nous n'allons même plus avoir accès à la console! 😱

![Perte de l'accès à la console](@site/static/img/R12/consolePerdu.png)

Pourquoi? Ce ne sera pas la responsabilité de nos classe de gérer l'affichage. Ce sera à nos fenêtre et formulaire de Windows Forms de s'en occuper.

Il est fortement recommandé de nommer notre bibliothèque de classe **`Modele`**.

Voici comment ajouter un projet **`Bibliothèque de classe`**:
![Ajouter un nouveau projet Bibliothèque de classe](@site/static/img/R12/bibliothequeClasse.png)

### ➕ Ajouter une référence
Afin de franchir la frontière que nous nous sommes créée, nous devrons ajouter une référence de notre bibliothèque à notre projet **`Application Windows Forms`**. Cliquez avec le bouton droit de la souris sur notre projet contenant notre fenêtre principale, choisissez **`Ajouter`**, puis **`Référence de projet...`**. 
![Ajouter une référence de la bibliothèque au projet Winforms](@site/static/img/R12/ajouterReference.png)

Une fenêtre de **`Gestionnaire de références`** devrait ouvrir. Cochez le projet de biliothèque de classe, idéalement que l'on devrait avoir nommé **`Modele`**.
![Cochez la bibliothèque que l'on vient de créer](@site/static/img/R12/cocherBibliotheque.png)

### 🛂 Utiliser un objet provenant d'un autre espace de nom (Namespace)

Il nous reste maintenant à utiliser notre bibliothèque de classe dans notre fenêtre principale. Par défaut, l'espace de nom (Namespace) de note bibliothèque
devrait être le même que le nom de notre bibliothèque (**`Modele`**). Le mot clé **`using`** nous permet d'importer la bibliothèque et d'utiliser les classes qui si retrouvent.

Dans l'exemple ci-bas, la **`Class1`** de notre bilbiothèque est maintenant accessible:
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

Cet espace de nom **`Modele`** a été spécifié pour notre **`Class1`** en utilisant le mot clé **`namespace`**:

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

---
title: 🟢 Thermostat2.0
---
# 🧪 Labo 6.2A – 🟢 Thermostat2.0

:::danger
Ce laboratoire doit être développé à l'aide du logiciel **Git**. Vous devrez **créer un nouveau dépôt dans GitHub** 
et **inviter votre professeur** en tant que collaborateur.

Voici le format du dépôt exigé: **H26-2P6-R12-MATRICULE**

Il devrait y avoir **un commit** pour **chaque** exercice.

:::
---
## Aucun fichier de départ 😱

Et oui, on veut s'assurer que vous soyez capable de tout créer !

---

## 🎯 Objectifs 
* Se familiariser avec Windows Forms et les classes
* Créer une classe
* Instancier et utiliser un objet
* Créer un formulaire lié à un objet

## 🛠️ Instructions
Nous allons revisiter un ancien laboratoire et lui redonner un nouveau look! 💅

Vous devez réécrire un programme qui simule un thermostat. Ce programme instancie un objet de la classe **`Thermostat`**. 
Il permet d'augmenter ou de diminuer la température d'un degré à la fois. La température autorisée est 
entre 5 et 35 degrés Celsius.

Ajoutez une nouvelle classe au projet nommée **`AppThermostat`** qui correspond au schéma.

## 📋 Structure de la classe
Voici la classe et sa structure que vous devrez créer:

![](@site/static/img/R12/thermostat.png)

## ⭐ Exemple d'exécution

ok, ok... on va vous aider

#### Votre solution devrait ressembler à ça:

![Exemple des fichiers dans l'explorateur de solution](@site/static/img/R12/solutionThermostat.png)

#### ...et peut-être que vous allez vouloir initialiser votre interface utilisateur de cette façon:
```csharp
using Modele;

namespace InterfaceUtilisateur
{
    public partial class FormThermostat : Form
    {
        Thermostat thermostat;
        public FormThermostat()
        {
            InitializeComponent();

            thermostat = new Thermostat();
            lblTemperature.Text = thermostat.Temperature.ToString();
        }
```


#### Vous devrez ajouter les contrôles suivant:
- Une étiquette (**`Label`**) pour la température.
- Une étiquette pour indiquer l'unité de la température.
- Un bouton pour augmenter la température.
- Un bouton pour diminuer la température.

#### Votre interface graphique devrait ressembler à ceci:

![Exemple formulaire thermostat](@site/static/img/R12/formulaireThermostat.png)
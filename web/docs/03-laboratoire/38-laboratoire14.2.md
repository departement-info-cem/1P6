---
title: Programmation orientée objet
---

# 🧪 Labo 13.1 – Programmation orientée objet

📎 **Référence** : [Programmation orientée objet](https://info.cegepmontpetit.ca/1P6/cours/poo)
---

## 🟢 Exercice 1 : Compte bancaire

---
### Télécharger le projet de départ
Disponible ici 👇
<GithubDownload
  repo="1P6"
  folder="code/laboratoires/Laboratoire13-1/Exer1_Compte"
  label="📁 Exercice 1 - Compte bancaire" 
/>

Vous devez télécharger le .zip, puis l'extraire sur votre poste et **ouvrir le fichier `Compte.sln`** dans Visual Studio.

### 🎯 Objectifs de l’exercice :

* Instanciation : créer un objet avec new
* Accéder aux propriétés et méthode de l'objet
* Utiliser l'objet comme variable globale dans une application WinForm

**Instructions** : Compléter un application WinForm qui pernet à l'utilisateur de :
* Créer un compte bancaire au nom d'une personne
* Effectuer des depôts et des retraits sur le compte


✅ **Sortie attendue** :

Utiliser la démonstration pour comprendre le fonctionnement attendu de l'application.

---
## 🧩 Travail demandé

1. Télécharger le projet de départ
2. Compléter le code du formulaire

```csharp

        // TODO 01 : Définir une variable compte pour un objet Compte

        public FrmCompte()
        {
            InitializeComponent();


            // TODO 02 : Instancier la variable compte pour créer un compte à votre nom
           
            // TODO 03 : Utiliser la méthode AfficherInfosCompte pour afficher les informations du compte
           

        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            // TODO 05 : Compléter le code pour permettre de déposer un montant et actualiser l'affichage des informations du compte
            // Utiliser la méthode Deposer() de l'objet
          
        }

        private void btnRetrait_Click(object sender, EventArgs e)
        {
            // TODO 06 : Compléter le code pour permettre de retirer un montant et actualiser l'affichage des informations du compte
            // Utiliser la méthode Retirer() de l'objet
           
        }
        
        private void AfficherInfosCompte()
        {
            // TODO 04 : Compléter le code pour afficher les informations du compte      
           
        }
```


---
## 🟢 Exercice 2 : Thermostat

---
### Télécharger le projet de départ
Disponible ici 👇
<GithubDownload
  repo="1P6"
  folder="code/laboratoires/Laboratoire13-1/Exer2_Thermostat"
  label="📁 Exercice 2 - Thermostat" 
/>

Vous devez télécharger le .zip, puis l'extraire sur votre poste et **ouvrir le fichier `AppThermostat.sln`** dans Visual Studio.

### 🎯 Objectifs de l’exercice :

* Instanciation : créer un objet avec new
* Accéder aux membres:
    * propriétés et méthodes de l'objet
    * Constantes et méthodes statiques 
* Utiliser l'objet comme variable globale dans une application WinForm

**Instructions** : Compléter un application WinForm qui pernet à l'utilisateur de :
* Ajouter un Thermostat central dans sa maison
* Augmenter et diminuer la température avec ce thermostat


✅ **Sortie attendue** :

Utiliser la démonstration pour comprendre le fonctionnement attendu de l'application.

---
## 🧩 Travail demandé

1. Télécharger le projet de départ
2. Compléter le code du formulaire


```csharp

    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(DÉMO)";
        /// ==================================================================================
        /// <summary>
        /// Variable membre permettant de référer sur un objet de la classe Thermostat
        /// </summary>
        /// ----------------------------------------------------------------------------------
        // TODO 01 : Définir une variable pour objet Thermostat
       
        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02 : Instancier un objet Thermostat et l'affecter dans m_objThermostat
           

            // TODO 03 : Afficher la température courante dans lblTemperature
            

            // TODO 04 : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void MnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
        //====================================================================================
        private void BtnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 05A : Augmenter la température du Thermostat
            
            // TODO 5B : Afficher la température courante du Thermostat
            
            // TODO 5C : Appeler la méthode ActualiserBoutonsSelonContexte
            
        }
        //====================================================================================
        private void BtnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Diminuer la température du Thermostat
           
            // TODO 6B : Afficher la température courante du Thermostat
           
            // TODO 6C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void MnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 07 : Afficher la température minimale d'un Thermostat
          
        }
        //====================================================================================
        private void MnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 08 : Afficher la température maximale d'un Thermostat
           
        }
        //====================================================================================
        private void TmrTempérature_Tick(object sender, EventArgs e)
        {
            // TODO 09 : Afficher la température actuelle du Thermostat
            
        }
        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 10A : btnDiminuer est actif seulement si la température courante est supérieure à TEMPÉRATURE_MINIMALE
           
            // TODO 10B : btnAugmenter est actif seulement si la température courante est inférieure à TEMPÉRATURE_MAXIMALE
           
        }
    }
```


---
## 🟢 Exercice 3 : MultiThermostat

---
### Télécharger le projet de départ
Disponible ici 👇
<GithubDownload
  repo="1P6"
  folder="code/laboratoires/Laboratoire13-1/Exer3_MultiThermostat"
  label="📁 Exercice 3 - MultiThermostat" 
/>

Vous devez télécharger le .zip, puis l'extraire sur votre poste et **ouvrir le fichier `AppMultiThermostat.sln`** dans Visual Studio.

### 🎯 Objectifs de l’exercice :

* Instanciation : créer plusieurs objets de la même classe
* Type référence
* Utiliser l'objet comme variable globale dans une application WinForm

**Instructions** : Compléter un application WinForm qui pernet à l'utilisateur de :
* Ajouter un thermostat dans chaque pièce de sa maison
* Augmenter et diminuer la température de chaque pièce avec son propre thermostat


✅ **Sortie attendue** :

Utiliser la démonstration pour comprendre le fonctionnement attendu de l'application.

---
## 🧩 Travail demandé

1. Télécharger le projet de départ
2. Compléter le code du formulaire


```csharp

      public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(DÉMO)";

        /// =================================================================================
        // TODO 01A : Déclarer une variable et Instancier un Thermostat pour la chambre à 25
       

        // TODO 01B : Déclarer une variable et Instancier un Thermostat pour la cuisine à 20
        

        // TODO 01C : Déclarer une variable et Instancier un Thermostat pour le salon à 22
       

        // TODO 01D : Déclarer une variable supplémentaire pour référer sur le Thermostat courant (NE PAS INSTANCIER)
       
        //====================================================================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            // TODO 02A : Fixer le Thermostat courant à celui de la chambre
            

            // TODO 02B : Afficher la température du Thermostat courant
            
        }

        //====================================================================================
        private void radChambre_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 03A : Modifier le Thermostat courant pour référer sur celui de la chambre
           
            // TODO 03B : Afficher la température du Thermostat courant
           
            // TODO 03C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void radCuisine_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 04A : Modifier le Thermostat courant pour référer sur celui de la cuisine
            
            // TODO 04B : Afficher la température du Thermostat courant
            
            // TODO 04C : Appeler la méthode ActualiserBoutonsSelonContexte
            
        }
        //====================================================================================
        private void radSalon_CheckedChanged(object sender, EventArgs e)
        {
            // TODO 05A : Modifier le Thermostat courant pour référer sur celui du salon
           
            // TODO 05B : Afficher la température du Thermostat courant
          
            // TODO 05C : Appeler la méthode ActualiserBoutonsSelonContexte
          
        }
        //====================================================================================
        private void btnAugmenter_Click(object sender, System.EventArgs e)
        {
            // TODO 06A : Augmenter la température du Thermostat courant
           
            // TODO 06B : Afficher la température du Thermostat courant
           
            // TODO 06C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void btnDiminuer_Click(object sender, System.EventArgs e)
        {
            // TODO 07A : Diminuer la température du Thermostat courant
          
            // TODO 07B : Afficher la température du Thermostat courant
           
            // TODO 07C : Appeler la méthode ActualiserBoutonsSelonContexte
           
        }
        //====================================================================================
        private void mnuAffichageTempMin_Click(object sender, EventArgs e)
        {
            // TODO 08 : Afficher la température minimale permise par un Thermostat           
           
        }
        //====================================================================================
        private void mnuAffichageTempMax_Click(object sender, EventArgs e)
        {
            // TODO 09 : Afficher la température maximale permise par un Thermostat
                      
        }
        //====================================================================================
        private void TmrTempératureCourante_Tick(object sender, EventArgs e)
        {
             // TODO 10 : Afficher la température actuelle du Thermostat courant
           
        }
        //====================================================================================
        private void ActualiserBoutonsSelonContexte()
        {
            // TODO 11A : btnDiminuer est actif seulement si la température courante est supérieure à TEMPÉRATURE_MINIMALE
           
            // TODO 11B : btnAugmenter est actif seulement si la température courante est inférieure à TEMPÉRATURE_MAXIMALE
           
        }

        //====================================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }

```

 

---

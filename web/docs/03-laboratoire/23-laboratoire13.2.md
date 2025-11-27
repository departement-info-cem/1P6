---
title: Intégration 
---

# 🧪 Labo 13.2 – Intégration  


## 🎯 Objectifs

* Créer et manipuler des **objets** graphiques **WinForms** via le **code** 
* Créer une application **WinForms** complexe
  * Utiliser les fichiers texte dans une application **WinForms**



---

## 🧭 Création et manipulation d’un contrôle Button
---

### 🎯 Objectifs

* l’instanciation dynamique de contrôles
* la configuration de leurs propriétés
* la gestion des événements via des délégués (ici, une lambda expression)
* l’intégration du contrôle dans le formulaire
---

### 🔸 1. Création d’un contrôle dynamiquement

Au lieu d’utiliser l’interface designer, on peut créer les contrôles directement par code.
Ici, un objet de type **Button** est instancié :

```csharp
Button b = new Button();
```

L’avantage de cette approche est la **flexibilité** : on peut générer des contrôles à la volée, en fonction de conditions ou de données.

---

### 🔸 2. Configuration des propriétés du contrôle

Chaque contrôle possède des **propriétés** permettant de définir son apparence et son comportement.
Par exemple :

* `Text` : texte affiché sur le bouton
* `Location` : position (x,y) du contrôle dans la fenêtre
* `Size` : dimensions du contrôle
* `Tag` : champ polyvalent permettant d’associer au contrôle des données supplémentaires

```csharp
b.Text = "Bonjour";
b.Location = new Point(50, 50);
b.Tag = 10;
b.Size = new Size(100, 100);
```

Ces propriétés permettent de personnaliser le contrôle avant son affichage.

---

### 🔸 3. Gestion des événements (Programmation événementielle)

Ici, l’événement **Click** du bouton est associé à un *gestionnaire d’événement* (event handler) :

```csharp
b.Click += (s, e) =>
{
    Button btn = (Button) s;
    MessageBox.Show("Je suis là");
};
```

#### Explications :

* `b.Click += ...` : on abonne une méthode à l’événement `Click`
* `(s, e)` :

  * `s` représente l’objet émetteur de l’événement (ici, le bouton cliqué)
  * `e` contient les informations relatives à l’événement
* `Button btn = (Button)s;` : on récupère le bouton qui a généré l'événement
* `MessageBox.Show("Je suis là");` : action effectuée lorsque l’utilisateur clique

Cela illustre clairement la notion **d’action-réaction** : *l’utilisateur clique → le programme exécute une méthode*.

---

### 🔸 4. Ajout du contrôle à la fenêtre

Une fois configuré, le bouton doit être ajouté à la collection `Controls` du formulaire :

```csharp
Controls.Add(b);
```
### 🔸 5. Ajout du contrôle à la fenêtre

Tu peux définir la taille d’une fenêtre en ajustant la propriété Size du formulaire (Form). Par exemple :
```csharp
this.Size = new Size(800, 600); // Redimensionner la fenêtre à 800x600 pixels
```

Tu peux également redimensionner la fenêtre en ajustant la largeur et la hauteur individuellement :
```csharp
this.Width = 800;  // Largeur de la fenêtre
this.Height = 600; // Hauteur de la fenêtre
```
Cela permet de définir une taille spécifique pour la fenêtre de ton application.

---
## 🔵 Mini-Projet  : Gestion de tâches

---
### Télécharger le projet de départ
Disponible ici 👇
<GithubDownload
  repo="1P6"
  folder="code\laboratoires\Laboratoire13-2\Task2Do"
  label="📁 Exercice - Gestion de tâches" 
/>

Vous devez télécharger le .zip, puis l'extraire sur votre poste et **ouvrir le fichier `Task2Do.sln`** dans Visual Studio.

### 🎯 Objectifs de l’exercice :

* Manipuler des objets graphiques (ListBox, ComboBox, TextBox, Button, Menu).
* Gérer les événements utilisateur (clics, double-clics, sélection d’éléments).
* Utiliser les fichiers texte

---
### 🧩 Travail demandé

Vous devez compléter une application **WinForms** permettant à l’utilisateur de gérer ses tâches quotidiennes.
L’application doit offrir les fonctionnalités suivantes :

1. **Ajouter une tâche** à partir d’une liste de tâches disponibles ou en saisissant manuellement une nouvelle tâche.
2. **Supprimer une tâche** de la liste des tâches à faire.
3. **Déplacer une tâche** :

   * de la liste **À faire** vers la liste **Réalisées**,
   * de la liste **Réalisées** vers la liste **À faire**.
4. **Enregistrer les tâches** dans des fichiers texte afin de conserver les données entre deux utilisations de l’application :

   * un fichier pour les tâches à faire,
   * un fichier pour les tâches réalisées,
   * un fichier pour les tâches disponibles.
5. **Charger automatiquement** les tâches depuis les fichiers au démarrage de l’application.
6. **Quitter l’application** via le menu prévu à cet effet.

Vous devez implémenter les méthodes nécessaires et compléter le code des événements déjà présents pour assurer le bon fonctionnement de l’ensemble.

---



```csharp

 public partial class FrmTasks : Form
 {
     // Chemin du fichier contenant la liste des tâches à faire.
     private readonly string cheminFichierTachesAFaire = "../../Fichiers/tachesAFAire.txt";

     // Chemin du fichier contenant la liste des tâches réalisées.
     private readonly string cheminFichierTachesRealisees = "../../Fichiers/tachesRealisees.txt";

     // Chemin du fichier contenant la liste des tâches disponibles.
     private readonly string cheminFichierTachesDisponibles = "../../Fichiers/tachesDisponibles.txt";

     public FrmTasks()
     {
        InitializeComponent();

        // Chargement des tâches         

     }



    // ==================================== Méthodes à implémenter =================================
    // 
    // Enregistre les tâches d’une ListBox dans un fichier texte.
    // Paramètres :
    //   cheminFichier      -> chemin du fichier où les tâches seront sauvegardées
    //   lstBoxSource       -> ListBox contenant les tâches à enregistrer
    private void EnregistrerTaches(string cheminFichier, ListBox lstBoxSource){}

    // Charge les tâches d’un fichier texte dans une ListBox.
    // Paramètres :
    //   cheminFichier       -> chemin du fichier à lire
    //   lstBoxDestination   -> ListBox dans laquelle les tâches seront ajoutées     
    private void ChargerTaches(string cheminFichier, ListBox lstBoxDestination){}

    // Charge les tâches disponibles à partir d’un fichier texte dans un ComboBox.
    // Paramètres :
    //   cheminFichier        -> chemin du fichier à lire
    //   cmbBoxDestination    -> ComboBox dans lequel les éléments seront ajoutés
    private void ChargerTachesDisponibles(string cheminFichier, ComboBox cmbBoxDestination){}

    // ==================================== Événements à implémenter =================================

    // Ajoute une nouvelle tâche à la liste "À faire".
    // Vérifie que la tâche n'est pas vide, puis l’ajoute à la ListBox lstAFaire.
    private void btnAjouter_Click(object sender, EventArgs e){}

    // Supprime la tâche sélectionnée dans la liste "À faire".
    // Si aucune tâche n'est sélectionnée, un message d’information est affiché.
    private void btnSupprimerAFaire_Click(object sender, EventArgs e){}

    // Déplace la tâche sélectionnée de "À faire" vers "Réalisée".
    // Si aucune tâche n’est sélectionnée, un message d’information apparaît.
    private void btnVersRealise_Click(object sender, EventArgs e){}

    // Déplace la tâche sélectionnée de "Réalisée" vers "À faire".
    // Si aucune tâche n’est sélectionnée, un message d’information est affiché.
    private void btnVersAFaire_Click(object sender, EventArgs e){}

    // Enregistre les listes "À faire" et "Réalisée" dans leurs fichiers respectifs.
    private void mnuEnregistrer_Click(object sender, EventArgs e){}

    // Ferme l’application.
    private void mnuQuitter_Click(object sender, EventArgs e){}


```


---
## 🔵 Mini-Projet  : Gestion de Panier

---
### Télécharger le projet de départ
Disponible ici 👇
<GithubDownload
  repo="1P6"
  folder="code\laboratoires\Laboratoire13-2\Panier"
  label="📁 Exercice - Gestion de Panier" 
/>

Vous devez télécharger le .zip, puis l'extraire sur votre poste et **ouvrir le fichier `Panier.sln`** dans Visual Studio.

### 🎯 Objectifs de l’exercice :

* Manipuler des objets graphiques (ListBox, ComboBox, TextBox, Button, Menu).
* Gérer les événements utilisateur (clics, double-clics, sélection d’éléments).
* Utiliser les fichiers texte

---
### 🧩 Travail demandé


Vous devez compléter une application **WinForms** permettant à l’utilisateur de gérer un **panier d’achats**. L’application doit permettre de gérer des items disponibles et le contenu du panier, tout en calculant le total avec taxes.

L’application doit offrir les fonctionnalités suivantes :

1. **Charger les items disponibles** depuis un fichier texte au démarrage de l’application.
2. **Ajouter un item au panier** :

   * Sélectionner un item dans la liste des items disponibles.
   * Ajouter cet item dans le panier et mettre à jour la facture (nombre d’items, total, taxes, total avec taxes).
3. **Retirer un item du panier** en le sélectionnant dans la liste du panier.
4. **Vider le panier** complètement via le menu prévu à cet effet.
5. **Enregistrer le panier** dans un fichier texte afin de conserver les données entre deux utilisations.
6. **Charger le panier** depuis le fichier correspondant.
7. **Afficher la facture** :

   * Nombre d’items dans le panier.
   * Total des prix des items.
   * Taxes appliquées.
   * Total incluant les taxes.
8. **Activer ou désactiver les boutons** en fonction des sélections (par exemple, “Retirer du panier” ne doit être actif que si un item est sélectionné).
9. **Quitter l’application** via le menu prévu à cet effet.

Vous devez compléter les méthodes et événements déjà présents dans le projet pour assurer le bon fonctionnement de l’ensemble. Chaque action (ajout, suppression, chargement, enregistrement, double-clic) doit mettre à jour correctement le contenu du panier et la facture.

---




```csharp

 public partial class FrmPanier : Form
{

    const decimal TAUX_TAXE = 0.15m; // TAUX des taxes applicables
    const int INDEX_COL_DESCRIPTION = 0; // index de la colonne pour la description des items
    const int INDEX_COL_PRIX = 1; // index de la colonne pour le prix des items

    // Chemin du fichier contenant la liste des items.
    private readonly string cheminFichierItems = "../../Fichiers/Items.txt";

    // Chemin du fichier contenant les items du panier.
    private readonly string cheminFichierPanier = "../../Fichiers/Panier.txt";

    // ---------------------------------------------------------------------------------------------
    public FrmQ1()
    {
        InitializeComponent();
        // Charger les items disponibles
        
        
        
    }

    // ==================================== Méthodes à implémenter =================================
    // 
    // Enregistre le contenu du panier dans un fichier texte.
    // Chaque item du ListBox lstPanier est écrit dans le fichier.
    private void EnregistrerPanier(){}

    // Charge la liste des items disponibles à partir du fichier correspondant.
    // Chaque ligne du fichier est ajoutée dans la ListBox lstItemsDisponibles.
    private void ChargerItems(){}

    // Charge le contenu du panier à partir d’un fichier texte.
    // Chaque ligne du fichier représente un item ajouté dans lstPanier.
    // Après le chargement, la facture est mise à jour automatiquement.
    private void ChargerPanier(){}

    // Calcule et affiche le résumé de la facture du panier.
    // - Affiche le nombre d’items dans le panier.
    // - Calcule le total des prix des items (avant taxes).
    // - Calcule et affiche les taxes.
    // - Calcule et affiche le total avec les taxes.
    // Les résultats sont affichés dans les TextBox prévues.
    public void AfficherFacture(){}

    // ==================================== Événements à implémenter =================================

   // Active ou désactive le bouton "Retirer du panier" selon qu'un item est sélectionné dans lstPanier.
    private void LstPanier_SelectedIndexChanged(object sender, EventArgs e){}

    // Ferme l'application.
    private void mnuFichierQuitter_Click(object sender, EventArgs e){}

    // Vide complètement le panier et met à jour la facture.
    private void mnuFichierViderPanier_Click(object sender, EventArgs e){}

    // Ajoute l'item sélectionné ou saisi dans le panier.
    // Met à jour la ListBox et réinitialise les champs de saisie.
    public void BtnAjouterAuPanier_Click(object sender, EventArgs e){}

    // Retire l'item sélectionné du panier et met à jour la facture.
    private void BtnRetirerDuPanier_Click(object sender, EventArgs e){}

    // Charge le panier depuis le fichier correspondant.
    private void mnuFichierChargerPanier_Click(object sender, EventArgs e){}

    // Enregistre le panier dans le fichier correspondant.
    private void mnuFichierEnregistrerPanier_Click(object sender, EventArgs e){}

    // Double-clic sur un item disponible : remplit les champs de description et prix.
    // Active le bouton "Ajouter au panier" si un item est sélectionné, sinon réinitialise les champs.
    private void lstItemsDisponibles_DoubleClick(object sender, EventArgs e){}

```




 

---





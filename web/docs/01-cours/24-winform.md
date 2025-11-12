---
description: Remise TP3 et introduction à l'interface graphique (WinForm)
---

# 12.2 — Remise TP3 et introduction à l'interface graphique (WinForm)

## 🎯 Objectif

Concevoir et développer une application Windows simple avec une interface graphique en utilisant Visual Studio et le framework WinForms de C#.

---

### 🔍 Objectifs spécifiques :

1. **Comprendre les principes de base d’une interface graphique (GUI)** : fenêtres, contrôles, événements, propriétés.
2. **Découvrir l’environnement de développement Visual Studio** pour créer un projet WinForms.
3. **Utiliser les principaux contrôles** (boutons, labels, zones de texte, menus, etc.) pour construire une interface utilisateur.
4. **Gérer les événements** (clics, saisies, etc.) avec le code C#.
5. **Personnaliser l’apparence et le comportement** d’une application Windows.
6. **Compiler et exécuter une application WinForms fonctionnelle.**


---
## 🖥️ **1. Interface graphique (GUI)**

Une interface graphique (**Graphical User Interface**) permet à l’utilisateur d’interagir avec l’ordinateur à l’aide d’éléments visuels comme des fenêtres, boutons, menus ou icônes. Contrairement aux applications console, elle est plus intuitive : l’utilisateur clique, sélectionne ou saisit des données au lieu de taper des commandes. Les interfaces graphiques rendent les applications plus faciles à utiliser et moins sujettes aux erreurs. Dans ce cours, nous utiliserons WinForms en C# pour apprendre à créer des fenêtres, ajouter des contrôles et gérer les actions de l’utilisateur.

![Démonstration](_24-winform/winform-demo.png)

---
## 🧩 **2. Structure d’une application WinForms**

Une application **WinForms** est organisée autour de **formulaires**, qui sont des fenêtres servant d’interface avec l’utilisateur. Chaque formulaire correspond à une **classe C#** dérivée de `Form`. L’application démarre avec le **formulaire principal**, et peut ouvrir d’autres formulaires secondaires si nécessaire.

Dans le projet WinForms, on retrouve généralement :

* **Form1.cs** : contient le code logique du formulaire.
* **Form1.Designer.cs** : génère automatiquement le code de l’interface créée avec le concepteur.
* **Program.cs** : point d’entrée du programme, qui lance le formulaire principal via `Application.Run()`.

Le **concepteur graphique** de Visual Studio permet de **placer et configurer visuellement les contrôles** (boutons, zones de texte, étiquettes…), tandis que le **code C#** gère leur comportement et les interactions avec l’utilisateur. Cette organisation sépare clairement **l’interface** du **fonctionnement**, ce qui facilite la création, la lecture et la maintenance de l’application.



![Contrôles](_24-winform/winform-environnement.png)

---

## 🧱 **3. Les contrôles de base**

Dans une application **WinForms**, les **contrôles** représentent les éléments visuels interactifs qui composent l’interface graphique. Ce sont les objets que l’utilisateur voit et manipule sur le formulaire, tels que les :

* **formulaire (Form)**,
* **bouton (Button)**,
* **étiquette (Label)**,
* **zone de texte (TextBox)**,
* **case à cocher (CheckBox)**,
* **bouton radio (RadioButton)** 
* **liste (déroulantes) (ComboBox et ListBox)**. 

L’ajout de contrôles se fait facilement dans **Visual Studio** grâce à l’outil de conception visuelle : il suffit de **glisser-déposer** les éléments souhaités depuis la boîte à outils vers le formulaire.


![Contrôles](_24-winform/winform-controles.png)

---

### ⚙️ **Les propriétés et les méthodes**

Chaque **contrôle** d’une application WinForms possède un ensemble de **propriétés** qui définissent son apparence, sa position et son comportement. Par exemple, une propriété peut indiquer le **texte affiché** sur un bouton (`Text`), la **taille** ou la **couleur** d’un élément (`Size`, `BackColor`), ou encore sa **visibilité** (`Visible`). Ces propriétés peuvent être modifiées de deux manières : soit dans la **fenêtre Propriétés**, soit directement dans le **code**.

Chaque contrôle dispose également d’un ensemble de méthodes permettant d’intervenir sur lui, par exemple pour l’afficher, le masquer ou en actualiser l’affichage.

#### **Quelques propriétés communes à tous les contrôles**
| Propriété            | Description                                                                 | Exemple                                        |      
| -------------------- | --------------------------------------------------------------------------- | ---------------------------------------------- |
| **Name**             | Nom du contrôle (identifiant dans le code).                                 | `btnOk.Name = "btnOk";`                        |     
| **Text**             | Texte affiché (si applicable).                                              | `txtMessage.Text = "Bienvenue";`               |        
| **Enabled**          | Indique si le contrôle est actif (`true`) ou désactivé (`false`).           | `txtNom.Enabled = false;`                      |              
| **Visible**          | Rend le contrôle visible ou invisible.                                      | `txtNom.Visible = true;`                       |              
| **BackColor**        | Couleur d’arrière-plan du contrôle.                                         | `txtNom.BackColor = Color.LightGray;`          | 
| **ForeColor**        | Couleur du texte (si applicable).                                           | `txtNom.ForeColor = Color.DarkBlue;`           |   
| **Size**             | Taille du contrôle (largeur et hauteur).                                    | `txtNom.Size = new Size(100, 30);`             |   

#### **Quelques méthodes communes à tous les contrôles**
| Méthode                               | Description                                                   | Exemple C#                                           |
| ------------------------------------- | ------------------------------------------------------------- | ---------------------------------------------------- |
| **Show()**                            | Affiche le contrôle.                                          | `btnSupprimer.Show();`                               |
| **Hide()**                            | Cache le contrôle.                                            | `btnSupprimer.Hide();`                               |
| **Focus()**                           | Donne le focus (sélection) au contrôle.                       | `btnSupprimer.Focus();`                              |
| **Select()**                          | Similaire à `Focus()`.                                        | `btnSupprimer.Select();`                             |


### 🖱️ **Les événements**

Dans une interface WinForms, les **événements** représentent les actions effectuées par l’utilisateur — comme un **clic sur un bouton**, une **saisie de texte**, ou encore le **chargement d’un formulaire**. Chaque contrôle peut générer différents événements, et le programmeur définit la **réaction du programme** à ces actions en écrivant du code spécifique appelé **gestionnaire d’événement** (*event handler*).
Par exemple, pour un bouton nommé *button1*, on peut écrire une méthode en C# comme :

```csharp
private void button1_Click(object sender, EventArgs e)
{
   // Ici, l’événement `Click` déclenche l’exécution de cette ligne de code pour afficher un message à l’écran. 
    MessageBox.Show("Bonjour !");
}
```


#### **Quelques évènements communes à tous les contrôles**
| Événement                           | Description                                            |
| ------------------------------------|------------------------------------------------------- |
| **Click**                           | Quand on clique sur le contrôle.                       |
| **DoubleClick**                     | Quand on double-clique.                                | 
| **MouseEnter / MouseLeave**         | Quand la souris entre ou quitte le contrôle.           | 
| **MouseDown / MouseUp / MouseMove** | Pour gérer les actions de la souris.                   |
| **KeyDown / KeyUp / KeyPress**      | Pour capter les touches du clavier.                    | 
| **GotFocus / LostFocus**            | Quand le contrôle reçoit ou perd le focus.             | 
| **TextChanged**                     | Quand le texte change (pour les contrôles avec texte). | 

```csharp
private void button1_DoubleClick(object sender, EventArgs e)
{
   // Ici, l’événement `Click` déclenche l’exécution de cette ligne de code pour afficher un message à l’écran. 
    MessageBox.Show("Bonjour !");
}
```
```csharp
private void txtNom_TextChanged(object sender, EventArgs e)
{
   // Ici, l’événement `Click` déclenche l’exécution de cette ligne de code pour afficher un message à l’écran. 
    MessageBox.Show("Bonjour !");
}
```
---

## 🧰 **TextBox**

Le TextBox est un **champ de saisie** permettant à l’utilisateur d’entrer du **texte** (comme un nom, une adresse, un mot de passe, etc.).

### **Principales propriétés et méthodes**

| Propriété                           | Description       | Exemple |
|--------------------------------|-----------------------------|--------------------------------|
| Text                           | Contenu du TextBox    | <code>//Récupérer le contenu d'un TextBox<br />string nom = txtNom.Text;<br /> //Modifier le contenu<br />txtNom.Text = "Adam";</code>|
| Visible                        | Afficher ou masuqer le contrôle | <code>//Afficher un TextBox<br />txtNom.Visible = true;<br /> //Masquer un TextBox<br />txtNom.Visible = false;</code>|
| ReadOnly            | Empêcher la modification du texte | <code>txtNom.ReadOnly = true;</code>|
| MaxLength              | Limite le nombre de caractères   | <code>txtNom.MaxLength = 50;</code>|



---
## 🧰 **Button**

Le Button est un contrôle **cliquable** qui permet à l’utilisateur de déclencher une action.

### **Associer un bouton à l'évènement click**
Nous voulons 

````csharp
private void btnMessage_Click(object sender, EventArgs e)
{
    // Récupérer le contenu du contrôle txtNom
    string nom = txtNom.Text
    MessageBox.Show("Bonjour " + nom);
}
````
---
## 1️⃣ Le controle ListBox

Le Button est un contrôle **cliquable** qui permet à l’utilisateur de déclencher une action.

### Principales propriétés et méthodes
| Propriété       | Description                                               | Exemple                                                 |
| --------------- | --------------------------------------------------------- | ------------------------------------------------------- |
| `Items`         | Contient la liste des éléments                            | `lstFruits.Items.Add("Banane");`                          |
| `SelectedIndex` | Index de l’élément sélectionné                            | `int index = lstFruits.SelectedIndex;`                   |
| `SelectedItem`  | L’élément sélectionné                                     | `string ville = (string)listBox1.SelectedItem;`         |
| `SelectionMode` | Mode de sélection (`One`, `MultiSimple`, `MultiExtended`) | `listBox1.SelectionMode = SelectionMode.MultiExtended;` |
| `Sorted`        | Tri automatique des éléments                              | `listBox1.Sorted = true;`                               |

Chacun des éléments contient la valeur par défaut du type de données du tableau :
| Propriété                           | Description       | Exemple |
|--------------------------------|-----------------------------|--------------------------------|
| Text                           | Contenu du TextBox    | <code>//Récupérer le contenu d'un TextBox<br />string nom = txtNom.Text;<br /> //Modifier le contenu<br />txtNom.Text = "Adam";</code>|
| Visible                        | Afficher ou masuqer le contrôle | <code>//Afficher un TextBox<br />txtNom.Visible = true;<br /> //Masquer un TextBox<br />txtNom.Visible = false;</code>|
| ReadOnly            | Empêcher la modification du texte | <code>txtNom.ReadOnly = true;</code>|
| MaxLength              | Limite le nombre de caractères   | <code>txtNom.MaxLength = 50;</code>|
| ...                            | ...                         | ...                             |

### 1️⃣ Remplir un ListBox
Maintenant, nous allons remplir le contrôle lstFruits par des noms de fruit.

````csharp
private void btnRemplirListBox_Click(object sender, EventArgs e)
{
    // supprimer tous les éléments
    lstFruits.Items.Clear();

    // Ajouter des éléments
    lstFruits.Items.Add("Kiwi");
    lstFruits.Items.Add("Banane");
    lstFruits.Items.Add("Pomme");
  
}
````
1. Ouvrez votre projet WinForms dans Visual Studio
2. Ouvrez le Form1.cs [Design]
3. Dans la Boîte à outils (Toolbox), faites glisser un TextBox sur votre formulaire
4. Ajustez sa taille et sa position avec la souris

### Principales propriétés et méthodes
Chacun des éléments contient la valeur par défaut du type de données du tableau :
| Propriété                           | Description       | Exemple |
|--------------------------------|-----------------------------|--------------------------------|
| Text                           | Contenu du TextBox    | <code>//Récupérer le contenu d'un TextBox<br />string nom = txtNom.Text;<br /> //Modifier le contenu<br />txtNom.Text = "Adam";</code>|
| Visible                        | Afficher ou masuqer le contrôle | <code>//Afficher un TextBox<br />txtNom.Visible = true;<br /> //Masquer un TextBox<br />txtNom.Visible = false;</code>|
| ReadOnly            | Empêcher la modification du texte | <code>txtNom.ReadOnly = true;</code>|
| MaxLength              | Limite le nombre de caractères   | <code>txtNom.MaxLength = 50;</code>|
| ...                            | ...                         | ...                             |


---

## 📎 Références


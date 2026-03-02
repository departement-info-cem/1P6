---
description: Windows Forms
---

# Windows Forms

## 🎯 Objectifs
1. Introduction à Windows Forms
2. Comprendre la structure du projet
3. Créer un projet WinForms
4. Créer une application simple

## ✅ Introduction

Windows Forms est une structure logicielle, offerte par Microsoft, pour développer des interfaces utilisateur. Cette structure est simple, mature et rapide. Elle est idéale pour nous. Il s'agit tout simplement d'une boîte à outils nous offrant des fenêtres et des contrôles avec lesquels nous pourrons composer notre application. Nous serons donc en mesure d'ajouter une interface graphique à nos programmes.

:::info
Une interface graphique (**Graphical User Interface**) permet à l’utilisateur d’interagir avec l’ordinateur à l’aide d’éléments visuels comme des fenêtres, boutons, menus ou icônes. Contrairement aux applications console, elle est plus intuitive : l’utilisateur clique, sélectionne ou saisit des données au lieu de taper des commandes. Les interfaces graphiques rendent les applications plus faciles à utiliser et moins sujettes aux erreurs. Dans ce cours, nous utiliserons WinForms en C# pour apprendre à créer des fenêtres, ajouter des contrôles et gérer les actions de l’utilisateur.
:::

Vous retrouverez Windows Forms dans plusieurs contextes comme:
- Solutions logiciel qui doivent être exécutées localement (Outils de sécurité, diagnostic, productivité).
- Accès aux ressources matérielles de l'ordinateur (Système de fichier, périphériques spécifiques, ports série).
- Outils internes d'entreprise
- Prototype et preuve de concept
- Projets personnels

Windows Forms repose sur le principe de la **programmation événementielle**. C'est-à-dire que l'application est en **attente** d'un stimuli pour ensuite **réagir**. Elle est comparable à nos menus console. C'est le même principe que nous utilison lorsque l'application tourne en boucle en attendant que l'utilisateur choisisse et appuie sur la touche `entrée`.

### 🌟 Créer un projet
Commençons par créer un projet d'application Windows Forms et nous explorerons ensuite sa structure.

![Création d'un projet Application Windows Forms](@site/static/img/R11/projetWinforms.png)

## ✅ Comprendre la structure

### 🏁 Le point d'entrée
Le point d'entrée reste le même fichier, soit **`Program.cs`**. Parcontre, on y retrouve quelques petites différences:

```csharp
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FenetrePrincipale());
        }
    }
```
Nous retrouvons notre **`static void Main()`** auquel nous sommes habitués. L'attribut de classe **`[STAThread]`** est ajouté et nous indique que l'application sera exécutée sur le fil d'exécution pricinpale. Sans pour autant entrer dans les détails, Winforms **ne supporte pas le multithread**. Il faudra faire attention de ne pas bloquer l'interface utilisateur et éviter les longues opérations.

La ligne importante pour nous est **`Application.Run(new FenetrePrincipale());`**, c'est notre point d'entrée. Avec cette ligne, nous informons que l'application va être exécutée en ouvrant une fenêtre de type **`Form`** et que nous avons nommé **`FenetrePrincipale`**.

:::tip
Remarquez ici qu'après avoir configuré les styles visuels et le rendu du texte par défaut, l'application lance immédiatement **`FenetrePrincipale`**. Nous pourrions profiter de l'occasion pour initialiser le logiciel **avant** même de créer la fenêtre principale où l'utilisateur sera accueilli.

```csharp
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
// ... peut-être appeler une méthode d'initialisation ici? 🤔
Application.Run(new FenetrePrincipale());
```
:::

### 🧑‍🔧Le code-behind 

Chaques fenêtres, chaques boutons, chaques zone de textes, bref... **TOUT** est un **objet** dans Windows Forms. Comme on vient de le voir au point d'entrée, pour démarrer une fenêtre, il faut instancier un objet de type `Form` avec le mot clé `new`. 

Si l'on observe cette section de code, on peut y lire qu'un bouton est ajouté à la fenêtre pricipale:
```csharp
public class FenetrePrincipale : Form
{
    public FenetrePrincipale()
    {
        /// btnQuitter
        Button btnQuitter = new System.Windows.Forms.Button();
        btnQuitter.Name = "btnQuitter";
        btnQuitter.Size = new System.Drawing.Size(75, 30);
        btnQuitter.Text = "Quitter";

        /// FenetrePricipale
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Fenêtre principale";
        this.Controls.Add(btnQuitter);
    }            
```
En effet, tout les contrôles que nous allons créer et ajouter à la fenêtre sont des objets avec des propriétés que nous devrons initialiser. Une fois initialiser, ces objets seront contenu dans une collection de contrôle de la fenêtre. On peut se le représenter comme un liste d'objet où les boutons, les champs de textes, les étiquettes vont être gardé en mémoire.

Ils seront emmagasinés dans cette collection appelé **`components`**.

```csharp
public class FenetrePrincipale : Form
{
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
``` 

### 🧰 La boîte à outil
Écrire tout ceci à la main est long et fastidieux. La boîte à outil est là pour nous aider. Elle est accessible par le menu **`Affichage➡️Boîte à outils`** ou tout simplement avec le raccourcis **`ctrl-alt-x`**. Avec cet outil, il est maintenant possible d'ajouter, positionner, dimensionner les contrôles de la fenêtre en n'utilisant que la souris. Nous aurons donc rarement à créer objets de contrôles manuellement.

![La boîte à outil accessible par ctrl-alt-x](@site/static/img/R11/boiteOutil.png)

Comme vous pouvez remarquer, il y a une quantité incroyable de contrôles. Nous explorerons les principaux tout au long de la session, mais nous allons nous restreindre aux 
- Fenêtres (`Form`)
- Étiquettes (`Label`)
- Boîtes de texte (`TextBox`) 
- Boutons (`Button`).

### 🪄 Le designer

L'outil de conception, appelé **Designer** dans Visual Studio, est pratique et complexe. Il permet de générer le code des contrôles automatiquement lorsqu'on les glisse de la boîte à outils vers la fenêtre et lorsqu'on les modifie à partir de la fenêtre de propriétés. Le designer remarque les changements apportés aux contrôles et ajuste le code au fur et à mesure des changements.

Prenons par exemple l'ajout d'un simple bouton **`Quitter`**:
![Insertion d'un bouton "Quitter" dans la fenêtre principale](@site/static/img/R11/btnQuitter.png)


<Row>

Remarquez maintenant que le designer reflète dans le code les propriétés que nous avons spécifiées comme par exemple la position (Location = 198; 59).
<Column>

```csharp
private void InitializeComponent()
{
    this.btnQuitter = new System.Windows.Forms.Button();
    this.SuspendLayout();
    // 
    // btnQuitter
    // 
    this.btnQuitter.Location = new System.Drawing.Point(198, 59);
    this.btnQuitter.Name = "btnQuitter";
    this.btnQuitter.Size = new System.Drawing.Size(152, 52);
    this.btnQuitter.TabIndex = 0;
    this.btnQuitter.Text = "Quitter";
    this.btnQuitter.UseVisualStyleBackColor = true;
    // 
    // Form1
    // 
```

</Column>

<Column>

![La fenêtre de propriété d'un contrôle](@site/static/img/R11/proprietes.png)

</Column>

</Row>

:::tip
Lorsqu'on utilise le volet graphique du designer, les propriétés des objets peuvent être changées sans avoir à écrire du code. Il suffit de choisir sa composante en cliquant dessus ou en choississant son nom dans le menu déroulant de la **`🔧Fenêtre de propriété (F4)`**.

![Fenêtre de propriétés](@site/static/img/R11/tipProprietes.png)

:::

On ne va pas se le cacher, il y a une quantité incroyable de contrôles et chaques contrôles a beaucoup de propriétés. Il nous sera impossible de tout montrer pendant le cours. Nous devrons alors nous familiariser avec l'interface d'application logiciel(API) de Microsft pour Winforms. 

Voici un lien vers une description générale des contrôles et des leurs propriétés:
[Control Classe](https://learn.microsoft.com/fr-fr/dotnet/api/system.windows.forms.control?view=netframework-4.7.2)

On y retrouve la liste exhaustive et détaillée des:
- Constructeurs
- Propriétés
- Méthodes
- Événements

Il faudra se pratiquer à chercher à l'intérieur de cet outil.

## ✅ Fenêtres (Form)

[Lien vers l'API pour la classe Form](https://learn.microsoft.com/fr-fr/dotnet/api/system.windows.forms.form?view=netframework-4.7.2)

La fenêtre est un élément important d'une application Winforms. Elle est le point d'acrage de toutes les composantes. Elle est tellement important que si on décide de fermer la fenêtre, l'application va s'arrêter.


```csharp
public partial class FenetrePrincipale : Form
{
    public void Fermer()
    {
        this.Close();

        // Est l'équivalent de fermer explicitement l'application par:
        Application.Exit();
    }
```

### ➕ Ajouter une fenêtre

Il est possible que l'on veuille ajouter des fenêtres (formulaires) à notre projet. Il suffit de faire un **`clic droit`** de la souris sur le **`projet`**, sélectionner **`Ajouter...`** et ensuite cliquer sur **`Formulaire (Windows Form)`**.

![Ajouter une fenêtre clique droit souris sur projet, Ajouter..., Formulaire (Windows Form)](@site/static/img/R11/ajouterForm.png)

:::tip
N'oubliez pas de mettre à jour le fichier **`Program.cs`** si c'est la fenêtre principale que vous changez!

```csharp
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
// ... peut-être appeler une méthode d'initialisation ici? 🤔
Application.Run(new Form1()); // ❌
Appication.Run(new NouvelleFenetre()); // ✅
```
:::
### 🥊 `Form.cs` vs `Form.Designer.cs`
Un petit mot clé C# s'est glissé sans que l'on s'en rende compte. Vous remarquerez dans la définition de la classe que le mot **`partial`** est apparu. Il est très important, car il indique que la classe FenetrePricipale est définie à **deux endroits**! On retrouve la classe **`FenetrePricipale`** dans **`FenetrePricipale.cs`** **ET** dans **`FenetrePrincipale.Designer.cs`**.

![FenetrePricipale.cs et FenetrePricipale.Designer.cs](@site/static/img/R11/designer.png)

Le code que nous allons écrire devra être inséré dans **`FenetrePrincipale.cs`**. Cependant, le code généré par le designer va se retrouver dans **`FenetrePrincipale.Designer.cs`**. Il est important d'éviter de modifier le code dans le **`.Designer.cs`** car nous n'avons pas nécessairement le contrôle de ce qui est écrit.

### 🔰 InitializeComponent()

La méthode **`InitializeComponent()`** généré par le designer se retrouve dans le fichier **`*.Designer.cs`** de notre fenêtre. On y retrouve **TOUS** nos contrôles tel que nos boutons, étiquettes et boîtes de texte que nous ajoutons avec la boîte à outils. Cette section change dès que l'on modifie la propriété d'un contrôle. 

```csharp
#region Code généré par le Concepteur Windows Form

/// <summary>
/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
/// le contenu de cette méthode avec l'éditeur de code.
/// </summary>
private void InitializeComponent()
{
    this.btnQuitter = new System.Windows.Forms.Button();
    this.SuspendLayout();
    // 
    // btnQuitter
    // 
    this.btnQuitter.Location = new System.Drawing.Point(123, 85);
    this.btnQuitter.Name = "btnQuitter";
    this.btnQuitter.Size = new System.Drawing.Size(152, 52);
    this.btnQuitter.TabIndex = 0;
    this.btnQuitter.Text = "Quitter";
    this.btnQuitter.UseVisualStyleBackColor = true;
    this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
    // 
    // FenetrePricipale
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(409, 240);
    // ...
```

:::danger
Il est fortement **déconseillé** d'ajouter ou de modifier soit même du code dans cette section. Il n'est pas garantie que nos changements seront gardés.
:::

## ✅ Contrôles

[Lien vers la classe générale de Control](https://learn.microsoft.com/fr-fr/dotnet/api/system.windows.forms.control?view=netframework-4.7.2)

Les contrôles dans Winforms prennent plusieurs formes. Ce sont des composantes d'interface utilisateur réutiilisables qui permetttent d'afficher des données, de structurer la mise en page et de receuillir les entrées de l'utilisateur. Ils sont des éléments visuels interactifs. Chaque contrôle possède des propriétés, des méthodes et des événements communs.

Les noms que nous allons donner à nos contrôles doivent respecter un standard. Le nom doit commmencer par un **préfix de trois lettres**.

### 🏷️ Étiquette (Label)
[Lien vers la classe Label](https://learn.microsoft.com/fr-fr/dotnet/api/system.windows.forms.label?view=netframework-4.7.2)

Une étiquette est un contrôle de la classe **`System.Windows.Forms.Label`**. Elle permet d'afficher du texte à l'utilisteur. On s'en sert principalement pour identifier les contrôles présentés dans une fenêtre, fournir des instructions ou pour afficher des information dynamique à l'exécution (statut, résultats).

:::warning
Le préfixe pour une étiquette est **`lbl`**.
:::

![Visuel d'une boîte de texte de la classe Textbox](@site/static/img/R11/label.png)

```csharp
/// <summary>
/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
/// le contenu de cette méthode avec l'éditeur de code.
/// </summary>
private void InitializeComponent()
{
    // 
    // lblQuelNom
    // 
    this.lblQuelNom.AutoSize = true;
    this.lblQuelNom.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.lblQuelNom.Location = new System.Drawing.Point(23, 35);
    this.lblQuelNom.Name = "lblQuelNom";
    this.lblQuelNom.Size = new System.Drawing.Size(197, 22);
    this.lblQuelNom.TabIndex = 1;
    this.lblQuelNom.Text = "Quel est votre nom?";
```

### ⌨️ Boîte de texte (TextBox)
[Lien vers la classe TextBox](https://learn.microsoft.com/fr-fr/dotnet/api/system.windows.forms.textbox?view=netframework-4.7.2)

Une boîte de texte est un contrôle de la classe **`System.Windows.Forms.TextBox`**. Elle permet à l'utilisteur d'écrire du texte dans une zone spécifique. On s'en sert principalement pour permettre à l'utilisateur de saisir, modifier ou visualiser du texte (une ou plusieurs lignes) dans une application. C'est un contrôle essentiel pour la collecte de données, prenant en charge le clavier, le copier-coller et la personnalisation.

:::warning
Le préfixe pour une boîte de texte est **`txt`**.
:::

![Visuel d'une étiquette de la classe Label](@site/static/img/R11/textBox.png)

```csharp
/// <summary>
/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
/// le contenu de cette méthode avec l'éditeur de code.
/// </summary>
private void InitializeComponent()
{
    // 
    // txtNom
    // 
    this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.txtNom.Location = new System.Drawing.Point(226, 35);
    this.txtNom.Name = "txtNom";
    this.txtNom.Size = new System.Drawing.Size(263, 29);
    this.txtNom.TabIndex = 2;
```
### 🖱️ Bouton (Button)
[Lien vers la classe Button](https://learn.microsoft.com/fr-fr/dotnet/api/system.windows.forms.button?view=netframework-4.7.2)

Un bouton est un contrôle de la classe **`System.Windows.Forms.Button`**. Il permet à l'utilisteur de déclencher une action spécifique, telle que la soumission d'un formulaire, l'enregistrement de données, l'ouverture ou la fermeture d'une fenêtre. Il s'agit d'un composant fondamental de l'interface graphique.

:::warning
Le préfixe pour un bouton est **`btn`**.
:::

![Visuel d'un bouton de la classe Button](@site/static/img/R11/button.png)

```csharp
/// <summary>
/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
/// le contenu de cette méthode avec l'éditeur de code.
/// </summary>
private void InitializeComponent()
{
    // 
    // btnQuitter
    // 
    this.btnQuitter.Location = new System.Drawing.Point(183, 164);
    this.btnQuitter.Name = "btnQuitter";
    this.btnQuitter.Size = new System.Drawing.Size(152, 52);
    this.btnQuitter.TabIndex = 0;
    this.btnQuitter.Text = "Quitter";
    this.btnQuitter.UseVisualStyleBackColor = true;
    this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
```

## ✅ Événements

Un événement en C# WinForms est un signal émis par un contrôle (bouton, formulaire) pour notifier qu'une action s'est produite, telle qu'un clic (Click), une touche pressée (KeyDown) ou le chargement d'une fenêtre (Load). Ils sont au cœur de la programmation événementielle : le code réagit en réponse à l'action de l'utilisateur.

### ➕ Ajouter un événements

Dans la fenêtre **`Propriétés`**, il est possible d'ajouter des événements. Sous le nom de l'objet de contrôle sélectionné, il existe plusieurs boutons. Le quatrième est le bouton **`Événements'** qui va basculer la liste des propriétés vers la liste des événements disponibles pour ce contrôle.

![Événements](@site/static/img/R11/events.png)

:::tip
Il arrive souvent d'ajouter un événement clic par erreur en double cliquant le contrôle au lieu de le sélectionner. Il est possible d'effacer cet événements. Parcontre si l'événement à été effacé dans le fichier de la fenêtre (**`FenetrePricipale.cs`**), il est possible de venir corriger le designer en allant effacer l'événement dans l'**`InitializeComponent()`** du designer de la fenêtre (**`FenetrePricipale.Designer.cs`**).
![Erreur commun](@site/static/img/R11/erreurCommun.png)

:::

### 🗺️ Où sont placés les événements?

Les événements générés par le designer sont placés dans le fichier de notre fenêtre. Dans l'exemple ici, il sera dans **`FenetrePrincipale.cs`**. Malheureusement lorsqu'on clique sur notre fenêtre dans l'**`Explorateur de solutions`**, Visual Studio nous ouvre le designer. Pour voir le code derrière, il faut faire un clique droit de la souris sur notre fenêtre et choisir **`<> Afficher le code`**. Un raccourcis clavier existe qui est **`F7`**.

![Emplacement de l'événements](@site/static/img/R11/eventLocation.png)

### 🔎 À quoi ressemble un événement

Un événement va toujours avoir la même signature. Le nom est écrit sous le format `nomControl_Evenement`. 

Les deux paramètres sont très importants:
- **`object sender`**: Est une référence sur l'objet qui a déclanché l'événement. Il est possible d'associer le même événement à plusieurs contrôles! Il est donc primordial d'être en mesure de déterminer **QUI** a généré l'événement.
- **`EventArgs e`**: Est un objet contenant tous les arguments passés en paramètre à l'événements. 

```csharp
private void btnQuitter_Click(object sender, EventArgs e)
{
    Application.Exit();
}
```
## 📚 Ressources supplémentaires


Vous devez réaliser le labo suivant :
 [🧪 Labo 6.1](/laboratoire/laboratoire6.1A)

---
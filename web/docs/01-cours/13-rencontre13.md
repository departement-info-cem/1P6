---
description: Relations
---

# La relation d'association

## 🎯 Objectifs
1. Comprendre et implémenter une association entre objets
   * Relier `Chat` et `Proprietaire` via un lien unidirectionnel/bidirectionnel
   * Introduire la notion de multiplicité (1 propriétaire → plusieurs chats)
2. Comprendre les relations d'agrégation et de composition
3. Utiliser les contrôles WinForms : `ListBox` et `ComboBox`
---

💡 À la fin de ce cours, l’étudiant saura modéliser correctement des entités du domaine et créer des relations entre objets.

---
## 🐱🔍👤 Situation initiale : modèle actuel

Dans notre application de gestion d’un salon de toilettage pour chats, nous voulons gérer les chats et leurs propriétaires. 
Le salon doit donc être capable de connaître le propriétaire d’un chat afin de gérer les rendez-vous et les services.

* Chaque chat possède des informations de base, comme son nom et son âge, et est associé à un client du salon.
* Chaque client possède des informations de base, comme son nom et son numéro de téléphone.

### 🧠 Représentation conceptuelle

![](@site/static/img/R13/noRelationChatClient.png)

### 💻 Implémentation avec C#

**Classe Chat**
``` csharp
 public class Chat
 {
     public string Nom { get; private set; }
     public string Age { get; private set; }       
 }
```
**Classe Client**
``` csharp
public class Client
{ 
   public string Nom { get; private set;}           
   public string Prenom { get; private set;}
   public string Telephone { get; private set;}
}
```
ℹ️ **Remarque :**

> On utilise uniquement des **propriétés automatiques** sans validation pour se concentrer sur la **structure des classes et leurs relations**.
---

## 🐱👤 Amélioration du modèle : Un chat doit connaitre son propriétaire
Dans notre modèle initial, les classes Chat et Client existent indépendamment.
Or, dans la réalité, chaque chat appartient à un client.
Nous devons donc modifier notre modèle afin de représenter cette relation entre les deux classes.

### 🎯 Besoin métier

> * Chaque chat est associé à un seul client, qui est son propriétaire.

> 👉 Comment peut-on savoir qui est le propriétaire d’un chat ?


### 🧠 Représentation conceptuelle

![](@site/static/img/R13/relationChatClientUni.png)

### 💻 Implémentation avec C#

**Classe Chat modifiée**
``` csharp
 public class Chat
 {
   public string Nom { get; private set; }
   public int Age { get; private set; }       
   // Un chat connaît son propriétaire, qui est un client.
   public Client Proprietaire { get; private set; }

   public Chat(string nom, int age, Client proprietaire)
   {
      Nom = nom;
      Age = age;
      Proprietaire = proprietaire;
   } 
       
 }
```
#### 📦 Exemples d'objets en relations

* La cliente Sophie est la propriétaire du chat Milo.
``` csharp
 Client client = new Client("Martin", "Sophie", "514-123-4567"),
 Chat chatMilo = new Chat("Milo", 2, client);
```
👉 Le chat Milo possède une propriété Proprietaire qui référence l’objet client.

---

## 🐱🔢👤 Amélioration du modèle : Cardinalité de la relation
Nous savons maintenant qu’il existe une relation entre les classes Chat et Client : Un chat possède un propriétaire.
Cependant, cette relation soulève plusieurs questions importantes :
> * 👉 Combien de clients peut avoir un chat ?
> * 👉 Combien de chats peut avoir un client ?

### 🎯 Besoin métier
Supposons maintenant les règles suivantes :

> * Chaque chat possède  **un** seul client propriétaire ;
> * Un client peut posséder **plusieurs** chats.

### 🧠 Représentation conceptuelle

Pour préciser combien de chats et de clients peuvent être liés dans cette relation, on ajoute la notion de cardinalité dans le modèle conceptuel.

![](@site/static/img/R13/relationChatClientUniAvecCard.png)

### 💻 Implémentation avec C#


#### 📦 Exemples d'objets en relations

* La cliente Sophie est la propriétaire des chats Milo et Luna.
``` csharp
Client client = new Client("Martin", "Sophie", "514-123-4567"),

Chat chatMilo = new Chat("Milo", 2, client);
Chat chatLuna = new Chat("Luna", 1, client);
```
👉 Les deux chats Milo et Luna possèdent chacun une propriété **Proprietaire** qui référence au même objet **client**.


### Accéder aux informations du propriétaire


``` csharp
// Obtenir le nom du propriétaire du chat Milo
string nom = chatMilo.Proprietaire.Nom

// Obtenir le propriétaire du chat Milo
Client proprietaireMilo = chatMilo.Proprietaire

```
---
## 🐱🔢👤 Amélioration du modèle : Le client connais-il ses chats ?
Dans le modèle amélioré, chaque chat connaît son propriétaire grâce à la propriété Proprietaire.

> * 👉 Comment peut-on trouver tous les chats d’un client ?

``` csharp
// Supposons que nous avons une liste contenant tous les chats
// et une autre contenant tous les clients
List<Client> clients = new List<Client>
{
    new Client("Martin", "Sophie", "514-123-4567"),
    new Client("Dubois", "Marc", "514-987-6543"),
    new Client("Lefebvre", "Julie", "514-555-1111")
};

List<Chat> chats = new List<Chat>
{
    new Chat("Milo", 2, clients[0]),
    new Chat("Luna", 1, clients[0]),
    new Chat("Tiger", 3, clients[1]),
    new Chat("Nala", 4, clients[2]),
    new Chat("Simba", 2, clients[0])
};
```
🧠 **Question**

👉 Trouver tous les chats de Sophie.

💻 Solution possible: Pour trouver les chats d’un client, il faudrait parcourir tous les chats.

``` csharp
// On veut trouver les chats de Sophie Martin
List<Chat> chatsDeSophie = new List<Chat>();
foreach(Chat chat in chats)
{
    if(chat.Proprietaire.Prenom == "Sophie" &&
        chat.Proprietaire.Nom == "Martin")
    {
        chatsDeAdam.Add(chat);
    }
}
```

### 🎯 Besoin métier: Le client doit connaitre ses chats
Avec le modèle actuel, le client ne connaît pas ses chats. Pour trouver les chats d’un client, il faudrait parcourir tous les chats.
Pour résoudre ce problème, on ajoute une liste de chats dans la classe Client. Cela permet au client de connaître directement ses chats.

### 🧠 Représentation conceptuelle

![](@site/static/img/R13/relationChatClientBiAvecCard.png)

### 💻 Implémentation avec C#
Afin de pouvoir retrouver facilement les chats d’un client, la classe Client possède maintenant une propriété qui contient une liste de chats. Cette liste permet de représenter tous les chats appartenant à ce client.

**Classe Client modifiée**
``` csharp
public class Client
{ 
   public string Nom { get; private set;}           
   public string Prenom { get; private set;}
   public string Telephone { get; private set;}
   // Un client connaît ses chats
   public List<Chat> MesChats { get; private set; }   
}
```
#### ⚠️ Remarque importante

Maintenant que la classe Client possède une liste de chats, il faut s’assurer que cette liste reste cohérente.

Autrement dit :

> Lorsqu’un chat est créé ou associé à un client, il faut mettre à jour la liste des chats de ce client.

Sinon, le modèle devient incohérent :
* le chat connaît son propriétaire
* mais le client ne connaît pas ce chat

Nous ajoutons maintenant dans la classe Client une méthode **AjouterChat** qui permet d’ajouter un chat à la liste des chats du client. Cette méthode sera appelée automatiquement lors de la création d’un chat afin de maintenir la cohérence entre les deux classes.

**Classe Client**
``` csharp
public class Client
{
    public string Nom { get; private set;}
    public string Prenom { get; private set;}

    public List<Chat> Meschats { get; private set;}

    public Client(string nom, string prenom, string Telephone)
    {
        Nom = nom;
        Prenom = prenom;
        Telephone = telephone;
        MesChats = new List<Chat>();
    }

    public void AjouterChat(Chat chat)
    {
        MesChats.Add(chat);
    }
}
```
**Classe Chat** 
``` csharp
public class Chat
{
    public string Nom { get; private set;}
    public int Age { get; private set;}

    public Client Proprietaire { get; private set;}

    public Chat(string nom, int age, Client proprietaire)
    {
        Nom = nom;
        Age = age;
        Proprietaire = proprietaire;

        // Mise à jour de la liste des chats du client
        proprietaire.AjouterChat(this);
    }
}
```
## ⭐ Récapitulatif
Pour représenter fidèlement la relation entre les chats et les clients, nous avons apporté les modifications suivantes aux deux classes (modèles): 

* Dans la classe Chat, une propriété a été ajoutée afin de stocker une référence vers l’objet Client représentant le propriétaire du chat. Cela permet à chaque chat de connaître son propriétaire.

* Dans la classe Client, une liste de chats a été ajoutée. Cette liste permet de conserver tous les chats appartenant à ce client et de faciliter leur accès.

* De plus, lorsqu’un chat est associé à un client, la liste des chats du client est automatiquement mise à jour afin de maintenir la cohérence entre les deux classes.

## 🔢 Cardinalités
Lorsqu’on établit une relation entre deux classes, il faut préciser combien d’objets d’une classe peuvent être liés à combien d’objets de l’autre classe.
Conceptuellement, nous avons utilisé les cardinalités dans notre diagramme de classe. Dans le tableau suivant, nous trouvons les différentes configurations possibles que nous pouvons utiliser en fonction du besoin métier.

| Cardinalité | Signification                                          | Exemple                                                                            |
| ----------- | ------------------------------------------------------ | ---------------------------------------------------------------------------------- |
| 1 – 1   | Chaque objet est lié à un seul objet de l’autre classe | Une voiture possède une seule plaque                                               |
| 1 – *   | Un objet peut être lié à plusieurs objets              | Un client peut avoir plusieurs chats                                               |
| * – *   | Plusieurs objets peuvent être liés à plusieurs objets  | Un étudiant peut suivre plusieurs cours et un cours peut avoir plusieurs étudiants |
| 0..1    | Zéro ou un objet                                       | Un chat peut ne pas avoir encore de propriétaire                                   |
| 0..*    | Zéro, un ou plusieurs objets                           | Un client peut n’avoir aucun chat ou plusieurs                                  


De point de vue implémentation, la cardinalité influence directement la façon dont la relation est représentée dans le code.

* Une cardinalité 0..1 peut être représentée par une propriété nullable, ce qui signifie que la relation est optionnelle.
``` csharp
// Ici, un chat peut ne pas avoir de propriétaire.
// Par exemple, dans un refuge, s’il n’a pas encore été adopté.
public Client? Proprietaire { get; private set;}
```
* Une cardinalité 1 est représentée par une propriété simple, car l’objet doit toujours exister.
``` csharp
// Dans le contexte d’un salon de beauté pour chats, chaque chat doit avoir un propriétaire.
// Un chat ne peut pas être enregistré dans le système sans client associé.
public Client Proprietaire { get; private set;}
```
* Une cardinalité * est généralement représentée par une liste d’objets, par exemple `List<T>`.
``` csharp
// Un client peut posséder plusieurs chats.
public List<Chat> MesChats { get; private set;}
```

## ⭐ Types particuliers d'associations
### Agrégation
Une association entre deux classes peut avoir différentes sémantiques. Par exemple, elle peut représenter une relation **tout–partie**, comme dans le cas d’une équipe et de ses joueurs.

* Une équipe peut être composée d’un ou de plusieurs joueurs. Les joueurs font donc partie de l’équipe.
* L'équipe et ses joueurs sont liés par une relation de type **« se compose de »** ou encore **tout–partie**.

Ce type de relation est appelée **agrégation**.


Dans un diagramme de classes, cette association particulière est représentée par un lien dont l’extrémité du côté du tout (dans notre exemple, l’équipe) est indiquée par un **losange vide**. 


<div align="center">

![](@site/static/img/R13/agregationEquipeJoueur.png)

</div>

En implémentation, l’agrégation est représentée de la même manière qu’une association.

### Composition

La composition modélise un lien d'agrégation fort. La destruction du tout implique automatiquement la destruction des parties.
Prenons l’exemple d’une maison. 
* Une maison est composée de plusieurs pièces (salon, cuisine, chambres, etc.).
* Les pièces font donc partie de la maison.
* Une maison et ses pièces sont liées par une relation **tout–partie**.
* Dans ce cas, les pièces n’ont pas de sens sans la maison : si la maison disparaît, les pièces disparaissent aussi.

👉 On parle alors d’une relation de composition.

<div align="center">

![](@site/static/img/R13/compositionMaisonPiece.png)

</div>

---

# 🪟 ListBox et ComboBox en C# (WinForms)

## 1. Présentation des contrôles

### ListBox

Un **ListBox** est un contrôle qui permet d’afficher une **liste d’éléments** parmi lesquels l’utilisateur peut faire une sélection.

Caractéristiques :

* Peut afficher plusieurs éléments.
* Peut permettre une **sélection simple ou multiple**.
* Utilisé pour afficher une liste d’objets ou de valeurs.

Exemples d’utilisation :

* Liste de clients
* Liste de produits
* Liste de fichiers

---

### ComboBox

Un **ComboBox** est une **liste déroulante** combinée avec une zone de texte.

Caractéristiques :

* Permet de choisir un élément dans une liste.
* Peut permettre la saisie manuelle.
* Prend moins d’espace qu’une ListBox.

Exemples d’utilisation :

* Choix d’une ville
* Choix d’un type
* Choix d’une catégorie

---

# 2. Ajouter des éléments

Les deux contrôles utilisent la propriété :

```
Items
```

qui contient les éléments de la liste.

---

## Ajouter un élément

```csharp
listBox1.Items.Add("Jean");
comboBox1.Items.Add("Marie");
```

---

## Ajouter plusieurs éléments

```csharp
listBox1.Items.Add("Jean");
listBox1.Items.Add("Paul");
listBox1.Items.Add("Marie");
```

ou

```csharp
comboBox1.Items.AddRange(new string[] { "Rouge", "Vert", "Bleu" });
```

---

## Vider la liste

```csharp
listBox1.Items.Clear();
comboBox1.Items.Clear();
```

---

# 3. Récupérer l’élément sélectionné

## Avec SelectedItem

Retourne **l’objet sélectionné**.

```csharp
string nom = listBox1.SelectedItem.ToString();
```

ou

```csharp
string couleur = comboBox1.SelectedItem.ToString();
```

⚠️ Toujours vérifier qu’un élément est sélectionné.

```csharp
if (listBox1.SelectedItem != null)
{
    string nom = listBox1.SelectedItem.ToString();
}
```

---

## Avec SelectedIndex

Retourne **la position de l’élément** sélectionné.

```csharp
int index = listBox1.SelectedIndex;
```

Exemple :

```csharp
if (listBox1.SelectedIndex != -1)
{
    MessageBox.Show("Index : " + listBox1.SelectedIndex);
}
```

---

# 4. Ajouter des objets dans un ListBox ou ComboBox

On peut ajouter **des objets complets** et pas seulement des chaînes de caractères.

Exemple avec une classe.

### Classe

```csharp
public class Client
{
    public string Nom { get; set; }
    public string Prenom { get; set; }

    public override string ToString()
    {
        return Nom + " " + Prenom;
    }
}
```

---

## Ajouter un objet

```csharp
Client c1 = new Client();
c1.Nom = "Dupont";
c1.Prenom = "Jean";

listBox1.Items.Add(c1);
```

Le **ListBox affichera automatiquement le résultat de `ToString()`**.

---

## Récupérer l’objet sélectionné

```csharp
if (listBox1.SelectedItem != null)
{
    Client c = (Client)listBox1.SelectedItem;
    MessageBox.Show(c.Nom);
}
```

Même principe pour un **ComboBox**.

```csharp
Client c = (Client)comboBox1.SelectedItem;
```

---

# 5. Supprimer un élément

## Supprimer l’élément sélectionné

```csharp
if (listBox1.SelectedIndex != -1)
{
    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
}
```
ou
```csharp
if (listBox1.SelecselectedItem != null)
{
    listBox1.Items.Remove(listBox1.SelectedItem);
}
```

---

# 6. Événement de sélection

On peut exécuter du code lorsqu’un élément est sélectionné.

### ListBox

```csharp
private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    if (listBox1.SelectedItem != null)
    {
        MessageBox.Show(listBox1.SelectedItem.ToString());
    }
}
```

---

### ComboBox

```csharp
private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
{
    MessageBox.Show(comboBox1.SelectedItem.ToString());
}
```

---

# 7. Résumé

| Action                | Code               |
| --------------------- | ------------------ |
| Ajouter un élément    | `Items.Add()`      |
| Ajouter plusieurs     | `Items.AddRange()` |
| Vider la liste        | `Items.Clear()`    |
| Élément sélectionné   | `SelectedItem`     |
| Position sélectionnée | `SelectedIndex`    |
| Supprimer             | `RemoveAt()`       |

---


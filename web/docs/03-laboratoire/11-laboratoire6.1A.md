---
title: 🟢 Bonjour tout le monde!
---
# 🧪 Labo 6.1A – 🟢 BonjourToutLeMonde

:::danger
Ce laboratoire doit être développé à l'aide du logiciel **Git**. Vous devrez **créer un nouveau dépôt dans GitHub** 
et **inviter votre professeur** en tant que collaborateur.

Voici le format du dépôt exigé: **H26-2P6-R11-MATRICULE**

Il devrait y avoir **un commit** pour **chaque** exercice.

:::
---
### Télécharger la solution contenant les différents exercices de ce laboratoire.

Disponible ici 👉 [Laboratoire6_1](../../static/files/laboratoires/Laboratoire6_1.zip)

---

## 🎯 Objectifs 

- Créer une application Windows Forms.
- Ajouter et positionner des contrôles.
- Ajouter un événement à un contrôle.
- Découvrir le **`MessageBox`**.
---

## 🛠️ Instructions
Dans cet exercice, vous devez créer une application Windows Forms en c#. Votre fenêtre devra être en mesure de prendre un prénom et un nom. Lorsqu'on appuie sur le bouton **`Bonjour!`**, une boîte de message devra appraraîte avec le message : **"Bonjour prenom nom!"**.

Dans la fenêtre, vous devrez ajouter:
- Une **étiquette** et une **boîte** de texte pour le **prénom**.
- Une **étiquette** et une **boîte** de texte pour le **nom**.
- Un **bouton** bonjour qui affichera, par un événement **`click`**, le message dans une **`MessageBox`**.

:::warning
Vous devrez valider les champs **prénom** et **nom**. Ils ne doivent pas être vide. Affichez un message d'erreur dans ce cas.
:::

Voici un exemple du résultat attendu:

![Exemple de fenêtre demandé](@site/static/img/R11/bonjour.png)


---

## 📥 MessageBox

La boîte de message est un outil essentiel pour les applications utilisant Windows Forms. Elle permet d'afficher une petite fenêtre d'information pour l'utilisateur. Elle est souvent utiliser pour afficher des messages d'erreur, d'information ou d'avertissement. Cette fenêtre apparaît lorsqu'on l'appel avec la méthode **`Show()`**.

La méthode **`Show()`** a pour paramètre:
- Le message en `string`.
- Le titre en `string`.
- Un enum pour les boutons.
- Un enum pour l'icône affiché.

```csharp
MessageBox.Show("Le message", "Le titre", MessageBoxButtons.OK, MessageBoxIcon.Information);
```

![Exemple d'un MessageBox](@site/static/img/R11/messageBox.png)
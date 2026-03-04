---
description: Relations
---

# Type par énumération

## 🎯 Objectifs
1. Comprendre la notion d’entité métier
   * Identifier les objets du domaine réel (Chat, Proprietaire)
   * Différencier ce qui appartient à chaque entité
2. Comprendre et implémenter une association entre objets
   * Relier `Chat` et `Proprietaire` via un lien bidirectionnel
   * Introduire la notion de multiplicité (1 propriétaire → plusieurs chats)

---

💡 À la fin de ce cours, l’étudiant saura modéliser correctement des entités du domaine et créer des relations entre objets.

---
## ✅ Situation initiale : modèle actuel

> « Dans notre application **AdopteTonChaton**, nous voulons gérer des chats et leurs propriétaires. Chaque chat a des informations de base comme son nom et son âge, et appartient à un propriétaire.

> On commence avec une classe `Chat` qui contient :
>
> * Le **nom** du chat
> * L’**âge**
> * Le **nom du propriétaire** sous forme de `string`

ℹ️ **Remarque :**

> On utilise uniquement des **propriétés automatiques** sans validation pour se concentrer sur la **structure des classes et leurs relations**.

![](@site/static/img/R13/chat.png)


Ici, le propriétaire est représenté par une simple chaîne de caractères.

```
Chat c1 = new Chat("Milo", 2, "Jean Dupont");
```
Pour le moment, le propriétaire est représenté uniquement par son nom : "Jean Dupont".

---

❓ **Question :**

> Est-ce que "Jean Dupont" est un objet ou simplement un texte ?

---
✔️ Réponse : c’est juste un texte.
________________________________________

## ✅ Nouveau besoin métier

On veut maintenant stocker :

> * Le prénom du propriétaire
> * Le numéro de téléphone du propriétaire

---

❓ **Question :**

> Comment peut-on stocker ces informations?

---
✔️ Réponse : ???
________________________________________

### ✅ Première solution : Ajouter des propriétés dans la classe `Chat`

* On remplace le simple `string` du propriétaire par plusieurs propriétés :

  * `NomProprietaire`
  * `PrenomProprietaire`
  * `TelephoneProprietaire`

![](@site/static/img/R13/chatV2.png)

**Avantages :**

* Permet d’accéder directement à plusieurs informations sur le propriétaire.
* Plus structuré qu’un simple texte.

**Limites :**

* Si un propriétaire a plusieurs chats, ses informations sont **dupliquées dans chaque chat**.
* Toute modification (ex. changement de téléphone) doit être faite **dans tous les chats**, ce qui peut provoquer **incohérence et erreurs**.
* Le chat gère des informations qui **ne lui appartiennent pas réellement**, ce qui va à l’encontre des principes de la POO.

---
#### Problème 1 : duplication

```
ChatV2 c1 = new ChatV2("Milo", 2, "Dupont", "Jean", "0600000000");
ChatV2 c2 = new ChatV2("Luna", 1, "Dupont", "Jean", "0600000000");
```
Les informations du propriétaire sont copiées dans chaque chat.

---

❓ **Question :**

> Que se passe-t-il si le téléphone change ?

✔️ Réponse : Il faut modifier tous les chats du propriétaire!

⚠️ Risque :
>  * Chat 1 : Milo, 2, Dupont, Jean, <span style={{ color: 'red' }}>0600000000</span>
>  * Chat 1 : Milo, 1, Dupont, Jean, <span style={{ color: 'red' }}>0600000001</span>

👉 Incohérence des données: Le numéro de téléphone d’un même propriétaire peut varier d’un chat à l’autre
________________________________________

#### Problème 2 : Responsabilité

Un principe fondamental en POO :
Une classe doit gérer uniquement les informations qui lui appartiennent.

Un Chat doit gérer :
>  * Son nom
>  * Son âge

❓ **Question :**

> Est-ce son rôle de gérer toutes les informations du propriétaire ?

✔️ Réponse : Non. On mélange deux entités différentes.

________________________________________

### ✅ Deuxième solution : Identifier l’entité métier `Prioprietaire`

Dans la réalité :
>  * Un propriétaire existe indépendamment du chat
>  * Il peut posséder plusieurs chats
>  * Il possède ses propres informations

👉 Conclusion logique : Le propriétaire doit devenir une classe


![](@site/static/img/R13/proprietaire.png)


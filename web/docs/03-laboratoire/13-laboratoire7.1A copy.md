---
title: Modelisation
---
# 🧪 Labo 7.1A – Modelisation

---

## 🎯 Objectifs 

* identifier les **classes d’un système** ;
* analyser et modéliser les **relations entre les classes**;
* déterminer les **cardinalités des relations** ;
* élaborer un **diagramme de classes** représentant le modèle ;
* **implémenter** le diagramme de classes en **C#**.
---

# 🟢 Exercice : Gestion de comptes bancaires

Une banque souhaite développer une application permettant de gérer les **clients** et leurs **comptes bancaires**.

**Description des données**

* Chaque **client** possède les informations suivantes :
    * un **nom**
    * un **prénom**
* Chaque **compte bancaire** possède :
    * un **numéro de compte**
    * un **solde**

**Règles métier**
* Un **client** peut posséder **plusieurs comptes bancaires**.
* Chaque **compte bancaire** appartient à **un seul client**.

Les classes **Client** et **Compte** sont déjà représentées dans ce diagramme de classes simplifié. Chaque classe est représentée par son nom seulement pour des raisons de simplification.

![diagramme de classes simplifié](@site/static/img/R13/compte.png)

**Implémentation des deux classes en C#**

```csharp
public class Client
{
    public string Nom { get; private set; }
    public string Prenom { get; private set; }        
    public Client(string nom, string prenom)
    {
        Nom = nom;
        Prenom = prenom;            
    }
 }
```

```csharp
public class Compte
{
    public string Numero { get; private set; }
    public double Solde { get; private set; }
    public Compte(string numero, double solde)
    {
        Numero = numero;
        Solde = solde;
    }
    public void Deposer(double montant)
    {
       Solde+= montant;
    }
    public void Retirer(double montant)
    {
        Solde -= montant;
    }
}
```
---


## Travail demandé
En vous basant sur les regles métier :
1. Compléter le  **diagramme de classes** et :
    * Indiquer les **relations** entre ces classes.
    * Préciser les **cardinalités** de chaque relation.
3. Dans quelle classe devrait-on utiliser une **liste d’objets** (`List<T>`) ?

---

## Indice

Réfléchissez à la question suivante :

> Combien de **comptes** un client peut-il posséder ?

---

# 🟢 Exercice : Gestion d’un département

On souhaite développer une application permettant de gérer les **départements**, les **professeurs** et les **cours** dans notre Cegep.
* Chaque **département** possède un **nom** et regroupe plusieurs **professeurs**.
* Chaque **professeur** possède un **nom** et appartient à un **département**.
* Chaque **cours** possède un **titre** et un **code**.

---

## 1️⃣ Premier besoin

Dans une première version du système, on considère que :

* un **professeur** peut enseigner **plusieurs cours** ;
* chaque **cours** est enseigné par **un seul professeur**.

---

### Travail demandé
1. Identifier les **classes** nécessaires pour modéliser ce système.
2. Proposer un **diagramme de classes** et :
    * Indiquer les **relations** entre ces classes.
    * Préciser les **cardinalités** de chaque relation.
3. Dans quelle classe devrait-on utiliser une **liste d’objets** (`List<T>`) ?
---

## 2️⃣ Deuxième besoin (évolution du système)

Dans une nouvelle version du système, le Cegep décide que certains **cours peuvent être enseignés par plusieurs professeurs**.

---

### Travail demandé

1. Modifier votre **diagramme de classes** afin de tenir compte de ce nouveau besoin.
2. Indiquer les **nouvelles cardinalités** entre les classes.
3. Expliquer brièvement les **modifications apportées au modèle**.
4. Au besoin, dans quelle classe devrait-on utiliser une **liste d’objets** (`List<T>`) ?
---

# 🟢 Exercice : Panier d’achat

On souhaite modéliser une partie simplifiée d’une application de commerce en ligne. Dans cette application, un **panier** permet de regrouper les **produits** que l’on souhaite acheter.

* Chaque **produit** possède les informations suivantes :
    * un **nom**
    * un **prix**
* Un **panier** peut contenir plusieurs produits. Les produits ajoutés au panier restent dans celui-ci jusqu’à ce qu’ils soient retirés ou que le panier soit vidé.

---

## ❓ Questions

1. Quelles sont les **classes** nécessaires pour modéliser ce système ?
2. Proposer un **diagramme de classes** et :
    * Indiquer les **relations** entre ces classes.
    * Préciser les **cardinalités** de chaque relation.
3. Dans quelle classe devrait-on utiliser une **liste d’objets** (`List<T>`) ?

---

## 💡 Indice

Réfléchissez à la question suivante :

> Combien de **produits** un panier peut-il contenir ?

---

# 🟢 Exercice : Gestion d’une collection musicale

On souhaite développer une application permettant de gérer une **collection musicale**.

* Un **album** représente une œuvre musicale publiée par un **artiste**.
* Chaque album possède un **titre** et une **année de publication**.
* Un album est composé de plusieurs **chansons**.
* Chaque chanson possède un **titre** et une **durée** (en secondes).
* Les chansons font partie d’un album et sont associées à l’artiste qui les interprète.

---

## ❓ Questions

1. Quelles sont les **classes** nécessaires pour modéliser ce système ?
2. Proposer un **diagramme de classes** et :
    * Indiquer les **relations** entre ces classes.
    * Préciser les **cardinalités** de chaque relation.
3. Dans quelles classes faudrait-il utiliser une **liste d’objets** (`List<T>`) ?

---

## 💡 Indices

Réfléchissez aux questions suivantes :

* Combien de **chansons** peut contenir un album ?
* Une **chanson** appartient-elle à plusieurs albums ?
* Combien d’**albums** un artiste peut-il produire ?
---


---
title: Définition des classes
---

# 🧪 Labo 2.1 – Définition des classes

📎 **Référence** : [Instanciation objet](https://info.cegepmontpetit.ca/notions-csharp/documentation/instanciation-objet)

---
:::danger
Ce laboratoire doit être développé à l'aide du logiciel **Git**. Vous devrez **créer un nouveau dépôt dans GitHub** 
et **inviter votre professeur** en tant que collaborateur.

Voici le format du dépôt exigé: **H26-2P6-R03-MATRICULE**

Il devrait y avoir **un commit** pour **chaque** exercice.

:::
---
### Télécharger la solution contenant les différents exercices de ce laboratoire.

Disponible ici 👉 [Laboratoire2_1](../../static/files/laboratoires/Laboratoire2_1.zip)

---
## 🟢 Exercice 1 – AppCompteurHydro
### 🎯 Objectifs 
* Se familiariser avec le diagramme d'une classe
* Instancier et utiliser un objet
* Créer un menu console

### 🛠️ Instructions
Écrire un programme qui simule un compteur d'Hydro Québec. Ce compteur garde en mémoire la quantité de Kw/h consommé et permet même de compter
le coût de la consommation. Vous devrez instancier et utiliser la classe **`CompteurHydro`**.

Vous devrez compléter un menu en mode console permttant les actions suivantes:
- Consommer une quantité de Kw/h
- Afficher la consommation actuelle
- Afficher le coût de la consommation
- Quitter

### 📋 Structure de la classe
La classe que vous allez utiliser existe déjà et voici sa structure:

![](@site/static/img/R03/compteurHydro.png)
---

## 🟡 Exercice 2 – AppMontre
### 🎯 Objectifs 
* Créer une classe
* Se familiariser avec le diagramme d'une classe
* Instancier et utiliser un objet
* Créer un menu console

### 🛠️ Instructions
Vous devez écrire un programme qui simule une montre. Ce programme instancie une classe **`Montre`** qui permet de modifier les
heures, les minutes et les secondes. Il permet également de faire avancer le temps de la montre d'une seconde.

Ajoutez une nouvelle classe au projet nommée **`AppMontre`** qui correspond à la structure de la classe ci-bas.

### 📋 Structure de la classe
Voici la classe et sa structure que vous devrez créer:

![](@site/static/img/R03/montre.png)

---

### 📝 Description de la classe

#### Champs

* **m_heures**
  Stocke l’heure courante de la montre, comprise entre 0 et 23.
* **m_minutes**
  Stocke les minutes courantes de la montre, comprises entre 0 et 59.
* **m_secondes**
  Stocke les secondes courantes de la montre, comprises entre 0 et 59.

---

#### Propriétés

* **Heures**
  Permet d’obtenir la valeur actuelle des heures de la montre.
* **Minutes**
  Permet d’obtenir la valeur actuelle des minutes de la montre.
* **Secondes**
  Permet d’obtenir la valeur actuelle des secondes de la montre.

---

#### Constructeurs

* **Constructeur sans paramètre**
  Initialise une nouvelle montre à l’heure **00 heures, 00 minutes et 00 secondes**.

* **Constructeur avec paramètres**
  Initialise une nouvelle montre avec une heure, des minutes et des secondes passées en paramètres.

---

#### Méthodes

* **Avancer une seconde**
  Augmente le temps courant d’une seconde.
  Gère automatiquement le passage des secondes aux minutes, des minutes aux heures, et le retour à zéro après 23 heures.

* **Temps courant**
  Retourne l’heure actuelle de la montre sous forme de texte formaté heures, minutes et secondes.

---



### ⭐ Exemple d'exécution

```
=== Menu Principal ===
1 - Avancer la montre d'une seconde
2 - Initialiser la montre à 0:00:00
3 - Initialiser la montre à 12:30:59
4 - Initialiser la montre à 12:59:59
5 - Initialiser la montre à 23:59:59
Q - Quitter
=======================
Veuillez sélectionner une option : 
```
---

## 🟡 Exercice 3 – AppThermostat
### 🎯 Objectifs 
* Créer une classe
* Se familiariser avec le diagramme d'une classe
* Instancier et utiliser un objet
* Créer un menu console

### 🛠️ Instructions
Vous devez écrire un programme qui simule un thermostat. Ce programme instancie un objet de la classe **`Thermostat`**. 
Il permet d'augmenter ou de diminuer la température d'un degrés à la fois. La température autorisée est 
entre 5 et 35 degrés Celcius.

Ajoutez une nouvelle classe au projet nommée **`AppThermostat`** qui correspond au schéma.

### 📋 Structure de la classe
Voici la classe et sa structure que vous devrez créer:

![](@site/static/img/R03/thermostat.png)

### ⭐ Exemple d'exécution

```
=== Menu Principal ===
1 - Augmenter la température
2 - Diminuer la température
3 - Température Maximale autorisée
4 - Température Minimale autorisée
Q - Quitter
=======================
Veuillez sélectionner une option : 
```
---
    
## 🔴 Exercice 4 – AppParcometre
### 🎯 Objectifs 
* Créer une classe
* Se familiariser avec le diagramme d'une classe
* Instancier et utiliser un objet
* Créer un menu console

### 🛠️ Instructions
Vous devez écrire un programme qui simule un parcomètre. Ce programme instancie un objet de la classe **`Parcometre`**. 
Il permet de gérer du temps de stationnement à partir d’argent inséré par un utilisateur.

Ajoutez une nouvelle classe **`Parcometre`** au projet nommée **`AppParcometre`**.

### 📋 Structure de la classe

Voici la classe et sa structure que vous devrez créer:

![](@site/static/img/R03/parcometre.png)

### 📝 Description de la classe

#### Constantes

* **Coût par minute**
  Montant fixe, en cents, représentant le prix d’une minute de stationnement.
* **Montant minimum**
  Montant minimal d’argent pouvant être inséré dans le parcomètre.

---

#### Champs

* **Minutes restantes**
  Nombre de minutes de stationnement encore disponibles avant l’infraction.

* **Montant total**
  Somme totale d’argent, en cents, insérée dans le parcomètre depuis son initialisation.

---

#### Propriétés

* **Montant total**
  Permet d’obtenir le montant total d’argent actuellement contenu dans le parcomètre.
---

#### Constructeurs

* **Constructeur du parcomètre**
  Crée un nouveau parcomètre sans argent et sans temps de stationnement au départ.
---

#### Méthodes

* **Insérer monnaie**
  Permet à l’utilisateur d’ajouter un montant d’argent au parcomètre.
  Le montant inséré est converti en minutes de stationnement selon le coût par minute, et ajouté au temps restant.
* **Consommer une minute de temps**
  Simule l’écoulement du temps en retirant une minute au temps de stationnement restant.
* **Obtenir le temps restant**
  Retourne le temps de stationnement restant sous la forme heures et minutes.
* **Est en infraction**
  Indique si le véhicule est en situation d’infraction, c’est-à-dire lorsque le temps de stationnement est écoulé.

---
### ⭐ Exemple d'exécution

```
=== Menu Principal ===
1 - Est en infraction?
2 - Obtenir le temps restant
3 - Inserer de la monnaie
4 - Avancer le temps d'une minute
Q - Quitter
=======================
Veuillez sélectionner une option : 
```
---

## 🔴 Exercice 5 – AppMultiThermostat
### 🎯 Objectifs 
* Créer une classe
* Se familiariser avec le diagramme d'une classe
* Instancier et utiliser un objet
* Créer un menu console

### 🛠️ Instructions
Vous devez écrire un programme qui simule **trois** thermostat!

Ce programme instancie 3 objets de la classe **`Thermostat`**, car il permet de contrôler la température dans 3 emplacements différents,
soit : la chambre, la cuisine ou encore le salon. Une quatrième variable va servir uniquement à référer sur le Thermostat courant.
Au départ le thermostat courant est celui de la chambre, ensuite l'utilisateur peut au besoin le changer pour celui de la cuisine ou du salon.
Les options pour augmenter ou diminuer la température affecte uniquement le Thermostat courant.   

Ajoutez une nouvelle classe au projet nommée **`AppMultiThermostat`** qui correspond au schéma.

### 📋 Structure de la classe
Voici la classe et sa structure que vous devrez créer:

![](@site/static/img/R03/thermostat.png)

### ⭐ Exemple d'exécution

```
=== Menu Principal ===
1 - Augmenter la température du Thermostat courant
2 - Diminuer la température du Thermostat courant
3 - Température Maximale autorisée
4 - Température Minimale autorisée
5 - Fixe le Thermostat courant à celui de la chambre
6 - Fixe le Thermostat courant à celui de la cuisine
7 - Fixe le Thermostat courant à celui du salon
Q - Quitter
=======================
Veuillez sélectionner une option : 
```
    
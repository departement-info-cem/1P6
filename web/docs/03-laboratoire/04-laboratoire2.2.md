---
title: Définition des classes (Encapsulation)
---

# 🧪 Labo 2.2 – Définition des classes (Encapsulation)

📎 **Référence** : [Instanciation objet](https://info.cegepmontpetit.ca/notions-csharp/documentation/instanciation-objet)

---
:::danger
Ce laboratoire doit être développé à l'aide du logiciel **Git**. Vous devrez **créer un nouveau dépôt dans GitHub** 
et **inviter votre professeur** en tant que collaborateur.

Voici le format du dépôt exigé: **H26-2P6-R04-MATRICULE**

Il devrait y avoir **un commit** pour **chaque** exercice.

:::
---
### Télécharger la solution contenant les différents exercices de ce laboratoire.

Disponible ici 👉 [Laboratoire2_2](../../static/files/laboratoires/Laboratoire2_2.zip)

---
    
## 🟢 Exercice 1 – AppRobot
### 🎯 Objectifs 
* Créer une classe
* Se familiariser avec le diagramme d'une classe
* Instancier et utiliser un objet
* Créer un menu console

### 🛠️ Instructions
Dans cet exercice, vous devez créer une classe Robot qui permet de simuler le fonctionnement d’un robot mobile.
Le robot peut démarrer, s’arrêter, accélérer, ralentir et afficher son état. Sa vitesse maximale est de 10 km/h.

Ajoutez une nouvelle classe **`Robot`** au projet nommée **`AppRobot`**.

### 📋 Structure de la classe

Voici la classe et sa structure que vous devrez créer:

![](@site/static/img/R04/robot.png)

### 📝 Description de la classe `Robot`

#### Constantes

* **Vitesse maximale (`VITESSE_MAX`)**
  Valeur maximale, en km/h, que le robot peut atteindre.
* **Nom par défaut (`NOM_PAR_DEFAUT`)**
  Nom attribué automatiquement au robot lorsque le nom fourni est invalide ou absent.
---
#### Champs

* **Vitesse actuelle (`m_vitesseActuelle`)**
  Représente la vitesse courante du robot en km/h.
* **Robot allumé (`m_estAllume`)**
  Représente l'état du robet (allumé ou non).
---
#### Propriétés

* **Nom**
  Permet d’obtenir et modifier le nom du robot.
  Cette propriété est en lecture seule à l’extérieur de la classe.
* **Vitesse actuelle (`VitesseActuelle`)**
  Permet d’obtenir et modifier la vitesse courante du robot.
  Cette propriété est en lecture seule à l’extérieur de la classe.
* **Robot allumé (`EstAllume`)**
  Permet d’obtenir et modifier l'état du robot (allumé ou non).
  Cette propriété est en lecture seule à l’extérieur de la classe.
* **En mouvement (`EnMouvement`)**
  Indique si le robot est en déplacement, c’est-à-dire lorsque sa vitesse est supérieure à zéro.
---
#### Constructeurs

* **Constructeur sans paramètre**
  Crée un robot nommé *Anonyme*, éteint et avec une vitesse initiale de 0 km/h.
* **Constructeur avec paramètre**
  Crée un robot avec le nom fourni en paramètre.
  Si le nom contient moins de trois caractères, le nom par défaut est utilisé.
  Le robot est éteint et la vitesse est initialisée à 0 km/h.

---

#### Méthodes

* **`Demarrer`**
  Allume le robot s’il est actuellement éteint.
* **`Arreter`**
  Éteint le robot et remet sa vitesse à 0 km/h.
* **`Accelerer`**
  Augmente la vitesse du robot selon la valeur fournie, sans dépasser la vitesse maximale.
* **`Ralentir`**
  Diminue la vitesse du robot selon la valeur fournie, sans descendre sous 0 km/h.
  Cette méthode fonctionne uniquement si le robot est allumé.
* **`Infos`**
  Retourne une description textuelle de l’état du robot, incluant son nom, sa vitesse, l’état du robot et son mouvement.
 **Exemple :** Robot RoboCup, Vitesse actuelle: 6 km/h, Allumé: Oui, En mouvement: Oui

---
### ⭐ Exemple d'exécution

```
=== MENU ROBOT ===
1 - Créer un robot
2 - Démarrer
3 - Arreter
4 - Accélérer
5 - Ralentir
6 - Afficher les infos du robot
7 - Quitter
=======================
Veuillez sélectionner une option : 
```
---


## 🟢 Exercice 2 – Personnage
### 🎯 Objectifs 
* Créer une classe
* Se familiariser avec le diagramme d'une classe
* Instancier et utiliser un objet
* Créer un menu console

### 🛠️ Instructions
Dans cet exercice, Vous devez définir une classe Personnage qui représente un aventurier dans un jeu.
Un personnage possède un nom, un âge, une classe (type), des points de vie et des statistiques. Il peut recevoir des dégâts, se soigner, calculer sa puissance d’attaque et afficher sa fiche.

Dans ce jeu d’aventure, chaque personnage appartient à une **classe** :

* **G** = Guerrier
* **M** = Mage
* **V** = Voleur

Selon sa classe (et parfois son âge), ses statistiques varient.

Ajoutez une nouvelle classe **`Personnage`** au projet nommée **`AppPersonnage`**.

### 📋 Structure de la classe

Voici la classe et sa structure que vous devrez créer:

![](@site/static/img/R04/personnage.png)

### 📝 Description de la classe `Personnage`

#### Constantes

Votre classe doit contenir les constantes suivantes :

* `PV_MAX = 100`
* `AGE_MIN = 12`
* `AGE_MAX = 80`
* `NOM_PAR_DEFAUT = "Anonyme"`
* `AGE_PAR_DEFAUT = 18`
* `CLASSE_PAR_DEFAUT = 'G'`

---


#### Champs

* **`m_nom`**: Contient le nom du personnage. Il permet d’identifier l’aventurier dans le jeu.
* **`m_age`**: Représente l’âge du personnage en années. Cette valeur influence ses statistiques.
* **`m_classe`**: Indique la classe du personnage :

  * `G` → Guerrier
  * `M` → Mage
  * `V` → Voleur

  La classe détermine ses compétences principales.

* **`m_pointsDeVie`**: Représente les points de vie actuels du personnage. Lorsqu’ils atteignent 0, le personnage est considéré comme mort.

---
#### Propriétés

* **`Nom`**
  Permet d’obtenir et modifier le nom du personnage.
  Cette propriété est en lecture seule à l’extérieur de la classe afin de protéger l’identité du personnage.

* **`Age`**
  Permet d’obtenir et modifier l’âge du personnage.
  La modification de cette valeur est contrôlée par la classe pour garantir qu’elle respecte les limites autorisées.

* **`Classe`**
  Permet d’obtenir et modifier la classe du personnage (Guerrier, Mage ou Voleur).
  Cette propriété est protégée contre les modifications directes afin d’assurer la cohérence des statistiques.

* **`PointsDeVie`**
  Permet d’obtenir et mettre à jour le nombre de points de vie actuels du personnage.
  Cette valeur est modifiée uniquement par les méthodes à l'interieur de de la classe (dégâts, soins) afin d’éviter des valeurs invalides.

* **`Force`**
  Permet d'obtenir et modifier la puissance physique du personnage.
  Cette statistique influence principalement les capacités de combat des guerriers.
  Elle est définie automatiquement selon la classe et l’âge du personnage et ne peut pas être modifiée directement de l’extérieur.

* **`Intelligence`**
  Permet d'obtenir les capacités mentales et magiques du personnage.
  Cette statistique influence surtout les compétences des mages.
  Elle est calculée automatiquement lors de la création du personnage et est protégée contre toute modification externe.

* **`Vitesse`**
Permet d'obtenir la rapidité du personnage lors de ses déplacements et de ses actions.
Cette valeur est déterminée automatiquement selon sa classe : 
  * `G` (Guerrier) → 2
  * `M` (Mage) → 3
  * `V` (Voleur) → 4
  * Autre → 2

* **`EstVivant`**  
  Permet d'obtenir l'état du personnage (en vie ou non). Elle retourne :
  * `true` si `PointsDeVie` est supérieur à 0  
  * `false` si `PointsDeVie` est égal à 0

  Cette propriété permet de vérifier si le personnage peut encore combattre ou agir.

* **`StatPrincipale`**
Permet d'obtenir la statistique la plus importante du personnage selon sa classe.
Elle est utilisée notamment pour calculer la puissance d’attaque.
  La valeur retournée dépend de la classe :
    * `G` (Guerrier) → `Force`
    * `M` (Mage) → `Intelligence`
    * `V` (Voleur) → `Vitesse`

  Cette propriété permet d’adapter automatiquement le comportement du personnage à son rôle dans le jeu.

---
#### Constructeurs

* **Constructeur sans paramètre**
  Crée un personnage nommé *Anonyme* avec des valeurs par défaut. Puis il doit appeler une méthode `calculerStatistiques()`.
* **Constructeur avec paramètre**
  Crée un personnage avec les valeurs fournies en paramètre.
    * Si `nom` est vide → utiliser le nom par défaut
    * Si `age` n’est pas entre `AGE_MIN` et `AGE_MAX` → utiliser l’âge par défaut
    * Si `classe` n’est pas `G`, `M` ou `V` → utiliser la classe par défaut

   Ensuite, appeler `calculerStatistiques()`.

---

#### Méthodes

* **`recevoirDegats`**
  * Si `degats < 0` → ne fait rien
  * Diminue les points de vie
  * Les PV ne doivent jamais descendre sous 0
* **`soigner`**
  * Si `points < 0` → ne fait rien
  * Augmente les PV
  * Les PV ne doivent jamais dépasser `PV_MAX`
* **`PuissanceAttaque`**
  * Si le personnage est mort → retourne 0
  * Sinon → retourne `StatPrincipale * 2`
* **`Fiche`**
  Retourne une description textuelle du personnage.

 **Exemple :**
```
   Nom           : Toto
   Âge           : 25
   Classe        : G
   PV            : 20/100
   Force         : 10
   Intelligence  : 0
   Vitesse       : 2
   Stat principale : 10
   État          : Vivant
```

* **`calculerStatistiques`**
  Cette méthode initialise les statistiques selon la classe :

    * **G** : Intelligence = 5, Force = 15, PV = 20
    * **M** : Intelligence = 18, Force = 5, PV = 12
    * **V** : Intelligence = 10, Force = 10, PV = 15

  Ensuite, selon l’âge :

    * Si `Age > 40` :

       * Intelligence += 10
       * Force += 10
       * PointsDeVie -= 10
    * Sinon :

       * Intelligence -= 5
       * Force -= 5

---
### ⭐ Exemple d'exécution

```
=== MENU PERSONNAGE ===
1 - Créer un personnage
2 - Afficher la fiche
3 - Recevoir des dégâts
4 - Se soigner
5 - Calculer la puissance d'attaque
Q - Quitter
=======================
Veuillez sélectionner une option : 
```

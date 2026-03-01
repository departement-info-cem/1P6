---
title: MicroOnde
---

# 🟡 Labo 5.1B – Formatif

## 🎯 Objectifs 

1. **Comprendre et appliquer la notion de classe en C#**
   * Définir des **champs privés**, des **propriétés** et des **méthodes**.
   * Utiliser un **constructeur** pour initialiser l’objet.

2. **Mettre en œuvre l’encapsulation**
   * Protéger les données internes de l’objet via des propriétés publiques et des champs privés.
   * Contrôler l’accès et la modification des données selon les règles définies.

3. **Appliquer des comportements à l’objet**
   * Définir des méthodes qui font évoluer l’état interne de l’objet.
   * Implémenter des **propriétés calculées** pour obtenir des informations dérivées de l’état.

---

## 🌀 Contexte
Vous devez créer une classe MicroOnde qui représente un micro-ondes utilisé dans un établissement (ex. cafétéria). Le micro-ondes peut démarrer une cuisson selon un mode et un nombre de minutes, et permet de calculer la consommation en watts pour une cuisson.

---
:::success
## 🧪 Directives pour utiliser les tests
* Des tests sont fournis pour vous aider à valider votre travail. ils ne sont **pas exhaustifs** et ne remplacent pas **vos propres tests**, nécessaires pour assurer que votre code est correct.
* Tous les tests sont regroupés dans **un fichier séparé** du programme principal (`TestsMicroOnde.cs`).
* Pour utiliser un test, vous devez d’abord **définir la classe demandée** en respectant exactement sa définition.
* **Décommentez ensuite le test correspondant**.
* **Démarrez l’application** et observez le résultat affiché dans la console.
* ⚠️ Si le programme ne compile pas après avoir décommenté un test, cela signifie que la classe n’est **pas définie comme demandé**.


La ligne à décommenter pour activer les tests se trouvent au **début** du fichier (`TestsMicroOnde.cs`).
```
//#define TEST_CLASSE_MICR_OONDES
```
:::

---

## 📊 Diagramme de classes


![](@site/static/img/R09/micro-onde.png)


---

## 🔢 Énumération `ModeCuisson`

Représente les différents modes de cuisson disponibles sur le micro-ondes.

* **Decongelation** : mode à faible puissance pour décongeler les aliments.
* **Rechauffage** : mode standard pour réchauffer les plats.
* **Grill** : mode à forte puissance pour griller ou dorer les aliments.

---
## Description de la classe `MicroOnde`

## 📌 Constantes

* **EMPLACEMENT_PAR_DEFAUT**
  Emplacement utilisé si aucun emplacement valide n’est fourni (Cafétéria par défaut).

* **WATTS_DECONGELATION**
  Puissance consommée par minute en mode décongélation (300).

* **WATTS_RECHAUFFAGE**
  Puissance consommée par minute en mode réchauffage (800).

* **WATTS_GRILL**
  Puissance consommée par minute en mode grill (1200).

* **MINUTES_PAR_DEFAUT**
  Durée utilisée lorsque le nombre de minutes fourni est invalide (1 minute).

* **MODE_PAR_DEFAUT**
  Mode de cuisson utilisé par défaut lors du démarrage (Rechauffage).

---

## 🔒 Champs

* **m_modeCuisson**
  Stocke le mode de cuisson actuellement utilisé par le micro-ondes.

* **m_emplacement**
  Contient l’emplacement physique du micro-ondes (ex. cafétéria).

* **m_minutesCuisson**
  Représente la durée de cuisson en minutes.

---

## 🧩 Propriétés

### `Emplacement`

Permet d’obtenir ou de modifier l’emplacement du micro-ondes.
Si la valeur fournie est nulle ou vide, l’emplacement par défaut est utilisé.

---

### `ModeCuisson`

Permet de connaître le mode de cuisson actuel.
La modification est contrôlée et ne peut se faire qu’à l’intérieur de la classe.

---

### `EstEnMarche`

Indique si le micro-ondes est actuellement en fonctionnement.

* `true` : une cuisson est en cours
* `false` : le micro-ondes est arrêté

---

### `MinutesCuisson`

Permet d’obtenir ou de modifier la durée de cuisson.
Si une valeur négative est fournie, la durée par défaut est utilisée.

---

### `ConsommationWattsParCuisson`

Retourne la consommation totale en watts pour la cuisson en cours.
Cette valeur est calculée automatiquement en fonction du mode et du nombre de minutes.

---

## 🏗️ Constructeurs

### `MicroOnde()`

Crée un micro-ondes avec :

* le mode par défaut,
* aucune cuisson en cours,
* une durée initiale de 0 minute,
* l’emplacement par défaut.

---

### `MicroOnde(string emplacement)`

Crée un micro-ondes avec l’emplacement fourni en paramètre.
Si l'emplacement n'est pas valide (null ou un texte vide), l’emplacement par défaut est utilisé.

---

## ⚙️ Méthodes

### `ObtenirWattsParMinute(ModeCuisson pMode)`

Retourne la puissance consommée par minute selon le mode de cuisson fourni.

---

### `Demarrer(int pMinutes)`

Démarre une cuisson en utilisant le mode par défaut et la durée fournie.

---

### `Demarrer(ModeCuisson pMode, int pMinutes)`

Démarre une cuisson en spécifiant le mode et la durée.
Si la durée est négative, la durée par défaut est utilisée.

---

### `Arreter()`

Arrête la cuisson en cours et met le micro-ondes hors fonctionnement.

---

### `ChangerModeCuisson(ModeCuisson pMode)`

Change le mode de cuisson utilisé par le micro-ondes.


---


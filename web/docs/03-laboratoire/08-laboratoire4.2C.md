---
title: Météo
---

# 🟡 Labo 4.2 – Historique météo

### 🎯 Objectifs 

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

### 🌀 Contexte

Dans cet exercice, votre mission est : **implémenter une classe `HistoriqueMeteo`** capable de :

* Enregistrer les **températures** d’une région donnée, en conservant un nombre limité de mesures.
* Calculer automatiquement les **statistiques** : moyenne, minimum et maximum.
* Compter combien de mesures dépassent un **seuil donné**.
* Comparer la moyenne avec un l'historique d'une autre région.
* Fournir une **copie indépendante** (clone) d’un historique.
* Produire un **résumé** de l’historique sous forme de texte.

---

### 📊 Diagramme de classes


![](@site/static/img/R08/historique_meteo.png)

---

### Description de la classe `HistoriqueMeteo`

---

### Constantes

| Constante        | Description                                               |
| ---------------- | --------------------------------------------------------- |
| `NB_MESURES_MAX` | Nombre maximal de mesures conservées (7).                 |
| `NOM_PAR_DEFAUT` | Nom par défaut si la région n’est pas valide ("Inconnu"). |

---

### Champs privés

* `m_temperatures` : liste interne des températures enregistrées.

---

### Propriétés publiques

| Propriété      | Description                                     |
| -------------- | ----------------------------------------------- |
| `Region`       | Nom de la région (lecture seule à l’extérieur). |
| `Temperatures` | Liste des températures (lecture et écriture).   |
| `Moyenne`      | Moyenne des températures (lecture seule).       |
| `Minimum`      | Température la plus basse (lecture seule).      |
| `Maximum`      | Température la plus haute (lecture seule).      |

---

### Constructeurs

* `HistoriqueMeteo()` : crée un historique vide avec la région par défaut.
* `HistoriqueMeteo(string region)` : crée un historique vide pour la région donnée (nom valide si ≥ 3 caractères, sinon valeur par défaut).

---

### Méthodes publiques

1. **`AjouterTemperature(double temperature)`**

   * Ajoute une nouvelle mesure dans l’historique.
   * Si le nombre maximal de mesures est atteint (`NB_MESURES_MAX`), supprime la plus ancienne mesure.

2. **`CompterAuDessus(double seuil)`**

   * Retourne le nombre de températures supérieures au seuil spécifié.

3. **`Clone()`**

   * Crée une **copie indépendante** de l’historique, incluant toutes les mesures actuelles.

4. **`ComparaisonMoyenne(HistoriqueMeteo autre)`**

   * Compare la moyenne des températures avec un autre historique.
   * Retourne `1` si la moyenne est supérieure, `-1` si inférieure, `0` si égale ou si l’autre est null.

5. **`Historique()`**

   * Retourne une chaîne affichant le nom de la région et les températures enregistrées.

---


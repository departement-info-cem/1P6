---
title: Gestion d'une buanderie - Secheuse
---

# 🧪 Labo 4.2B – La Sécheuse Magique


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




### 🌀 Contexte

Dans cet exercice, votre mission est : **implémenter une sécheuse simplifiée** capable de :

* Gérer différents **cycles de séchage** (`BlancsCouleurs`, `Synthetiques`, `Delicats`) avec les températures correspondantes.
* Calculer automatiquement le **temps de séchage** en fonction du montant inséré :

  * 2 $ pour un **cycle de base** de 35 minutes
  * Bloc supplémentaire de 25 ¢ = 5 minutes supplémentaires
* **Démarrer et arrêter** la machine selon le montant disponible et le temps restant.
* Gérer le **montant total** et les **minutes restantes** pour le cycle en cours.

---

### 📊 Diagramme de classes

![](@site/static/img/R08/secheuse.png)

---

### Description de la classe `Secheuse`


### Constantes

| Constante                | Description                                                                           |
| ------------------------ | ------------------------------------------------------------------------------------- |
| `MINUTES_DE_BASE`        | Durée de base en minutes pour le montant minimum (35 min pour 2 $).                   |
| `MONTANT_DEPART_MINIMUM` | Montant minimum requis pour démarrer (2 $ = 200 cents).                               |
| `PRIX_PAR_BLOC`          | Valeur d’un bloc supplémentaire pour calculer les minutes supplémentaires (25 cents). |
| `MINUTES_PAR_BLOC`       | Nombre de minutes ajoutées par bloc supplémentaire (5 min).                           |
| `TEMP_BLANCS`            | Température pour le cycle `BlancsCouleurs` (75 °C).                                   |
| `TEMP_SYNTHETIQUES`      | Température pour le cycle `Synthetiques` (65 °C).                                     |
| `TEMP_DELICATS`          | Température pour le cycle `Delicats` (55 °C).                                         |

---

### Champs privés

* `m_cycle` : cycle actuel choisi (`CycleSechage`)
* `m_montantTotal` : montant inséré en cents
* `m_minutesRestantes` : minutes restantes pour le cycle en cours

---

### Propriétés publiques

| Propriété          | Description                                                                                     |
| ------------------ | ----------------------------------------------------------------------------------------------- |
| `Cycle`            | Lecture et définition du cycle actuel. La définition met à jour la température automatiquement. |
| `EstEnMarche`      | Indique si la machine fonctionne.                                                               |
| `MinutesRestantes` | Minutes restantes pour le cycle (non négatif).                                                  |
| `MontantTotal`     | Montant total inséré (non négatif).                                                             |
| `MontantSuffisant` | Calculée : vrai si le montant minimum pour démarrer est atteint.                                |
| `Temperature`      | Température actuelle selon le cycle choisi.                                                     |
| `MinutesEcoulees`  | Prévue pour indiquer le temps écoulé (non encore implémentée).                                  |

---

### Constructeur

* `Secheuse()` : initialise la sécheuse en appelant `Reinitialiser()`
---

### Méthodes publiques

1. **`ChoisirCycle(CycleSechage pCycle)`**

   * Change le cycle sélectionné (si la machine n’est pas en marche)
   * Met à jour automatiquement la température

2. **`AjouterMontant(int pMontantCents)`**

   * Ajoute 25 ¢ ou 1 $ pour obtenir du temps de séchage
   * Si le montant atteint le minimum pour la première fois : minutes de base + minutes supplémentaires
   * Si le minimum déjà atteint : ajoute seulement les minutes correspondant aux blocs supplémentaires

3. **`ConsommerUneMinute()`**

   * Décrémente `MinutesRestantes` de 1
   * Si `MinutesRestantes` = 0, arrête la machine

4. **`Demarrer()`**

   * Démarre la machine si le montant minimum est atteint et qu’il reste du temps

5. **`Arreter()`**

   * Arrête la machine immédiatement

6. **`Reinitialiser()`**

   * Remet la machine à l’état initial :

     * Cycle par défaut (`BlancsCouleurs`)
     * Machine arrêtée
     * Montant et minutes à 0
     * Température définie selon le cycle

---

### Enum : `CycleSechage`

| Valeur           | Description / Type de linge     | Température       |
| ---------------- | ------------------------------- | ----------------- |
| `BlancsCouleurs` | Linge blanc ou coloré résistant | Haute (≈ 75 °C)   |
| `Synthetiques`   | Linge synthétique ou fragile    | Moyenne (≈ 65 °C) |
| `Delicats`       | Linge délicat ou fragile        | Basse (≈ 55 °C)   |

* Utilisée par la classe pour :

  * Déterminer automatiquement la température
  * Permettre à l’utilisateur de sélectionner le cycle approprié

---

### Remarques

* Les valeurs de l’énum sont des **constantes implicites** (0, 1, 2) correspondant à l’ordre de déclaration.
* La classe associe à chaque cycle une température via les constantes `TEMP_BLANCS`, `TEMP_SYNTHETIQUES`, `TEMP_DELICATS`.

---
### ⭐ Tests pour validation

Les méthodes de tests fournies dans la classe `Program` vous permettent de **valider certaines fonctionnalités de votre classe `Secheuse`** : constructeur, propriétés, méthodes publiques et comportements principaux.

⚠️ **Important** :

* Ces tests **ne sont pas exhaustifs** et ne couvrent pas tous les cas possibles.
* Ils servent **uniquement de guide** pour vérifier si votre implémentation fonctionne correctement sur les scénarios principaux.
* Vous êtes encouragés à **ajouter vos propres tests** pour explorer d’autres situations, comme des montants invalides, l’ajout de plusieurs blocs, ou le comportement de la machine lorsqu’elle est déjà en marche.

```
=== TEST PROPRIÉTÉ : Cycle / Temperature ===
Cycle : Synthetiques | Température : 65 (attendu: 65)
Cycle : Delicats | Température : 55 (attendu: 55)
Cycle : BlancsCouleurs | Température : 75 (attendu: 75)

=== TEST MÉTHODE : AjouterMontant(int) ===
Après 1$ -> Minutes : 0 (attendu: 0)
Après 2$ -> Minutes : 35 (attendu: 35)
Après 2.25$ -> Minutes : 40 (attendu: 40)

=== TEST MÉTHODE : Demarrer() ===
Sans argent -> EstEnMarche : False (attendu: False)
Avec montant suffisant -> EstEnMarche : True (attendu: True)

=== TEST MÉTHODE : ConsommerUneMinute() ===
Minutes initiales : 0 (attendu: 35)
Après 1 minute -> 0 (attendu: 34)
Après fin -> EstEnMarche : False (attendu: False)

=== TEST MÉTHODE : Reinitialiser() ===
MontantTotal : 0 (attendu: 0)
MinutesRestantes : 0 (attendu: 0)
Cycle : BlancsCouleurs (attendu: BlancsCouleurs)
Temperature : 75 (attendu: 75)
EstEnMarche : False (attendu: False)


FIN DES TESTS
```


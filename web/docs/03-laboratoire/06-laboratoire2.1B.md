---
title: B - Conditions, assignation composées
---

# 🧪 Labo 2.1B – Conditions, assignation composées


---



## 🟢 J'applique — Conditions et expressions logiques

### Exercice 1 – Besoin de café ☕

**🎯 Objectif :** utiliser une variable booléenne avec une structure `if`.

#### 📋 Besoin

Une application personnelle doit déterminer si une personne a besoin d'une pause-café.

La personne est considérée comme fatiguée lorsque son état indique qu'elle est fatiguée.

Lorsque c'est le cas, l'application affiche :

```text
Voici la solution : café
```

#### 🧩 Démarche de résolution

1. Créer une variable appelée `jeSuisFatigue` pour représenter l'état de la personne. **Comme cet état peut seulement être vrai ou faux, utiliser le type `bool`.**
2. Attribuer à `jeSuisFatigue` la valeur `true`.
3. **Utiliser une structure `if` pour vérifier si `jeSuisFatigue` est vrai (`true`).**

    * Dans le bloc du if, afficher `Voici la solution : café`.




#### 📝 Pseudo-code

```text
Déclarer jeSuisFatigue comme booléen
jeSuisFatigue ← vrai

SI jeSuisFatigue ALORS
    Afficher "Voici la solution : café"
FIN SI
```


#### 🧪 Test

| `jeSuisFatigue` | Résultat attendu           |
| --------------- | -------------------------- |
| `true`          | `Voici la solution : café` |

---

### 🟢 Exercice 2 – Contrôle de majorité 🎂

**🎯 Objectif :** utiliser une comparaison dans une structure `if`.

#### 📋 Besoin

Un système doit déterminer si une personne est majeure. 

Une personne âgée de **18 ans ou plus** est considérée comme majeure.

Le programme demande l'âge de l'utilisateur et affiche `Tu es majeur.` lorsque cette condition est respectée..

#### 🧩 Démarche de résolution

1. Demander l'âge de l'utilisateur et conserver la réponse dans une variable entière.
2. **Utiliser une structure `if` pour vérifier que l'âge est supérieur ou égal à `18`.**.

    * Dans le bloc du if, afficher `Tu es majeur.`.   

#### 🧪 Tests

| Âge | Résultat attendu |
| --: | ---------------- |
|  19 | `Tu es majeur.`  |
|  18 | `Tu es majeur.`  |
|  16 | Aucun message    |

---

### 🟢 Exercice 3 – Le mot magique 🪄

**🎯 Objectif :** comparer des chaînes de caractères avec `==` et utiliser `if` / `else`.

#### 📋 Besoin

Une application propose un petit jeu dans lequel l'utilisateur doit connaître un mot magique.

Le mot magique est `abracadabra`.

Le programme affiche `Tu connais la magie toi !` lorsque le mot saisi est correct. Pour toute autre réponse, il affiche `Mot incorrect... essaie encore.`

#### 🧩 Démarche de résolution

1. Demander un mot à l'utilisateur et conserver sa réponse dans une variable `string`.
2. **Utiliser une structure `if` / `else` et l'opérateur `==` pour vérifier si le mot saisi est égale à `"abracadabra"`**

    * Dans le bloc du `if`, afficher `Tu connais la magie toi !`.
    * Dans le bloc du `else`, afficher `Mot incorrect... essaie encore.`.
3. **Modifiez le programme pour obtenir le même résultat en utilisant deux structures `if` indépendantes.**

#### 🧪 Tests

| Mot saisi     | Résultat attendu                  |
| ------------- | --------------------------------- |
| `abracadabra` | `Tu connais la magie toi !`       |
| `magie`       | `Mot incorrect... essaie encore.` |
| `Abracadabra` | `Mot incorrect... essaie encore.` |

---

### 🟢 Exercice 4 – Nombre pair ou impair 🔢

**🎯 Objectif :** utiliser `if` et `else` avec l'opérateur `%`.

#### 📋 Besoin

Un programme doit déterminer si un nombre entier est pair ou impair.

Un nombre est pair lorsqu'il peut être divisé par 2 sans laisser de reste.

Le programme affiche `Nombre pair` pour un nombre pair et `Nombre impair` pour un nombre impair.

#### 🧩 Démarche de résolution

1. Demander un nombre entier à l'utilisateur et conserver sa valeur dans une variable.
2. Utiliser l'opérateur `%` pour calculer le reste de la division du nombre par `2`.
3. **Utiliser une structure `if` / `else` pour vérifier si le reste obtenu est égal à `0`.**

    * Dans le bloc du `if`, afficher `Nombre pair`.
    * Dans le bloc du `else`, afficher `Nombre impair`.
4. **Modifiez le programme pour obtenir le même résultat en utilisant deux structures `if` indépendantes.**

#### 🧪 Tests

| Nombre | Résultat attendu |
| -----: | ---------------- |
|      8 | `Nombre pair`    |
|      7 | `Nombre impair`  |
|      0 | `Nombre pair`    |
|     -4 | `Nombre pair`    |



**Exemple d'exécution :**

```text
Entrer un noimbre entier : 17

Nombre impair.
```
```text
Entrer un noimbre entier : 18

Nombre pair.
```
---


### 🟢 Exercice 5 – Les LEGO 🧸

**🎯 Objectif :** combiner deux conditions avec l'opérateur logique `||`.

#### 📋 Besoin

Un magasin de jouets veut déterminer si une personne peut jouer avec des LEGO.

Les personnes âgées de **moins de 4 ans** ou de **plus de 99 ans** ne peuvent pas jouer avec des LEGO.

Le programme affiche `Tu ne peux pas jouer avec des LEGO` pour ces situations et `Tu peux jouer avec des LEGO` pour tous les autres âges.

#### 🧩 Démarche de résolution

1. Demander l'âge de l'utilisateur et conserver sa valeur dans une variable entière.
2. **Utiliser une structure `if` / `else` et l'opérateur `||` pour vérifier si l'âge est moins de 4 ans ou plus de 99 ans**

    * Dans le bloc du `if`, afficher `Tu ne peux pas jouer avec des LEGO`.
    * Dans le bloc du `else`, afficher `Tu peux jouer avec des LEGO`.

3. **Modifiez le programme pour obtenir le même résultat en utilisant deux structures `if` indépendantes.**


#### 🧪 Tests

| Âge | Résultat attendu                     |
| --: | ------------------------------------ |
|   3 | `Tu ne peux pas jouer avec des LEGO` |
|   4 | `Tu peux jouer avec des LEGO`        |
|  25 | `Tu peux jouer avec des LEGO`        |
|  99 | `Tu peux jouer avec des LEGO`        |
| 100 | `Tu ne peux pas jouer avec des LEGO` |

---

### 🟢 Exercice 6 – Es-tu prêt ? 🔁

**🎯 Objectif :** utiliser l'opérateur logique `!`.

#### 📋 Besoin

Une application demande à l'utilisateur s'il est prêt avant de commencer une activité.

La réponse est une valeur booléenne `true` ou `false`.

Lorsque l'utilisateur n'est pas prêt, le programme affiche `Tu n'es pas prêt.`

#### 🧩 Démarche de résolution

1. Demander à l'utilisateur s'il est prêt et conserver sa réponse dans une variable `bool`.
2. **Utiliser l'opérateur `!` pour vérifier que la valeur booléenne est fausse.**
3. **Utiliser une structure `if` pour traiter cette situation.**
4. Afficher `Tu n'es pas prêt.` lorsque l'utilisateur n'est pas prêt.
5. Ne pas utiliser `== false`.

#### 🧪 Tests

| Réponse | Résultat attendu    |
| ------- | ------------------- |
| `true`  | Aucun message       |
| `false` | `Tu n'es pas prêt.` |

---

### 🟢 Exercice 7 – Jeune adulte fatigué 😴

**🎯 Objectif :** combiner plusieurs conditions avec `&&`.

#### 📋 Besoin

Une application veut identifier les jeunes adultes qui manquent de sommeil.

Une personne est considérée comme un **jeune adulte fatigué** lorsqu'elle a entre **18 et 30 ans inclusivement** et qu'elle a dormi **moins de 6 heures**.

Le programme affiche `Jeune adulte fatigué` pour cette catégorie et `Tu sembles en forme !` dans les autres situations.

#### 🧩 Démarche de résolution

1. Demander l'âge et conserver sa valeur dans une variable entière.
2. Demander le nombre d'heures de sommeil et conserver sa valeur dans une variable.
3. Écrire une condition vérifiant que l'âge est supérieur ou égal à `18`.
4. Écrire une condition vérifiant que l'âge est inférieur ou égal à `30`.
5. Écrire une condition vérifiant que le nombre d'heures de sommeil est inférieur à `6`.
6. **Combiner les trois conditions avec l'opérateur logique `&&`, puisque les trois critères doivent être respectés simultanément.**
7. **Utiliser une structure `if` / `else` pour traiter les deux situations.**
8. Afficher `Jeune adulte fatigué` dans le premier cas et `Tu sembles en forme !` dans l'autre.

#### 🧪 Tests

| Âge | Sommeil | Résultat attendu        |
| --: | ------: | ----------------------- |
|  22 |       5 | `Jeune adulte fatigué`  |
|  18 |       5 | `Jeune adulte fatigué`  |
|  30 |       5 | `Jeune adulte fatigué`  |
|  17 |       5 | `Tu sembles en forme !` |
|  31 |       5 | `Tu sembles en forme !` |
|  22 |       6 | `Tu sembles en forme !` |

---

### 🟢 Exercice 8 – Le prix du pantalon 👖💸

**🎯 Objectif :** utiliser plusieurs conditions avec `if`, `else if` et `else`.

#### 📋 Besoin

Une boutique de vêtements veut afficher automatiquement un commentaire en fonction du prix d'un pantalon.

Les règles commerciales sont les suivantes :

| Prix                     | Commentaire                                               |
| ------------------------ | --------------------------------------------------------- |
| 100 $ ou plus            | `Je vais chercher un rip-off cheap sur Amazon à la place` |
| Moins de 30 $            | `Wow c'est un beau prix. C'est sus`                       |
| De 30 $ à moins de 100 $ | `Prix raisonnable`                                        |

#### 🧩 Démarche de résolution

1. Demander le prix du pantalon et conserver sa valeur dans une variable numérique.
2. Identifier les trois catégories de prix à traiter.
3. **Utiliser un `if` pour traiter les prix de 100 $ ou plus.**
4. **Ajouter un `else if` pour traiter les prix de moins de 30 $.**
5. **Ajouter un `else` pour traiter les prix qui ne correspondent pas aux deux premières catégories.**
6. Afficher le message associé à chaque catégorie.

#### 🧪 Tests

|  Prix | Résultat attendu                                          |
| ----: | --------------------------------------------------------- |
|    20 | `Wow c'est un beau prix. C'est sus`                       |
| 29.99 | `Wow c'est un beau prix. C'est sus`                       |
|    30 | `Prix raisonnable`                                        |
|    50 | `Prix raisonnable`                                        |
| 99.99 | `Prix raisonnable`                                        |
|   100 | `Je vais chercher un rip-off cheap sur Amazon à la place` |

---

### 🟢 Exercice 9 – Contrôle de température 🌡️

**🎯 Objectif :** utiliser `if`, `else if` et `else` pour traiter plusieurs intervalles.

#### 📋 Besoin

Une application météo doit décrire la température extérieure.

Les règles de l'application sont les suivantes :

| Température                | Message                |
| -------------------------- | ---------------------- |
| Moins de 0 °C              | `Il gèle dehors !`     |
| De 0 à 25 °C inclusivement | `Température agréable` |
| Plus de 25 °C              | `Il fait chaud !`      |

#### 🧩 Démarche de résolution

1. Demander la température et conserver sa valeur dans une variable numérique.
2. Identifier les trois intervalles de température.
3. **Utiliser un `if` pour traiter les températures inférieures à `0`.**
4. **Ajouter un `else if` pour traiter les températures de `0` à `25`.**
5. **Ajouter un `else` pour traiter les températures supérieures à `25`.**
6. Afficher le message correspondant à chaque intervalle.

#### 🧪 Tests

| Température | Résultat attendu       |
| ----------: | ---------------------- |
|          -5 | `Il gèle dehors !`     |
|           0 | `Température agréable` |
|          20 | `Température agréable` |
|          25 | `Température agréable` |
|          26 | `Il fait chaud !`      |

---



### 🟢 Exercice 10 – Le plus grand des trois 🏆

**🎯 Objectif :** utiliser des conditions imbriquées pour comparer plusieurs valeurs.

#### 📋 Besoin

Un programme doit déterminer le plus grand de trois nombres.

Le programme demande trois nombres et affiche le plus grand sous la forme :

```text
Le plus grand est : 12
```

#### 🧩 Démarche de résolution

1. Demander les trois nombres et conserver leurs valeurs dans trois variables.
2. Comparer le premier nombre avec le deuxième.
3. **Utiliser une structure `if` pour déterminer lequel des deux est le plus grand.**
4. À partir du plus grand des deux premiers nombres, le comparer avec le troisième.
5. **Utiliser une deuxième structure `if` pour déterminer le plus grand des trois nombres.**
6. Afficher `Le plus grand est :` suivi de la valeur obtenue.

#### 🧪 Tests

|  A |  B |  C | Résultat attendu         |
| -: | -: | -: | ------------------------ |
| 12 |  5 |  9 | `Le plus grand est : 12` |
|  5 | 12 |  9 | `Le plus grand est : 12` |
|  5 |  9 | 12 | `Le plus grand est : 12` |
| 10 | 10 |  5 | `Le plus grand est : 10` |
|  7 |  7 |  7 | `Le plus grand est : 7`  |

---

### 🟢 Exercice 11 – Questionnaire éclair ⚡

**🎯 Objectif :** combiner des variables booléennes, des conditions et un calcul de score.

#### 📋 Besoin

Une application veut évaluer si une personne est bien préparée pour commencer sa journée.

Elle pose les trois questions suivantes :

```text
As-tu dormi 8h ?
As-tu mangé ce matin ?
As-tu fait tes devoirs ?
```

Chaque réponse `true` rapporte **1 point**.

Le résultat dépend du score obtenu :

* **3 points** : `Tu es prêt pour la journée !`
* **1 ou 2 points** : `Pas mal, mais tu peux faire mieux !`
* **0 point** : `Aïe... une journée difficile t'attend`

#### 🧩 Démarche de résolution

1. Déclarer trois variables booléennes représentant les réponses aux trois questions.
2. Demander les trois réponses à l'utilisateur.
3. Déclarer une variable `score` initialisée à `0`.
4. **Utiliser une structure `if` pour ajouter `1` au score lorsque la première réponse est `true`.**
5. Répéter le même principe pour les deux autres réponses.
6. Le score obtenu peut maintenant prendre les valeurs `0`, `1`, `2` ou `3`.
7. **Utiliser une structure `if` / `else if` / `else` pour déterminer le message associé au score.**
8. Afficher le score et le message correspondant.

#### 🧪 Tests

| Dormi   | Mangé   | Devoirs | Score | Résultat attendu                        |
| ------- | ------- | ------- | ----: | --------------------------------------- |
| `true`  | `true`  | `true`  |     3 | `Tu es prêt pour la journée !`          |
| `true`  | `false` | `true`  |     2 | `Pas mal, mais tu peux faire mieux !`   |
| `false` | `true`  | `false` |     1 | `Pas mal, mais tu peux faire mieux !`   |
| `false` | `false` | `false` |     0 | `Aïe... une journée difficile t'attend` |

---


## 🟣 Je résous

### 🟣 Exercice 12 – Le mot magique 🪄

Une application propose un petit jeu dans lequel l'utilisateur doit trouver le mot magique.

Le système demande à l'utilisateur d'écrire un mot. Le mot magique est `abracadabra`.

Le message `Tu connais la magie toi !` doit être affiché lorsque le mot saisi correspond exactement au mot magique. Dans toutes les autres situations, le message `Mot incorrect... essaie encore.` doit être affiché.

**Tests à effectuer :**

| Mot saisi     | Résultat attendu                  |
| ------------- | --------------------------------- |
| `abracadabra` | `Tu connais la magie toi !`       |
| `magie`       | `Mot incorrect... essaie encore.` |
| `Abracadabra` | `Mot incorrect... essaie encore.` |

**Exemple d'exécution :**

```text
Quel est le mot magique ? abracadabra
Tu connais la magie toi !
```


### 🟣 Exercice 13 – Le prix du pantalon 👖💸

Une boutique de vêtements souhaite ajouter une fonctionnalité permettant d'évaluer automatiquement le prix d'un pantalon.

Le système doit demander le prix du pantalon et afficher un commentaire correspondant à la situation :

* un prix de 100 $ ou plus doit afficher `Je vais chercher un rip-off cheap sur Amazon à la place`;
* un prix de moins de 30 $ doit afficher `Wow c'est un beau prix. C'est sus`;
* un prix de 30 $ à moins de 100 $ doit afficher `Prix raisonnable`.

**Tests à effectuer :**

| Prix | Résultat attendu                                          |
| ---: | --------------------------------------------------------- |
|   20 | `Wow c'est un beau prix. C'est sus`                       |
|   50 | `Prix raisonnable`                                        |
|  100 | `Je vais chercher un rip-off cheap sur Amazon à la place` |

**Exemple d'exécution :**

```text
Prix du pantalon : 50
Prix raisonnable
```
---

### 🟣 Exercice 14 – Mon aliment préféré 🥦🍫

Un restaurant veut connaître l'aliment préféré de son client.

Demande à l'utilisateur son aliment préféré et affiche le commentaire approprié :

* `brocoli` : `Miam. Un des aliments avec le plus de nutriments`
* tout autre aliment : `Huh, c'est mieux le brocoli`

**Tests à effectuer :**

| Aliment    | Résultat attendu                                   |
| ---------- | -------------------------------------------------- |
| `brocoli`  | `Miam. Un des aliments avec le plus de nutriments` |
| `chocolat` | `Huh, c'est mieux le brocoli`                      |
| `pizza`    | `Huh, c'est mieux le brocoli`                      |



**Exemple d'exécution :**

```text
Quel est ton aliment préféré ? chocolat

Huh, c'est mieux le brocoli
```
---

### 🟣 Exercice 15 – Jeune adulte fatigué 😴

Un programme veut déterminer si une personne est un jeune adulte qui manque de sommeil.

Demande l'âge et le nombre d'heures de sommeil de la personne.

La catégorie **jeune adulte fatigué** comprend les personnes âgées de **18 à 30 ans inclusivement** qui ont dormi **moins de 6 heures**.

Affiche `Tyu es un jeune adulte fatigué` pour cette catégorie et `Tu sembles en forme !` pour toutes les autres situations.

**Tests à effectuer :**

| Âge | Sommeil | Résultat attendu        |
| --: | ------: | ----------------------- |
|  22 |       5 | `Jeune adulte fatigué`  |
|  18 |       5 | `Jeune adulte fatigué`  |
|  30 |       5 | `Jeune adulte fatigué`  |
|  22 |       6 | `Tu sembles en forme !` |
|  17 |       5 | `Tu sembles en forme !` |
|  31 |       5 | `Tu sembles en forme !` |



**Exemple d'exécution :**

```text
Âge : 22
Heures de sommeil : 5

Tu es un jeune adulte fatigué
```

---

### 🟣 Exercice 16 – Code secret 🔐

Un système doit décider si un utilisateur peut accéder à une application.

Demande son prénom et son code secret.

L'accès est accordé uniquement avec les informations suivantes :

* Prénom : `Alice`
* Code : `1234`

Affiche `Accès accordé` lorsque les informations permettent l'accès et `Accès refusé` dans toutes les autres situations.

**Tests à effectuer :**

| Prénom  | Code | Résultat attendu |
| ------- | ---: | ---------------- |
| `Alice` | 1234 | `Accès accordé`  |
| `Alice` | 5678 | `Accès refusé`   |
| `Bob`   | 1234 | `Accès refusé`   |
| `Bob`   | 5678 | `Accès refusé`   |


**Exemple d'exécution :**

```text
Prénom : Alice
Code : 1234

Accès accordé
```

---

### 🟣 Exercice 17 – Loterie 🍀

Une loterie utilise le nombre mystère `7`.

Demande à l'utilisateur de choisir un nombre entre 1 et 10.

Le numéro gagnant produit le message `Félicitations, tu as gagné !`. Tout autre numéro produit le message `Désolé, ce n'est pas le bon numéro`.

**Tests à effectuer :**

| Nombre choisi | Résultat attendu                     |
| ------------: | ------------------------------------ |
|             7 | `Félicitations, tu as gagné !`       |
|             3 | `Désolé, ce n'est pas le bon numéro` |
|            10 | `Désolé, ce n'est pas le bon numéro` |

**Exemple d'exécution :**

```text
Choisis un nombre : 7

Félicitations, tu as gagné !
```

---

### 🟣 Exercice 18 – Contrôle de température 🌡️

Une application météo doit décrire la température extérieure.

Demande la température et affiche le message correspondant :

* température inférieure à 0 : `Il gèle dehors !`
* température de 0 à 25 inclusivement : `Température agréable`
* température supérieure à 25 : `Il fait chaud !`

**Tests à effectuer :**

| Température | Résultat attendu       |
| ----------: | ---------------------- |
|          -5 | `Il gèle dehors !`     |
|           0 | `Température agréable` |
|          20 | `Température agréable` |
|          25 | `Température agréable` |
|          26 | `Il fait chaud !`      |



**Exemple d'exécution :**

```text
Température : 26

Il fait chaud !
```
---

### 🟣 Exercice 19 – Film recommandé 🎬

Un service de diffusion veut recommander un film en fonction de l'âge de l'utilisateur.

Demande son âge et affiche la recommandation appropriée :

* moins de 13 ans : `Tu peux regarder : Coco`
* de 13 à 17 ans inclusivement : `Tu peux regarder : Spider-Man`
* 18 ans ou plus : `Tu peux regarder : Inception`

**Tests à effectuer :**

| Âge | Résultat attendu                |
| --: | ------------------------------- |
|  10 | `Tu peux regarder : Coco`       |
|  13 | `Tu peux regarder : Spider-Man` |
|  17 | `Tu peux regarder : Spider-Man` |
|  18 | `Tu peux regarder : Inception`  |



**Exemple d'exécution :**

```text
Quel est ton âge ? 15

Tu peux regarder : Spider-Man
```
---

### 🟣 Exercice 20 – Questionnaire éclair ⚡

Une application veut évaluer si une personne est bien préparée pour commencer sa journée.

Pose les trois questions suivantes :

```text
As-tu dormi 8h ?
As-tu mangé ce matin ?
As-tu fait tes devoirs ?
```

Chaque réponse `true` rapporte un point.

Le résultat dépend du nombre de points obtenus :

* 3 points : `Tu es prêt pour la journée !`
* 1 ou 2 points : `Pas mal, mais tu peux faire mieux !`
* 0 point : `Aïe... une journée difficile t'attend`

**Tests à effectuer :**

| Dormi 8h | Mangé   | Devoirs | Score | Résultat                                |
| -------- | ------- | ------- | ----: | --------------------------------------- |
| `false`  | `false` | `false` |     0 | `Aïe... une journée difficile t'attend` |
| `false`  | `false` | `true`  |     1 | `Pas mal, mais tu peux faire mieux !`   |
| `false`  | `true`  | `false` |     1 | `Pas mal, mais tu peux faire mieux !`   |
| `false`  | `true`  | `true`  |     2 | `Pas mal, mais tu peux faire mieux !`   |
| `true`   | `false` | `false` |     1 | `Pas mal, mais tu peux faire mieux !`   |
| `true`   | `false` | `true`  |     2 | `Pas mal, mais tu peux faire mieux !`   |
| `true`   | `true`  | `false` |     2 | `Pas mal, mais tu peux faire mieux !`   |
| `true`   | `true`  | `true`  |     3 | `Tu es prêt pour la journée !`          |




**Exemple d'exécution :**

```text
As-tu dormi 8h ? true
As-tu mangé ce matin ? false
As-tu fait tes devoirs ? true

Score : 2
Pas mal, mais tu peux faire mieux !
```
---

### 🟣 Exercice 21 – Le plus grand des trois 🏆

Un programme doit déterminer le plus grand de trois nombres.

Demande trois nombres à l'utilisateur et affiche le plus grand sous la forme :

`Le plus grand est : [valeur]`

**Tests à effectuer :**

|  A |  B |  C | Résultat attendu         |
| -: | -: | -: | ------------------------ |
| 12 |  5 |  9 | `Le plus grand est : 12` |
|  5 | 12 |  9 | `Le plus grand est : 12` |
|  5 |  9 | 12 | `Le plus grand est : 12` |
| 12 |  5 | 12 | `Le plus grand est : 12` |
|  5 | 12 | 12 | `Le plus grand est : 12` |
| 12 | 12 |  5 | `Le plus grand est : 12` |
| 10 | 10 |  5 | `Le plus grand est : 10` |
| 10 |  5 | 10 | `Le plus grand est : 10` |
|  5 | 10 | 10 | `Le plus grand est : 10` |
|  7 |  7 |  7 | `Le plus grand est : 7`  |




### exercices similaires


### 🟢 Exercice 11 – Film recommandé 🎬

**🎯 Objectif :** combiner plusieurs intervalles avec `if`, `else if` et `else`.

#### 📋 Besoin

Un service de diffusion veut recommander un film en fonction de l'âge de son utilisateur.

Les recommandations sont les suivantes :

| Âge                          | Film recommandé                 |
| ---------------------------- | ------------------------------- |
| Moins de 13 ans              | `Tu peux regarder : Coco`       |
| De 13 à 17 ans inclusivement | `Tu peux regarder : Spider-Man` |
| 18 ans ou plus               | `Tu peux regarder : Inception`  |

#### 🧩 Démarche de résolution

1. Demander l'âge et conserver sa valeur dans une variable entière.
2. Identifier les trois groupes d'âge.
3. **Utiliser un `if` pour traiter les utilisateurs de moins de `13` ans.**
4. **Ajouter un `else if` pour traiter les utilisateurs de `13` à `17` ans.**
5. **Ajouter un `else` pour traiter les utilisateurs de `18` ans ou plus.**
6. Afficher la recommandation associée au groupe d'âge.

#### 🧪 Tests

| Âge | Résultat attendu                |
| --: | ------------------------------- |
|  10 | `Tu peux regarder : Coco`       |
|  12 | `Tu peux regarder : Coco`       |
|  13 | `Tu peux regarder : Spider-Man` |
|  15 | `Tu peux regarder : Spider-Man` |
|  17 | `Tu peux regarder : Spider-Man` |
|  18 | `Tu peux regarder : Inception`  |
|  25 | `Tu peux regarder : Inception`  |



### 🟢 Exercice 14 – Gym pour variables 🏋️

**🎯 Objectif :** utiliser les opérateurs d'assignation composée et d'incrémentation.

#### 📋 Besoin

Un programme doit faire évoluer progressivement la valeur d'un score.

Le score commence à `10`. Le programme doit ensuite ajouter `5`, multiplier le résultat par `2`, augmenter le score de `1`, puis le diminuer deux fois de `1`.

La valeur finale doit être affichée sous la forme :

```text
Score final : 29
```

#### 🧩 Démarche de résolution

1. Déclarer une variable `score` avec la valeur initiale `10`.
2. **Utiliser `+=` pour ajouter `5` au score.**
3. **Utiliser `*=` pour multiplier le score par `2`.**
4. **Utiliser `++` pour augmenter le score de `1`.**
5. **Utiliser `--` deux fois pour diminuer le score de `1` à deux reprises.**
6. Afficher la valeur finale du score.

#### 🧪 Test

| Score initial |   Résultat attendu |
| ------------: | -----------------: |
|            10 | `Score final : 29` |


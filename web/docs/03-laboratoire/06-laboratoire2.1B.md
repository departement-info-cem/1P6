---
title: B - Exercices pratiques - Conditions, assignation composées
---

# 🧪 Labo 2.1B – Exercices pratiques : Conditions, assignation composées

---

## 🟢 J'applique

### 🟢 Exercice 1 – Besoin de café ☕

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

#### 🧪 Test

| `jeSuisFatigue` | Résultat attendu           |
| :-------------- | :------------------------- |
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
| :------------ | :-------------------------------- |
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
Entrer un nombre entier : 17
Nombre impair.
```

```text
Entrer un nombre entier : 18
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

3. **Modifiez le programme pour obtenir le même résultat en utilisant deux structures `if` indépendantes sans l'opérateur `||`**

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
| :------ | :------------------ |
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

### 🟢 Exercice 12 – Gym pour variables 🏋️

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

| Score initial | Résultat attendu   |
| ------------: | ------------------ |
|            10 | `Score final : 29` |





## 🟣 Je résous

### 🟣 Exercice 13 – Mon aliment préféré 🥦🍫

Une application de restaurant souhaite connaître l'aliment préféré de son client.

Le système demande à l'utilisateur son aliment préféré. Le choix `brocoli` produit le message `Miam. Un des aliments avec le plus de nutriments`. Tout autre choix produit le message `Huh, c'est mieux le brocoli`.

#### 🧪 Tests à effectuer

| Aliment    | Résultat attendu                                   |
| ---------- | -------------------------------------------------- |
| `brocoli`  | `Miam. Un des aliments avec le plus de nutriments` |
| `chocolat` | `Huh, c'est mieux le brocoli`                      |
| `pizza`    | `Huh, c'est mieux le brocoli`                      |

#### ▶️ Exemple d'exécution

```text
Quel est ton aliment préféré ? chocolat

Huh, c'est mieux le brocoli
```

---

### 🟣 Exercice 14 – Code secret 🔐

Un système doit décider si un utilisateur peut accéder à une application.

Le système demande le prénom et le code secret de l'utilisateur.

L'accès est accordé uniquement avec le prénom `Alice` et le code `1234`. Le message `Accès accordé` est alors affiché. Toutes les autres situations produisent le message `Accès refusé`.

#### 🧪 Tests à effectuer

| Prénom  | Code | Résultat attendu |
| ------- | ---: | ---------------- |
| `Alice` | 1234 | `Accès accordé`  |
| `Alice` | 5678 | `Accès refusé`   |
| `Bob`   | 1234 | `Accès refusé`   |
| `Bob`   | 5678 | `Accès refusé`   |

#### ▶️ Exemple d'exécution

```text
Prénom : Alice
Code : 1234

Accès accordé
```

---

### 🟣 Exercice 15 – Loterie 🍀

Une loterie utilise le nombre mystère `7`.

Le système demande à l'utilisateur de choisir un nombre entre 1 et 10.

Le numéro `7` produit le message `Félicitations, tu as gagné !`. Tout autre numéro produit le message `Désolé, ce n'est pas le bon numéro`.

#### 🧪 Tests à effectuer

| Nombre choisi | Résultat attendu                     |
| ------------: | ------------------------------------ |
|             7 | `Félicitations, tu as gagné !`       |
|             3 | `Désolé, ce n'est pas le bon numéro` |
|            10 | `Désolé, ce n'est pas le bon numéro` |

#### ▶️ Exemple d'exécution

```text
Choisis un chiffre : 7

Félicitations, tu as gagné !
```

---

### 🟣 Exercice 16 – Film recommandé 🎬

Un service de diffusion souhaite recommander un film en fonction de l'âge de son utilisateur.

Le système demande l'âge de l'utilisateur.

Les utilisateurs de **moins de 13 ans** reçoivent la recommandation `Tu peux regarder : Coco`.

Les utilisateurs de **13 à 17 ans inclusivement** reçoivent la recommandation `Tu peux regarder : Spider-Man`.

Les utilisateurs de **18 ans ou plus** reçoivent la recommandation `Tu peux regarder : Inception`.

#### 🧪 Tests à effectuer

| Âge | Résultat attendu                |
| --: | ------------------------------- |
|  10 | `Tu peux regarder : Coco`       |
|  13 | `Tu peux regarder : Spider-Man` |
|  15 | `Tu peux regarder : Spider-Man` |
|  17 | `Tu peux regarder : Spider-Man` |
|  18 | `Tu peux regarder : Inception`  |
|  25 | `Tu peux regarder : Inception`  |

### ▶️ Exemple d'exécution

```text
Quel est ton âge ? 15

Tu peux regarder : Spider-Man
```
### 🟣 Exercice 17 – Le jeu des deux dés 🎲🎲

Une application simule un jeu avec **deux dés à six faces**.

Le programme demande la valeur obtenue par chacun des deux dés et calcule un score selon les règles suivantes :

* Si les deux dés affichent **6**, le joueur obtient **100 points**.
* Si les deux dés affichent **5** ou **4**, le joueur obtient **75 points**.
* Si les deux dés affichent **la même valeur**, le joueur obtient **50 points**.
* Dans tous les autres cas, le joueur obtient un nombre de points correspondant à **la somme des deux dés**.

Le programme affiche le score obtenu.

#### 🧪 Tests à effectuer

| Dé 1 | Dé 2 | Résultat attendu |
| ---: | ---: | ---------------- |
|    6 |    6 | `Score : 100`    |
|    5 |    5 | `Score : 75`     |
|    4 |    4 | `Score : 75`     |
|    3 |    3 | `Score : 50`     |
|    2 |    2 | `Score : 50`     |
|    1 |    1 | `Score : 50`     |
|    6 |    5 | `Score : 11`     |
|    6 |    2 | `Score : 8`      |
|    4 |    3 | `Score : 7`      |
|    2 |    5 | `Score : 7`      |


---
## ⚫ Je relève le défi

Prêt à relever un défi ? Rends-toi sur la page du défi pour mettre tes connaissances à l'épreuve !

👉 [Accéder au défi sur les conditions](../06-defis/conditions.md)

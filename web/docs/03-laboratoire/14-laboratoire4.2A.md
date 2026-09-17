---
title: A - Boucle For simple
---

# Labo 4.2A – Exercices simples de boucles

---

## Exercices simples de boucles

Nous allons réaliser une série d’exercices permettant de pratiquer l'**utilisation de boucles for** en C#.

Pour **chaque exercice**, créez un **nouveau projet** dans Visual Studio.

---

### 📌 Rappel : Boucle simple

```csharp
//initialisation; test logique; incrémentation  
for (int i = 0;   i < 10 ;   i++)
{
    // Block de code de la boucle
}
```
### 🟢 Exercice 1 — Affichez des valeurs

Affichez les nombres de `1` à `6` dans la console avec une boucle `for`.

#### Démarche

* Utilisez une boucle `for` avec un compteur qui varie de `1` à `6`.
* À chaque répétition, affichez la valeur du compteur.

---

### 🟢 Exercice 2 — Affichage sur une ligne

Affichez les nombres de `10` à `20` sur une seule ligne.

#### Démarche

* Utilisez une boucle `for` avec un compteur qui varie de `10` à `20`.
* À chaque répétition, affichez la valeur du compteur sans effectuer de retour à la ligne.
* Ajoutez un espace entre les différentes valeurs.

---

### 🟢 Exercice 3 — Décrémentation d’un compteur

Affichez les nombres de `10` à `0` en diminuant la valeur de `2` à chaque répétition.

#### Démarche

* Utilisez une boucle `for` avec un compteur qui commence à `10`.
* Faites diminuer le compteur de `2` à chaque répétition.
* La répétition doit se poursuivre jusqu'à `0`.
* À chaque répétition, affichez la valeur du compteur.

---

### 🟢 Exercice 4 — Incrémentation par bonds

Affichez les nombres pairs de `0` à `20`.

#### Démarche

* Utilisez une boucle `for` avec un compteur qui commence à `0`.
* Faites augmenter le compteur de `2` à chaque répétition.
* La répétition doit se poursuivre jusqu'à `20`.
* À chaque répétition, affichez la valeur du compteur.


Résultat attendu :
```
0
2
4
6
8
10
12
14
16
18
20
```
---


### 🟢 Exercice 5 : Conditionnel dans une boucle.
Affichez les nombres impairs de 10 à 25 inclusivement.
 * L'index de votre boucle **doit** commencer à la valeur 10, qui n'est **pas** un chiffre impair.
 * Vous **devez** donc utiliser un  `if` et un modulo ( `%` ) afin de vérifier que chaque index est impair avant de l'afficher.

Résultat attendu :
```
11
13
15
17
19
21
23
25
```

### 🟢 Exercice 6 : Conditionnel dans une boucle.
Affichez les nombres de 1 à 50 sur une ligne **sauf** les multiples de 3.
Vous devez vérifier si le nombre est divisible par 3 avec un modulo avant de l'afficher.
Résultat attendu :
```
1 2 4 5 7 8 10 11 13 14 16 17 19 20 22 23 25 26 28 29 31 32 34 35 37 38 40 41 43 44 46 47 49 50
```

### 🟢 Exercice 7 : Accumulation de valeurs.
Faites la somme des chiffres de 1 à 50.
Affichez le résultat final.
Vous aurez besoin de créer une variable compteur à laquelle vous additionnez les valeurs de votre boucle.

Résultat attendu :
```
Total : 1275
```

### 🟢 Exercice 8 : Accumulation d'entrées d'utilisateur.
Faites une boucle qui demande à l'utilisateur de rentrer 3 chiffres un après l'autre.
Convertissez la valeur entrée en `double`.
Additionnez chacun des chiffres entrés dans une variable.
Faites la moyenne des chiffres entrés.

Résultat attendu :
```
Entrez un chiffre : 3
Entrez un chiffre : -5
Entrez un chiffre : 21
La moyenne est : 6,33 // ou bien 6,33333333
```


---


### 🟢 Exercice 9 : Boucles imbriquées
🎯 **Objectif** : Utilisez deux boucles imbriquées pour faire un carré d'étoiles. 

🛠️ **Instructions** :
1. Faites une première boucle avec un index `i` commençant à 1 et allant jusqu'à 5.
2. Dans le corps de votre première boucle, commencez par faire un saut de ligne dans la console avec `Console.WriteLine()`
3. Encore dans le corps de votre première boucle, faites une deuxième boucle avec un index `j` allant de 1 à 5.
4. Dans le corps de la **deuxième** boucle, imprimer le symbole __`*`__ sur une ligne sans retour de ligne avec `Console.Write()`

**Pseudo-Code :**
```
DÉBUT
    BOUCLE UN avec des valeurs d'index de 1 à 5 inclusivement
        Impression d'un saut de ligne dans la console

        BOUCLE DEUX avec des valeurs d'index de 1 à 5
            Impression de '*' sur une ligne sans retour clavier
        Fin de la boucle DEUX

    Fin de la boucle UN
FIN
```
**Notez** : Chaque itération de la première boucle fera **1** saut de ligne, suivi de l'exécution complète de la deuxième boucle. La deuxième boucle affichera 1 caractère à chaque itération, pour un total de **5** caractères. Le code dans la première boucle sera exécuté **5** fois tandis que le code dans la deuxième boucle sera exécuté **25** fois.


Résultat attendu :
```
*****
*****
*****
*****
*****
```


### 🟢 Exercice 10 : Boucles imbriquées
🎯 **Objectif** : On fait une pyramide d'étoiles. Avec deux boucles imbriquées, on veut utiliser l'index de la première boucle dans la deuxième boucle. 

🛠️ **Instructions** :
1. Reprenez le code de l'exercice précédent.
2. Changez le test conditionnel dans la deuxième boucle. Plutôt de que de faire `j <= 5`, faites `j <= i`
3. Exécuter votre code.

```
DÉBUT
    BOUCLE UN avec des valeurs d'index de 1 à 5 inclusivement
        Impression d'un saut de ligne dans la console

        BOUCLE DEUX avec des valeurs d'index de 1 à **INDEX DE LA PREMIÈRE BOUCLE**
            Impression de '*' sur une ligne sans retour clavier
        Fin de la boucle DEUX

    Fin de la boucle UN

FIN
```

**NOTEZ** : Vous faites encore 5 itérations de la première boucle. Mais le nombre d'itérations de la deuxième boucle varie à chaque fois. Le contenu de la deuxième boucle est d'abord exécuté **1** fois, puis **2**, **3**, **4**, et finalement **5** fois.

Résultat attendu :
```
*
**
***
****
*****
```

---


### 🟣 Exercice 11 — Compter certaines valeurs

Un programme doit demander à l'utilisateur **10 nombres entiers**.

À la fin de la saisie, le programme doit afficher :

* le nombre de valeurs positives;
* le nombre de valeurs négatives;
* le nombre de valeurs égales à `0`.

Exemple :

```text
Nombre 1 : 12
Nombre 2 : -4
Nombre 3 : 0
Nombre 4 : 8
...

Positifs : 5
Négatifs : 3
Zéros : 2
```

Déterminez les variables nécessaires et la façon de parcourir les 10 valeurs.

---

### 🟣 Exercice 12 — Trouver le plus grand nombre

Un programme doit demander à l'utilisateur **10 nombres entiers**.

À la fin, il doit afficher le plus grand nombre saisi.

Exemple :

```text
Nombre 1 : 12
Nombre 2 : 7
Nombre 3 : 25
Nombre 4 : 8
...

Plus grand nombre : 25
```

Vous devez déterminer comment conserver en mémoire la plus grande valeur rencontrée pendant la saisie.

---
## ⚫ Je relève le défi

Prêt à relever un défi ? Rends-toi sur la page du défi pour mettre tes connaissances à l'épreuve !

👉 [Accéder au défi sur la boucle `for`](../06-defis/boucle-for.md)



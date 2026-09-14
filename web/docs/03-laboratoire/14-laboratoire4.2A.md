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


---

### 🟣 Exercice 5 — Compter certaines valeurs

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

### 🟣 Exercice 6 — Additionner certaines valeurs

Un programme doit demander à l'utilisateur **10 nombres entiers**.

À la fin, il doit afficher la somme des nombres **pairs uniquement**.

Exemple :

```text
Nombre 1 : 12
Nombre 2 : 7
Nombre 3 : 4
Nombre 4 : 9
...

Somme des nombres pairs : 16
```

Le programme doit fonctionner avec n'importe quelles valeurs saisies.

---

### 🟣 Exercice 7 — Trouver le plus grand nombre

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

### 🟣 Exercice 8 — Calculer une moyenne selon une condition

Un programme doit demander à l'utilisateur **10 notes**.

À la fin, il doit calculer et afficher la moyenne des notes **supérieures ou égales à 60**.

Si aucune note ne respecte cette condition, le programme doit afficher un message approprié.

Exemple :

```text
Note 1 : 75
Note 2 : 45
Note 3 : 82
Note 4 : 55
...

Moyenne des notes réussies : 78.5
```

Déterminez comment identifier les notes à prendre en compte et comment calculer leur moyenne.

---

### 🟣 Exercice 9 — Construire un carré

Un programme doit afficher un carré composé du caractère `*`.

La taille du carré est fournie par l'utilisateur.

Pour une taille de `5` :

```text
*****
*****
*****
*****
*****
```

Pour une taille de `3` :

```text
***
***
***
```

Le programme doit fonctionner pour différentes tailles.

**À vous de déterminer comment organiser les répétitions nécessaires pour construire le carré.**

---

### 🟣 Exercice 10 — Construire une pyramide

Un programme doit afficher une pyramide composée du caractère `*`.

La hauteur de la pyramide est fournie par l'utilisateur.

Pour une hauteur de `5` :

```text
*
**
***
****
*****
```

Pour une hauteur de `3` :

```text
*
**
***
```

Le programme doit fonctionner pour différentes hauteurs.

**À vous de déterminer comment faire varier le nombre de caractères affichés à chaque ligne.**

## Exercices plus complexes

### 🟢 Exercice 11 — Boucle dans une fonction

#### Besoin

Vous devez créer une fonction `AfficherTableMultiplication` qui reçoit un nombre entier et affiche sa table de multiplication de `1` à `12`.

Par exemple, l'appel :

```csharp
AfficherTableMultiplication(5);
```

doit afficher :

```text
5 x 1 = 5
5 x 2 = 10
5 x 3 = 15
...
5 x 12 = 60
```

#### Démarche

1. Créez une fonction nommée `AfficherTableMultiplication`.
2. La fonction doit recevoir le nombre dont vous voulez afficher la table.
3. Dans la fonction, utilisez une boucle permettant de parcourir les multiplicateurs de `1` à `12`.
4. À chaque répétition, calculez le produit du nombre reçu par la fonction et du compteur.
5. Affichez le résultat.
6. Dans `Main`, appelez la fonction avec différentes valeurs.

#### À vous de programmer

Écrivez la fonction et testez-la avec au moins trois nombres différents.

---

### 🔵 Exercice 12 Fonction dans une boucle

⚠️ **Important :** cette série d'exercices se réalise dans **le même projet**. Conservez le code développé d'un exercice à l'autre, car les exercices suivants réutilisent les fonctions créées précédemment.


#### 🔵 Exercice 12-A — Fonction `ComposerLigneÉtoile()`

Créez une fonction `ComposerLigneÉtoile()` qui reçoit un nombre d’étoiles et retourne une chaîne contenant ce nombre d’étoiles.

##### Démarche

* Créez une fonction `ComposerLigneÉtoile()` avec un paramètre représentant le nombre d’étoiles à produire et un retour de type `string`.
* Utilisez une variable `string` initialisée avec une chaîne vide.
* Utilisez une boucle `for` pour ajouter une étoile à la chaîne à chaque répétition.
* La boucle doit se répéter autant de fois que le nombre d’étoiles demandé.
* Retournez la chaîne obtenue.

##### Vérification

Appelez la fonction avec les valeurs `3`, `5` et `9` et affichez les résultats.

**Résultat attendu :**

```text
***
*****
*********
```

---

#### 🔵 Exercice 2-B — Appel d’une fonction dans une boucle

Utilisez la fonction `ComposerLigneÉtoile()` pour afficher une pyramide de `5` lignes.

##### Démarche

* Utilisez une boucle `for` dont le compteur permet de représenter le numéro de la ligne.
* À chaque répétition, appelez la fonction `ComposerLigneÉtoile()`.
* Utilisez le compteur de la boucle pour déterminer le nombre d’étoiles à afficher sur la ligne.
* Affichez la chaîne retournée par la fonction.

**Résultat attendu :**

```text
*
**
***
****
*****
```

---

#### 🔵 Exercice 2-C — Créer la fonction `ImprimerPyramide()`

Transformez la solution de l'exercice 2-B en une fonction appelée `ImprimerPyramide()` qui reçoit la taille de la pyramide.

##### Démarche

* Créez une fonction `ImprimerPyramide()` avec un paramètre représentant la taille de la pyramide.
* Reprenez le principe de la boucle utilisée à l'exercice 2-B.
* Utilisez la valeur reçue en paramètre pour déterminer le nombre de lignes à afficher.
* À chaque répétition, appelez `ComposerLigneÉtoile()` avec le nombre d'étoiles correspondant à la ligne.
* Affichez la chaîne retournée.
* Dans `Main`, testez la fonction avec différentes tailles.

**Exemples :**

Pour une taille de `3` :

```text
*
**
***
```

Pour une taille de `5` :

```text
*
**
***
****
*****
```

---

#### 🔵 Exercice 2-D — Créer la fonction `ImprimerPyramideInverser()`

Créez une fonction `ImprimerPyramideInverser()` qui reçoit la taille de la pyramide et affiche les lignes d'une pyramide en ordre décroissant.

##### Démarche

* Créez une fonction `ImprimerPyramideInverser()` avec un paramètre représentant la taille de la pyramide.
* Utilisez une boucle `for` avec un compteur qui commence à la taille reçue en paramètre et diminue de `1` à chaque répétition.
* À chaque répétition, appelez `ComposerLigneÉtoile()` en utilisant la valeur actuelle du compteur.
* Affichez la chaîne retournée.
* Dans `Main`, testez la fonction avec une taille de `4`.

**Résultat attendu :**

```text
****
***
**
*
```

##### Intégration

Appelez ensuite `ImprimerPyramide()` suivie de `ImprimerPyramideInverser()` afin d'obtenir :

```text
*
**
***
**
*
```

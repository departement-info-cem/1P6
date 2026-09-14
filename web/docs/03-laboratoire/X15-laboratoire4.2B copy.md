---
title: B - Exercices plus complexes
---

# Labo 4.2B – Exercices de boucles

Nous allons réaliser une série d’exercices permettant de pratiquer l'**utilisation de boucles for** en C#.

Pour **chaque exercice**, créez un **nouveau projet** dans Visual Studio.

---



## 🟡 Exercice 1 : Boucle dans une fonction.
**Mise en situation** : On fait un petit programme pour aider les jeunes à apprendre leurs tables de multiplication.

🎯 **Objectif** : Faire une fonction qui prend un `int` en paramètre et qui imprime la table de multiplication correspondante dans la console.

🛠️ **Instructions** :
1. Crée une fonction `AfficherTableMultiplication()` qui prend un int en paramètre et qui n'a pas de retour.
2. La fonction doit contenir une boucle `for` allant de 1 à 12.
3. Dans la boucle, imprimer la valeur passée en paramètre, ainsi que l'index et le résultat de leur multiplication.
4. Appelez la fonction dans le `Main()` avec la valeur 7 en paramètre.


**Résultat attendu** :
```
    7 x 1 = 7
    7 x 2 = 14
    7 x 3 = 21
    7 x 4 = 28
    7 x 5 = 35
    7 x 6 = 42
    7 x 7 = 49
    7 x 8 = 56
    7 x 9 = 63
    7 x 10 = 70
    7 x 11 = 77
    7 x 12 = 84
```
---

## 🟡 Exercice 2 : Fonction dans une boucle
Cette série d'exercices se font dans le même projet.

### Exercice 2-A : Fonction `ComposerLigneÉtoile()`

🎯 **Objectif** : Faire une fonction qui prend un `int` en paramètre et qui retourne un `string` avec un nombre d'étoiles **`*`** correspondant.

🛠️ **Instructions** :
1. Faites une fonction `ComposerLigneÉtoile()` qui prend un `int` en paramètre `pNbrÉtoiles` et qui retourne un `string`
2. Dans la fonction, faites une variable de type `string` avec une chaine vide `""` comme valeur initiale
3. Encore dans la fonction, faites une boucle avec un index commençant à **0** et en utilisant le `int` passé pour le test logique `index < pNbrÉtoiles`
4. Dans la boucle, concaténez une étoile **`*`** à la variable `string` créée à l'étape 2.
5. Une fois la boucle terminée, retourner la variable `string`

Vérifiez votre fonction en l'appelant avec les valeurs **3**, **5**,  et **9** et en imprimant les retours dans la console.

**Résultat attendu** :
```
***
*****
*********
```

### Exercice 2-B : Appel de fonction dans une boucle
Dans le même projet que l'exercice 2-A.


🎯 **Objectif** : Faire un appel de fonction dans une boucle pour faire une pyramide.

🛠️ **Instructions** :
1. Faites une boucle qui appelle la fonction `ComposerLigneÉtoile()` 5 fois et qui imprime son retour.
2. En paramètre de la fonction `ComposerLigneÉtoile()`, passez l'index de votre boucle.

**Résultat attendu** :
```
*
**
***
****
*****
```

### Exercice 2-C : Appel de fonction dans une boucle
Encore dans le même projet.

🎯 **Objectif** : Créer une fonction `ImprimerPyramide()` qui prend la taille de la pyramide en paramètre.

🛠️ **Instructions** :
1. Crée une nouvelle fonction `ImprimerPyramide()` qui prend un `int` en paramètre correspondant à la taille de la pyramide désirée.
2. Reprenez votre boucle que vous venez de faire à l'exercice **2-B** et mettez le code dans votre nouvelle fonction.
3. Modifier la boucle afin qu'elle utilise la valeur de taille passée en paramètre.
4. Testez votre nouvelle fonction.

**Résultat attendu** :
```Csharp
// 3 passé en paramètre
*
**
***

// 5 passé en paramètre
*
**
***
****
*****
```

**Notez** : Nous avons maintenant une fonction qui appelle une autre fonction. Il n'y a pas de limites au nombre de fonctions qui peuvent être appelées.


### Exercice 2-D : Appel de fonction dans une boucle
Encore dans le même projet.

🎯 **Objectif** : Créer une fonction `ImprimerPyramideInverser()` qui prend la taille de la pyramide en paramètre.

🛠️ **Instructions** :
1. Crée une nouvelle fonction `ImprimerPyramideInverser()` qui prend un `int` en paramètre correspondant à la taille de la pyramide désirée.
2. Cette fonction doit contenir une boucle dont on initialise l'index à la valeur de taille passé en paramètre et qu'on itère en décrémentant l'index jusqu'à ce qu'il atteigne **0**

**Résultat attendu** :
```Csharp
// 4 passé en paramètre
****
***
**
*
```

Essayer d'appeler la fonction `ImprimerPyramide(3)` suivie de  `ImprimerPyramideInverser(2)`, vous devriez obtenir le résultat suivant : 

**Résultat attendu** :
```Csharp
*
**
***
**
*
```




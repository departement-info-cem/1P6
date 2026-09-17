---
title: B - Exercices plus complexes
---

# Labo 4.2B – Exercices de boucles

---

## 🟢 Exercice 1 — Boucle dans une fonction

### Besoin

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

### Démarche

1. Créez une fonction nommée `AfficherTableMultiplication`.
2. La fonction doit recevoir le nombre dont vous voulez afficher la table.
3. Dans la fonction, utilisez une boucle permettant de parcourir les multiplicateurs de `1` à `12`.
4. À chaque répétition, calculez le produit du nombre reçu par la fonction et du compteur.
5. Affichez le résultat.
6. Dans `Main`, appelez la fonction avec différentes valeurs.

### À vous de programmer

Écrivez la fonction et testez-la avec au moins trois nombres différents.

---

## 🔵 Exercice 2 Fonction dans une boucle

⚠️ **Important :** cette série d'exercices se réalise dans **le même projet**. Conservez le code développé d'un exercice à l'autre, car les exercices suivants réutilisent les fonctions créées précédemment.


### 🔵 Exercice 2-A — Fonction `ComposerLigneÉtoile()`

Créez une fonction `ComposerLigneÉtoile()` qui reçoit un nombre d’étoiles et retourne une chaîne contenant ce nombre d’étoiles.

##### Démarche

* Créez une fonction `ComposerLigneÉtoile()` avec un paramètre représentant le nombre d’étoiles à produire et un retour de type `string`.
* Utilisez une variable `string` initialisée avec une chaîne vide.
* Utilisez une boucle `for` pour ajouter une étoile à la chaîne à chaque répétition.
* La boucle doit se répéter autant de fois que le nombre d’étoiles demandé.
* Retournez la chaîne obtenue.

#### Vérification

Appelez la fonction avec les valeurs `3`, `5` et `9` et affichez les résultats.

**Résultat attendu :**

```text
***
*****
*********
```

---

### 🔵 Exercice 2-B — Appel d’une fonction dans une boucle

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

### 🔵 Exercice 2-C — Créer la fonction `ImprimerPyramide()`

Transformez la solution de l'exercice 2-B en une fonction appelée `ImprimerPyramide()` qui reçoit la taille de la pyramide.

#### Démarche

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

### 🔵 Exercice 2-D — Créer la fonction `ImprimerPyramideInverser()`

Créez une fonction `ImprimerPyramideInverser()` qui reçoit la taille de la pyramide et affiche les lignes d'une pyramide en ordre décroissant.

#### Démarche

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

#### Intégration

Appelez ensuite `ImprimerPyramide()` suivie de `ImprimerPyramideInverser()` afin d'obtenir :

```text
*
**
***
**
*
```


---
## ⚫ Je relève le défi

Prêt à relever un défi ? Rends-toi sur la page du défi pour mettre tes connaissances à l'épreuve !

👉 [Accéder au défi sur la boucle `for`](../06-defis/boucle-for.md)

---
title: 📝 C - Intégration des boucles et des tableaux - Mini-projet – entrée de données
---

# 🧪 Labo 5.2C 📝 Mini-projet – entrée de données



## 🎯 Objectif
Créer un programme qui demande à l'utilisateur d'entrer une chaine de caractères contenant toutes les notes d'une classe.

Le programme doit pouvoir lire les notes, les convertir en valeurs numériques, et afficher le nombre de notes lues, la moyenne de la classe, et le nombre d'échecs.

Dans notre scénario, les notes proviennent d'un autre programme et consistent en des valeurs entières séparées par un "pipe" **`|`**

**Différents ensembles de valeurs pour tests :**
> 95|92|75|48|65|23|100|92|86|82

> 62|55|42|68|72|64|100|42|68|92|28|55|46|69|85

> 0|10|20|30|40|50|60|70|80|90|100



---

## 📋 Instructions
1. Dans votre `Main()`, demandez à l'utilisateur d'entrer les notes de la classe et saisissez l'entrée dans la console.
2. Transformer le `string` saisi en un tableau de `string[]` avec la méthode `.split()`
3. Appelez la méthode `TransformerEnTableauDeInt()` et passer lui le tableau de `string[]` en paramètre. Capturez le tableau de `int[]` retourné dans une variable.
4. Appelez les fonctions `CompterNombreÉchecs()` et `CalculerMoyenne()` en leur passant le tableau de `int[]` en paramètres afin d'obtenir des statistiques.
5. Affichez le nombre de notes, la moyenne de la classe, et le nombre d'échecs (voir résultat attendu)



---


## 🛠️ Fonctions à faire
### 1.`TransformerEnTableauDeInt()`
* Prends un `string[]` en paramètre.
* Retourne un `int[]` équivalent.
1. Créez un nouveau tableau de `int[]`¸d'une même longueur que le tableau passé en paramètre.
2. Faites une boucle `for` pour passer à travers le tableau passé en paramètre. Pour chaque valeur, utiliser `int.Parse()` ou `int.TryParse()` afin d'obtenir un `int`.
4. Retournez le nouveau tableau de `int[]`.

### 2. `CompterNombreÉchecs()`
* Prends un `int[]` en paramètre.
* Retourne un `int`
Retourne le nombre de valeurs en dessous de 60 dans le tableau passé en paramètre.


### 3. `CalculerMoyenne()`
* Prends un `int[]` en paramètre.
* Retourne un `double`.
Calcule la moyenne des notes du tableau passé en paramètre.

---

## 💡 Résultat attendu lors de l'exécution :
Essayez votre programme avec les trois valeurs suivantes :
> 95|92|75|48|65|23|100|92|86|82

> 62|55|42|68|72|64|100|42|68|92|28|55|46|69|85

> 0|10|20|30|40|50|60|70|80|90|100

**Exemple 1**
```
Entrez les notes de la classe : 95|92|75|48|65|23|100|92|86|82
Il y a 10 notes.
La moyenne est : 75,80
Il y a 2 échecs
```

**Exemple 2**
```
Entrez les notes de la classe : 62|55|42|68|72|64|100|42|68|92|28|55|46|69|85
Il y a 15 notes.
La moyenne est : 63,20
Il y a 6 échecs
```

**Exemple 3**
```
Entrez les notes de la classe : 0|10|20|30|40|50|60|70|80|90|100
Il y a 11 notes.
La moyenne est : 50,00
Il y a 6 échecs
```
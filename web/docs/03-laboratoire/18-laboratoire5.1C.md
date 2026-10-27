---
title: C - Tableaux 1D – Avancé
---

# 🧠 Labo 5.1C – Tableaux et boucles `for` (avancé)

---

## 🟣 Exercice 1 – Somme et moyenne d’un tableau
🎯 **Objectif** : Parcourir un tableau pour calculer la somme et la moyenne.

🛠️ **Instructions** :
1. Créez un tableau `int[]` contenant : `10, 20, 30, 40, 50`.
2. À l’aide d’une boucle `for`, calculez la **somme** de ses valeurs.
3. Calculez ensuite la **moyenne** avec une division réelle, par exemple `(double)somme / tableau.Length`.
4. Affichez les deux résultats.

✅ **Exemple attendu** :
```
Somme : 150
Moyenne : 30
```

---

## 🟣 Exercice 2 – Trouver le maximum et le minimum
🎯 **Objectif** : Identifier la plus grande et la plus petite valeur dans un tableau.

🛠️ **Instructions** :
1. Créez un tableau `int[]` contenant : `45, 12, 99, 18, 62`.
2. Parcourez le tableau avec une boucle `for`.
3. Trouvez la **valeur maximale** et la **valeur minimale**.
4. Affichez ces deux valeurs.

✅ **Exemple attendu** :
```
Min : 12
Max : 99
```

---

## 🟣 Exercice 3 – Compter les valeurs selon une condition
🎯 **Objectif** : Compter le nombre d’éléments répondant à un critère.

🛠️ **Instructions** :
1. Créez un tableau `int[]` contenant : `2, 7, 4, 9, 12, 5`.
2. Parcourez-le avec un `for`.
3. Comptez combien de nombres sont **pairs** et combien sont **impairs**.
4. Affichez les deux résultats.

✅ **Exemple attendu** :
```
Pairs : 3
Impairs : 3
```

---

## 🟣 Exercice 4 – Créer et retourner un tableau transformé
🎯 **Objectif** : Manipuler un tableau reçu en paramètre et en créer un nouveau.

🛠️ **Instructions** :
1. Créez une fonction `int[] Doubler(int[] source)`.
2. Cette fonction crée un **nouveau tableau de même taille**.
3. Chaque case du nouveau tableau doit contenir la valeur de la case originale multipliée par 2.
4. Dans `Main()`, créez un tableau, appelez `Doubler()` et affichez le tableau retourné.

Pour conserver le retour `int[]`, on suppose que chaque valeur de `source` est comprise entre `-1073741824` et `1073741823` inclusivement : son double est alors représentable dans un `int`. Il s'agit d'une précondition de cet exercice, sans validation supplémentaire à programmer.

✅ **Exemple attendu** :
```
Tableau d'origine : 1 2 3 4
Tableau doublé : 2 4 6 8
```

**Test aux limites :** `{-1073741824, 1073741823}` doit donner `{-2147483648, 2147483646}`. Une valeur comme `1500000000` est hors des préconditions de cette version.

---

## 🟣 Exercice 5 – Inverser un tableau
🎯 **Objectif** : Créer une fonction qui retourne un tableau inversé.

🛠️ **Instructions** :
1. Créez une fonction `int[] Inverser(int[] source)`.
2. Elle crée un nouveau tableau et copie les valeurs dans l’ordre inverse.
3. Dans `Main()`, testez avec un tableau de 5 valeurs.
4. Affichez le résultat avant et après inversion.

✅ **Exemple attendu** :
```
Avant : 10 20 30 40 50
Après : 50 40 30 20 10
```

---

## 🟣 Exercice 6 – Analyse d’un tableau passé en paramètre
🎯 **Objectif** : Traiter un tableau reçu en paramètre et calculer plusieurs statistiques.

🛠️ **Instructions** :
1. Créez une fonction `void AnalyserTableau(int[] t)`.
2. Parcourez `t` avec un `for` pour calculer : **somme, moyenne, min et max**. Utilisez un `long` pour la somme : cet entier de plus grande capacité peut cumuler les valeurs `int` du tableau. Calculez la moyenne en `double` à partir de cette somme avec une division réelle; les minimum et maximum restent des `int`.
3. Affichez les résultats dans la fonction.
4. Testez dans `Main()` avec `{ 10, 20, 30, 40, 10, 40 }`, puis avec d’autres tableaux non vides.

✅ **Exemple attendu** :
```
Somme : 150
Moyenne : 25
Min : 10
Max : 40
```

**Test de capacité :** `{1500000000, 1500000000}` donne une somme de `3000000000`, une moyenne de `1500000000`, un minimum et un maximum de `1500000000`.

---

[Consulter le corrigé du laboratoire 5.1C](/solution/laboratoire-solution5.1C)

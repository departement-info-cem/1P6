---
title: B - Tableaux 1D avec conditions et fonctions
---

# 🧪 Labo 5.1B – Tableaux 1D

📎 **Référence** : [Tableau 1D – Documentation C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-1d)

---

## 🟡 Exercice 1 – Fonction qui prend un tableau de notes et retourne une moyenne pondérée
🎯 **Objectif** : Faire une fonction qui prend un `double[]` en paramètre et retourne un `double`.

🛠️ **Instructions** :
1. Déclarez un tableau `double[]` préinitialisé avec les valeurs : `{70.0, 80.5 ,90.0}`.
2. Créez une fonction **CalculerMoyenneFinale()** qui prend un tableau `double[]` en paramètre. 
3. Cette fonction doit faire une moyenne, mais la première note compte pour 30%, la deuxième pour 20%, et la troisième pour 50%.
4. Appelez la fonction et capturez son retour.

✅ **Résultat attendu** :
```
Notes : 70, 80,5, 90
Moyenne : 82,1
```

## 🟡 Exercice 2 - Ajout d'instructions conditionnelles
🎯 **Objectif** : Valider nos paramètres avec `.Length` et des if-else.

🛠️ **Instructions** :
1. Reprenez le code du dernier exercice
2. Ajoutez un if dans la fonction **CalculerMoyenneFinale()** pour vérifier qu'il y a bien **3** notes dans le tableau
3. **SI** ce n'est **pas** le cas, affichez un message "Erreur ! Il n'y a pas le bon nombre de notes !" et retournez la valeur `0.0` afin d'interrompre l'exécution de la fonction.
4. Ajoutez un second test qui valide qu'aucune des notes est en dessous de zéro.
5. **SI** une note est inférieure à zéro, affichez le message "Erreur ! Une note n'est pas valide !" et retournez la valeur `0.0`.

**Résultat attendu** : Avec trop de valeurs
```
Erreur ! Il n'y a pas le bon nombre de notes !
Notes : 70, 80,5, 90, 55
Moyenne : 0
```

**Résultat attendu** : Avec une valeur négative :
```
Erreur ! Une note n'est pas valide !
Notes : -3, 80,5, 90
Moyenne : 0
```

## 🟡 Exercice 3 - Fonction qui compare deux tableaux
🎯 **Objectif** : Faire une fonction qui prend deux tableaux `int[]` en paramètre et qui retourne le plus grand des deux.

Copiez ce code dans votre `Main()`
```csharp
int[] tab1 = { 1, 2, 3, 4, 5 };
int[] tab2 = { 11, 25, 50};

int[] reponse = ObtenirPlusGrandTableau(tab1, tab2);

Console.Write("Le plus grand tableau est : ");
Console.WriteLine(string.Join(", ", reponse));
```
Faites la fonction **ObtenirPlusGrandTableau()** afin d'obtenir le résultat suivant :

✅ **Résultat attendu** :
```
Le plus grand tableau est : 1, 2, 3, 4, 5
```

## 🟡 Exercice 4 - recherche par index

🛠️ **Instructions** :
1. Faites une fonction qui prend deux paramètres, un `int` **pIndex** et un tableau `string[]` **pTableau** et qui retourne un `string` correspondant à la valeur à l'index **SI** l'index est inférieur à la longueur du tableau et plus grand que 0.
2. Sinon, retourner le `string` "Erreur, index non valide".

Copiez ce code dans votre `Main()`
```csharp
string[] profs = { "David", "Éric", "Jamil" };

string resultat1 = ObtenirValeurParIndex(5, profs);
string resultat2 = ObtenirValeurParIndex(1, profs);

Console.WriteLine("Avec index 5 : " + resultat1);
Console.WriteLine("Avec index 1 : " + resultat2);
```
Faites la fonction **ObtenirValeurParIndex()** afin d'obtenir le résultat suivant :

✅ **Résultat attendu** :
```
Avec index 5 : Erreur, index non valide
Avec index 1 : Éric
```


---
## 🟡 Exercice 5 – Compter les lettres d’un mot
🎯 **Objectif** : Manipuler une chaîne de caractères comme un tableau de `char`.

🛠️ **Instructions** :
1. Demandez à l’utilisateur d’entrer un mot.
2. Stockez cette entrée dans une variable `string`.
3. Parcourez le mot avec une boucle `for` :
   - Affichez chaque lettre une par une.
   - Comptez combien de fois la lettre `a` (ou `A`) apparaît.
4. Affichez le nombre total de lettres et le nombre de `a`.

✅ **Résultat attendu** :
```
Mot saisi : Canada
C
a
n
a
d
a
Nombre de lettres : 6
Nombre de 'a' : 3
```
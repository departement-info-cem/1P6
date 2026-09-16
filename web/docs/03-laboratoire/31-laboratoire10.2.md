---
title: Lecture dans un fichier texte
---

# 🧪 Labo 10.2 – Lecture dans un fichier texte

📎 **Référence** : [Fichiers texte — StreamReader](https://info.cegepmontpetit.ca/notions-csharp/documentation/fichier-texte#la-classe-streamreader--lecture-dans-un-fichier-texte)

---

## 🟢 Exercice 1 : Découvrir StreamReader
**Objectif :** Lire un fichier texte ligne par ligne et afficher son contenu dans la console.

**Instructions**
1. Dans le répertoire `EspaceLabo`, créez manuellement un fichier texte nommé `sortileges.txt` contenant les lignes de suivantes:

```
Sortilège de la mort : Avada Kedavra
Sortilège de contrôle mental : Imperio
Sortilège de torture : Doloris
```

2. Dans votre programme, ouvrez le fichier en mode **lecture** avec `StreamReader`.
3. Lisez le fichier ligne par ligne à l’aide d’une boucle `while`.
4. Affichez chaque ligne dans la console.
5. Fermez le fichier une fois la lecture terminée.

✅ **Sortie attendue** :
```
Sortilège de la mort : Avada Kedavra
Sortilège de contrôle mental : Imperio
Sortilège de torture : Doloris
```

---

## 🟢 Exercice 2 : ReadLine vs ReadToEnd
**Objectif :** Explorer la différence entre `ReadLine()` (lecture ligne par ligne) et `ReadToEnd()` (lecture complète du fichier d’un coup).

**Instructions**
1. Créez manuellement un fichier texte `citations.txt` contenant 4 citations célèbres.

Exemple:
```
Je préférerais mourir d’une mort qui ait un sens plutôt que vivre une vie insignifiante. – Corazon Aquino
100 % des choses qu’on ne tente pas échouent. - Wayne Gretzky
Faites que le rêve dévore votre vie afin que la vie ne dévore pas votre rêve. - Antoine de Saint-Exupéry
Vous ne pourrez jamais traverser l’océan si vous n’avez pas le courage de perdre de vue le rivage. - Christophe Colomb
```

2. Dans votre programme, ouvrez le fichier en mode **lecture** et lisez la première ligne seulement à l’aide de `ReadLine()`.
3. Affichez le résultat dans la console et fermez le fichier.
4. Ouvrez une seconde fois le fichier en mode **lecture** et lisez tout le contenu d’un coup avec `ReadToEnd()`.
5. Affichez le résultat dans la console et fermez le fichier.

✅ **Sortie attendue** :
```
--- Lecture avec ReadLine() ---
Je préférerais mourir d’une mort qui ait un sens plutôt que vivre une vie insignifiante. – Corazon Aquino

--- Lecture avec ReadToEnd() ---
Je préférerais mourir d’une mort qui ait un sens plutôt que vivre une vie insignifiante. – Corazon Aquino
100 % des choses qu’on ne tente pas échouent. - Wayne Gretzky
Faites que le rêve dévore votre vie afin que la vie ne dévore pas votre rêve. - Antoine de Saint-Exupéry
Vous ne pourrez jamais traverser l’océan si vous n’avez pas le courage de perdre de vue le rivage. - Christophe Colomb
```

---

---

## 🟢 Exercice 3 : Découper le contenu lu avec `ReadToEnd()`
**Objectif :** Lire tout le contenu d’un fichier d’un coup, puis séparer les lignes dans un tableau 1D à l’aide de la méthode `Split()`.

**Instructions**
1. Reprenez le fichier `citations.txt` créé à l’exercice précédent.
2. Dans votre programme :
        - Ouvrez le fichier en mode **lecture**.
        - Lisez tout le contenu d’un coup avec `ReadToEnd()`.
        - Fermez le fichier.
4. Séparez le texte obtenu dans un tableau 1D en utilisant la méthode `Split()` sur le caractère de fin de ligne.
5. Affichez le contenu de la dernière ligne du tableau.

✅ **Sortie attendue** :
```
Vous ne pourrez jamais traverser l’océan si vous n’avez pas le courage de perdre de vue le rivage. - Christophe Colomb
```

---


## 🟡 Exercice 4 : Créer et relire un fichier ✍️📖
**Objectif :** Fusionner l’écriture (séance 9.1) et la lecture (9.2) : créer un fichier, y écrire des données, puis les relire.

**Instructions**
1. Demandez à l’utilisateur d’entrer 3 objectifs personnels pour l’année.
2. Écrivez ces objectifs dans un fichier `objectifs.txt` à l’aide d’un `StreamWriter`.
3. Une fois l'écriture complétée, ouvrez le fichier en mode **lecture** avec un `StreamReader` et affichez chaque ligne dans la console.

**Astuce** : Utilisez un tableau 1D !

✅ **Exemple** :
```
--- Console ---
Entrez votre objectif 1 : Finir ma session avec succès.
Entrez votre objectif 2 : M’entraîner 3 fois par semaine.
Entrez votre objectif 3 : Partir en voyage l'été prochain.
Les objectifs ont été enregistrés !

--- objectifs.txt ---
Finir ma session avec succès.
M’entraîner 3 fois par semaine.
Partir en voyage l'été prochain.

--- Console ---
Mes objectifs sont :
Finir ma session avec succès.
M’entraîner 3 fois par semaine.
Partir en voyage l'été prochain.

```


---

## 🟡 Exercice 5 : Ajouter et relire du contenu existant 🧾
**Objectif :** Ajouter du texte **sans écraser le contenu existant**, puis le relire.

**Instructions**
1. Vérifiez si le fichier `objectifs.txt` existe avec `File.Exists()`.
2. Si le fichier existe, ouvrez-le avec un `StreamWriter` en mode ajout.
3. Ajoutez deux nouveaux objectifs et fermez le fichier.
4. Rouvrez le fichier avec `StreamReader` et affichez son contenu complet.

✅ **Exemple** :
```
--- Console ---
Finir ma session avec succès.
M’entraîner 3 fois par semaine.
Partir en voyage l'été prochain.
Lire 5 livres cette année.
Économiser pour un voyage.
```

---

## 🔴 Exercice 6 : Sauvegarder et relire un tableau 1D 🎵
**Objectif :** Écrire le contenu d’un tableau 1D dans un fichier texte, puis le relire pour afficher les éléments dans la console.

**Instructions**
1. Créez un tableau 1D de chaînes de caractères représentant vos 5 repas préférés.
2. Écrivez les repas dans un fichier `mes_repas_prefs.txt` à l’aide de `StreamWriter`.
3. Rouvrez le fichier avec un `StreamReader` et affichez chaque repas dans la console.

✅ **Exemple** :
```
--- mes_repas_prefs.txt ---
Pizza hawaiennne
Pizza toute garnie
Pizzaghetti
Pizza Meat Lover
Pizza aux artichauts et aux olives noires

--- Console ---
Voici vos repas préférés :
Pizza hawaiennne
Pizza toute garnie
Pizzaghetti
Pizza Meat Lover
Pizza aux artichauts et aux olives noires
```

---

## 🔴 Exercice 7 : Manipuler une matrice 2D 🔢 (avant-goût de la séance 10.1)
**Objectif :** Écrire et relire une matrice de nombres dans un fichier texte.

**Instructions**
1. Créez un tableau 2D (3x3) d’entiers.
2. Écrivez la matrice dans un fichier `matrice.txt` (chaque ligne contient les 3 entiers **séparés par un espace**).
3. Lisez ensuite le fichier et affichez le contenu dans la console (1 entier par ligne).

✅ **Exemple**
```
--- matrice.txt ---
1 2 3
4 5 6
7 8 9

--- Console ---
1
2
3
4
5
6
7
8
9
```

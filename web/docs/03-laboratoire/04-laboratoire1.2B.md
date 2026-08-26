---
title: B - Exercices pratiques - Variables, affectation, opérations
---

# 🧪 Labo 1.2A – Variables, affectation, opérations

---

## 🟢 J'applique

### 🟢 Exercice 1 – Déclarer et initialiser des variables

🎯 **Objectif** : Appliquer la déclarartion, le choix de type et l'initialisation des variables.

Écrire un programme qui permet de manipuler des informations d'un étudiant.

🛠️ **Instructions** :
- Déclare une variable `string` nommée `prenom` et donnez-lui la valeur "Adam".
- Déclare une variable `string` nommée `nom` et donnez-lui la valeur "Gammoudi".
- Déclare une variable `int` nommée `age` et donnez-lui la valeur 3.
- Déclare une variable `double` nommée `moyenne` et donnez-lui la valeur 82.5.
- Déclare une variable `char` nommée `initiale` et donnez-lui la valeur `A`
- Déclare une variable `bool` nommée `estInscrit` et donnez-lui la valeur `true`
- Affichez toutes les informations saisies

✅ **Sortie attendue** :
```plaintext
Prénom : Adam
Nom : Gammoudi
Âge : 3
Moyenne : 82,5
Initiale : A
Inscrit : True
```

### 🟢 Exercice 2 – Saisie des données et conversion

🎯 **Objectif** : Pratiquer la saisie et la conversion

Écrire un programme qui permet à un étudiant de saisir ses informations et les afficher

🛠️ **Instructions** :
- Demander le prénom de l'étudiant
- Lire la saisie et l'affecter à une variable `prenom`
- Demander le nom de l'étudiant
- Lire la saisie et l'affecter à une variable `nom`
- Demander l'âge de l'étudiant
- Lire la saisie, la convertir en `int` et l'affecter à une variable `age`
- Demander la moyenne de l'étudiant
- Lire la saisie, la convertir en `double` et l'affecter à une variable `moyenne`
- Affichez toutes les informations saisies



✅ **Sortie attendue** :
```plaintext
Prénom : Adam
Nom : Gammoudi
Âge : 3
Moyenne : 82,5

--- Informations ---
Prénom : Adam
Nom : Gammoudi
Âge : 3
Moyenne : 82,5
```


### 🟢 Exercice 3 – Concaténation de chaînes  
🎯 **Objectif** : Utiliser l’opérateur `+` pour concaténer du texte.

🛠️ **Instructions** :
- Déclare une variable `string` nommée `prenom` et lui affecter "Adam".
- Déclare une variable `string` nommée `nom` et lui affecter "Gammoudi".
- Déclare une variable `string` nommée `nomComplet` et lui affecter prenom + " " + nom.
- Afficher le contenu des trois variables

✅ **Entrée/Sortie attendue** :
```plaintext
Prénom : Adam
Nom : Gammoudi
Nom complét : Adam Gammoudi
```

---


### 🟢 Exercice 4 – Coût d'un produit

🎯 **Objectif** : Pratiquer des opérations arithmétiques

Écrire un programme qui permet d'afficher le coût d'un produit.

🛠️ **Instructions** :

- Déclarer une variable `string` nommée `nomProduit` et donnez-lui la valeur "Clavier".
- Déclarer une variable `double` nommée `PrixUnitaire` et donnez-lui la valeur 15.99.
- Déclarer une variable `int` nommée `quantite` et donnez-lui la valeur 3.
- Déclarer une variable `double` nommée `sousTotal`.
- Multiplier le `prixUnitaire` par la `quantite` et placez le résultat dans la variable `sousTotal`
- Affichez le nom du produit, son prix unitaire, la quantité achetée et le sous-total.


✅ **Entrée/Sortie attendue** :
```plaintext
Produit : Clavier
Prix unitaire : 15,99 $
Quantité : 3
Sous-total : 47,97 $
```

---


### 🟢 Exercice 5 – Emballer des produits dans des boîtes
🎯 **Objectif** : Pratiquer la division entière et le modulo

Écrire un programme qui permet de déterminer le nombre de boîtes nécessaires pour emballer un certains nombre de produits ainsi que le nombre de produits restants.

🛠️ **Instructions** :
- Déclarez une variable `int` nommée `nombreProduits` et initialisez-la à 47.
- Déclarez une variable `int` nommée `nbProduitsParBoites` et initialisez-la à 6.
- Déclarez une variable `int` nommée `nombreBoites`.
- Utilisez la divison entière `/` pour calculer le nombre de boîtes complétées et placer le résultat dans `nombreBoites`.
- Déclarer une variable `int` nommée `nbProduitsRestants`.
- Utilisez le modulo `%` pour calculer le nombre de produits restants et placez le résultat dans `nbProduitsRestants`.
- Affichez le nombre de boîtes et le nombre de produits restants.


✅ **Sortie attendue** :
```plaintext
Nombre de boîtes complétées : 7
Nombre de produits restants : 5
```

---
## 🟣 Je résous

### 🟣 Exercice 6 – Moyenne de deux notes  

🛠️ **Instructions** :

Écrire un programme qui permet de calculer et afficher la moyenne de deux nombres.

✅ **Entrée/Sortie attendue** :
```plaintext
Note 1 : 75,5
Note 2 : 82,0
Moyenne : 78,75
```

---

### 🟣 Exercice 7 – Le double d'un nombre  

🛠️ **Instructions** :

Écrire un programme qui permet de calculer et afficher le double d'un nombre.

✅ **Entrée/Sortie attendue** :
```plaintext
Prix : 15,50
Double du prix : 31
```

---

### 🟣 Exercice 8 – Permutation de deux valeurs  
🎯 **Objectif** : Échanger le contenu de deux variables.

🛠️ **Instructions** :
- Demande deux nombres.
- Échange-les.
- Affiche le résultat.

✅ **Entrée/Sortie attendue** :
```plaintext
Nombre A : 4
Nombre B : 7
Après permutation : A = 7, B = 4
```


---
##  ⚫ Je relève le défi

### ⚫ Exercice 9 – Fiche Animal  

🛠️ **Instructions** :

Écrire un programme qui permet de recueillir les informations d'un animal et de les afficher.

L'utilisateur doit fournir :
- le nom de l'animal
- son age
- son poids en kilogrammes
- son sexe : F pour femelle et M pour male
- s'il est vacciné ou non

Utilisez les types appropriés pour stocker les informations.
Affichez ensuite toutes les informations saisies.


✅ **Entrée/Sortie attendue** :
```plaintext
Nom de l'animal : Luna
Âge : 4
Poids (kg) : 12,5
Sexe (F/M) : F
Vacciné (true/false) : true

--- Informations de l'animal ---
Nom : Luna
Âge : 4
Poids : 12,5 kg
Sexe : F
Vacciné : True
```

### ⚫ Exercice 10 – Location de vélo  

🛠️ **Instructions** :

Écrire un programme qui permet de calculer le coût d'une location de vélo.

L'utilisateur doit fournir :
- la durée de location en heures
- le tarif de location par heure

Le programme doit afficher la durée, le traif horaire et le coût total.


✅ **Entrée/Sortie attendue** :
```plaintext
Durée de location (heures) : 4
Tarif par heure : 8,50

Durée : 4 heures
Tarif horaire : 8,50 $
Coût total : 34,00 $
```


### ⚫ Exercice 11 – Conversion de température 
🎯 **Objectif** : Appliquer une formule de conversion de température

🛠️ **Instructions** :

Écrire un programme qui permet de convertir une température de Celcius en Fahrenheit et afficher le résultat. 

- L'utilisateur doit fourni la température en Celcius

- La formule pour effectuer la conversion est la suivante :

`Température en Fahrenheit = Température en Celcius * 9 / 5 + 32`


✅ **Exemple attendu** :
```
Température : 25,2
En Fahrenheit : 77,36

```


---

### ⚫ Exercice 12 – Calcul de taxes et pourboire
🎯 **Objectif** : Lire un prix, ajouter 15 % de taxes et 10 % de pourboire.

🛠️ **Instructions** :
Écrire un programme qui calcule et affiche le total à payer d'un repas en ajoutant : 
- une taxe de 15% 
- un pourboire de 10% calculé sur le prix du repas avant taxe.

Le client entre le prix du repas avant taxe.

✅ **Exemple attendu** :
```
Prix du repas : 20,00 $
Taxe de 15 % : 3,00 $
Pourboire de 10 % : 2,00 $
Total à payer : 25,00 $
```

---

### ⚫ Exercice 13 – Conversion de minutes

🛠️ **Instructions** :
- Demandez un nombre de minutes à l’utilisateur
- Calculez le nombre d’heures et de jours complets
- Affichez les résultats

✅ **Exemple attendu** :
```
Minutes : 1500
Heures : 25
Jours : 1
```

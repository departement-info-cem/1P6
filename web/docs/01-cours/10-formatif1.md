---
description: Formatif 1
---

# Examen formatif 1
**Voici 10 exercices qui vous aideront à pratiquer les notions vues en classe.**  
Le jour de l'examen, on vous donnera des fichiers de départ et/ou une description du résultat attendu.  
L'examen sera plus court que cette pratique ⚠️  
  
🦾🧠 Bonne pratique!  

## 1. Types de variables et expressions arithmétiques

### 💵 1.1. Programme console qui calcule le salaire d’un employé et affiche ses informations.

#### Instructions :

- Dans la fonction `Main` :
  - Demander le nom de l’employé, le nombre d’heures travaillées par semaine et le taux horaire.
    - Utilisez des variables pour stocker chaque donnée en considérant le type.
  - Calculer, dans une nouvelle variable, le salaire hebdomadaire : Heures par semaine * Taux horaire.
  - Afficher, dans une seule ligne, les informations de l’employé.
- Tester votre programme avec le cas suivant :

#### Sortie attendue :

```
==================LA PAIE=================  
Nom de l’employé : Mario  
Nombre d’heures : 32,5  
Taux horaire : 19,75  

Mario a travaillé 32,5 h par semaine avec un taux horaire de 19,75$. Son salaire est de 641,88$.  
```

---

## 2. Structures conditionnelles simples

### ☀️2.1. Programme console qui valide la température

#### Instructions :

- Dans la fonction `Main` :
  - Demander une température en Celsius. Considérer des valeurs entières.
  - Afficher un message selon la température :
    - Température supérieure à 16, afficher « Il fait chaud! »
    - Température entre 12 et 16 inclusivement, afficher « C’est agréable! »
    - Température entre 5 et 11 inclusivement, afficher « C’est frais! »
    - Température égale à 4 ou moins, afficher : « Il fait froid »
- Tester votre programme avec les cas suivants :
 
| Température | Message |
|---------|---------|
| 17 | Il fait chaud! |
| 16 | C’est agréable! |
| 15 | C’est agréable! |
| 12 | C’est agréable! |
| 11 | C’est frais! |
| 10 | C’est frais! |
| 5 | C’est frais! |
| 4 | Il fait froid |
| 3 | Il fait froid |


#### Entrée / Sortie attendue :
```
Quelle est la température : 15
C'est agréable!
```

---

### 🎲 2.2. Calcul du score d'une équipe de deux joueurs avec des dés  
Chaque joueur d’une équipe doit lancer un dé à 6 faces. Le programme doit calculer et afficher le score de l’équipe selon les règles suivantes :  
- Si les deux dés valent 6, le score est 100.
- Si les deux dés valent 5 ou 4, le score est 75.
- Si les deux dés sont identiques (même valeur), le score est 50.
- Dans tous les autres cas, le score correspond à la somme des deux dés.


#### Instructions :

- Dans la fonction `Main` :
  - Générer aléatoirement deux nombres entre 1 et 6.
  - Calculer le score de l’équipe en fonction des règles du jeu.
  - Afficher le score.
- Tester votre programme avec des valeurs aléatoires.
- Tester votre programme avec des valeurs non aléatoires données dans les exemples d’exécution.
 

#### Exemples d’exécution :
```
Dé 1 = 6, Dé 2 = 6 → Score = 100
Dé 1 = 5, Dé 2 = 5 → Score = 75
Dé 1 = 4, Dé 2 = 4 → Score = 75
Dé 1 = 3, Dé 2 = 3 → Score = 50
Dé 1 = 2, Dé 2 = 2 → Score = 50
Dé 1 = 2, Dé 2 = 6 → Score = 8
```

---

## 3. Fonctions et structures conditionnelles

### 🪙 3.1. Programme console qui calcule et affiche un prix après taxes selon la province choisie

#### Instructions :

- Dans la fonction `Main` :
  - Demander le prix d’un article et de choisir une province.
  - Utiliser une fonction `CalculerPrixApresTaxes` pour calculer le prix après taxe, puis afficher le résultat.
- La fonction `CalculerPrixApresTaxes` :  
  - Accepte en paramètre le prix de l’article et le choix de la province.  
  - Elle calcule et retourne le prix après taxe selon la province choisie.  
  - Considérer le taux de taxation selon la province comme suit :  
    - Québec : 15%  
    - Ontario : 13%  
    - Autres : 12%
- Tester votre programme pour les 3 provinces.

#### Entrée / Sortie attendue :
```
Prix de l’article : 100
Choisir la province? 1)QC, 2) ON, 3) Autre.
Votre choix : 1
Prix après taxes : 115,00$

Prix de l’article : 100
Choisir la province? 1)QC, 2) ON, 3) Autre.
Votre choix : 2
Prix après taxes : 113,00$

Prix de l’article : 100
Choisir la province? 1)QC, 2) ON, 3) Autre.
Votre choix : 3
Prix après taxes : 112,00$
```

---

### 🔤 3.2. Programme console qui formate le nom d’un étudiant

#### Instructions :

- Dans la fonction `Main` :
  - Demander le prénom et le nom de famille de l’étudiant.
  - Utiliser une fonction `FormaterNom` pour obtenir le nom formaté, puis afficher le résultat.
- La fonction `FormaterNom` :
  - Accepte en paramètre un prénom et un nom de famille.
  - Elle retourne une chaîne contenant le nom de famille **en majuscules**, suivi d’une virgule et du prénom.
    - **Indice :** Utiliser la fonction ToUpper()
- Tester votre programme.


#### Entrée / sortie attendue :
```
------------------Je formaterai votre nom------------------
Entrez votre prénom : Mario
Entrez votre nom : Tremblay
Nom formaté : TREMBLAY, Mario
```

---

## 4. Boucle For et fonctions avec paramètres et retour

### 🔢 4.1. Programme console qui compte les multiples d’un nombre

#### Instructions

- Dans la fonction `Main` :
  - Demander de rentrer une limite (nombre entier positif) et un diviseur.
  - Utiliser une fonction `CompterMultiples` pour calculer combien de nombres entre 1 et la limite sont des multiples du diviseur, puis afficher le résultat.  
- La fonction `CompterMultiples` :
  - Accepte en paramètre la limite et le diviseur.
  - Elle calcule et retourne le nombre de multiples du diviseur entre 1 et la limite (inclusivement). Utiliser une boucle pour parcourir les nombres.
    - **Indice :** Un nombre est un multiple du diviseur si le reste de la division (`%`) vaut 0.
- Tester votre programme.


#### Entrée / Sortie attendue :
```
Entrez une limite : 20
Entrez un diviseur : 3
Il y a 6 multiples de 3 entre 1 et 20
```

---

### ➕ 4.2. Programme console qui calcule la somme des carrés

#### Instructions

- Dans la fonction `Main` :
  - Demander de rentrer un nombre entier positif N.
  - Utiliser une fonction `SommeDesCarres` pour calculer la somme des carrés des N premiers entiers, puis afficher le résultat.  
- La fonction `SommeDesCarres` :
  - Accepte en paramètre un nombre entier positif N
  - Elle calcule et retourne la somme des carrées des N premiers entiers qu’on peut l’obtenir comme suit :
  - Exemple : SommeDesCarres(5) = 1<sup>2</sup> + 2<sup>2</sup> + 3<sup>2</sup> + 4<sup>2</sup> + 5<sup>2</sup>
- Tester votre programme.
 

#### Entrée / Sortie attendue :
```
---Je peux vous aider à calculer la somme des carrés---
Entrez un nombre : 5
Le résultat est : 55
```

---

## 5. Intégration : boucles, conditions et fonctions

### 📊 5.1. Programme console qui calcule les statistiques d’un groupe de notes

#### Instructions

- Dans la fonction `Main` :
  - Demander le nombre de notes à saisir.
  - Utiliser une boucle pour demander chacune des notes (valeurs décimales).
  - Pendant la boucle, calculer la somme des notes, la note la plus haute et la note la plus basse.
  - Calculer la moyenne, puis utiliser la fonction `DeterminerMention` pour obtenir la mention associée.
  - Afficher la moyenne (2 décimales), la note la plus haute, la note la plus basse et la mention.
- La fonction `DeterminerMention` :
  - Accepte en paramètre une moyenne.
  - Elle retourne la mention selon la moyenne :
    - 90 et plus : « Excellent »
    - 75 à moins de 90 : « Très bien »
    - 60 à moins de 75 : « Réussite »
    - Moins de 60 : « Échec »
- Tester votre programme.

#### Entrée / Sortie attendue :
```
Combien de notes : 4
Note 1 : 85
Note 2 : 72,5
Note 3 : 91
Note 4 : 64,5

Moyenne : 78,25
Note la plus haute : 91
Note la plus basse : 64,5
Mention : Très bien
```

---

### 🎯 5.2. Jeu : deviner un nombre secret

#### Instructions

- Dans la fonction `Main` :
  - Générer aléatoirement un nombre secret entre 1 et 20.
  - Utiliser une boucle `for` qui donne **au maximum 5 essais** au joueur.
    - La boucle doit s’arrêter dès que le joueur trouve le nombre.
      - **Indice :** Utiliser une variable `bool` dans la condition de la boucle.
  - À chaque essai, demander un nombre et afficher le message retourné par la fonction `ComparerNombres`.
  - Après la boucle, afficher « Bravo! Trouvé en X essai(s). » ou « Perdu! Le nombre était X. »
- La fonction `ComparerNombres` :
  - Accepte en paramètre l’essai du joueur et le nombre secret.
  - Elle retourne « Trop petit! », « Trop grand! » ou « Exact! ».
- Tester votre programme avec des valeurs aléatoires.
- Tester votre programme avec un nombre secret fixe (ex. : 13) pour vérifier les deux fins possibles.

#### Exemple d’exécution (nombre secret : 13) :
```
Essai 1 : 10
Trop petit!
Essai 2 : 15
Trop grand!
Essai 3 : 13
Exact!
Bravo! Trouvé en 3 essai(s).
```

---

### 🔲 5.3. Programme console qui dessine un rectangle creux

#### Instructions

- Dans la fonction `Main` :
  - Demander la largeur et la hauteur du rectangle.
  - Appeler la fonction `DessinerRectangle`.
- La fonction `DessinerRectangle` :
  - Accepte en paramètre une largeur et une hauteur.
  - Ne retourne rien : elle affiche le rectangle dans la console.
  - Utiliser deux boucles imbriquées : afficher `*` sur le contour (première et dernière ligne, première et dernière colonne) et un espace à l’intérieur.
- Tester votre programme avec plusieurs dimensions (ex. : 6 × 4, 3 × 3, 10 × 2).

#### Entrée / Sortie attendue :
```
Largeur : 6
Hauteur : 4
******
*    *
*    *
******
```

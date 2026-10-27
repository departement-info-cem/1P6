---
title: B - Switch... case, While et Do... while – Simple
---

# 🧪 Labo 8.2B - Switch... case, While et Do... while – Simple

📎*Référence* : [Switch... case](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/switch-case) | [While](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/while) | [Do... while](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/do-while)  | [TryParse](https://info.cegepmontpetit.ca/1P6/cours/integration-fonctions#-quest-ce-que-tryparse-)


## 🔢Switch... case
### 🔵 Exercice S1.1 - Les jours de la semaine
🎯 **Objectif** : Comprendre la déclaration et l’affichage d’éléments avec `Switch case`.

🛠️ **Instructions :**
* Demandez à l'utilisateur de saisir un chiffre entier entre 1 et 7.
* Affichez le jour de la semaine correspondant au chiffre (dimanche = 1, etc.).
* Utilisez `TryParse` pour valider l'information saisie.

✅ **Entrée / sortie attendue :**

~~~
Donne moi un numéro de jour de la semaine : 4
Le jour 4 est le : Mercredi
~~~

---

### 🔵 Exercice S1.2 – Les mois de l’année

🎯 **Objectif** : Afficher le mois selon un numéro donné, utiliser la case défaut.
🛠️ **Instructions :**
* Demandez un nombre entier entre 1 et 12.
* Affichez le mois associé.
* Utilisez `TryParse` pour valider l'information saisie.
* Si la valeur entrée est invalide, utilisez la case `default` pour afficher : ERREUR.


✅ **Entrée / sortie attendue :**
~~~
Donne-moi un numéro de mois (1-12) : 0
ERREUR
-----------
Donne-moi un numéro de mois (1-12) : 8
Le mois 8 correspond à août.
~~~

---

### 🔵 Exercice  S1.3 – Calculer l’aire 1.0
🎯 **Objectif** : Afficher des formules selon un choix.
🛠️ **Instructions :**
* Proposez un menu d'options offrant différentes formes géométriques.
* Selon le choix de l’utilisateur, affichez la formule qui permet de calculer l’aire de la forme choisie.
* Utilisez `TryParse` pour valider l'information saisie.

**Rappel :**
Carré : côté * côté
Rectangle : longueur * largeur
Cercle : 3.1416 * (rayon * rayon)
Triangle : (base × hauteur) /2

✅ **Entrée / sortie attendue :**
~~~
=== Bienvenue dans votre assistant de calcul d’aire v1.0! ===
Quelle formule désirez-vous consulter :
1.	Carré
2.	Rectangle
3.	Cercle
4.	Triangle
Votre choix : 2
Pour calculer l'aire d'un rectangle faites : longueur * largeur
~~~

---

### 🔵 Exercice S1.4 – Classes de permis 1.0

Ce tableau est un **jeu de données fictif et simplifié** pour pratiquer `switch`. Il ne décrit pas les classes officielles d’une province ou d’un pays.
🎯 **Objectif** : Afficher le type de véhicule autorisé selon la classe
🛠️ **Instructions :**
* Demandez un nombre entier entre 1 et 8.
* Affichez les informations qui correspondent à la classe de permis (voir tableau).
* Utilisez `TryParse` pour valider l'information saisie.
* Déclarez un tableau de `string` de 9 rangées et 2 colonnes, initialisez avec les informations suivantes :
```csharp
string[,] permis = {
    { "C", "Véhicule"},
    { "1", "Tous"},
    { "2", "Autobus 24p+"},
    { "3", "Camion"},
    { "4", "Véhicules d'urgence"},
    { "5", "Automobiles"},
    { "6", "Motocyclettes"},
    { "7", "Apprenti"},
    { "8", "Tracteur"},};
```

|Classe|Véhicule|
|---|---|
|1|Tous|
|2|Autobus 24p+|
|3|Camion|
|4|Véhicules d’urgence|
|5|Automobile|
|6|Motocyclettes|
|7|Apprenti|
|8|Tracteur|

✅ **Entrée / sortie attendue :**
~~~
Quelle classe de permis voulez-vous vérifier (1-8) ? 7
La classe 7 autorise la conduite pour : Apprenti
~~~
---

### 🔵 Exercice S1.5 – Cinéma 1.0
🎯 **Objectif** : Afficher un titre selon le numéro entré.
🛠️ **Instructions :**
* Déclarez et initialisez le tableau suivant :
```csharp
string[] filmsHarry = {
    "À l'école des sorciers (2001)",
    "La Chambre des secrets (2002)",
    "Le Prisonnier d'Azkaban (2004)",
    "La Coupe de feu (2005)",
    "L'Ordre du Phénix (2007)",
    "Le Prince de sang-mêlé (2009)",
    "Les Reliques de la Mort, partie 1 (2010)",
    "Les Reliques de la Mort, partie 2 (2011)"
};
```

* Demandez un numéro entre 1 et 8 pour choisir un film.
* Affichez le titre correspondant.
* Utilisez `TryParse` pour valider l'information saisie.
* Si la valeur entrée est invalide, affichez ERREUR.

| Film |
| --- |
| À l'école des sorciers (2001) |
| La Chambre des secrets (2002) |
| Le Prisonnier d'Azkaban (2004) |
| La Coupe de feu (2005) |
| L'Ordre du Phénix (2007) |
| Le Prince de sang-mêlé (2009) |
| Les Reliques de la Mort, partie 1 (2010) |
| Les Reliques de la Mort, partie 2 (2011) |

✅ **Entrée / sortie attendue :**
~~~
Quel film de Harry Potter voulez vous consulter? 3
Le Prisonnier d'Azkaban (2004)
~~~

---

## 🌀WHILE
### 🔵 Exercice W1.1 – Compter de 1 à 100
🎯 **Objectif :** Afficher les valeurs de 1 à 100 à l’aide de `While`.
✅ **Sortie attendue :**
~~~
1
2
3
…
100
~~~

---

### 🔵 Exercice W1.2 – Demander le code secret
🎯 **Objectif :** Répéter une question
🛠️ **Instructions :**
* Demandez « T’es qui, toi ? » jusqu’à obtenir exactement `Moi` (majuscule initiale).

✅ **Entrée / sortie attendue :**
~~~
T’es qui, toi? Charles
Mauvaise réponse… Essaie toi encore ;)
T’es qui, toi? Moi
Bonne réponse ! :D
~~~
---

### 🔵 Exercice W1.3 – Afficher le budget
🎯 **Objectif :** Afficher un budget, jusqu’à épuisement
🛠️ **Instructions :**
* Déclarez une variable budget de 100$.
* Affichez le budget initial.
* Demandez un montant entier positif ou nul dépensé, tant qu’il reste du budget. Une saisie invalide ou négative ne doit pas modifier le budget.
* Utilisez `TryParse` pour valider l'information saisie.
* Si le budget devient 0 ou négatif, affichez un message.

✅ **Entrée / sortie attendue :**
~~~
Ton budget : 100$
Combien as-tu dépensé?
50
Il te reste: 50
Combien as-tu dépensé?
60
Il te reste: -10
Oh no, pas encore!
~~~
---

### 🔵 Exercice W1.4 – Quelle est la moitié de…
🎯 **Objectif :** Répéter une question
🛠️ **Instructions :**
* Demandez un nombre.
* Tant que la valeur courante est supérieure à `0.5`, divisez-la par 2 puis affichez le résultat. La dernière valeur affichée peut donc être inférieure ou égale à `0.5`.
* Utilisez `TryParse` pour valider l'information saisie.

✅ **Entrée / sortie attendue :**
~~~
Trouvons la moitié de :50
25
12,5
6,25
3,125
1,5625
0,78125
0,390625
~~~
---

### 🔵 Exercice W1.5 – Les amis à Harry
🎯 **Objectif :** Répéter une question, deux réponses possibles
🛠️ **Instructions :**
* Demandez le nom de l’ami à Harry Potter.
* Répéter la question tant que la réponse n’est pas Hermione ou Ron.

✅ **Entrée / sortie attendue :**
~~~
Nommez un des amis de Harry Potter : Draco
Nommez un des amis de Harry Potter : Voldemort
Nommez un des amis de Harry Potter : Ron
~~~
---

## ➡️🌀DO WHILE
### 🔵 Exercice DW1.1 – Majeurs
🎯 **Objectif :** Poser une question, répéter jusqu’à obtenir une des bonnes réponses
🛠️ **Instructions :**
* Dans ce jeu, demandez à l’utilisateur un des deux âges acceptés : 18 ou 21.
* Répéter la question tant qu’elle est différente de deux réponses possibles, soit 18 ou 21. Il s’agit des réponses choisies pour le jeu, pas d’une règle juridique générale.
* Utilisez `TryParse` pour valider l'information saisie.

✅ **Entrée / sortie attendue :**
~~~
À quel âge on devient majeur ? 15
À quel âge on devient majeur ? 17
À quel âge on devient majeur ? 18
~~~
---

### 🔵 Exercice DW1.2 – Les épargnes
🎯 **Objectif :** Répéter une question
🛠️ **Instructions :**
* Demande à l’utilisateur combien veut-il épargner ce mois-ci.
* Utilisez `TryParse` pour valider l'information saisie.
* Répétez jusqu’à obtenir zéro. Refusez les montants négatifs et les saisies non numériques, sans les ajouter au total.
* Afficher le montant total des économies.

✅ **Entrée / sortie attendue :**
~~~
Combien désirez-vous épargner ce mois-ci? 50
Combien désirez-vous épargner ce mois-ci? 10
Combien désirez-vous épargner ce mois-ci? 30
Combien désirez-vous épargner ce mois-ci? 0

----------------------------------------
Vous avez cumulé : 90,00 $
~~~
---

### 🔵 Exercice DW1.3 – Quai de Harry Potter
🎯 **Objectif :** Répéter une question jusqu’à avoir la bonne réponse
🛠️ **Instructions :**
* Demander à l’utilisateur d’entrer le numéro de quai de Harry Potter (en décimal).
* Répéter la question tant qu’elle est différente de 9.75
* Utilisez `TryParse` pour valider l'information saisie.

✅ **Entrée / sortie attendue :**
~~~
Quel est le numéro de quai de Harry Potter ? 3
Quel est le numéro de quai de Harry Potter ? 9
Quel est le numéro de quai de Harry Potter ? 9,75
~~~
---

[Consulter le corrigé du laboratoire 8.2B](/solution/laboratoire-solution8.2B)

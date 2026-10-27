---
title: C - Switch... case, While et Do... while – Avancé
---

# 🧪 Labo 8.2C - Switch... case, While et Do... while – Avancé

## 🔢Switch... case
### 🟣 Exercice S2.1 – Calculer l’aire 2.0
🎯 **Objectif :** Pratiquer Switch ... case et les fonctions
🛠️ **Instructions :**
* Reprenez votre exercice « S1.3 Calculer l’aire 1.0 »
* Renommez comme « S2.1 Calculer l’aire 2.0 »
* Chaque case appellera une fonction qui demandera les informations nécessaires pour calculer l’aire de la forme choisie
* Affichez le résultat obtenu

✅ **Entrée / sortie attendue :**
~~~
=== Bienvenue dans votre assistant de calcul d’aire v2.0! ===
Pour quelle forme désirez-vous calculer l'aire :
1.	Carré
2.	Rectangle
3.	Cercle
4.	Triangle

Votre choix : 2

--- Calculer l'aire d'un rectangle ---
Quelle est la longueur : 2
Quelle est la largeur : 3
L'aire d'un rectangle 2 X 3 est de : 6

~~~
---

### 🟣 Exercice S2.2 – Classes de permis 2.0
🎯 **Objectif :** Pratiquer Switch ... case, les tableaux 2D et les icônes
🛠️ **Instructions :**
* Reprenez l’exercice « S1.4 – Classes de permis 1.0 »
* Renommez comme « S2.2 – Classes de permis 2.0 »
* Le tableau fictif de l’exercice S1.4 est conservé. Affichez-le au complet
* À l'aide de Switch... case, demandez à l'utilisateur à quelle classe de permis il veut ajouter une icône
* Dans chaque case, appelez une fonction qui :
  * Recevra en paramètre : le tableau, le choix de classe et une icône
  * Ajouter l'icône (représentant le véhicule en question) à côté de la classe de permis
  * Réafficher le tableau :
    * Le numéro de classe, suivi de l'icône, suivi du titre du permis

**DÉFI** : Permettre d'ajouter des icônes aux autres classes, jusqu'à demander de quitter (Piste : Utilisez `Do... while`)

➡️ Pour les icônes, voir section [Extra](https://info.cegepmontpetit.ca/1P6/extra/style)

✅ **Entrée / sortie attendue :**
~~~
Classes de permis de conduire v2.0
*************************************
C  Véhicule
1  Tous
2  Autobus 24p+
3  Camion
4  Véhicules d'urgence
5  Automobiles
6  Motocyclettes
7  Apprenti
8  Tracteur


 Votre choix : 4


Classes de permis de conduire v2.0
*************************************
C  Véhicule
1  Tous
2  Autobus 24p+
3  Camion
4 🚑 Véhicules d'urgence
5  Automobiles
6  Motocyclettes
7  Apprenti
8  Tracteur
~~~

**Avec Défi :**

~~~
=== S2.2 – Classes de permis 2.0 ===
*************************************
C - Véhicule
1 🏎️ - Tous
2 🚌 - Autobus 24p+
3 🚛 - Camion
4 🚑 - Véhicules d'urgence
5 - Automobiles
6 - Motocyclettes
7 - Apprenti
8 - Tracteur

À quelle classe voulez-vous ajouter une icône ? (1 à 8, 9 pour quitter) :
~~~
---

### 🟣 Exercice S2.3 – Cinéma 2.0
🎯 **Objectif :** Pratiquer le switch... case, les tableaux 1D et les couleurs
🛠️ **Instructions :**
* Reprenez l’exercice « S1.5 – Cinéma 1.0 »
* Renommez comme « S2.3 –Cinéma 2.0 »
* Créez un tableau. Ajoutez comme valeurs les titres des films.
* Affichez d’abord la liste complète des huit films. Pour chaque film, utilisez la couleur `(ConsoleColor)(i + 1)`, où `i` est son indice (0 à 7), puis restaurez les couleurs. Le décalage de 1 évite la couleur noire. Demandez ensuite le numéro du film à consulter (1 à 8) et affichez son titre.

➡️ Regardez `Console.ForegroundColor = (ConsoleColor)(i + 1);` pour vous aider
Ou encore la section [Extra](https://info.cegepmontpetit.ca/1P6/extra/style)

✅ **Sortie attendue :**
~~~
-----------------Les films de Harry Potter--------------------------

1. À l'école des sorciers (2001)
2. La Chambre des secrets (2002)
3. Le Prisonnier d'Azkaban (2004)
4. La Coupe de feu (2005)
5. L'Ordre du Phénix (2007)
6. Le Prince de sang-mêlé (2009)
7. Les Reliques de la Mort, partie 1 (2010)
8. Les Reliques de la Mort, partie 2 (2011)

 Lequel des 8 films voulez-vous consulter : 5


 Le 5e film est :
L'Ordre du Phénix (2007)

~~~
---

## 🌀WHILE
### 🟣 Exercice W2.1 – Le sortilège de la journée
🎯 **Objectif :** Pratiquer While, les tableaux 1D et la génération de nombres aléatoires
🛠️ **Instructions :**
* Déclarez le tableau suivant :
```csharp
string[] sortileges = { "Accio", "Wingardium Leviosa", "Stupéfix", "Protego", "Endoloris" };
```
* Créez un générateur avec `Random generateur = new Random();`.
* Choisissez une seule fois un indice avec `generateur.Next(0, sortileges.Length)`; utilisez-le pour sélectionner le sortilège à deviner
* Demandez à l’utilisateur de deviner quel est le sortilège de la journée. Comparez les réponses sans tenir compte des majuscules/minuscules, par exemple avec `.ToLower()` des deux côtés.
* Répétez la question tant que le sortilège n'a pas été deviné

✅ **Entrée / sortie attendue :**
~~~
Devine le sortilège de la journée : Accio


 Mauvaise réponse. Essaie encore ! Protego


 Mauvaise réponse. Essaie encore ! Endoloris
Bonne réponse !

~~~
---

### 🟣 Exercice W2.2 – Devine le film de Ghibli
🎯 **Objectif :** Pratiquer While, les tableaux 1D, la propriété `Length` et les nombres aléatoires
🛠️ **Instructions :**
* Déclarez le tableau suivant :
```csharp
string[] films = { "Kiki", "Porco Rosso", "Totoro", "Ponyo", "Mononoke" };
```
* Créez un générateur avec `Random generateur = new Random();`.
* Générez un indice avec `generateur.Next(0, films.Length)` (de 0 inclus à `Length` exclu)
* Demandez à l’utilisateur de deviner quel est le film qui a été choisi aléatoirement. Comparez sans tenir compte des majuscules/minuscules.
* Répétez la question tant qu’il n’a pas deviné.

✅ **Entrée / sortie attendue :**
~~~
Devinez quel film de Ghibli a été sélectionné :

Votre réponse : kiki
Ce n'est pas le bon film. Essayez encore !

Votre réponse : ponyo
Ce n'est pas le bon film. Essayez encore !

Votre réponse : porco rosso
Bravo ! Vous avez deviné

~~~
---

## ➡️🌀DO WHILE
### 🟣 Exercice DW2.1 – Les sortilèges colorés
🎯 **Objectif :** Pratiquer Do while, les tableaux 1D et les couleurs
🛠️ **Instructions :**
* Reprenez "W2.1 – Le sortilège de la journée"
* Copiez et renommez comme "DW2.1 – Les sortilèges colorés"
* Demandez à l’utilisateur de saisir un sortilège. Comparez sans tenir compte des majuscules/minuscules.
* Tant que le sortilège saisi se trouve dans le tableau :
 1. Changez la couleur de l’arrière-plan à l’aide de l'index + 1;
 2. Réaffichez le sortilège choisi (en couleur)
 3. Rétablissez les couleurs de la console aux valeurs par défaut
 4. Redemandez de saisir un nouveau sortilège
 5. Toute autre valeur qui ne se trouve pas dans le tableau, permettra de quitter l'application.
 6. Envoyez un message avant de quitter.

➡️ Regarder `Console.BackgroundColor = (ConsoleColor)(index + 1);` pour vous aider

✅ **Entrée / sortie attendue :**
~~~
Est-ce que ce sortilège est disponible : accio
Et oui!!!
Accio

Est-ce que ce sortilège est disponible : stupéfix
Et oui!!!
Stupéfix

Est-ce que ce sortilège est disponible : protego
Et oui!!!
Protego

Est-ce que ce sortilège est disponible : abracadabra
Ce sortilège n'est pas dans la liste. Au revoir !
~~~

---

### 🟣 Exercice DW2.2 – Où est le magicien ?
🎯 **Objectif :** Afficher un tableau 2D de personnages et retrouver les coordonnées du magicien affiché.
🛠️ **Instructions :**
* Utilisez le code suivant :
```csharp
     // Permet d'afficher correctement les icônes, symboles et émojis
     Console.OutputEncoding = System.Text.Encoding.UTF8;

     string magicien = "🧙‍♂️"; // ou "🧙‍♀️" pour une magicienne !

     // Grille de jeu de 5x5
     string[,] plateau = {
          {"🧝‍♂️","🧛‍♀️","🧟‍♂️","🧞‍♀️","🧜‍♂️"},
          {"🧚‍♀️","🧑‍🚀","🧑‍⚕️","🧑‍🍳","🧑‍🏫"},
          {"🧑‍🔧","🧑‍💻","🧑‍🎨","🧑‍🚒","🧑‍✈️"},
          {"🧘‍♂️","🧑‍🌾","🧜‍♂️","🧝‍♀️","🧛‍♂️"},
          {"🧟‍♀️","🧞‍♂️","🧜‍♀️","🧚‍♂️","🧑‍🚀"}
     };
```
* Le plateau ne contient initialement aucun magicien. Créez `Random generateur = new Random();`, puis générez une rangée avec `generateur.Next(0, plateau.GetLength(0))` et une colonne avec `generateur.Next(0, plateau.GetLength(1))`. Remplacez un seul personnage par le magicien.
* Demandez des numéros de rangée et de colonne de 1 à 5. Validez-les avant tout accès, puis soustrayez 1 pour obtenir les indices du tableau. Une saisie invalide doit être redemandée.
* Tant que la position du magicien n’a pas été trouvée :
     1. Effacez le contenu de la console.
     2. Affichez le plateau de jeu.
     3. Demandez à l’utilisateur de choisir une rangée.
     4. Demandez à l’utilisateur de choisir une colonne.
* **Bonus :** si l’utilisateur devine une position incorrecte, remplacez le personnage choisi par un `❌`.
✅ **Entrée / sortie attendue :**
```
🧝‍♂️ 🧛‍♀️ 🧟‍♂️ 🧞‍♀️ 🧜‍♂️
🧚‍♀️ 🧑‍🚀 🧑‍⚕️ 🧑‍🍳 🧑‍🏫
🧑‍🔧 🧑‍💻 🧑‍🎨 🧑‍🚒 🧑‍✈️
🧘‍♂️ 🧑‍🌾 🧙‍♂️ 🧝‍♀️ 🧛‍♂️
🧟‍♀️ 🧞‍♂️ 🧜‍♀️ 🧚‍♂️ 🧑‍🚀
Choix de la rangée (1 à 5): 4
Choix de la colonne (1 à 5): 3
Bravo, le magicien a été trouvé à la position [4,3] !
```
## ➡️[🧪 Défi 8.2](/defis/switch-boucles-conditionnelles)

---

[Consulter le corrigé du laboratoire 8.2C](/solution/laboratoire-solution8.2C)

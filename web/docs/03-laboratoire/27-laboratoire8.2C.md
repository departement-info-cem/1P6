---
title: B - Switch... case, While et Do... while – Avancé  
---

# 🧪 Labo 8.2B - Switch... case, While et Do... while – Avancé

## 🔢Switch... case 
### 🟡 Exercice S2.1 – Calculer l’aire 2.0
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

### 🟡 Exercice S2.2 – Classes de permis 2.0  
🎯 **Objectif :** Pratiquer Switch ... case, les tableaux 2D et les icônes    
🛠️ **Instructions :**   
* Reprenez l’exercice « S1.4 – Classes de permis 1.0 »  
* Renommez comme « S2.2 – Classes de permis 2.0 »  
* Affichez le tableau au complet  
* À l'aide de Switch... case, demandez à l'utilisateur à quelle classe de permis il veut ajouter une icône  
* Dans chaque case, appelez une fonction qui : 
  * Recevra en paramètre : le tableau, le choix de classe et une icône  
  * Ajouter l'icône (représentant le véhicule en question) à côté de la classe de permis  
  * Reafficher le tableau :  
    * Le numéro de classe, suivi de l'icône, suivi du titre du permis

**DÉFI** : Permettre d'ajouter des icônes aux autres clases, jusqu'à demander de quitter (Piste : Utilisez `Do... while`) 

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

### 🟡 Exercice S2.3 – Cinéma 2.0  
🎯 **Objectif :** Pratiquer le switch... case, les tableaux 1D et les couleurs  
🛠️ **Instructions :**  
* Reprenez l’exercice « S1.5 – Cinéma 1.0 »   
* Renommez comme « S2.3 –Cinéma 2.0 »  
* Créez un tableau. Ajoutez comme valeurs les titres des films.  
* Chaque film devra s’afficher dans la couleur qui correspond à l’index (à l’exception des titres de colonnes)  
    
➡️ Regardez `Console.ForegroundColor = (ConsoleColor)*index*` pour vous aider  
Ou encore la section [Extra](https://info.cegepmontpetit.ca/1P6/extra/style)  

✅ **Sortie attendue :**     
~~~
-----------------Les films de Harry Potter--------------------------

 Lequel des 8 films voulez-vous consulter : 5


 Le 5e film est :
l'Ordre du Phénix (2003)

~~~
---

## 🌀WHILE
### 🟡 Exercice W2.1 – Le sortilège de la journée 
🎯 **Objectif :** Pratiquer While, les tableaux 1D et la génération de nombres aléatoires  
🛠️ **Instructions :**  
* Déclarez le tableau suivant :   
`string [] sortileges = {"Accio", "Wingardium Leviosa", "Stupéfix", "Protego", "Endoloris"}`  
* Générez un nombre aléatoire pour choisir un des sortilèges présents dans le tableau    
* Demandez à l’utilisateur de deviner quel est sortilège de la journée   
* Répétez la question tant que le sortilège n'a pas été deviné 

✅ **Entrée / sortie attendue :**     
~~~
Devine le sortilège de la journée : Accio


 Mauvaise réponse. Essaie encore ! Protego


 Mauvaise réponse. Essaie encore ! Endoloris
Bonne réponse !

~~~
---

### 🟡 Exercice W2.2 – Devine le film de Ghibli  
🎯 **Objectif :** Pratiquer While, les tableaux 1D, la propriété length et les nombres aléatoires    
🛠️ **Instructions :**  
* Déclarez le tableau suivant :  
    `string [] films={"Kiki", "Porco Rosso", "Totoro", "Ponyo", "Mononoke"}`  
* Générez un chiffre aléatoire entre 1 et le nombre de films disponibles (en utilisant la propriété length)  
* Demandez à l’utilisateur de deviner quel est le film qui a été choisi aléatoirement  
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
### 🟡 Exercice DW2.1 – Les sortilèges colorés 
🎯 **Objectif :** Pratiquer Do while, les tableaux 1D et les couleurs  
🛠️ **Instructions :**  
* Reprenez "W2.1 – Le sortilège de la journée"  
* Copiez et renommez comme "DW2.2 – Les sortilèges colorés"    
* Demandez à l’utilisateur de saisir un sortilège.   
* Tant que le sortilège saisi se trouve dans le tableau :  
 1. Changez la couleur de l’arrière-plan à l’aide de l'index + 1;  
 2. Réaffichez le sortilège choisi (en couleur)  
 3. Rétablissez les couleurs de la console aux valeurs par défaut  
 4. Redemandez de saisir un nouveau sortilège  
 5. Toute autre valeur qui ne se trouve pas dans la tableau, permettra de quitter l'application.  
 6. Envoyez un message avant que quitter.  
  
➡️ Regarder `Console.BackgroundColor = (ConsoleColor)index` pour vous aider

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

### 🟡 Exercice DW2.2 – Où est le magicien ? 
🎯 **Objectif :** Être capable d'afficher un tableau 2D de personnages, et trouver le magicien caché.
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
          {"🧘‍♂️","🧑‍🌾","🧙‍♂️","🧝‍♀️","🧛‍♂️"},
          {"🧟‍♀️","🧞‍♂️","🧜‍♀️","🧚‍♂️","🧑‍🚀"}
     };
```
* Générez une rangée et une colonne aléatoires, puis remplacez l’un des personnages du plateau par le magicien.
* Demandez à l’utilisateur de saisir une rangée et une colonne.   
* Tant que la position du magicien n’a pas été trouvée :
     1. Effacez le contenu de la console.
     2. Affichez le plateau de jeu.
     3. Demandez à l’utilisateur de choisir une rangée.
     4. Demandez à l’utilisateur de choisir une colonne.
* **Bonus :** si l’utilisateur devine une position incorrecte, remplacez le personnage choisi par un `❌`.
✅ **Entrée / sortie attendue :**     
```
🧝‍♂️ 🧛‍♂️ 🧞‍♂️ 🧚‍♂️ 🧑‍🚀
🧑‍⚕️ 🧑‍🍳 🧑‍🏫 🧑‍🔧 🧑‍💻
🧑‍🎨 🧑‍🚒 🧑‍✈️ 🧘‍♂️ 🧑‍🌾
🧑‍🎤 🧑‍🏭 🧙‍♂️ 🧛‍♀️ 🧞‍♀️
🧚‍♀️ 🧜‍♀️ 🧝‍♀️ 🧑‍🦽 🧑‍🦯
Choix de la rangée (1 à 5): 4
Choix de la colonne (1 à 5): 3
Bravo, le magicien a été trouvé à la position [4,3] !
```

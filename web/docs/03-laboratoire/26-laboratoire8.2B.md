---
title: A - Switch... case, While et Do... while – Simple
---

# 🧪 Labo 8.2A - Switch... case, While et Do... while – Simple

📎*Référence* : [Switch... case](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/switch-case) | [While](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/while) | [Do... while](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/do-while)  | [TryParse](https://info.cegepmontpetit.ca/1P6/cours/integration-fonctions#-quest-ce-que-tryparse-)


## 🔢Switch... case  
### 🟢 Exercice S1.1 - Les jours de la semaine
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

### 🟢 Exercice S1.2 – Les mois de l’année  

🎯 **Objectif** : Afficher le mois selon un numéro donné, utiliser la case défaut.  
🛠️ **Instructions :**      
* Demandez un chiffre entier entre 1 et 12.
* Affichez le mois associé.
* Utilisez `TryParse` pour valider l'information saisie.  
* Si la valeur entrée est invalide, utilisez la case `Default` pour afficher : ERREUR.


✅ **Entrée / sortie attendue :**     
~~~
Donne-moi un numéro de mois (1-12) : 0  
ERREUR  
-----------  
Donne-moi un numéro de mois (1-12) : 8  
Le mois 8 correspond à août.
~~~

---

### 🟢 Exercice  S1.3 – Calculer l’aire 1.0   
🎯 **Objectif** : Afficher des formules selon un choix.  
🛠️ **Instructions :**  
* Proposez un menu d'options offrant différentes formes géométriques.
* Selon le choix de l’utilisateur, affichez la formule qui permet de calculer l’aire de la forme choisie.
* Utilisez `TryParse` pour valider l'information saisie.  

**Rappel :**  
Carré : côté * côté  
Rectangle : longueur * largeur  
Cercle : 3.14 * (rayon*rayon)  
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

### 🟢 Exercice S1.4 – Classes de permis 1.0  
🎯 **Objectif** : Afficher le type de véhicule autorisé selon la classe  
🛠️ **Instructions :**  
* Demandez un chiffre entier entre 1 et 8.
* AFfichez les informaitons qui correspondent à la classe de permis (voir tableau).
* Utilisez `TryParse` pour valider l'information saisie.    
* Déclarez un tableau de string 2 X 9, initialisez avec les informations suivantes :  
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

### 🟢 Exercice S1.5 – Cinéma 1.0  
🎯 **Objectif** : Afficher un titre selon le numéro entré.  
🛠️ **Instructions :**  
* Déclarez et initialisez le tableau suivant :
```csharp
  string[] filmsHarry = {
    "À l'école des sorciers (1997)",
    "la Chambre des secrets (1998)",
    "le Prisonnier d'Azkaban (1999)",
    "la Coupe de feu (2000)",
    "l'Ordre du Phénix (2003)",
    "le Prince de sang-mêlé (2005)",
    "les Reliques de la Mort (2007)"};
```

* Demandez un numéro entre 1 et 8 pour choisir un film.  
* Affichez le titre correspondant.
* Utilisez `TryParse` pour valider l'information saisie.  
* Si la valeur entrée est invalide, affichez ERREUR.  
  
|Titre|
|---|
|À l'école des sorciers (1997)
|la Chambre des secrets (1998)
|le Prisonnier d'Azkaban (1999)
|la Coupe de feu (2000)
|l'Ordre du Phénix (2003)
|le Prince de sang-mêlé (2005)
|les Reliques de la Mort (2007)



✅ **Entrée / sortie attendue :**        
~~~   
Quel film de Harry Potter voulez vous consulter? 3  
Le Prisonnier d'Azkaban (1999)
~~~

---

## 🌀WHILE
### 🟢 Exercice W1.1 – Compter de 1 à 100  
*🎯 **Objectif :** Afficher les valeurs de 1 à 100 à l’aide de `While`.  
✅ **Sortie attendue :**     
~~~   
1
2
3
…
100
~~~

---

### 🟢 Exercice W1.2 – Demander le code secret   
🎯 **Objectif :** Répéter une question  
🛠️ **Instructions :**  
* Répéter une question tant que la bonne réponse n’est pas entrée.  

✅ **Entrée / sortie attendue :**     
~~~   
T’es qui, toi? Charles  
Mauvaise réponse… Essaie toi encore ;)  
T’es qui, toi? Moi  
Bonne réponse ! :D  
~~~
---

### 🟢 Exercice W1.3 – Afficher le budget  
🎯 **Objectif :** Afficher un budget, jusqu’à épuisement  
🛠️ **Instructions :**  
* Déclarez une variable budget de 100$.  
* Affichez le budget initial.  
* Demandez combien a été dépensé, tant qu’il reste de budget.
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

### 🟢 Exercice W1.4 – Quelle est la moitié de…  
🎯 **Objectif :** Répéter une question  
🛠️ **Instructions :**  
* Demandez un nombre.
* Calculez et affichez la moitié de cette valeur, tant qu’elle est plus grande que 0.5
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

### 🟢 Exercice W1.5 – Les amis à Harry  
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
### 🟢 Exercice DW1.1 – Majeurs  
🎯 **Objectif :** Poser une question, répéter jusqu’à obtenir une des bonnes réponses 
🛠️ **Instructions :**  
* Demandez à l’utilisateur à quel âge on devient majeurs.  
* Répéter la question tant qu’elle est différente de deux réponses possibles, soit 18 ou soit 21 selon le pays.
* Utilisez `TryParse` pour valider l'information saisie.  
  
✅ **Entrée / sortie attendue :**
~~~
À quel âge on devient majeur ? 15
À quel âge on devient majeur ? 17
À quel âge on devient majeur ? 18  
~~~
---

### 🟢 Exercice DW1.2 – Les épargnes  
🎯 **Objectif :** Répéter une question   
🛠️ **Instructions :**  
* Demande à l’utilisateur combien veut-il épargner ce mois-ci.
* Utilisez `TryParse` pour valider l'information saisie.    
* Répéter la question jusqu’à ce que la réponse soit zéro.    
* Afficher le montant total des économies.  

✅ **Entrée / sortie attendue :**     
~~~
Combien désirez-vous épargner ce mois-ci? 50
Combien désirez-vous épargner ce mois-ci? 10
Combien désirez-vous épargner ce mois-ci? 30
Combien désirez-vous épargner ce mois-ci? 0  

----------------------------------------  
Vous avez cummulé : 90,00 $  
~~~
---

### 🟢 Exercice DW1.3 – Station de Harry Potter  
🎯 **Objectif :** Répéter une question jusqu’à avoir la bonne réponse  
🛠️ **Instructions :** 
* Demander à l’utilisateur d’entrer le numéro de station de Harry Potter (en décimal).  
* Répéter la question tant qu’elle est différente de 9.75
* Utilisez `TryParse` pour valider l'information saisie.  

✅ **Entrée / sortie attendue :**     
~~~
Quel est le numéro de station de Harry Potter ? 3
Quel est le numéro de station de Harry Potter ? 9
Quel est le numéro de station de Harry Potter ? 9,75  
~~~
--- 

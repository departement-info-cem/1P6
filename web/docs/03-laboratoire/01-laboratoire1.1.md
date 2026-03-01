---
title: Révision - Objet et collection
---

# 🧪 Labo 1.1 – Gestion de données avec des collections

📎 **Référence** : [Tableau 1D – Documentation C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-1d)

---

## 🟢 Exercice 1 – Gestion d’une liste de notes et calcul de statistiques
### 🎯 **Objectifs** 
* Manipuler une liste simple
* Définir des fonctions



### 🛠️ Instructions
Écrire un programme qui permet de saisir les notes de 10 étudiants, puis calculer et afficher des statistiques.

1. Créez une liste pour stocker les notes.
2. Demandez à l’utilisateur de **rentrer 10 notes** (ex : sur 100).
    * Les notes doivent être enregistrées dans la liste.
3. Écrivez une fonction **CalculerMoyenne** qui :
    * reçoit en paramètre une liste de notes
    * retourne la **moyenne des notes**
4. Écrivez une fonction **TrouverNoteMax** qui :
    * reçoit en paramètre une liste de notes
    * retourne la **note maximale**
5. Écrivez une fonction **TrouverNoteMin** qui :
    * reçoit en paramètre une liste de notes
    * retourne la **note minimale**
6. Écrivez une fonction **CompterAuDessusDeLaMoyenne** qui :
    * recoit en paramètre une liste de notes et une moyenne
    * retourne le **Nombre d’étudiants avec une note supérieure ou égale à la moyenne**


 ### ⭐ Exemple d’exécution

```
Entrez la note #1 : 60
Entrez la note #2 : 75
...
Entrez la note #10 : 90

Notes : 60 75 80 55 90 70 65 88 77 50
Moyenne de la classe : 71.0
Note maximale : 90
Note minimale : 50
Nombre d’étudiants avec une note supérieure ou égale à la moyenne : 5
```

## 🟡 Exercice 2 – Filtrer une liste
### 🎯 Objectifs
* Modifier une liste “sur place” afin de ne conserver que les éléments qui respectent une condition


### 🛠️ Instructions

1. Créez une liste et l'initialiser avec ces valeurs \{12, 5, 8, 21, 15, 4, 18, 7, 13, 9, 2, 6\}
2. Écrivez une fonction **GarderPairs** qui :
    * recoit en paramètre une liste d'entiers
    * supprime tous les nombres impairs
    * affiche le résultat avant et après 

#### 🔒 ***Contraintes obligatoires***

    *  Interdit de créer une deuxième liste pour stocker les résultats.
    *  La suppression doit se faire pendant le parcours.
    *  Le programme doit fonctionner correctement même si deux nombres impairs sont consécutifs.

 ### ⭐ Exemple d’exécution

```
Avant : 12 5 8 21 15 4 18 7 13 9 2 6
Après : 12 8 4 18 2 6
```

## 🟡 Exercice 3 – Personnage (changement d’état )

### 🎯 Objectifs

* Utiliser une classe fournie pour instancier un objet et manipuler son état (lecture et modification des propriétés, appel de méthodes).

### Télécharger le fichier de la classe Personnage
Disponible ici 👉 [Personnage.cs](../../static/files/laboratoires/Laboratoire1_1.zip)

Vous devez télécharger le fichier Personnage.cs, puis le rajouter à votre projet Visual Studio. N'oubliez pas de changer le nom du namespace au besoin.

📌 **Classe fournie : description des éléments**

La classe `Personnage` est fournie. Elle contient :

* **Nom** : le nom du personnage (ex : `"Link"`)
* **Points** : le niveau actuel du personnage (ex : `1`, `2`, `3`, …)
* **Niveau** : le rang du personnage (ex : `DEBUTANT`, `APPRENTI`, `GUERRIER`, `HERO`)
* **GagnerUnPoint()** : méthode qui augmente le nombre de points de 1
* **AfficherEtat()** : méthode qui retourne une chaîne de caractères contenant l'état du personnage (nom, niveau, statut)
* **Constantes de paliers** : valeurs fixes indiquant à partir de combien de points le niveau doit changer (ex. : 5, 10, 15).
* **Constantes de niveaux** : valeurs fixes représentant les noms des niveaux (`DEBUTANT`, `APPRENTI`, etc.)
* **Constructeurs** : instancier des objets de la classe

⚠️ **Remarque importante :** Le changement de niveau n’est pas automatique : c’est votre programme qui doit modifier le niveau lorsque le personnage atteint les points demandées.

### 🛠️ Instructions

1. Instanciez un personnage `Personnage` nommé **"Link"**.
2. Affichez son état (nom, points, niveau).
3. Affichez :
```
Le personnage s'entraine...
```
4. Faites gagner le personnage des points jusqu’à **15** en affichant un point `.` à chaque fois.
5. Lorsque le personnage atteint le seuil de points correspondant à un niveau donné, son niveau est mis à jour et son état est affiché.
6. À la fin, affichez l’état final du personnage :

#### 🔒 Contraintes

* Le programme doit utiliser **une boucle** pour augmenter le nombre de points.
* Aucune modification n’est autorisée dans la classe fournie.
* Le programme doit afficher des points `.` pendant l’entraînement.

 ### ⭐ Affichages attendus

```
Link | Points 1 | Niveau : DEBUTANT
Le personnage s'entraine...
.....
>>> Nouveau niveau atteint : APPRENTI (niveau 5)
.....
>>> Nouveau niveau atteint : GUERRIER (niveau 10)
.....
>>> Nouveau niveau atteint : HERO (niveau 15)

--- Fin ---
Link | Points 15 | Niveau : HERO

```

## 🟡 Exercice 4 – Stocker les personnages dans des fichiers csv

### 🎯 Objectifs

* utiliser les fichiers csv
* utiliser un constructuer avec plusieurs paramètres
* parcourir une liste

### 📁 Fichier d’entrée

Dans cet exercice nous allons utiliser des fichiers csv pour stocker les informations des personnages. Chaque ligne contient un personnage au format :

```
Nom;Points;Niveau
```

Exemples :

```
Link;1;DEBUTANT
Zelda;7;APPRENTI
Ganon;15;HERO
Impa;10;GUERRIER
Epona;4;DEBUTANT
```

## 🛠️ Instructions

* charger tous les personnages depuis un fichier csv;
* séparer les personnages selon leur niveau;
* sauvegarder chaque groupe dans un fichier csv différent.

### 1) Charger la liste depuis le fichier

Écrire une fonction **ChargerPersonnages** qui doit:

* recevoir en paramètre un nom de fichier csv
* lire toutes les lignes du fichier csv
* pour chaque ligne valide :
  * extraire `Nom`, `Points`, `Niveau`
  * créer un objet `Personnage(nom, points, niveau)`
  * l’ajouter à une `List<Personnage>`
* retourne la liste

### 2) Filtrer une liste par niveau 

Écrire une fonction **FiltrerParNiveau** qui doit:

* recevoir en paramètre une liste de personnages et un niveau;
* retourner une nouvelle liste contenant seulement les personnages selon le niveau en entrée.

📌 Exemple : filtrer la liste pour obtenir la liste des GUERRIER.

### 3) Sauvegarder une liste dans un fichier

Écrire une fonction **Enregistrer** qui doit :

* recevoir une liste et le nom d'un fichier csv;
* sauvegarder le contenu de la liste dans ce fichier.

📌 Conserver la même structure de fichier: Nom;Points;Niveau


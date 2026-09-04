---
title: B - Tableaux 2D – Avancé
---

# 🧪 Labo 7.1B – Tableaux 2D – Avancé

📎 **Référence** : [Tableaux 2D en C# – Documentation](https://info.cegepmontpetit.ca/notions-csharp/documentation/tableau/tableau-2d)

Nous allons réaliser une série d’exercices permettant de pratiquer les **Tableaux 2D** en C#.

Pour **chaque Labo**, créez un **nouveau projet** dans Visual Studio.

## 🟡 Exercice 1 - Moyenne des salaires

Voici le revenu mensuel de plusieurs employé(e)s au sein de la compagnie XYZ.
```csharp
int[] employe1 = { 1200, 3600, 600, 1000, 500, 6000, 1200, 500, 10000, 900, 8500, 100 };
int[] employe2 = { 2500, 2600, 2550, 2700, 2650, 2800, 2750, 2900, 3000, 3100, 3050, 3200 };
int[] employe3 = { 1500, 1800, 2000, 1700, 1600, 1900, 2100, 2500, 2300, 2200, 2000, 2400 };
int[] employe4 = { 800, 1200, 950, 1100, 1000, 900, 1050, 980, 1020, 1150, 1080, 1110 };
```


🎯 **Objectif** : Calculer la moyenne des salaires mensuels de chaque employé(e).

🛠️ **Instructions** :
1. Transforme le salaire mensuel de chaque employé(e) afin de le rendre accessible dans un **tableau 2D**.
2. Écris la fonction `CalculerMoyenne(int[,] employes)` qui reçoit en paramètre un tableau 2D et qui retourne la moyenne salariale de chaque employé(e) dans un **tableau 1D**.
3. Parcours le tableau des moyennes et affiche le salaire moyen de chaque employé(e).

✅ **Résultat attendu**:
```
2841
2816
2000
1028
```

---

## 🟡 Exercice 2 – Sommation mensuelle

🎯 **Objectif** : Calculer la somme des salaires de tous les employé(e)s pour un mois donné.

🛠️ **Instructions** :
1. Reprends le code de l'exercice précédent.  
2. Écris la fonction `CalculerSommeMensuelle(int[,] employes, int mois)` qui reçoit en paramètre un tableau 2D et l’indice du mois (**de 0 à 11**).  
   Cette fonction doit retourner la somme des salaires de tous les employé(e)s pour le mois choisi.  
3. Demande à l’utilisateur de choisir un mois.  
4. Appelle la fonction et affiche la somme des salaires pour le mois en question.  

✅ **Résultat attendu** :
```
Choisissez un mois (0-Jan, 1-Fév, 2-Mar, 3-Avr, 4-Mai, 5-Juin, 6-Juil, 7-Août, 8-Sep, 9-Oct, 10-Nov, 11-Déc) : 5
Total : 11600
```

---

## 🟡 Exercice 3 – Total du revenu annuel de tous les employé(e)s de la compagnie XYZ

🎯 **Objectif** : Calculer la somme des salaires de tous les employé(e)s sur une année complète.

🛠️ **Instructions** :
1. Reprends le code de l'exercice 2.  
2. Appelle la fonction `CalculerSommeMensuelle(int[,] employes, int mois)` de l'exercice 8 pour **chaque mois** automatiquement à l’aide d’une boucle `for`.  
3. Additionne les résultats obtenus pour chaque mois.  
4. Affiche le revenu total annuel de tous les employé(e)s.  

✅ **Résultat attendu** :
```
Total : 104240
```

---

## 🟡 Exercice 4 – Statistiques des Pokémons

Voici les statistiques de 10 pokémons différents.
```csharp

// PV, Attaque, Défense, Vitesse, Spécial
int[] Pikachu     = { 35, 55, 40, 90, 50 };
int[] Bulbasaur   = { 45, 49, 49, 45, 65 };
int[] Charmander  = { 39, 52, 43, 65, 50 };
int[] Squirtle    = { 44, 48, 65, 43, 50 };
int[] Pidgey      = { 40, 45, 40, 56, 35 };
int[] Rattata     = { 30, 56, 35, 72, 25 };
int[] Jigglypuff  = { 115, 45, 20, 20, 25 };
int[] Meowth      = { 40, 45, 35, 90, 40 };
int[] Machop      = { 70, 80, 50, 35, 35 };
int[] Gastly      = { 30, 35, 30, 80, 100 };
```

🎯 **Objectif** : Valider des données dans un tableau **2D** selon certains critères.

🛠️ **Instructions** :
1. Transforme les 10 pokémons afin de les rendre accessibles dans un **tableau 2D** nommé `statPokemons`.
2. Crée également un tableau **1D** contenant tous les noms de pokémons dans le même ordre que les statistiques, nommé `nomsPokemons`.
3. Crée une fonction nommée `EstUnPokemonFaible(int sommeStat)` qui reçoit en paramètre la somme de toutes les statistiques d'un pokémon. La fonction doit retourner `true` si cette somme est inférieure à 250.
4. À la fin du programme :
    * Affiche le nom de tous les pokémons n'ayant **aucune statistique faible**.  
    * Affiche le nombre de pokémons puissants sur le nombre total de pokémons.  

✅ **Résultat attendu** :
```
Pikachu
Bulbasaur
Squirtle
Meowth
Machop
Gastly

Pokémons puissants : 6 / 10
```

---

## 🟡 Exercice 5 – Affichage statistique et multiples tableaux

🎯 **Objectif** : Création d'une fonction qui retourne une dimension d'un tableau.

🛠️ **Instructions** :
1. Reprends le code de l'exercice 4.  
2. Crée un tableau **1D**  nommé `titresStatistiques` avec les informations suivantes `PV, Attaque, Défense, Vitesse, Spécial`.
3. Crée une fonction nommée `StatistiqueParPokemon(int[,] statPokemons, int numeroPokemon)` qui reçoit en paramètre le tableau de statistiques des pokémons et le numéro du pokémon désiré. La fonction doit retourner la totalité des statistiques de ce pokémon.
4. Demande à l'utilisateur d'entrer un nombre pour choisir le pokémon désiré.
5. À la fin du programme :
    * Affiche le nom du pokémon.
    * Affiche le titre de chaque statistique.
    * Affiche les statistiques de ce pokémon.

✅ **Résultat attendu** :
```
Choisissez un Pokémon :
0. Pikachu
1. Bulbasaur
2. Charmander
3. Squirtle
4. Pidgey
5. Rattata
6. Jigglypuff
7. Meowth
8. Machop
9. Gastly

Choix : 3

Squirtle
PV : 44
Attaque : 48
Défense : 65
Vitesse : 43
Spécial : 50
```

---

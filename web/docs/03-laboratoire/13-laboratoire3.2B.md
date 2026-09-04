---
title: B - 🎬 Intègration des fonctions - Mini-projet – Calculateur de coût de sortie au cinéma
---

# 🧪 Labo 3.2 🎬 Mini-projet – Calculateur de coût de sortie au cinéma 

## 🎯 Objectif
Créer un programme console qui calcule le coût d’une sortie au cinéma pour **un participant**, en tenant compte :
- Du type de film
- De l’âge du participant
- D’une collation choisie parmi trois options
- Des taxes

Le programme doit utiliser **plusieurs méthodes `static`** qui retournent des valeurs.

---

## 🎟️ Tarifs des billets

| Tranche d’âge     | Standard | 3D     | IMAX   |
|-------------------|----------|--------|--------|
| Moins de 12 ans   | 6.00 $   | 8.00 $ | 10.00 $|
| 12 à 17 ans       | 8.00 $   | 10.00 $| 12.00 $|
| 18 à 64 ans       | 10.00 $  | 12.00 $| 14.00 $|
| 65 ans et plus    | 7.00 $   | 9.00 $ | 11.00 $|

---

## 🍿 Collations disponibles

| Numéro | Nom       | Prix   |
|--------|-----------|--------|
| 1      | Popcorn   | 5.50 $ |
| 2      | Nachos    | 6.75 $ |
| 3      | Breuvage  | 4.25 $ |

---

## 📋 Instructions

1. **Demander le type de film** (1 = Standard, 2 = 3D, 3 = IMAX)  
2. **Demander l’âge du participant**  
3. **Utiliser la méthode `ObtenirPrixBillet`** pour déterminer le prix du billet  
4. **Afficher la liste des collations et demander un choix** (1, 2 ou 3)  
5. **Utiliser la méthode `ObtenirPrixCollation`** pour déterminer le prix de la collation choisie  
6. **Calculer le total avant taxes** avec `CalculerTotal`  
7. **Appliquer les taxes** avec `AjouterTaxes`  
8. **Afficher le récapitulatif complet**

---

## 📝 Pseudo-code principal 

```
DEBUT

    AFFICHER "Type de film (1: Standard, 2: 3D, 3: IMAX) : "
    LIRE typeFilm

    AFFICHER "Âge du participant : "
    LIRE age

    prixBillet = ObtenirPrixBillet(age, typeFilm)

    AFFICHER "Choisissez une collation :"
    AFFICHER "1 - Popcorn (5.50 $)"
    AFFICHER "2 - Nachos (6.75 $)"
    AFFICHER "3 - Breuvage (4.25 $)"
    LIRE choixCollation

    prixCollation = ObtenirPrixCollation(choixCollation)

    totalAvantTaxes = CalculerTotal(prixBillet, prixCollation)

    totalAvecTaxes = AjouterTaxes(totalAvantTaxes)

    AFFICHER "--- Récapitulatif ---"
    AFFICHER "Type de film : ", typeFilm
    AFFICHER "Prix billet : ", prixBillet
    AFFICHER "Collation : ", prixCollation
    AFFICHER "Total avant taxes : ", totalAvantTaxes
    AFFICHER "Total avec taxes : ", totalAvecTaxes

FIN
```

---

## 🛠️ Méthodes à créer 

### 1️⃣ `ObtenirPrixBillet`
```
SI typeFilm EST ÉGAL À 1 ALORS
    SI age PLUS PETIT QUE 12 ALORS prix = 6.00
    SINON SI age PLUS PETIT OU ÉGAL À 17 ALORS prix = 8.00
    SINON SI age PLUS PETIT OU ÉGAL À 64 ALORS prix = 10.00
    SINON prix = 7.00

SI typeFilm EST ÉGAL À 2 ALORS
    SI age PLUS PETIT QUE 12 ALORS prix = 8.00
    SINON SI age PLUS PETIT OU ÉGAL À 17 ALORS prix = 10.00
    SINON SI age PLUS PETIT OU ÉGAL À 64 ALORS prix = 12.00
    SINON prix = 9.00

SI typeFilm EST ÉGAL À 3 ALORS
    SI age PLUS PETIT QUE 12 ALORS prix = 10.00
    SINON SI age PLUS PETIT OU ÉGAL À 17 ALORS prix = 12.00
    SINON SI age PLUS PETIT OU ÉGAL À 64 ALORS prix = 14.00
    SINON prix = 11.00

RETOURNER prix
```

---

### 2️⃣ `ObtenirPrixCollation`
```
SI choixCollation EST ÉGAL À 1 ALORS prix = 5.50
SI choixCollation EST ÉGAL À 2 ALORS prix = 6.75
SI choixCollation EST ÉGAL À 3 ALORS prix = 4.25

RETOURNER prix
```

---

### 3️⃣ `CalculerTotal`
```
total = prixBillet PLUS prixCollation
RETOURNER total
```

---

### 4️⃣ `AjouterTaxes`
```
taxe = montant MULTIPLIER PAR 0.15
montantTotal = montant PLUS taxe
RETOURNER montantTotal
```

---

## 💡 Exemple d’exécution

```
Type de film (1: Standard, 2: 3D, 3: IMAX) : 3
Âge du participant : 15
Choisissez une collation :
1 - Popcorn (5.50 $)
2 - Nachos (6.75 $)
3 - Breuvage (4.25 $) : 1

--- Récapitulatif ---
Type de film : IMAX
Prix billet : 12.00 $
Collation : 5.50 $
Total avant taxes : 17.50 $
Total avec taxes : 20.13 $
```

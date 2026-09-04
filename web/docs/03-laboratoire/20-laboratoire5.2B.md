---
title: 🔑 B - Intégration des boucles et des tableaux - Mini-projet - Générateur de mot de passe
---

# 🧪 Labo 5.2B 🔑 Mini-projet – Générateur de mot de passe

## 🎯 Objectif
Créer un programme qui demande la longueur du mot de passe désiré et si l'utilisateur veut inclure des caractères spéciaux. Génère un mot de passe aléatoire de la longueur spécifiée.


### Rappel
```csharp
Random generateur = new Random();
int nombre = generateur.Next(1, 11); // génère un nombre entre 1 et 10
```

---

## 📋 Instructions
Vous devez utiliser deux constantes pour vérifier la longueur du mot de passe
    *   **LONGUEUR_MIN** est un `int` de valeur **8**;
    *   **LONGUEUR_MAX** est un `int` de valeur **20**;

1. Dans votre `Main()`, vous devez demander à l'utilisateur la longueur du mot de passe à générer. 
    * Si la longueur est plus petite que LONGUEUR_MIN, utilisez LONGUEUR_MIN comme longueur.
    * Si la longueur est plus grande que LONGUEUR_MAX, utilisez LONGUEUR_MAX comme longueur.

2. Demandez à l'utilisateur s'il veut inclure des caractères spéciaux
3. Appelez la fonction `GenererMotDePasse()` en lui passant la longueur de mot de passe désiré et si l'utilisateur veut des caractères spéciaux. Capturer le retour de la fonction dans une variable.
4. Affichez le mot de passe généré.

---

## 🛠️ Fonction `GenererMotDePasse()`
    * Prends deux valeurs en paramètre `int pLongueur` et `bool inclureSymboles`
    * Retourne un `string`

1. Copier les deux variables **caractèresValides** et  **symboles** dans votre fonction `GenererMotDePasse()`
```Csharp
 string caractèresValides = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
 string symboles = "!@#$%^&*-_=+:?";
```   
2. Si le paramètre `inclureSymboles` est `true`, ajouter le texte de **symboles** à votre variable **caractèresValides**.
3. Créez un générateur de valeurs aléatoires avec `Random`
4. Créez une variable `string motDePasse`
5. Faites une boucle `for` sur des valeurs allant de 0 à la longueur désirée.
6. Dans la boucle :
    * générez une valeur d'index aléatoire entre 0 et la longueur de votre variable **caractèresValides**
    * Ajoutez à votre variable **motDePasse** la valeur de **caractèresValides** à l'index aléatoire généré.
7. Une fois la boucle finie, retournez le mot de passe généré.

---

## 💡 Exemples d’exécution
**Longueur valide, pas de symboles**
```
Entrez la longueur du mot de passe : 10
Inclure des symboles ? (oui/non) : non
Votre mot de passe généré est :
THsHLByPLz
```

**Longueur valide, avec symboles**
```
Entrez la longueur du mot de passe : 8
Inclure des symboles ? (oui/non) : oui
Votre mot de passe généré est :
y:I?:$7A
```

**Longeur invalide, avec symboles**
```
Entrez la longueur du mot de passe : 100
Inclure des symboles ? (oui/non) : oui
Votre mot de passe généré est :
Qx7Vx&ShixU:I?:$7FFv
```
* Notez : La longueur de 100 n'est pas valide, le mot de passe a donc une longueur maximum de 20 caractères.


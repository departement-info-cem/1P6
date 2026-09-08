---
title: C - Fonctions avec retour
---

# 🧪 Labo 3.1C – Fonctions avec retour

Nous allons travailler une série d’exercices pour pratiquer la **définition de fonctions avec paramètres et retour de valeur**.



---

## 📌 Rappel : Syntaxe d’une fonction avec retour

```csharp
static TypeRetour NomDeLaFonction(type pParam1, type pParam2)
{
    // calculs
    return valeur;
}
````

### Exemple

```csharp
static double CalculerAireRectangle(double pLongueur, double pLargeur)
{
    double aire = pLongueur * pLargeur;
    return aire;
}
```

---

## 🟢 J'APPLIQUE

### 🟢 Exercice 7 – Calculer une somme

Créez une méthode `CalculerSomme` qui reçoit **deux entiers** en paramètres et **retourne leur somme**.

Votre méthode doit pouvoir être utilisée avec différentes valeurs.

Par exemple :

```text
Entrez un premier nombre : 5
Entrez un deuxième nombre : 7

Résultat : 12
```

#### Questions pour vous guider

1. Quelles informations la méthode doit-elle recevoir ?
2. Combien de paramètres sont nécessaires ?
3. Quel type doivent avoir ces paramètres ?
4. Quel type de valeur la méthode doit-elle retourner ?
5. Quelle valeur devez-vous placer après `return` ?

---

### 🟢 Exercice 8 – Calculer l'aire d'un rectangle

Créez une méthode `CalculerAireRectangle` qui reçoit la **longueur** et la **largeur** d'un rectangle et retourne son aire.

> Formule : `aire = longueur × largeur`

Exemple :

```text
Longueur : 8
Largeur : 5

Aire : 40
```

#### Questions pour vous guider

1. Quelles données sont nécessaires pour calculer l'aire ?
2. Quelles données doivent être des paramètres ?
3. Quel type de valeur la méthode doit-elle retourner ?
4. Où devez-vous effectuer le calcul ?
5. Que devez-vous retourner ?

Testez votre méthode avec plusieurs rectangles **sans modifier le code de la méthode**.

---

## 🟣 JE RÉSOUS

### 🟣 Exercice 9 – Maximum entre deux et trois valeurs

Écrivez une méthode `MaximumDeux` qui permet de déterminer et retourner le plus grand de deux nombres entiers.

Réutilisez ensuite **cette même méthode** pour déterminer le maximum de **trois nombres entiers**.


Par exemple :

```text
Entrez nombre 1 : 12
Entrez nombre 2 : 7
Entrez nombre 3 : 4

Le plus grand est : 12
```

#### 🔍 Questions pour vous guider

1. Quelles données `MaximumDeux` doit-elle recevoir ?
2. Que doit-elle retourner ?
3. Comment déterminer lequel des deux nombres est le plus grand ?
4. Pour trouver le maximum de trois nombres, pouvez-vous réutiliser `MaximumDeux` ?
5. Pouvez-vous utiliser le résultat d'un appel comme paramètre d'un autre appel ?
6. Pouvez-vous écrire une solution qui fonctionne avec **n'importe quels trois nombres** ?

💡 **Objectif :** découvrir qu'une méthode qui retourne une valeur peut être utilisée comme une **expression** ou comme argument d'une autre méthode.

---

### 🟣 Exercice 10 – Année bissextile : version avec retour

Reprenez votre méthode de l'exercice sur l'année bissextile.

Modifiez-la afin qu'elle **retourne un booléen** plutôt que d'afficher directement le résultat.

La méthode doit :

* retourner `true` si l'année est bissextile;
* retourner `false` sinon.

Exemple :

```text
Entrez une année : 2024

Bissextile : True
```

#### 🔍 Questions pour vous guider

1. Quelle information la méthode doit-elle recevoir ?
2. Quel type doit avoir le paramètre ?
3. La méthode doit-elle retourner un nombre, un texte ou une valeur booléenne ?
4. Quelle différence y a-t-il maintenant entre **afficher** le résultat et **retourner** le résultat ?

---


### 🟣 Exercice 11 – Vérifier un nombre palindrome

Un nombre à trois chiffres est un **palindrome** lorsqu'il se lit de la même façon de gauche à droite et de droite à gauche.

Exemples :

* `121` → palindrome
* `343` → palindrome
* `123` → pas un palindrome

Écrivez une méthode `EstPalindrome` qui permet de déterminer si un nombre entier à trois chiffres est un palindrome et retourne true si c’est le cas, sinon false.


**Questions pour vous guider :**

1. Quelle donnée la méthode doit-elle recevoir ?
2. Quel type doit avoir le paramètre ?
3. Quel type doit retourner la méthode ?
4. Comment pouvez-vous extraire le chiffre des unités ?
5. Comment pouvez-vous extraire le chiffre des centaines ?
6. Votre méthode peut-elle être appelée avec différents nombres sans modifier son code ?

---

### 🟣 Exercice 12 – Vérifier si trois longueurs forment un triangle


Écrivez une méthode `EstTriangleValide` qui permet de déterminer si trois longueurs peuvent former un triangle et retourne `true` si c’est le cas, sinon `false`.

Pour qu'un triangle soit valide :

```text
a + b > c
a + c > b
b + c > a
```

Exemple :

```csharp
bool resultat = EstTriangleValide(3, 4, 5);
Console.WriteLine(resultat);
```

**Questions pour vous guider :**

1. Combien de paramètres la méthode doit-elle avoir ?
2. Quel type doivent avoir ces paramètres ?
3. Quel type doit retourner la méthode ?
4. Combien de conditions devez-vous vérifier ?
5. Votre méthode fonctionne-t-elle avec différentes longueurs ?

---

### 🟣 Exercice 13 – Classer une moyenne

Écrivez une méthode `DeterminerMention` qui permet de déterminer et retourner une mention à partir **de deux notes**, selon la moyenne obtenue :

| Moyenne     | Mention   |
| ----------- | --------- |
| 90 et plus  | `"A"`     |
| 80 à 89     | `"B"`     |
| 70 à 79     | `"C"`     |
| Moins de 70 | `"Échec"` |

Exemple :

```csharp
string mention = DeterminerMention(85, 92);
Console.WriteLine(mention);
```

**Questions pour vous guider :**

1. Quelles informations la méthode doit-elle recevoir ?
2. Combien de paramètres sont nécessaires ?
3. Quel type doivent avoir les paramètres ?
4. Quel type doit retourner la méthode ?
5. Votre méthode peut-elle être utilisée avec n'importe quelles deux notes ?

---

## ⚫ Je relève le défi

Prêt à relever un défi ? Rends-toi sur la page du défi pour mettre tes connaissances à l'épreuve !

👉 [Accéder au défi sur les fonctions](../06-defis/fonctions.md)

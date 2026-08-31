---
description: Structures conditionnelles if/else, booléens
---



# 🤔 Booléens, Conditions et Débogage

---

## 🏆 QUIZ de révision 
<Quiz file="/quiz/quiz-rencontre1-2.json" />

## 🎯 Objectif

Comprendre ce que sont les booléens, manipuler les comparaisons, structurer des décisions avec `if`, `else`, `else if`, combiner des conditions avec les opérateurs logiques, et utiliser des outils de débogage pour comprendre ce qui se passe dans un programme.

---

## 🧠 Type booléen

Un **booléen** est un type de donnée qui peut prendre **deux valeurs seulement** : `true` (vrai) ou `false` (faux). On les utilise pour **vérifier si quelque chose est vrai ou faux**.

```csharp
bool aLesYeuxBleus = false;
bool estMajeur = true;
bool contientLettreT = false;
bool aUtiliseUnExtincteur = false;
```

👉 **Attention !** `true` n’est pas `"true"` :

```csharp
bool ok = true;       // ✔️ correct
string texte = "true"; // ❌ ce n’est pas un booléen
```

---

## ⚖️ Opérateurs de comparaison

Ils comparent deux valeurs et **retournent un booléen**.

| Opérateur | Signification      | Exemple  | Résultat |
| --------- | ------------------ | -------- | -------- |
| `>`       | Plus grand que     | `5 > 3`  | `true`   |
| `>=`      | Plus grand ou égal | `5 >= 5` | `true`   |
| `<`       | Plus petit que     | `3 < 5`  | `true`   |
| `<=`      | Plus petit ou égal | `3 <= 2` | `false`  |
| `==`      | Égal à             | `5 == 5` | `true`   |
| `!=`      | Différent de       | `5 != 6` | `true`   |


👉 Vue complète : [Opérateur](https://info.cegepmontpetit.ca/notions-csharp/documentation/operateur)

### ⚠️ `=` vs `==`

* `=` : affectation (ex. `x = 5`)
* `==` : comparaison (ex. `x == 5`)

```csharp
int x = 5;
if (x == 5) { ... } // ✅ compare
if (x = 5) { ... }  // ❌ erreur en C#, car x = 5 n’est pas un booléen
```

---

## 🔁 Structures conditionnelles

### `if` simple

```csharp
int age = 20;
if (age >= 18)
{
    Console.WriteLine("Tu es majeur.");
}
```

* Si la condition est `true`, le bloc est exécuté.
* Sinon, il est ignoré.

---

### `if` + `else`

```csharp
int argent = 1;
if (argent >= 2)
{
    Console.WriteLine("Voici ton paquet de gommes.");
}
else
{
    Console.WriteLine("Tu n’as pas assez d’argent.");
}
```

* L’un des deux blocs est toujours exécuté.

---

### `if` + `else if` + `else`

```csharp
int a = 4;

if (a < 3)
{
    Console.WriteLine("Petit");
}
else if (a > 5)
{
    Console.WriteLine("Grand");
}
else
{
    Console.WriteLine("Moyen");
}
```

🧠 À retenir :

* Le **premier bloc `true`** est exécuté, les autres sont ignorés.
* Le `else` est **optionnel**.
* On peut ajouter autant de `else if` que nécessaire.

---

### Plusieurs `if` indépendants

```csharp
if (age >= 18)
{
    Console.WriteLine("Majeur");
}
if (age < 30)
{
    Console.WriteLine("Jeune");
}
```

* Les deux blocs peuvent s’exécuter, indépendamment.

👉 Voir plus : [if (Structures de contrôle)](https://info.cegepmontpetit.ca/notions-csharp/documentation/structures-de-controle/if)

---

## 🧩 Opérateurs logiques

Permettent de **combiner plusieurs conditions**.

### `&&` (ET)

Toutes les conditions doivent être vraies.

```csharp
if (age >= 18 && age < 30)
{
    Console.WriteLine("Tu es un jeune adulte 👨‍🎓");
}
```

---

### `||` (OU)

Au moins une condition doit être vraie.

```csharp
if (age < 4 || age > 99)
{
    Console.WriteLine("Tu ne peux pas jouer avec des LEGO 😭");
}
```

---

### `!` (NON)

Inverse une condition.

```csharp
bool estMineur = true;
if (!estMineur)
{
    Console.WriteLine("Tu es majeur.");
}
```

---

### Autres exemples utiles :

```csharp
// Au moins un des prix est élevé
if (prix1 > 5 || prix2 > 5 || prix3 > 5) { ... }

// Trois couleurs identiques
if (couleur1 == couleur2 && couleur2 == couleur3) {
    Console.WriteLine("Les couleurs sont identiques.");
}
```

👉 Plus de détails : [Logique (opérateurs logiques)](https://info.cegepmontpetit.ca/notions-csharp/documentation/operateur/logique)

---

## 🐞 Erreurs fréquentes à éviter

* Mettre une condition évidente :

  ```csharp
  if (true) { ... } // Inutile
  ```

* Oublier les accolades `{}` quand il y a plusieurs instructions

* Confondre `=` (affectation) avec `==` (comparaison)

* Ne pas bien grouper les conditions logiques avec des parenthèses :

  ```csharp
  // Mauvais
  if (a > 5 && b > 5 || c > 5) { ... }

  // Meilleur
  if ((a > 5 && b > 5) || c > 5) { ... }
  ```

---

## 🧮 Assignation composée

L’**assignation composée** simplifie l’écriture :

```csharp
int a = 7, b = 10;
a += b; // équivaut à a = a + b; → 17
a *= 2; // équivaut à a = a * 2;
a++;    // incrémentation
a--;    // décrémentation
```

👉 Explication complète : [Assignation composée](https://info.cegepmontpetit.ca/notions-csharp/documentation/operateur/assignation-composee)

---


## 🔍 Débogage avec Visual Studio

Le **débogueur** permet d’exécuter étape par étape et d’observer les valeurs à tout moment :

### 🛠️ Guide pratique

1. Placer un **point d'arrêt**
2. Lancer en mode débogage (`F5`)
3. Utiliser `F10` (**Step Over**) ou `F11` (**Step Into**)
4. Observer les variables via les fenêtres **Locals** ou **Autos**

---
Vous devez réaliser les labos suivants :
 [🧪 Labo 2.1A](/laboratoire/laboratoire2.1A)
 [🧪 Labo 2.1B](/laboratoire/laboratoire2.1B)
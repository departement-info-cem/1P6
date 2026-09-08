---
title: B - Fonctions avec paramètres et Portée des variables
---

# 🧪 Labo 3.1B – Fonctions avec paramètres et Portée des variables

Nous allons réaliser une série d’exercices permettant de pratiquer la **définition de fonctions avec paramètres** en C#.

Pour **chaque exercice**, créez un **nouveau projet** dans Visual Studio.

---

## 📌 Rappel : Syntaxe d’une fonction avec paramètres

```csharp
static void NomDeLaFonction(type param1, type param2)
{
    // Instructions
}
```

### Exemple

```csharp
static void MessageDeBienvenue(string prenom, string nom)
{
    Console.WriteLine("Bienvenue " + prenom + " " + nom);
}
```

## 🟢 J'applique

### 🟢 Exercice 1 – Message personnalisé


Créez une méthode nommée AfficherMessage qui affiche les informations d'une personne.

La méthode doit recevoir en paramètres :

* le prénom;
* le nom;
* l'âge;
* la ville.

Elle doit afficher une phrase semblable à :
```text
Bonjour Benoit Caldairou, vous avez 20 ans et vous venez de Montréal.
```

#### Pour vous guider
* Quelles informations la méthode doit-elle recevoir ?
* Quel paramètre correspond à chaque information ?
* Quel type de données devez-vous utiliser pour chaque paramètre ?
* Appelez votre méthode avec différentes personnes pour vérifier qu'elle est réutilisable.


> 💡 **Une bonne méthode doit pouvoir être réutilisée avec différentes valeurs. Les informations qui peuvent varier d'un appel à l'autre doivent généralement être fournies à la méthode à l'aide de paramètres.**

---

### 🟢 Exercice 2 – Périmètre d’un rectangle

Créez une méthode nommée `AfficherPerimetre` qui affiche le **périmètre d'un rectangle**.

La méthode doit pouvoir fonctionner avec **n'importe quelle largeur et n'importe quelle hauteur**.

> Formule :
> `périmètre = 2 × (largeur + hauteur)`

Par exemple :

```text
Largeur : 5
Hauteur : 3
Périmètre : 16
```

#### Pour vous guider

* Quelles informations sont nécessaires pour calculer le périmètre ?
* Quelles informations peuvent changer d'un rectangle à l'autre ?
* Quels paramètres votre méthode doit-elle recevoir ?
* Quel type doit avoir chaque paramètre ?
* Pouvez-vous utiliser la même méthode pour calculer le périmètre de plusieurs rectangles **sans modifier son code** ?

---


### 🟢 Exercice 3 – Portée des variables

1. Créez un nouveau projet **Console App** nommé `ExercicePortee`.
2. Copiez le code suivant, puis **essayez de le compiler tel quel** :

```csharp
 1  using System;
 2
 3  class Program
 4  {
 5      static int nombreGlobal = 42;
 6
 7      static void Main()
 8      {
 9          int nombreMain = 10;
10
11          if (nombreMain > 5)
12          {
13              int nombreBloc = 5;
14              Console.WriteLine("Bloc if : " + nombreBloc);
15          }
16
17          Console.WriteLine("Main : " + nombreMain);
18          Console.WriteLine("Global : " + nombreGlobal);
19
20          // Console.WriteLine("Bloc : " + nombreBloc);
21      }
22
23      static void AutreMethode()
24      {
25          // Console.WriteLine(nombreMain);
26          Console.WriteLine("Global dans AutreMethode : " + nombreGlobal);
27      }
28  }
```

---

#### 🔍 Questions de réflexion

##### 1. Observer la portée

- Pourquoi peut-on utiliser `nombreBloc` à l'intérieur du `if` ?
- Pourquoi ne peut-on pas utiliser `nombreBloc` après le `if` ?
- Pourquoi `nombreMain` peut-il être utilisé dans `Main()` ?
- Pourquoi `nombreMain` n'est-il pas accessible depuis `AutreMethode()` ?
- Quelle variable peut être utilisée dans `Main()` **et** dans `AutreMethode()` ?
- Qu'est-ce que les `{ }` créent dans ce contexte ?

##### 2. Prédire avant de tester


```csharp
 1  using System;
 2
 3  class Program
 4  {
 5      static int nombreGlobal = 42;
 6
 7      static void Main()
 8      {
 9          int nombreMain = 10;
10
11          if (nombreMain > 5)
12          {
13              int nombreBloc = 5;
14              Console.WriteLine("Bloc if : " + nombreBloc);
15          }
16
17          Console.WriteLine("Main : " + nombreMain);
18          Console.WriteLine("Global : " + nombreGlobal);
19
20          // Console.WriteLine("Bloc : " + nombreBloc);
21      }
22
23      static void AutreMethode()
24      {
25          // Console.WriteLine(nombreMain);
26          Console.WriteLine("Global dans AutreMethode : " + nombreGlobal);
27      }
28  }
```

Dans le programme fourni, observez les lignes **17, 18 et 20**.

Pour chacune des instructions suivantes, indiquez si elle peut être exécutée sans erreur :

| Ligne | Instruction                                      | Accessible ? |
| ----- | ------------------------------------------------ | ------------ |
| 18    | `Console.WriteLine("Global : " + nombreGlobal);` | ☐ Oui ☐ Non  |
| 17    | `Console.WriteLine("Main : " + nombreMain);`     | ☐ Oui ☐ Non  |
| 20    | `Console.WriteLine("Bloc : " + nombreBloc);`     | ☐ Oui ☐ Non  |

**Pour chaque réponse, justifiez votre choix en indiquant la portée de la variable.**


##### 3. Faire le lien avec les méthodes

Supposons que `AutreMethode()` ait besoin de la valeur de `nombreMain`.

- Peut-elle utiliser directement `nombreMain` ?
- Pourquoi ?
- Comment pourrait-on **transmettre cette valeur** à `AutreMethode()` ?
- Quelle modification faudrait-il apporter à la définition de `AutreMethode()` ?
- Quelle valeur faudrait-il fournir lors de l'appel de la méthode ?

Essayez ensuite de modifier le programme pour pouvoir écrire :

```csharp
AutreMethode(nombreMain);
```

et obtenir :

```text
Nombre reçu : 10
```

##### 4. Réflexion sur les paramètres

Comparez maintenant les deux méthodes :

```csharp
static void AutreMethode()
{
    // ...
}
```

et

```csharp
static void AutreMethode(int nombre)
{
    // ...
}
```

- Quelle est la différence entre les deux méthodes ?
- Dans la deuxième version, d'où vient la valeur de `nombre` ?
- Pourquoi est-il utile d'utiliser un paramètre lorsqu'une méthode doit travailler avec une valeur provenant d'une autre méthode ?
- Si on veut pouvoir utiliser `AutreMethode()` avec plusieurs valeurs différentes, quelle solution permet de rendre la méthode plus réutilisable ?

---

#### ✅ À faire

1. Corrigez les lignes commentées qui causent des erreurs.

2. Ajoutez une nouvelle méthode `AfficherGlobalEtLocal()` qui essaie d'accéder aux différentes variables.

3. Avant de compiler, prédisez quelles variables pourront être utilisées dans cette nouvelle méthode.

4. Dessinez un petit schéma ou commentez votre code pour indiquer la **portée de chaque variable**.

5. Modifiez `AfficherGlobalEtLocal()` afin qu'elle puisse recevoir une valeur provenant de `Main()` à l'aide d'un **paramètre**.

6. Appelez cette méthode avec différentes valeurs afin de vérifier qu'elle est réutilisable.

---



## 🟣 JE RÉSOUS

### 🟣 Exercice 4 – Table de multiplication

Créez une méthode qui affiche la **table de multiplication d'un nombre jusqu'à 10**.

Par exemple, pour le nombre `3` :

```text
3 x 1 = 3
3 x 2 = 6
3 x 3 = 9
...
3 x 10 = 30
```

La méthode doit pouvoir être utilisée pour afficher la table de **n'importe quel nombre entier**.

#### Pour vous guider

Avant d'écrire votre méthode, posez-vous les questions suivantes :

1. Qu'est-ce qui peut changer d'une table à l'autre ?
2. Quelle information doit être fournie à la méthode ?
3. Quel paramètre devez-vous prévoir ?
4. Quel type doit avoir ce paramètre ?
5. Pouvez-vous appeler votre méthode pour afficher les tables de `3`, `7` et `12` sans modifier la méthode ?

---

### 🟣 Exercice 5 – Conversion de température

On veut écrire une méthode qui permet de convertir une température exprimée en degrés Celsius en degrés Fahrenheit et d’afficher le résultat.

La formule de conversion est :

```text
Fahrenheit = Celsius × 9 / 5 + 32
```

La méthode doit pouvoir être utilisée pour convertir **différentes températures**.

Par exemple :

```text
0 °C  → 32 °F
20 °C → 68 °F
30 °C → 86 °F
```

#### Pour vous guider

1. Quelles informations la méthode doit-elle recevoir ?
2. Combien de paramètres sont nécessaires ?
3. Quel doit être le type de chaque paramètre ?
4. La méthode doit-elle afficher le résultat ou retourner une valeur ?

---

### 🟣 Exercice 6 – Année bissextile

Créez une méthode qui reçoit une année en paramètre et affiche si cette année est bissextile ou non.

Une année est bissextile si :

* elle est divisible par 400;

OU

* elle est divisible par 4 ET elle n'est pas divisible par 100.

**Exemples d'années bissextiles :**
```text
1600
2000
1996
1992
2024
```
**Exemples d'années non bissextiles :**
```text
1997
2006
1900
```

#### 🔍 Questions pour vous guider

Avant d'écrire votre méthode, réfléchissez aux questions suivantes :

* Quelle information la méthode doit-elle recevoir pour déterminer si une année est bissextile ?
* Quel paramètre devez-vous utiliser ?
* Quel type doit avoir ce paramètre ?
* Votre méthode peut-elle être utilisée avec n'importe quelle année sans modifier son code ?


### 💡 Petit défi supplémentaire

Une fois votre méthode terminée, testez-la avec au moins trois autres années de votre choix.







---
title: Aide-mémoire
---


### 1. Introduction, Entrées/Sorties et Variables



#### 🖨️ Affichage avec `Console.WriteLine()`
Affiche un message dans la console et passe à la ligne suivante.
```csharp
Console.WriteLine("Bienvenue dans le programme !");
```

#### 🖊️ Affichage sans retour à la ligne : `Console.Write()`
Utile pour inviter l'utilisateur à écrire une réponse sur la même ligne.
```csharp
Console.Write("Entrez votre nom : ");
```

#### ⌨️ Lecture de l’entrée avec `Console.ReadLine()`
Lit un texte entré par l'utilisateur (toujours une `string`, c'est un type de **variable** (voir rencontre 2)).
```csharp
string nom = Console.ReadLine();
```

#### 🧠 Exemple complet
```csharp
Console.Write("Quel est ton prénom ? ");
string prenom = Console.ReadLine();
Console.WriteLine("Bonjour, " + prenom + "!");
```

* **Affichage console (`Console.WriteLine` / `Console.Write`) et Lecture (`Console.ReadLine`)** :
```csharp
// Console.Write laisse le curseur sur la même ligne pour l'entrée
Console.Write("Quel est ton nom ? ");
string nom = Console.ReadLine();

// Console.WriteLine ajoute un saut de ligne automatique à la fin
Console.WriteLine("Bonjour " + nom + " !");

```


* **Déclaration des types de base** :
```csharp
int age = 20;               // Nombre entier
double prix = 14.99;        // Nombre décimal
char lettre = 'A';          // Caractère unique
bool estMajeur = true;      // Booléen (true ou false)
string ville = "Montreal";  // Chaîne de caractères

```

---



#### 🖨️ Affichage et formatage du texte : Concaténation (`+`) vs Interpolation (`$`)


En C#, pour afficher du texte combiné à des variables, on peut utiliser la **concaténation** avec `+` ou **l'interpolation** avec `$`.

Voici un exemple de code complet en C# qui montre les deux façons d'afficher exactement le même résultat :

```csharp
string prenom = "Alice";
int age = 22;
double moyenne = 89.5;

// Utilisation de '+' pour assembler le texte et les variables
Console.WriteLine("Nom : " + prenom + ", Âge : " + age + " ans, Moyenne : " + moyenne + "%");

// Utilisation de '$' au début et des accolades '{}' pour les variables
Console.WriteLine($"Nom : {prenom}, Âge : {age} ans, Moyenne : {moyenne}%");


// Résultat affiché dans la console :
// Nom : Alice, Âge : 22 ans, Moyenne : 89.5%

```

---

### 2. Expressions Arithmétiques

Les expressions arithmétiques permettent de faire des calculs mathématiques avec des nombres (`int`, `double`).

* **Les opérateurs de base (`+`, `-`, `*`, `/`, `%`)** :
```csharp
int a = 10;
int b = 3;

int somme = a + b;       // 13
int difference = a - b;  // 7
int produit = a * b;     // 30
int quotient = a / b;    // 3 (Division entière : 10 divisé par 3 donne 3, le reste est ignoré)
int reste = a % b;       // 1 (Modulo : le reste de la division de 10 par 3, car 3*3=9, il reste 1)


```

#### EXEMPLES D'USAGES DU MODULO

```csharp
// --- EXEMPLES D'USAGES DU MODULO ---

// 1. Vérifier si un nombre est pair ou impair (très courant avec % 2)
int nombre = 4;
if (nombre % 2 == 0)
{
    // Si le reste est 0, le nombre est pair
    // (4 % 2 donne 0)
}

// 2. Vérifier si un nombre est un multiple (ex: multiple de 3)
int testMultiple = 9;
if (testMultiple % 3 == 0)
{
    // 9 est un multiple de 3, car 9 / 3 donne 3 avec un reste de 0
}


```

* **⚠️ Attention au piège de la division d'entiers (`int` vs `double`)** :
* Si tu divises deux `int`, C# fait une division entière et supprime les décimales. Pour avoir un résultat précis (`double`), il faut qu'au moins l'un des nombres soit un `double`.


```csharp
// Piège :
double mauvaisResultat = 5 / 2;     // Donne 2.0 (car 5 et 2 sont des int au départ)

// Solution correcte :
double bonResultat = 5.0 / 2;       // Donne 2.5

```


* **Opérateurs composés** :
```csharp
int score = 10;
score++;          // Incrémente de 1 (score vaut maintenant 11)
score--;          // Décrémente de 1 (score revient à 10)

score += 5;       // Équivaut à : score = score + 5 (score vaut 15)
score *= 2;       // Équivaut à : score = score * 2 (score vaut 30)

```

---
### 3. Conversion de types

Lorsqu’on lit une entrée utilisateur via `Console.ReadLine()`, on obtient toujours une **chaîne de caractères (`string`)**. Pour utiliser cette entrée comme un nombre, il faut la convertir.

#### 🔁 Convertir une `string` en `int`
```csharp
Console.Write("Entrez votre âge : ");
string saisie = Console.ReadLine();
int age = int.Parse(saisie);
```

#### 🔁 Convertir en `double`
```csharp
Console.Write("Entrez un prix : ");
string entree = Console.ReadLine();
double prix = double.Parse(entree);
```

---

### 📝 Qu’est-ce que `TryParse` ?

`TryParse` est une fonction disponible sur plusieurs types de base en C#.  
Elle permet de **convertir une chaîne de caractères** en un type donné **sans lever d’exception** en cas d’échec.

Contrairement à `Parse` qui lève une exception si la conversion échoue, `TryParse` retourne simplement `true` si la conversion réussit, ou `false` sinon.
#### Exemple d'utilisation : Lecture de l'âge d'une personne qui doit être un nombre entier
```csharp
Console.Write("Entrez votre âge : ");
string saisie = Console.ReadLine();
int age;
bool conversion = int.TryParse(saisie, out age);

if (conversion)
{
    Console.WriteLine("Conversion réussie!");
}
else
{
    Console.WriteLine("Échec de conversion! La valeur saisie est invalide!!");
}

```
---
### 4. Expressions Booléennes

Une expression booléenne est une condition ou une combinaison de conditions qui retourne **toujours un booléen (`true` ou `false`)**. On les utilise principalement dans les structures `if`.

* **Comparaisons simples (`>`, `<`, `>=`, `<=`, `==`, `!=`)** :
```csharp
int age = 20;

bool estMajeur = (age >= 18);          // true (20 est plus grand ou égal à 18)
bool estExactement18 = (age == 18);   // false
bool estDifferentDe10 = (age != 10);  // true

```


* **Opérateurs logiques (`&&` = ET, `||` = OU, `!` = NON)** :
Ils servent à combiner plusieurs expressions booléennes ensemble.
* **`&&` (ET logique) : Vrai SEULEMENT SI toutes les conditions sont vraies.**
```csharp
int age = 20;
bool aSonPermis = true;

// Pour conduire, il faut être majeur ET avoir son permis
bool peutConduire = (age >= 18) && aSonPermis; // true (les deux sont vrais)

```


* **`||` (OU logique) : Vrai si AU MOINS UNE des conditions est vraie.**
```csharp
bool estEtudiant = true;
bool aUnCoupon = false;

// A droit au rabais si on est étudiant OU si on a un coupon
bool aDroitAuRabais = estEtudiant || aUnCoupon; // true (car estEtudiant est vrai)

```


* **`!` (NON logique) : Inverse la valeur booléenne (vrai devient faux, et vice-versa).**
```csharp
bool estConnecte = false;

// Si l'utilisateur n'est PAS connecté
bool doitAfficherLogin = !estConnecte; // true (car !false donne true)

```




* **Exemple complet dans un `if` avec des opérateurs combinés** :
```csharp
int age = 17;
bool aUneInvitationVIP = true;

// Entre si la personne a 18 ans ou plus, OU si elle a une invitation VIP
if ((age >= 18) || aUneInvitationVIP)
{
    Console.WriteLine("Bienvenue dans la salle !");
}
else
{
    Console.WriteLine("Accès refusé.");
}
// Résultat affiché : "Bienvenue dans la salle !" (grâce à l'invitation VIP, malgré l'âge).

```




* **Conversion sécurisée (`TryParse`)** :
* *Utile pour éviter que le programme plante si l'utilisateur entre du texte au lieu d'un nombre.*


```csharp
Console.Write("Entrez votre âge : ");
string saisie = Console.ReadLine();
int ageUtilisateur = 0;

// int.TryParse essaie de convertir la string en int
if (int.TryParse(saisie, out ageUtilisateur))
{
    Console.WriteLine("Conversion réussie ! Vous avez " + ageUtilisateur + " ans.");
}
else
{
    Console.WriteLine("Erreur : ce n'est pas un nombre valide.");
}

```


* **Constantes (`const`)** :
```csharp
// La valeur ne pourra plus être modifiée par la suite
const double TAXE_TPS = 0.05;
double sousTotal = 100.0;
double totalFinal = sousTotal + (sousTotal * TAXE_TPS);

```



---

### 5. Structures Conditionnelles (`if` / `else`)

* **Structure complète (`if`, `else if`, `else`)** :
```csharp
int note = 75;

if (note >= 90)
{
    Console.WriteLine("Mention : Excellent (A)");
}
else if (note >= 70)
{
    Console.WriteLine("Mention : Bien (B)");
}
else if (note >= 60)
{
    Console.WriteLine("Mention : Passable (C)");
}
else
{
    Console.WriteLine("Mention : Échec (F)");
}

```


* **Attention `=` vs `==**` :
```csharp
int x = 10;

// x == 10 compare la valeur (Correct dans un if)
if (x == 10) 
{
    Console.WriteLine("x vaut 10");
}

// x = 10 affecte la valeur (❌ Provoque une erreur de compilation dans un if)
// if (x = 10) { ... } 

```

---

### 6. Les Fonctions (Méthodes)

#### Anatomie d'une fonction (Méthode en C#)

```csharp
[Visibilité] [TypeDeRetour] NomDeLaFonction([Paramètres])
{
    // Instructions (code de la fonction)
    return valeur; // Obligé si le TypeDeRetour n'est pas 'void'
}

```

* **`void` :** Utilisé si la fonction exécute des actions (ex: `Console.WriteLine`) mais **ne retourne aucune valeur** au code qui l'a appelée.
* **`return` :** Permet de renvoyer un résultat (un `int`, un `string`, un `bool`, etc.) et **arrête immédiatement** l'exécution de la fonction.

---

#### Exemples types

##### A. Une fonction sans paramètre et sans retour (`void`)

```csharp
static void AfficherMessageBienvenue()
{
    Console.WriteLine("Bienvenue dans le programme !");
}
// Appel dans le Main : AfficherMessageBienvenue();

```

##### B. Une fonction avec paramètres et sans retour (`void`)

```csharp
static void AfficherSomme(int nb1, int nb2)
{
    int resultat = nb1 + nb2;
    Console.WriteLine("La somme est : " + resultat);
}
// Appel dans le Main : AfficherSomme(5, 10);

```

##### C. Une fonction avec paramètres et avec retour (ex: `int`)

```csharp
static int CalculerCarre(int nombre)
{
    int carre = nombre * nombre;
    return carre; // On retourne le résultat
}
// Appel dans le Main : int resultat = CalculerCarre(4);

```

---

#### Comment appeler une méthode ?

##### A. Méthode sans valeur de retour (`void`)

Une méthode `void` fait une action (ex: afficher du texte), mais **ne donne rien en retour**. On ne peut donc pas l'assigner à une variable. On l'appelle simplement par son nom en lui passant les bons paramètres.

```csharp
// Définition de la méthode
static void AfficherSalutation(string nom)
{
    Console.WriteLine("Bonjour " + nom);
}

// --- APPEL DANS LE PROGRAMME (ex: dans Main) ---
AfficherSalutation("Alice"); // Affiche : Bonjour Alice

```

##### B. Méthode avec valeur de retour (`int`, `string`, `double`, etc.)

Une méthode avec un type de retour calcule ou récupère une information et la **ramène** grâce au `mot-clé return`. Pour l'utiliser, il faut **obligatoirement stocker le résultat dans une variable** ou l'utiliser directement dans une instruction.

```csharp
// Définition de la méthode
static int CalculerCarre(int nombre)
{
    return nombre * nombre;
}

// --- APPEL DANS LE PROGRAMME ---
int resultat = CalculerCarre(5); // La variable 'resultat' vaut maintenant 25

```

---

#### Utiliser une méthode dans une expression arithmétique

Puisqu'une méthode avec valeur de retour se comporte exactement comme la valeur qu'elle retourne, vous pouvez l'utiliser directement dans un calcul mathématique. C'est comme si le nom de la méthode était remplacé par son résultat.

```csharp
static int MultiplierParDeux(int n)
{
    return n * 2;
}

// --- EXEMPLE D'UTILISATION ---
int x = 10;
// On appelle la méthode directement au milieu d'une addition et d'une multiplication
int total = 5 + MultiplierParDeux(x) * 3; 

// Étape par étape :
// 1. MultiplierParDeux(10) retourne 20
// 2. Le calcul devient : 5 + 20 * 3
// 3. Priorité des opérations : 20 * 3 = 60
// 4. total = 5 + 60 -> 65

```

---

#### Utiliser une méthode dans un `if` (Structure conditionnelle)

Pour utiliser une méthode dans un `if`, la méthode doit retourner un type booléen (`bool` : `true` ou `false`). Le `if` évaluera directement le résultat de la méthode.

```csharp
// Définition d'une méthode qui retourne un booléen
static bool EstMajeur(int age)
{
    if (age >= 18)
    {
        return true;
    }
    else
    {
        return false;
    }
    // (Version courte : return age >= 18;)
}

// --- EXEMPLE D'UTILISATION DANS UN IF ---
int ageClient = 20;

if (EstMajeur(ageClient)) 
{
    Console.WriteLine("Accès autorisé.");
}
else
{
    Console.WriteLine("Accès refusé.");
}

```

---

### 7. Boucles (`for`)

* **Boucle `for` classique (incrémentation)** :
* *Exemple pour afficher les nombres de 1 à 5 :*


```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Itération numéro : " + i);
}

```


* **Boucle `for` avec un pas personnalisé (multiples de 3)** :
```csharp
Console.WriteLine("Multiples de 3 :");
for (int i = 0; i < 15; i += 3)
{
    Console.Write(i + " "); // Affiche : 0 3 6 9 12
}

```


* **Boucle `for` en décrémentation (compte à rebours)** :
```csharp
for (int i = 3; i > 0; i--)
{
    Console.WriteLine(i + "...");
}
Console.WriteLine("Partez !");

```



---

### 8. Tableaux 1D (Arrays)

* **Déclaration et initialisation** :
```csharp
// Tableau préinitialisé avec des valeurs
int[] notesEtudiants = { 85, 90, 78, 92, 88 };

// Tableau vide de 4 éléments (initialisés par défaut à 0)
int[] scores = new int[4];

```


* **Accès par index et modification (`.Length`)** :
```csharp
int[] notes = { 85, 90, 78 };

Console.WriteLine(notes[0]); // Affiche 85 (premier élément)

// Modifier un élément
notes[1] = 95; // Remplace 90 par 95

// Accéder au dernier élément dynamiquement avec .Length
int dernierElement = notes[notes.Length - 1]; // notes[2] -> 78

```


* **Parcourir un tableau avec une boucle `for**` :
```csharp
int[] notes = { 85, 90, 78, 92 };

for (int i = 0; i < notes.Length; i++)
{
    Console.WriteLine("Note à l'index " + i + " : " + notes[i]);
}

```

---

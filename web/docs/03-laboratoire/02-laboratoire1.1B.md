---
title: B - Exercices
---

# 🧪 Labo 1.1B – Exercices

Les exercices sont organisés en quatre niveaux. Chaque niveau demande progressivement plus d'autonomie.

* 🟢 **Je comprends** : je peux lire, interpréter et expliquer un programme simple.
* 🔵 **J'applique** : je peux produire un programme en suivant des consignes détaillées.
* 🟣 **Je résous** : je peux analyser un problème et construire moi-même une solution.
* ⚫ **Je relève le défi** : je peux résoudre un problème plus complexe ou moins guidé en combinant plusieurs notions.

---

## 🟢 Je comprends

> 🧠 **Je comprends :** je peux lire un programme simple et déterminer s'il répond à l'objectif demandé.

Pour chaque question, **lisez l'objectif et le code fourni**.

**Le code est-il correct?**
Si le code est incorrect, **identifiez le problème**.

### A. Comprendre le code

#### Question 1 — Afficher un message

**Objectif :** afficher le message `Bienvenue!`.

```csharp
Console.WriteLine("Bienvenue!");
```

Le code est-il correct? Expliquez votre réponse.

---

#### Question 2 — Utiliser `Console.Write()`

**Objectif :** afficher le message `Bonjour`.

```csharp
Console.Write("Bonjour");
```

Le code est-il correct? Expliquez votre réponse.

---

#### Question 3 — Utiliser `Write` et `WriteLine`

**Objectif :** afficher les deux messages sur deux lignes différentes.

```csharp
Console.Write("Bonjour");
Console.WriteLine("Bienvenue!");
```

Le code est-il correct? Expliquez votre réponse.

---

#### Question 4 — Afficher sur une seule ligne

**Objectif :** afficher `Bonjour Bienvenue!` sur une seule ligne.

```csharp
Console.WriteLine("Bonjour");
Console.WriteLine("Bienvenue!");
```

Le code est-il correct? Si non, quel est le problème?

---

#### Question 5 — Lire une information

**Objectif :** demander le prénom de l'utilisateur et conserver l'information saisie.

```csharp
string prenom;

Console.Write("Quel est votre prénom? ");
prenom = Console.ReadLine();
```

Le code est-il correct? Expliquez votre réponse.

---

#### Question 6 — Afficher une information lue

**Objectif :** demander le prénom de l'utilisateur et afficher ensuite le prénom saisi.

```csharp
string prenom;

Console.Write("Quel est votre prénom? ");
prenom = Console.ReadLine();

Console.WriteLine(prenom);
```

Le code est-il correct? Expliquez votre réponse.

---

#### Question 7 — Concaténer une information

**Objectif :** afficher `Bonjour Sébastien!` lorsque l'utilisateur saisit `Sébastien`.

```csharp
string prenom;

Console.Write("Quel est votre prénom? ");
prenom = Console.ReadLine();

Console.WriteLine("Bonjour " + prenom + "!");
```

Le code est-il correct? Expliquez votre réponse.

---

#### Question 8 — Erreur de concaténation

**Objectif :** afficher `Bonjour Sébastien!` lorsque l'utilisateur saisit `Sébastien`.

```csharp
string prenom;

Console.Write("Quel est votre prénom? ");
prenom = Console.ReadLine();

Console.WriteLine("Bonjour " + "prenom" + "!");
```

Le code est-il correct? Si non, expliquez le problème.

---

#### Question 9 — Plusieurs informations

**Objectif :** demander le prénom et le nom de l'utilisateur, puis afficher :

```text
Bonjour Amine Tremblay!
```

si l'utilisateur saisit `Sébastien` et `Derumière`.

```csharp
string prenom;
string nom;

Console.Write("Prénom : ");
prenom = Console.ReadLine();

Console.Write("Nom : ");
nom = Console.ReadLine();

Console.WriteLine("Bonjour " + prenom + " " + nom + "!");
```

Le code est-il correct? Expliquez votre réponse.

---

Oui. Pour la question de synthèse, je prendrais un contexte différent et j'introduirais **une erreur de concaténation** que l'étudiant doit repérer.

#### Question 10 — Synthèse

**Objectif :** demander à l'utilisateur le nom d'un jeu vidéo et sa plateforme, puis afficher une phrase présentant le jeu.

Par exemple, si l'utilisateur saisit :

```text
Jeu : Minecraft
Plateforme : PC
```

le programme doit afficher :

```text
Vous jouez à Minecraft sur PC.
```

Le code suivant permet-il d'atteindre l'objectif?

```csharp
Console.Write("Nom du jeu : ");
string jeu = Console.ReadLine();

Console.Write("Plateforme : ");
string plateforme = Console.ReadLine();

Console.WriteLine("Vous jouez à " + jeu " sur " + plateforme + ".");
```

Le code est-il correct? Si non, identifiez et expliquez l'erreur.




### B. Repérer une erreur de syntaxe

> ❌ **Le code suivant contient une erreur. Identifiez l'erreur et indiquez comment la corriger.**

#### Question 11

**Objectif :** afficher `Bonjour!`.

```csharp
Console.WriteLine("Bonjour!";
```

Quelle est l'erreur?

---

#### Question 12

**Objectif :** afficher `Bienvenue!`.

```csharp
Console.WriteLine("Bienvenue!);
```

Quelle est l'erreur?

---

#### Question 13

**Objectif :** afficher `Bonjour!`.

```csharp
Console.WriteLine("Bonjour!")
```

Quelle est l'erreur?

---

#### Question 14

**Objectif :** afficher `Bonjour!`.

```csharp
console.WriteLine("Bonjour!");
```

Quelle est l'erreur?

---

#### Question 15

**Objectif :** afficher `Bonjour!`.

```csharp
Console.Writeline("Bonjour!");
```

Quelle est l'erreur?

---

#### Question 16

**Objectif :** afficher le prénom saisi par l'utilisateur.

```csharp
string prenom;

Console.Write("Prénom : ");
prenom = Console.ReadLine();

Console.WriteLine(prenon);
```

Quelle est l'erreur?

---

#### Question 17

**Objectif :** afficher le prénom saisi par l'utilisateur.

```csharp
Console.Write("Prénom : ");
prenom = Console.ReadLine();

Console.WriteLine("Bonjour " + prenom"!");
```

Quelle est l'erreur?

---

#### Question 18

**Objectif :** demander le prénom de l'utilisateur.

```csharp
string prenom;

Console.Write("Prénom : ";
prenom = Console.ReadLine();
```

Quelle est l'erreur?

---

#### Question 19

**Objectif :** afficher deux messages.

```csharp
Console.WriteLine("Bienvenue!");
Console.WriteLine("Bonne journée!")
```

Quelle est l'erreur?

---

#### Question 20 — Plusieurs erreurs

**Objectif :** demander le prénom de l'utilisateur et afficher `Bonjour [prénom]!`.

```csharp

Console.Write("Quel est votre prénom? ";
prenom = Console.ReadLine()

Console.WriteLine("Bonjour " + prenom + "!");
```

Identifiez **les deux erreurs** et indiquez comment les corriger.

---

## 🔵 J'applique

> 🔧 **J'applique :** je peux réaliser un programme en suivant une démarche proposée.

Pour chaque exercice :

1. Lisez l'énoncé.
2. Réalisez les étapes demandées dans l'ordre.
3. Vérifiez votre programme à l'aide du résultat attendu.

**Aucun code de départ n'est fourni.**

---

### Exercice 1 — Carte de visite

Créez un programme permettant de générer une carte de visite à partir des informations saisies par l'utilisateur.

**Travail demandé :**

1. Demander le prénom
2. Demander la passion
3. Demander la couleur préférée
4. Afficher un message personnalisé

**Exemple attendu :**
```
Quel est ton prénom ? Alex
Quelle est ta passion ? Musique
Quelle est ta couleur préférée ? Bleu
Bonjour Alex, ta passion est Musique et ta couleur préférée est le Bleu.
```

---

### Exercice 2 — Film préféré

Créez un programme permettant de présenter le film préféré de l'utilisateur.

**Travail demandé :**

1. Demandez le nom du film.
2. Demandez le genre du film.
3. Affichez une ligne vide.
4. Affichez une phrase contenant le nom du film.
5. Affichez une deuxième phrase contenant le genre du film.

**Résultat attendu :**

```text
Nom du film : Interstellar
Genre : Science-fiction

Votre film préféré est Interstellar.
Le genre du film est Science-fiction.
```

---

### Exercice 3 — Destination de voyage

Créez un programme permettant de présenter les informations d'un voyage.

**Travail demandé :**

1. Demandez la destination du voyage.
2. Demandez l'activité préférée pendant le voyage.
3. Affichez une ligne vide.
4. Affichez une phrase contenant la destination.
5. Affichez une deuxième phrase contenant l'activité choisie.

**Résultat attendu :**

```text
Destination : Paris
Activité préférée : Visiter des musées

Vous allez à Paris.
Votre activité préférée sera : Visiter des musées.
```

---

## 🟣 Je résous

> 🛠️ **Je résous :** je peux résoudre un problème en déterminant moi-même les étapes et les instructions nécessaires.

Ici, on ne donne **ni code ni démarche détaillée**.

### Exercice 1 — Profil musical 🎵

Créez un programme permettant de présenter les préférences musicales d'un utilisateur.

Le programme doit **demander les informations suivantes à l'utilisateur** :

* son prénom;
* son artiste préféré;
* son genre musical;
* sa chanson préférée.

Le programme doit ensuite afficher une présentation contenant toutes les informations saisies.

**Résultat attendu :**

```text
Prénom : Alex
Artiste préféré : Stromae
Genre musical : Pop
Chanson préférée : Alors on danse

Alex aime la musique pop.
Son artiste préféré est Stromae et sa chanson préférée est Alors on danse.
```

### Exercice 2 — Billet de cinéma

Créez un programme permettant de générer un billet de cinéma.

Le programme doit **demander les informations suivantes à l'utilisateur** :

* le prénom du client;
* le nom du film;
* l'heure de la séance.

Le programme doit ensuite afficher un billet contenant les informations saisies.

**Résultat attendu :**

```text
Prénom : Sara
Film : Avatar
Heure : 19h30

----------------------------
       BILLET DE CINÉMA
----------------------------
Sara
Film : Avatar
Séance : 19h30
----------------------------
```

### Exercice 3 — Fiche d'un animal

Créez un programme permettant de générer une fiche d'un animal.

Le programme doit **demander les informations suivantes à l'utilisateur** :

* le nom de l'animal;
* son type;
* son âge.

Le programme doit ensuite afficher une fiche contenant les informations saisies.

**Résultat attendu :**

```text
Nom de l'animal : Max
Type : Chien
Âge : 4

----------------------------
       FICHE DE L'ANIMAL
----------------------------
Nom : Max
Type : Chien
Âge : 4 ans
----------------------------
```

## 🟣 Je relève un défi

---
description: Objets, propriétés, méthodes et apprendre à les utiliser
---

# Introduction à la programmation orientée objet

## 🎯 Objectifs
1. Créer des objets avec **new** (Instancier des classes)
2. Comprendre le fonctionnement d’un objet en utilisant :
   - les propriétés exposées,
   - les méthodes disponibles,
3. Utiliser le débogueur (points d’arrêt, pas-à-pas, inspection des variables).


---

## 📝 Déroulement du cours

* **Comprendre la notion d’objet**
* **Démonstration avec la PouleMagique**
---

## 🔹 Les objets dans WinForms

Dans le dernier cours (**WinForms**), nous avons manipulé des **objets** . Chaque élément de l’interface — un **Button**, un **TextBox**, un **Label**, ou même la **Form** — est un **objet** créé à partir d’une classe.

Quand vous changez le texte d’un bouton, modifiez sa couleur, ou réagissez à son événement *Click*, vous travaillez avec les **propriétés**, **méthodes** et **événements** de cet objet.
Cela signifie que vous utilisez déjà la **programmation orientée objet**, souvent sans vous en rendre compte.

---
# 1. Classe = modèle + machine

Une **classe** joue deux rôles complémentaires :

### 🧩 1️⃣ La classe est un **modèle**

Elle décrit :

* les **propriétés** que les objets posséderont,
* les **méthodes** qu’ils pourront exécuter,
* la **structure** générale de l’objet.

C’est le **plan**!

### ⚙️ 2️⃣ La classe est une **machine**

À partir de ce modèle, la classe sert aussi de **machine qui fabrique des objets** quand on utilise **`new`**.

En résumé :

> 👉 **La classe est à la fois le modèle de l’objet et la machine qui permet d’en fabriquer des exemplaires.**

---

# 2. Instanciation

L’**instanciation** consiste à créer un objet à partir d’une classe grâce au mot-clé `new`.

```csharp
MaClasse objet = new MaClasse();
```

### Exemples d’instanciation

#### 🟦 Exemple 1 : Classe `Random`

```csharp
Random r = new Random();
int nombre = r.Next(1, 10);  // Méthode Next()
```

#### 🟦 Exemple 2 : Classe `Button` (WinForms)

```csharp
Button b = new Button();
b.Text = "Clique-moi";
b.Width = 120;
```

#### 🟦 Exemple 3 : Classe personnalisée `PouleMagique`

```csharp
PouleMagique p = new PouleMagique();
p.Danser();
```

---



# 3. Accéder aux membres d’un objet

### 🔹 Propriétés

Des **valeurs** appartenant à l’objet.

#### 🟦 Exemple : Classe `Button` (WinForms)
```csharp
Button b = new Button();
// Changer la propriété Text du bouton
b.Text = "Clique-moi";
// Changer la propriété Width du bouton
b.Width = 120;
```

### 🔹 Méthodes

Des **actions** que l’objet peut effectuer.

#### 🟦 Exemple 1 : Classe `Random`

```csharp
Random r = new Random();
// Générer un nombre aléatoire entre 1 et 9
int nombre = r.Next(1, 10);  // Méthode Next()
```

#### 🟦 Exemple 2 : Classe personnalisée `PouleMagique`

```csharp
PouleMagique p = new PouleMagique();
// Faire dancer la poule
p.Danser();
```
### 🔹 Constantes

Elles n’appartiennent pas à l’objet mais à la **classe**.

```csharp
int valeur = MaClasse.NomConstante;
```
#### 🟦 Exemple  : Classe personnalisée `PouleMagique`

```csharp
PouleMagique p = new PouleMagique();
// Récupérer la taille maximale d'une poule magique
int tailleMAx = PouleMagique.TAILLE_MAX;
```
### 🔹 Méthodes statiques
Une méthode statique est une méthode qui appartient à la classe elle-même, et non aux objets créés à partir de cette classe. On l'appelle via la **classe**.

```csharp
int max = Math.Max(4, 7);
```

---

# 4. Types valeur vs Types référence

### 🧱 Type valeur

Stocke directement la valeur (`int`, `bool`, `decimal`, etc.)

### 🪪 Type référence

Stocke l’**adresse** pointant vers un objet (`string`, `Button`, `Random`, classes…).

👉 Une variable non instanciée vaut **null**.

```csharp
// Déclarer une varibale de type Button
Button b; // La variable b est à null
// Instancier un objet de Type Button et l'affecter à la variable b
b = new Button(); // La variable b pointe maintenant vers un objet de type Button. Elle contient sa référence ne mémoire.

```
---

# 5. Variables locales vs variables membres

### 🔸 Variables locales

Déclarées dans une méthode.
Disparaissent à la fin du bloc.

### 🔸 Variables membres

Déclarées dans la classe.
Accessibles partout dans la classe.

---

# 6. Débogage : explorer les objets

* Placer un **point d’arrêt**
* Survoler les objets dans Visual Studio pour voir :

  * leurs propriétés (`b.Text`, `b.Width`, `p.Energie`…)
  * leurs méthodes
  * leur état interne
* Clic droit → **Atteindre la définition** pour voir la structure de la classe

---
  ##  Démonstration : Découvrir l'objet avec la Poule Magique

## 🪄🐔 **Message de la Poule Magique**

 « **Bonjour, humain curieux !**
Je suis **PouleMagique**, la créature la plus incroyable du poulailler interdimensionnel.

On m’a enfermée dans une petite classe C#…

   ⦿ Vous voyez mes **propriétés** ? Elles changent parfois sans prévenir.

   ⦿ Vous voyez mes **méthodes** ? Elles font des choses… disons, *surprenantes*.

Mais vous ne saurez jamais exactement quoi…

**à moins d’utiliser votre Débogueur !**


Votre mission est simple :
- 🔍 **M’observer**
- 🧪 **Tester mes actions**
- 📈 **Comprendre comment je réagis**
- et découvrir ce que cachent mes mystérieux comportements magiques.

Allez, assez parlé, humain !
Faites-moi **danser**, **manger**, **pondre** ou même **activer mon pouvoir spécial**…
et venez percer **mon secret** ! »

---
## 📎 Références
* [Instanciation objet](https://info.cegepmontpetit.ca/notions-csharp/documentation/instanciation-objet)



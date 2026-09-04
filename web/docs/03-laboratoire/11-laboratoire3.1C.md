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

## 🧩 Exercices

### 🔹 Exercice 1 – Somme

Créez une fonction qui prend **deux entiers** en paramètres et retourne leur **somme**.

#### 💬 Exemple d’utilisation en console :

```
Entrez un premier nombre : 5
Entrez un deuxième nombre : 7
Résultat : 12
```

---

### 🔹 Exercice 2 – Maximum entre deux puis trois valeurs

1. Créez une fonction qui retourne le **maximum entre deux entiers**.
 
2. Ensuite, utilisez **cette même fonction** pour obtenir le **maximum entre trois entiers**.\
   L’astuce est d’appeler la fonction **à l’intérieur d’un autre appel**. Par exemple :

   ```csharp
   int max3 = MaximumDeux(nombre1, MaximumDeux(nombre2, nombre3));
   ```

   Ici, on commence par trouver le maximum entre `nombre2` et `nombre3`, puis on compare ce résultat avec `nombre1`.

#### 💬 Exemple d’utilisation en console :

```
Entrez nombre Un : 12
Entrez nombre Deux : 7
Entrez nombre Trois : 4
Le plus grand est : 12
```

---

### 🔹 Exercice 3 – Surcharge de fonction

Dans le **même projet que l’exercice 2**, créez une **deuxième fonction** portant le **même nom**, mais prenant **trois paramètres**. Elle doit retourner le **maximum des trois**. Ce procédé s'appelle une **surcharge**.

#### 💬 Exemple d’utilisation en console :

```
Entrez nombre Un : 9
Entrez nombre Deux : 15
Entrez nombre Trois : 10
Le maximum (avec fonction surchargée) est : 15
```

---

### 🔹 Exercice 4 – Année bissextile (retour)

Modifiez la fonction de l’exercice précédent sur les années bissextiles pour qu’elle **retourne un booléen** au lieu d’afficher le résultat. La fonction retourne `true` si l’année est bissextile, sinon `false`.

#### 💬 Exemple d’utilisation en console :

```
Entrez une année : 2024
Bissextile : True
```

---

### 🔹 Exercice 5 – Nombre palindrome

Créez une fonction qui prend un **entier à 3 chiffres** et retourne un **booléen** indiquant si ce nombre est un **palindrome** (il se lit de la même façon à l’endroit et à l’envers).

#### 💡 Indices

- Utiliser la division entière `/` et le reste `%` pour extraire les chiffres.
- Comparer le chiffre des centaines et celui des unités.

#### 💬 Exemple d’utilisation en console :

```
Entrez un nombre à 3 chiffres : 121
Palindrome : True

Entrez un nombre à 3 chiffres : 245
Palindrome : False
```

---

### 🔹 Défi 6 – Triangle valide

Créez une fonction qui prend **trois côtés** (entiers) et retourne un booléen indiquant si ces trois côtés peuvent former un **triangle valide**.

📌 Règle : la somme de deux côtés doit toujours être **supérieure** au troisième.

#### 💬 Exemple d’utilisation en console :

```
Valeur des trois côtés : 3, 4, 5
Triangle valide : True

Valeur des trois côtés : 2, 2, 5
Triangle valide : False
```

---

### 🔹 Défi 7 – Devine la moyenne

Créez une fonction qui prend **deux notes** et retourne :

- `"A"` si la moyenne est ≥ 90
- `"B"` si elle est ≥ 80
- `"C"` si elle est ≥ 70
- `"Échec"` sinon

#### 💬 Exemple d’utilisation en console :

```
Entrez note 1 : 85
Entrez note 2 : 92
Résultat : B

Entrez note 1 : 60
Entrez note 2 : 70
Résultat : Échec
```

---

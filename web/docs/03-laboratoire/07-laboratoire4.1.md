---
title: Type valeur vs Type référence
---

# 🧪 Labo 4.1 – Type valeur vs Type référence

---
:::danger
Ce laboratoire doit être développé à l'aide du logiciel **Git**. Vous devrez **créer un nouveau dépôt dans GitHub** 
et **inviter votre professeur** en tant que collaborateur.

Voici le format du dépôt exigé: **H26-2P6-R07-MATRICULE**

Il devrait y avoir **un commit** pour **chaque** exercice.

:::

---

## 🟢 Exercice 1 – Type valeur

Considérez le code suivant :

```csharp
static void Main(string[] args)
{
    int x = 10;
    int y = 20;

    x = y;
    x++;
}
```
Complétez la trace ci-dessous. La première ligne vous est donnée à titre indicatif.

| Ligne exécutée      | Effet | Valeur de x | Valeur de y |
| ---------- | ----- | ----------- | ----------- |
| int x = 10 |  Création de la variable *x* et assignation de la **valeur** 10.      |       10      |      ---       |
| int y = 20 |       |             |             |
| x = y      |       |             |             |
| x++        |       |             |             |


**Question :** La valeur de `y` change-t-elle lorsque la ligne `x++` est exécutée ? Pourquoi ?


---

## 🟢 Exercice 2 – Type référence

On considère le code suivant :

```csharp
class Personne
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public Personne(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }
}
```

```csharp
static void Main(string[] args)
{
    Personne p1 = new Personne("Michael", 21);
    Personne p2 = new Personne("Jason", 34);

    p1 = p2;
    p2.Nom = "Jonathan";
    p2.Age++;
}
```

Complétez la trace :

| Ligne exécutée      | Effet | Champs de l'objet pointé par p1 | Champs de l'objet pointé par p2 |
| ---------- | ----- | ----------- | ----------- |
| Personne p1 = new Personne("Michael", 21); |  Création d'un objet de la classe Personne. La variable *p1* reçoit la **référence** vers cet objet.     |    Nom = "Michael" Age = 21      |      ---       |
| Personne p2 = new Personne("Jason", 34); |       |             |             |
| p1 = p2;      |       |             |             |
| p2.Nom = "Jonathan";        |       |             |             |
| p2.Age++;        |       |             |             |

**Question :** Combien d’objets sont **accessibles** après l'exécution de `p1 = p2` ?

---

## 🟢 Exercice 3 – Type référence

Considérez le code suivant :

```csharp
static void Main(string[] args)
{
    Personne p3 = new Personne("Nathan", 10);
    Personne p4 = new Personne("Nathan", 10);

    bool comparaison1 = (p3.Age == p4.Age);

    bool comparaison2 = (p3 == p4);

    p3 = p4;

    bool comparaison3 = (p3 == p4);
}
```
**Questions :**
1. Quelle valeur prendra *comparaison1* ? Expliquez pourquoi.
2. Quelle valeur prendra *comparaison2* ? Expliquez pourquoi.
3. Lorsque `==` est utilisé entre *p3* et *p4*, que sommes-nous en train de comparer  ? Des objets ? Les valeurs de champs ? Les références?
4. Quelle valeur prendra *comparaison3* ? Expliquez pourquoi.

---
## 🟢 Exercice 4 – Même objet ou copie ?

Considérez le code suivant :


```csharp
class Thermostat
{
    public int Temperature { get; set; }

    public Thermostat Copie()
    {
        Thermostat t = new Thermostat();
        t.Temperature = this.Temperature;
        return t;
    }
}

```

```csharp
static void Main(string[] args)
{
    Thermostat t1 = new Thermostat();
    t1.Temperature = 20;

    Thermostat t2 = t1.Copie();
    t2.Temperature = 30;

    Console.WriteLine(t1.Temperature);
}
```
**Question :** Quelle valeur sera affichée dans la console ? Expliquez votre réponse.

:::warning
Dans une classe, le mot-clé *this* désigne **l’objet courant**, c’est-à-dire l’instance sur laquelle la méthode est en train de s’exécuter.

Dans une méthode qui crée une copie de l’objet, on veut copier les valeurs de l’objet courant vers le nouvel objet.
Ainsi, `this.Temperature` correspond à la valeur de la température de l’objet qu’on est en train de copier.

:::

---

## 🟢 Exercice 5 – Passage par valeur

Considérez la méthode suivante et son appel dans le `Main`:

```csharp
static void Ajouter10(int n)
{
    n = n + 10;
}
```

```csharp
static void Main(string[] args)
{
    int valeur = 5;
    Ajouter10(valeur);
    Console.WriteLine(valeur);
}
```
**Questions :**
1. Quelle valeur sera affichée dans la console ? Expliquez pourquoi.
2. **Sans modifier la valeur de retour de la méthode**, modifiez le code pour que la valeur affichée dans la console soit égale à la valeur originale de `valeur` augmentée de 10.
Vous devrez ajuster la façon dont le paramètre est transmis à la méthode.


---
## 🟢 Exercice 6 – Passage par référence

Considérez la méthode suivante et son appel dans le `Main`:
```csharp

static void AjouterAListe(List<int> pListe, int valeur)
{
    pListe.Add(valeur);
}
```

```csharp
static void Main(string[] args)
{
    List<int> sublimeListe = new List<int>();

    AjouterAListe(sublimeListe, 10);

    Console.WriteLine(sublimeListe.Count);

}

```

**Questions :**
1. Quelle valeur sera affichée dans la console ?
2. Pourquoi la méthode `AjouterAListe()` n'a-t-elle pas besoin de retourner une liste ?






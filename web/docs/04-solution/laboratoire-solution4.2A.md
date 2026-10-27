---
title: "✅ Solutions — Laboratoire 4.2A"
---

# ✅ Solutions — Laboratoire 4.2A

[Retour au laboratoire 4.2A](/laboratoire/laboratoire4.2A)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

---


### 🔵 Exercice 1 : Affichez des valeurs.
Affichez les valeurs de 1 à 6 dans la console avec une boucle for.
```csharp
for (int i = 1; i <= 6; i++)
{
    Console.WriteLine(i);
}
```


### 🔵 Exercice 2 : Affichage sur une ligne.
Affichez sur UNE ligne, les valeurs de 10 à 20 (utiliser `Console.Write()`)
```csharp
for (int i = 10; i <= 20; i++)
{
    Console.Write(i + " "); // Écrit le nombre ET un espace
}
```

### 🔵 Exercice 3 : Décrémentation d'index.
Faites un compte à rebours par bonds de 2 en partant de 10 et incluant le 0.

```csharp
for (int i = 10; i >= 0; i-=2) // index commence à 10 et diminue de 2 à chaque itération.
{
    Console.WriteLine(i);
}
```


### 🔵 Exercice 4 : Incrémentation par bonds.
Affichez les nombres pairs de 0 à 20 inclusivement.
```csharp
for (int i = 0; i <= 20; i+=2)
{
    Console.WriteLine(i);
}
```

### 🔵 Exercice 5 : Conditionnel dans une boucle.
Affichez les nombres impairs de 10 à 25 inclusivement.
```csharp
for (int i = 10; i <= 25; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}
```

### 🔵 Exercice 6 : Conditionnel dans une boucle.
Affichez les nombres de 1 à 50 sur une ligne **sauf** les multiples de 3.
Vous devez vérifier si le nombre est divisible par 3 avec un modulo avant de l'afficher.
```csharp
for (int i = 1; i <= 50; i++)
{
    if (i % 3 != 0)
    {
        Console.Write(i + " ");
    }
}
```

### 🔵 Exercice 7 : Accumulation de valeurs.
Faites la somme des nombres de 1 à 50.
```csharp
int total = 0;
for (int i = 1; i <= 50; i++)
{
    total += i;
}
Console.WriteLine($"Total : {total}");
```

### 🔵 Exercice 8 : Accumulation d'entrées d'utilisateur.
Faites une boucle qui demande à l'utilisateur de rentrer 3 nombres un après l'autre.

Faites la moyenne des nombres entrés.
```csharp
 double total = 0;
 for (int i = 0; i < 3; i++)
 {
     Console.Write("Entrez un nombre : ");
     double chiffreSaisie = double.Parse(Console.ReadLine());
     total += chiffreSaisie;
 }
 double moyenne = total / 3;
 Console.WriteLine($"La moyenne est : {moyenne.ToString("F")}");
```



### 🔵 Exercice 9 : Boucles imbriquées
Utilisez deux boucles imbriquées pour faire un carré d'étoiles.


```csharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 5; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

```




### 🔵 Exercice 10 : Boucles imbriquées
On fait une pyramide d'étoiles. Avec deux boucles imbriquées, on veut utiliser l'index de la première boucle dans la deuxième boucle.

```csharp
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)  // La comparaison est différente de l'exercice précédent.
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

```


### 🟣 Exercice 11 — Compter certaines valeurs

```csharp
int positifs = 0, negatifs = 0, zeros = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Nombre {i} : ");
    int nombre = int.Parse(Console.ReadLine());
    if (nombre > 0) positifs++;
    else if (nombre < 0) negatifs++;
    else zeros++;
}
Console.WriteLine($"Positifs : {positifs}");
Console.WriteLine($"Négatifs : {negatifs}");
Console.WriteLine($"Zéros : {zeros}");
```

Chaque saisie appartient à une seule catégorie. La somme des trois compteurs doit être `10`. Les valeurs `12, -4, 0, 8, 1, -2, 3, 0, -1, 4` donnent `5`, `3`, `2`.

### 🟣 Exercice 12 — Trouver le plus grand nombre

```csharp
int maximum = 0;
for (int i = 1; i <= 10; i++)
{
    Console.Write($"Nombre {i} : ");
    int nombre = int.Parse(Console.ReadLine());
    if (i == 1 || nombre > maximum) maximum = nombre;
}
Console.WriteLine($"Plus grand nombre : {maximum}");
```

La première saisie remplace toujours la valeur initiale. Le résultat reste donc correct lorsque les dix nombres sont négatifs. Par exemple, `-12, -7, -25, -8, -9, -10, -11, -6, -20, -15` donne `-6`.

---
title: B - Trace d'exécution
---

# 🧪 Labo 2.2B – Trace d'exécution

### 🎯 Objectif

Réaliser une trace d'exécution afin de suivre l'évolution des variables et comprendre le comportement d'un programme.


### **Consigne générale :**

> Réaliser une trace d'exécution afin de suivre l'évolution des variables et de comprendre le déroulement d'un programme.


:::warning
Le tableau de trace d’exécution fourni est conçu pour être utilisé tout au long de la session. Il contient donc des éléments qui n’ont pas encore été vus, comme la **pile d’appels**, les **fonctions appelées**, les **valeurs retournées** et les **portées des variables**.

Pour les exercices de cette section, **utilisez uniquement les éléments qui ont été présentés en classe**. Les autres éléments seront introduits progressivement et seront utilisés dans de prochains exercices de trace plus complets.
:::

> 🖨️ [Imprimer le tableau de trace d’exécution pour pratiquer vos traces à la main.](https://info.cegepmontpetit.ca/420-SN1/assets/files/Traces_recto_verso-c4b18f20ba4ca97fa4a818fec269eae3.pdf) 


### Exercice 1

```csharp
1. int a = 10;
2. int b = 4;
3. int resultat = a + b;
4. a = resultat * 2;
5. b = a - 3;
```
### Exercice 2

```csharp
1. int a = 6;
2. int b = 3;
3. int c = 2;
4. int resultat = a + b * c;
5. Console.WriteLine(resultat);
6. resultat = (a + b) * c;
```
### Exercice 3

```csharp
1. int x = 10;
2. int y = 5;
3. x = y;
4. y = x + 2;
5. Console.WriteLine(x);
6. Console.WriteLine(y);
```
### Exercice 4 Code avec `if` simple

```csharp
1. int a = 11;
2. bool estPair = false;

4. if (a % 2 == 0)
5. {
6.     estPair = true;
7. }
```

### Exercice 5 Code avec `if else`

```csharp
1. int a = 10;
2. int b = 5;
3. int resultat;
4. if (a > b)
5. {
6.     resultat = a - b;
7. }
8. else
9. {
10.     resultat = b - a;
11. }
12. if (resultat >= 10)
13. {
14.     resultat = resultat * 2;
15. }
16. else
17. {
18.     resultat = resultat + 3;
19. }
20. Console.WriteLine(resultat);
```

### Exercice 6 Code avec `if` imbriquée

```csharp
1. int distance = 8;
2. bool paiementEffectue = true;
3. if (distance <= 10)
4. {
5.     if (paiementEffectue)
6.     {
7.         Console.WriteLine("Livraison acceptée");
8.     }
9.     else
10.    {
11.        Console.WriteLine("Paiement requis");
12.    }
13. }
14. else
15. {
16.     Console.WriteLine("Distance trop grande");
17. }
```

### Exercice 7

```csharp
1. int score = 0;
2. int age = 22;
3. bool aUneExperience = true;
4. bool aUnDiplome = false;
5.
6. if (age >= 18)
7. {
8.     score = score + 10;
9.
10.    if (estAvecExperience)
11.    {
12.        score = score + 20;
13.    }
14.    else
15.    {
16.        score = score + 5;
17.    }
18.
19.    if (aUnDiplome)
20.    {
21.        score = score + 30;
22.    }
23. }
24. Console.WriteLine(score);
```
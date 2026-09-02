---
title: B - Trace d'exécution
---

# 🧪 Labo 2.2B – Trace d'exécution

### 🎯 Objectif


---
```csharp
1. int a = 10;
2. int b = 4;
3. int resultat = a + b;
4. a = resultat * 2;
5. b = a - 3;
```

```csharp
1. int a = 6;
2. int b = 3;
3. int c = 2;
4. int resultat = a + b * c;
5. Console.WriteLine(resultat);
6. resultat = (a + b) * c;
```

```csharp
1. int x = 10;
2. int y = 5;
3. x = y;
4. y = x + 2;
5. Console.WriteLine(x);
6. Console.WriteLine(y);
```
## Trace d'exécution d'un code avec `if`

```csharp
1. int a = 11;
2. bool estPair = false;

4. if (a % 2 == 0)
5. {
6.     estPair = true;
7. }
```


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
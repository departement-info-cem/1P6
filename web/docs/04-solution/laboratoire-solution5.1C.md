---
title: "✅ Solutions — Laboratoire 5.1C"
---

# ✅ Solutions — Laboratoire 5.1C

[Retour au laboratoire 5.1C](/laboratoire/laboratoire5.1C)

Chaque exercice est indépendant. Les instructions seules vont dans `Main`; les méthodes vont dans la classe `Program`, à l’extérieur de `Main`. Si un bloc contient déjà `static void Main`, remplacez votre méthode `Main` existante par celle du bloc et placez les autres méthodes à côté. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`. Les exemples décimaux supposent un poste configuré en français (Canada).

## 🟣 Exercice 1
```csharp
static void Main(string[] args)
{
    int[] tab = { 10, 20, 30, 40, 50 };

    int somme = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        somme += tab[i];
    }
    double moyenne = (double)somme / tab.Length;

    Console.WriteLine("Somme : " + somme);
    Console.WriteLine("Moyenne : " + moyenne);
}
```

---

## 🟣 Exercice 2
```csharp
static void Main(string[] args)
{
    int[] tab = { 45, 12, 99, 18, 62 };

    int min = tab[0];
    int max = tab[0];

    for (int i = 1; i < tab.Length; i++)
    {
        if (tab[i] < min) min = tab[i];
        if (tab[i] > max) max = tab[i];
    }

    Console.WriteLine("Min : " + min);
    Console.WriteLine("Max : " + max);
}
```

---

## 🟣 Exercice 3
```csharp
static void Main(string[] args)
{
    int[] tab = { 2, 7, 4, 9, 12, 5 };

    int nbPairs = 0;
    int nbImpairs = 0;

    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] % 2 == 0)
            nbPairs++;
        else
            nbImpairs++;
    }

    Console.WriteLine("Pairs : " + nbPairs);
    Console.WriteLine("Impairs : " + nbImpairs);
}
```

---

## 🟣 Exercice 4

Le retour reste un `int[]`. Comme dans l'énoncé, chaque élément de `source` doit être compris entre `-1073741824` et `1073741823` inclusivement afin que son double tienne dans un `int`; aucune validation supplémentaire n'est demandée.

```csharp
static void Main(string[] args)
{
    int[] tab = { 1, 2, 3, 4 };

    int[] resultat = Doubler(tab);

    Console.WriteLine("Tableau d'origine : " + string.Join(" ", tab));
    Console.WriteLine("Tableau doublé : " + string.Join(" ", resultat));
}

static int[] Doubler(int[] source)
{
    int[] nouveau = new int[source.Length];
    for (int i = 0; i < source.Length; i++)
    {
        nouveau[i] = source[i] * 2;
    }
    return nouveau;
}
```

Avec `{-1073741824, 1073741823}`, le tableau retourné est `{-2147483648, 2147483646}`. `1500000000` est hors des préconditions.

---

## 🟣 Exercice 5
```csharp
static void Main(string[] args)
{
    int[] tab = { 10, 20, 30, 40, 50 };

    int[] inversé = Inverser(tab);

    Console.WriteLine("Avant : " + string.Join(" ", tab));
    Console.WriteLine("Après : " + string.Join(" ", inversé));
}

static int[] Inverser(int[] source)
{
    int[] resultat = new int[source.Length];
    for (int i = 0; i < source.Length; i++)
    {
        resultat[i] = source[source.Length - 1 - i];
    }
    return resultat;
}
```

---

## 🟣 Exercice 6

Le tableau reçu n'est pas vide. Un `long`, entier de plus grande capacité, sert au cumul; la moyenne est calculée en `double` depuis ce cumul. Les extrema restent des `int` et la méthode retourne toujours `void`.

```csharp
static void Main(string[] args)
{
    int[] tab = { 10, 20, 30, 40, 10, 40 };

    AnalyserTableau(tab);
}

static void AnalyserTableau(int[] t)
{
    long somme = 0;
    int min = t[0];
    int max = t[0];

    for (int i = 0; i < t.Length; i++)
    {
        somme += t[i];
        if (t[i] < min) min = t[i];
        if (t[i] > max) max = t[i];
    }

    double moyenne = (double)somme / t.Length;

    Console.WriteLine("Somme : " + somme);
    Console.WriteLine("Moyenne : " + moyenne);
    Console.WriteLine("Min : " + min);
    Console.WriteLine("Max : " + max);
}
```

Le tableau d'origine donne toujours `150`, `25`, `10` et `40`. Avec `{1500000000, 1500000000}`, la somme vaut `3000000000`, la moyenne, le minimum et le maximum valent `1500000000`.

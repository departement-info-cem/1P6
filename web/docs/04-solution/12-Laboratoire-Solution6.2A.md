# ✅ Solution – Labo 4.2C

## 🟢 Exercice 1
```csharp
static void Main(string[] args)
{
    string[,] artistesChansons = {
        {"Mr. Brightside","Somebody Told Me","When You Were Young"},
        {"Bohemian Rhapsody","Don't Stop Me Now", "Under Pressure" },
        {"Exille","Rosyln","Skinny Love"},
        {"L'amérique pleure","Les étoiles filantes", "Sur mon épaule" }
    };

    Console.WriteLine("1. The Killers");
    Console.WriteLine("2. Queen");
    Console.WriteLine("3. Bon Iver");
    Console.WriteLine("4. Les Cowboys Fringants");
    Console.Write("choix: ");
    int saisie = int.Parse(Console.ReadLine());

    Console.WriteLine($"{artistesChansons[saisie - 1,0]}, {artistesChansons[saisie - 1, 1]}, {artistesChansons[saisie - 1, 2]}");
}
```

---

## 🟢 Exercice 2
```csharp
static void Main(string[] args)
{
    int[,] notesEleves = new int[3,5];
    string[,] PrenomEtNomEleves = new string[3, 2];
    bool[,] reussiteEleves = new bool[3,5];

    Console.WriteLine(notesEleves.GetLength(1));
    Console.WriteLine(PrenomEtNomEleves.Length);
    Console.WriteLine(reussiteEleves[1,0]);
}
```

---

## 🟢 Exercice 3
```csharp
static void Main(string[] args)
{
    int[,] notesEtudiants = { { 99,92},{ 76, 68 }, { 55,65} };

    Console.WriteLine($"Notes: {notesEtudiants[notesEtudiants.GetLength(0)-1,0]} et {notesEtudiants[notesEtudiants.GetLength(0)-1, 1]}");
    notesEtudiants[notesEtudiants.GetLength(0) - 1, 0] = 60;
    Console.WriteLine($"Notes: {notesEtudiants[notesEtudiants.GetLength(0)-1,0]} et {notesEtudiants[notesEtudiants.GetLength(0)-1, 1]}");
}
```

## 🟢 Exercice 4
```csharp
static void Main(string[] args)
{
    string[,] citations =
    {
        // Albert Einstein
        { "L’imagination est plus importante que le savoir.",
          "La vie, c’est comme une bicyclette, il faut avancer pour ne pas perdre l’équilibre." },

        // Mahatma Gandhi
        { "Sois le changement que tu veux voir dans le monde.",
          "La force ne vient pas des capacités physiques, mais d’une volonté indomptable." },

        // Steve Jobs
        { "Votre temps est limité, ne le gaspillez pas à vivre la vie de quelqu’un d’autre.",
          "La créativité, c’est simplement relier les choses entre elles." },

        // Marie Curie
        { "Dans la vie, rien n’est à craindre, tout est à comprendre.",
          "Soyez moins curieux des gens et plus curieux des idées." }
    };

    for (int i = 0; i < citations.GetLength(0); i++)
    {
        for (int j = 0; j < citations.GetLength(1); j++)
        {
            Console.WriteLine($"Citation #{j} : {citations[i, j]}");
        }
        Console.WriteLine();
    }
}
```

## 🟢 Exercice 5
```csharp
static void Main(string[] args)
{
    string[] personnality = {"Albert Einstein","Mahatma Gandhi","Steve Jobs","Marie Curie"};
    string[,] citations =
    {
        { "L’imagination est plus importante que le savoir.",
          "La vie, c’est comme une bicyclette, il faut avancer pour ne pas perdre l’équilibre." },
        { "Sois le changement que tu veux voir dans le monde.",
          "La force ne vient pas des capacités physiques, mais d’une volonté indomptable." },
        { "Votre temps est limité, ne le gaspillez pas à vivre la vie de quelqu’un d’autre.",
          "La créativité, c’est simplement relier les choses entre elles." },
        { "Dans la vie, rien n’est à craindre, tout est à comprendre.",
          "Soyez moins curieux des gens et plus curieux des idées." }
    };

    for (int i = 0; i < citations.GetLength(0); i++)
    {
        Console.WriteLine(personnality[i]);
        for (int j = 0; j < citations.GetLength(1); j++)
        {
            Console.WriteLine($"Citation #{j} : {citations[i, j]}");
        }
        Console.WriteLine();
    }
}
```

---

## 🟢 Exercice 6
```csharp
static int meilleurJoueur(int[,] j)
{
    int meilleurPointage = 0;
    int indiceDuMeilleurJoueur = 0;

    for (int i = 0; i < j.GetLength(0); i++)
    {
        if(meilleurPointage <= j[i,4])
        {
            meilleurPointage = j[i, 4];
            indiceDuMeilleurJoueur = i;
        }
    }
    return indiceDuMeilleurJoueur;
}

static void Main(string[] args)
{
    int[,] joueurs =
    {
        { 120, 145, 132, 160, 178 },
        { 200, 185, 210, 195, 220 },
        { 98, 105, 115, 130, 125 },
        { 250, 260, 240, 270, 280 },
        { 150, 165, 172, 158, 180 },
        { 75, 90, 85, 100, 95 }
    };

    Console.WriteLine(meilleurJoueur(joueurs)+1);
}
```

---

## 🟢 Exercice 7
```csharp
static double[] CalculerMoyenne(int[,]e)
{
    double[] m = new double[e.GetLength(0)];

    for (int i = 0; i < e.GetLength(0); i++)
    {
        int avg = e[i,0];

        for (int j = 1; j < e.GetLength(1); j++)
        {
            avg += e[i, j];
        }

        m[i] = avg / e.GetLength(1);
    }

    return m;
}
static void Main(string[] args)
{
    int[,] employes =
    {
        { 1200, 3600, 600, 1000, 500, 6000, 1200, 500, 10000, 900, 8500, 100 },
        { 2500, 2600, 2550, 2700, 2650, 2800, 2750, 2900, 3000, 3100, 3050, 3200 },
        { 1500, 1800, 2000, 1700, 1600, 1900, 2100, 2500, 2300, 2200, 2000, 2400 },
        { 800, 1200, 950, 1100, 1000, 900, 1050, 980, 1020, 1150, 1080, 1110 }
    };

    double[] moyenneEmploye = CalculerMoyenne(employes);

    for (int i = 0; i < moyenneEmploye.Length; i++)
    {
        Console.WriteLine(moyenneEmploye[i]);
        
    }
}
```

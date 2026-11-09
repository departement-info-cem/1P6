### Question 1 (4 pts) : Trace d'exécution

Complétez la trace d'exécution du code suivant, une ligne du tableau par instruction exécutée. Les trois premières lignes sont déjà remplies. Écrivez le texte affiché dans la dernière colonne.

```csharp showLineNumbers
int[] prix = { 7, 5, 4 };
int total = 0;
int i = 0;
while (total < 10)
{
    total = total + prix[i];
    i++;
}
Console.WriteLine($"{i} articles : {total} $");
```

| Instruction exécutée | i | total | `total<10` | Affichage |
| :---: | :---: | :---: | :---: | :---: |
| 2 | — | 0 | TRUE | — |
| 3 | 0 | 0 | TRUE | — |
| 4 | 0 | 0 | TRUE | — |
| 6 | | | | |
| 7 | | | | |
|  | | | | |
|  | | | | |
|  | | | | |
|  | | | | |
|  | | | | |

### Question 2 (4 pts) : Tableaux 2D

Soit la déclaration suivante. Indiquez la valeur de chaque expression.

```csharp
int[,] mesures = { { 4, 9, 1 },
                   { 7, 2, 6 } };
```

| Expression | Valeur |
| --- | :---: |
| `mesures[0, 1]` | |
| `mesures[1, 2]` | |
| `mesures.GetLength(1)` | |
| `mesures[1, 0] + mesures[0, 2]` | |

### Question 3 (2 pts) : Boucle while

Qu'arrive-t-il lorsqu'on exécute ce code ? Quelle ligne faut-il ajouter pour afficher 1, 2, 3 et 4, puis arrêter ?

```csharp showLineNumbers
int n = 1;
while (n < 5)
{
    Console.WriteLine(n);
}
```

Ce qui arrive :

Ligne à ajouter et où faut-il ajouter cette ligne :

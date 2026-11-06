---
description: Temps en classe pour faire l'examen formatif
---

# Examen Formatif 2

L'examen formatif a le même format que l'examen 2. Il porte sur la matière vue depuis le cours 5.1 : les tableaux 1D et 2D, le débogage et la trace d'exécution, le `switch`, les boucles `while` et `do... while`, et `TryParse`.

| Partie | Contenu | Pointage | Temps suggéré |
| --- | --- | ---: | ---: |
| Papier | Trace d'exécution et questions de compréhension, **sans documentation** | 10 pts | 20 min |
| Question 1 | Switch et boucle | 10 pts | 20 min |
| Question 2 | Tableau 1D | 10 pts | 20 min |
| Question 3 | Tableau 2D | 10 pts | 25 min |

## Partie papier
Votre enseignant vous remet la partie papier en classe. Vous la remettez avant de commencer la partie sur ordinateur.

📄 [Télécharger la partie papier (Word)](./fichiers/420-1P6-A26-Formatif2-Partie-papier.docx)

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

| Instruction exécutée | i | total | Affichage |
| :---: | :---: | :---: | :---: |
| 2 | — | 0 | — |
| 3 | 0 | 0 | — |
| 4 | 0 | 0 | — |
| 6 | | | |
| 7 | | | |
| 4 | | | |
| 6 | | | |
| 7 | | | |
| 4 | | | |
| 9 | | | |

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

```csharp
int n = 1;
while (n < 5)
{
    Console.WriteLine(n);
}
```

## Partie sur ordinateur

### Télécharger le projet de départ
Disponible ici 👇
<GithubDownload
  repo="1P6"
  folder="code/examens/formatif_2_1p6"
  label="📁 Examen Formatif 2" 
/>

Vous devez télécharger le .zip, puis l'extraire sur votre poste et **ouvrir le fichier `formatif_2_1p6.sln`** dans Visual Studio.

### Extraits du projet de départ
#### 1. Switch et boucle
<GHCode 
  repo="1P6" 
  filePath="code/examens/formatif_2_1p6/Q1_switch_while/Program.cs" 
  language="csharp" 
  startLine="8"
  endLine="52"  
  branch="main"
  trimLineStart="true"
  showLineNumber="true"
/>

#### 2. Tableau 1D
<GHCode 
  repo="1P6" 
  filePath="code/examens/formatif_2_1p6/Q2_tableau_1D/Program.cs" 
  language="csharp" 
  startLine="8"
  endLine="38"
  branch="main"
  trimLineStart="true"
  showLineNumber="true"
/>

#### 3. Tableau 2D
<GHCode 
  repo="1P6" 
  filePath="code/examens/formatif_2_1p6/Q3_tableau_2D/Program.cs" 
  language="csharp" 
  startLine="8"
  endLine="51"
  branch="main"
  trimLineStart="true"
  showLineNumber="true"
/>

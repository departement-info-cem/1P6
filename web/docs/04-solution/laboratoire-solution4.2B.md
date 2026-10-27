---
title: "✅ Solutions — Laboratoire 4.2B"
---

# ✅ Solutions — Laboratoire 4.2B

[Retour au laboratoire 4.2B](/laboratoire/laboratoire4.2B)

L’exercice 1 est indépendant. Les exercices 2-A à 2-D sont des versions successives du **même projet** : chaque bloc présente la version complète à cette étape. Remplacez la version précédente de `Main` et des méthodes montrées, sans conserver de définitions en double. Les méthodes se placent dans la classe `Program`, à l’extérieur de `Main`. Les petits blocs d’appels de test se placent uniquement dans `Main`, à l’endroit indiqué. Si une classe `Program` complète est fournie, remplacez le contenu de `Program.cs`.

---


### 🔵 Exercice 1 : Boucle dans une fonction.
Faire une fonction qui prend un int en paramètre et qui imprime la table de multiplication correspondante dans la console.
```csharp
static void Main(string[] args)
{
    // Tester la fonction AfficherTableMultiplication avec 7
    AfficherTableMultiplication(7);
}
static void AfficherTableMultiplication(int nombre)
{
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine($"{nombre} x {i} = {(long)nombre * i}");
    }
}
```

Pour tester la fonction avec les trois nombres demandés, remplacez l’appel dans `Main` par ces trois appels; conservez une seule définition de `AfficherTableMultiplication` :

```csharp
AfficherTableMultiplication(3);
AfficherTableMultiplication(7);
AfficherTableMultiplication(12);
```

Chaque appel affiche les douze produits de sa table : de `3 x 1 = 3` à `3 x 12 = 36`, de `7 x 1 = 7` à `7 x 12 = 84`, puis de `12 x 1 = 12` à `12 x 12 = 144`.

Le paramètre reste un `int`. La conversion `(long)nombre` a lieu avant la multiplication : le produit est calculé dans un `long`, qui peut représenter tous les produits d’un `int` par les multiplicateurs de 1 à 12. Pour l’essai avec une grande valeur, remplacez les appels de `Main` par `AfficherTableMultiplication(300000000);`. Les lignes des multiplicateurs `8` et `12` affichent `300000000 x 8 = 2400000000` et `300000000 x 12 = 3600000000`.


### 🔵 Exercice 2 : Fonction dans une boucle.
#### 🔵 Exercice 2-A : Fonction ComposerLigneÉtoile().
Faire une fonction qui prend un int en paramètre et qui retourne un string avec un nombre d'étoiles * correspondant.
```csharp
static void Main(string[] args)
{
    // Tester la fonction avec 3
    Console.WriteLine(ComposerLigneÉtoile(3));
    // Tester la fonction avec 5
    Console.WriteLine(ComposerLigneÉtoile(5));
    // Tester la fonction avec 9
    Console.WriteLine(ComposerLigneÉtoile(9));


}
static string ComposerLigneÉtoile(int pNbrÉtoiles)
{
    string ligne = "";
    for (int i = 0; i < pNbrÉtoiles; i++)
    {
        ligne += "*";
    }
    return ligne;
}
```

Les trois appels affichent respectivement :

```text
***
*****
*********
```

#### 🔵 Exercice 2-B : Appel de fonction dans une boucle.
Faire un appel de la fonction ComposerLigneÉtoile() dans une boucle pour faire une pyramide de taille 5.
```csharp
static void Main(string[] args)
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine(ComposerLigneÉtoile(i));
    }
}
static string ComposerLigneÉtoile(int pNbrÉtoiles)
{
    string ligne = "";
    for (int i = 0; i < pNbrÉtoiles; i++)
    {
        ligne += "*";
    }
    return ligne;
}
```

#### 🔵 Exercice 2-C : Appel de fonction dans une boucle.
Créer une fonction ImprimerPyramide() qui prend la taille de la pyramide en paramètre. Le compteur commence à `0` et reste strictement inférieur à la taille; chaque ligne contient `i + 1` étoiles. Ce parcours affiche les lignes de 1 à la taille sans faire dépasser au compteur la capacité d’un `int`.
```csharp
 static void Main(string[] args)
 {
     ImprimerPyramide(3);
     ImprimerPyramide(5);
 }
 static void ImprimerPyramide(int pTaillePyramide)
 {
     for (int i = 0; i < pTaillePyramide; i++)
     {
         Console.WriteLine(ComposerLigneÉtoile(i + 1));
     }
 }
 static string ComposerLigneÉtoile(int pNbrÉtoiles)
 {
     string ligne = "";
     for (int i = 0; i < pNbrÉtoiles; i++)
     {
         ligne += "*";
     }
     return ligne;
 }
```
#### 🔵 Exercice 2-D : Appel de fonction dans une boucle.
Créer une fonction ImprimerPyramideInverser() qui prend la taille de la pyramide en paramètre.

Le bloc complet ci-dessous montre l’intégration finale. Pour effectuer d’abord le test demandé avec une taille de `4`, remplacez temporairement les deux appels de `Main` par cet appel; conservez les trois méthodes :

```csharp
ImprimerPyramideInverser(4);
```

Ce test affiche :

```text
****
***
**
*
```

Pour l’intégration, remettez ensuite les appels `ImprimerPyramide(3)` et `ImprimerPyramideInverser(2)` dans `Main`, comme dans cette version :

```csharp
static void Main(string[] args)
{
    // Imprimer une pyramide de taille 3
    ImprimerPyramide(3);
    // Imprimer une pyramide inversée de taille 2
    ImprimerPyramideInverser(2);

}
static void ImprimerPyramideInverser(int pTaillePyramide)
{
    for (int i = pTaillePyramide; i >= 1; i--)
    {
        Console.WriteLine(ComposerLigneÉtoile(i));
    }
}
static void ImprimerPyramide(int pTaillePyramide)
{
    for (int i = 0; i < pTaillePyramide; i++)
    {
        Console.WriteLine(ComposerLigneÉtoile(i + 1));
    }
}
static string ComposerLigneÉtoile(int pNbrÉtoiles)
{
    string ligne = "";
    for (int i = 0; i < pNbrÉtoiles; i++)
    {
        ligne += "*";
    }
    return ligne;
}
```

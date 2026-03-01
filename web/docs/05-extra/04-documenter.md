---
title: Documenter son code
---

# Bien documenter son code

## 🎯 Objectif
1. Améliorer la lisibilité et la compréhension du code
2. Faciliter la maintenance
3. Faciliter la collaboration
4. Réduire les erreurs


## Ajouter des commentaires
Documenter son code est un processus simple mais essentiel. Il facilite grandement la compréhension et permet d'éviter des erreurs d'ambiguïté.

Considérons le constructeur suivant : il est facile de deviner l'intention des paramètres. Par contre, si l'on regarde la classe, que devrait-elle contenir ?
```csharp
public Personnage(string nom, int age, char classe)
{
    //...
}
```

Comparons maintenant avec l'ajout de commentaires. Nous comprenons mieux ce que nous devons fournir dans le paramètre `classe`.

```csharp
/// <summary>
/// Constructeur nous permettant de créer un personnage.
/// </summary>
/// <param name="nom">Le nom du personnage</param>
/// <param name="age">L'âge du personnage</param>
/// <param name="classe">La classe du personnage : "G" pour un guerrier, "M" pour un mage ou 
/// "V" pour un voleur.</param>
public Personnage(string nom, int age, char classe)
{
    // ...
}
```

## Où commenter?
- Les constantes
- Les champs
- Les propriétés
- Les constructeurs
- Les méthodes
- Vos classes

## Comment commenter?
Lorsque votre méthode est bien écrite et que vous êtes certain de sa structure, il est temps de commenter.

Très simplement, placez-vous sur la ligne juste au-dessus de votre méthode et tapez trois barres obliques `///`. Visual Studio va reconnaître votre code et proposera un bloc de commentaires à compléter.

![](@site/static/img/extra/commentaire.gif)

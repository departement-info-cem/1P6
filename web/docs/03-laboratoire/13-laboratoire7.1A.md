---
title: Modelisation
---
# 🧪 Labo 7.1A – Modelisation

---

## 🎯 Objectifs 

* identifier les **classes d’un système** ;
* analyser et modéliser les **relations entre les classes**;
* déterminer les **cardinalités des relations** ;
* élaborer un **diagramme de classes** représentant le modèle ;
* **implémenter** le diagramme de classes en **C#**.
---

# 🟢 Exercice 1 : Situations de modélisation : diagrammes de classes 
Dans cet exercice, plusieurs énoncés issus de différents domaines d’application vous sont proposés. Pour chacun d’eux, vous devez 
produire le diagramme de classes correspondant.

Pour construire le diagramme de classes, procédez selon les étapes suivantes :
1. Identifier les **classes**
1. Indiquer les **relations** entre les classes.
2. Préciser les **cardinalités** de chaque relation.
3. Proposer dans quelle direction la relation doit-elle être navigable ?

**Indices** : Pour répondre aux questions, réfléchissez aux questions suivantes :
* Quels sont les objets ou entités importantes mentionnés dans l'énoncé et qui représentent des concepts du domaine ?
* Combien d’objets de la classe B peuvent être associés à un objet de la classe A ?
* Un objet de la classe B peut-il être associé à plusieurs objets de la classe A ?

### Énoncé 1
* Un **client** peut posséder **plusieurs comptes bancaires**.
* Chaque **compte bancaire** appartient à **un seul client**.
---
### Énoncé 2
* Un **professeur** est affecté à un seul **département**.
* Un **département** contient **plusieurs professeurs**.
---
### Énoncé 3
* Un animal peut être adopté par **une seule personne**.
* Un animal peut aussi **ne pas être adopté**.
* Une personne peut adopter **plusieurs animaux**.
---
### Énoncé 4
* une personne peut avoir **zéro ou un permis**
* chaque permis de conduire appartient à **une seule personne**
---
### Énoncé 5
* Une **commande** contient **plusieurs produits**.
* Un **produit** peut apparaître dans **plusieurs commandes**.
---
### Énoncé 6
* Une **maison** est composée de **plusieurs pièces**.
* Chaque **pièce** appartient à **une seule maison**.
---

# 🟢 Exercice 2 : Implémentation d'un diagramme de classes 
Dans ce deuxième exercice, un diagramme de classes vous sera fourni.
À partir de ce diagramme, vous devrez réaliser son implémentation en C#.
* Implémenter les relations entre les classes ;
* Respecter les cardinalités indiquées dans le diagramme ;
* Ajouter les constructeurs appropriés.
* Ajouter les méthodes nécessaires pour maintenir la cohérence des relations entre les classes

![diagramme de classes simplifié](@site/static/img/R13/exercice2-compte.png)

**Implémentation des deux classes en C# à compléter**

```csharp
public class Client
{
    public string Nom { get; private set; }
    public string Prenom { get; private set; }     
}
```
```csharp
public class Compte
{
    public string Numero { get; private set; }
    public double Solde { get; private set; }       
}
```
---

# 🟢 Exercice 3 : Implémentation d'un diagrammes de classes 
Dans ce deuxième exercice, un diagramme de classes vous sera fourni.
À partir de ce diagramme, vous devrez réaliser son implémentation en C#.
* Implémenter les relations entre les classes ;
* Respecter les cardinalités indiquées dans le diagramme ;
* Ajouter les constructeurs appropriés.
* Ajouter les méthodes nécessaires pour maintenir la cohérence des relations entre les classes

![diagramme de classes simplifié](@site/static/img/R13/exercice3-cours-stage.png)

**Implémentation des deux classes en C# à compléter**

```csharp
public class Cours
{
    public string Code { get; private set; }
    public string Titre { get; private set; }     
}
```
```csharp
public class Etudiant
{
    public string Matricule { get; private set; }
    public string Nom { get; private set; }     
    public string Prenom { get; private set; }    
}
```
```csharp
public class Stage
{
    public string Entreprise { get; private set; }
    public int Duree { get; private set; }        
}
```



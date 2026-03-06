---
title: ✅ Solutions – Laboratoire 4.1
---

## 🟢 Exercice 1 – Type valeur

| Ligne exécutée | Effet                                                          | Valeur de x | Valeur de y |
| -------------- | -------------------------------------------------------------- | ----------- | ----------- |
| int x = 10     | Création de la variable *x* et assignation de la **valeur** 10 | 10          | —           |
| int y = 20     | Création de la variable *y* et assignation de la valeur 20     | 10          | 20          |
| x = y          | Copie de la valeur de *y* dans *x*                             | 20          | 20          |
| x++            | Incrémentation de *x*                                          | 21          | 20          |


**Réponse :**
Non. La valeur de `y` ne change pas.
``int`` est un type valeur : l’instruction ``x = y`` copie la valeur. Les variables occupent donc des emplacements mémoire distincts.


---

## 🟢 Exercice 2 – Type référence

| Ligne exécutée                             | Effet                                    | Champs de l'objet pointé par p1 | Champs de l'objet pointé par p2 |
| ------------------------------------------ | ---------------------------------------- | ------------------------------- | ------------------------------- |
| Personne p1 = new Personne("Michael", 21); | Création d'un objet de la classe Personne. La variable *p1* reçoit la référence vers cet objet. | Nom="Michael" Age=21         | —                               |
| Personne p2 = new Personne("Jason", 34);   | Création d'un second objet. La référence vers cet objet est assignée à *p2*.                    | Nom="Michael" Age=21         | Nom="Jason" Age=34           |
| p1 = p2;                                   | Copie de la **référence** de *p2* dans *p1*.                 | Nom="Jason" Age=34           | Nom="Jason" Age=34           |
| p2.Nom = "Jonathan";                       | Modification de l’objet partagé.          | Nom="Jonathan" Age=34        | Nom="Jonathan" Age=34        |
| p2.Age++;                                  | Incrémentation de *Age*.                          | Nom="Jonathan" Age=35        | Nom="Jonathan" Age=35        |


**Réponse :** Un seul objet est accessible après ``p1 = p2``.
L’objet initial de *p1* n’a plus de référence, il sera éventuellement détruit par le *garbage collector*.

---

## 🟢 Exercice 3 – Type référence

**Réponses :**
1. True. On compare deux ``int`` qui possèdent les mêmes valeurs.
2. False. Bien que les deux objets aient des champs de même valeur, *p3* et *p4* pointent vers deux instances différentes. Donc deux références différentes !
3. ``==`` compare les références des objets.
4. True. Après ``p3 = p4``, les deux variables pointent vers le même objet. Elles possèdent donc la même référence.

---
## 🟢 Exercice 4 – Même objet ou copie ?


**Réponse :** 
Valeur affichée : 20

La méthode *Copie()* crée un nouvel objet et copie les champs. *t1* et *t2* pointent vers deux objets distincts. Modifier *t2* n’affecte pas *t1*.

---

## 🟢 Exercice 5 – Passage par valeur


**Réponses :**
1. Valeur affichée : 5. ``int`` est un type valeur, donc une copie est passée à la méthode.
2. 

```csharp

static void Ajouter10(int original, out int resultat)
{
    resultat = original + 10;
}

```

---
## 🟢 Exercice 6 – Passage par référence

**Réponses :**
1. Valeur affichée : 1 . ``List<int>`` est un type référence. La méthode reçoit la référence de l'objet ``List<int>``. C'est donc le même objet qui est modifié.
2. Pas besoin de retourner la liste car l’objet est modifié directement via la référence partagée.

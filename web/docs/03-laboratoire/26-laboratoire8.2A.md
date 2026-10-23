---
title: A - Questions de compréhension - Switch... case, While et Do... while – Simple
---

# 🧪 Labo 8.2A – Questions de compréhension -Switch... case, While et Do... while – Simple

---

## 🟢 Je comprends

> 🧠 **Je comprends :** je peux lire un programme simple et déterminer s'il répond à l'objectif demandé.

> ⚠️ Ces questions doivent être réalisés **sans utiliser l'ordinateur**.
N'ouvrez pas Visual Studio pour écrire et exécutez le code. L'objectif est de développer votre capacité à comprendre et à analyser le code par vous-même.

Pour chaque question, **lisez l'objectif et le code fourni**.

**Le code est-il correct?**
Si le code est incorrect, **identifiez le problème**.

### Question 1 — Deux structures, un même résultat ?

On souhaite afficher le niveau d'un utilisateur à partir de la valeur de la variable `niveau`.

<div className="row">
  <div className="col col--6">

**Solution A — `if / else if`**

    ```csharp
    int niveau = 2;

    if (niveau == 1)
    {
        Console.WriteLine("Débutant");
    }
    else if (niveau == 2)
    {
        Console.WriteLine("Intermédiaire");
    }
    else if (niveau == 3)
    {
        Console.WriteLine("Avancé");
    }
    else
    {
        Console.WriteLine("Invalide");
    }
    ```

  </div>
  <div className="col col--6">

**Solution B — `switch`**

    ```csharp
    int niveau = 2;

    switch (niveau)
    {
        case 1:
            Console.WriteLine("Débutant");
            break;
        case 2:
            Console.WriteLine("Intermédiaire");
            break;
        case 3:
            Console.WriteLine("Avancé");
            break;
        default:
            Console.WriteLine("Invalide");
            break;
    }
    ```

  </div>
</div>


**Les deux solutions sont-elles équivalentes ? Justifiez votre réponse.**

<details>
<summary>💡 Vérifier ma réponse</summary>

**Oui.**

Les deux solutions affichent le même message pour les valeurs 1, 2 et 3. Pour toute autre valeur, elles affichent « Code invalide ».

La structure `if...else if...else` et la structure `switch` permettent ici d'obtenir le même résultat.

</details>

---



### Question 2 — Deux structures, un même résultat ?

On souhaite déterminer si un jour correspond à un jour de semaine ou à une journée de fin de semaine.

<div className="row">
  <div className="col col--6">

**Solution A — Un `case` pour chaque jour**

    ```csharp
    int jour = 6;

    switch (jour)
    {
        case 1:
            Console.WriteLine("Jour de semaine");
            break;
        case 2:
            Console.WriteLine("Jour de semaine");
            break;
        case 3:
            Console.WriteLine("Jour de semaine");
            break;
        case 4:
            Console.WriteLine("Jour de semaine");
            break;
        case 5:
            Console.WriteLine("Jour de semaine");
            break;
        case 6:
            Console.WriteLine("Fin de semaine");
            break;
        case 7:
            Console.WriteLine("Fin de semaine");
            break;
        default:
            Console.WriteLine("Jour invalide");
            break;
    }
    ```

  </div>
  <div className="col col--6">

**Solution B — Regroupement des `case`**

    ```csharp
    int jour = 6;

    switch (jour)
    {
        case 1:
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine("Jour de semaine");
            break;
        case 6:
        case 7:
            Console.WriteLine("Fin de semaine");
            break;
        default:
            Console.WriteLine("Jour invalide");
            break;
    }
    ```

  </div>
</div>

**Questions :**

1. Les deux solutions produisent-elles le même résultat ?
2. Qu'est-ce que chaque solution affiche lorsque `jour` vaut `6` ?
3. Quel est l'avantage de regrouper plusieurs `case` ?

<details>
<summary>💡 Vérifier ma réponse</summary>

1. Oui, les deux solutions produisent le même résultat.
2. Les deux affichent : 
```text
Fin de semaine
```
3. Le regroupement évite de répéter les mêmes instructions et rend le code plus court et plus facile à lire.
</details>


---

### Question 3 — Le rôle de `default`

**Besoin :**

Une application attribue une catégorie à une commande :

- 1 : commande urgente ;
- 2 : commande régulière ;
- 3 : commande différée.

Pour toute autre valeur, l'application doit afficher « Type de commande inconnu ». Si le numéro est négatif, elle doit également afficher « Attention : le numéro ne peut pas être négatif ».

Un étudiant propose le code suivant :

```csharp
int type = -2;

switch (type)
{
    case 1:
        Console.WriteLine("Commande urgente");
        break;

    case 2:
        Console.WriteLine("Commande régulière");
        break;

    case 3:
        Console.WriteLine("Commande différée");
        break;

    default:
        Console.WriteLine("Type de commande inconnu");

        if (type < 0)
        {
            Console.WriteLine("Attention : le numéro ne peut pas être négatif");
        }

        break;
}
```

**Le code répond-il au besoin ? Justifiez votre réponse.**

<details>
<summary>💡 Vérifier ma réponse</summary>

**Oui.**

Pour `type = -2`, aucun des cas `1`, `2` ou `3` ne correspond. Le bloc `default` est donc exécuté.

Le programme affiche :

```text
Type de commande inconnu
Attention : le numéro ne peut pas être négatif
```

Le `if` placé dans `default` permet d'ajouter un traitement particulier pour les valeurs négatives, tout en conservant un message général pour les autres valeurs non reconnues.

Si `type` vaut `5`, seul le message « Type de commande inconnu » est affiché. Si `type` vaut `2`, le programme affiche « Commande régulière ».

</details>

---

### Question 4 — Deux boucles, un même résultat ?

On souhaite rechercher la première occurrence du caractère 'a' dans une chaîne. Le programme doit afficher la position de cette occurrence. Si la valeur n'est pas présente, il doit afficher un message approprié.


<div className="row">
  <div className="col col--6">

**Solution A — Boucle `for`**

```csharp
string texte = "banane";

for (int i = 0; i < texte.Length && texte[i] != 'a'; i++)
{
}

if (i < texte.Length)
{
    Console.WriteLine("Position : " + i);
}
else
{
    Console.WriteLine("La lettre 'a' est absente.");
}
```

  </div>
  <div className="col col--6">

**Solution B — Boucle `while`**

```csharp
string texte = "banane";
int i = 0;

while (i < texte.Length && texte[i] != 'a')
{
    i++;
}

if (i < texte.Length)
{
    Console.WriteLine("Position : " + i);
}
else
{
    Console.WriteLine("La lettre 'a' est absente.");
}
```

  </div>
</div>

**Questions :**

1. Les deux solutions produisent-elles le même résultat ?
2. Qu'est-ce que chaque solution affiche à la fin de son exécution ?
3. Quel est le rôle de la condition `i < texte.Length` dans la condition de répétition de la boucle ?
4. Pourquoi la recherche s'arrête-t-elle dès la première occurrence de la lettre 'a' ?
5. Si on remplace "banane" par "kiwi", qu'est-ce que le programme affiche ?

<details>
<summary>💡 Vérifier ma réponse</summary>


1. Oui, les deux solutions affichent le même résultat, car elles recherchent la première occurrence de la lettre 'a' dans la chaîne.
2. Les deux solutions affichent :
```text
Position : 1
```
La première occurrence de 'a' dans "banane" se trouve à l'indice 1.

3. Elle vérifie que l'indice i reste valide dans la chaîne. Elle empêche le programme d'accéder à un caractère situé au-delà de la fin de la chaîne.

4. Parce que la condition `texte[i] != 'a'` devient fausse lorsque la lettre 'a' est trouvée. La boucle s'arrête alors immédiatement.

5. Les deux solutions affichent :
```text
La lettre 'a' est absente.
```
La boucle parcourt toute la chaîne sans trouver la lettre 'a'. À la fin, i est égal à texte.Length, donc la condition `i < texte.Length` est fausse.

</details>
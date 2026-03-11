---
description: Exceptions
---

# Lancer & attraper une exception

---
### Télécharger la démonstration à compléter

Disponible ici 👉 [Demonstration7_2](../../static/files/demonstrations/Demonstration7_2.zip)

---

## 🎯 Objectifs de la séance

À la fin de cette séance, vous serez en mesure de :

- Comprendre le rôle des exceptions dans un programme
- Lancer une exception avec le mot-clé ``throw``
- Intercepter une exception avec la structure ``try { } catch { }``
- Utiliser les exceptions pour **protéger l’intégrité d’un objet**

---

## Introduction

Tout programme complexe a de fortes chances de contenir des erreurs. Ces erreurs peuvent prendre plusieurs formes : 
- Erreurs de programmation
- Erreurs découlant d’une interaction avec un utilisateur
- Erreurs découlant d'une collaboration avec d'autres systèmes

Indépendamment de leur nature et de leur origine, **ces erreurs doivent être gérées**. En C#, les erreurs détectées à l’exécution sont représentées par des **exceptions** et sont pris en charge par **un mécanisme de gestion des exceptions**. Essentiellement, ce mécanisme permet de :
- Signaler une erreur
- Transmettre les détails de cette erreur
- Permettre au programme de réagir de manière appropriée

Dans un contexte orienté objet, les exceptions sont particulièrement utiles pour protéger l’intégrité des objets et empêcher qu’ils se retrouvent dans un état invalide.

La première étape pour comprendre ce mécanisme consiste à apprendre comment **lancer une exception.**

---

## Étape 1 : Lancer une exception

Replongeons-nous dans notre classe `Thermostat` et examinons l'implémentation de la propriété `Temperature` ainsi que des méthodes `augmenterTemperature()` et `diminuerTemperature()`.

```csharp
public double Temperature
{
    get { return m_temperature; }
    private set
    {
        m_temperature = value;
    }

}
public void augmenterTemperature()
{
        Temperature++;

}

public void diminuerTemperature()
{
        Temperature--;

}

```

La première méthode permet d'augmenter la température d'un degré, alors que la seconde la diminue d'un degré. Étant donné les valeurs minimale et maximale autorisées par un ``Thermostat`` (voir `MIN_TEMPERATURE` et `MAX_TEMPERATURE`), voyez-vous une faille avec cette implémentation ?


### Le mot-clé `throw`

Actuellement, **rien n'empêche un utilisateur d'augmenter ou de diminuer la température au-delà des limites permises** . Pour protéger l'intégrité d'un objet `Thermostat` et respecter l'intervalle entre  `MIN_TEMPERATURE` et `MAX_TEMPERATURE`, nous pouvons lancer une exception lorsque la valeur fournie dépasse les limites autorisées. Pour ce faire, nous utilisons le mot-clé `throw` pour lancer une exception `ArgumentOutOfRangeException()` comme ceci :

```csharp
public double Temperature
{
    get { return m_temperature; }
    private set
    {
        if (value < MIN_TEMPERATURE || value > MAX_TEMPERATURE)
            throw new ArgumentOutOfRangeException();
        m_temperature = value;
    }

}
```
Que se passe-t-il ici ?

1️⃣ Le mot-clé `throw` permet d'interrompre l’exécution de la propriété `Temperature`;

2️⃣ **Une exception est un objet** créé à partir d’une classe d’exception.

---

### Les classes d’exception

Il existe plusieurs types d’exceptions dans .NET. Chaque classe d’exception correspond à un type d’erreur particulier. Ici, nous travaillons avec l'exception `ArgumentOutOfRangeException`, appropriée pour signaler qu’une valeur se trouve **en dehors de l’intervalle autorisé**. Il en existe plusieurs autres ! Parmi les exceptions les plus fréquentes sur lesquelles vous êtes probablement déjà tombés, on retrouve :
* `NullReferenceException`
* `IndexOutOfRangeException`
* `FileNotFoundException`
* `FormatException`

(Documentation officielle : https://learn.microsoft.com/fr-fr/dotnet/standard/exceptions/)

:::important
N.B. La classe ``Exception`` est **la classe de base de toutes les exceptions** en C#.
:::


**Testons !**

Essayez maintenant d’exécuter votre programme et d’augmenter ou de diminuer la température au-delà de la limite permise. Vous devriez obtenir un message semblable à celui-ci :

:::danger
System.ArgumentOutOfRangeException : 'Specified argument was out of the range of valid values.'
:::

Sachez qu'il est possible de fournir un message personnalisé lors de la création de l’exception, comme ceci :

```csharp
throw new ArgumentOutOfRangeException("La température devrait être entre 5 et 35 inclusivement");

```

Ce message pourra ensuite être récupéré lors du traitement de l’exception.

---

## Étape 2 : Attraper une exception

Les exceptions font partie intégrante du cycle de vie d’une application. Si elles ne peuvent pas toujours être évitées, il est par contre indispensable de les **intercepter** et de les gérer **afin d’éviter que l’application ne se termine brutalement.**

Dans l’exemple précédent, lorsque l’utilisateur provoque une erreur, l’application s’arrête immédiatement.

Dans une application réelle, il est préférable de :

* Détecter l’erreur
* Informer l’utilisateur de l'erreur commise
* Permettre à l’application de continuer à fonctionner

Pour ce faire, on utilise la structure ``try { } catch { }``.

### La structure `try{} catch{}`

Sachant que l’utilisateur peut augmenter ou diminuer la température en cliquant sur un bouton, nous pourrions intercepter l’exception comme ceci :

```csharp
private void btnAugmenter_Click(object sender, EventArgs e)
{
    try
    {
        thermostat.augmenterTemperature();
    }
    catch (ArgumentOutOfRangeException exception)
    {
        MessageBox.Show("La température devrait être entre 5 et 35 inclusivement");
        // ou MessageBox.Show(exception.Message) pour afficher le message de l'exception.
    }

    lblTemperature.Text = thermostat.Temperature.ToString();
}
```

La partie ``try`` contient les instructions susceptibles de déclencher une erreur. Si une exception est lancée, l’exécution du bloc `try` est interrompue et le programme passe immédiatement dans la partie ``catch`` afin de traiter l’erreur.

### Capturer TOUTES les exceptions

Remarquez qu'ici, nous ne capturons que les exceptions de type `ArgumentOutOfRangeException`. Il est possible d’attraper n’importe quelle exception en utilisant la classe de base ``Exception``, comme ceci :

```csharp
try
{
    // Instructions
}
catch (Exception exception)
{
    // Gestion générique d’une erreur.
}

```
Puisque toutes les exceptions *héritent* de ``Exception``, ce bloc capturera tous les types d’exceptions.

### Capturer des exceptions SPÉCIFIQUES

Il est souvent préférable de capturer des types d’exceptions spécifiques afin de réagir différemment selon l'erreur rencontrée. Pour cela, on peut enchaîner plusieurs blocs ``catch`` :

```csharp
try
{
    // Instructions
}
catch (ArgumentOutOfRangeException exceptionA)
{
    // Gestion d’une erreur d'intervalle.
}
catch (NullReferenceException exceptionB)
{
    // Gestion d’une erreur de référence.
}

```

Chaque bloc ``catch`` traite un type d’erreur particulier.

:::important
Il existe également un bloc ``finally`` permettant d'exécuter du code qu’une exception survienne ou non. Typiquement, ce bloc est utilisé pour libérer les ressources allouées dans un bloc ``try``. Ce mécanisme ne sera pas couvert dans cette introduction.
:::

---
## Comprendre la propagation d'une exception

Lorsqu’une exception est lancée, elle **remonte la pile d’appels** jusqu’à ce qu’un bloc ``catch`` la capture.

Considérons l’exemple suivant :

```csharp
static void Main()
{
    methodeA();
}

static void methodeA()
{
    methodeB();
}

static void methodeB()
{
    throw new Exception("Erreur !");
}
```

Voici ce qui se passe :

1️⃣ ``Main()`` appelle ``methodeA()``

2️⃣ ``methodeA()`` appelle ``methodeB()``

3️⃣ ``methodeB()`` lance une exception

Une fois lancée, l'exception remonte la pile d'appels comme suit :

```csharp
methodeB --> methodeA --> Main
```

Si aucune méthode ne capture l’exception avec ``catch``, **le programme s’arrête**.

En interceptant l'exception dans le `Main`, on s'assure que le programme **ne plante pas**.

```csharp
static void Main()
{
    try
    {
        methodeA();
    }
    catch (Exception e)
    {
        Console.WriteLine("Une erreur s'est produite.");
    }
}

```
Ici :

* ``methodeB()`` lance l’exception

* L'exception remonte jusqu’à ``Main()``

* ``Main()`` l’intercepte et affiche un message dans la console

---

## Règle fondamentale à retenir !

Pour éviter de mettre des `throw` et des `try/catch` un peu partout, il est bon de se rappeler la règle suivante :

* On utilise ``throw`` là où l’erreur est **détectée**.

* On utilise ``try/catch`` là où on veut **réagir** à l’erreur.

Dans notre exemple :

* C'est dans la classe ``Thermostat`` qu'une température invalide est **détectée**. C'est donc là où on lance une exception.

* C'est dans l’interface utilisateur qu'on **réagit** à l’erreur en capturant l'exception et en affichant un message approprié.




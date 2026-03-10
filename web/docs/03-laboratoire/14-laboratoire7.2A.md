---
title: Introduction aux exceptions en console
---
# 🧪 Labo 7.2A – Introduction aux exceptions

---
:::danger
Ce laboratoire doit être développé à l'aide du logiciel **Git**. Vous devrez **créer un nouveau dépôt dans GitHub** 
et **inviter votre professeur** en tant que collaborateur.

Voici le format du dépôt exigé: **H26-2P6-R14-MATRICULE**

Il devrait y avoir **un commit** pour **chaque** exercice.

:::

:::note
Les exercices suivants peuvent être réalisés à partir d'une **application console**.
:::

## 🟢 Exercice 1 – Observer une exception

Considérez le code suivant :

```csharp
static void Main()
{
    int x = int.Parse("bonjour");

    Console.WriteLine(x);
}
```
1)	Que se passe-t-il lorsque vous exécutez ce programme ?
2)	Quel type d’exception est généré ?


---

## 🟢 Exercice 2 – Lancer une exception spécifique

:::important
**Rappel :** Vous pouvez lever explicitement une exception à l’aide de l’instruction ``throw``.
:::

Considérez la classe suivante :

```csharp
class CompteBancaire
{
    public double Solde { get; private set; }

    public void Retirer(double montant)
    {
        Solde -= montant;
    }

    public CompteBancaire(){
        Solde = 100.0;
    }
}
```
1) Quel est la faille dans l'implémentation actuelle de cette classe ?

2) Modifiez la méthode ``Retirer()`` afin qu’elle lance une exception si un utilisateur tente de retirer un montant **supérieur** au solde disponible. Pour ce faire :
    * Choisissez une exception appropriée (autre que ``Exception``) parmi celles présentées dans la documentation suivante : https://learn.microsoft.com/fr-fr/dotnet/standard/exceptions/ (🤓*bonne lecture hehehe*)
    * Personnalisez le message de l'exception

3) Pour vérifier votre implémentation, rendez-vous dans le `Main()` :
    * Instanciez un nouvel objet `CompteBancaire`
    * Tentez de retirer 150,00 $.

Qu’observez-vous lors de l’exécution du programme ?


---

## 🟢 Exercice 3 – Intercepter une exception spécifique

:::important
**Rappel :** les instructions susceptibles de **provoquer une erreur** doivent être placées dans un bloc ``try``. Le traitement de l’exception se fait ensuite dans un ou plusieurs blocs ``catch``.
:::

Utilisez la structure `try/catch` dans votre `Main()` afin d'intercepter l'exception lancée à l'exercice précédent. Dans votre bloc `catch`, gérez l'exception simplement en affichant le message de l’exception dans la console.

:::tip
Pour récupérer le message d’une exception, vous pouvez utiliser sa propriété `Message` : `exception.Message`
:::

---

## 🟢 Exercice 4 – Intercepter plusieurs exceptions spécifiques

Dans l’exemple suivant, on tente d'ouvrir un fichier nommé ``data.txt`` et d'afficher la première ligne du fichier. Un code comme celui-ci peut typiquement lever l’une des exceptions suivantes :

* *FileNotFoundException*
* *DirectoryNotFoundException*
* *IOException*

Écrivez un ``try/catch`` composé de 3 blocs ``catch``, chacun interceptant l’une de ces exceptions. Dans chaque bloc ``catch``, affichez simplement le message de l’exception dans la console.

```csharp
static void Main()
{
    using (StreamReader sr = File.OpenText("data.txt"))
    {
        Console.WriteLine($"La première ligne du fichier est {sr.ReadLine()}");

    }
}
```


---
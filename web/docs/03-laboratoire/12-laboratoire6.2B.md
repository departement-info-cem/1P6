---
title: 🟡 Calculatrice simple
---
# 🧪 Labo 6.2B – 🟡 Calculatrice simple

---

## 🎯 Objectifs 
* Se familiariser avec Windows Forms et les classes
* Créer une classe
* Instancier et utiliser un objet
* Créer un formulaire lié à un objet

---

## 🛠️ Instructions

Vous devez écrire un programme qui simule une calculatrice simple pour laquelle on pourra spécifier la précision. Vous devrez créer une classe **`Calculatrice`** dans votre bibliothèque de classe **`Modele`** qui sera utilisée par votre interface graphique pour:
- Additionner deux chiffres
- Soustraire deux chiffres
- Multiplier deux chiffres
- Diviser deux chiffres

:::danger
Pour cet exercice, il est interdit de faire la conversion en décimale des deux chiffres dans l'interface graphique. Il faudra que la classe calculatrice reçoive en paramètre et retourne le résultat en format **`string`**.
:::


## ⭐ Exemple d'exécution

Vous devrez être en mesure de:
- Spécifier la précision désirée
- Entrer un premier chiffre dans un **`Textbox`**
- Entrer un deuxième chiffre dans un **`Textbox`**
- Quatre boutons pour chaque opération addition, soustraction, multiplication et division
- Afficher le résultat dans une étiquette (**`Label`**)

#### Votre solution devrait ressembler à ceci:

![Exemple des fichiers dans l'explorateur de solution](@site/static/img/R12/calculatriceSimple.png)

:::tip
Vous pouvez vous inspirer de cette propriété dérivée pour formater le résultat de la calculatrice:

```csharp
public string Resultat 
{
    get
    {
        return String.Format("{0:N" + Precision + "}", m_resultat);
    }
}
```
:::
---
description: Définition des classes - Encapsulation
---

# Définition des classes - Encapsulation

## 🎯 Objectifs
1. Comprendre le principe d'encapsulation
2. Comprendre l’importance de préserver l’intégrité d’un objet.
3. Utiliser les accesseurs get et set
4. Ajouter des règles de validation dans l’accesseur set.
3. Définir des propriétés automatiques.
4. Définir des propriétés calculées.

## ✅ Encapsulation

## 1. Définition

L’encapsulation est un principe de la programmation orientée objet qui consiste à :

> **cacher les données d’un objet et contrôler la façon dont on peut y accéder ou les modifier.**

Concrètement, cela signifie que :

* les données d’une classe sont déclarées **privées** ;
* on y accède uniquement par des **propriétés ou des méthodes** ;
* chaque modification est **vérifiée et encadrée**.

L’objectif est d’empêcher qu’un objet se retrouve dans un état incorrect ou incohérent. Autrement dit, elle protège les données d’un objet en obligeant le programmeur à passer par des règles d’accès contrôlées, afin de garantir sa cohérence et sa fiabilité.


---

## 2. Champ (privé)

Un **champ** sert à stocker la donnée.


```csharp

private int m_secondes;   // Champ privé
```
## 3. Propriété (publique)

Pour accéder à la valeur d’un champ, on peut définir une **propriété** en précisant son niveau d’accès (lecture et/ou écriture).

* Pour un accès en **lecture seulement**, on définit un **accesseur** `get`.
* Pour un accès en **écriture seulement**, on définit un **accesseur** `set`.

#### 📖 Propriété en lecture seule

L’accesseur `get` permet de **lire** la valeur d’une propriété. 

```csharp
public int Secondes       // Propriété publique
{
    get { return m_secondes; }
      
}
```
👉 Ici, la valeur peut être consultée, mais pas modifiée de l’extérieur.

---

#### ✍️ Propriété en lecture/écriture

* L’accesseur `set` permet de **modifier** la valeur d’une propriété. 
* Le mot-clé `value` représente la valeur assignée.

```csharp
public int Secondes       // Propriété publique
{
    get { return m_secondes; }
    set                    
    {
        // Validation de la nouvelle valeur value avant de l'assigner au champ m_secondes
         if(value >= 0 && value <= 59)
         {
            m_secondes = value; 
         }
         
         
    }
}
```


```csharp

// Exemples d'assignation
Montre uneMontre = new Montre();
uneMontre.Secondes = 10; // La valeur 10 sera assignée au champ m_secondes a travers l'assenceur set
uneMontre.Secondes = 60 // La valeur 60 n'est pas valide et elle ne sera pas assignée au champ m_secondes 
```

👉 Cette version permet la consultation et la modification.

---

## 4. Propriété calculée

Une **propriété calculée** ne stocke pas directement une valeur.
Elle la calcule à partir d’autres champs.

### Exemple avec une méthode

```csharp
public string ObtenirTempsCourant()
{
    return m_heures + ":" +
           m_minutes.ToString("00") + ":" +
           m_secondes.ToString("00");
}
```
```csharp
// Obtenir le temps courant avec la méthode
Montre uneMontre = new Montre();
string tempCourant = uneMontre.ObtenirTempsCourant(); 
```

### Version avec une propriété calculée

```csharp
public string TempsCourant
{
    get
    {
        return m_heures + ":" +
               m_minutes.ToString("00") + ":" +
               m_secondes.ToString("00");
    }
}
```
```csharp
// Obtenir le temps courant avec la propriété calculée
Montre uneMontre = new Montre();
string tempCourant = uneMontre.TempsCourant; 
```

👉 La propriété remplace ici la méthode sans paramètre.

---

## 5. Propriété automatique

Une **propriété automatique** permet d’éviter la déclaration explicite d’un champ privé.

### Version classique

```csharp
private int m_secondes;

public int Secondes
{
    get { return m_secondes; }
}
```

### Version automatique

```csharp
public int Secondes { get; private set; }
```

👉 Le compilateur crée automatiquement le champ interne.

---
❌ Les propriétés automatiques sont simples à implémenter, mais ne permettent pas facilement la validation et l'exécution de traitements dans le set.

---

## 6. À retenir

### ✔️ L’encapsulation permet de :

* protéger les données,
* éviter les valeurs invalides,
* améliorer la robustesse du programme.

### ✔️ Les propriétés servent à :

* contrôler l’accès aux champs,
* valider les données,
* exposer l’état d’un objet.

### ✔️ Types de propriétés

| Type             | Utilité        |
| ---------------- | -------------- |
| Lecture seule    | Consultation   |
| Écriture seule   | Modification   |
| Lecture/écriture | Accès complet  |
| Calculée         | Valeur dérivée |
| Automatique      | Simplicité     |

---



## 📚 Ressources supplémentaires


Vous devez réaliser le labo suivant :
 [🧪 Labo 2.2](/laboratoire/laboratoire2.2)

---

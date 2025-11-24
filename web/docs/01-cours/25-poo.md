---
description: Objets, propriétés, méthodes et apprendre à les utiliser
---

# Introduction à la programmation orientée objet

## Instanciation

   * Création d’un objet avec `new`.
   * [Documentation sur l’instanciation en C#](https://sites.google.com/site/notionscsharpcem/instanciation_objet)

## Accéder aux membres d’un objet

   * **Propriétés** : valeurs appartenant à l’objet.
   * **Méthodes** : actions que l’objet peut effectuer.
   * **Constantes** : accessibles via le **nom de la classe**, pas l’objet.

     ```csharp
     int valeur = MaClasse.NomConstante;
     ```
   * **Méthodes statiques** : accessibles via le **nom de la classe**, pas l’objet.

## Type valeur et type référence

   * **Type valeur** : stocke directement la valeur (ex. `int`, `char`, `decimal`, `bool`).
   * **Type référence** : stocke l’adresse de l’objet (ex. `string`, tableaux, classes).
   * Une référence `null` signifie que l’objet ne référence rien. Un objet déclaré mais non instancié a la valeur `null`.

## Variable locale vs variable membre

   * **Variable locale** : déclarée dans une méthode ou un bloc ; accessible uniquement à l’intérieur. Disparaît à la fin de l’exécution du bloc.
   * **Variable membre** : déclarée au niveau de la classe ; accessible dans toutes les méthodes de la classe. Préfixe conseillé : `m_` (ex. `m_prix`).

## Débogueur pour visualiser les membres d’un objet

   * Mettre un point d’arrêt et survoler l’objet pour voir les valeurs de ses propriétés.
   * Voir la structure de la classe via clic droit → “Atteindre la définition”.


  ##  Démonstration : Découvrir l'objet avec la Poule Magique

## 🎯 Objectif
1. Créer des objets avec **new** (Instancier des classes)
2. Comprendre le fonctionnement d’un objet en utilisant :
   - les propriétés exposées,
   - les méthodes disponibles,
3. Utiliser le débogueur (points d’arrêt, pas-à-pas, inspection des variables).

## 🪄🐔 **Message de la Poule Magique**

 « **Bonjour, humain curieux !**
Je suis **PouleMagique**, la créature la plus incroyable du poulailler interdimensionnel.

On m’a enfermée dans une petite classe C#…

   ⦿ Vous voyez mes **propriétés** ? Elles changent parfois sans prévenir.

   ⦿ Vous voyez mes **méthodes** ? Elles font des choses… disons, *surprenantes*.

Mais vous ne saurez jamais exactement quoi…

**à moins d’utiliser votre Débogueur !**


Votre mission est simple :
- 🔍 **M’observer**
- 🧪 **Tester mes actions**
- 📈 **Comprendre comment je réagis**
- et découvrir ce que cachent mes mystérieux comportements magiques.

Allez, assez parlé, humain !
Faites-moi **danser**, **manger**, **pondre** ou même **activer mon pouvoir spécial**…
et venez percer **mon secret** ! »

---
## 📎 Références
* [Instanciation objet](https://info.cegepmontpetit.ca/notions-csharp/documentation/instanciation-objet)



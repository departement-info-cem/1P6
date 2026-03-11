---
title: Traitement des exceptions dans WinForms
---
# 🧪 Labo 7.2B – Traitement des exceptions dans WinForms

## 🟢 Exercices B1 – Utiliser des `throw` dans un projet WinForms

**Projet de départ :** [Laboratoire7_2_B1](../../static/files/laboratoires/Laboratoire7_2_B1.zip)

### A - CompteurHydro

Prenez connaissance des classes ``CompteurHydro`` et `FrmPrincipal`. 

1) Du point de vue de **l'intégrité des données**, quel est le problème avec l'implémentation actuelle de la méthode `Consommer()` ?

2) Ajoutez le code nécessaire pour lancer une exception **lorsque pQuantitéKwh est négatif**. Quelle exception serait appropriée dans ce cas-ci ? Consultez la documentation  https://learn.microsoft.com/fr-fr/dotnet/standard/exceptions/

3) Vérifiez que votre exception est bien lancée lorsque la méthode reçoit une valeur invalide.


### B - Montre

Prenez connaissance des classes ``Montre`` et `FrmPrincipal`. 

1) Du point de vue de **l'intégrité des données**, comment pourriez-vous améliorer l’implémentation actuelle de la classe `Montre` ?

2) Ajoutez le code nécessaire pour lancer des exceptions dans chacune des propriétés `Heures`, `Minutes`, `Secondes` lorsqu’une valeur invalide est assignée. Quelle exception serait appropriée dans ce cas-ci ? Voir https://learn.microsoft.com/fr-fr/dotnet/standard/exceptions/

3) Vérifiez que vos exceptions sont bien lancées lorsque des valeurs invalides sont assignées.

---

## 🟡 Exercices B2 - Traiter des exceptions dans un projet WinForms

**Projet de départ :** [Laboratoire7_2_B2](../../static/files/laboratoires/Laboratoire7_2_B2.zip)

Dans cette série d’exercices, l’interface contient quatre boutons, chacun provoquant une erreur différente.
Votre objectif est d’intercepter les exceptions générées et de les gérer adéquatement.

### Exercice 1 - Thermostat
Prenez connaissance de la classe ``Thermostat``. Dans `FrmPrincipal.cs`, au niveau de l'évènement ``BtnExemple1_Click()``, capturez l'exception lancée lorsqu'on tente d'assigner la valeur `999 degrés` à la propriété ``Temperature``. Gérez l'exception en affichant son message dans un ``MessageBox``.
### Exercice 2 - Tableau 1D
Dans ``BtnExemple2_Click()``, une erreur est provoquée lorsqu'on tente d'assigner une valeur à la 11e case d'un tableau contenant seulement 5 cases. Capturez l'exception et gérez-la en affichant son message dans un ``MessageBox``.
### Exercice 3 - Conversion `string` vers `int`
Dans ``BtnExemple3_Click()``, vous tentez de convertir les chaînes de caractères `chaine1` et `chaine2` en entier. Capturez les exceptions pouvant être lancées lors de ces conversions. Vous devez utiliser au moins deux blocs `catch` distincts.
### Exercice 4 - Lecture d'un fichier `txt` et création d'un objet `Personne`
Considérez la classe `Personne`, ainsi que le fichier `ListeDesPersonnes.txt`. 
1) Exécutez le code présent dans `BtnExemple4_Click()` afin d’identifier l’exception générée.
2) Implémentez une solution adéquate permettant d’intercepter et de gérer cette exception.


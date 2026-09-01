---
title: A - Intègration structure conditionnelle if
---

# 🧪 Labo 2.2A – Intègration structure conditionnelle if

# Prime de rendement d'un employé

## Contexte

Une entreprise accorde des primes à ses employés selon leurs ventes, leurs heures travaillées et leur ancienneté.

Un employé peut recevoir une prime de base et, dans certains cas, une prime supplémentaire.

## Règles de calcul

| **Condition**                                              | **Prime**                     |
| ---------------------------------------------------------- | ----------------------------- |
| Ventes de 3000 $ ou plus                                   | 500 $                         |
| Ventes de 2000 $ ou plus avec au moins 30 heures travaillées | 300 $                         |
| Ancienneté de 5 ans ou plus                                | Prime supplémentaire de 100 $ |

## Besoins

Crée un programme qui demande le montant des ventes, le nombre d'heures travaillées et le nombre d'années d'ancienneté.

Le programme doit afficher la prime totale obtenue ainsi qu'une explication.

## Valeurs à utiliser

* Ventes : nombre réel positif.
* Heures travaillées : entier positif.
* Ancienneté : entier positif.

## Notions à utiliser

* comparaisons numériques;
* opérateurs logiques (`&&`, `||`);
* structures `if`, `else if` et `else`;
* calculs avec variables numériques.

## Contraintes

* Une seule prime de base peut être accordée.
* La prime d'ancienneté peut s'ajouter à la prime de base.
* Prévoir un message d'erreur pour les valeurs négatives.

## Exemple de résultat

**Entrées saisies :** ventes `3200`, heures `28`, ancienneté `6`

```text
Prime totale : 600 $

Raison :
- Prime de rendement exceptionnelle : 500 $
- Prime d'ancienneté : 100 $
```

## Critères de réussite

* La bonne prime est calculée.
* Les règles sont appliquées dans le bon ordre.
* Les valeurs invalides sont traitées.

## Tests manuels et résultats attendus

| Ventes | Heures | Ancienneté | Résultat attendu     |
| ------ | ------ | ---------- | -------------------- |
| 3200   | 28     | 6          | Prime totale : 600 $ |
| 2500   | 35     | 2          | Prime totale : 300 $ |
| 2500   | 25     | 7          | Prime totale : 100 $ |
| 1500   | 40     | 1          | Prime totale : 0 $   |
| -100   | 20     | 2          | Message d'erreur     |

---

# Admission à une activité spéciale

## Contexte

Un parc d'aventures organise une activité spéciale.

L'accès dépend de l'âge, de la possession d'un billet et de la présence d'un adulte accompagnateur.

## Règles d'admission

| **Situation**                                              | **Résultat**        |
| ---------------------------------------------------------- | ------------------- |
| 18 ans ou plus avec billet valide                            | Admission autorisée |
| Moins de 18 ans avec billet valide et accompagné d'un adulte | Admission autorisée |
| Toute autre situation                                      | Admission refusée   |

## Besoins

Crée un programme qui détermine si une personne peut participer à l'activité.

## Valeurs à utiliser

* Âge : entier entre 0 et 120.
* Billet valide : `oui` ou `non`.
* Accompagnateur : `oui` ou `non`.

## Notions à utiliser

* expressions logiques;
* opérateurs `&&` et `||`;
* structures conditionnelles.

## Contraintes

* Une personne sans billet ne peut jamais entrer.
* Une personne majeure n'a pas besoin d'accompagnateur.
* Prévoir un message d'erreur si l'âge est invalide.

## Exemple de résultat

**Entrées saisies :** âge `15`, billet `oui`, accompagnateur `oui`

```text
Admission autorisée

Raison : mineur accompagné avec billet valide.
```

## Critères de réussite

* La bonne décision est affichée.
* Les règles sont respectées.
* Les cas invalides sont traités.

## Tests manuels et résultats attendus

| Âge | Billet | Accompagnateur | Résultat attendu    |
| --- | ------ | -------------- | ------------------- |
| 20  | oui    | non            | Admission autorisée |
| 15  | oui    | oui            | Admission autorisée |
| 15  | oui    | non            | Admission refusée   |
| 20  | non    | oui            | Admission refusée   |
| -5  | oui    | oui            | Message d'erreur    |

---

# Défi 2.4 — Facture d'une commande en ligne

## Contexte

Une boutique en ligne applique différents frais et rabais selon le montant de la commande et le statut du client.

## Règles

| **Condition**               | **Effet**                      |
| --------------------------- | ------------------------------ |
| Commande inférieure à 25 $  | Frais de livraison de 8 $      |
| Commande de 25 $ ou plus    | Frais de livraison de 5 $      |
| Client Premium              | Livraison gratuite             |
| Commande supérieure à 100 $ | Rabais de 10 % sur la commande |

## Besoins

Crée un programme qui calcule le montant final à payer.

## Valeurs à utiliser

* Montant de la commande : nombre réel positif.
* Client Premium : `oui` ou `non`.

## Notions à utiliser

* calculs numériques;
* structures conditionnelles;
* pourcentage;
* plusieurs `if` dans le même programme.

## Contraintes

* Le rabais doit être appliqué avant d'ajouter les frais de livraison.
* Les frais de livraison ne peuvent jamais être négatifs.
* Prévoir un message d'erreur pour un montant invalide.

## Exemple de résultat

**Entrées saisies :** montant `120`, premium `non`

```text
Montant après rabais : 108 $

Frais de livraison : 5 $

Total à payer : 113 $
```

## Critères de réussite

* Le calcul est exact.
* Les règles sont appliquées dans le bon ordre.
* Les valeurs invalides sont traitées.

## Tests manuels et résultats attendus

| Montant | Premium | Résultat attendu |
| ------- | ------- | ---------------- |
| 120     | non     | Total : 113 $    |
| 120     | oui     | Total : 108 $    |
| 20      | non     | Total : 28 $     |
| 20      | oui     | Total : 20 $     |
| -10     | non     | Message d'erreur |

---

# Défi 2.5 — Évaluation de la réussite d'un étudiant

## Contexte

Pour réussir un cours, un étudiant doit satisfaire plusieurs conditions.

## Règles

| **Condition**    | **Valeur minimale** |
| ---------------- | ------------------- |
| Note d'examen    | 60 %                |
| Note des travaux | 60 %                |
| Moyenne finale   | 60 %                |

## Besoins

Crée un programme qui détermine si l'étudiant réussit ou échoue.

Si l'étudiant échoue, le programme doit préciser toutes les conditions non respectées.

## Valeurs à utiliser

* Note d'examen : nombre réel entre 0 et 100.
* Note des travaux : nombre réel entre 0 et 100.
* Moyenne finale : nombre réel entre 0 et 100.

## Notions à utiliser

* plusieurs conditions indépendantes;
* opérateurs logiques;
* structures `if`;
* validation de données.

## Contraintes

* Toutes les conditions doivent être vérifiées.
* Plus d'un message peut être affiché en cas d'échec.
* Prévoir un message d'erreur pour les notes invalides.

## Exemple de résultat

**Entrées saisies :** examen `55`, travaux `70`, moyenne `58`

```text
Résultat : Échec

Conditions non respectées :
- Examen inférieur à 60 %
- Moyenne finale inférieure à 60 %
```

## Critères de réussite

* Toutes les conditions sont vérifiées.
* Les raisons de l'échec sont affichées.
* Les données invalides sont détectées.

## Tests manuels et résultats attendus

| Examen | Travaux | Moyenne | Résultat attendu     |
| ------ | ------- | ------- | -------------------- |
| 75     | 80      | 78      | Réussite             |
| 55     | 70      | 58      | Échec avec 2 raisons |
| 55     | 50      | 55      | Échec avec 3 raisons |
| 60     | 60      | 60      | Réussite             |
| 120    | 70      | 80      | Message d'erreur     |


Je ne mettrais pas directement le **code C# complet** sous chaque exercice, sinon plusieurs étudiants vont simplement le copier.

Pour un laboratoire de consolidation, je te suggère plutôt de fournir sous chaque défi une **démarche de résolution**. Voici celles des 4 premiers défis.

---

# Défi 2.2 — Prime de rendement d'un employé

## Solution possible

### Démarche de résolution

1. Lire le montant des ventes, le nombre d'heures travaillées et l'ancienneté.
2. Vérifier que les valeurs sont valides.
3. Initialiser la prime à 0.
4. Vérifier si les ventes atteignent 3000 $ ou plus.

   * Si oui, ajouter une prime de 500 $.
5. Sinon, vérifier si les ventes atteignent 2000 $ ou plus et si l'employé a travaillé au moins 30 heures.

   * Si oui, ajouter une prime de 300 $.
6. Vérifier si l'ancienneté est de 5 ans ou plus.

   * Si oui, ajouter 100 $ à la prime.
7. Afficher la prime totale ainsi que les raisons accordées.

### Algorithme

```text
Lire ventes
Lire heures
Lire anciennete

Si une valeur est invalide
    Afficher un message d'erreur
Sinon
    prime = 0

    Si ventes >= 3000
        prime = prime + 500
    Sinon si ventes >= 2000 ET heures >= 30
        prime = prime + 300

    Si anciennete >= 5
        prime = prime + 100

    Afficher prime
```

---

# Défi 2.3 — Admission à une activité spéciale

## Solution possible

### Démarche de résolution

1. Lire l'âge.
2. Vérifier que l'âge est valide.
3. Lire l'information concernant le billet.
4. Si la personne est majeure et possède un billet valide, autoriser l'accès.
5. Sinon, vérifier si la personne est mineure, possède un billet et est accompagnée.
6. Afficher la décision finale.

### Algorithme

```text
Lire age

Si age invalide
    Afficher un message d'erreur
Sinon
    Lire billet
    Lire accompagnateur

    Si age >= 18 ET billet = oui
        Autoriser l'accès
    Sinon si age < 18 ET billet = oui ET accompagnateur = oui
        Autoriser l'accès
    Sinon
        Refuser l'accès
```

---

# Défi 2.4 — Facture d'une commande en ligne

## Solution possible

### Démarche de résolution

1. Lire le montant de la commande.
2. Vérifier que le montant est valide.
3. Déterminer le rabais applicable.
4. Calculer le montant après rabais.
5. Déterminer les frais de livraison.
6. Si le client est Premium, rendre la livraison gratuite.
7. Calculer le total à payer.
8. Afficher le détail des calculs.

### Algorithme

```text
Lire montant

Si montant invalide
    Afficher un message d'erreur
Sinon
    montantFinal = montant

    Si montant > 100
        montantFinal = montantFinal - (montantFinal * 0.10)

    Si montant < 25
        livraison = 8
    Sinon
        livraison = 5

    Si clientPremium = oui
        livraison = 0

    total = montantFinal + livraison

    Afficher total
```

---

# Défi 2.5 — Évaluation de la réussite d'un étudiant

## Solution possible

### Démarche de résolution

1. Lire les trois notes.
2. Vérifier que les notes sont comprises entre 0 et 100.
3. Initialiser une variable indiquant que l'étudiant réussit.
4. Vérifier séparément chacune des conditions.
5. Si une condition n'est pas respectée, afficher la raison et indiquer un échec.
6. Après toutes les vérifications, afficher le résultat final.

### Algorithme

```text
Lire examen
Lire travaux
Lire moyenne

Si une note est invalide
    Afficher un message d'erreur
Sinon
    reussite = vrai

    Si examen < 60
        Afficher une raison
        reussite = faux

    Si travaux < 60
        Afficher une raison
        reussite = faux

    Si moyenne < 60
        Afficher une raison
        reussite = faux

    Si reussite
        Afficher "Réussite"
    Sinon
        Afficher "Échec"
```

Pour un groupe de **1P6**, ces démarches sont souvent plus utiles que le code complet, car elles obligent les étudiants à transformer eux-mêmes l'algorithme en `if`, `else if` et `else`. Cela permet aussi de réutiliser les mêmes exercices lors d'évaluations sans que la solution soit déjà fournie.


Oui, pour tes étudiants de 1P6, je mettrais directement une section **« Solution possible (pseudo-code) »** à la fin de chaque défi.

---

# Défi 2.2 — Prime de rendement d'un employé

## Solution possible (pseudo-code)

```text
Lire ventes
Lire heuresTravaillees
Lire anciennete

Si ventes < 0 OU heuresTravaillees < 0 OU anciennete < 0
    Afficher "Erreur : valeur invalide."
Sinon

    prime = 0

    Si ventes >= 3000
        prime = prime + 500
    Sinon Si ventes >= 2000 ET heuresTravaillees >= 30
        prime = prime + 300
    Fin Si

    Si anciennete >= 5
        prime = prime + 100
    Fin Si

    Afficher "Prime totale : ", prime
Fin Si
```

---

# Défi 2.3 — Admission à une activité spéciale

## Solution possible (pseudo-code)

```text
Lire age

Si age < 0 OU age > 120
    Afficher "Erreur : âge invalide."
Sinon

    Lire billet
    Lire accompagnateur

    Si age >= 18 ET billet = "oui"
        Afficher "Admission autorisée"
    Sinon Si age < 18 ET billet = "oui" ET accompagnateur = "oui"
        Afficher "Admission autorisée"
    Sinon
        Afficher "Admission refusée"
    Fin Si

Fin Si
```

---

# Défi 2.4 — Facture d'une commande en ligne

## Solution possible (pseudo-code)

```text
Lire montantCommande

Si montantCommande < 0
    Afficher "Erreur : montant invalide."
Sinon

    Lire clientPremium

    montantApresRabais = montantCommande

    Si montantCommande > 100
        montantApresRabais = montantCommande * 0.90
    Fin Si

    Si montantCommande < 25
        fraisLivraison = 8
    Sinon
        fraisLivraison = 5
    Fin Si

    Si clientPremium = "oui"
        fraisLivraison = 0
    Fin Si

    total = montantApresRabais + fraisLivraison

    Afficher "Montant après rabais : ", montantApresRabais
    Afficher "Frais de livraison : ", fraisLivraison
    Afficher "Total à payer : ", total

Fin Si
```

---

# Défi 2.5 — Évaluation de la réussite d'un étudiant

## Solution possible (pseudo-code)

```text
Lire noteExamen
Lire noteTravaux
Lire moyenneFinale

Si noteExamen < 0 OU noteExamen > 100
    Afficher "Erreur : note invalide."
Sinon Si noteTravaux < 0 OU noteTravaux > 100
    Afficher "Erreur : note invalide."
Sinon Si moyenneFinale < 0 OU moyenneFinale > 100
    Afficher "Erreur : note invalide."
Sinon

    reussite = vrai

    Si noteExamen < 60
        Afficher "Examen insuffisant."
        reussite = faux
    Fin Si

    Si noteTravaux < 60
        Afficher "Travaux insuffisants."
        reussite = faux
    Fin Si

    Si moyenneFinale < 60
        Afficher "Moyenne finale insuffisante."
        reussite = faux
    Fin Si

    Si reussite
        Afficher "Résultat : Réussite"
    Sinon
        Afficher "Résultat : Échec"
    Fin Si

Fin Si
```

J'aime bien ce format parce qu'il reste suffisamment détaillé pour guider l'étudiant, tout en lui laissant le travail de transformer le pseudo-code en C#. C'est généralement le bon équilibre pour un laboratoire de consolidation.

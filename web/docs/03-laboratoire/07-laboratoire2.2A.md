---
title: A - Intègration structure conditionnelle if
---

# 🧪 Labo 2.2A – Intègration structure conditionnelle if

## Exercice 1 - Prime de rendement d'un employé

### Contexte

Une entreprise accorde des primes à ses employés selon leurs ventes, leurs heures travaillées et leur ancienneté.

Un employé peut recevoir une prime de base et, dans certains cas, une prime supplémentaire.

### Règles de calcul

| **Condition**                                              | **Prime**                     |
| ---------------------------------------------------------- | ----------------------------- |
| Ventes de 3000 $ ou plus                                   | 500 $                         |
| Ventes de 2000 $ ou plus avec au moins 30 heures travaillées | 300 $                         |
| Ancienneté de 5 ans ou plus                                | Prime supplémentaire de 100 $ |

### Besoins

Crée un programme qui demande le montant des ventes, le nombre d'heures travaillées et le nombre d'années d'ancienneté.

Le programme doit afficher la prime totale obtenue ainsi qu'une explication.

### Valeurs à utiliser

* Ventes : nombre réel positif.
* Heures travaillées : entier positif.
* Ancienneté : entier positif.

### Notions à utiliser

* comparaisons numériques;
* opérateurs logiques (`&&`, `||`);
* structures `if`, `else if` et `else`;
* calculs avec variables numériques.

### Contraintes

* Une seule prime de base peut être accordée.
* La prime d'ancienneté peut s'ajouter à la prime de base.
* Prévoir un message d'erreur pour les valeurs négatives.

### Exemple de résultat

**Entrées saisies :** ventes `3200`, heures `28`, ancienneté `6`

```text
Prime totale : 600 $

Raison :
- Prime de rendement exceptionnelle : 500 $
- Prime d'ancienneté : 100 $
```

### Critères de réussite

* La bonne prime est calculée.
* Les règles sont appliquées dans le bon ordre.
* Les valeurs invalides sont traitées.

### Tests manuels et résultats attendus

| Ventes | Heures | Ancienneté | Résultat attendu     |
| ------ | ------ | ---------- | -------------------- |
| 3200   | 28     | 6          | Prime totale : 600 $ |
| 2500   | 35     | 2          | Prime totale : 300 $ |
| 2500   | 25     | 7          | Prime totale : 100 $ |
| 1500   | 40     | 1          | Prime totale : 0 $   |
| -100   | 20     | 2          | Message d'erreur     |

---

## Exercice 2 - Admission à une activité spéciale

### Contexte

Un parc d'aventures organise une activité spéciale.

L'accès dépend de l'âge, de la possession d'un billet et de la présence d'un adulte accompagnateur.

### Règles d'admission

| **Situation**                                              | **Résultat**        |
| ---------------------------------------------------------- | ------------------- |
| 18 ans ou plus avec billet valide                            | Admission autorisée |
| Moins de 18 ans avec billet valide et accompagné d'un adulte | Admission autorisée |
| Toute autre situation                                      | Admission refusée   |

### Besoins

Crée un programme qui détermine si une personne peut participer à l'activité.

### Valeurs à utiliser

* Âge : entier entre 0 et 120.
* Billet valide : `oui` ou `non`.
* Accompagnateur : `oui` ou `non`.

### Notions à utiliser

* expressions logiques;
* opérateurs `&&` et `||`;
* structures conditionnelles.

### Contraintes

* Une personne sans billet ne peut jamais entrer.
* Une personne majeure n'a pas besoin d'accompagnateur.
* Prévoir un message d'erreur si l'âge est invalide.

### Exemple de résultat

**Entrées saisies :** âge `15`, billet `oui`, accompagnateur `oui`

```text
Admission autorisée

Raison : mineur accompagné avec billet valide.
```

### Critères de réussite

* La bonne décision est affichée.
* Les règles sont respectées.
* Les cas invalides sont traités.

### Tests manuels et résultats attendus

| Âge | Billet | Accompagnateur | Résultat attendu    |
| --- | ------ | -------------- | ------------------- |
| 20  | oui    | non            | Admission autorisée |
| 15  | oui    | oui            | Admission autorisée |
| 15  | oui    | non            | Admission refusée   |
| 20  | non    | oui            | Admission refusée   |
| -5  | oui    | oui            | Message d'erreur    |

---

## Exercice 3 - Facture d'une commande en ligne

### Contexte

Une boutique en ligne applique différents frais et rabais selon le montant de la commande et le statut du client.

### Règles

| **Condition**               | **Effet**                      |
| --------------------------- | ------------------------------ |
| Commande inférieure à 25 $  | Frais de livraison de 8 $      |
| Commande de 25 $ ou plus    | Frais de livraison de 5 $      |
| Client Premium              | Livraison gratuite             |
| Commande supérieure à 100 $ | Rabais de 10 % sur la commande |

### Besoins

Crée un programme qui calcule le montant final à payer.

### Valeurs à utiliser

* Montant de la commande : nombre réel positif.
* Client Premium : `oui` ou `non`.

### Notions à utiliser

* calculs numériques;
* structures conditionnelles;
* pourcentage;
* plusieurs `if` dans le même programme.

### Contraintes

* Le rabais doit être appliqué avant d'ajouter les frais de livraison.
* Les frais de livraison ne peuvent jamais être négatifs.
* Prévoir un message d'erreur pour un montant invalide.

### Exemple de résultat

**Entrées saisies :** montant `120`, premium `non`

```text
Montant après rabais : 108 $

Frais de livraison : 5 $

Total à payer : 113 $
```

### Critères de réussite

* Le calcul est exact.
* Les règles sont appliquées dans le bon ordre.
* Les valeurs invalides sont traitées.

### Tests manuels et résultats attendus

| Montant | Premium | Résultat attendu |
| ------- | ------- | ---------------- |
| 120     | non     | Total : 113 $    |
| 120     | oui     | Total : 108 $    |
| 20      | non     | Total : 28 $     |
| 20      | oui     | Total : 20 $     |
| -10     | non     | Message d'erreur |

---

## Exercice 4 - Évaluation de la réussite d'un étudiant

### Contexte

Pour réussir un cours, un étudiant doit satisfaire plusieurs conditions.

### Règles

| **Condition**    | **Valeur minimale** |
| ---------------- | ------------------- |
| Note d'examen    | 60 %                |
| Note des travaux | 60 %                |
| Moyenne finale   | 60 %                |

### Besoins

Crée un programme qui détermine si l'étudiant réussit ou échoue.

Si l'étudiant échoue, le programme doit préciser toutes les conditions non respectées.

### Valeurs à utiliser

* Note d'examen : nombre réel entre 0 et 100.
* Note des travaux : nombre réel entre 0 et 100.
* Moyenne finale : nombre réel entre 0 et 100.

### Notions à utiliser

* plusieurs conditions indépendantes;
* opérateurs logiques;
* structures `if`;
* validation de données.

### Contraintes

* Toutes les conditions doivent être vérifiées.
* Plus d'un message peut être affiché en cas d'échec.
* Prévoir un message d'erreur pour les notes invalides.

### Exemple de résultat

**Entrées saisies :** examen `55`, travaux `70`, moyenne `58`

```text
Résultat : Échec

Conditions non respectées :
- Examen inférieur à 60 %
- Moyenne finale inférieure à 60 %
```

### Critères de réussite

* Toutes les conditions sont vérifiées.
* Les raisons de l'échec sont affichées.
* Les données invalides sont détectées.

### Tests manuels et résultats attendus

| Examen | Travaux | Moyenne | Résultat attendu     |
| ------ | ------- | ------- | -------------------- |
| 75     | 80      | 78      | Réussite             |
| 55     | 70      | 58      | Échec avec 2 raisons |
| 55     | 50      | 55      | Échec avec 3 raisons |
| 60     | 60      | 60      | Réussite             |
| 120    | 70      | 80      | Message d'erreur     |


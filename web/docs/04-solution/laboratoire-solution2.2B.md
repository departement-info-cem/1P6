---
title: "✅ Solutions — Laboratoire 2.2B"
---

# ✅ Solutions — Laboratoire 2.2B

[Retour au laboratoire 2.2B](/laboratoire/laboratoire2.2B)

## Traces d’exécution — résultats de contrôle

Ces résultats servent à vérifier les tableaux de trace remplis sur papier. Ils ne remplacent pas les états intermédiaires ni les branches suivies.

| Exercice | États et affichage attendus |
| --- | --- |
| 1 | `resultat = 14`, puis `a = 28`, puis `b = 25`; aucun affichage. |
| 2 | `resultat = 12`, affichage `12`, puis `resultat = 18`. |
| 3 | Après `x = y`, `x = 5`; puis `y = 7`. Affichage : `5`, puis `7`. |
| 4 | `11 % 2` vaut `1`; le bloc `if` est sauté et `estPair` reste `false`. |
| 5 | `resultat = 10 - 5 = 5`, puis `resultat = 5 + 3 = 8`; affichage `8`. |
| 6 | `8 <= 10` et `paiementEffectue == true` : affichage `Livraison acceptée`. |
| 7 | Le majeur ajoute `10`; l’expérience ajoute `20`; le diplôme n’ajoute rien. Affichage `30`. |

## Exercice 1 — Affectations successives

| Ligne | `a` | `b` | `resultat` | Explication |
| ---: | ---: | ---: | ---: | --- |
| 1 | 10 | — | — | Initialisation de `a` |
| 2 | 10 | 4 | — | Initialisation de `b` |
| 3 | 10 | 4 | 14 | Addition des valeurs courantes |
| 4 | 28 | 4 | 14 | `a` reçoit `14 × 2` |
| 5 | 28 | 25 | 14 | `b` reçoit `28 - 3` |

Aucun affichage : modifier une variable ne l'affiche pas.

## Exercice 2 — Priorité des opérations

| Ligne | `a` | `b` | `c` | `resultat` | Affichage |
| ---: | ---: | ---: | ---: | ---: | --- |
| 1 | 6 | — | — | — | — |
| 2 | 6 | 3 | — | — | — |
| 3 | 6 | 3 | 2 | — | — |
| 4 | 6 | 3 | 2 | 12 | — |
| 5 | 6 | 3 | 2 | 12 | `12` |
| 6 | 6 | 3 | 2 | 18 | — |

La multiplication précède l'addition à la ligne 4. Les parenthèses imposent l'addition d'abord à la ligne 6; cette dernière valeur n'est pas affichée.

## Exercice 3 — Copier une valeur

| Ligne | `x` | `y` | Affichage |
| ---: | ---: | ---: | --- |
| 1 | 10 | — | — |
| 2 | 10 | 5 | — |
| 3 | 5 | 5 | — |
| 4 | 5 | 7 | — |
| 5 | 5 | 7 | `5` |
| 6 | 5 | 7 | `7` |

`x = y` copie la valeur courante de `y`; les deux variables ne restent pas liées.

## Exercice 4 — Condition fausse

| Ligne | `a` | `estPair` | Condition / action |
| ---: | ---: | --- | --- |
| 1 | 11 | — | Initialisation |
| 2 | 11 | `false` | Initialisation |
| 4 | 11 | `false` | `11 % 2 == 0` est faux |
| 6 | 11 | `false` | Ligne sautée |

Aucun affichage. Le booléen ne change pas, car son affectation se trouve dans le bloc non exécuté.

## Exercice 5 — Deux choix successifs

| Ligne | `a` | `b` | `resultat` | Condition / action |
| ---: | ---: | ---: | ---: | --- |
| 1 | 10 | — | — | Initialisation |
| 2 | 10 | 5 | — | Initialisation |
| 3 | 10 | 5 | Non affecté | Déclaration |
| 4 | 10 | 5 | Non affecté | `10 > 5` est vrai |
| 6 | 10 | 5 | 5 | `10 - 5` |
| 10 | 10 | 5 | 5 | Branche `else` sautée |
| 12 | 10 | 5 | 5 | `5 >= 10` est faux |
| 14 | 10 | 5 | 5 | Ligne sautée |
| 18 | 10 | 5 | 8 | `5 + 3` |
| 20 | 10 | 5 | 8 | Affichage `8` |

## Exercice 6 — Conditions imbriquées

| Ligne | `distance` | `paiementEffectue` | Condition / affichage |
| ---: | ---: | --- | --- |
| 1 | 8 | — | Initialisation |
| 2 | 8 | `true` | Initialisation |
| 3 | 8 | `true` | `8 <= 10` est vrai |
| 5 | 8 | `true` | Paiement vrai |
| 7 | 8 | `true` | `Livraison acceptée` |
| 11 | 8 | `true` | Branche interne sautée |
| 16 | 8 | `true` | Branche externe sautée |

## Exercice 7 — Accumuler sous conditions

| Ligne | `score` | Condition / action |
| ---: | ---: | --- |
| 1 | 0 | Initialisation |
| 2 à 4 | 0 | `age = 22`, `aUneExperience = true`, `aUnDiplome = false` |
| 6 | 0 | `22 >= 18` est vrai |
| 8 | 10 | Ajout de `10` |
| 10 | 10 | Expérience vraie |
| 12 | 30 | Ajout de `20` |
| 16 | 30 | Branche `else` sautée |
| 19 | 30 | Diplôme faux |
| 21 | 30 | Ligne sautée |
| 24 | 30 | Affichage `30` |

Les numéros indiquent les lignes de l'énoncé; les accolades ne changent aucune valeur.

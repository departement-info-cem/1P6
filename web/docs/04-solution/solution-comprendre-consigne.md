---
title: 🏆 Solution - Comprendre un mandat
---

# 🏆 Solution — Compréhension : La commande de chandails

Les formulations peuvent varier. Une réponse est valide lorsqu'elle conserve le sens du mandat et qu'elle peut être justifiée par le texte.

## 1. Reformuler le besoin

L'application doit calculer et présenter le montant d'une commande de chandails en appliquant la réduction prévue selon la quantité.

## 2. Classer les informations

| Catégorie | Informations repérées dans le mandat |
| --- | --- |
| Informations à saisir | Le prénom, la taille et la quantité de chandails. |
| Résultats à afficher | Le prénom, la taille, la quantité, le sous-total, la réduction et le total. |
| Règles et limites | Un chandail coûte `32,00 $`; la quantité va de `1` à `5`; à partir de trois chandails, la réduction est de `10 %`; une quantité invalide produit une erreur sans total. |
| Information de contexte qui ne doit pas être saisie | La couleur bleu marine est déjà choisie. Les taxes sont traitées séparément. |

## 3. Vérifier ce qui est réellement écrit

1. **Vrai.** « Au moins trois chandails » comprend exactement trois chandails.
2. **Faux.** La couleur bleu marine est déjà choisie par le comité.
3. **Faux.** Le mandat précise que les taxes ne font pas partie de l'application.
4. **Impossible à déterminer.** Le mandat limite les tailles à `P`, `M` et `G`, mais il ne précise pas quoi faire lorsqu'une autre taille est saisie.

## 4. Repérer une ambiguïté

Une question possible serait : « Que doit faire l'application si la taille saisie n'est ni `P`, ni `M`, ni `G`? »

D'autres questions sont acceptables lorsqu'elles portent sur une information réellement absente du mandat.

## 5. Prévoir un résultat

Pour trois chandails :

- sous-total : `3 × 32,00 $ = 96,00 $`;
- réduction : `10 % de 96,00 $ = 9,60 $`;
- total : `96,00 $ - 9,60 $ = 86,40 $`.

La taille et le prénom doivent apparaître dans le résultat, mais ils ne changent pas le calcul.

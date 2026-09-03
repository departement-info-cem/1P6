---
title: 🏆 Solution - Analyser un problème
---

# 🏆 Solution — Analyse : Le prêt d'équipement

Les formulations et les cas d'essai peuvent varier. Les réponses doivent toutefois respecter toutes les règles du mandat.

## 1. Définir le problème

L'application doit calculer le montant d'un prêt d'équipement selon le type choisi, la durée et le statut de membre, puis présenter le détail du montant à payer.

## 2. Construire le contrat de l'application

| Élément | Analyse attendue |
| --- | --- |
| Données reçues par l'application | Le type d'équipement, la durée du prêt et le statut de membre. |
| Résultats produits | Le coût avant réduction, la réduction, le dépôt et le total à payer, ou un message d'erreur. |
| Règles de calcul | Raquettes : `6,00 $` par jour; bâtons : `9,00 $` par jour; réduction de `20 %` pour un membre; dépôt de `25,00 $` ajouté après la réduction et jamais réduit. |
| Valeurs refusées | Une durée inférieure à `1` ou supérieure à `7`. |
| Information qui ne fait pas partie de l'application | Les conditions de retour déjà présentées sur le site Web. |

## 3. Ordonner les résultats

1. Déterminer le coût de location avant réduction.
2. Déterminer la réduction à partir du coût de location et du statut de membre.
3. Déterminer le dépôt de `25,00 $`.
4. Déterminer le total : coût de location moins réduction, puis ajout du dépôt.

La réduction dépend du coût de location. Le total dépend ensuite du coût, de la réduction et du dépôt.

## 4. Préparer des cas d'essai

Voici quatre exemples; seulement trois étaient demandés.

| Équipement | Durée | Membre | Résultats attendus |
| --- | ---: | --- | --- |
| Raquettes | 2 jours | Non | Coût `12,00 $`; réduction `0,00 $`; dépôt `25,00 $`; total `37,00 $`. |
| Bâtons | 3 jours | Oui | Coût `27,00 $`; réduction `5,40 $`; dépôt `25,00 $`; total `46,60 $`. |
| Raquettes | 7 jours | Oui | Coût `42,00 $`; réduction `8,40 $`; dépôt `25,00 $`; total `58,60 $`. |
| Bâtons | 0 jour | Non | Message d'erreur et aucun montant présenté. |

## 5. Repérer ce qui manque

Une question possible serait : « Que doit faire l'application si le type d'équipement saisi n'est pas reconnu? »

Le mandat explique les durées invalides, mais pas les types d'équipement invalides. Une autre question est acceptable si sa réponse n'est pas déjà présente dans le texte.

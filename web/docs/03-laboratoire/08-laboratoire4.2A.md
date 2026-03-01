---
title: Gestion d'inventaire
---

# 🧪 Labo 4.2A – Intègration

---
:::danger
Ce laboratoire doit être développé à l'aide du logiciel **Git**. Vous devrez **créer un nouveau dépôt dans GitHub** 
et **inviter votre professeur** en tant que collaborateur.

Voici le format du dépôt exigé: **H26-2P6-R08-MATRICULE**

Il devrait y avoir **un commit** pour **chaque** exercice.

:::
---
### Télécharger la solution contenant les différents exercices de ce laboratoire.

Disponible ici 👉 [Laboratoire4_2](../../static/files/laboratoires/Laboratoire4_2.zip)

---
    
## 🟡 Exercice A – Inventaire
### 🎯 Objectifs 
* Instanciation et utilisation d'un objet
* Manipulation des listes d'objets
* Lecture / écriture de fichiers csv
* Utilisation des énumérations
* Parcours avec `foreach`
* Définition de méthodes

### 🛠️ Instructions
Dans cet exercice, on vous fournit la classe `Produit` ainsi que le menu principal du programme.

Votre travail consiste à :
* **implémenter les méthodes de gestion de l’inventaire** dans la classe `Program`.
* **Compléter** le **menu** en appelant les méthodes au bon endroit!

Ces méthodes manipulent une liste de `Produit` et permettent de charger, filtrer, afficher et sauvegarder des données.

---

### 📊 Diagramme de classes

La classe `Produit` et le type par énumération `Categorie` sont fournies. Il ne faut pas les modifier. 

La classe est déjà documentée dans le code. Vous devez l'observer et la comprendre. Cette étape vous permet de savoir quelles propriétés et méthodes sont disponibles pour l’utiliser correctement dans le reste du programme.

![](@site/static/img/R08/inventaire.png)

---
### 🧩 Méthodes à implémenter
#### 1️⃣ `Inventaire`

Charger les produits depuis un fichier CSV et les retourner sous forme d’une liste.
##### 📥 Paramètre

* chemin du fichier contenant les produits.
##### 📤 Retour

* Liste de produits.

##### 📝 Constraintes
* Vérifier si le fichier existe.
* Si le fichier n’existe pas, retourner une liste vide et afficher un message.
---
#### 2️⃣ `Afficher`
Afficher tous les produits d’une liste sur la console.

##### 📥 Paramètre

* liste des produits à afficher.

##### 📝 Contraintes

* Si la liste est vide, afficher :
  `"Inventaire vide."`
* Utiliser la méthode `Etat()` de la classe `Produit`.

---

#### 3️⃣ `ProduitsCritiques`

##### 🎯 Objectif

Retourner uniquement les produits dont le stock est critique.

###### 📥 Paramètre

* liste complète des produits.

###### 📤 Retour

* liste de produits

###### 📝 Contraintes

* Utiliser une boucle
* Utiliser la propriété `StockCritique`.

---

#### 4️⃣ `ProduitsParCategorie`

##### 🎯 Objectif

Filtrer les produits selon une catégorie donnée.

##### 📥 Paramètres

* liste complète des produits.
* catégorie à filtrer (`ALIMENTAIRE`, `ELECTRONIQUE`, `VETEMENT`).

##### 📤 Retour

* liste de produit

##### 📝 Contraintes

* Utiliser une boucle.
---

##### 5️⃣ `Sauvegarder`

###### 🎯 Objectif

Sauvegarder les produits dans un fichier.

###### 📥 Paramètres

* liste des produits à sauvegarder.
* chemin du fichier de destination.

###### 📝 Contraintes

* Vérifier si le chemin du fichier est invalide.
* Si le le chemin est invalide, afficher un message.
* Utiliser la méthode `Info()` de la classe `Produit`.
* Afficher un message confirmant la sauvegarde.

---
### ⭐ Exemples d'exécution

**Menu**
```
===== MENU INVENTAIRE =====
1. Charger inventaire
2. Afficher inventaire
3. Afficher produits critiques            
4. Afficher par catégorie
5. Sauvegarder produits critiques
6. Quitter et sauvegarder
Choix :
```
**Afficher l'inventaire**
```
Pain | 2,50 $ | Qté: 50 | ALIMENTAIRE | Stock OK
Lait | 3,20 $ | Qté: 8 | ALIMENTAIRE | ? STOCK CRITIQUE
Fromage | 6,75 $ | Qté: 5 | ALIMENTAIRE | ? STOCK CRITIQUE
Laptop | 1 200,00 $ | Qté: 3 | ELECTRONIQUE | ? STOCK CRITIQUE
Souris | 25,00 $ | Qté: 15 | ELECTRONIQUE | Stock OK
Telephone | 800,00 $ | Qté: 2 | ELECTRONIQUE | ? STOCK CRITIQUE
T-Shirt | 25,00 $ | Qté: 40 | VETEMENT | Stock OK
Jean | 60,00 $ | Qté: 9 | VETEMENT | ? STOCK CRITIQUE
Manteau | 150,00 $ | Qté: 4 | VETEMENT | ? STOCK CRITIQUE
```
**Afficher les produits critiques**
```
Lait | 3,20 $ | Qté: 8 | ALIMENTAIRE | ? STOCK CRITIQUE
Fromage | 6,75 $ | Qté: 5 | ALIMENTAIRE | ? STOCK CRITIQUE
Laptop | 1 200,00 $ | Qté: 3 | ELECTRONIQUE | ? STOCK CRITIQUE
Telephone | 800,00 $ | Qté: 2 | ELECTRONIQUE | ? STOCK CRITIQUE
Jean | 60,00 $ | Qté: 9 | VETEMENT | ? STOCK CRITIQUE
Manteau | 150,00 $ | Qté: 4 | VETEMENT | ? STOCK CRITIQUE
```
**Afficher les produits critiques**
```
******Liste des produits alimentaires !******
Pain | 2,50 $ | Qté: 50 | ALIMENTAIRE | Stock OK
Lait | 3,20 $ | Qté: 8 | ALIMENTAIRE | ? STOCK CRITIQUE
Fromage | 6,75 $ | Qté: 5 | ALIMENTAIRE | ? STOCK CRITIQUE
******Liste des produits éléctroniques !******
Laptop | 1 200,00 $ | Qté: 3 | ELECTRONIQUE | ? STOCK CRITIQUE
Souris | 25,00 $ | Qté: 15 | ELECTRONIQUE | Stock OK
Telephone | 800,00 $ | Qté: 2 | ELECTRONIQUE | ? STOCK CRITIQUE
******Liste des produits vétements !******
T-Shirt | 25,00 $ | Qté: 40 | VETEMENT | Stock OK
Jean | 60,00 $ | Qté: 9 | VETEMENT | ? STOCK CRITIQUE
Manteau | 150,00 $ | Qté: 4 | VETEMENT | ? STOCK CRITIQUE
```


---
description: Fonctionnement du cours, Visual Studio et programmer en console
---

# Introduction au cours 🏁
### 🌐 Connexion au réseau du collège

#### 🧭 Plateforme pédagogique

Ceci est le site principal du cours ([1P6](https://info.cegepmontpetit.ca/1P6/)).

### 💬 Plateforme LÉA, MIO et Teams

Accès via : [Omnivox - Cégep Édouard-Montpetit](https://cegepmontpetit.omnivox.ca/Login/Account/Login?ReturnUrl=%2fintr)

- Identifiant : *matricule@cegepmontpetit.ca*  (matricule = 7 chiffres)
- 📘 LÉA : consulter vos notes
- ✉️ MIO : communiquer avec vos professeurs
- 💻 Teams : échanges, aide à distance et communications avec les enseignants

### 🗂️ Plan et organisation du cours

- Structure des rencontres hebdomadaires
- Utilisation du site web comme support principal
- Exercices pratiques intégrés au site
- Accès aux ressources supplémentaires (Notions C#)

#### 📜 Règles et politiques du cours :

- 🧮 Barème d’évaluation (double seuil)
- ⏰ Politique vis-à-vis les retards / absences
- 📅 Remise des travaux
- 🧑‍🤝‍🧑 Plagiat vs entraide
- 📵 Cellulaire en classe
- 👩‍🏫 Disponibilité des enseignants / Centre d’aide

### 🧪 Démonstration de l'utilisation du site web Notions C#

Accès via : <a href="https://info.cegepmontpetit.ca/notions-csharp/" target="_blank" rel="noopener noreferrer">Notions C#</a>


👉 Consultez particulièrement la section [Bien débuter](https://info.cegepmontpetit.ca/notions-csharp/bien-debuter) pour installer les logiciels nécessaires et découvrir les outils recommandés pour suivre le cours efficacement.

### 💽 Installation de Visual Studio (pour le travail à la maison)

Voir la procédure ici : [Installation de Visual Studio](https://info.cegepmontpetit.ca/notions-csharp/bien-debuter/installation-des-logiciels/visual-studio)

### À propos du Centre des services adaptés (CSA)

Les étudiants ayant un diagnostic peuvent faire une demande de mesures adaptées :
- Envoyer le diagnostic par MIO à **"Service, CSA"** ou par courriel à **servicesaadaptes@cegepmontpetit.ca**
- Si vous avez déjà un plan, communiquez avec votre professeur en début de session

## Service de tutorat

### Conditions d’achèvement

**Tutorat par les pairs (Le Phare)**  
📍 Local E-026

Tu éprouves des difficultés dans certaines matières et tu sens qu'un coup de pouce serait bénéfique?  
N'hésite pas à t'inscrire au tutorat pour des rencontres individuelles. Tu seras jumelé avec un autre étudiant qui a déjà réussi le cours.  

Le tuteur peut :
- te donner des explications supplémentaires
- répondre à tes questions
- t'aider à améliorer tes méthodes de travail

🎓 Ce service est **gratuit**.  
🕘 Présente-toi au local **E-026** pour prendre rendez-vous.

---
## 🧠 Théorie Rencontre 1

Voici les documents de référence :

- [Algorithmie](https://info.cegepmontpetit.ca/notions-csharp/documentation/algorithmie) : l’étude des procédures et étapes pour résoudre des problèmes informatiques.
- [Résolution de problèmes](https://info.cegepmontpetit.ca/notions-csharp/documentation/algorithmie/resolution-de-problemes) : guide structuré en 7 étapes, du besoin utilisateur au test final.
- [Programme et langage](https://info.cegepmontpetit.ca/notions-csharp/documentation/algorithmie/programme-et-langage) : introduction au concept de programme écrit en langage formel (C#) compilable par la machine.
- [Application console en C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/console) : explication des concepts et fonctionnement d’un programme console minimal en C#, incluant l’entrée/sortie utilisateur.
- [Commentaires en C#](https://info.cegepmontpetit.ca/notions-csharp/documentation/commentaire) : comment documenter le code avec des commentaires simples, multilignes ou XML.

## Lecture et affichage console

Les interactions avec l'utilisateur en mode console se font avec deux méthodes principales : `Console.WriteLine()` et `Console.ReadLine()`.

### 🖨️ Affichage avec `Console.WriteLine()`
Affiche un message dans la console et passe à la ligne suivante.
```csharp
Console.WriteLine("Bienvenue dans le programme !");
```

### 🖊️ Affichage sans retour à la ligne : `Console.Write()`
Utile pour inviter l'utilisateur à écrire une réponse sur la même ligne.
```csharp
Console.Write("Entrez votre nom : ");
```

### ⌨️ Lecture de l’entrée avec `Console.ReadLine()`
Lit un texte entré par l'utilisateur (toujours une `string`, c'est un type de **variable** (voir rencontre 2)).
```csharp
string nom = Console.ReadLine();
```

### 🧠 Exemple complet
```csharp
Console.Write("Quel est ton prénom ? ");
string prenom = Console.ReadLine();
Console.WriteLine("Bonjour, " + prenom + "!");
```

### ⚠️ Attention
`Console.ReadLine()` retourne toujours un **texte (string)**, même si l’utilisateur tape un chiffre. Pour l’utiliser comme un nombre, il faut le **convertir** (voir rencontre 2).


## 💪 Exercice

Vous devez réaliser les labos suivants :
 [🧪 Labo 1.1A](/laboratoire/laboratoire1.1)
 [🧪 Labo 1.1B](/laboratoire/laboratoire1.1B)

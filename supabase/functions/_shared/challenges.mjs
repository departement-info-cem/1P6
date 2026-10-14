// Les attentes sont volontairement centrées sur le résultat observable.
// Le classement sert à pratiquer, pas à attribuer une note de cours.
export const challenges = {
  "affichage-chaines": {
    tests: [{ name: "Billet d'accueil", contains: ["nom", "alex tremblay", "groupe", "1090", "local", "b-321", "debut", "8 h 00"] }],
  },
  "variables-calculs": {
    tests: [
      { name: "Commande de 8 pages", input: "4\n2\n0,15\n", contains: ["pages imprimees : 8", "cout total : 1,2"] },
      { name: "Commande de 10 pages", input: "10\n1\n0,20\n", contains: ["pages imprimees : 10", "cout total : 2"] },
      { name: "Autre commande", input: "3\n4\n0,10\n", contains: ["pages imprimees : 12", "cout total : 1,2"] },
    ],
  },
  conditions: {
    tests: [
      { name: "Enfant", input: "5\n", contains: ["tarif applicable : gratuit"] },
      { name: "Jeune", input: "16\n", contains: ["tarif applicable : 8"] },
      { name: "Étudiant", input: "20\noui\n", contains: ["tarif applicable : 10"] },
      { name: "Adulte", input: "20\nnon\n", contains: ["tarif applicable : 14"] },
      { name: "Aîné", input: "72\n", contains: ["tarif applicable : 9"] },
      { name: "Âge impossible", input: "-1\n", containsAny: ["invalide", "impossible", "erreur"], notContains: ["tarif applicable"] },
    ],
  },
  fonctions: {
    tests: [
      { name: "Petite sans livraison", input: "P\n0\nnon\n", contains: ["pizza et garnitures : 12,00", "frais de livraison : 0,00", "total a payer : 13,80"] },
      { name: "Grande livrée", input: "G\n3\noui\n", contains: ["pizza et garnitures : 22,50", "frais de livraison : 5,00", "total a payer : 31,62"] },
      { name: "Petite livrée", input: "P\n2\noui\n", contains: ["pizza et garnitures : 15,00", "total a payer : 23,00"] },
    ],
  },
  "integration-conditions-fonctions": {
    tests: [
      { name: "Bonne participation", input: "Revision de C#\n4\n1\n", contains: ["personnes inscrites : 5", "presence : 80", "bonne participation"] },
      { name: "Participation limitée", input: "Aide aux devoirs\n0\n3\n", contains: ["personnes inscrites : 3", "presence : 0", "participation limitee"] },
      { name: "Excellente participation", input: "Preparation a l'examen\n3\n0\n", contains: ["personnes inscrites : 3", "presence : 100", "excellente participation"] },
    ],
  },
  "boucle-for": {
    tests: [
      { name: "Quatre trousses", input: "4\n4\n", contains: ["total d'articles prepares : 16"], lines: ["1 4", "2 8", "3 12", "4 16"] },
      { name: "Une trousse", input: "6\n1\n", contains: ["total d'articles prepares : 6"], lines: ["1 6"] },
      { name: "Valeur nulle", input: "0\n4\n", contains: ["valeurs doivent etre superieures a 0"], notContains: ["total d'articles prepares"] },
      { name: "Valeur négative", input: "4\n-1\n", contains: ["valeurs doivent etre superieures a 0"], notContains: ["total d'articles prepares"] },
    ],
  },
  "tableaux-1d": {
    tests: [{ name: "Bilan de la semaine", contains: ["jour 1 : 18", "jour 7 : 16", "minimale : 16", "maximale : 25", "moyenne de la semaine : 20,00", "20", "plus : 4", "plus chaude : jour 5"] }],
  },
  "integration-tableaux-1d": {
    tests: [{ name: "Bilan de Uno", contains: ["amelie : 12", "bilal : 19", "chloe : 19", "meilleur resultat : bilal", "moyenne : 16,67", "15 points ou plus : 2"] }],
  },
  "tableaux-2d": {
    tests: [{ name: "Plan de salle", contains: ["sieges libres : 15", "rangee 1 : 2", "rangee 2 : 3", "rangee 3 : 1", "rangee 4 : 3", "plus de sieges libres : rangee 3"] }],
  },
  "switch-boucles-conditionnelles": {
    tests: [
      { name: "Celsius", input: "1\n0\n0\n", contains: ["resultat : 32,00"] },
      { name: "Kilomètres", input: "2\n10\n0\n", contains: ["resultat : 6,21"] },
      { name: "Dollars", input: "3\n100\n0\n", contains: ["resultat : 72,00"] },
      { name: "Choix invalide", input: "9\n0\n", containsAny: ["choix invalide", "choix est invalide", "choix inexistant"] },
    ],
  },
  "integration-menus-tableaux-2d": {
    tests: [
      { name: "Totaux des robots", input: "2\n0\n", contains: ["alpha : 36", "beta : 35", "gamma : 36", "delta : 37", "plus performant : delta"] },
      { name: "Meilleures notes", input: "3\n0\n", contains: ["vitesse : 15", "precision : 16", "endurance : 14"] },
      { name: "Seuil invalide", input: "4\n21\n0\n", containsAny: ["invalide", "entre 0 et 20"] },
    ],
  },
};

export const challengeIds = Object.keys(challenges);

export function normalize(value) {
  return String(value ?? "")
    .normalize("NFD").replace(/[\u0300-\u036f]/g, "")
    .toLowerCase().replace(/\s+/g, " ").trim();
}

export function checkResult(test, stdout) {
  const text = normalize(stdout);
  if ((test.contains || []).some((item) => !text.includes(normalize(item)))) return false;
  if (test.containsAny && !test.containsAny.some((item) => text.includes(normalize(item)))) return false;
  if ((test.notContains || []).some((item) => text.includes(normalize(item)))) return false;
  if ((test.lines || []).some((line) => !normalize(stdout).includes(normalize(line)))) return false;
  return true;
}

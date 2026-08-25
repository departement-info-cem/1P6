// Contrôle centralisé de la publication des solutions de défis.
const solutionsDefis = require("./src/data/solutions-defis.json");

function entreeSidebarSolutionDefi(id) {
  const solution = solutionsDefis.find((item) => item.id === id);

  if (!solution) {
    throw new Error(`Solution de défi inconnue : ${id}`);
  }

  return solution.publie ? [solution.id] : [];
}

function fichiersSolutionsDefisCaches() {
  return solutionsDefis
    .filter((solution) => !solution.publie)
    .map((solution) => solution.fichier);
}

module.exports = {
  entreeSidebarSolutionDefi,
  fichiersSolutionsDefisCaches,
};

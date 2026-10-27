// React 18 peut insérer des NUL aux frontières de blocs UTF-8 pendant le rendu
// serveur. Ces caractères sont interdits dans le HTML et cassent les ancres.
// https://github.com/facebook/docusaurus/issues/9985
const fs = require("node:fs/promises");
const path = require("node:path");

module.exports = function htmlIntegrity() {
  return {
    name: "html-integrity",
    async postBuild({ outDir }) {
      let removed = 0;
      async function inspect(directory) {
        for (const entry of await fs.readdir(directory, { withFileTypes: true })) {
          const file = path.join(directory, entry.name);
          if (entry.isDirectory()) {
            await inspect(file);
          } else if (entry.isFile() && entry.name.endsWith(".html")) {
            const html = await fs.readFile(file, "utf8");
            const count = (html.match(/\u0000/g) || []).length;
            if (count) {
              await fs.writeFile(file, html.replace(/\u0000/g, ""), "utf8");
              removed += count;
            }
          }
        }
      }
      await inspect(outDir);
      if (removed) console.info(`[html-integrity] ${removed} caractère(s) NUL de rendu supprimé(s).`);
    },
  };
};

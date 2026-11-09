// Plugin Docusaurus : permet aux pages d'importer le Markdown de code/examens/.
// Par défaut, Docusaurus ne compile que le Markdown situé dans docs/.
const path = require("path");
const { createMDXLoaderRule } = require("@docusaurus/mdx-loader");

module.exports = function pluginMarkdownExamens(context) {
  const { siteDir, siteConfig } = context;
  const dossier = path.resolve(siteDir, "../code/examens") + path.sep;

  return {
    name: "docusaurus-plugin-markdown-examens",
    async configureWebpack() {
      const regle = await createMDXLoaderRule({
        include: [dossier],
        options: {
          siteDir,
          staticDirs: siteConfig.staticDirectories.map((d) => path.resolve(siteDir, d)),
          markdownConfig: siteConfig.markdown,
          admonitions: true,
          // Ces fichiers sont importés dans une page : ils n'en sont pas une eux-mêmes.
          isMDXPartial: () => true,
        },
      });
      return { module: { rules: [regle] } };
    },
  };
};

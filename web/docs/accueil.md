---
sidebar_position: 1
slug: /
hide_table_of_contents: true
---

# Accueil

<Row>

<Column>

Bienvenue au cours de 2P6 - Programmation orientée objet! Dans ce cours, tu apprendras la programmation orientée objet à l'aide du language C#.

Le contenu des cours ainsi que les énoncés de TP sont disponibles dans les onglets **[Cours](cours/introduction)** et **[Travaux Pratiques](tp/tp1)**. Tu trouveras également les exercices et les solutions aux exercices dans les onglets **[Laboratoires](laboratoire/laboratoire1.1)** et **[Solutions](solution/Laboratoire-Solution)**

:::info Installation à la maison

Voir la procédure ici : [Installation de Visual Studio](https://info.cegepmontpetit.ca/notions-csharp/bien-debuter/installation-des-logiciels/visual-studio)

:::

</Column>

<Column>

:::danger Plagiat

Les exercices peuvent être réalisés à plusieurs. Par contre, tous les travaux **évalués** sont **INDIVIDUELS**.

Lis les règles concernant le plagiat et les sanctions **[ici](https://info.cegepmontpetit.ca/plagiat)**

:::

:::tip Documentation du cours

La matière est expliquée dans chacun des cours, mais tu peux trouver plus d'information sur le site de <a href="https://info.cegepmontpetit.ca/notions-csharp/" target="_blank" rel="noopener noreferrer">Notions C#</a>.


👉 Consultez particulièrement la section [Bien débuter](https://info.cegepmontpetit.ca/notions-csharp/bien-debuter/) pour installer les logiciels nécessaires et découvrir les outils recommandés pour suivre le cours efficacement.

:::

</Column>

</Row>

<DocsViewer
    tabs={[
        {
            id: "grid",
            label: "Liste",
            icon: "📋",
            component: <MainDocsGrid />,
        },
        {
            id: "calendar-david",
            label: "David",
            icon: "📅",
            component: <MainDocsCalendar professorName="David" />,
        },       
        {
            id: "calendar-jamil",
            label: "Jamil",
            icon: "📅",
            component: <MainDocsCalendar professorName="Jamil" />,
        },       
        {
            id: "calendar-philippe",
            label: "Philippe",
            icon: "📅",
            component: <MainDocsCalendar professorName="Philippe" />,
        },
        {
            id: "calendar-jimmy",
            label: "Jimmy",
            icon: "📅",
            component: <MainDocsCalendar professorName="Jimmy" />,
        },
    ]}
    defaultTabId="grid"
/>

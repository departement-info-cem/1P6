---
sidebar_position: 1
slug: /
hide_table_of_contents: true
---

# Accueil

<Row>

<Column>

Bienvenue au cours de 1P6 - Introduction à la programmation! Dans ce cours, tu apprendras la programmation à l'aide du language C#.

Le contenu des cours ainsi que les énoncés de TP sont disponibles dans les onglets **[Cours](cours/introduction)** et **[Travaux Pratiques](tp/tp1)**. Tu trouveras également les exercices et les solutions aux exercices dans les onglets **[Laboratoires](laboratoire/laboratoire1.1)** et **[Solutions](solution/Laboratoire-Solution1.1)**

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
        id: "cours",
        label: "Planification des rencontres",
        icon: "⭐",
        component: <MainDocsGrid />,
    }, 
    {
        id: "eric", label: "Éric", icon: "👾",
        component: <div><DocsViewer
            tabs={[
                { id: "horaire", label: "Horaire", icon: "💼",
                    component: <WeeklySchedule title="Horaire d'Éric Mathieu"
                                               dataUrl="/horaire_a26_eric.json" /> },
                { id: "calendrier", label: "Calendrier", icon: "📅",
                    component: <MainDocsCalendar professorName="Éric" /> },
            ]} defaultTabId="horaire" /> </div> 
    },
    {
        id: "jamil", label: "Jamil", icon: "🪈",
        component: <div><DocsViewer
            tabs={[
                { id: "horaire", label: "Horaire", icon: "💼",
                    component: <WeeklySchedule title="Horaire de Jamil Gammoudi"
                                               dataUrl="/horaire_a26_jamil.json" /> },
                { id: "calendrier", label: "Calendrier", icon: "📅",
                    component: <MainDocsCalendar professorName="Jamil" /> },
            ]} defaultTabId="horaire" /> </div> 
    },
    {
        id: "jeanmichel", label: "Jean-Michel", icon: "😺",
        component: <div><DocsViewer
            tabs={[
                { id: "horaire", label: "Horaire", icon: "💼",
                    component: <WeeklySchedule title="Horaire de Jean-Michel Nadeau" 
                                               dataUrl="/horaire_a26_jeanmichel.json" /> },
                { id: "calendrier", label: "Calendrier", icon: "📅",
                    component: <MainDocsCalendar professorName="Jean-Michel" /> },
            ]} defaultTabId="horaire" /> </div> 
    },
    {
        id: "sebastien", label: "Sébastien", icon: "🕹️",
        component: <div><DocsViewer
            tabs={[
                { id: "horaire", label: "Horaire", icon: "💼",
                    component: <WeeklySchedule title="Horaire de Sébastien Derumière"
                                               dataUrl="/horaire_a26_sebastien.json" /> },
                { id: "calendrier", label: "Calendrier", icon: "📅",
                    component: <MainDocsCalendar professorName="Sébastien" /> },
            ]} defaultTabId="horaire" /> </div> 
    },
    {
        id: "pierrepaul", label: "Pierre-Paul", icon: "🎲",
        component: <div><DocsViewer
            tabs={[
                { id: "horaire", label: "Horaire", icon: "💼",
                    component: <WeeklySchedule title="Horaire de Pierre-Paul Gallant"
                                               dataUrl="/horaire_a26_pierrepaul.json" /> },
                { id: "calendrier", label: "Calendrier", icon: "📅",
                    component: <MainDocsCalendar professorName="Pierre-Paul" /> },
            ]} defaultTabId="horaire" /> </div> 
    },
    ]}
    defaultTabId="cours"
/>

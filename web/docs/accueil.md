---
title: Accueil
sidebar_position: 1
slug: /
hide_table_of_contents: true
hide_title: true
---

<CourseHome />

## Parcours des rencontres {#parcours}

Choisis une rencontre pour consulter ses notes. Les horaires et calendriers de chaque professeur sont accessibles dans les onglets ci-dessous.

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

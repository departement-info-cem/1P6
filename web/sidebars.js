// @ts-check

let currentDate = new Date();
let month = currentDate.getMonth() + 1;

let collapseBloc1 = !(month <= 9);
let collapseBloc2 = !(month >= 9 && month <= 11);
let collapseBloc3 = !(month >= 11);

const g1010 = [
  "2026-08-24",
  "2026-08-27",
  "2026-08-31",
  "2026-09-03",
  "2026-09-10",
  "2026-09-14",
  "2026-09-17",
  "2026-09-21",
  "2026-09-24",
  "2026-09-28",
  "2026-10-01",
  "2026-10-06",
  "2026-10-08",
  "2026-10-19",
  "2026-10-22",
  "2026-10-26",
  "2026-10-29",
  "2026-11-02",
  "2026-11-05",
  "2026-11-09",
  "2026-11-12",
  "2026-11-16",
  "2026-11-19",
  "2026-11-23",
  "2026-11-26",
  "2026-11-30",
  "2026-12-03",
  "2026-12-07",
  "2026-12-14",
  "2026-12-17"
];

const g1020 = [...g1010];

const g1030 = [
  "2026-08-25",
  "2026-08-28",
  "2026-09-01",
  "2026-09-04",
  "2026-09-08",
  "2026-09-11",
  "2026-09-15",
  "2026-09-18",
  "2026-09-22",
  "2026-09-25",
  "2026-09-29",
  "2026-10-02",
  "2026-10-09",
  "2026-10-20",
  "2026-10-23",
  "2026-10-27",
  "2026-10-30",
  "2026-11-03",
  "2026-11-06",
  "2026-11-10",
  "2026-11-13",
  "2026-11-17",
  "2026-11-20",
  "2026-11-24",
  "2026-12-01",
  "2026-12-04",
  "2026-12-08",
  "2026-12-11",
  "2026-12-15",
  "2026-12-18"
];

const g1040 = [...g1030];

const g1050 = [
  "2026-08-25",
  "2026-08-27",
  "2026-09-01",
  "2026-09-03",
  "2026-09-08",
  "2026-09-10",
  "2026-09-15",
  "2026-09-17",
  "2026-09-22",
  "2026-09-24",
  "2026-09-29",
  "2026-10-01",
  "2026-10-08",
  "2026-10-20",
  "2026-10-22",
  "2026-10-27",
  "2026-10-29",
  "2026-11-03",
  "2026-11-05",
  "2026-11-10",
  "2026-11-12",
  "2026-11-17",
  "2026-11-19",
  "2026-11-24",
  "2026-11-26",
  "2026-12-01",
  "2026-12-03",
  "2026-12-08",
  "2026-12-15",
  "2026-12-17"
];

const g1060 = [...g1050];

const g1070 = [...g1010];

const g1080 = [...g1010];

const g1090 = [
  "2026-08-24",
  "2026-08-26",
  "2026-08-31",
  "2026-09-02",
  "2026-09-09",
  "2026-09-14",
  "2026-09-16",
  "2026-09-21",
  "2026-09-23",
  "2026-09-28",
  "2026-09-30",
  "2026-10-06",
  "2026-10-07",
  "2026-10-19",
  "2026-10-21",
  "2026-10-26",
  "2026-10-28",
  "2026-11-02",
  "2026-11-04",
  "2026-11-09",
  "2026-11-11",
  "2026-11-16",
  "2026-11-18",
  "2026-11-23",
  "2026-11-25",
  "2026-11-30",
  "2026-12-02",
  "2026-12-07",
  "2026-12-09",
  "2026-12-14"
];

const groupSchedules = {
  "1010": g1010,
  "1020": g1020,
  "1030": g1030,
  "1040": g1040,
  "1050": g1050,
  "1060": g1060,
  "1070": g1070,
  "1080": g1080,
  "1090": g1090,
};

const teacherGroups = {
  "Éric": ["1070", "1080"],
  "Jamil": ["1010", "1020"],
  "Jean-Michel": ["1090"],
  "Sébastien": ["1030", "1040"],
  "Pierre-Paul": ["1050", "1060"],
};

function buildCalendrierForIndex(index) {
  if (index < 0 || index >= g1010.length) {
    return {};
  }

  const calendrier = {};
  for (const [teacher, groups] of Object.entries(teacherGroups)) {
    calendrier[teacher] = groups.map((group) => ({
      [group]: groupSchedules[group][index],
    }));
  }

  return calendrier;
}

/** @type {import('@docusaurus/plugin-content-docs').SidebarsConfig} */
const sidebars = {
  docs: [
    {
      type: "doc",
      label: "1.1 - Introduction 🏁",
      id: "cours/introduction",
      customProps: {
        calendrier: buildCalendrierForIndex(0),
        tooltip:"cache"
      },
    },
    {
      type: "doc",
      label: "1.2 - Variables et opérations",
      id: "cours/variables",
      customProps: {
        calendrier: buildCalendrierForIndex(1),

        tooltip:"cache"
      },
    },
    {
      type: "doc",
      label: "2.1 - Structures conditionnelles (if/else)",
      id: "cours/ifelse",
      customProps: {
        calendrier: buildCalendrierForIndex(2),
        tooltip:"cache"
      },
    },
    {
      type: "doc",
      label: "2.2 - Fonctions",
      id: "cours/fonctions",
      customProps: {
        avancementLabel: "TP1",
        avancement: 0.1,
        calendrier: buildCalendrierForIndex(3),
        tooltip:"cache"
      },
    },
    {
      type: "doc",
      label: "3.1 - Intégration des fonctions",
      id: "cours/integration-fonctions",
      customProps: {
        avancementLabel: "TP1",
        avancement: 0.4,
        calendrier: buildCalendrierForIndex(4),
        tooltip:"cache"
      },
    },
    {
      type: "doc",
      label: "3.2 - TP1 - Créateur de personnage",
      id: "cours/integration-tp1",
      className: "remise-tp1",
      customProps: {
        avancementLabel: "TP1",
        avancement: 1.0,
        calendrier: buildCalendrierForIndex(5),
        tooltip:"cache"
      },
    },
    {
      type: "doc",
      label: "4.1 - Boucles for",
      id: "cours/for",
      customProps: {
        calendrier: buildCalendrierForIndex(6),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "4.2 - Tableaux 1D",
      id: "cours/tableaux1d",
      customProps: {
        calendrier: buildCalendrierForIndex(7),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "5.1 - Intégration des notions",
      id: "cours/integration-for",
      customProps: {
        calendrier: buildCalendrierForIndex(8),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "5.2 - Formatif 1",
      id: "cours/formatif1",
      customProps: {
        calendrier: buildCalendrierForIndex(9),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "6.1 - Examen 1",
      id: "cours/examen1",
      className: "examen",
      customProps: {
        calendrier: buildCalendrierForIndex(10),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "6.2 - Tableaux 2D",
      id: "cours/tableaux2d",
      customProps: {
        avancementLabel: "TP2",
        avancement: 0.1,
        calendrier: buildCalendrierForIndex(11),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "7.1 - Intégration des tableaux 2D",
      id: "cours/integration-2d",
      customProps: {
        avancementLabel: "TP2",
        avancement: 0.3,
        calendrier: buildCalendrierForIndex(12),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "7.2 - Switch, while, do while",
      id: "cours/switch-while",
      customProps: {
        avancementLabel: "TP2",
        avancement: 0.3,
        calendrier: buildCalendrierForIndex(13),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "8.1 - Intégration - TP2",
      id: "cours/integration-tp2-1",
      customProps: {
        avancementLabel: "TP2", 
        avancement: 0.6,
        calendrier: buildCalendrierForIndex(14),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "8.2 - TP2 - Mini RPG",
      id: "cours/integration-tp2-2",
      className: "remise-tp2",
      customProps: {
        avancementLabel: "TP2",
        avancement: 1.0,
        calendrier: buildCalendrierForIndex(15),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "9.1 - Écriture dans un fichier",
      id: "cours/ecriture-texte",
      customProps: {
        avancementLabel: "TP3 - Créé - ",
        avancement: 0.1,
        calendrier: buildCalendrierForIndex(16),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      
      label: "9.2 - Lecture de fichiers texte",
      id: "cours/lecture-texte",
      customProps: {
        avancementLabel: "TP3",
        avancement: 0.2,
        calendrier: buildCalendrierForIndex(17),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "10.1 - Fichiers CSV et séparateurs",
      id: "cours/csv",
      customProps: {
        avancementLabel: "TP3",
        avancement: 0.3,
        calendrier: buildCalendrierForIndex(18),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "10.2 - Formatif 2",
      id: "cours/formatif2",
      customProps: {
        calendrier: buildCalendrierForIndex(19),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "11.1 - Examen 2",
      id: "cours/examen2",
      className: "examen",
      customProps: {
        calendrier: buildCalendrierForIndex(20),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "11.2 - TP3 - RPG avancé",
      id: "cours/integration-tp3-1",
      customProps: {
        avancementLabel: "TP3",
        avancement: 0.7,
        calendrier: buildCalendrierForIndex(21),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "12.1 - TP3 - suite",
      id: "cours/integration-tp3-2",
      className: "remise-tp3",
      customProps: {
        avancementLabel: "TP3",
        avancement: 1.0,
        calendrier: buildCalendrierForIndex(22),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "12.2 - Interface graphique",
      id: "cours/winform",
      customProps: {
        avancementLabel: "TP4 - Créé - ",
        avancement: 0.15,
        calendrier: buildCalendrierForIndex(23),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "13.1 - Introduction à la POO",
      id: "cours/poo",
      customProps: {
        avancementLabel: "TP4",
        avancement: 0.3,
        calendrier: buildCalendrierForIndex(24),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "13.2 - Intégration des objets",
      id: "cours/integration-poo",
      customProps: {
        avancementLabel: "TP4",
        avancement: 0.5,
        calendrier: buildCalendrierForIndex(25),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "14.1 - TP4 - Démineur",
      id: "cours/integration-tp4-1",
      customProps: {
        avancementLabel: "TP4",
        avancement: 0.75,
        calendrier: buildCalendrierForIndex(26),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "14.2 - TP4 - suite",
      id: "cours/integration-tp4-2",
      className: "remise-tp4",
      customProps: {
        avancementLabel: "TP4",
        avancement: 1.0,
        calendrier: buildCalendrierForIndex(27),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "15.1 - Formatif 3",
      id: "cours/formatif3",
      customProps: {
        calendrier: buildCalendrierForIndex(28),
        tooltip:"cache"
      }
    },
    {
      type: "doc",
      label: "15.2 - Examen 3",
      id: "cours/examen3",
      className: "examen",
      customProps: {
        calendrier: buildCalendrierForIndex(29),
        tooltip:"cache"
      }
    }

  ],
  tp: [
    { type: "autogenerated", dirName: "02-tp" }
  ],
  laboratoire: [
    {
      type: 'category',
      label: 'Laboratoire',
      collapsible: false,
      items: ['laboratoire/laboratoire']
    },
    {
      type: 'category',
      label: 'Laboratoire 1.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire1.1', 'laboratoire/laboratoire1.1B']
    },
    {
      type: 'category',
      label: 'Laboratoire 1.2',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire1.2A', 'laboratoire/laboratoire1.2B']
    },
    {
      type: 'category',
      label: 'Laboratoire 2.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire2.1A', 'laboratoire/laboratoire2.1B']
    },
    {
      type: 'category',
      label: 'Laboratoire 2.2',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire2.2A', 'laboratoire/laboratoire2.2B']
    },
    {
      type: 'category',
      label: 'Laboratoire 3.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire3.1A', 'laboratoire/laboratoire3.1B']
    },

    {
      type: 'category',
      label: 'Laboratoire 4.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire4.1A', 'laboratoire/laboratoire4.1B']
    },
    {
      type: 'category',
      label: 'Laboratoire 4.2',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire4.2A','laboratoire/laboratoire4.2B','laboratoire/laboratoire4.2C']
    },
    {
      type: 'category',
      label: 'Laboratoire 5.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire5.1A', 'laboratoire/laboratoire5.1B', 'laboratoire/laboratoire5.1C']
    },
    {
      type: 'category',
      label: 'Laboratoire 6.2',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire6.2A','laboratoire/laboratoire6.2B']
    },
    {
      type: 'category',
      label: 'Laboratoire 7.2',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire7.2A', 'laboratoire/laboratoire7.2B']
    },
    {
      type: 'category',
      label: 'Laboratoire 8.1',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire8.1A']
    },
    {
      type: 'category',
      label: 'Laboratoire 9.1',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire9.1']
    },
    {
      type: 'category',
      label: 'Laboratoire 9.2',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire9.2']
    },
    {
      type: 'category',
      label: 'Laboratoire 10.1',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire10.1']
    },
    {
      type: 'category',
      label: 'Laboratoire 12.2',
      collapsible: true,
      collapsed: collapseBloc3,
      items: ['laboratoire/laboratoire12.2']
    },
    {
      type: 'category',
      label: 'Laboratoire 13.1',
      collapsible: true,
      collapsed: collapseBloc3,
      items: ['laboratoire/laboratoire13.1']
    },
    {
      type: 'category',
      label: 'Laboratoire 13.2',
      collapsible: true,
      collapsed: collapseBloc3,
      items: ['laboratoire/laboratoire13.2']
    },
  ],
  defis: [{ type: "autogenerated", dirName: "06-defis" }],
  solution: [
    'solution/Laboratoire-Solution1.1',
    'solution/Defi-Solution1.1',
    'solution/Laboratoire-Solution1.2A',
    'solution/Laboratoire-Solution1.2B',
    'solution/Defi-Solution1.2',
    'solution/laboratoire-Solution2.1A',
    'solution/laboratoire-Solution2.1B',
    'solution/Defi-Solution2.1',
    'solution/Laboratoire-Solution2.2A',
    'solution/Laboratoire-Solution2.2B',
    'solution/Laboratoire-Solution2.2C',
    'solution/Defi-Solution2.2',
    'solution/Laboratoire-Solution3.1A',
    'solution/Laboratoire-Solution3.1B',
    'solution/Defi-Solution3.1',
    'solution/Laboratoire-Solution4.1A',
    'solution/Laboratoire-Solution4.1B',
    'solution/Defi-Solution4.1',
    'solution/Laboratoire-Solution4.2A',
    'solution/Laboratoire-Solution4.2B',
    'solution/Laboratoire-Solution4.2C',
    'solution/Defi-Solution4.2',
    'solution/Laboratoire-Solution6.2A',
    'solution/Laboratoire-Solution6.2B',
    'solution/Defi-Solution6.2',
    'solution/Laboratoire-Solution7.2A',
    'solution/Laboratoire-Solution7.2B',
    'solution/Defi-Solution7.2',
    'solution/Defi-Solution8.1',
    'solution/Laboratoire-Solution9.1',
    'solution/Defi-Solution9.1',
    'solution/Laboratoire-Solution9.2',
    'solution/Defi-Solution9.2',
    'solution/Laboratoire-Solution10.1',
    'solution/Defi-Solution10.1',
    'solution/Defi-Solution12.2',
    'solution/Defi-Solution13.1',
    'solution/Defi-Solution13.2'
  ],
  extra: [{ type: "autogenerated", dirName: "05-extra" }],
};


module.exports = sidebars;

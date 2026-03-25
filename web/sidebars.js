// @ts-check

let currentDate = new Date();
let month = currentDate.getMonth() + 1;

let collapseBloc1 = !(month <= 9);
let collapseBloc2 = !(month >= 9 && month <= 11);
let collapseBloc3 = !(month >= 11);

const g1010 = [
  "2026-01-26",
  "2026-01-28",
  "2026-02-02",
  "2026-02-04",
  "2026-02-09",
  "2026-02-11",
  "2026-02-16",
  "2026-02-18",
  "2026-02-23",
  "2026-02-25",
  "2026-03-02",
  "2026-03-04",
  "2026-03-09",
  "2026-03-11",
  "2026-03-16",
  "2026-03-18",
  "2026-03-23",
  "2026-03-25",
  "2026-03-30",
  "2026-04-01",
  "2026-04-06",
  "2026-04-08",
  "2026-04-13",
  "2026-04-15",
  "2026-04-20",
  "2026-04-22",
  "2026-04-27",
  "2026-04-29",
  "2026-05-04",
  "2026-05-06",
  "2026-05-11",
  "2026-05-13",
  "2026-05-18",
  "2026-05-20",
  "2026-05-25",
  "2026-05-27"

];

const g1030 = [
  "2026-01-27",
  "2026-01-30",
  "2026-02-03",
  "2026-02-06",
  "2026-02-10",
  "2026-02-13",
  "2026-02-17",
  "2026-02-20",
  "2026-02-24",
  "2026-02-27",
  "2026-03-03",
  "2026-03-06",
  "2026-03-10",
  "2026-03-13",
  "2026-03-17",
  "2026-03-20",
  "2026-03-24",
  "2026-03-27",
  "2026-03-31",
  "2026-04-03",
  "2026-04-07",
  "2026-04-10",
  "2026-04-14",
  "2026-04-17",
  "2026-04-21",
  "2026-04-24",
  "2026-04-28",
  "2026-05-01",
  "2026-05-05",
  "2026-05-08",
  "2026-05-12",
  "2026-05-15",
  "2026-05-19",
  "2026-05-22",
  "2026-05-26",
  "2026-05-29",

];

const g1060 = [
  "2026-01-28",
  "2026-01-29",
  "2026-02-04",
  "2026-02-05",
  "2026-02-11",
  "2026-02-12",
  "2026-02-18",
  "2026-02-19",
  "2026-02-25",
  "2026-02-26",
  "2026-03-04",
  "2026-03-05",
  "2026-03-11",
  "2026-03-12",
  "2026-03-18",
  "2026-03-19",
  "2026-03-25",
  "2026-03-26",
  "2026-04-01",
  "2026-04-02",
  "2026-04-08",
  "2026-04-09",
  "2026-04-15",
  "2026-04-16",
  "2026-04-22",
  "2026-04-23",
  "2026-04-29",
  "2026-04-30",
  "2026-05-06",
  "2026-05-07",
  "2026-05-13",
  "2026-05-14",
  "2026-05-20",
  "2026-05-21",
  "2026-05-27",
  "2026-05-28",


];

/** @type {import('@docusaurus/plugin-content-docs').SidebarsConfig} */
const sidebars = {
  docs: [
    {
      type: "doc",
      label: "1.0 - Présentation du cours",
      id: "cours/introduction",
      customProps: {

        tooltip: "cache"
      },
    },
    {
      type: "doc",
      label: "1.1 - Révision, objets et collection",
      id: "cours/revision-collection",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[0] }, { "1020": g1010[0] }],
          "Philippe": [{ "1050": g1010[0] }],
          "David": [{ "1030": g1030[0] }, { "1040": g1030[0] }],
          "Jimmy": [{ "1060": g1060[0] }],
        },
        tooltip: "cache"
      },
    },
    {
      type: "doc",
      label: "1.2 - Git et TP1 (Partie 1)",
      id: "cours/git",
      customProps: {
        avancementLabel: "TP1",
        avancement: 0.1,
        calendrier: {
          "Jamil": [{ "1010": g1010[1] }, { "1020": g1010[1] }],
          "Philippe": [{ "1050": g1010[1] }],
          "David": [{ "1030": g1030[1] }, { "1040": g1030[1] }],
          "Jimmy": [{ "1060": g1060[1] }],
        },

        tooltip: "cache"
      },
    },
    {
      type: "doc",
      label: "2.1 - Définition des classes",
      id: "cours/classe",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[2] }, { "1020": g1010[2] }],
          "Philippe": [{ "1050": g1010[2] }],
          "David": [{ "1030": g1030[2] }, { "1040": g1030[2] }],
          "Jimmy": [{ "1060": g1060[2] }],
        },
        tooltip: "cache"
      },
    },
    {
      type: "doc",
      label: "2.2 - Encapsulation",
      id: "cours/encapsulation",
      customProps: {

        calendrier: {
          "Jamil": [{ "1010": g1010[3] }, { "1020": g1010[3] }],
          "Philippe": [{ "1050": g1010[3] }],
          "David": [{ "1030": g1030[3] }, { "1040": g1030[3] }],
          "Jimmy": [{ "1060": g1060[3] }],
        },
        tooltip: "cache"
      },
    },
    {
      type: "doc",
      label: "3.1 - Type par énumération - TP1 (Partie 2)",
      id: "cours/enum",
      customProps: {
        avancementLabel: "TP1",
        avancement: 0.4,
        calendrier: {
          "Jamil": [{ "1010": g1010[4] }, { "1020": g1010[4] }],
          "Philippe": [{ "1050": g1010[4] }],
          "David": [{ "1030": g1030[4] }, { "1040": g1030[4] }],
          "Jimmy": [{ "1060": g1060[4] }],
        },
        tooltip: "cache"
      },
    },
    {
      type: "doc",
      label: "3.2 - TP1 (Partie 2)",
      id: "cours/tp1-p2",
      customProps: {
        avancementLabel: "TP1",
        avancement: 0.6,
        calendrier: {
          "Jamil": [{ "1010": g1010[5] }, { "1020": g1010[5] }],
          "Philippe": [{ "1050": g1010[5] }],
          "David": [{ "1030": g1030[5] }, { "1040": g1030[5] }],
          "Jimmy": [{ "1060": g1060[5] }],
        },
        tooltip: "cache"
      },
    },
    {
      type: "doc",
      label: "4.1 - Type valeur vs référence",
      id: "cours/valeur-reference",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[6] }, { "1020": g1010[6] }],
          "Philippe": [{ "1050": g1010[6] }],
          "David": [{ "1030": g1030[6] }, { "1040": g1030[6] }],
          "Jimmy": [{ "1060": g1060[6] }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "4.2 - Intégration",
      id: "cours/integration-module1",
      className: "remise-tp1",
      customProps: {
        avancementLabel: "TP1",
        avancement: 1.0,
        calendrier: {
          "Jamil": [{ "1010": g1010[7] }, { "1020": g1010[7] }],
          "Philippe": [{ "1050": g1010[7] }],
          "David": [{ "1030": g1030[7] }, { "1040": g1030[7] }],
          "Jimmy": [{ "1060": g1060[7] }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "5.1 - Examen formatif 1",
      id: "cours/formatif1",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[8] }, { "1020": g1010[8] }],
          "Philippe": [{ "1050": g1010[8] }],
          "David": [{ "1030": g1030[8] }, { "1040": g1030[8] }],
          "Jimmy": [{ "1060": g1060[8] }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "5.2 - Examen 1",
      id: "cours/examen1",
      className: "examen",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[9] }, { "1020": g1010[9] }],
          "Philippe": [{ "1050": g1010[9] }],
          "David": [{ "1030": g1030[9] }, { "1040": g1030[9] }],
          "Jimmy": [{ "1060": g1060[9] }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "6.1 - Windows Forms",
      id: "cours/winforms",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[10] }, { "1020": g1010[10] }],
          "Philippe": [{ "1050": g1010[10] }],
          "David": [{ "1030": g1030[10] }, { "1040": g1030[10] }],
          "Jimmy": [{ "1060": g1010[10] }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "6.2 - Windows Forms (suite)",
      id: "cours/winforms_suite",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[10] }, { "1020": g1010[10] }],
          "Philippe": [{ "1050": g1010[10] }],
          "David": [{ "1030": g1030[10] }, { "1040": g1030[10] }],
          "Jimmy": [{ "1060": g1010[10] }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "7.1 - Relation d'association",
      id: "cours/rencontre13",
      customProps: {

        calendrier: {
          "Jamil": [{ "1010": g1010[12] }, { "1020": g1010[12] }],
          "Philippe": [{ "1050": g1010[12] }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "7.2 - Exceptions",
      id: "cours/exceptions",
      customProps: {
        calendrier: {
          "Jamil": [{ "1010": g1010[13] }, { "1020": g1010[13] }],
          "Philippe": [{ "1050": g1010[13] }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "8.1 - TP2",
      id: "cours/tp2",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-10-20" }, { "1100": "2026-10-20" }],
          "Éric": [{ "1050": "2026-10-24" }, { "1060": "2026-10-24" }],
          "Jamil": [{ "1010": "2026-10-21" }, { "1020": "2026-10-21" }],
          "Jean-Michel": [{ "1120": g1010[14] }, { "1080": g1030[14] }],
          "Pierre-Paul": [{ "1030": "2026-10-20" }, { "1040": "2026-10-20" }],
          "Tommy": [{ "1130": "2026-10-21" }],
          "Philippe": [{ "1070": "2026-10-20" }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "8.2 - rencontre16",
      id: "cours/rencontre16",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-10-23" }, { "1100": "2026-10-23" }],
          "Éric": [{ "1050": "2026-10-29" }, { "1060": "2026-10-29" }],
          "Jamil": [{ "1010": "2026-10-23" }, { "1020": "2026-10-23" }],
          "Jean-Michel": [{ "1120": g1010[15] }, { "1080": g1030[15] }],
          "Pierre-Paul": [{ "1030": "2026-10-22" }, { "1040": "2026-10-22" }],
          "Tommy": [{ "1130": "2026-10-24" }],
          "Philippe": [{ "1070": "2026-10-23" }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "9.1 - rencontre17",
      id: "cours/rencontre17",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-10-27" }, { "1100": "2026-10-27" }],
          "Éric": [{ "1050": "2026-10-31" }, { "1060": "2026-10-31" }],
          "Jamil": [{ "1010": "2026-10-28" }, { "1020": "2026-10-28" }],
          "Jean-Michel": [{ "1120": g1010[16] }, { "1080": g1030[16] }],
          "Pierre-Paul": [{ "1030": "2026-10-27" }, { "1040": "2026-10-27" }],
          "Tommy": [{ "1130": "2026-10-28" }],
          "Philippe": [{ "1070": "2026-10-27" }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",

      label: "9.2 - Intégration",
      id: "cours/integration-module2",
      className: "remise-tp2",
      customProps: {
        avancementLabel: "TP2",
        avancement: 1.0,
        calendrier: {
          "David": [{ "1090": "2026-10-30" }, { "1100": "2026-10-30" }],
          "Éric": [{ "1050": "2026-11-05" }, { "1060": "2026-11-05" }],
          "Jamil": [{ "1010": "2026-10-30" }, { "1020": "2026-10-30" }],
          "Jean-Michel": [{ "1120": g1010[17] }, { "1080": g1030[17] }],
          "Pierre-Paul": [{ "1030": "2026-10-29" }, { "1040": "2026-10-29" }],
          "Tommy": [{ "1130": "2026-10-31" }],
          "Philippe": [{ "1070": "2026-10-30" }],
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "10.1 - Examen formatif 2",
      id: "cours/formatif2",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-11-03" }, { "1100": "2026-11-03" }],
          "Éric": [{ "1050": "2026-11-07" }, { "1060": "2026-11-07" }],
          "Jamil": [{ "1010": "2026-11-04" }, { "1020": "2026-11-04" }],
          "Jean-Michel": [{ "1120": g1010[18] }, { "1080": g1030[18] }],
          "Pierre-Paul": [{ "1030": "2026-11-03" }, { "1040": "2026-11-03" }],
          "Tommy": [{ "1130": "2026-11-04" }],
          "Philippe": [{ "1070": "2026-11-03" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "10.2 - Examen 2",
      id: "cours/examen2",
      className: "examen",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-11-06" }, { "1100": "2026-11-06" }],
          "Éric": [{ "1050": "2026-11-12" }, { "1060": "2026-11-12" }],
          "Jamil": [{ "1010": "2026-11-06" }, { "1020": "2026-11-06" }],
          "Jean-Michel": [{ "1120": g1010[19] }, { "1080": g1030[19] }],
          "Pierre-Paul": [{ "1030": "2026-11-05" }, { "1040": "2026-11-05" }],
          "Tommy": [{ "1130": "2026-11-07" }],
          "Philippe": [{ "1070": "2026-11-06" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "11.1 - rencontre21",
      id: "cours/rencontre21",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-11-13" }, { "1100": "2026-11-13" }],
          "Éric": [{ "1050": "2026-11-14" }, { "1060": "2026-11-14" }],
          "Jamil": [{ "1010": "2026-11-11" }, { "1020": "2026-11-11" }],
          "Jean-Michel": [{ "1120": g1010[20] }, { "1080": g1030[20] }],
          "Pierre-Paul": [{ "1030": "2026-11-12" }, { "1040": "2026-11-12" }],
          "Tommy": [{ "1130": "2026-11-11" }],
          "Philippe": [{ "1070": "2026-11-13" }, { "1080": "2026-11-13" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "11.2 - rencontre 22",
      id: "cours/rencontre22",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-11-17" }, { "1100": "2026-11-17" }],
          "Éric": [{ "1050": "2026-11-19" }, { "1060": "2026-11-19" }],
          "Jamil": [{ "1010": "2026-11-13" }, { "1020": "2026-11-13" }],
          "Jean-Michel": [{ "1120": g1010[21] }, { "1080": g1030[21] }],
          "Pierre-Paul": [{ "1030": "2026-11-17" }, { "1040": "2026-11-17" }],
          "Tommy": [{ "1130": "2026-11-14" }],
          "Philippe": [{ "1070": "2026-11-17" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "12.1 - rencontre23",
      id: "cours/rencontre23",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-11-20" }, { "1100": "2026-11-20" }],
          "Éric": [{ "1050": "2026-11-21" }, { "1060": "2026-11-21" }],
          "Jamil": [{ "1010": "2026-11-18" }, { "1020": "2026-11-18" }],
          "Jean-Michel": [{ "1120": g1010[22] }, { "1080": g1030[22] }],
          "Pierre-Paul": [{ "1030": "2026-11-19" }, { "1040": "2026-11-19" }],
          "Tommy": [{ "1130": "2026-11-18" }],
          "Philippe": [{ "1070": "2026-11-20" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "12.2 - rencontre24",
      id: "cours/rencontre24",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-11-27" }, { "1100": "2026-11-27" }],
          "Éric": [{ "1050": "2026-11-26" }, { "1060": "2026-11-26" }],
          "Jamil": [{ "1010": "2026-11-20" }, { "1020": "2026-11-20" }],
          "Jean-Michel": [{ "1120": g1010[23] }, { "1080": g1030[23] }],
          "Pierre-Paul": [{ "1030": "2026-11-26" }, { "1040": "2026-11-26" }],
          "Tommy": [{ "1130": "2026-11-21" }],
          "Philippe": [{ "1070": "2026-11-27" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "13.1 - rencontre25",
      id: "cours/rencontre25",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-12-01" }, { "1100": "2026-12-01" }],
          "Éric": [{ "1050": "2026-12-03" }, { "1060": "2026-12-03" }],
          "Jamil": [{ "1010": "2026-11-25" }, { "1020": "2026-11-25" }],
          "Jean-Michel": [{ "1120": g1010[24] }, { "1080": g1030[24] }],
          "Pierre-Paul": [{ "1030": "2026-12-01" }, { "1040": "2026-12-01" }],
          "Tommy": [{ "1130": "2026-11-25" }],
          "Philippe": [{ "1070": "2026-12-01" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "13.2 - rencontre26",
      id: "cours/rencontre26",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-12-04" }, { "1100": "2026-12-04" }],
          "Éric": [{ "1050": "2026-12-05" }, { "1060": "2026-12-05" }],
          "Jamil": [{ "1010": "2026-11-27" }, { "1020": "2026-11-27" }],
          "Jean-Michel": [{ "1120": g1010[25] }, { "1080": g1030[25] }],
          "Pierre-Paul": [{ "1030": "2026-12-03" }, { "1040": "2026-12-03" }],
          "Tommy": [{ "1130": "2026-11-28" }],
          "Philippe": [{ "1070": "2026-12-04" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "14.1 - rencontre27",
      id: "cours/rencontre27",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-12-08" }, { "1100": "2026-12-08" }],
          "Éric": [{ "1050": "2026-12-10" }, { "1060": "2026-12-10" }],
          "Jamil": [{ "1010": "2026-12-02" }, { "1020": "2026-12-02" }],
          "Jean-Michel": [{ "1120": g1010[26] }, { "1080": g1030[26] }],
          "Pierre-Paul": [{ "1030": "2026-12-08" }, { "1040": "2026-12-08" }],
          "Tommy": [{ "1130": "2026-12-02" }],
          "Philippe": [{ "1070": "2026-12-08" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "14.2 - Intégration",
      id: "cours/integration-module3",
      className: "remise-tp3",
      customProps: {
        avancementLabel: "TP3",
        avancement: 1.0,
        calendrier: {
          "David": [{ "1090": "2026-12-15" }, { "1100": "2026-12-15" }],
          "Éric": [{ "1050": "2026-12-19" }, { "1060": "2026-12-19" }],
          "Jamil": [{ "1010": "2026-12-04" }, { "1020": "2026-12-04" }],
          "Jean-Michel": [{ "1120": g1010[27] }, { "1080": g1030[27] }],
          "Pierre-Paul": [{ "1030": "2026-12-10" }, { "1040": "2026-12-10" }],
          "Tommy": [{ "1130": "2026-12-05" }],
          "Philippe": [{ "1070": "2026-12-11" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "15.1 - Examen formatif 3",
      id: "cours/formatif3",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-12-11" }, { "1100": "2026-12-11" }],
          "Éric": [{ "1050": "2026-12-12" }, { "1060": "2026-12-12" }],
          "Jamil": [{ "1010": "2026-12-11" }, { "1020": "2026-12-11" }],
          "Jean-Michel": [{ "1120": g1010[28] }, { "1080": g1030[28] }],
          "Pierre-Paul": [{ "1030": "2026-12-15" }, { "1040": "2026-12-15" }],
          "Tommy": [{ "1130": "2026-12-16" }],
          "Philippe": [{ "1070": "2026-12-15" }]
        },
        tooltip: "cache"
      }
    },
    {
      type: "doc",
      label: "15.2 - Examen 3",
      id: "cours/examen3",
      className: "examen",
      customProps: {
        calendrier: {
          "David": [{ "1090": "2026-12-18" }, { "1100": "2026-12-18" }],
          "Éric": [{ "1050": "2026-12-18" }, { "1060": "2026-12-18" }],
          "Jamil": [{ "1010": "2026-12-18" }, { "1020": "2026-12-18" }],
          "Jean-Michel": [{ "1120": g1010[29] }, { "1080": g1030[29] }],
          "Pierre-Paul": [{ "1030": "2026-12-18" }, { "1040": "2026-12-18" }],
          "Tommy": [{ "1130": "2026-12-18" }],
          "Philippe": [{ "1070": "2026-12-18" }]
        },
        tooltip: "cache"
      }
    }

  ],
  tp: [
    { type: "autogenerated", dirName: "02-tp" }
  ],
  laboratoire: [
    {
      type: 'category',
      label: 'Laboratoire 1.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire1.1']
    },
    {
      type: 'category',
      label: 'Laboratoire 2.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire2.1']
    },
    {
      type: 'category',
      label: 'Laboratoire 2.2',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire2.2']
    },
    {
      type: 'category',
      label: 'Laboratoire 3.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire3.1']
    },
    {
      type: 'category',
      label: 'Laboratoire 4.1',
      collapsible: true,
      collapsed: collapseBloc1,
      items: ['laboratoire/laboratoire4.1']
    },
    {
      type: 'category',
      label: 'Laboratoire 4.2',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire4.2A', 'laboratoire/laboratoire4.2B', 'laboratoire/laboratoire4.2C']

    },
    {
      type: 'category',
      label: 'Laboratoire 5.1',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire5.1A', 'laboratoire/laboratoire5.1B']

    },
    {
      type: 'category',
      label: 'Laboratoire 6.1',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire6.1A', 'laboratoire/laboratoire6.1B', 'laboratoire/laboratoire6.1C']

    },
    {
      type: 'category',
      label: 'Laboratoire 6.2',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire6.2A', 'laboratoire/laboratoire6.2B', 'laboratoire/laboratoire6.2C']

    },
     {
      type: 'category',
      label: 'Laboratoire 7.1',
      collapsible: true,
      collapsed: collapseBloc2,
      items: ['laboratoire/laboratoire7.1A', 'laboratoire/laboratoire7.1B']

    },
    {
      type: 'category',
      label: 'Laboratoire 7.2',
      collapsible: true,
      collapsed: collapseBloc3,
      items: ['laboratoire/laboratoire7.2A', 'laboratoire/laboratoire7.2B', 'laboratoire/laboratoire7.2C']

    }


  ],
  solution: [{ type: "autogenerated", dirName: "04-solution" }],
  extra: [{ type: "autogenerated", dirName: "05-extra" }],
};


module.exports = sidebars;

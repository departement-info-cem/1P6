import React from "react";
import Link from "@docusaurus/Link";
import styles from "./CourseHome.module.css";

const paths = [
  {
    number: "01",
    title: "Comprendre",
    description: "Les notions et les exemples de chaque rencontre.",
    links: [{ label: "Voir les cours", to: "/cours/introduction" }],
  },
  {
    number: "02",
    title: "Pratiquer",
    description: "Des exercices pour essayer le code par toi-même.",
    links: [
      { label: "Laboratoires", to: "/laboratoire/laboratoire" },
      { label: "Défis", to: "/defis" },
    ],
  },
  {
    number: "03",
    title: "Réaliser",
    description: "Les travaux pratiques et leurs consignes.",
    links: [{ label: "Travaux pratiques", to: "/tp/tp1" }],
  },
  {
    number: "04",
    title: "Vérifier",
    description: "Des corrigés pour comparer ta démarche après l'essai.",
    links: [
      {
        label: "Solutions",
        to: "/solution/solution-comprendre-consigne",
      },
    ],
  },
];

export default function CourseHome() {
  return (
    <>
      <section className={styles.hero} aria-labelledby="home-title">
        <div className={styles.heroContent}>
          <p className={styles.eyebrow}>1P6 · PROGRAMMATION 1 · C#</p>
          <h1 id="home-title">Apprendre à programmer, une rencontre à la fois.</h1>
          <p className={styles.intro}>
            Retrouve au même endroit les notions du cours, les exercices et les
            travaux pratiques. Avance à ton rythme, puis vérifie ta démarche.
          </p>
          <div className={styles.actions}>
            <Link className={styles.primaryAction} to="/cours/introduction">
              Commencer le cours <span aria-hidden="true">→</span>
            </Link>
            <a className={styles.secondaryAction} href="#parcours">
              Voir le parcours
            </a>
          </div>
        </div>
        <div className={styles.heroPanel} aria-label="Méthode de travail">
          <span className={styles.panelLabel}>UNE BONNE ROUTINE</span>
          <div><strong>Lire</strong><span>Comprendre la notion</span></div>
          <div><strong>Essayer</strong><span>Écrire et exécuter le code</span></div>
          <div><strong>Vérifier</strong><span>Comparer avec le corrigé</span></div>
        </div>
      </section>

      <section className={styles.section} aria-labelledby="home-paths">
        <div className={styles.sectionHeading}>
          <div>
            <p className={styles.eyebrow}>REPÈRES</p>
            <h2 id="home-paths">Choisis ta prochaine étape</h2>
          </div>
          <p>Chaque ressource a sa place dans le parcours du cours.</p>
        </div>
        <div className={styles.pathGrid}>
          {paths.map((path) => (
            <article className={styles.pathCard} key={path.number}>
              <span className={styles.pathNumber}>{path.number}</span>
              <h3>{path.title}</h3>
              <p>{path.description}</p>
              <div className={styles.pathLinks}>
                {path.links.map((link) => (
                  <Link key={link.label} to={link.to}>
                    {link.label} <span aria-hidden="true">→</span>
                  </Link>
                ))}
              </div>
            </article>
          ))}
        </div>
      </section>

      <section className={styles.section} aria-labelledby="home-resources">
        <div className={styles.sectionHeading}>
          <div>
            <p className={styles.eyebrow}>À GARDER SOUS LA MAIN</p>
            <h2 id="home-resources">Ressources essentielles</h2>
          </div>
        </div>
        <div className={styles.resourceGrid}>
          <article className={styles.resourceCard}>
            <span aria-hidden="true" className={styles.resourceIcon}>⌘</span>
            <h3>Préparer son poste</h3>
            <p>Installe Visual Studio pour pratiquer à la maison.</p>
            <a href="https://info.cegepmontpetit.ca/notions-csharp/bien-debuter/installation-des-logiciels/visual-studio">
              Guide d'installation <span aria-hidden="true">→</span>
            </a>
          </article>
          <article className={styles.resourceCard}>
            <span aria-hidden="true" className={styles.resourceIcon}>§</span>
            <h3>Travaux individuels</h3>
            <p>Les exercices peuvent être faits à plusieurs. Les travaux évalués sont individuels.</p>
            <a href="https://info.cegepmontpetit.ca/plagiat">
              Règles sur le plagiat <span aria-hidden="true">→</span>
            </a>
          </article>
          <article className={styles.resourceCard}>
            <span aria-hidden="true" className={styles.resourceIcon}>{"{ }"}</span>
            <h3>Documentation C#</h3>
            <p>Revois les outils et les explications complémentaires au cours.</p>
            <a href="https://info.cegepmontpetit.ca/notions-csharp/bien-debuter/">
              Bien débuter en C# <span aria-hidden="true">→</span>
            </a>
          </article>
        </div>
      </section>
    </>
  );
}

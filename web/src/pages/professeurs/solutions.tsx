import React, { FormEvent, useState } from "react";
import Layout from "@theme/Layout";
import Heading from "@theme/Heading";
import useDocusaurusContext from "@docusaurus/useDocusaurusContext";
import solutionsInitiales from "@site/src/data/solutions-defis.json";
import styles from "./solutions.module.css";

type SolutionDefi = {
  id: string;
  fichier: string;
  publie: boolean;
};

const MOT_DE_PASSE_SHA256 =
  "77f671c8a3119b01675d748017b7d369cfab96b1d4d96e9f9222e7059dd36309";

async function calculerSha256(valeur: string): Promise<string> {
  const donnees = new TextEncoder().encode(valeur);
  const empreinte = await crypto.subtle.digest("SHA-256", donnees);
  return Array.from(new Uint8Array(empreinte))
    .map((octet) => octet.toString(16).padStart(2, "0"))
    .join("");
}

function nomDuDefi(id: string): string {
  return `Défi ${id.replace("solution/Defi-Solution", "")}`;
}

export default function GestionSolutionsDefis(): React.ReactElement {
  const { siteConfig } = useDocusaurusContext();
  const brancheEdition = String(siteConfig.customFields?.brancheEdition || "main");
  const editeurGitHub = `https://github.com/departement-info-cem/1P6/edit/${encodeURIComponent(
    brancheEdition
  )}/web/src/data/solutions-defis.json`;
  const [motDePasse, setMotDePasse] = useState("");
  const [autorise, setAutorise] = useState(false);
  const [erreur, setErreur] = useState("");
  const [message, setMessage] = useState("");
  const [solutions, setSolutions] = useState<SolutionDefi[]>(
    solutionsInitiales as SolutionDefi[]
  );

  const ouvrirSession = async (evenement: FormEvent) => {
    evenement.preventDefault();
    const empreinte = await calculerSha256(motDePasse);

    if (empreinte !== MOT_DE_PASSE_SHA256) {
      setErreur("Mot de passe incorrect.");
      return;
    }

    setAutorise(true);
    setErreur("");
    setMotDePasse("");
  };

  const modifierSolution = (id: string) => {
    setSolutions((liste) =>
      liste.map((solution) =>
        solution.id === id
          ? { ...solution, publie: !solution.publie }
          : solution
      )
    );
    setMessage("");
  };

  const definirToutes = (publie: boolean) => {
    setSolutions((liste) =>
      liste.map((solution) => ({ ...solution, publie }))
    );
    setMessage("");
  };

  const preparerPublication = async () => {
    const contenu = `${JSON.stringify(solutions, null, 2)}\n`;

    try {
      await navigator.clipboard.writeText(contenu);
      setMessage(
        "Configuration copiée. Dans GitHub : Ctrl+A, Ctrl+V, puis Commit changes."
      );
      window.open(editeurGitHub, "_blank", "noopener,noreferrer");
    } catch {
      const fichier = new Blob([contenu], { type: "application/json" });
      const lien = document.createElement("a");
      lien.href = URL.createObjectURL(fichier);
      lien.download = "solutions-defis.json";
      lien.click();
      URL.revokeObjectURL(lien.href);
      setMessage(
        "Le fichier a été téléchargé. Remplace-le dans GitHub, puis confirme le commit."
      );
      window.open(editeurGitHub, "_blank", "noopener,noreferrer");
    }
  };

  return (
    <Layout title="Espace professeur" description="Gestion des solutions de défis">
      <main className={styles.page}>
        <section className={styles.panel}>
          <Heading as="h1">Espace professeur</Heading>

          {!autorise ? (
            <div className={styles.login}>
              <p>Entre le mot de passe pour gérer les solutions de défis.</p>
              <form onSubmit={ouvrirSession}>
                <div className={styles.passwordRow}>
                  <input
                    className={styles.passwordInput}
                    type="password"
                    value={motDePasse}
                    onChange={(evenement) => setMotDePasse(evenement.target.value)}
                    placeholder="Mot de passe"
                    autoComplete="current-password"
                    autoFocus
                  />
                  <button className="button button--primary" type="submit">
                    Ouvrir
                  </button>
                </div>
                {erreur && <p className={styles.error}>{erreur}</p>}
              </form>
            </div>
          ) : (
            <>
              <p>
                Coche les solutions à afficher aux étudiants. Les solutions de
                laboratoires ne sont pas modifiées ici.
              </p>

              <div className={styles.toolbar}>
                <button
                  className="button button--secondary button--sm"
                  type="button"
                  onClick={() => definirToutes(true)}
                >
                  Tout afficher
                </button>
                <button
                  className="button button--secondary button--sm"
                  type="button"
                  onClick={() => definirToutes(false)}
                >
                  Tout cacher
                </button>
                <button
                  className="button button--outline button--secondary button--sm"
                  type="button"
                  onClick={() => setAutorise(false)}
                >
                  Fermer la session
                </button>
              </div>

              <div className={styles.solutions}>
                {solutions.map((solution) => (
                  <label
                    className={`${styles.solution} ${
                      solution.publie ? styles.published : ""
                    }`}
                    key={solution.id}
                  >
                    <input
                      type="checkbox"
                      checked={solution.publie}
                      onChange={() => modifierSolution(solution.id)}
                    />
                    <span>{nomDuDefi(solution.id)}</span>
                  </label>
                ))}
              </div>

              <button
                className="button button--primary button--lg"
                type="button"
                onClick={preparerPublication}
              >
                Copier et ouvrir GitHub
              </button>

              {message && <div className={styles.instructions}>{message}</div>}

              <div className={styles.instructions}>
                <strong>Dernière étape dans GitHub :</strong> remplace tout le
                contenu du fichier avec Ctrl+A puis Ctrl+V, et clique sur
                <em> Commit changes</em>. Le site se mettra ensuite à jour
                automatiquement.
              </div>
            </>
          )}
        </section>
      </main>
    </Layout>
  );
}

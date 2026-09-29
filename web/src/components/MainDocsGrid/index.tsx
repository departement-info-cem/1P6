import React, { useEffect, useMemo, useState } from "react";
import Link from "@docusaurus/Link";
import styles from "./MainDocsGrid.module.css";
import useBaseUrl from "@docusaurus/useBaseUrl";
import { usePluginData } from "@docusaurus/useGlobalData";
import sidebarDocs from "./sidebarDocs";

const ranges = [
  { start: 1, end: 5, title: "Rencontres 1 à 5" },
  { start: 6, end: 10, title: "Rencontres 6 à 10" },
  { start: 11, end: 15, title: "Rencontres 11 à 15" },
];

function formatDateFr(dateStr: string): string {
  const [year, month, day] = dateStr.split("-").map(Number);
  return new Date(year, month - 1, day).toLocaleDateString("fr-CA", {
    day: "numeric",
    month: "long",
  });
}

function resolveDocTitle(doc: any): string {
  return (
    doc?.title?.trim() ||
    doc?._sidebarLabel?.trim() ||
    doc?._documentTitle?.trim() ||
    doc?.id ||
    "Rencontre"
  );
}

function getKind(doc: any) {
  const className = doc._sidebarClassName || "";
  const title = resolveDocTitle(doc);
  if (className.includes("examen")) return { label: "Examen", tone: styles.exam };
  if (className.includes("remise")) return { label: "Remise", tone: styles.assignment };
  if (/formatif/i.test(title)) return { label: "Formatif", tone: styles.formative };
  if (/\bTP\d/i.test(title)) return { label: "TP", tone: styles.assignment };
  return { label: "Cours", tone: "" };
}

export default function MainDocsGrid() {
  const [meta, setMeta] = useState<any[]>([]);
  const metadataUrl = useBaseUrl("/docsMetadata.json");
  const baseUrl = useBaseUrl("/");
  const { routeBasePath = "" } = (usePluginData(
    "docusaurus-plugin-docs-metadata"
  ) ?? {}) as { routeBasePath?: string };

  useEffect(() => {
    fetch(metadataUrl)
      .then((response) => {
        if (!response.ok) throw new Error("Métadonnées indisponibles");
        return response.json();
      })
      .then((data) => setMeta(data))
      .catch(() => {
        // Les titres et les liens de la navigation restent disponibles.
      });
  }, [metadataUrl]);

  const docs = useMemo(
    () =>
      sidebarDocs.map((entry: any) => {
        const slug = entry.id.split("/").pop().replace(/^[0-9]+-/, "");
        const doc = meta.find((item: any) => item.id.endsWith(slug));
        return {
          ...doc,
          id: entry.id,
          _slug: slug,
          _sidebarLabel: entry.label,
          _sidebarProps: entry.customProps,
          _sidebarClassName: entry.className,
          _week: Number.parseInt(entry.label, 10),
        };
      }),
    [meta]
  );

  const routePrefix = routeBasePath ? `${routeBasePath}/` : "";

  return (
    <div className={styles.groups}>
      {ranges.map((range, groupIndex) => {
        const groupDocs = docs.filter(
          (doc) => doc._week >= range.start && doc._week <= range.end
        );
        return (
          <details className={styles.group} key={range.start} open={groupIndex === 0}>
            <summary className={styles.groupSummary}>
              <span>
                <span className={styles.groupKicker}>PARCOURS · {range.start}—{range.end}</span>
                <strong>{range.title}</strong>
              </span>
              <span className={styles.groupCount}>
                {groupDocs.length} rencontres <span aria-hidden="true">⌄</span>
              </span>
            </summary>
            <div className={styles.gridContainer}>
              {groupDocs.map((doc) => {
                const kind = getKind(doc);
                const calendar = doc._sidebarProps?.calendrier as
                  | Record<string, Array<Record<string, string>>>
                  | undefined;
                const showDates = calendar && doc._sidebarProps?.tooltip !== "cache";
                const progress = doc._sidebarProps?.avancement;
                const progressLabel = doc._sidebarProps?.avancementLabel
                  ?.split("-")[0]
                  .trim();
                const href = `${baseUrl}${routePrefix}${doc._slug}`;

                return (
                  <article
                    className={`${styles.gridItem} ${kind.tone}`}
                    key={doc.id}
                  >
                    <Link className={styles.cardLink} to={href}>
                      <span className={styles.cardTop}>
                        <span className={styles.kind}>{kind.label}</span>
                        <span aria-hidden="true" className={styles.arrow}>→</span>
                      </span>
                      <strong className={styles.cardTitle}>{resolveDocTitle(doc)}</strong>
                      <span className={styles.description}>
                        {doc.description || "Ouvrir la rencontre et consulter les notes."}
                      </span>
                      {typeof progress === "number" && (
                        <span className={styles.progressNote}>
                          {progressLabel || "TP"} · {Math.round(progress * 100)} %
                        </span>
                      )}
                    </Link>
                    {showDates && (
                      <details className={styles.dates}>
                        <summary>Voir les dates par groupe</summary>
                        <ul>
                          {Object.entries(calendar).map(([teacher, groupDates]) => (
                            <li key={teacher}>
                              <strong>{teacher}</strong>
                              <span>
                                {groupDates
                                  .map((groupDate) => {
                                    const [group, date] = Object.entries(groupDate)[0];
                                    return `${group} : ${formatDateFr(date)}`;
                                  })
                                  .join(" · ")}
                              </span>
                            </li>
                          ))}
                        </ul>
                      </details>
                    )}
                  </article>
                );
              })}
            </div>
          </details>
        );
      })}
    </div>
  );
}

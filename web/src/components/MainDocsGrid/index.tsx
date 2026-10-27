import React, { useEffect, useState } from "react";
import Link from "@docusaurus/Link";
import styles from "./MainDocsGrid.module.css";
import useBaseUrl from "@docusaurus/useBaseUrl";
import { useColorMode } from "@docusaurus/theme-common";
import { usePluginData } from "@docusaurus/useGlobalData";
import sidebarDocs from "./sidebarDocs";
import ProgressBar from "./ProgressBar";

export default function MainDocsGrid() {
  const [docs, setDocs] = useState<any[]>([]);
  const [meta, setMeta] = useState<any[]>([]);
  const [hoveredIndex, setHoveredIndex] = useState<number | null>(null);
  const [tooltipPos, setTooltipPos] = useState<{ x: number; y: number } | null>(
    null
  );
  const baseUrl = useBaseUrl("/");
  const metadataUrl = useBaseUrl("/docsMetadata.json");
  // Route des docs telle que configurée pour le plugin docs-metadata (ex : "notes")
  const { routeBasePath = "" } = (usePluginData(
    "docusaurus-plugin-docs-metadata"
  ) ?? {}) as { routeBasePath?: string };
  const { colorMode } = useColorMode();

  useEffect(() => {
    fetch(metadataUrl)
      .then((res) => {
        if (!res.ok) throw new Error("Métadonnées des cours indisponibles");
        return res;
      })
      .then((res) => res.json())
      .then((data) => setMeta(data))
      .catch(() => setMeta([]));
  }, [metadataUrl]);

  useEffect(() => {
    // Pour chaque entrée de la sidebar, trouver le doc correspondant (même si doublon)
    const docsList = sidebarDocs.map((entry: any) => {
      // Retirer le préfixe numérique et le tiret (ex: 01-rencontre1.1 -> rencontre1.1)
      const slug = entry.id.split("/").pop().replace(/^[0-9]+-/, "");
      const doc = meta.find((d: any) => d.id.replace(/^[0-9]+-/, "") === slug);
      return {
        ...doc,
        _sidebarLabel: entry.label,
        _sidebarProps: entry.customProps,
        _sidebarClassName: entry.className,
        _slug: slug,
      };
    });
    setDocs(docsList);
  }, [meta]);

  const docUrl = (doc: any): string => {
    // Le slug vient de la sidebar : il reste valide même si le doc n’a pas de métadonnées
    const slug = doc?._slug || doc?.id?.replace(/^[0-9]+-/, "");
    if (!slug) return baseUrl;
    const prefix = routeBasePath ? `${routeBasePath}/` : "";
    return `${baseUrl}${prefix}${slug}`;
  };

  const getBackgroundColor = (className: string): string => {
    if (className && className.includes("tp")) {
      return "var(--remise-tp-bg)";
    }
    if (className && className.includes("examen")) {
      return "var(--examen-bg)";
    }
    return "inherit";
  };

  const formatDateFr = (dateStr: string) => {
    if (!dateStr) return "";
    const [year, month, day] = dateStr.split("-").map(Number);
    const date = new Date(year, month - 1, day);
    return date.toLocaleDateString("fr-FR", {
      month: "long",
      day: "numeric",
    });
  };

  const resolveDocTitle = (doc: any): string => {
    const frontmatterTitle =
      typeof doc?.title === "string" && doc.title.trim().length > 0
        ? doc.title.trim()
        : undefined;
    const sidebarTitle =
      typeof doc?._sidebarLabel === "string" &&
        doc._sidebarLabel.trim().length > 0
        ? doc._sidebarLabel.trim()
        : undefined;
    const markdownTitle =
      typeof doc?._documentTitle === "string" &&
        doc._documentTitle.trim().length > 0
        ? doc._documentTitle.trim()
        : undefined;

    return frontmatterTitle || sidebarTitle || markdownTitle || doc?.id || "";
  };

  return (
    <div
      className={
        styles.gridContainer +
        (colorMode === "dark"
          ? ` ${styles.gridContainerDark}`
          : ` ${styles.gridContainerLight}`)
      }
    >
      {docs.map((doc, i) => {
        const calendrier = doc._sidebarProps?.calendrier;
        const tooltip = doc._sidebarProps?.tooltip;
        // Déterminer la position du tooltip (droite ou gauche)
        let tooltipSide: "left" | "right" = "right";
        if (hoveredIndex === i && tooltipPos) {
          const tooltipWidth = 200; // px, valeur approximative
          if (tooltipPos.x + tooltipWidth > window.innerWidth) {
            tooltipSide = "left";
          }
        }
        return (
          <Link
            key={i}
            to={docUrl(doc)}
            className={styles.gridItem}
            style={{
              backgroundColor: getBackgroundColor(doc._sidebarClassName),
              color: doc._sidebarProps?.color || "inherit",
              position: "relative",
            }}
            onMouseEnter={(e) => {
              if (tooltip !== "cache") {
                setHoveredIndex(i);
                const rect = (
                  e.currentTarget as HTMLElement
                ).getBoundingClientRect();
                setTooltipPos({ x: rect.right + 8, y: rect.top });
              }
            }}
            onMouseLeave={() => {
              if (tooltip !== "cache") {
                setHoveredIndex(null);
                setTooltipPos(null);
              }
            }}
          >
            <div>
              <h3>{resolveDocTitle(doc)}</h3>
              <p>{doc?.description || ""}</p>
            </div>
            <div>
              {typeof doc?._sidebarProps?.avancement === "number" && (

                <ProgressBar value={doc._sidebarProps.avancement} />
              )}
              <p className={styles.avancement}>
                {typeof doc?._sidebarProps?.avancementLabel === "string" && (<>
                  {doc._sidebarProps.avancementLabel}{" "}</>)}
                {typeof doc?._sidebarProps?.avancement === "number" && (
                  <>
                    {doc._sidebarProps.avancement * 100}% complété</>)}
              </p>


            </div>
            {hoveredIndex === i && calendrier && (
              <div
                className={
                  styles.tooltip +
                  (colorMode === "dark"
                    ? " " + styles.tooltipDark
                    : " " + styles.tooltipLight) +
                  (tooltipSide === "left"
                    ? " " + styles.tooltipLeft
                    : " " + styles.tooltipRight)
                }
              >
                <strong>Calendrier :</strong>
                <ul style={{ margin: 0, paddingLeft: 16, whiteSpace: "nowrap" }}>
                  {Object.entries(calendrier).map(([nom, groupedate]) => (
                    (groupedate as Array<Record<string, string>>).map((groupeObj, index) => {
                      const [groupe, date] = Object.entries(groupeObj)[0];
                      return (
                        <li key={index} style={{ whiteSpace: "nowrap" }}>
                          {nom} - {groupe} : {formatDateFr(date)}
                        </li>
                      );
                    })
                  ))}
                </ul>
              </div>
            )}
          </Link>
        );
      })}
    </div>
  );
}

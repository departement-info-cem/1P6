import React, { useId, useState } from "react";
import styles from "./DocsViewer.module.css";

interface TabConfig {
  id: string;
  label: string;
  icon?: string;
  component: React.ReactNode;
}

interface DocsViewerProps {
  tabs: TabConfig[];
  defaultTabId?: string;
}

export default function DocsViewer({ tabs, defaultTabId }: DocsViewerProps) {
  const panelId = useId();
  const [activeTabId, setActiveTabId] = useState<string>(
    defaultTabId || tabs[0]?.id || ""
  );

  const activeTab = tabs.find((tab) => tab.id === activeTabId);

  return (
    <div className={styles.container}>
      <div className={styles.toggleContainer} aria-label="Choisir une vue">
        {tabs.map((tab) => (
          <button
            key={tab.id}
            type="button"
            aria-pressed={activeTabId === tab.id}
            aria-controls={panelId}
            className={`${styles.toggleButton} ${
              activeTabId === tab.id ? styles.active : ""
            }`}
            onClick={() => setActiveTabId(tab.id)}
          >
            {tab.icon && <span className={styles.tabIcon}>{tab.icon}</span>}
            <span className={styles.tabLabel}>{tab.label}</span>
          </button>
        ))}
      </div>

      <div className={styles.viewContainer} id={panelId} role="region" aria-label={activeTab?.label}>
        {activeTab && activeTab.component}
      </div>
    </div>
  );
}

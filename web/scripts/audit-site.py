"""Contrôle des pages, liens, ancres et illustrations après un build Docusaurus.

Usage : python scripts/audit-site.py [--build-dir CHEMIN] [--json RAPPORT]
Les anciennes métadonnées générées sont ignorées si leur source ou leur ID
n'existe plus dans la version courante. Aucun fichier du site n'est modifié.
"""

import argparse
import json
import re
import sys
from collections import defaultdict, deque
from html.parser import HTMLParser
from pathlib import Path
from urllib.parse import unquote, urljoin, urlsplit

WEB = Path(__file__).resolve().parents[1]


class Page(HTMLParser):
    def __init__(self):
        super().__init__()
        self.links = []
        self.anchors = set()
        self.stack = []
        self.structure_errors = []

    def handle_starttag(self, tag, attrs):
        attrs = dict(attrs)
        if tag == "tr" and self.stack and self.stack[-1] == "table":
            self.structure_errors.append("ligne de tableau sans tbody/thead explicite")
        if tag not in {"area", "base", "br", "col", "embed", "hr", "img", "input", "link", "meta", "param", "source", "track", "wbr"}:
            self.stack.append(tag)
        if attrs.get("id"):
            self.anchors.add(attrs["id"])
        if tag == "a" and attrs.get("href"):
            self.links.append(attrs["href"])

    def handle_endtag(self, tag):
        if tag in self.stack:
            self.stack = self.stack[:len(self.stack) - 1 - self.stack[::-1].index(tag)]


def normalize(path):
    path = unquote(path)
    if path.endswith(".html"):
        path = path[:-5]
    if path.endswith("/index"):
        path = path[:-6]
    return path.rstrip("/") or "/"


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--build-dir", type=Path, default=WEB / "build")
    parser.add_argument("--json", type=Path)
    args = parser.parse_args()
    build = args.build_dir.resolve()
    global_file = WEB / ".docusaurus/globalData.json"
    if not global_file.is_file() or not (build / "index.html").is_file():
        parser.error("Lancer npm run build avant cet audit et vérifier --build-dir.")
    data = json.loads(global_file.read_text(encoding="utf-8"))
    version = data["docusaurus-plugin-content-docs"]["default"]["versions"][0]
    base = version["path"].rstrip("/")
    origin = "https://info.cegepmontpetit.ca"
    current = {doc["id"]: doc for doc in version["docs"]}
    documents = []
    for meta in (WEB / ".docusaurus/docusaurus-plugin-content-docs/default").glob("site-docs-*.json"):
        doc = json.loads(meta.read_text(encoding="utf-8"))
        source = WEB / doc.get("source", "").removeprefix("@site/")
        if doc.get("id") in current and source.is_file():
            documents.append((doc, source))
    built_sources = {source.resolve() for _, source in documents}
    unbuilt_sources = [str(source.relative_to(WEB)) for source in (WEB / "docs").rglob("*")
                       if source.suffix in {".md", ".mdx"}
                       and not any(part.startswith(("_", ".")) for part in source.relative_to(WEB / "docs").parts)
                       and source.resolve() not in built_sources]

    pages = {}
    invalid_html = []
    for html in build.rglob("*.html"):
        route = normalize(base + "/" + html.relative_to(build).as_posix())
        content = html.read_text(encoding="utf-8")
        if "\x00" in content:
            invalid_html.append({"file": str(html.relative_to(build)), "reason": "caractère NUL dans le HTML"})
        page = Page()
        page.feed(content)
        if page.structure_errors:
            invalid_html.append({"file": str(html.relative_to(build)), "reason": page.structure_errors[0]})
        pages[route] = page

    broken = []
    graph = defaultdict(set)
    for route, page in pages.items():
        for href in page.links:
            if href.startswith(("mailto:", "tel:", "javascript:", "data:")):
                continue
            target = urlsplit(urljoin(origin + route, href))
            if target.netloc and target.netloc != urlsplit(origin).netloc:
                continue
            if target.path != base and not target.path.startswith(base + "/"):
                continue
            destination = normalize(target.path)
            if destination in pages:
                graph[route].add(destination)
                if target.fragment and unquote(target.fragment) not in pages[destination].anchors:
                    broken.append({"from": route, "href": href, "reason": "ancre absente"})
            else:
                relative = unquote(target.path[len(base):]).lstrip("/")
                if not (build / relative).is_file():
                    broken.append({"from": route, "href": href, "reason": "cible absente"})

    reachable = set()
    queue = deque([base])
    while queue:
        route = queue.popleft()
        if route in reachable:
            continue
        reachable.add(route)
        queue.extend(graph[route] - reachable)
    orphan_pages = [str(source.relative_to(WEB)) for doc, source in documents
                    if normalize(doc["permalink"]) not in reachable]

    source_files = []
    for folder in [WEB / "docs", WEB / "src", WEB / "plugins", WEB / "static/quiz"]:
        source_files.extend(path for path in folder.rglob("*") if path.is_file()
                            and path.suffix in {".md", ".mdx", ".js", ".jsx", ".ts", ".tsx", ".css", ".json"})
    source_files += [WEB / "sidebars.js", WEB / "config.js", WEB / "docusaurus.config.js"]
    texts = {path: path.read_text(encoding="utf-8") for path in source_files}
    corpus = "\n".join(texts.values())
    pictures = [path for folder in [WEB / "docs", WEB / "static/img"] for path in folder.rglob("*")
                if path.suffix.lower() in {".png", ".jpg", ".jpeg", ".svg", ".webp", ".gif", ".ico"}]
    orphan_images = [str(path.relative_to(WEB)) for path in pictures if path.name not in corpus]
    orphan_data = [str(path.relative_to(WEB)) for path in (WEB / "static").rglob("*.json")
                   if path.name != "docsMetadata.json" and path.name not in corpus]
    editorial = []
    discussion = re.compile(r"^\s*(?:Oui\. Pour la question de synthèse|Souhaites-tu que je|Veux-tu que je|Voici une version (?:corrigée|améliorée)|En tant qu['’]IA)", re.I)
    for path, text in texts.items():
        if path.suffix not in {".md", ".mdx"}:
            continue
        for line, value in enumerate(text.splitlines(), 1):
            if discussion.search(value):
                editorial.append({"file": str(path.relative_to(WEB)), "line": line, "text": value})

    report = {"documents": len(documents), "html_pages": len(pages), "invalid_html": invalid_html, "unbuilt_sources": unbuilt_sources, "broken_links": broken,
              "orphan_pages": orphan_pages, "orphan_images": orphan_images, "orphan_data": orphan_data, "editorial_residue": editorial}
    if args.json:
        args.json.parent.mkdir(parents=True, exist_ok=True)
        args.json.write_text(json.dumps(report, ensure_ascii=False, indent=2), encoding="utf-8")
    for category in ["invalid_html", "unbuilt_sources", "broken_links", "orphan_pages", "orphan_images", "orphan_data", "editorial_residue"]:
        print(f"{category}: {len(report[category])}")
        for item in report[category][:30]:
            print("  " + (json.dumps(item, ensure_ascii=False) if isinstance(item, dict) else item))
    print(f"Documentation contrôlée : {len(documents)} pages sources actuelles.")
    return 1 if any(report[key] for key in ["invalid_html", "unbuilt_sources", "broken_links", "orphan_pages", "orphan_images", "orphan_data", "editorial_residue"]) else 0


if __name__ == "__main__":
    if hasattr(sys.stdout, "reconfigure"):
        sys.stdout.reconfigure(encoding="utf-8")
    sys.exit(main())

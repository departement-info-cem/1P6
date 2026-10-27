"""Crée ou vérifie une empreinte des sources du site, sans compilation.

python scripts/freeze-site.py create CHEMIN_MANIFESTE
python scripts/freeze-site.py check CHEMIN_MANIFESTE
Le manifeste est un rapport local : le conserver hors du dépôt.
"""

import argparse
import hashlib
import json
import os
import sys
from pathlib import Path

WEB = Path(__file__).resolve().parents[1]


def sources():
    paths = set()
    for folder in ["docs", "src", "plugins", "static", "scripts"]:
        paths.update(path for path in (WEB / folder).rglob("*") if path.is_file()
                     and "__pycache__" not in path.parts
                     and path.name != "sidebarDocs.js"
                     and path != WEB / "static/docsMetadata.json")
    # Les projets proposés en téléchargement font partie du contrat pédagogique.
    # On ne lit ici que leurs sources et ressources, jamais leurs sorties compilées.
    paths.update(path for path in (WEB.parent / "code").rglob("*") if path.is_file()
                 and not {"bin", "obj", ".vs", "__pycache__"}.intersection(path.parts)
                 and path.suffix.lower() not in {".dll", ".exe", ".pdb"})
    paths.update(path for path in WEB.iterdir() if path.is_file()
                 and path.suffix in {".js", ".json"})
    paths.update(path for path in (WEB.parent / ".github/workflows").glob("*.yml") if path.is_file())
    return {Path(os.path.relpath(path, WEB)).as_posix(): hashlib.sha256(path.read_bytes()).hexdigest()
            for path in sorted(paths)}


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("action", choices=["create", "check"])
    parser.add_argument("manifest", type=Path)
    args = parser.parse_args()
    hashes = sources()
    if args.action == "create":
        args.manifest.parent.mkdir(parents=True, exist_ok=True)
        args.manifest.write_text(json.dumps(hashes, indent=2), encoding="utf-8")
        print(f"Sources gelées : {len(hashes)} fichiers. Manifeste : {args.manifest}")
        return 0
    previous = json.loads(args.manifest.read_text(encoding="utf-8"))
    changed = sorted(path for path in hashes.keys() | previous.keys()
                     if hashes.get(path) != previous.get(path))
    for path in changed:
        print("MODIFIÉ : " + path)
    print(f"Contrôle du gel : {len(changed)} différence(s), {len(hashes)} fichiers actuels.")
    return 1 if changed else 0


if __name__ == "__main__":
    if hasattr(sys.stdout, "reconfigure"):
        sys.stdout.reconfigure(encoding="utf-8")
    sys.exit(main())

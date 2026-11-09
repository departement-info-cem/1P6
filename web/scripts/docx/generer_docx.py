#!/usr/bin/env python3
"""Génère les .docx des parties papier à partir de leur source Markdown.

Le Markdown est le même que celui affiché sur le site. Les fichiers produits
vont dans static/fichiers/ (non versionné) : le déploiement les génère avant
le build. Pour les avoir en local : python3 scripts/docx/generer_docx.py

Syntaxe reconnue : titres ###, paragraphes, `code`, **gras**, blocs ```
(showLineNumbers numérote les lignes) et tableaux. Le reste arrête le script.
Dans le .docx, un paragraphe finissant par « : » laisse de l'espace pour répondre.
Ne rien mettre ici qui soit confidentiel : ces fichiers sont publics.
"""
import re
import sys
import zipfile
from pathlib import Path
from xml.sax.saxutils import escape

WEB = Path(__file__).resolve().parents[2]
GABARIT = Path(__file__).with_name("gabarit.docx")
SORTIE = WEB / "static" / "fichiers"

DOCUMENTS = [
    {
        "source": WEB.parent / "code/examens/formatif_2_1p6/partie-papier.md",
        "sortie": "420-1P6-A26-Formatif2-Partie-papier.docx",
        "titre": "EXAMEN FORMATIF 2 - PARTIE PAPIER",
        "sous_titre": "Formatif",
        "session": "Automne 2026",
        "instructions": [
            ("DURÉE : ", "20 minutes maximum. La partie papier est remise avant de commencer la partie sur ordinateur."),
            ("MATÉRIEL PERMIS : ", "aucun (pas de notes, d'ordinateur ni de calculatrice)."),
            ("POINTAGE : ", "10 points. Répondez directement sur cette feuille."),
        ],
    },
]

LARGEUR_PAGE = 9360
COL_MIN = 1300
GRIS, BLEU = "F2F2F2", "D9E2F3"
BORDURES = "<w:tblBorders>" + "".join(
    f'<w:{c} w:val="single" w:color="auto" w:sz="4"/>'
    for c in ("top", "left", "bottom", "right", "insideH", "insideV")
) + "</w:tblBorders>"


def run(texte, police="Calibri", taille=22, gras=False, couleur=None):
    return (
        f'<w:r><w:rPr><w:rFonts w:ascii="{police}" w:cs="{police}" w:eastAsia="{police}" w:hAnsi="{police}"/>'
        + ("<w:b/><w:bCs/>" if gras else "")
        + (f'<w:color w:val="{couleur}"/>' if couleur else "")
        + f'<w:sz w:val="{taille}"/><w:szCs w:val="{taille}"/></w:rPr>'
        + f'<w:t xml:space="preserve">{escape(texte)}</w:t></w:r>'
    )


def para(*runs, apres=120, jc=None, garder=False):
    return (
        "<w:p><w:pPr>" + ("<w:keepNext/>" if garder else "")
        + f'<w:spacing w:after="{apres}"/>' + (f'<w:jc w:val="{jc}"/>' if jc else "")
        + f'</w:pPr>{"".join(runs)}</w:p>'
    )


def en_ligne(texte, **kw):
    """Convertit `code` et **gras** en runs."""
    runs = []
    for bout in re.split(r"(`[^`]+`|\*\*[^*]+\*\*)", texte):
        if bout.startswith("`"):
            runs.append(run(bout[1:-1], police="Consolas", taille=20))
        elif bout.startswith("**"):
            runs.append(run(bout[2:-2], gras=True))
        elif bout:
            runs.append(run(bout, **kw))
    return runs


def table_xml(largeurs, rangees):
    grille = "".join(f'<w:gridCol w:w="{l}"/>' for l in largeurs)
    return (
        f'<w:tbl><w:tblPr><w:tblW w:type="dxa" w:w="{sum(largeurs)}"/>{BORDURES}<w:tblLayout w:type="fixed"/></w:tblPr>'
        f'<w:tblGrid>{grille}</w:tblGrid>{"".join(rangees)}</w:tbl>'
    )


def rangee(cellules):
    return f'<w:tr><w:trPr><w:cantSplit/></w:trPr>{"".join(cellules)}</w:tr>'


def cellule(contenu, largeur, fond=None, marge=(80, 120), jc=None):
    m_v, m_h = marge
    ombre = f'<w:shd w:fill="{fond}" w:color="auto" w:val="clear"/>' if fond else ""
    return (
        f'<w:tc><w:tcPr><w:tcW w:type="dxa" w:w="{largeur}"/>{ombre}<w:tcMar>'
        f'<w:top w:type="dxa" w:w="{m_v}"/><w:left w:type="dxa" w:w="{m_h}"/>'
        f'<w:bottom w:type="dxa" w:w="{m_v}"/><w:right w:type="dxa" w:w="{m_h}"/>'
        f"</w:tcMar></w:tcPr>{contenu}</w:tc>"
    )


def bloc_code(info, lignes):
    if "showLineNumbers" in info:
        lignes = [f"{n}. {l}" for n, l in enumerate(lignes, 1)]
    contenu = "".join(para(run(l, police="Consolas", taille=20), apres=0, garder=True) for l in lignes)
    return table_xml([LARGEUR_PAGE], [rangee([cellule(contenu, LARGEUR_PAGE, GRIS, (100, 160))])]) + para(apres=60)


def cases(ligne):
    return [c.strip() for c in ligne.strip().strip("|").split("|")]


def tableau(lignes):
    entete, alignements, *corps = [cases(l) for l in lignes]
    if any(len(r) != len(entete) for r in corps) or not all(re.fullmatch(r":?-+:?", a) for a in alignements):
        raise ValueError(f"Tableau mal formé : {lignes[0]}")
    jc = ["center" if a.startswith(":") and a.endswith(":") else "right" if a.endswith(":") else "left" for a in alignements]
    # Chaque colonne est assez large pour son contenu; la dernière, où l'on répond, prend le reste.
    largeurs = [
        max(COL_MIN, 240 + 120 * max(len(r[i].strip("`")) for r in [entete] + corps))
        for i in range(len(entete) - 1)
    ]
    largeurs.append(LARGEUR_PAGE - sum(largeurs))
    if largeurs[-1] < COL_MIN:
        raise ValueError(f"Tableau trop large : {lignes[0]}")
    rangees = [rangee([
        cellule(para(run(t, gras=True), apres=0, jc=j), l, BLEU) for t, l, j in zip(entete, largeurs, jc)
    ])]
    for r in corps:
        # Une case déjà remplie est grisée, sauf le code, qui fait partie de la question.
        rangees.append(rangee([
            cellule(para(*en_ligne(t), apres=0, jc=j), l, GRIS if t and not t.startswith("`") else None)
            for t, l, j in zip(r, largeurs, jc)
        ]))
    return table_xml(largeurs, rangees) + para(apres=60)


def markdown_vers_xml(texte, source):
    xml, lignes, i = [], texte.splitlines(), 0
    while i < len(lignes):
        ligne = lignes[i]
        if not ligne.strip():
            i += 1
        elif ligne.startswith("### "):
            xml.append(
                '<w:p><w:pPr><w:pStyle w:val="Heading2"/><w:keepNext/><w:spacing w:after="120" w:before="280"/></w:pPr>'
                + run(ligne[4:], gras=True, couleur="1F3864", taille=24) + "</w:p>"
            )
            i += 1
        elif ligne.startswith("```"):
            fin = next((j for j in range(i + 1, len(lignes)) if lignes[j].startswith("```")), None)
            if fin is None:
                raise ValueError(f"{source}:{i + 1} : bloc de code non fermé")
            xml.append(bloc_code(ligne[3:], lignes[i + 1:fin]))
            i = fin + 1
        elif ligne.startswith("|"):
            debut = i
            while i < len(lignes) and lignes[i].startswith("|"):
                i += 1
            xml.append(tableau(lignes[debut:i]))
        elif re.match(r"(#|[-*+] |\d+\. |>|<|:::|import |!?\[)", ligne):
            raise ValueError(f"{source}:{i + 1} : syntaxe non gérée pour le .docx : {ligne}")
        else:
            debut = i
            while i < len(lignes) and lignes[i].strip() and not lignes[i].startswith(("|", "```", "#")):
                i += 1
            texte_p = " ".join(l.strip() for l in lignes[debut:i])
            xml.append(para(*en_ligne(texte_p), apres=480 if texte_p.endswith(":") else 120))
    return "".join(xml)


def entete(doc):
    b = [
        para(run("420-1P6 Programmation 1"), apres=0),
        para(run("Département d'informatique"), apres=0),
        para(run(doc["session"]), apres=240),
        para(run(doc["titre"], gras=True, taille=32), apres=60, jc="center"),
        para(run(doc["sous_titre"]), apres=240, jc="center"),
        para(run("Nom : ", gras=True), run("_______________________________________     "),
             run("Groupe : ", gras=True), run("________"), apres=240),
        para(run("Instructions", gras=True), apres=60),
    ]
    for n, (etiquette, texte) in enumerate(doc["instructions"], 1):
        b.append(para(run(etiquette, gras=True), run(texte), apres=240 if n == len(doc["instructions"]) else 60))
    return "".join(b)


def generer(doc):
    with zipfile.ZipFile(GABARIT) as gabarit:
        modele = gabarit.read("word/document.xml").decode("utf8")
        debut = modele[: modele.index("<w:body>") + len("<w:body>")]
        fin = modele[modele.rindex("<w:sectPr") :]
        corps = entete(doc) + markdown_vers_xml(doc["source"].read_text(encoding="utf8"), doc["source"].name)
        cible = SORTIE / doc["sortie"]
        with zipfile.ZipFile(cible, "w", zipfile.ZIP_DEFLATED) as z:
            for entree in gabarit.infolist():
                contenu = gabarit.read(entree.filename)
                if entree.filename == "word/document.xml":
                    contenu = (debut + corps + fin).encode("utf8")
                z.writestr(zipfile.ZipInfo(entree.filename, (2026, 1, 1, 0, 0, 0)), contenu, zipfile.ZIP_DEFLATED)
    print(f"Généré : {cible.relative_to(WEB)}")


if __name__ == "__main__":
    SORTIE.mkdir(parents=True, exist_ok=True)
    try:
        for doc in DOCUMENTS:
            generer(doc)
    except ValueError as erreur:
        sys.exit(f"Erreur : {erreur}")

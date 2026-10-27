const assert = require("node:assert/strict");
const fs = require("node:fs");
const path = require("node:path");
const { test } = require("node:test");
const ts = require("typescript");

// Le site est compilé par Docusaurus. Ce chargeur permet de tester ses fonctions
// TypeScript pures avec le runner de Node, sans lancer React ni un navigateur.
require.extensions[".ts"] = (module, filename) => {
  const source = fs.readFileSync(filename, "utf8");
  const { outputText } = ts.transpileModule(source, {
    compilerOptions: { module: ts.ModuleKind.CommonJS, target: ts.ScriptTarget.ES2020 },
    fileName: filename,
  });
  module._compile(outputText, filename);
};

const { parseQuizMarkdown } = require("../src/components/Quiz/quizMarkdown.ts");
const { validateQuiz, QuizRoom } = require("../src/components/Quiz/quizEngine.ts");
const { dateDuJour, trouverProchainCours, trouverTpCourant } = require("../src/components/NavigationRapide/navigationRapide.ts");
const pluginDocsMetadata = require("../plugins/docs-metadata");
const htmlIntegrity = require("../plugins/html-integrity");

test("les cinq quiz publiés sont lisibles et ont une réponse par question", () => {
  const directory = path.join(__dirname, "../static/quiz");
  const files = fs.readdirSync(directory).filter((file) => file.endsWith(".md"));
  assert.equal(files.length, 5);
  for (const file of files) {
    const quiz = validateQuiz(parseQuizMarkdown(fs.readFileSync(path.join(directory, file), "utf8")));
    assert.ok(quiz.questions.length > 0, file);
  }
});

test("les titres et marqueurs de choix dans un bloc de code restent du code", () => {
  const quiz = parseQuizMarkdown("# Quiz\n## Lire du texte\n```text\n## pas une question\n- [x] pas une réponse\n```\n- [x] Choix A\n- [ ] Choix B");
  assert.equal(quiz.questions.length, 1);
  assert.match(quiz.questions[0].texte, /pas une question/);
  assert.equal(quiz.questions[0].choix.length, 2);
});

const question = () => ({ texte: "Combien font 1 + 1 ?", choix: ["1", "2"], reponse: 1, duree: 10 });
test("un fichier de quiz rejette les réponses non entières et les durées invalides", () => {
  for (const reponse of [NaN, 0.5, -1, 2]) {
    assert.throws(() => validateQuiz({ questions: [{ ...question(), reponse }] }));
  }
  for (const duree of [NaN, Infinity, 0, -5]) {
    assert.throws(() => validateQuiz({ questions: [{ ...question(), duree }] }));
  }
  assert.throws(() => validateQuiz({ questions: [{ ...question(), choix: ["1", null] }] }));
});

test("une réponse invalide n'empêche pas ensuite une réponse valide", () => {
  const room = new QuizRoom({ questions: [question()] });
  room.players.set("p", { pseudo: "Joueur", score: 0 });
  room.startQuestion(0);
  assert.equal(room.recordAnswer("p", 0.5), false);
  assert.equal(room.recordAnswer("p", 5), false);
  assert.equal(room.answeredCount(), 0);
  assert.equal(room.recordAnswer("p", 1), true);
  assert.equal(room.recordAnswer("p", 0), false);
  assert.equal(room.answeredCount(), 1);
});

test("une réponse après la fin du chronomètre ne reçoit pas de points", () => {
  const room = new QuizRoom({ questions: [question()] });
  room.players.set("p", { pseudo: "Joueur", score: 0 });
  room.startQuestion(0);
  room.questionStartAt -= 11000;
  assert.equal(room.recordAnswer("p", 1), false);
  room.reveal();
  assert.equal(room.players.get("p").score, 0);
});

test("la date du calendrier conserve le jour local", () => {
  assert.equal(dateDuJour(new Date(2026, 9, 27, 0, 5)), "2026-10-27");
});

test("le prochain cours et le TP suivent le calendrier sans confondre TP1 et TP10", () => {
  const entree = (id, date, className) => ({ id, className, customProps: { calendrier: { Prof: [{ "1010": date }] } } });
  const entries = [entree("cours/a", "2026-10-26"), entree("cours/b", "2026-10-29", "remise-tp10"), entree("cours/c", "2026-11-02", "remise-tp1")];
  assert.equal(trouverProchainCours(entries, "2026-10-27"), "cours/b");
  assert.equal(trouverTpCourant(entries, [{ id: "tp/tp1", nom: "TP1" }], "2026-10-27"), "tp/tp1");
  assert.equal(trouverProchainCours(entries, "2027-01-01"), undefined);
});

test("la navigation reconnaît les vrais TP avec une icône dans le titre", async () => {
  let published;
  const docs = [
    { id: "tp/tp1", title: "🧪 TP1 – Créateur de personnage", sidebar: "tp" },
    { id: "tp/tp2", title: "🧪 TP2 – Mini-système d'inventaire", sidebar: "tp" },
    { id: "laboratoire/laboratoire9.2", title: "TP2", sidebar: "laboratoire" },
  ];
  await pluginDocsMetadata({}, {}).allContentLoaded({
    allContent: { "docusaurus-plugin-content-docs": { default: { loadedVersions: [{ docs }] } } },
    actions: { setGlobalData: (value) => { published = value; } },
  });
  assert.deepEqual(published.travauxPratiques.map(({ id, nom }) => ({ id, nom })), [
    { id: "tp/tp1", nom: "TP1" }, { id: "tp/tp2", nom: "TP2" },
  ]);
});

test("le build conserve les accents et les ancres en retirant les NUL du rendu React", async () => {
  const directory = fs.mkdtempSync(path.join(require("node:os").tmpdir(), "1p6-html-integrity-"));
  try {
    fs.mkdirSync(path.join(directory, "cours"));
    const expected = '<p>être</p><h3 id="boucles-imbriquées">Boucles imbriquées</h3><a href="#boucles-imbriquées">Lire</a>';
    const page = path.join(directory, "cours/for.html");
    fs.writeFileSync(page, expected.replace("être", "\u0000être").replace('href="#boucles-imbriquées"', 'href="#boucles-imbriqu\u0000ées"'));
    fs.writeFileSync(path.join(directory, "index.html"), expected);
    const asset = Buffer.from([0, 195, 169, 255]);
    fs.writeFileSync(path.join(directory, "image.png"), asset);
    await htmlIntegrity().postBuild({ outDir: directory });
    assert.equal(fs.readFileSync(page, "utf8"), expected);
    assert.equal(fs.readFileSync(path.join(directory, "index.html"), "utf8"), expected);
    assert.deepEqual(fs.readFileSync(path.join(directory, "image.png")), asset);
  } finally {
    assert.equal(path.dirname(path.resolve(directory)), path.resolve(require("node:os").tmpdir()));
    fs.rmSync(directory, { recursive: true, force: true });
  }
});

import assert from "node:assert/strict";
import { readFileSync } from "node:fs";
import { test } from "node:test";
import { challengeIds, challenges, checkResult } from "./challenges.mjs";
import { judgeSubmission, makeSource } from "./judge.mjs";

test("les onze défis console autonomes ont des cas de validation", () => {
  assert.equal(challengeIds.length, 11);
  for (const id of challengeIds) assert.ok(challenges[id].tests.length > 0, id);
});

test("un défi échoué ne peut pas être déclaré réussi par un résultat partiel", () => {
  assert.equal(checkResult({ contains: ["total : 16", "ligne : 4"] }, "total : 16", null), false);
  assert.equal(checkResult({ notContains: ["erreur"] }, "Erreur de saisie"), false);
});

test("le correcteur ajoute une entrée séparée et une culture française", () => {
  const source = makeSource("class Program { static void Main() {} }");
  assert.match(source, /class __DefisValidation/);
  assert.match(source, /CultureInfo\("fr-CA"\)/);
  assert.ok(!source.includes("using System.Linq"));
});

const judgeUrl = process.env.JUDGE0_TEST_URL;
for (const id of challengeIds) {
  test(`solution publiée acceptée : ${id}`, { skip: !judgeUrl, timeout: 120000 }, async () => {
    const markdown = readFileSync(`web/docs/04-solution/solution-${id}.md`, "utf8");
    const source = /```csharp\s*([\s\S]*?)```/.exec(markdown)?.[1];
    assert.ok(source, `Code manquant dans la solution ${id}`);
    const verdict = await judgeSubmission(id, source, { url: judgeUrl });
    assert.equal(verdict.passed, true, JSON.stringify(verdict.results));
  });
}

test("un programme incorrect ne gagne pas de point", { skip: !judgeUrl, timeout: 30000 }, async () => {
  const verdict = await judgeSubmission("variables-calculs",
    'class Program { static void Main() { System.Console.WriteLine("bonjour"); } }', { url: judgeUrl });
  assert.equal(verdict.passed, false);
});

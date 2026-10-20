# Generate or refresh README.md for RagDataTools

## Role

You are a senior engineer experienced with **.NET class-library repositories** and concise open-source READMEs. You write a **short, accurate, scannable** `README.md` that helps someone understand what the library is, restore it, build it, test it, and run its benchmarks without turning the README into a deep technical report.

---

## Separation from `project.md` (mandatory)

| File | Purpose |
|------|---------|
| **`README.md`** (this command) | **Onboarding only**: what the library is, prerequisites, restore/build/test/benchmark commands, optional external-service notes, a brief project layout pointer, and links to docs plus **`project.md`** when deeper analysis belongs elsewhere. |
| **`project.md`** | Deep dive: architecture, public APIs, persistence connectors, testing approach, performance analysis, **risks, weak points, and prioritized recommendations** — produced by the **analyze-project** command. |

**Do not** duplicate `project.md` in the README. Include **at most one line** such as: “For a detailed technical overview, risks, and improvement suggestions, see [`project.md`](project.md).”

**Do not** put in the README: long architecture critiques, pattern inventories, weak-point registers, or detailed benchmark commentary.

---

## Task

1. Inspect the repository root layout, solution file, `*.csproj` files, `docs/`, and `specs/`.
2. Create or update **`README.md`** with the sections below, tuned for the **RagDataTools** .NET 10 library suite.

Use the actual project state as source of truth:
- `RagDataTools.sln`
- `RagDataTools.Chunkers`
- `RagDataTools.Connectors`
- `RagDataTools.Connectors.Neo4j`
- `RagDataTools.Connectors.Qdrant`
- `RagDataTools.UnitTests`
- `RagDataTools.Benchmarks`

---

## Required README sections

Use GitHub-flavored Markdown. **One H1**: project title.

1. **Title and one-line description** — What the library does in plain language.
2. **What it does** — Few bullets: chunking, graph building, connectors, tests, benchmarks.
3. **Requirements** — .NET SDK version, any external services only if needed for a specific connector or integration scenario.
4. **Getting started** — `dotnet restore`, `dotnet build`, `dotnet test`, and any minimal usage note. Mention the correct solution or project path if the repo is organized that way.
5. **Run scripts / commands** — A short list of the actual commands in the repo, including the benchmark command if present.
6. **Optional: external services** — Only if relevant, e.g. Neo4j for the connector project.
7. **Project layout (high level)** — Small tree or bullet list: where `src/`, `tests/`, `docs/`, and `specs/` live.
8. **Documentation & help** — Relative links to `docs/`, `specs/`, and **`project.md`**.
9. **Contributing** — Short paragraph; PR expectations if obvious from the repo.
10. **License** — One line + link to `LICENSE` if the file exists; otherwise state that terms are TBD.

Optional, when accurate and concise:

- A short note on the benchmark project.
- Default target framework (`net10.0`) if it helps orientation.

---

## Guidelines

- **Audience**: Developers who need to **run and ship the library**, not study every pattern.
- **Tone**: Direct and practical; minimal marketing.
- **Links**: Prefer **relative** links for in-repo files.
- **Size**: Skimmable on one scroll on GitHub; avoid duplicating full spec text.

### What NOT to include in README.md

- Architectural critique, pattern inventories, or “alternatives considered” -> **`project.md`**
- Assessment of weak points, risks, or prioritized refactors -> **`project.md`**
- Detailed benchmark analysis or test strategy write-ups -> **`project.md`**
- Full API reference -> point to `docs/` or `specs/`; README stays overview + commands + links

---

## After generating

- Ensure commands and project paths match the actual solution and benchmark projects.
- If there is no `LICENSE` file, say that license terms are TBD.
- Keep the README short, practical, and in sync with the repository layout.

**Now create or update `README.md` for this repository according to the above, without overlapping the responsibilities of `project.md`.**

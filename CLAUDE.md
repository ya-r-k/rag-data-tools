# RagDataTools Claude Code Guide

## 1. PROJECT & AGENT SYNC

### Repository purpose

RagDataTools is a .NET 10 class-library suite for RAG data preparation. It chunks text, extracts structured Markdown/HTML content, builds chunk relationship graphs, extracts keywords, ingests documents, and exposes persistence abstractions/connectors. It is a reusable library suite, not a web API or hosted application.

### Authoritative context

- Read [`@AGENTS.md`](AGENTS.md) when present. It is not currently present; do not invent one unless the project explicitly adopts it.
- Read `.specify/memory/constitution.md` for non-negotiable governance, architecture, testing, performance, documentation, and review rules. The constitution is authoritative.
- Read the active feature artifacts under `specs/<feature>/`: `spec.md`, `plan.md`, `tasks.md`, `research.md`, `data-model.md`, `contracts/`, `quickstart.md`, and `checklists/` as applicable.
- Treat `project.md` as the technical deep dive and `README.md` as onboarding documentation. Keep their responsibilities separate.
- Cursor rules from `.cursor/rules/` are preserved in `.claude/rules/` and remain applicable by scope. Important rules include `general.mdc`, `specify-rules.mdc`, `rag-data-tools-tests.mdc`, `fake-infrastructure-data-builders.mdc`, `fake-infrastructure-models.mdc`, and `regex-provider-getforretrieving-naming.mdc`.
- Global Claude Code instructions and user instructions remain applicable. All agent responses and generated documentation must be in English.

### Solution structure

- `RagDataTools.Chunkers/`: chunking, Markdown extractors, regex providers, chunk models, relationships, and public extension-method APIs.
- `RagDataTools.Ingest/`: document conversion and ingest orchestration.
- `RagDataTools.KeywordExtraction/`: keyword extraction contracts and implementations.
- `RagDataTools.Connectors/`: persistence abstractions.
- `RagDataTools.Connectors.Neo4j/`: Neo4j persistence implementation.
- `RagDataTools.Connectors.Qdrant/`: Qdrant placeholder/in-progress connector.
- `RagDataTools.Di/`: composition and service-registration support.
- `RagDataTools.Unifiers/`: unifier support.
- `RagDataTools.FakeInfrastructure/`: test doubles and fake infrastructure.
- `RagDataTools.UnitTests/`: NUnit unit tests and reusable chunking fixtures/builders.
- `RagDataTools.Benchmarks/`: BenchmarkDotNet executable.
- `.specify/`: Spec Kit templates, scripts, and constitution.
- `.claude/commands/`: Claude Code slash-command implementations.
- `.claude/rules/`: Claude Code project rules migrated from Cursor.
- `specs/`: architecture/API/performance documentation and feature specifications.

### Working rules

- Inspect relevant existing code, project files, tests, and feature artifacts before editing.
- Preserve unrelated user changes in the working tree. Do not reset, checkout, or delete them.
- Keep changes focused and reviewable. Every class belongs in its own file.
- Use the constitution and active feature plan to resolve conflicts; do not weaken governance rules implicitly.
- After behavior changes, update tests and relevant `specs/` or public documentation.

## 2. BUILD, TEST & LINT COMMANDS

Run commands from the repository root. The solution targets `net10.0` and requires the .NET 10 SDK.

```bash
dotnet restore RagDataTools.sln
dotnet build RagDataTools.sln
dotnet build RagDataTools.sln --configuration Release
dotnet test RagDataTools.sln
dotnet test RagDataTools.sln --configuration Release --no-build
dotnet test RagDataTools.UnitTests/RagDataTools.UnitTests.csproj --configuration Release
dotnet run --project RagDataTools.Benchmarks/RagDataTools.Benchmarks.csproj --configuration Release
```

Use the following validation sequence for normal changes:

```bash
dotnet restore RagDataTools.sln && dotnet build RagDataTools.sln && dotnet test RagDataTools.sln
```

There is no separate repository lint command. Build-time style enforcement is enabled through `Directory.Build.props` with `StyleCop.Analyzers`, `AnalysisLevel=latest-recommended`, and `.editorconfig`. Run `dotnet build` to execute analyzers and code-style checks. Warnings are not currently treated as errors.

For feature work, use the repository's PowerShell scripts from the root as required by the command definitions:

```powershell
.specify/scripts/powershell/check-prerequisites.ps1 -Json
.specify/scripts/powershell/check-prerequisites.ps1 -Json -RequireTasks -IncludeTasks
.specify/scripts/powershell/setup-plan.ps1 -Json
```

Do not run benchmarks as a substitute for unit tests. Changes to chunking, relationship construction, regex-heavy extraction, or other hot paths should update or add BenchmarkDotNet coverage.

## 3. CODE STYLE & ARCHITECTURE RULES

### C# and repository style

- Use C# on `net10.0`, nullable reference types, implicit usings, and the solution's `LangVersion` settings.
- Follow `.editorconfig`, `stylecop.json`, and `Directory.Build.props`. Use four spaces, block-scoped namespaces, braces for control blocks, accessibility modifiers on non-interface members, and the repository's established naming conventions.
- Interfaces begin with `I`; types and public members use PascalCase. Prefer clear, explicit names over abbreviations.
- Prefer readonly fields, immutable/canonical models where practical, collection expressions when compatible, null propagation, pattern matching, and simple object/collection initializers when they improve clarity.
- Keep public APIs XML-documented. Avoid unnecessary dependencies and abstractions.
- Prefer fluent builders for reusable test setup. Keep production strategies separate from test-data builders.

### Architecture

- Keep a clear boundary between domain/application logic and infrastructure: `Chunkers` owns chunking and relationship behavior; `Connectors` owns persistence contracts and implementations.
- Keep the library consumable without requiring a host or mandatory dependency-injection container. Wire `IExecutor`, `INoteReadHandler`, and `INoteProcessor` chains explicitly where those patterns apply.
- Prefer extension methods as the main public chunking API for discoverability.
- Use regex or equivalent pattern-based extraction as the primary mechanism for chunk boundaries and structured Markdown elements. New patterns belong in regex providers and require focused tests.
- Regex-provider factory methods must start with `GetForRetrieving...`; do not introduce `Build...`, `Create...`, `Get...`, or `Make...` alternatives.
- Avoid repeated regex work and unnecessary allocations in hot paths. Consider benchmark impact for semantic chunking, deep extraction, relationship graph construction, and duplicate URL detection.
- Validate inputs and preserve nullable contracts. Do not introduce unsafe string interpolation for persistence queries; use the connector's safe parameterization patterns.
- Do not add HTTP or process boundaries unless the constitution is explicitly amended.

### Tests and fixtures

- Use NUnit, FluentAssertions, Microsoft.NET.Test.Sdk, AutoFixture, and Moq.AutoMock as established by the test project.
- Every test follows `// Arrange`, `// Act`, `// Assert` in that order.
- Test names follow `<methodname>_When<conditionbeingchecked>_Should<expectedresult>`.
- Do not use imperative loops in test bodies.
- Keep reusable fixtures under `RagDataTools.UnitTests/TestData` or `RagDataTools.UnitTests/Chunkers/TestData`.
- Keep fixture models canonical: use existing `ChunkModel` fields such as `RawContent`, `Data`, and `RelatedChunksIndexes`; do not add duplicate raw-content properties.
- Fixture builders should retain derived fluent return types and support code blocks, tables, images, info blocks, strange/odd-markup text, topics/headings, and code-block count ranges.
- New behavior must include unit tests. Connector, ingest, keyword-extraction, and edge-case changes should include tests at the appropriate layer.

### Spec Kit workflow

- `/speckit.specify` creates or updates a feature specification and its requirements checklist.
- `/speckit.clarify` resolves high-impact ambiguity before planning.
- `/speckit.plan` creates research, data-model, contracts, quickstart, and implementation-plan artifacts.
- `/speckit.tasks` creates dependency-ordered, story-labeled tasks.
- `/speckit.analyze` is read-only and checks consistency across `spec.md`, `plan.md`, and `tasks.md`.
- `/speckit.implement` executes tasks phase by phase and marks completed tasks.
- `/speckit.checklist` validates requirement quality, not implementation behavior.
- `/speckit.constitution` updates governance only when explicitly requested.
- `/speckit.taskstoissues` creates GitHub issues only when the configured remote is the matching GitHub repository.

## 4. CUSTOM COMMANDS & SKILLS

### Project slash commands

Claude Code commands are stored in `.claude/commands/`:

- `/analyze-project`: inspect the current .NET library and create/update `project.md` with architecture, APIs, testing, performance, risks, and recommendations.
- `/generate-readme`: create/update the concise onboarding `README.md` without duplicating the `project.md` deep dive.
- `/speckit.constitution`: create or amend `.specify/memory/constitution.md` and validate dependent templates.
- `/speckit.specify`: create a feature branch and specification from a feature description.
- `/speckit.clarify`: ask targeted clarification questions and write accepted answers into the active specification.
- `/speckit.plan`: produce the implementation plan and supporting research/design artifacts.
- `/speckit.tasks`: generate dependency-ordered implementation tasks from the specification and plan.
- `/speckit.checklist`: generate or append a requirements-quality checklist.
- `/speckit.analyze`: perform read-only cross-artifact consistency analysis.
- `/speckit.implement`: execute the active task plan, validate checklists, run tests, and mark tasks complete.
- `/speckit.taskstoissues`: convert active tasks into matching GitHub issues when the remote is a GitHub URL.

### Rules and settings

- `.claude/rules/` contains the migrated Cursor rules and should be updated when project-wide conventions change.
- `.claude/settings.local.json` contains local permission denials for sensitive configuration files, generated output directories, and parent-directory traversal. Respect those restrictions.
- No project-specific `.claude/skills/` directory is currently present. Use the repository commands above and globally installed Claude Code skills where applicable.
- No hooks or `.specify/extensions.yml` are currently registered. If extensions are added, follow the hook behavior documented by the relevant Spec Kit command.

### Operational expectations

- Before edits, state the intended scope briefly and read the target files.
- After edits, run the narrowest relevant tests, then the full solution build/test when practical.
- Report exact command failures and remaining test gaps. Do not claim validation that was not run.

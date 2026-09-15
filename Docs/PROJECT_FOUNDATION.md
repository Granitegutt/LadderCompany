# Project Foundation Notes

This document records the decisions made when establishing the initial Unreal
Engine 5 project foundation for Ladder Company, so they can be reviewed and
revised. It follows the "FIRST REPOSITORY TASK" checklist in `CLAUDE.md`.

## Starting state

- The repository contained only `CLAUDE.md` and two documents in `Docs/`.
- `Ladder_Company_Game_Design_Bible_v0.1.docx` and
  `Ladder_Company_Technical_Development_Brief_v0.1.docx` are currently **empty
  2-byte placeholder files**. Until they are filled in, `CLAUDE.md` is the sole
  source-of-truth design/technical document.
- No Unreal project, source, config, or assets existed.

## Environment

The foundation was created in a headless Linux container **without Unreal Engine
installed** (no `UnrealEditor` / `UnrealBuildTool`, and UE cannot be installed
here). A UE project's foundation is entirely text, so it was hand-authored to
match Epic's standard layout. It has therefore **not been compiled or opened by
the editor yet** — that verification must happen on a machine with UE 5.4.

## Decisions

### 1. Engine version: UE 5.4
`CLAUDE.md` commits to "Unreal Engine 5" without a point release. UE 5.4 was
chosen as a mature, widely deployed version with strong networking and Chaos
physics support — both directly relevant to the shared-ladder physics pillar
(multiplayer + physical object manipulation). `EngineAssociation` in the
`.uproject` is set to `"5.4"`; change it to match whatever version the project
owner actually installs.

### 2. C++ project with a single empty game module
The project is set up as a **C++ project** (not Blueprint-only) because the
design commits to C++ for networked, structured gameplay systems. Only the
**primary game module** (`Source/LadderCompany/`) was created — the minimum for
the project to compile. It contains **no gameplay classes**: no ladder,
character, game mode, fire, or floors. This respects "do not begin implementing
the full game" and "systems created before they are needed."

### 3. Minimal dependencies
`LadderCompany.Build.cs` depends only on `Core`, `CoreUObject`, `Engine`, and
`InputCore`. Enhanced Input, networking helpers, and Chaos physics helpers are
deliberately deferred until the prototype that needs them is built.

### 4. Minimal config
`Config/DefaultEngine.ini`, `DefaultGame.ini`, and `DefaultInput.ini` carry only
basic project identity. Rendering, physics, networking, and input mappings are
left to engine defaults until there is something concrete to test.

### 5. Source control conventions
- `.gitignore` ignores all engine-generated/machine-local output
  (`Binaries/`, `Intermediate/`, `Saved/`, `DerivedDataCache/`, IDE files, etc.).
- `.gitattributes` establishes **Git LFS** for binary asset types
  (`.uasset`, `.umap`, media) ahead of any assets landing, and normalizes text
  files. Run `git lfs install` per clone.
- `Content/` is kept in version control via a `.gitkeep` placeholder while empty.

## Not done (intentionally)

- No gameplay systems (ladder, movement, interaction, fire, floors, water).
- No procedural generation, progression, inventory, or polished assets.
- No maps/levels beyond none (default engine startup map).

## Next recommended step

Verify on a UE 5.4 machine: generate project files, build the `LadderCompany`
module, and confirm the editor opens with an empty default level. Once that is
confirmed, begin the **Ladder Prototype** per the recommended development order
in `CLAUDE.md` — starting with the multiplayer first-person player controller.

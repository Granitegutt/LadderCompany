# Ladder Company

> **Higher Together.**

A 2–4 player cooperative first-person firefighting game built around one central idea:

> Four firefighters must climb an enormous, dangerous, burning building together while sharing **one physical ladder**.

Shorthand pitch: *PEAK meets firefighting* — cooperative traversal and comedy, with its own mechanics, systems, and identity.

---

## Project status

**Foundation stage.** This repository currently contains only the Unreal Engine 5
project skeleton — enough to open and compile an empty C++ project. **No gameplay
systems exist yet** (no ladder, character, fire, or floors). The first gameplay
work will be the *Ladder Prototype* described in `CLAUDE.md`.

## Technology

- **Unreal Engine 5** (targeting **5.4** — see below)
- **C++** for structured/networked/reusable gameplay logic, **Blueprints** for iteration and designer-facing config
- **Git / GitHub** for source control (Git LFS for binary assets)

## Opening the project

1. Install **Unreal Engine 5.4** (via the Epic Games Launcher or a source build).
2. If your installed engine version differs, update `"EngineAssociation"` in
   `LadderCompany.uproject` to match it.
3. Run `git lfs install` once in your clone (binary assets will use LFS).
4. Right-click `LadderCompany.uproject` → **Generate project files**, then open it.
   The editor will offer to build the `LadderCompany` module the first time.

> This foundation was authored as text (the standard, source-control-friendly UE
> layout) in an environment without the engine installed, so it has **not** been
> compiled by the Unreal Editor yet. See `Docs/PROJECT_FOUNDATION.md`.

## Repository layout

```
LadderCompany.uproject      Project descriptor
Config/                     Project .ini configuration (minimal)
Source/                     C++ source
  LadderCompany.Target.cs         Game build target
  LadderCompanyEditor.Target.cs   Editor build target
  LadderCompany/                  Primary game module (currently empty)
Content/                    Unreal assets (empty; tracked via Git LFS)
Docs/                       Design & technical documentation
CLAUDE.md                   Primary source-of-truth design brief
```

## Source of truth

Design and technical direction live in `CLAUDE.md` and the `Docs/` folder. See
`Docs/PROJECT_FOUNDATION.md` for the decisions behind this foundation.

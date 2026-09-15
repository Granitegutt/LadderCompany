# LADDER COMPANY — CLAUDE CODE INSTRUCTIONS

## Project Identity

**Project:** Ladder Company  
**Tagline:** Higher Together.

Ladder Company is a 2–4 player cooperative first-person firefighting game built around one central idea:

> Four firefighters must climb an enormous, dangerous, burning building together while sharing one physical ladder.

The game is intended to create emergent teamwork, physics-driven comedy, environmental problem solving, escalating danger, and memorable moments between friends.

The shorthand pitch is:

> **PEAK meets firefighting.**

This describes the cooperative traversal/comedy appeal only. Ladder Company must have its own mechanics, environments, systems, characters, art direction, and identity.

---

## Your Role

You are the primary implementation/development agent for Ladder Company.

You are expected to:

- Build working game systems, not just prototypes that look convincing.
- Follow the design documents in this repository.
- Protect the game's core identity.
- Prefer simple, understandable systems over unnecessary complexity.
- Build multiplayer correctly from the beginning.
- Create small playable increments that can be tested quickly.
- Explain important technical decisions.
- Keep documentation synchronized with meaningful architectural changes.
- Avoid inventing features simply because they are technically interesting.

When uncertain about implementation details, prefer the smallest solution that preserves the intended gameplay.

---

## Source of Truth

The project's primary design references are:

- `Docs/GAME_DESIGN_BIBLE.md`
- `Docs/TECHNICAL_DEVELOPMENT_BRIEF.md`
- `CLAUDE.md`

If these documents conflict:

1. The latest explicit decision from the project owner takes precedence.
2. Preserve the core design pillars.
3. Do not silently redefine the game.
4. Flag meaningful conflicts before making a major architectural change.

---

# Current Project State

The repository may initially be blank.

Do **not** assume that the Unreal project, source structure, gameplay systems, or assets already exist.

Before implementing major gameplay systems:

1. Inspect the repository.
2. Establish the Unreal project foundation.
3. Establish source control conventions.
4. Create the minimum required project structure.
5. Confirm the project builds/opens correctly.
6. Then begin the first gameplay prototype.

Do not immediately attempt to build the complete game.

---

# Technology Direction

The current technology direction is:

- **Unreal Engine 5**
- **C++ + Blueprints**
- **Blender**
- AI-assisted 3D asset generation where appropriate
- **Git / GitHub**
- Claude Code as the primary implementation agent
- ChatGPT/Codex as a secondary design, architecture, debugging, and review partner

Use C++ for systems that benefit from strong structure, networking, reusable gameplay logic, or performance.

Use Blueprints where they improve iteration speed, designer-facing configuration, animation logic, simple interactions, or visual scripting.

Do not create C++ solely for the sake of using C++.

---

# Multiplayer Is Fundamental

Ladder Company is a cooperative multiplayer game.

Multiplayer must not be treated as a feature that gets added after the single-player prototype works.

The first meaningful gameplay prototype should test:

- Multiple players
- Shared ladder interaction
- Ladder movement
- Player interaction with the ladder
- Network synchronization
- Ownership/authority
- Physics behavior under multiplayer conditions

Use a server-authoritative approach where appropriate.

Do not build important shared gameplay systems around assumptions that only work in single-player.

---

# CORE DESIGN PILLAR: ONE LADDER

The most important gameplay rule is:

> **The team has ONE primary physical ladder.**

Four players do not each receive their own ladder.

The ladder is not:

- A button ability
- A magical inventory item
- A teleport tool
- A menu selection
- A disposable visual prop

It is a physical object that players must manipulate.

Players should be able to:

- Pick it up
- Carry it
- Rotate it
- Position it
- Lean it
- Drop it
- Retrieve it
- Climb it
- Use it as a bridge
- Use it to reach windows/balconies
- Use it to cross gaps
- Use it to navigate damaged structures
- Potentially use it as a lever/reach tool where physically plausible

The ladder should create teamwork problems.

Examples:

> "Hold it."

> "Move left."

> "No, YOUR left."

> "How are we getting the ladder back?"

> "Someone grab the bottom."

> "Why did you let go?!"

This is intentional.

---

# LADDER PHILOSOPHY

The ladder should feel physical.

Avoid making ladder placement feel like a traditional videogame interaction where the player presses a button and the game automatically snaps it into the correct position.

Whenever practical, players should physically manipulate the object.

However, physicality must remain fun.

If realistic simulation creates excessive frustration without adding meaningful gameplay, simplify it.

The target is:

> **Believable enough to be funny and useful, not realistic enough to become a simulator.**

---

# LADDER VARIANTS

The game should eventually support different ladder archetypes.

The team still receives only one primary ladder.

Different ladders should be meaningful tradeoffs rather than simple numerical upgrades.

Initial ladder concepts:

### Wooden Ladder — "The Liability"

- Heavy
- Stable
- Excellent as a bridge
- Cumbersome
- Flammable
- Can char, crack, or become damaged

### Aluminum Extension Ladder — "The Workhorse"

- Lightweight
- Long reach
- Compact when collapsed
- Versatile
- Conductive
- Potentially less stable when extended

### Fiberglass Ladder — "The Safe Choice"

- Durable
- Heavy/bulky
- Heat resistant
- Non-conductive
- Can still become damaged

Do not create dozens of ladder types during the initial prototype.

First prove that ONE ladder is fun.

---

# CORE DESIGN PILLAR: FIRE

Fire is a systemic environmental mechanic.

Fire should interact with:

- Fuel
- Heat
- Oxygen
- Ventilation
- Water
- Doors
- Windows
- Electrical systems
- Structural materials
- Objects
- Rooms
- Players

Fire should not simply behave like an enemy with a health bar.

The environment should change as fire spreads.

Heat should be communicated through:

- Fire intensity
- Smoke
- Visual distortion
- Sound
- Glowing materials
- Environmental damage
- Player reactions
- Equipment behavior

---

# FIRE IS ALSO A RESOURCE

Fire is not always something the player must immediately extinguish.

Players may sometimes need to deliberately use fire.

Examples:

- Burning through wooden blockages
- Destroying structures
- Triggering heat-sensitive mechanisms
- Creating light
- Consuming fuel to change the environment

The core tension is:

> **Can we use the fire without letting the fire use us?**

Players should discover these interactions naturally.

Do not cover the screen with tutorial prompts explaining every possible interaction.

---

# NO TRADITIONAL OBJECTIVE CHECKLIST

Avoid a conventional HUD containing:

- "Rescue 2 civilians"
- "Extinguish 5 fires"
- "Go to Floor 12"
- Waypoint arrows
- Constant objective-complete notifications

The environment should communicate what is happening.

Players should look at the world and think:

> "That person is trapped."

> "That hallway is blocked."

> "We need water."

> "The stairs are gone."

> "There's probably another way up."

> "If we break that window, the smoke might clear."

The environment is the objective.

---

# ENVIRONMENTAL PROBLEM SOLVING

Whenever practical, support multiple solutions.

Do not force a single correct interaction if a physically plausible alternative could work.

Players should be able to experiment.

Examples:

- Move furniture
- Break doors
- Break windows
- Use the ladder differently
- Redirect water
- Manipulate valves
- Burn obstacles
- Cross exterior ledges
- Use equipment creatively
- Push/pull environmental objects

If an idea is stupid but physically plausible, consider allowing it.

---

# PHYSICS & EMERGENT COMEDY

Comedy should primarily emerge from:

- Physics
- Teamwork
- Miscommunication
- Bad decisions
- Unexpected interactions
- Environmental consequences
- Friends making things worse

Avoid relying heavily on scripted jokes.

The ideal moment is:

> "I cannot believe that worked."

or:

> "Why did you do that?"

or:

> "How the hell are we getting that ladder back?"

---

# "DUMB IDEAS ARE ALLOWED"

The world should permit players to try questionable ideas.

Examples:

- Axe hits the wrong pipe → water everywhere
- Halligan opens the wrong door → heat surge
- Water reaches electrical equipment → dangerous situation
- Shopping cart rolls away
- Hose snags and pulls a player
- Player throws a questionable object into a fire → unexpected reaction

The game should not constantly protect players from themselves.

Failure can be funny.

---

# FLAMMABLE WORLD

The broad philosophy is:

> **Almost everything should have a material reaction.**

Not literally every object needs to burn.

Use meaningful categories.

### Low Fuel

- Paper
- Playing cards
- Newspapers
- Receipts
- Napkins
- Cardboard

### Medium Fuel

- Curtains
- Clothing
- Furniture
- Mattresses
- Carpets
- Wooden pallets

### High / Dangerous Fuel

- Cooking oil
- Propane
- Certain chemicals
- Large plastic storage
- Aerosol-type objects

### Non-Combustible Contrast

- Metal
- Glass
- Concrete
- Ceramic
- Water

Do not label objects "flammable."

Let players learn through experimentation.

---

# FLOOR PHILOSOPHY

The entire building is one continuous run.

Players do not select individual floors from a menu.

Each floor is a compact gameplay segment, generally around 5–15 minutes depending on complexity.

Players physically continue upward.

Possible routes include:

- Stairwells
- Elevator shafts
- Collapsed ceilings
- Windows
- Exterior ledges
- Balconies
- Damaged structures
- Ladders
- Service areas

Do not force an explicit "floor complete" moment if the natural flow can continue.

The run ends when the team fails.

After failure, players return to the menu.

Record progression such as:

> **Floor 31**

The goal is to create a strong "one more run" loop.

---

# DIFFICULTY

Difficulty should increase primarily through system combinations, not simply larger health bars or faster timers.

Early floors may introduce:

- Small fires
- Basic traversal
- Ladder manipulation

Later floors may introduce:

- Smoke
- Heat
- Fire spread
- Ventilation
- Water pressure
- Structural damage
- Explosions
- Exterior routes
- Multiple interacting hazards

Eventually:

> **The systems themselves become the difficulty.**

---

# CRAZY FLOORS

Some floors should be surprising, absurd, or chaotic.

Examples:

- Apartments
- Offices
- Hotels
- Supermarkets
- Casinos
- Restaurants
- Hospitals
- Schools
- Construction sites
- Industrial floors
- Parking garages
- Pools
- Arcades
- Nightclubs
- Aquariums
- Rooftops
- Warehouses
- Gyms
- Labs
- Hardware stores

Crazy floors are not merely visual skins.

Their:

- Geometry
- Objects
- Fuel
- Water access
- Hazards
- Traversal
- Fire behavior

should change how players solve problems.

---

# SUPERMARKET EXAMPLE

A supermarket floor may contain:

- Shopping carts
- Cardboard
- Shelving
- Freezers
- Food
- Packaging
- Pallets
- Loading docks
- Water sources

Shopping carts can:

- Carry equipment
- Carry downed teammates
- Transport objects
- Become obstacles
- Roll away
- Create accidental chaos

Cardboard should provide substantial fuel potential.

The supermarket should therefore play differently from an office.

---

# CASINO EXAMPLE

A casino floor may contain:

- Slot machines
- Playing cards
- Casino chips
- Neon lighting
- Security doors
- Chandeliers
- Electrical hazards
- Smoke
- Windows

Some interactions should be intentionally pointless.

Example:

> Throwing casino chips into a fire does basically nothing.

That is okay.

Not every object needs to provide an advantage.

Some objects exist so players can make bad decisions.

---

# WATER & HOSE

Water should be a physical/logistical system.

It should not simply be an infinite weapon.

Players may need to connect to:

- Standpipes
- Fire department hookups
- Water tanks
- Valves
- Stairwell connections
- Damaged building infrastructure

Pressure can be simplified into:

- Weak
- Normal
- Excessive

Excessive pressure can make the hose harder to control.

The hose may:

- Snag
- Tangle
- Wrap around objects
- Pull players
- Create teamwork problems

Potential two-player operation:

- Nozzle operator
- Hose manager

Core relationship:

> **Ladder = gets people where they need to go.**

> **Hose = gets water where it needs to go.**

> **Fire = what they manage.**

> **Heat/smoke = whether they survive.**

---

# EQUIPMENT PHILOSOPHY

The equipment mix should combine real firefighter tools with stupid/fun objects.

### Essential

- Fire axe
- Halligan
- Flashlight
- Radio

### Utility

- Thermal camera
- Portable extinguisher
- Rescue saw
- Repair kit

### Team / Traversal

- Rope
- Harness
- Ladder-related gear

### Fun / Dumb

- Water gun / super soaker
- Bucket
- Garden hose
- Shopping cart
- Random environmental objects

Silly objects can be useful, weak, situational, or completely pointless.

That is intentional.

---

# VISUAL DIRECTION

The game should use a distinct stylized 3D visual identity.

Target characteristics:

- Chunky characters
- Large readable silhouettes
- Expressive simple faces
- Oversized equipment
- Rounded/simple geometry
- Bright readable colors
- Stylized PBR materials
- Limited surface detail
- Readable environments
- Dramatic stylized fire and smoke

Do **not** copy PEAK's art style.

The goal is an original Ladder Company visual identity.

---

# DEVELOPMENT PHILOSOPHY

Build the game from the core outward.

Do not attempt to build:

- The entire building
- Full procedural generation
- Full fire simulation
- Every equipment type
- Dozens of floors
- Final character art
- Full progression
- Full UI

before proving the central gameplay.

The first question is:

> **Is four-player cooperation around one physical ladder actually fun?**

---

# FIRST PROTOTYPE: THE LADDER PROTOTYPE

The first meaningful prototype should contain:

- Multiplayer
- First-person movement
- Basic interaction
- One physical ladder
- Simple blockout building
- One meaningful gap
- Pick up / carry / drop
- Rotate / position / lean
- Climb
- Bridge a gap
- Multiplayer synchronization
- Player/ladder physics

Do not add full fire systems until the ladder interaction is proven.

---

# RECOMMENDED DEVELOPMENT ORDER

1. Unreal project foundation
2. Source control
3. Multiplayer player controller
4. Basic interaction system
5. Physical ladder
6. Ladder manipulation
7. Ladder climbing
8. Multiplayer ladder synchronization
9. Simple test building
10. Gap/bridge challenge
11. Basic firefighter character presentation
12. Basic equipment interaction
13. Basic fire prototype
14. Heat/smoke prototype
15. Water/hose prototype
16. Environmental interactions
17. Floor-generation framework
18. Content expansion
19. Progression/run systems
20. Polish and optimization

Do not skip directly to procedural generation.

---

# CODE QUALITY

Prefer:

- Clear names
- Small systems
- Reusable components
- Explicit ownership
- Clear networking responsibilities
- Minimal hidden state
- Comments explaining WHY when necessary

Avoid:

- Giant classes
- God objects
- Hard-coded gameplay everywhere
- Duplicate logic
- Unnecessary abstractions
- Systems created before they are needed

Do not over-engineer the prototype.

---

# DOCUMENTATION

Meaningful architectural decisions should be documented.

If a major system changes:

1. Update the relevant documentation.
2. Explain the reason for the change.
3. Note important tradeoffs.
4. Keep implementation aligned with the design documents.

Do not allow the codebase to quietly drift away from the design.

---

# GIT RULES

Use Git consistently.

Create focused commits.

Avoid huge commits containing unrelated changes.

Commit messages should describe the actual change.

Examples:

- `Initialize Unreal project`
- `Add multiplayer character prototype`
- `Add physical ladder actor`
- `Implement ladder pickup and carry`
- `Add replicated ladder movement`
- `Create ladder bridge test`
- `Add basic fire prototype`

Do not commit generated junk, local machine files, secrets, or credentials.

---

# TESTING RULES

Every meaningful gameplay system should have a testable behavior.

For example:

### Ladder

Test:

- Player can pick it up
- Player can drop it
- Player can rotate it
- Player can position it
- Player can climb it
- Multiple players can interact with it
- State synchronizes correctly
- Physics does not become catastrophically unstable

### Multiplayer

Test:

- Host behavior
- Client behavior
- Multiple simultaneous interactions
- Disconnect/reconnect behavior where relevant
- Authority
- Replication
- Physics ownership

Do not assume a system works because it works in a single-player editor session.

---

# REPORTING AFTER WORK

After completing a meaningful task, report:

### What changed
Short summary of implementation.

### Files changed
List important files.

### What was tested
Describe the test performed.

### Known issues
List anything incomplete or unreliable.

### Next recommended step
Suggest the next smallest logical development step.

Keep reports concise.

---

# WHEN TO ASK FOR APPROVAL

Do not ask for approval for every small implementation decision.

Use reasonable engineering judgment for:

- Naming
- File organization
- Minor implementation details
- Small refactors
- Bug fixes
- Basic test scaffolding

Ask before making major changes that affect:

- Core gameplay pillars
- Multiplayer architecture
- Major technology choices
- Core player loop
- Ladder philosophy
- Fire philosophy
- Permanent scope expansion

---

# SCOPE PROTECTION

Ladder Company should resist feature creep.

Before adding a system, ask:

1. Does it improve cooperative gameplay?
2. Does it support the physical-world philosophy?
3. Does it create interesting decisions?
4. Does it increase emergent moments?
5. Does it strengthen the firefighter fantasy?
6. Is it necessary now?

If the answer is mostly no, defer it.

---

# FIRST REPOSITORY TASK

If the repository is blank, your first task is NOT to build the entire ladder system.

First:

1. Inspect the repository.
2. Confirm the repository state.
3. Establish the Unreal Engine project foundation.
4. Establish the initial source structure.
5. Establish `.gitignore`.
6. Establish basic documentation structure.
7. Verify the project opens/builds.
8. Commit the foundation.
9. Report what was created.
10. Then proceed to the Ladder Prototype.

Keep the first implementation small enough to review.

---

# MOST IMPORTANT RULE

Everything should ultimately support this experience:

> **Four friends, one physical ladder, an enormous burning building, and increasingly ridiculous problems.**

When deciding whether a feature belongs in the game, ask:

> **Does this make four players sharing one physical ladder inside an unpredictable burning building more fun?**

If not, it probably does not belong in the current build.

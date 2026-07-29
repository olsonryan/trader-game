# Up and To The Right! (working title: Trading Game)

Real-time multiplayer stock trading "friendslop" game. Up to 4 players work together (and against the rules) in a stock trading company, climbing floors and ranks while running illicit side hustles to boost profits. Modeled after viral co-op hits like *Lethal Company* and *Schedule 1*.

## Status

Early design phase. No implementation yet. This document collects design notes as of 2026-07-28 and will evolve.

## Tech Stack

- **Engine**: Unity
- **Scripting**: C# in Visual Studio Community
- **Version Control**: GitHub
- **Networking**: Steamworks (4-player co-op)
- **Assets**: Blender
- **Aesthetic**: Low-poly, terminal-style trading UI

## Core Concept

- Up to 4 players, each working their own trading desk(s) inside a large office building.
- Trading happens on a 2D terminal-style interface (**TradeOS**) at physical desks in the 3D world.
- Players progress through **floors** and **ranks/promotions**, unlocking new asset classes and desk types as they climb toward the top floor.
- **Favours** are a currency earned by exceeding profit quota by a set margin, and are spent to unlock **illicit activities** — higher-risk, higher-reward ways to boost profit.
- Two enforcement tracks create risk/tension: **HR** polices internal illicit activity (drugs, insider trading, embezzlement), **Police** respond to external illicit activity (business/sector interference, terrorism).
- Open question: consequences of bankruptcy or sustained non-performance (demotion? termination? debt?).
- Future idea: hire assistants (NPCs or hires) to perform illicit activities, procure drugs, or distract HR on the player's behalf.

## Core Loop

1. Sit at a desk, trade assets in real time to hit (and ideally exceed) profit quota.
2. Exceeding quota by a margin earns **favours**.
3. Spend favours on illicit activities to accelerate profit or unlock advantages.
4. Illicit activity carries risk of HR or police enforcement.
5. Sustained profit performance earns promotions, unlocking new floors, desks, and asset classes.

## Progression

Each asset class unlocks at a floor milestone, with different desk ownership rules:

| Order | Asset Class | Unlock | Desk Count | Ownership |
|---|---|---|---|---|
| 1 | Stocks | Start | 1 per player (max 4) | Individual, always available |
| 2 | Bonds | Floor 10 | 1 (shared) | Team decision, purchasable |
| 3 | Options | Floor 20 | Max 4 | Individual, must purchase each |
| 4 | Commodities | Floor 30 | Max 4 | Individual, must purchase each |
| 5 | Futures | Floor 40 | Max 4 | Individual, must purchase each |
| 6 | Forex | Floor 50 | 1 (shared) | Team decision, purchasable |

Trading cadence varies by asset:
- **Stocks, options, commodities, forex**: tick and move by the second.
- **Futures**: tick and move by the day.
- **Bonds**: long-term, fixed payoff.

Design goal: all desk layouts/UIs are visually and functionally similar, so any player can recognize how to trade a new asset class quickly.

## Asset Relationships

- **Bonds**: unaffected by anything else — fixed profit, no market interaction.
- **Stocks ↔ Options**: option prices derive from underlying stock prices.
- **Commodities ↔ Futures**: commodity supply/demand shifts drive futures payoffs.
- **Forex**: driven by world simulation —
  - Local currency ($) rises with more (legitimate) economic/trading activity, falls with more illicit activity (crime, terrorism).
  - Foreign currency rises when international companies operate normally, falls when their operations are inhibited.

## Trading Mechanics

- Buy/sell operations on each desk to generate profit.
- Stocks: technical signals appear during the trading day; players can get "tips" (source TBD — likely interns/reports, see below).
- Time passes in in-game seconds; prices update every tick.

## Illicit Activities

### Internal (inside the office — enforced by HR)

- **Insider trading**: call in a favour to slightly move an asset's price.
- **Distract HR**: distract the roaming HR rep to create a window for PED use, insider trading, etc.
- **Bribe investors**: temporarily boosts commission earned on profit.
- **Embezzlement**: siphon funds from your book into a personal bank account.

### External (outside the office — enforced by Police)

- Business interference (manual)
- Business interference (criminal)
- Sector interference (manual)
- Sector interference (terrorist — domestic/international)

*(External activities need further definition — what do these actually do mechanically, and how do they tie back into the forex/world simulation?)*

## Performance-Enhancing Drugs (PEDs)

- **"Lucidite" / "Dream Eater"**: taken during the day; player sleeps and "dreams" of a tradable asset. That asset will spike very high (75% chance) or crash very low (25% chance) the next day.
- **"Spice" / "Essence"**: while active, shows a confidence interval each second for where the price will land over the next minute.

## Settings

### The Office Building
- The premier office building of the modern world.
- Players start on the ground floor in a broom-closet-sized space.
- Each floor up gets progressively fancier, reflecting rank/success.

### TradeOS
- The in-world trading terminal software, used at every desk.
- Has different "editions" per asset class, sharing a common layout/interaction language.

### Phone
- Order goods (coffee, food, office supplies).
- Text world contacts: drug dealers, other traders, criminals, terrorists, police, fire, interns.
- Monitor portfolio remotely (view only, no trading).
- Map.

### The World
- A few city blocks surrounding the office.
- Some standalone storefront businesses; most businesses are housed inside the office building.
- Police stations + patrolling police.
- Fire stations.
- Apartments.

### The Apartments
- *(Undefined — player housing? Off-hours activities? TBD.)*

### Office Life Flavor
- Interns prepare morning reports with useful (varying-accuracy) information for the next trading day.
- Sticky notes as an in-world communication/hint mechanism. *(Idea was unfinished — revisit.)*

## Open Questions

- What happens on bankruptcy or sustained non-performance? (Demotion, termination, debt mechanic, permadeath-style reset?)
- How do external illicit activities mechanically affect the world/forex simulation?
- What are the Apartments for?
- What's the full intern report / sticky note information-sharing system?
- Future: hireable assistants — scope of what they can do, how they're hired/paid, risk of them getting caught.

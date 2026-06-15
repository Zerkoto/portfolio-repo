# Project Progress

This file records meaningful project changes by date. It is not a live branch, pull-request, or working-tree status tracker.

Use this as the durable project history for completed change batches, documented decisions, verification, and known follow-up work at the time of the change. Use `docs/HANDOFF.md` for operational next-agent context and `docs/HOSTING.md` for deployment and domain architecture.

## 2026-06-16 - Premium Hero, Skills And Experience Upgrade

### Completed

- Added an optimized upright hero portrait from the supplied profile photo and wired it into the portfolio hero.
- Upgraded the hero into a two-column premium layout on desktop and a compact portrait-first layout on mobile.
- Rewrote the About section to emphasize cross-sector experience, operational excellence, automation, technical delivery, Neutron.bg, and academic achievement.
- Added a Skills section covering operations/support, data/automation, financial operations, and web/product delivery.
- Restored the company-linked Experience section using the previously stored company URLs for Man Group, MaltaPost, Ricardo, Tungsten Network, Carebuilder, and AbbVie.
- Added reusable inline SVG icons and richer card treatments across About, Skills and Experience.
- Updated metadata and documentation so the site is no longer described as image-free.

### Documented Decisions

- The profile photo is stored as an optimized local web asset, not referenced from the Desktop source file.
- Company links were restored from repo history and preserved exactly.
- Neutron.bg remains positioned as a selected side-hustle technical project, not formal employment.
- Public copy is more confident, but avoids invented metrics or confidential operational details.

### Verification

- Parsed all JSON content files successfully.
- Ran `dotnet build .\MyPortfolio.sln --no-restore` successfully with zero warnings and zero errors.
- Ran `dotnet publish .\src\BlazorApp\BlazorApp.csproj -c Release` successfully.
- Verified in browser that the portrait loads, four skill cards render, seven experience cards render, six restored company links are present, and desktop/mobile layouts have no horizontal overflow.

### Follow-Up

- Review the stronger public wording before merging to production.
- Consider adding a public Neutron.bg link only when the live/demo destination is ready and suitable.
- Keep validating any future claims about metrics, responsibilities, certifications, or confidential financial workflows before publishing them.

## 2026-06-16 - General Progress Record Added

### Completed

- Added this root-level dated progress record so future work has a durable summary outside branch or pull-request state.
- Linked the progress record from `README.md`.
- Updated `AGENTS.md` so future agents keep this file current after meaningful project changes.

### Documented Decisions

- `PROGRESS.md` should record dated change batches, not temporary branch names, live PR status, or local working-tree details.
- `docs/HANDOFF.md` remains the operational handoff log.
- `docs/HOSTING.md` remains the detailed source for domain, DNS, hosting, and workflow architecture.

### Verification

- Confirmed the file exists at the repository root.
- Confirmed `README.md` links to this file.
- Confirmed `AGENTS.md` instructs future agents to keep this file current.
- Ran `dotnet build .\MyPortfolio.sln --no-restore` successfully with zero warnings and zero errors.

### Follow-Up

- Add a new dated section whenever a meaningful product, architecture, deployment, or documentation change is completed.

## 2026-05-26 - Hosting Clarification And Portfolio Redesign

### Completed

- Clarified the hosting architecture: SuperHosting owns and renews `kpetrov.z.bg`, Azure DNS answers DNS for the domain, and Azure Static Web Apps serves the production portfolio.
- Identified GitHub Pages as a stale legacy hosting path rather than the production host, and removed the GitHub Pages workflow from the supported deployment process.
- Simplified the Azure Static Web Apps workflow by removing the unused API path, adding explicit least-privilege permissions, and updating the checkout/setup actions.
- Added agent-facing context through `AGENTS.md`, `docs/HANDOFF.md`, and `docs/HOSTING.md`.
- Redesigned the portfolio as an image-free responsive Blazor WebAssembly site with black/gold dark styling, silver/green light styling, persistent theme switching, semantic sections, safer public CV wording, SEO metadata, `robots.txt`, and `sitemap.xml`.
- Removed old template photography and unused social assets.
- Introduced cached JSON-backed content loading for the portfolio sections.

### Documented Decisions

- Keep SuperHosting as the paid domain registrar and renewal account.
- Keep Azure DNS and Azure Static Web Apps as the lowest-risk production path because the live custom domain already routes there successfully.
- Treat GitHub Pages as obsolete unless a future decision deliberately restores it as a maintained mirror.
- Keep public career wording factual and privacy-conscious until exact seniority, education, employer, certification, or confidential work details are explicitly approved for publication.
- Defer profile photography or generated visuals until the image purpose, licensing, dimensions, and performance treatment are agreed.

### Verification

- Ran local restore/build/publish checks for the Blazor solution.
- Parsed the JSON content files successfully.
- Verified the local site in browser at desktop, 390px, and 320px widths.
- Checked both dark and light themes, direct section links, contact links, lack of horizontal overflow, and absence of visible Blazor error state.
- Confirmed the release output includes `robots.txt` and `sitemap.xml`.

### Follow-Up

- Open, review, and merge the GitHub pull request when the changes are ready for production.
- Disable GitHub Pages in authenticated repository settings after merge so the stale public mirror is withdrawn.
- Verify the live Azure Static Web Apps deployment at `https://www.kpetrov.z.bg/` after merge.
- Plan and validate a .NET 10 LTS migration before .NET 8 reaches end of support on 2026-11-10.
- Add an approved profile photo or generated supporting imagery later if it strengthens the portfolio narrative without hurting performance or credibility.

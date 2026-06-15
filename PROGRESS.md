# Project Progress

This file records meaningful project changes by date. It is not a live branch, pull-request, or working-tree status tracker.

Use this as the durable project history for completed change batches, documented decisions, verification, and known follow-up work at the time of the change. Use `docs/HANDOFF.md` for operational next-agent context and `docs/HOSTING.md` for deployment and domain architecture.

## 2026-06-16 - SEO Audit, Social Preview Card and Metadata Enhancements

### Completed

- Conducted a full SEO audit covering `<head>` metadata, JSON-LD structured data, semantic HTML in components (Home, About, Skills, Experience), robots.txt, sitemap.xml, performance hints, and content richness.
- Researched Blazor WebAssembly SEO specifics (JS-rendered shell challenges, importance of static index.html signals) and 2026 modern practices including Generative Engine Optimization (GEO), Answer Engine Optimization (AEO), E-E-A-T signals, entity optimization via schema, and OG images for improved CTR and AI citation.
- Generated a 1200×630 professional social preview card using image-to-image transformation on the existing `kristiyan-profile.jpg` (preserving accurate likeness) with dark/gold site branding, name, title, and domain. Committed as `src/BlazorApp/wwwroot/images/kristiyan-og-card.jpg`.
- Updated `index.html`:
  - Added complete Open Graph image metadata (`og:image`, `og:image:width="1200"`, `og:image:height="630"`, `og:image:alt`).
  - Upgraded `<meta name="twitter:card">` to `"summary_large_image"` and added `twitter:image`.
  - Enriched JSON-LD `Person`: added Instagram to `sameAs` array (was present in footer data but missing from schema), added `"image"` property referencing the profile photo.
- Bumped CSS cache-buster version (`v=20260616-og-image`).

### Documented Decisions

- Chose absolute production URLs in meta tags for correct behavior post-deploy (local server still serves the asset at `/images/kristiyan-og-card.jpg` for testing).
- Focused on high-impact metadata and visual asset improvements; larger architectural change (build-time prerendering for better WASM initial HTML) noted as follow-up.
- Ensured Instagram (recently restored to footer) is now consistently represented in structured data for entity linking and AI/search.

### Verification

- `dotnet build .\MyPortfolio.sln --no-restore` completed successfully with zero warnings and zero errors.
- Ran local dev server; confirmed new meta tags visible via View Page Source, new image served directly, and JSON-LD parsable.
- Image is ~150KB, optimized for web/social.
- Changes align with researched best practices for both traditional SEO and AI-driven discovery.

### Follow-Up

- After merge/deploy, use Google Search Console to submit sitemap, monitor indexing, rich results, and Core Web Vitals.
- Test live social cards with official debuggers (Facebook Sharing Debugger, X Card Validator, LinkedIn Post Inspector).
- Consider adding build-time prerendering or static HTML snapshots in a future batch to improve crawlability of the Blazor WASM content beyond the shell.
- Expand Person schema (e.g. jobTitle, alumniOf, detailed knowsAbout) only after confirming public wording with user.

## 2026-06-16 - Instagram Contact Link Restored

### Completed

- Restored the Instagram social icon asset from repository history.
- Added Instagram back to the data-driven contact/social model with the `zerkoto` handle.
- Rendered Instagram alongside Email, GitHub and LinkedIn in the footer contact links.
- Bumped the content cache version so the updated social data is requested by deployed clients.

### Verification

- Parsed all JSON content files successfully.
- Ran `dotnet build .\MyPortfolio.sln --no-restore` successfully with zero warnings and zero errors.
- Ran `dotnet publish .\src\BlazorApp\BlazorApp.csproj -c Release --no-restore` successfully.
- Verified locally that the footer renders an Instagram link to `https://instagram.com/zerkoto`.

## 2026-06-16 - Investment Middle Office And Neutron Emphasis

### Completed

- Added investment analysis to the hero overview proof points and refreshed the headline positioning around Developer, Investment Middle Office and AI-assisted automation.
- Reworked public copy to emphasize Middle Office financial analysis, investment operations, pricing, valuation, P&L, reconciliations, instrument lifecycle knowledge, derivatives and market awareness.
- Added a dedicated `Investment Middle Office` About card based on public Man Group/AHL and Man Group operations role descriptions, while keeping the wording personal and non-confidential.
- Removed the academic-scholarship highlight chip to reduce visual clutter.
- Converted About highlights from plain strings to link-capable objects and made the Neutron.bg highlight clickable.
- Updated the Neutron.bg experience card to link to the live Django e-commerce site at `https://www.neutron.bg/`.
- Replaced older repetitive support/release wording with development, analysis, production diagnostics, workflow ownership and business-result language.

### Documented Decisions

- Describe Man Group as one of the world's largest listed hedge fund managers and global alternative investment firms, rather than using an unqualified "largest hedge fund in the world" claim.
- Keep Neutron.bg positioned as a live personal technical/e-commerce project, not formal employment.
- Use public Man Group role language as a reference for Middle Office themes, but do not copy job-description wording verbatim or publish confidential role details.

### Verification

- Confirmed `https://www.neutron.bg/` returns HTTP 200 from the local workstation.
- Parsed all JSON content files successfully.
- Ran `dotnet build .\MyPortfolio.sln --no-restore` successfully with zero warnings and zero errors.
- Ran `dotnet publish .\src\BlazorApp\BlazorApp.csproj -c Release --no-restore` successfully.
- Verified in browser that the hero proof points include investment analysis, Neutron.bg is clickable from About and Experience, and the updated sections have no horizontal overflow at desktop or 390px mobile width.

### Follow-Up

- Review the strength of the public finance wording before merging, especially the stocks/crypto/derivatives language.
- Add more exact Man Group role/title detail only if it is approved for public publication.

## 2026-06-16 - Developer And AI Positioning Refinement

### Completed

- Fixed the hero portrait signal pills so they align below the profile image instead of overlapping the hero text or portrait caption.
- Replaced the second hero signal pill wording from `Support Controls Delivery` to `Development Support Results`.
- Reworked hero, About, Skills, metadata and page title copy so the public positioning reads more clearly as developer-oriented.
- Added explicit AI-assisted development positioning, including daily use of AI tools and coding agents for development, analysis, documentation and delivery.
- Added an `AI-Assisted Development` skill group and refreshed support wording toward development, support and results.

### Documented Decisions

- Keep the stronger developer/AI wording factual and broad, without adding unverified metrics, certifications, role titles, or confidential client detail.
- Keep the portrait signal pills visually tied to the image card on desktop and mobile by making them full-width within the hero visual column.

### Verification

- Parsed all JSON content files successfully.
- Ran `dotnet build .\MyPortfolio.sln --no-restore` successfully with zero warnings and zero errors.
- Ran `dotnet publish .\src\BlazorApp\BlazorApp.csproj -c Release --no-restore` successfully.
- Verified in browser at 2048px desktop width that the signal pills no longer overlap the hero copy or portrait.
- Verified in browser at 390px mobile width that the signal pills do not cause horizontal overflow and the longer wording wraps inside the pill.

### Follow-Up

- Review the stronger developer/AI wording before merging to production.
- Keep future AI-related claims focused on actual workflow habits unless the user approves more specific tooling, project or outcome details for publication.

## 2026-06-16 - Premium Hero, Skills And Experience Upgrade

### Completed

- Added an optimized upright hero portrait from the supplied profile photo and wired it into the portfolio hero.
- Upgraded the hero into a two-column premium layout on desktop and a compact portrait-first layout on mobile.
- Rewrote the About section to emphasize cross-sector experience, operational excellence, automation, technical delivery, Neutron.bg, and academic achievement.
- Tightened the final About wording to explicitly state many years of cross-sector experience, consistent delivery, the Neutron.bg side-hustle being built and run, and the Master's degree graduation with Honours and full academic excellence.
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

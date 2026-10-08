# Project Handoff Log

Read the newest entry first when resuming work. Git history remains the authoritative file-level record; this file records operational context and decisions that are otherwise easy to lose.

## Current Snapshot - 2026-05-26

- Local repository path: `C:\Users\zerko\Documents\GIT\portfolio-repo`.
- GitHub repository: `https://github.com/Zerkoto/portfolio-repo`.
- Production site: `https://www.kpetrov.z.bg/`.
- Application: .NET 8 Blazor WebAssembly app under `src/BlazorApp`.
- Domain ownership/renewal: SuperHosting manages the paid `kpetrov.z.bg` domain and currently delegates it to Azure DNS nameservers.
- Hosting route: GitHub `main` -> Azure Static Web Apps workflow -> Azure Static Web App, reached through the `kpetrov.z.bg` records in Azure DNS; details are in `docs/HOSTING.md`.
- A Git push dry run from this workstation succeeded on 2026-05-26, confirming the configured Git credentials can publish a feature branch to the GitHub repository without publishing one during that check.
- The GitHub CLI (`gh`) and Azure CLI (`az`) were not available in the current shell during the investigation. Git can push changes; portal-specific confirmation currently requires the Azure portal or installing/authenticating a CLI.

## Open Decisions

- Approve the recommended cleanup: remove/disable `.github/workflows/publish-gh-pages.yml` and disable the unused GitHub Pages publication in repository settings so the outdated `https://zerkoto.github.io/portfolio-repo/` mirror is no longer public.
- Confirm in Azure Static Web Apps > Custom domains that both `kpetrov.z.bg` and `www.kpetrov.z.bg` are registered to the `CV-Portfolio` app.
- Decide whether keeping Azure DNS as the authoritative DNS service is acceptable. It is the lowest-risk current setup; moving DNS management back to SuperHosting should happen only after confirming it supports the required Azure Static Web Apps apex-domain records or forwarding behavior.

## Change Log

### 2026-10-08 - Existing Azure Preview Publication Authorized

- The user subsequently requested updating the existing PR #6 Azure preview with the reviewed financial-automation content. This authorizes the preview deployment; production publication and merging still require separate approval.
- Publish the reviewed local `codex/financial-automation-content` changes to the existing PR head `codex/portfolio-recruiter-polish`, which was rechecked at `48b3c8a` before publication. A normal fast-forward push invokes the unchanged Azure pull-request workflow and retains the existing preview URL.
- Reviewed source and local Release verification remain the content-refinement batch described below. No further public copy, design, dependency, hosting or workflow changes accompany this publication.
- Verify the deployment workflow and hosted JSON/browser rendering after publication. Review artifacts stay under `/workspace/scratch/portfolio-financial-content/` outside the repository.

### 2026-10-08 - Financial Data Automation Content Review

- Inspected the latest PR #6 branch/head `48b3c8a` and its deployed Azure preview before editing; did not restore older `main` copy. Created local review branch `codex/financial-automation-content` from that head.
- Refined all four portfolio content JSON sources, small component labels/intro copy, page/SEO/structured data and the content cache version (`20261008-financial-automation`). Python/Pandas, APIs, Linux, Streamlit, financial reporting and approximately 100 fund-level Excel inputs now have explicit evidence. Man Group uses the user's requested leading alternative-manager description and confirmed Man AHL/Man Numeric business scope; existing role titles are preserved.
- Kept four Man Group highlights and six Skills cards, distinguishing investment operations from LDC commodity pricing/ZEMA/governance. Preserved Neutron.bg and the remaining five Experience entries. No CSS, JavaScript, visual assets, dependencies, hosting or workflow changes.
- `docs/CONTENT_SOURCES.md` now records the user's firsthand confirmation and separates it from related-role research. Do not infer ownership of all scripts/tools, quantitative strategy design, independent OTC pricing or investment authority; keep NAV, trading capital (GAV) and notional exposure distinct.
- Verified solution build (zero warnings/errors), Release publish, JSON/JSON-LD parsing, diff checks, required keyword coverage and Chromium at 320–2560px in both themes. No clipping/overflow or browser/application-request errors. Checked row/link alignment, menu/Escape, theme persistence, skip navigation and local section targets. Existing external URLs are unchanged.
- Local Release preview runs at `http://127.0.0.1:5090/` during this session. Review artifacts are under `/workspace/scratch/portfolio-financial-content/`; generated files remain outside the repository.
- **The user explicitly requires approval before any deployment or merge.** This batch has not been pushed, deployed or merged. The existing [PR #6 Azure preview](https://ashy-pebble-014ec8203-6.westeurope.3.azurestaticapps.net/) still shows the previous approved-to-preview batch. Do not push this work to the open PR branch or open another deployment-triggering PR before approval.
- Social-preview artwork still contains the older embedded subtitle; leave the approved artwork and .NET 10 migration for separate work.

### 2026-10-08 - Recruiter Copy And Responsive UI Polish

- Rewrote portfolio JSON, component headings, footer and metadata around confirmed systematic-fund responsibilities at Man Group alongside current LDC pricing and technical delivery. Man Group wording uses the verified qualifier `publicly listed`; scope includes Bloomberg pricing, P&L, custodian/FA tie-outs and the user's described feeder GAV/master NAV structure.
- Researched related Man Group roles and official Middle Office biographies to frame the final copy around investment operations and product control. `docs/CONTENT_SOURCES.md` records sources and their limits; it does not imply a specific AHL/Numeric team, unconfirmed duties or advertised-role seniority. The fund mechanics are summarized as trading-capital rebalancing rather than repeated literally.
- Refined `app.css` for aligned card content with subgrid/flex fallback and six Skills cards in 3/2/1 columns. Mobile shows the career introduction first and uses an expandable, keyboard-accessible menu. Preserved portrait, themes, external destinations, hosting and workflows.
- Fixed missing `BlazorApp.styles.css`, guarded theme storage and malformed hashes, restored anchors after delayed JSON renders, and corrected keyboard skip-link focus. CSS/content versions are `20261008-recruiter-polish`.
- Verified JSON/diff checks, solution build (zero warnings/errors), Release publish and Chromium views at 320–2560px, both themes, menu/keyboard/theme persistence, denied storage and 2.2-second delayed-content anchors; no horizontal overflow or browser/request errors. Installed the pinned .NET 8.0.408 SDK in this session at `/workspace/.dotnet`; no toolchain files or dependencies changed.
- Feature branch: `codex/portfolio-recruiter-polish`. Review its Azure Static Web Apps preview before merging; do not merge automatically.
- Still outstanding: approved social-preview artwork contains the previous subtitle; .NET 10 migration remains separate.
- Scale wording sources: [LSEG CIO interview](https://www.lseg.com/en/solutions/hedge-funds/podcast/hedge-fund-huddle/season-4-episode-1-centuries-strategy-a-conversation-with-man-groups-cio) and [Hedgeweek, 2026-07-28](https://hedgeweek.com/news/man-group-assets-hit-record-253-6bn-after-strong-h1-inflows-and-performance).

### 2026-07-16 - LDC Senior Pricing Middle Officer Experience

- Added Louis Dreyfus Company as the newest Experience card and updated the hero, About, Skills, footer, page title, SEO metadata, structured data and README to reflect commodity pricing, physical agricultural markets, valuation, P&L, risk, Python, SQL and AI-assisted automation.
- Renamed the Neutron.bg category from `Selected Project` to `Independent Product Delivery` and rewrote its role, sector, description and evidence in a more professional product-delivery voice.
- Updated the dead Tungsten Network homepage link to the current official Tungsten e-Invoice Network product page; no hosting, DNS, Azure, GitHub Actions, dependency, theme or profile-photo changes were made.
- Verified JSON parsing, `git diff --check`, restore, build and Release publish; browser-tested desktop and mobile layouts, dark/light theme switching, navigation, eight Experience cards with LDC first, no horizontal overflow and no browser-console errors.
- Automated link checks succeeded for six Experience destinations. LDC and AbbVie returned HTTP 403 to scripted requests but retain their canonical official URLs.
- Branch: `codex/add-ldc-pricing-experience`. Pull-request title: `Add LDC Senior Pricing Middle Officer experience`. Do not merge automatically; review the Azure Static Web Apps preview first.
- Unfinished visual decision: `src/BlazorApp/wwwroot/images/kristiyan-og-card.jpg` still contains the previous embedded subtitle and should be refreshed separately without changing the approved portrait or layout.

### 2026-06-17 - Hero Portrait Direction Adjustment

- Changed only the rendered hero portrait styling so the approved profile image appears mirrored and visually faces the adjacent hero copy.
- Affected files: `src/BlazorApp/wwwroot/css/app.css`, `src/BlazorApp/wwwroot/index.html`, `PROGRESS.md`, `docs/HANDOFF.md`.
- Verified `origin/main` was current before editing; ran `dotnet build .\MyPortfolio.sln --no-restore` successfully with zero warnings and zero errors.
- No deployment, DNS, Azure, GitHub Actions, metadata image, or source portrait asset changes were made.
- Pull request: `https://github.com/Zerkoto/portfolio-repo/pull/4`.
- Unfinished work: after merge and Azure Static Web Apps deployment, review the live hero visual at `https://www.kpetrov.z.bg/`.

### 2026-06-16 - SEO Audit, Social Preview Card and Metadata Enhancements

- Performed comprehensive SEO audit of the Blazor WASM portfolio (head metadata, JSON-LD, semantic components, robots/sitemap, content for E-E-A-T and AI signals).
- Researched Blazor WASM SEO limitations and 2026 practices (GEO/AEO, schema enrichment, OG images for CTR and AI citation).
- Generated 1200×630 og:image social card via image-to-image on the profile portrait (dark/gold branding matching site). Added to `wwwroot/images/kristiyan-og-card.jpg`.
- Updated `index.html`: full `og:image` tags (with width/height/alt), `twitter:card` to `summary_large_image` + `twitter:image`, added Instagram to JSON-LD `sameAs`, added `image` to Person schema.
- Bumped cache version.
- Verified: clean `dotnet build`, local server shows tags in View Source and serves the image asset.
- Benefits: stronger social previews and modern search/AI entity understanding.
- Note: This batch was Grok-initiated. Per user request, future non-Codex agent work will prefer a `Grok/` branch prefix (the `codex/` convention in AGENTS.md is specific to Codex-driven changes and creates no technical or handoff problems for other agents). The PR for this work was created/merged under the existing naming for continuity.

### 2026-06-16 - Instagram Contact Link Restored

- Restored `src/BlazorApp/wwwroot/images/socials/instagram.svg` from repository history.
- Added Instagram back to `SiteProperties`, `SocialIcons`, `siteproperties.json`, `socialicons.json`, and the footer contact-link rendering.
- Used the previously committed Instagram handle `zerkoto`.
- Bumped the content cache version and verified JSON parsing, `dotnet build .\MyPortfolio.sln --no-restore`, `dotnet publish .\src\BlazorApp\BlazorApp.csproj -c Release --no-restore`, and local footer rendering of `https://instagram.com/zerkoto`.

### 2026-06-16 - Investment Middle Office And Live Neutron Link

- Added investment analysis to the hero overview and refreshed public positioning around Developer, Investment Middle Office, AI-assisted automation, Python and SQL.
- Reworked About, Skills and Experience copy to emphasize Middle Office financial analysis, investment operations, pricing, valuation, NAV/P&L, reconciliations, instrument lifecycle knowledge, derivatives and market awareness.
- Added a fourth About focus card, `Investment Middle Office`, grounded in public Man Group/AHL and Man Group operations role themes without copying job-description text verbatim.
- Removed the academic-scholarship highlight chip and converted About highlights into link-capable objects.
- Added a clickable About highlight and Experience link for the live Neutron.bg Django e-commerce project at `https://www.neutron.bg/`.
- Verified `https://www.neutron.bg/` returned HTTP 200 from the local workstation, parsed JSON, ran `dotnet build .\MyPortfolio.sln --no-restore`, ran `dotnet publish .\src\BlazorApp\BlazorApp.csproj -c Release --no-restore`, and checked local browser rendering at desktop and 390px mobile widths with no horizontal overflow.

### 2026-06-16 - Developer And AI Hero Copy Refinement

- Fixed the hero signal pills by removing their negative offsets and making them full-width within the portrait column, preventing `AI / Python / SQL` and `Development / Support / Results` from overlapping the hero copy or profile image.
- Updated the hero, About, Skills, page title and SEO metadata to present Kristiyan more clearly as a developer using AI-assisted coding, agents, Python and SQL in modern delivery workflows.
- Replaced the old `Support / Controls / Delivery` signal wording with `Development / Support / Results`.
- Added an `AI-Assisted Development` skill group and refreshed the support skill group as `Development, Support And Results`.
- Verified JSON parsing, `dotnet build .\MyPortfolio.sln --no-restore`, `dotnet publish .\src\BlazorApp\BlazorApp.csproj -c Release --no-restore`, and local browser rendering at 2048px desktop and 390px mobile widths with no signal-pill overlap or horizontal overflow.
- A local preview was run at `http://127.0.0.1:5080/` during this session.

### 2026-06-16 - Premium Portfolio Content And Hero Photo

- Added the supplied profile photo as an optimized local hero asset at `src/BlazorApp/wwwroot/images/profile/kristiyan-profile.jpg`.
- Upgraded the hero, About, Skills, Experience and Footer presentation for a more polished personal-brand portfolio while keeping the one-page Blazor structure.
- Restored company-linked experience cards using the previously committed URLs for Man Group, MaltaPost, Ricardo, Tungsten Network, Carebuilder and AbbVie.
- Added `skills.json`, `SkillGroup`, `Skills.razor`, and reusable inline SVG icon marks for richer About, Skills and Experience cards.
- Updated README, AGENTS and PROGRESS documentation so the project no longer describes the site as image-free.
- Verified JSON parsing, `dotnet build .\MyPortfolio.sln --no-restore`, `dotnet publish`, and browser rendering at desktop, 390px mobile and narrow 320px-class widths with no visible Blazor error state or horizontal overflow.
- A local preview was run at `http://127.0.0.1:5080/` for review during this session.

### 2026-05-26 - Deployment Cleanup And Portfolio Redesign

- Began implementing the approved target architecture: SuperHosting retains the paid domain, Azure DNS and Azure Static Web Apps remain the production route, and the obsolete GitHub Pages workflow is removed in this branch.
- Simplified the Azure Static Web Apps workflow by removing its unused `Api` location, declaring restricted GitHub permissions, and updating to current official checkout/setup actions; the stale GitHub Pages publication still needs to be disabled in authenticated GitHub repository settings after merge.
- Implemented an image-free, accessible responsive redesign with black/gold dark styling, silver/green light styling, theme persistence, semantic metadata, direct section-link restoration after asynchronous content renders, and public-safe technical/financial positioning.
- Replaced the photographic template/portfolio card path with semantic hero, focus-area and experience components; introduced cached JSON loading; removed old photo assets and unused social-link assets.
- Removed a non-resolving external link for the selected Neutron e-commerce project while retaining a careful personal-project summary.
- Used parallel research/audit agents for official Blazor/Azure practices, accessibility/design practices, current implementation flaws, and privacy-conscious CV alignment; avoided publishing unsupported role, education, certification, or trading-scope claims.
- Verified that .NET 10 is not installed on the current workstation. Updated the current .NET 8 Blazor packages to the supported `8.0.27` servicing level; because .NET 8 approaches end of support on 2026-11-10, a separately validated .NET 10 LTS migration is recommended after installing its SDK.
- Validated `dotnet restore`, `dotnet build .\MyPortfolio.sln --no-restore`, JSON parsing, and `dotnet publish -c Release`; checked the local browser at desktop and 390px/320px mobile widths in both themes, including a direct `/#contact` visit and refreshed theme stylesheet, with no client errors or horizontal overflow.
- Pushed branch `codex/document-hosting-and-agent-context` to GitHub. Open its pull request from `https://github.com/Zerkoto/portfolio-repo/pull/new/codex/document-hosting-and-agent-context` when authenticated.
- GitHub repository settings could not be mutated from the available browser session because it is not authenticated; after merge, an authenticated repository owner must disable GitHub Pages to withdraw the stale public mirror.

### 2026-05-26 - Agent Context And Hosting Trace

- Investigated the nearby `job-application-studio` repository as a reference. It keeps its agent handoff in `README.md`, not in an `AGENTS.md` file.
- Added `AGENTS.md` for this repository so future agents are explicitly directed to current handoff and hosting documentation.
- Documented the production deployment, DNS route, Azure resources visible in the supplied portal screenshots, GitHub workflows, and pending portal confirmations in `docs/HOSTING.md`.
- Verified the live custom domain, apex domain, and Azure Static Web Apps default hostname return the portfolio; inspected public DNS and GitHub Actions state; verified Git remote branch publication capability with a non-publishing dry run.
- Confirmed from additional SuperHosting screenshots that SuperHosting owns/renews the paid domain and delegates DNS to Azure nameservers; no customer or payment identifiers were recorded.
- Diagnosed the GitHub Pages failure from its GitHub Actions annotation: the old Pages action path uses retired `actions/upload-artifact@v3` behavior. GitHub required Pages custom workflows to move to newer Pages actions by 2025-01-30. The last successful Pages deployment was 2025-01-30, which explains the stale mirror.
- Confirmed from the Blazor source that the production artifact is a browser-only static site backed by local JSON/assets, with no repository API/backend; provider choice is operational rather than an application-runtime requirement.
- Prepared these documentation changes on branch `codex/document-hosting-and-agent-context` and validated the existing solution with `dotnet build .\MyPortfolio.sln --no-restore` (zero warnings and zero errors).
- No Azure settings, DNS records, deployment workflow behavior, or production content were changed in this investigation.

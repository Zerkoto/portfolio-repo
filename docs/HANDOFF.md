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

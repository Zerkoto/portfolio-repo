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

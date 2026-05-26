# Agent Instructions

## Start Here

Before changing this repository, read:

1. `docs/HANDOFF.md` for the latest working state and unfinished decisions.
2. `docs/HOSTING.md` before touching deployments, domains, DNS, GitHub Actions, or Azure configuration.
3. `README.md` for the inherited Blazor portfolio-template customization guide.

Update `docs/HANDOFF.md` after any coherent change batch that affects the project state, deployment process, or next-agent context.

## Project Summary

- This is Kristiyan Petrov's portfolio site, published at `https://www.kpetrov.z.bg/`.
- It is a .NET 8 Blazor WebAssembly app in `src/BlazorApp`.
- User-facing portfolio data is principally in `src/BlazorApp/wwwroot/sample-data`.
- `kpetrov.z.bg` is registered and renewed through SuperHosting; do not confuse domain ownership with the current Azure application host.
- Production hosting is Azure Static Web Apps, deployed from GitHub through `.github/workflows/azure-static-web-apps-ashy-pebble-014ec8203.yml`.
- The GitHub Pages workflow is legacy/stale and is not the production route for `kpetrov.z.bg`; see `docs/HOSTING.md`.

## Repository And Publishing Rules

- GitHub remote: `https://github.com/Zerkoto/portfolio-repo.git`.
- Default production branch: `main`.
- Use feature branches for improvements and fixes; Codex branches should use the `codex/` prefix.
- A pull request to `main` invokes the Azure Static Web Apps preview/deployment workflow; a merge or push to `main` deploys production.
- Do not expose or commit Azure deployment tokens, GitHub tokens, portal exports containing secrets, or authentication material.
- Do not commit generated build output (`bin/`, `obj/`) or logs.
- DNS or Azure portal changes are operational changes: describe them in `docs/HANDOFF.md` and keep `docs/HOSTING.md` accurate.

## Verification

For application or content changes, use the narrowest relevant checks and normally include:

```powershell
dotnet build .\MyPortfolio.sln
git status --short --branch
```

For deployment or domain investigations, verify the active workflow and public DNS/HTTP route as described in `docs/HOSTING.md`; do not assume GitHub Pages serves production.

## Handoff Entry Format

Add a dated entry to `docs/HANDOFF.md` with:

- what changed and why;
- files or cloud resources affected;
- verification completed;
- unfinished work or decisions needed;
- branch, commit, or pull-request details when applicable.

Keep the handoff concise and never put secret values in it.

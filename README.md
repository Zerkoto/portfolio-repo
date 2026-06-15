# Kristiyan Petrov Portfolio

Public portfolio website for [https://www.kpetrov.z.bg/](https://www.kpetrov.z.bg/).

This repository began as GitHub Education's .NET Blazor portfolio template. It is now a custom portfolio focused on investment operations, application support, technical delivery, automation, and selected e-commerce project work.

## Start Here

- Future agent work: [AGENTS.md](./AGENTS.md)
- Dated project progress: [PROGRESS.md](./PROGRESS.md)
- Current project handoff: [docs/HANDOFF.md](./docs/HANDOFF.md)
- Hosting, DNS and deployment map: [docs/HOSTING.md](./docs/HOSTING.md)

## Application

The site is a .NET 8 Blazor WebAssembly application located at `src/BlazorApp`. It is a static client-side site with no API or server-side application dependency.

Current sections:

| Section | Source |
| --- | --- |
| Hero and contact identity | `src/BlazorApp/wwwroot/sample-data/siteproperties.json` |
| About and focus areas | `src/BlazorApp/wwwroot/sample-data/aboutme.json` |
| Skill groups | `src/BlazorApp/wwwroot/sample-data/skills.json` |
| Experience highlights | `src/BlazorApp/wwwroot/sample-data/experience.json` |
| Professional contact icons | `src/BlazorApp/wwwroot/sample-data/socialicons.json` |

The hero uses an optimized profile portrait at `src/BlazorApp/wwwroot/images/profile/kristiyan-profile.jpg`, supported by CSS geometry and lightweight inline icons.

## Design Direction

- Default dark theme: black surfaces with restrained gold highlights.
- Optional light theme: silver-toned surfaces with green highlights.
- Theme preference persists in local browser storage and initially follows the system color preference.
- Stable keyboard-accessible navigation, visible focus treatment and reduced-motion support.
- Public-facing copy should remain factual, confident, and privacy-conscious; do not add unverified metrics, confidential operational detail, or unsupported employment claims.

## Run Locally

Requirements: .NET SDK compatible with `global.json`.

```powershell
dotnet restore .\MyPortfolio.sln
dotnet run --project .\src\BlazorApp\BlazorApp.csproj
```

Open the local URL printed by `dotnet run`.

Validation:

```powershell
dotnet build .\MyPortfolio.sln --no-restore
```

## Deployment

Production is served by Azure Static Web Apps on the SuperHosting-registered domain `kpetrov.z.bg`:

```text
SuperHosting domain registration
  -> Azure DNS
  -> Azure Static Web Apps
  -> https://www.kpetrov.z.bg/
```

GitHub stores source and runs the Azure deployment workflow from `.github/workflows/azure-static-web-apps-ashy-pebble-014ec8203.yml`. Pushes to `main` publish production; pull requests targeting `main` create Azure preview deployments.

GitHub Pages was a stale duplicate hosting path and has been removed from the supported workflow. See [docs/HOSTING.md](./docs/HOSTING.md) for the full reasoning and operational checklist.

## Framework Maintenance

The site currently targets .NET 8. A migration to .NET 10 LTS should be completed in a separately verified change after the .NET 10 SDK is available in the local and CI toolchains.

# LifeGuide

A cross-platform app that helps people organise their day-to-day life in one place: to-dos, habits, gym programmes, meal plans, and streaks that show what they've accomplished.

> 🚧 **Status:** In early development. See the [Milestones](../../milestones) and [Issues](../../issues) for progress.

## Why LifeGuide?

Everyday tasks pile up, and most people juggle a separate app for each part of their life. LifeGuide brings them together. Every completed task, workout or meal feeds a single streak tracker, so progress across your whole life is visible at a glance.

## Features

| Feature | Status |
|---|---|
| To-do list | 🔨 Planned (MVP) |
| Streak tracker | 🔨 Planned (MVP) |
| Daily habits | 📋 Planned |
| Gym programme and workout logging | 📋 Planned |
| Meal plan and tracker | 📋 Planned |
| Daily check-in | 📋 Planned |

## Tech Stack

- **.NET MAUI Blazor Hybrid**: one C# codebase for Android, iOS, Windows and macOS, with UI built from Razor components (HTML/CSS)
- **C# / .NET**
- **Entity Framework Core + SQLite**: local, offline-first storage
- **xUnit**: unit testing

## Architecture

```
LifeGuide.slnx
├── LifeGuide.Core    → Domain models, interfaces and business rules (no dependencies)
├── LifeGuide.Data    → EF Core DbContext, SQLite, repositories
├── LifeGuide.App     → .NET MAUI Blazor Hybrid UI
└── LifeGuide.Tests   → xUnit tests
```

**Key design decision:** every module (to-dos, habits, workouts, meals) records a standard `CompletionEntry` when something is done. The streak tracker reads only those entries, so new modules plug in without changing any streak logic.

## Getting Started

_Setup instructions will be added once the solution skeleton is in place._

## Roadmap

1. **MVP**: to-dos and streak tracker
2. **Habits**: daily habits feeding into streaks
3. **Gym**: programmes and workout logging
4. **Meals**: meal plans and tracking

## Author

**Aaron**: self-taught developer. Built as a portfolio project, one issue at a time.

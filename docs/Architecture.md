# RaceVision Architecture

## Project Overview

RaceVision is a cloud platform for telemetry analysis in motorsport and sim racing.

The goal of the project is to allow users to upload telemetry data, analyze driving sessions, compare laps and receive performance insights.

---

## High-Level Architecture

RaceVision is composed of:

- ASP.NET Core Web API
- PostgreSQL
- Entity Framework Core
- Docker
- React frontend (planned)

---

## Why ASP.NET Core?

The backend is built with ASP.NET Core because it offers:

- High performance
- Excellent cloud support
- Dependency Injection
- Native REST API development
- Cross-platform compatibility

---

## Why PostgreSQL?

PostgreSQL was selected because:

- Open source
- Reliable
- Excellent Docker integration
- Widely adopted in cloud-native environments

---

## Why Docker?

Docker provides:

- Reproducible development environments
- Easy onboarding
- No local PostgreSQL installation
- Easier deployment

---

## Persistence

Entity Framework Core is used as the ORM.

Database schema evolution is managed through EF Core migrations.

---

## Current Domain

Current entities:

- User
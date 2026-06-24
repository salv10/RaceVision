# Development Guidelines

## Purpose

This document defines the development conventions used throughout the RaceVision project.

The objective is to keep the codebase consistent, maintainable and easy to understand as the project grows.

---

## Naming Conventions

### Classes

Use PascalCase.

Example:

User

Vehicle

TelemetryPoint

### Methods

Use PascalCase.

### Properties

Use PascalCase.

### Local variables

Use camelCase.

### Private fields

Prefix with "_".

Example:

private readonly IUserService _userService;

---

## Date and Time

Always use UTC.

Use:

DateTime.UtcNow

Avoid:

DateTime.Now

---

## Comments

Comments should explain **why** something exists or why a specific decision was made.

Avoid comments that simply describe what the code is doing.

---

## XML Documentation

All public classes and public methods must include XML documentation.

---

## Git

Use Conventional Commits.

Each commit should represent a single logical change whenever possible.

---

## General Principles

Keep classes focused on a single responsibility.

Prefer readable code over clever code.

Avoid premature optimization.

Do not introduce unnecessary abstractions.

## Project Philosophy

RaceVision is built with long-term maintainability in mind.

Whenever possible:

- Prefer simplicity over complexity.
- Prefer explicit code over implicit behavior.
- Design for future growth without overengineering.
- Every architectural decision should have a clear reason.
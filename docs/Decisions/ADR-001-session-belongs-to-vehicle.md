# ADR-001 - Session belongs to Vehicle

## Status

Accepted

---

## Date

2026-06-24

---

## Context

RaceVision allows users to record and analyze telemetry sessions.

A user can own multiple vehicles (e.g. a GT car, a kart, or a sim racing setup).

Each telemetry session is always performed using exactly one vehicle.

---

## Decision

A `Session` belongs to a `Vehicle`.

Relationships:

- User (1) → (N) Vehicle
- Vehicle (1) → (N) Session

The session does not belong directly to the user.

---

## Rationale

This design reflects the real world.

A user may own multiple vehicles and perform telemetry sessions with any of them.

Grouping sessions by vehicle makes it easier to:

- compare performances over time;
- calculate vehicle statistics;
- support different vehicle categories;
- extend the model without breaking existing relationships.

---

## Consequences

### Positive

- Simple and intuitive domain model.
- Easy to maintain.
- Supports multiple vehicles per user.
- Ready for future extensions.

### Negative

If future requirements introduce different configurations of the same vehicle, an additional entity may be required.

---

## Future Considerations

A future version of RaceVision may introduce a `Setup` entity associated with a `Session`.

This will allow users to compare telemetry collected with different vehicle configurations without changing the current domain model.
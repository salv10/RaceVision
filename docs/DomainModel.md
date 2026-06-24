# Domain Model

## User

Represents a registered RaceVision user.

A user can own multiple vehicles.

---

## Vehicle

Represents a real or virtual vehicle.

A vehicle belongs to one user.

A vehicle can have multiple sessions.

---

## Session

Represents a telemetry recording session.

A session belongs to one vehicle.

A session contains multiple laps.

---

## Lap

Represents a single completed lap.

A lap belongs to one session.

A lap contains telemetry points.

---

## TelemetryPoint

Represents a single telemetry sample.

Stores raw telemetry only.

Derived values are calculated by the application.
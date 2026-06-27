namespace RaceVision.Api.Domain.Entities;

/// <summary>
/// Represents a registered RaceVision user.
/// A user can own multiple vehicles and analyze telemetry sessions.
/// </summary>
public class User
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string DisplayName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Stores the hashed password only.
    /// Plain text passwords must never be stored.
    /// </summary>
    public string PasswordHash { get; set; } = string.Empty;

    public bool IsEmailVerified { get; set; } = false;

    /// <summary>
    /// UTC date used to avoid timezone issues across users and servers.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? LastLoginAt { get; set; }
}
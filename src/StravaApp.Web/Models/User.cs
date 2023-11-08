using Microsoft.AspNetCore.Identity;

namespace StravaApp.Web.Models;

public class User : IdentityUser
{
    /// <summary>
    ///     Strava user id.
    /// </summary>
    public required int StravaId { get; set; }

    /// <summary>
    ///     Date and time when user was created.
    /// </summary>
    public required DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
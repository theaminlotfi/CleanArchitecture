#nullable disable

namespace Application.Dtos.Account;

/// <summary>
/// Data Transfer Object for handling refresh token operations
/// </summary>
public class RefreshToken
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RefreshToken"/> class.
    /// </summary>
    /// <param name="token">The token to be refreshed.</param>
    public RefreshToken(string token)
    {
        if (string.IsNullOrWhiteSpace(token))
            throw new ArgumentNullException(nameof(token));

        Token = token;
    }

    /// <summary>
    /// Gets the token to be refreshed.
    /// </summary>
    public string Token { get; }

    /// <summary>
    /// Gets or sets the identifier of the refresh token.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the expiration date of the refresh token.
    /// </summary>
    public DateTime Expires { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the refresh token is expired.
    /// </summary>
    public bool IsExpired { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the refresh token was created.
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the client that created the refresh token.
    /// </summary>
    public string CreatedByIp { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the refresh token was revoked (if applicable).
    /// </summary>
    public DateTime? Revoked { get; set; }

    /// <summary>
    /// Gets or sets the IP address of the client that revoked the refresh token (if applicable).
    /// </summary>
    public string RevokedByIp { get; set; }

    /// <summary>
    /// Gets or sets the token that replaced the current refresh token (if applicable).
    /// </summary>
    public string ReplacedByToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the refresh token is active (not expired and not revoked).
    /// </summary>
    public bool IsActive
    {
        get
        {
            if (Revoked.HasValue)            
                return false;            

            return !IsExpired;
        }
    }
}
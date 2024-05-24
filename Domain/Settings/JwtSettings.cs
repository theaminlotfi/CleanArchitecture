#nullable disable

namespace Domain.Settings;

public class JwtSettings
{
    public string Key { get; set; } = "your_secret_key_here";
    public string Issuer { get; set; } = "your_issuer_here";
    public string Audience { get; set; } = "your_audience_here";
    public double DurationInMinutes { get; set; } = 30.0; // 30 minutes
}
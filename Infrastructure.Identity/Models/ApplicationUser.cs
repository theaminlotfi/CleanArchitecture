#nullable disable

using Application.Dtos.Account;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Models;

public class ApplicationUser : IdentityUser
{
    public string Username { get; set; }
    public List<RefreshTokenDto> RefreshTokens { get; set; }

    public ApplicationUser()
    {
        RefreshTokens = new List<RefreshTokenDto>();
    }

    public bool OwnsToken(string token)
    {
        return RefreshTokens.Find(x => x.Token == token) != null;
    }

    public void AddRefreshToken(RefreshTokenDto refreshToken)
    {
        RefreshTokens.Add(refreshToken);
    }

    public void RemoveRefreshToken(string token)
    {
        var refreshToken = RefreshTokens.Find(x => x.Token == token);
        if (refreshToken != null)        
            RefreshTokens.Remove(refreshToken);        
    }
}
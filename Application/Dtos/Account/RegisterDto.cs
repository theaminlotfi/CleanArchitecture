#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Account;

public record RegisterDto
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    [Required, Compare(nameof(Password))]
    public string PasswordHash { get; set; }
}

#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Account;

public record LoginDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}

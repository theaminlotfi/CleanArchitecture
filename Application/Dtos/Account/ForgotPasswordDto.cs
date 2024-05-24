#nullable disable

using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Account;

public class ForgotPasswordDto
{
    [Required, EmailAddress]
    public string Email { get; set; }
}

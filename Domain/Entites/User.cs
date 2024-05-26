#nullable disable

using Domain.Common;

namespace Domain.Entites;

public class User : BaseEntity<int>
{
    public int UserId { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }    
}

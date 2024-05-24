using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Identity.Data;

public class IdentityContext : IdentityDbContext<ApplicationUser>
{
}

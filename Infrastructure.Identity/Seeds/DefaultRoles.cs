using Application.Enums;
using Infrastructure.Identity.Models;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Seeds;

public static class DefaultRoles
{
    //public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    //{
    //    // Seed Roles
    //    await roleManager.CreateAsync(new IdentityRole(Roles.SuperAdmin.ToString()));
    //    await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
    //    await roleManager.CreateAsync(new IdentityRole(Roles.Moderator.ToString()));
    //    await roleManager.CreateAsync(new IdentityRole(Roles.Client.ToString()));
    //}

    //private static async Task CreateRole(RoleManager<IdentityRole> roleManager, string roleName)
    //{
    //    if (!await roleManager.RoleExistsAsync(roleName))
    //        await roleManager.CreateAsync(new IdentityRole(roleName));
    //}
}

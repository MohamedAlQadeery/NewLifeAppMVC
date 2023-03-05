using Microsoft.AspNetCore.Identity;
using NewLife.Web.Core.Consts;

namespace NewLife.Web.Seed
{
    public static class DefaultRoles
    {
        public static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {

            if (!roleManager.Roles.Any())
            {
                await roleManager.CreateAsync(new IdentityRole { Name = AppRoles.Admin});
            }
        }
    }
}

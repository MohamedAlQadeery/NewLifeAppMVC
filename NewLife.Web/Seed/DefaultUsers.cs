using Microsoft.AspNetCore.Identity;
using NewLife.Web.Core.Consts;

namespace NewLife.Web.Seed
{
    public static class DefaultUsers
    {
        public static async Task SeedAdminAsync(UserManager<IdentityUser> userManager)
        {
            var admin = new IdentityUser {
                UserName = "admin",
                Email = "admin@newlife.com",
                EmailConfirmed = true

            };

            var adminExist = await userManager.FindByNameAsync(admin.UserName);
            if(adminExist is null)
            {
                await userManager.CreateAsync(admin,"Admin123@");
                await userManager.AddToRoleAsync(admin, AppRoles.Admin);
            }
        }
    }
}

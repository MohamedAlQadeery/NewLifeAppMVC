using Microsoft.AspNetCore.Identity;

namespace NewLife.Web.Seed
{
    public static class SeedExtension
    {
        public static async Task SeedAdminAndRolesData(this IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();

            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            await DefaultRoles.SeedRolesAsync(roleManager);
            await DefaultUsers.SeedAdminAsync(userManager);

        }
    }
}


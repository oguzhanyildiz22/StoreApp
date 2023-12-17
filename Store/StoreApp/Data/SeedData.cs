using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

public class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roleNames = { "Admin", "User" };

            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);

                if (!roleExist)
                {
                    // Create the roles and seed them to the database
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            IdentityUser adminUser = await userManager.FindByEmailAsync("admin@example.com");

            if (adminUser == null)
            {
                // Create an Admin user with the password "Admin@123"
                adminUser = new IdentityUser()
                {
                    UserName = "admin@example.com",
                    Email = "admin@example.com",
                };

                await userManager.CreateAsync(adminUser, "Admin@123");

                // Assign the "Admin" role to the admin user
                await userManager.AddToRoleAsync(adminUser, "Admin");
            }
        }
    }
}



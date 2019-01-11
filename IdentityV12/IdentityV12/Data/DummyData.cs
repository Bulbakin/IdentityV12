using IdentityV12.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityV12.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";

            string role2 = "Member";

            string password = "Asd-123";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2));
            }

            if (await userManager.FindByNameAsync("a") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "a@a.a",
                    Email = "a@a.a",
                    firstName = "Adam",
                    lastName = "Aldridge",
                    PhoneNumber = "6902341234"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            if (await userManager.FindByNameAsync("b") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "b@b.b",
                    Email = "b@b.b",
                    firstName = "Bob",
                    lastName = "Barker",
                    PhoneNumber = "7788951456"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role2);
                }
                adminId2 = user.Id;
            }
        }
    }
}

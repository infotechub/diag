using Microsoft.AspNetCore.Identity;
using NovoDiagnosis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovoDiagnosis.Data
{
    public class DummyData
    {
        public static async Task Initialize(ApplicationDbContext context,
                              UserManager<ApplicationUser> userManager,
                              RoleManager<ApplicationRole> roleManager)
        {
            context.Database.EnsureCreated();

            String adminId1 = "";
            String adminId2 = "";

            string role1 = "Admin";
            string desc1 = "This is the administrators role";

            string role2 = "User";
            string desc2 = "This is the users role";


            string password = "P@$$w0rd";

            if (await roleManager.FindByNameAsync(role1) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role1, desc1, DateTime.Now));
            }
            if (await roleManager.FindByNameAsync(role2) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(role2, desc2, DateTime.Now));
            }
           
            if (await userManager.FindByNameAsync("akinbamidelet@outlook.com") == null)
            {
                var user = new ApplicationUser
                {
                    UserName = "063",
                    Email = "akinbamidelet@outlook.com",
                    FullName = "Akinbamidele Akinmejiwa",
                    StaffId = "063",
                    Street = "Lagos",
                    City = "Lagos",
                    State = "Lagos",
                    Country = "Nigeria",
                    PhoneNumber = "09080086100"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                    await userManager.AddToRoleAsync(user, role1);
                }
                adminId1 = user.Id;
            }

            
            
        }
    }
}

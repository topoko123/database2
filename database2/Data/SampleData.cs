using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace database2.Data
{
    public class SampleData
    {
       

        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            //  var serviceScope = serviceProvider.GetService<IServiceScopeFactory>().CreateScope();
            var dbcontext = serviceProvider.GetService<ApplicationDbContext>();
            var userManage = serviceProvider.GetService<UserManager<IdentityUser>>();
            var roleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();
            string[] roles = new string[] { "Administrator", "User" };

            foreach (var role in roles)
            {
                var isExist = await roleManager.RoleExistsAsync(role);
                if (!isExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
            var adminUser = new IdentityUser
            {
                Email = "aunkerzerza@hotmail.com",
                UserName = "aunkerzerza@hotmail.com",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            var currentUser = await userManage.FindByEmailAsync(adminUser.Email);
            if (currentUser == null)
            {
                await userManage.CreateAsync(adminUser, "Secret123!");
                currentUser = await userManage.FindByEmailAsync(adminUser.Email);
            }
            var isAdmin = await userManage.IsInRoleAsync(currentUser, "Administrator");
            if (!isAdmin)
            {
                await userManage.AddToRolesAsync(currentUser, roles);
            }
            var containSampleBook = await dbcontext.Books.AnyAsync(b => b.Name == "Sample Book");
            if (!containSampleBook)
            {
                dbcontext.Books.Add(new Models.Book
                {
                    Name = "Sample Book",
                    Price = 100m
                });
            }
            await dbcontext.SaveChangesAsync();
        }
    }
}

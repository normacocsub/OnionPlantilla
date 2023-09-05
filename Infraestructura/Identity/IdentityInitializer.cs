using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaOnion.Infraestructura.Identity
{
    public static class IdentityInitializer
    {
        public static void InitializeData(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                roleManager.CreateAsync(role).Wait();
            }

            ApplicationUser user = new ApplicationUser();
            user.UserName = "admin@example.com";
            user.NombreCompleto = "Fernando Vega";

            userManager.CreateAsync(user, "Password123").Wait();

            user = userManager.FindByNameAsync("admin@example.com").Result;

            userManager.AddToRoleAsync(user.Id, "Admin").Wait();
        }
    }
}

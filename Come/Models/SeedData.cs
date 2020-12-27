using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Come.Data;
using System;
using System.Linq;

namespace Come.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UserContext>>()))
            {
                // Look for any movies.


                if (context.Roles.Any())
                {
                    return;   // DB has been seeded
                }

                context.Roles.AddRange(
                    new Microsoft.AspNetCore.Identity.IdentityRole
                    {
                         Id="1",
                          Name="Admin"
                    }


                );
                context.SaveChanges();



                if (context.UserRoles.Any())
                {
                    return;   // DB has been seeded
                }

                context.UserRoles.AddRange(
                    new Microsoft.AspNetCore.Identity.IdentityUserRole<string>
                    {
                        UserId = "0a2e0b08-6859-4477-ba76-dad7ffddfeae",
                        RoleId = "1"
                    }
                       

                );
                context.SaveChanges();
            }
        }
    }
}
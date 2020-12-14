using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Crm4.Data;
using System;
using System.Linq;

namespace Crm4.Models
{
    public static class SeedDataRoles
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCrmContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCrmContext>>()))
            {
                // Look for any movies.
                if (context.Roles.Any())
                {
                    return;   // DB has been seeded
                }
                context.Roles.AddRange(
                    new Roles
                    {
                        Name = "Admin"
                    },

                    new Roles
                    {
                        Name = "Moderator"
                    },
                    new Roles
                    {
                        Name = "Użytkownik"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Crm4.Data;
using System;
using System.Linq;

namespace Crm4.Models
{
    public static class SeedDataIndustries
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCrmContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCrmContext>>()))
            {
                // Look for any movies.
                if (context.Industries.Any())
                {
                    return;   // DB has been seeded
                }
                context.Industries.AddRange(
                    new Industries
                    {
                        Name = "IT"
                    },

                    new Industries
                    {
                        Name = "Turystyczna"
                    },

                    new Industries
                    {
                        Name = "Gastronimiczna"
                    },

                    new Industries
                    {
                        Name = "Fitness"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Crm4.Data;
using System;
using System.Linq;

namespace Crm4.Models
{
    public static class SeedDataUsers
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCrmContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCrmContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }
                context.User.AddRange(
                    new Users
                    {
                        FirstName = "Grzegorz",
                        LastName = "Brzęczyszczykiewicz",
                        DateOfBirth = DateTime.Parse("1970-4-2"),
                        Login = "Dolas"
                    },

                    new Users
                    {
                        FirstName = "Czarek",
                        LastName = "Sucharek",
                        DateOfBirth = DateTime.Parse("1988-7-22"),
                        Login = "Kamerdyner22"
                    },

                    new Users
                    {
                        FirstName = "Maria",
                        LastName = "Nowak",
                        DateOfBirth = DateTime.Parse("1992-2-29"),
                        Login = "Marii"
                    },

                    new Users
                    {
                        FirstName = "Anastazja",
                        LastName = "Romanowa",
                        DateOfBirth = DateTime.Parse("1901-6-18"),
                        Login = "Caryca"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
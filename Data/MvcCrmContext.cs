using Microsoft.EntityFrameworkCore;
using Crm4.Models;

namespace Crm4.Data
{
    public class MvcCrmContext : DbContext
    {
        public MvcCrmContext(DbContextOptions<MvcCrmContext> options) 
            : base(options)
        {
        }

        public DbSet<Users> User { get; set; }

        public DbSet<Crm4.Models.Roles> Roles { get; set; }

        public DbSet<Crm4.Models.Industries> Industries { get; set; }
    }
}


using Microsoft.EntityFrameworkCore;
using Itemmanagement.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Itemmanagement.Data
{
    public class DbItemClass: IdentityDbContext
    {
        public DbItemClass(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Item> Items{ get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
       
    }
}

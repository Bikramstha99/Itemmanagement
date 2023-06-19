
using Microsoft.EntityFrameworkCore;
using Itemmanagement.Models.Domain;

namespace Itemmanagement.Data
{
    public class DbItemClass: DbContext
    {
        public DbItemClass(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Item> Items{ get; set; }
    }
}

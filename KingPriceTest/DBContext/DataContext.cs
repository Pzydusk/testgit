using KingPriceTest.Models;
using Microsoft.EntityFrameworkCore;

namespace KingPriceTest.DBContext
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure your database connection here
        }
    }
}

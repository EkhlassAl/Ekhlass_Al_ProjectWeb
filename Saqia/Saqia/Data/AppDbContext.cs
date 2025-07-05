using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Saqia.Models;

namespace Saqia.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Tank> Tanks { get; set; }
        public DbSet<TankArea> TankAreas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Driver> Drivers { get; set; }
    }
}

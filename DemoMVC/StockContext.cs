using DemoMVC.Configurations;
using DemoMVC.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoMVC
{
    // pour travailler avec EF
    // il faut hériter de DbContext
    public class StockContext(DbContextOptions options): DbContext(options)
    {
        // il faut aussi déclarer les tables
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderLineConfiguration());
        }
    }
}

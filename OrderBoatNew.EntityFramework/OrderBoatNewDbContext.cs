using Microsoft.EntityFrameworkCore;
using OrderBoatNew.Domain.Models;

namespace OrderBoatNew.EntityFramework
{
    public class OrderBoatNewDbContext : DbContext
    {
        public DbSet<Boat> Boats { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Wood> Woods { get; set; }
        public DbSet<Accessory> Accessories { get; set; }
        public DbSet<BoatAccessory> BoatAccessories { get; set; }
        public DbSet<BoatType> BoatTypes { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Deliver> Delivers { get; set; }
        public DbSet<DeliveryDetails> DeliveryDetails { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Managers> Managers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Partners> Partners { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public OrderBoatNewDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
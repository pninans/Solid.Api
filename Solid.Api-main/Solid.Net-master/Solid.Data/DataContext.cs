using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Buyer>? BuyerList { get; set; }
        public DbSet<Product>? ProductList { get; set; }
        public DbSet<Seller>? SellerList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=hand2_db");
        }

    }
}
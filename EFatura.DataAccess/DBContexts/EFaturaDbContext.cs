using System.Configuration;
using EFatura.Entities.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFatura.DataAccess.Base.DBContexts
{
    public class EFaturaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = 'BEKIRCAN\\SQLEXPRESS'; Initial Catalog = 'EFatura'; Integrated Security=SSPI;");
            /*"Data Source='BEKAIR'; Initial Catalog='EFatura'; Integrated Security=SSPI;"*/
        }

        public DbSet<Individual> Individuals { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }
    }
}

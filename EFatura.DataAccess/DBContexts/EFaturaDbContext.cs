using EFatura.Entities.Domain;
using EFatura.Entities.OtherEntities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace EFatura.DataAccess.Base.DBContexts
{
    public class EFaturaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = 'BEKIRCAN\\SQLEXPRESS'; Initial Catalog = 'EFatura'; Integrated Security = SSPI;");
            /*Data Source = 'BEKAIR'; Initial Catalog = 'EFatura'; Integrated Security = SSPI;*/
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<CorporateBill> CorporateBills { get; set; }
        public DbSet<IndividualBill> IndividualBills { get; set; }
    }
}

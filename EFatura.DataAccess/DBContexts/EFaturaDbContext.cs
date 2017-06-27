using EFatura.Entities.Domain;
using Microsoft.EntityFrameworkCore;

namespace EFatura.DataAccess.Base.DBContexts
{
    public class EFaturaDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source='BEKAIR'; Initial Catalog='EFatura'; Integrated Security=SSPI;");
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
    }
}

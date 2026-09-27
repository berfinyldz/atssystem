using Microsoft.EntityFrameworkCore;

namespace atssistem.Models
{
    public class atsDbContext : DbContext
    {
        string baglanti = "Server=(localdb)\\mssqllocaldb;Database=atsDb;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(baglanti);
        }
        public DbSet<Home> ilanlar { get; set; }
    }
}

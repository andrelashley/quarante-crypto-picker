using Microsoft.EntityFrameworkCore;

namespace CryptoPicker.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Entry> Entries { get; set; }
        public DbSet<Crypto> Cryptos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Crypto>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,4)");
        }
    }
}

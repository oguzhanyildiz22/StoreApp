using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public DbSet<Product> Products { get; set; }

        // Db için gerekli 
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options)
        {
        }

        // Bu method db'de veri varsa çalışmaz ama yoksa içindeki kaydı db'ye ekler
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Identity tablolarını özelleştirmek istiyorsanız burada konfigürasyonlar yapabilirsiniz.

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { ProductId = 1, ProductName = "Computer", Price = 17_000 },
                    new Product() { ProductId = 2, ProductName = "Keyboard", Price = 1_000 },
                    new Product() { ProductId = 3, ProductName = "Mouse", Price = 500 },
                    new Product() { ProductId = 4, ProductName = "Monitor", Price = 7_000 },
                    new Product() { ProductId = 5, ProductName = "Deck", Price = 1_500 }
                );
        }
    }
}

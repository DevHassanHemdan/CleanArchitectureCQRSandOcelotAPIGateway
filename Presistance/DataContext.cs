using Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Presistance
{
    public class DataContext : IdentityDbContext<Users>
    {
        public DataContext()
        {

        }
        public DataContext(DbContextOptions options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("A FALLBACK CONNECTION STRING");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBrand>().HasKey(x => x.Id);

            modelBuilder.Entity<ProductType>().HasKey(x => x.Id);

            modelBuilder.Entity<Product>()
                       .HasOne(e => e.ProductBrand)
                       .WithMany(c => c.Products);

            modelBuilder.Entity<Product>()
                .Property(x => x.Id)
                .HasColumnName("ProductId");

            modelBuilder.Entity<ProductType>()
                .Property(x => x.Id)
                .HasColumnName("ProductTypeId");

            modelBuilder.Entity<Product>()
                       .HasOne(e => e.ProductType)
                       .WithMany(c => c.Products);

            modelBuilder.Entity<Categories>()
                        .HasMany(p => p.Products)
                        .WithOne(c => c.Categories)
                        .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Product>()
                    .Property(x => x.CreatedOn)
                    .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<ProductType>()
                    .Property(x => x.CreatedOn)
                    .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<ProductBrand>()
                    .Property(x => x.CreatedOn)
                    .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Categories>()
                    .Property(x => x.CreatedOn)
                    .HasDefaultValueSql("GETDATE()");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class BrandConfig
    {
        public static ModelBuilder AddBrandEntity(this ModelBuilder modelBuilder)
        {
            var BrandEntity = modelBuilder.Entity<Brand>();

            // Name
            BrandEntity.HasKey(B => B.Name);

            BrandEntity.Property(b => b.Name)
                .HasMaxLength(30);

            // Products
            BrandEntity.HasMany(B => B.Products)
                .WithOne(P => P.Brand);

            return modelBuilder;
        }
    }
}

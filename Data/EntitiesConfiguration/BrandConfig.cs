using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class BrandConfig
    {
        public static ModelBuilder AddBrandEntity(this ModelBuilder modelBuilder)
        {
            var BrandEntity = modelBuilder.Entity<Brand>();

            // Id
            BrandEntity.HasKey(B => B.Id);

            // Name
            BrandEntity.Property(B => B.Name)
                .IsRequired()
                .HasMaxLength(20);

            // Products
            BrandEntity.HasMany(B => B.Products)
                .WithOne(P => P.Brand);

            return modelBuilder;
        }
    }
}

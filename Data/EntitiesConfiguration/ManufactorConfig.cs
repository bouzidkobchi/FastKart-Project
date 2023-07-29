using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class ManufactorConfig
    {
        public static ModelBuilder AddManufactorEntity(this ModelBuilder modelBuilder)
        {
            var ManufactorEntity = modelBuilder.Entity<Manufactor>();

            // Name
            ManufactorEntity.HasKey(M => M.Name);

            ManufactorEntity.Property(M => M.Name)
                .HasMaxLength(30);

            // Products
            ManufactorEntity.HasMany(M => M.Products)
                .WithOne(P => P.Manufactor);

            return modelBuilder;
        }
    }
}

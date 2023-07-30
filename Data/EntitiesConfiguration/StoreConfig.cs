using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class StoreConfig
    {
        public static ModelBuilder AddStoreEntity(this ModelBuilder modelBuilder)
        {
            var StoreEntity = modelBuilder.Entity<Store>();

            // Name
            StoreEntity.HasKey(S => S.Name);

            StoreEntity.Property(S => S.Name)
                .HasMaxLength(30);

            // Products
            StoreEntity.HasMany(S => S.Products)
                .WithOne(P => P.Store);

            return modelBuilder;
        }
    }
}

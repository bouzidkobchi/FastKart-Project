using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class CategoryConfig
    {
        public static ModelBuilder AddCategoryEntity(this ModelBuilder modelBuilder)
        {
            var CategoryEntity = modelBuilder.Entity<Category>();

            //Name
            CategoryEntity.HasKey(C => C.Name);

            //CategoryEntity.Property(C => C.Name)
            //    .HasMaxLength(30);

            //Image
            CategoryEntity.HasOne(C => C.Image);

            //Icon
            CategoryEntity.HasOne(C => C.icon);

            //Products
            CategoryEntity.HasMany(C => C.Products)
                .WithOne(C => C.Category);

            return modelBuilder;
        }
    }
}

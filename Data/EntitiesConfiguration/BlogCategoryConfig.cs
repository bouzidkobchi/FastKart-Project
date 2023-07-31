using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class BlogCategoryConfig
    {
        public static ModelBuilder AddBlogCategoryEntity(this ModelBuilder modelBuilder)
        {
            var BlogCategoryEntity = modelBuilder.Entity<BlogCategory>();

            // Name
            BlogCategoryEntity.HasKey(C => C.Name);

            BlogCategoryEntity.Property(C => C.Name)
                .HasMaxLength(30);

            return modelBuilder;
        }
    }
}

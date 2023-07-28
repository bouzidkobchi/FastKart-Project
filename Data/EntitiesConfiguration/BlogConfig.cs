using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class BlogConfig
    {
        public static ModelBuilder AddBlogEntity(this ModelBuilder modelBuilder)
        {
            var BlogEntity = modelBuilder.Entity<Blog>();

            // Id
            BlogEntity.HasKey(B => B.Id);

            // Title
            BlogEntity.Property(B => B.Title)
                .IsRequired()
                .HasMaxLength(50);

            // SmallTitle
            BlogEntity.Property(B => B.SmallTitle)
                .HasMaxLength(50);

            // Content
            BlogEntity.Property(B => B.Content)
                .HasMaxLength(5000)
                .IsUnicode()
                .IsRequired();

            // Welpaper
            BlogEntity.HasOne(B => B.Welpaper);

            // comments
            BlogEntity.HasMany(B => B.Comments)
                .WithOne(C => C.Blog);

            return modelBuilder;
        }
    }
}

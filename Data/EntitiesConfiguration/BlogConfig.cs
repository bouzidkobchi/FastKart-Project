using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class BlogConfig
    {
        public static ModelBuilder AddBlogEntity(this ModelBuilder modelBuilder)
        {
            var BlogEntity = modelBuilder.Entity<Blog>();

            // Title
            BlogEntity.Property(B => B.Title)
                .IsRequired()
                .HasMaxLength(50);

            // SmallTitle
            BlogEntity.Property(B => B.SmallTitle)
                .HasMaxLength(50);

            // Category 
            BlogEntity.HasOne(B => B.BlogCategory)
                .WithMany(C => C.Blogs)
                .HasForeignKey(B => B.BlogCategoryName);

            // Content
            BlogEntity.Property(B => B.Content)
                .HasMaxLength(5000)
                .IsUnicode()
                .IsRequired();

            // Wallpaper
            BlogEntity.HasOne(B => B.Wallpaper)
                .WithMany()                         // (X) verify this 
                .HasForeignKey(B => B.WallpaperId); 

            // comments
            BlogEntity.HasMany(B => B.Comments)
                .WithOne(C => C.Blog);

            // Title Unique By User
            BlogEntity.HasIndex(X => new { X.AutherId, X.Title })
                .IsUnique();

            return modelBuilder;
        }
    }
}

using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class BlogCommentConfig
    {
        public static ModelBuilder AddBlogCommentEntity(this ModelBuilder modelBuilder)
        {
            var BlogCommentEntity = modelBuilder.Entity<BlogComment>();
            
            // Auther
            BlogCommentEntity.HasOne(C => C.Auther)
                .WithMany(U => U.Comments)
                .HasForeignKey(B => B.AutherId);

            // Blog
            BlogCommentEntity.HasOne(C => C.Blog)
                .WithMany(B => B.Comments)
                .HasForeignKey(B => B.BlogId);

            // Content
            BlogCommentEntity.Property(C => C.Content)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode();

            // Replies
            BlogCommentEntity.HasMany(C => C.Replies)
                .WithOne(R => R.Comment);

            return modelBuilder;

        }

    }
}

using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class RatingConfig
    {
        public static ModelBuilder AddRatingEntity(this ModelBuilder modelBuilder)
        {
            var RatingEntity = modelBuilder.Entity<Rating>();

            RatingEntity.HasKey(R => new { R.UserId, R.ProductId });

            RatingEntity.HasOne(R => R.User)
                .WithMany(U => U.Ratings)
                .HasForeignKey(R => R.UserId);

            RatingEntity.HasOne(R => R.Product)
                .WithMany(P => P.Ratings)
                .HasForeignKey(R => R.ProductId);

            // Comment
            RatingEntity.Property(R => R.Comment)
                .HasMaxLength(200);

            return modelBuilder;
        }
    }
}

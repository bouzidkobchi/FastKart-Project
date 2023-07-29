using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class CouponConfig
    {
        public static ModelBuilder AddCouponEntity(this ModelBuilder modelBuilder)
        {
            var CouponEntity = modelBuilder.Entity<Coupon>();

            // Code
            CouponEntity.HasKey(C => C.Code);

            // Owner
            CouponEntity.HasOne(C => C.Owner)
                .WithMany(U => U.Coupons);

            // Title
            CouponEntity.Property(C => C.Title)
                .HasMaxLength(50);

            return modelBuilder;
        }
    }
}

using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class UserConfig
    {
        public static ModelBuilder AddUserEntity(this ModelBuilder modelBuilder)
        {
            var UserEntity = modelBuilder.Entity<User>();

            UserEntity.HasMany<Product>(U => U.WishList)
                .WithMany(P => P.Likers);

            // Id
            UserEntity.HasKey(U => U.Id);

            // Email
            UserEntity.Property(U => U.Email)
                .IsRequired()
                .HasMaxLength(50);
            UserEntity
                .HasIndex(U => U.Email)
                .IsUnique();

            // Username
            UserEntity.Property(U => U.UserName)
                .IsRequired()
                .HasMaxLength(30);
            UserEntity
                .HasIndex(U => U.UserName)
                .IsUnique();

            // Passwordhash
            UserEntity.Property(U => U.PasswordHash)
                .HasMaxLength(250);

            // Phone
            UserEntity.Property(U => U.Phone)
                .IsFixedLength(true)
                .HasMaxLength(12);

            // ProfilePicture
            UserEntity.HasOne(U => U.ProfilePicture);

            // WishList
            UserEntity.HasMany(U => U.WishList)
                .WithMany(P => P.Likers);

            // Orders
            UserEntity.HasMany(U => U.Orders)
                .WithOne(O => O.User);

            // Roles
            UserEntity.HasMany(U => U.Roles)
                .WithMany(R => R.Owners);

            // CreatedRoles
            UserEntity.HasMany(U => U.Roles)
                .WithOne(R => R.Auther);

            // CreatedBlogs
            UserEntity.HasMany(U => U.CreatedBlogs)
                .WithOne(B => B.Auther);

            // Cards
            UserEntity.HasMany(U => U.Cards)
                .WithOne(C => C.User);

            // Addresses
            UserEntity.HasMany(U => U.Addresses)
                .WithOne(A => A.User);

            // Pictures
            UserEntity.HasMany(U => U.Pictures);

            // Ratings
            UserEntity.HasMany(U => U.Ratings)
                .WithOne(R => R.User);

            // Coupons
            UserEntity.HasMany(U => U.Coupons)
                .WithOne(U => U.Owner);

            return modelBuilder;
        }
    }
}

using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class UserTable
    {
        public static ModelBuilder AddUserTable(this ModelBuilder modelBuilder)
        {
            var UserModel = modelBuilder.Entity<User>();

            UserModel.HasMany<Product>(U => U.WishList)
                .WithMany(P => P.Likers);

            // Id
            UserModel.HasKey(U => U.Id);

            // Email
            UserModel.Property(U => U.Email)
                .IsRequired()
                .HasMaxLength(50);
            UserModel
                .HasIndex(U => U.Email)
                .IsUnique();

            // Username
            UserModel.Property(U => U.UserName)
                .IsRequired()
                .HasMaxLength(30);
            UserModel
                .HasIndex(U => U.UserName)
                .IsUnique();

            // Passwordhash
            UserModel.Property(U => U.PasswordHash)
                .HasMaxLength(250);

            // Phone
            UserModel.Property(U => U.Phone)
                .IsFixedLength(true)
                .HasMaxLength(12);

            // ProfilePicture
            UserModel.HasOne(U => U.ProfilePicture);

            // WishList
            UserModel.HasMany(U => U.WishList)
                .WithMany(P => P.Likers);

            // Orders
            UserModel.HasMany(U => U.Orders)
                .WithOne(O => O.User);

            // Roles
            UserModel.HasMany(U => U.Roles)
                .WithMany(R => R.Owners);

            // CreatedRoles
            UserModel.HasMany(U => U.Roles)
                .WithOne(R => R.Auther);

            // CreatedBlogs
            UserModel.HasMany(U => U.CreatedBlogs)
                .WithOne(B => B.Auther);

            // Cards
            UserModel.HasMany(U => U.Cards)
                .WithOne(C => C.User);

            // Addresses
            UserModel.HasMany(U => U.Addresses)
                .WithOne(A => A.User);

            // Pictures
            UserModel.HasMany(U => U.Pictures);

            // Ratings
            UserModel.HasMany(U => U.Ratings)
                .WithOne(R => R.User);

            // Coupons
            UserModel.HasMany(U => U.Coupons)
                .WithOne(U => U.Owner);

            return modelBuilder;
        }
    }
}

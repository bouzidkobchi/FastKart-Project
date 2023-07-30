using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class ProductConfig
    {
        public static ModelBuilder AddProductEntity(this ModelBuilder modelBuilder)
        {
            var ProductEntity = modelBuilder.Entity<Product>();

            // Title
            ProductEntity.Property(P => P.Title)
                .IsRequired()
                .HasMaxLength(100);

            // Discription
            ProductEntity.Property(P => P.Discription)
                .HasMaxLength(2000);

            // Category
            ProductEntity.HasOne(P => P.Category)
                .WithMany(C => C.Products)
                .HasForeignKey(P => P.CategoryName);

            // Brand
            ProductEntity.HasOne(P => P.Brand)
                .WithMany(B => B.Products)
                .HasForeignKey(P => P.BrandName);

            // Form
            ProductEntity.HasOne(P => P.Form)
                .WithMany(F => F.Products)
                .HasForeignKey(P => P.FormName);

            // Store
            ProductEntity.HasOne(P => P.Store)
                .WithMany(S => S.Products)
                .HasForeignKey(P => P.StoreName);

            // PackageInfo
            ProductEntity.Property(P => P.PackageInfo)
                .HasMaxLength(50);

            // Manufactor
            ProductEntity.HasOne(P => P.Manufactor)
                .WithMany(M => M.Products)
                .HasForeignKey(P => P.ManufactorName);

            // PartNumber
            ProductEntity.HasIndex(P => P.PartNumber);

            ProductEntity.Property(P => P.PartNumber)
                .HasMaxLength(100);

            // ProductPictures
            ProductEntity.HasMany(P => P.ProductPictures);

            // Likers
            ProductEntity.HasMany(P => P.Likers)
                .WithMany(U => U.WishList);

            return modelBuilder;
        }
    }
}

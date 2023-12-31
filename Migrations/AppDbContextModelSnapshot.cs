﻿// <auto-generated />
using System;
using FastKart.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FastKart.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.20");

            modelBuilder.Entity("FastKart.Data.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AddressString")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .IsFixedLength();

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT")
                        .IsFixedLength();

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .IsUnicode(true)
                        .HasColumnType("TEXT");

                    b.Property<string>("SmallTitle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("WallpaperId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AutherId");

                    b.HasIndex("WallpaperId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("FastKart.Data.Entities.BlogComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BlogId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutherId");

                    b.HasIndex("BlogId");

                    b.ToTable("BlogComment");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Brand", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT")
                        .IsFixedLength();

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("PaymentMethodName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("PaymentMethodName");

                    b.HasIndex("UserId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Category", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("IconId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ImageId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Name");

                    b.HasIndex("IconId");

                    b.HasIndex("ImageId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FastKart.Data.Entities.CommentReply", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutherId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CommentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutherId");

                    b.HasIndex("CommentId");

                    b.ToTable("CommentReply");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Coupon", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("HasFreeShipping")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Code");

                    b.HasIndex("UserId");

                    b.ToTable("Coupons");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Form", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Manufactor", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Manufactors");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int?>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Amount")
                        .HasColumnType("REAL");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeliveryStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FastKart.Data.Entities.paymentMethod", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("paymentMethods");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("CurrentPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FormName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ManufactorName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("NetPrice")
                        .HasColumnType("REAL");

                    b.Property<int>("NetQuantity")
                        .HasColumnType("INTEGER");

                    b.Property<float>("OldPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("PackageInfo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PartNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BrandName");

                    b.HasIndex("CategoryName");

                    b.HasIndex("FormName");

                    b.HasIndex("ManufactorName");

                    b.HasIndex("StoreName");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Rating", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("Stars")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutherId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutherId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Store", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Name");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("FastKart.Data.Entities.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AutherId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AutherId");

                    b.ToTable("ToDo");
                });

            modelBuilder.Entity("FastKart.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT")
                        .IsFixedLength();

                    b.Property<int>("ProfilePictureId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("ProfilePictureId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.Property<int>("LikersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WishListId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LikersId", "WishListId");

                    b.HasIndex("WishListId");

                    b.ToTable("ProductUser");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<int>("OwnersId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RolesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OwnersId", "RolesId");

                    b.HasIndex("RolesId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Address", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Blog", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", "Auther")
                        .WithMany("CreatedBlogs")
                        .HasForeignKey("AutherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Media", "Wallpaper")
                        .WithMany()
                        .HasForeignKey("WallpaperId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auther");

                    b.Navigation("Wallpaper");
                });

            modelBuilder.Entity("FastKart.Data.Entities.BlogComment", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", "Auther")
                        .WithMany("Comments")
                        .HasForeignKey("AutherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auther");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Card", b =>
                {
                    b.HasOne("FastKart.Data.Entities.paymentMethod", "paymentMethod")
                        .WithMany("Cards")
                        .HasForeignKey("PaymentMethodName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.User", "User")
                        .WithMany("Cards")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("paymentMethod");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Category", b =>
                {
                    b.HasOne("FastKart.Data.Entities.Media", "icon")
                        .WithMany()
                        .HasForeignKey("IconId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Media", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");

                    b.Navigation("icon");
                });

            modelBuilder.Entity("FastKart.Data.Entities.CommentReply", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", "Auther")
                        .WithMany()
                        .HasForeignKey("AutherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.BlogComment", "Comment")
                        .WithMany("Replies")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auther");

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Coupon", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", "Owner")
                        .WithMany("Coupons")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Media", b =>
                {
                    b.HasOne("FastKart.Data.Entities.Product", null)
                        .WithMany("ProductPictures")
                        .HasForeignKey("ProductId");

                    b.HasOne("FastKart.Data.Entities.User", null)
                        .WithMany("Pictures")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Order", b =>
                {
                    b.HasOne("FastKart.Data.Entities.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Product", b =>
                {
                    b.HasOne("FastKart.Data.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Form", "Form")
                        .WithMany("Products")
                        .HasForeignKey("FormName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Manufactor", "Manufactor")
                        .WithMany("Products")
                        .HasForeignKey("ManufactorName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Store", "Store")
                        .WithMany("Products")
                        .HasForeignKey("StoreName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Form");

                    b.Navigation("Manufactor");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Rating", b =>
                {
                    b.HasOne("FastKart.Data.Entities.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.User", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Role", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", "Auther")
                        .WithMany("CreatedRoles")
                        .HasForeignKey("AutherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auther");
                });

            modelBuilder.Entity("FastKart.Data.Entities.ToDo", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", "Auther")
                        .WithMany("ToDos")
                        .HasForeignKey("AutherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auther");
                });

            modelBuilder.Entity("FastKart.Data.Entities.User", b =>
                {
                    b.HasOne("FastKart.Data.Entities.Media", "ProfilePicture")
                        .WithMany()
                        .HasForeignKey("ProfilePictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfilePicture");
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("LikersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("WishListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("FastKart.Data.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FastKart.Data.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FastKart.Data.Entities.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("FastKart.Data.Entities.BlogComment", b =>
                {
                    b.Navigation("Replies");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Form", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Manufactor", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FastKart.Data.Entities.paymentMethod", b =>
                {
                    b.Navigation("Cards");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Product", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ProductPictures");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("FastKart.Data.Entities.Store", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FastKart.Data.Entities.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Cards");

                    b.Navigation("Comments");

                    b.Navigation("Coupons");

                    b.Navigation("CreatedBlogs");

                    b.Navigation("CreatedRoles");

                    b.Navigation("Orders");

                    b.Navigation("Pictures");

                    b.Navigation("Ratings");

                    b.Navigation("ToDos");
                });
#pragma warning restore 612, 618
        }
    }
}

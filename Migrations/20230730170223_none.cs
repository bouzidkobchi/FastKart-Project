using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastKart.Migrations
{
    public partial class none : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "t");

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Manufactors",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufactors", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "paymentMethods",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentMethods", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    AddressString = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PinCode = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 5, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutherId = table.Column<int>(type: "INTEGER", nullable: false),
                    BlogId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutherId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SmallTitle = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: false),
                    WallpaperId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Code = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 16, nullable: false),
                    Password = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    PaymentMethodName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cards_paymentMethods_PaymentMethodName",
                        column: x => x.PaymentMethodName,
                        principalTable: "paymentMethods",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ImageId = table.Column<int>(type: "INTEGER", nullable: false),
                    IconId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Discription = table.Column<string>(type: "TEXT", nullable: false),
                    OldPrice = table.Column<float>(type: "REAL", nullable: false),
                    CurrentPrice = table.Column<float>(type: "REAL", nullable: false),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    BrandName = table.Column<string>(type: "TEXT", nullable: false),
                    FormName = table.Column<string>(type: "TEXT", nullable: false),
                    StoreName = table.Column<string>(type: "TEXT", nullable: false),
                    PackageInfo = table.Column<string>(type: "TEXT", nullable: false),
                    ManufactorName = table.Column<string>(type: "TEXT", nullable: false),
                    PartNumber = table.Column<string>(type: "TEXT", nullable: false),
                    NetQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    NetPrice = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandName",
                        column: x => x.BrandName,
                        principalTable: "Brands",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryName",
                        column: x => x.CategoryName,
                        principalTable: "Categories",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Forms_FormName",
                        column: x => x.FormName,
                        principalTable: "Forms",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Manufactors_ManufactorName",
                        column: x => x.ManufactorName,
                        principalTable: "Manufactors",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Stores_StoreName",
                        column: x => x.StoreName,
                        principalTable: "Stores",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CommentReply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutherId = table.Column<int>(type: "INTEGER", nullable: false),
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentReply_BlogComment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "BlogComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coupons",
                columns: table => new
                {
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    HasFreeShipping = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coupons", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<byte[]>(type: "BLOB", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Media_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", fixedLength: true, maxLength: 12, nullable: false),
                    ProfilePictureId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Media_ProfilePictureId",
                        column: x => x.ProfilePictureId,
                        principalTable: "Media",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CardId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<float>(type: "REAL", nullable: false),
                    DeliveryStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductUser",
                columns: table => new
                {
                    LikersId = table.Column<int>(type: "INTEGER", nullable: false),
                    WishListId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUser", x => new { x.LikersId, x.WishListId });
                    table.ForeignKey(
                        name: "FK_ProductUser_Products_WishListId",
                        column: x => x.WishListId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductUser_Users_LikersId",
                        column: x => x.LikersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Stars = table.Column<int>(type: "INTEGER", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Rating_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rating_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutherId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Users_AutherId",
                        column: x => x.AutherId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AutherId = table.Column<int>(type: "INTEGER", nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDo_Users_AutherId",
                        column: x => x.AutherId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    OwnersId = table.Column<int>(type: "INTEGER", nullable: false),
                    RolesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.OwnersId, x.RolesId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_AutherId",
                table: "BlogComment",
                column: "AutherId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComment_BlogId",
                table: "BlogComment",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_AutherId",
                table: "Blogs",
                column: "AutherId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_WallpaperId",
                table: "Blogs",
                column: "WallpaperId");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_Code",
                table: "Cards",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PaymentMethodName",
                table: "Cards",
                column: "PaymentMethodName");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_UserId",
                table: "Cards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IconId",
                table: "Categories",
                column: "IconId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ImageId",
                table: "Categories",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReply_AutherId",
                table: "CommentReply",
                column: "AutherId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentReply_CommentId",
                table: "CommentReply",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Coupons_UserId",
                table: "Coupons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_ProductId",
                table: "Media",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Media_UserId",
                table: "Media",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CardId",
                table: "Orders",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandName",
                table: "Products",
                column: "BrandName");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryName",
                table: "Products",
                column: "CategoryName");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FormName",
                table: "Products",
                column: "FormName");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufactorName",
                table: "Products",
                column: "ManufactorName");

            migrationBuilder.CreateIndex(
                name: "IX_Products_StoreName",
                table: "Products",
                column: "StoreName");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUser_WishListId",
                table: "ProductUser",
                column: "WishListId");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_ProductId",
                table: "Rating",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_AutherId",
                table: "Roles",
                column: "AutherId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_RolesId",
                table: "RoleUser",
                column: "RolesId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDo_AutherId",
                table: "ToDo",
                column: "AutherId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfilePictureId",
                table: "Users",
                column: "ProfilePictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComment_Blogs_BlogId",
                table: "BlogComment",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BlogComment_Users_AutherId",
                table: "BlogComment",
                column: "AutherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Media_WallpaperId",
                table: "Blogs",
                column: "WallpaperId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Users_AutherId",
                table: "Blogs",
                column: "AutherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Users_UserId",
                table: "Cards",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Media_IconId",
                table: "Categories",
                column: "IconId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Media_ImageId",
                table: "Categories",
                column: "ImageId",
                principalTable: "Media",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommentReply_Users_AutherId",
                table: "CommentReply",
                column: "AutherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Coupons_Users_UserId",
                table: "Coupons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Media_Users_UserId",
                table: "Media",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Media_Users_UserId",
                table: "Media");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Media_IconId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Media_ImageId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "CommentReply");

            migrationBuilder.DropTable(
                name: "Coupons");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductUser");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "ToDo");

            migrationBuilder.DropTable(
                name: "BlogComment");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "paymentMethods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Manufactors");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.CreateTable(
                name: "t",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_t", x => x.Id);
                });
        }
    }
}

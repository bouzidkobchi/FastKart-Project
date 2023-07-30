using FastKart.Data.Entities;
using FastKart.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Manufactor> Manufactors { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<paymentMethod> paymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var ConnectionString = config.GetSection("ConnectionStrings").GetSection("sqlite").Value;

            optionsBuilder.UseSqlite(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder
                .AddAddressEntity()
                .AddBlogCommentEntity()
                .AddBlogEntity()
                .AddBrandEntity()
                .AddCardEntity()
                .AddCategoryEntity()
                .AddCommentReplyEntity()
                .AddCouponEntity()
                .AddFormEntity()
                .AddManufactorEntity()
                .AddOrderEntity()
                .AddPaymentEntity()
                .AddRatingEntity()
                .AddRoleEntity()
                .AddStoreEntity()
                .AddUserEntity();
        }

    }
}

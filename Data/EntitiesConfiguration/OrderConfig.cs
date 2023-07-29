using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class OrderConfig
    {
        public static ModelBuilder AddOrderEntity(this ModelBuilder modelBuilder)
        {
            var OrderEntity = modelBuilder.Entity<Order>();

            // User
            OrderEntity.HasOne(O => O.User)
                .WithMany(U => U.Orders);

            // Product
            OrderEntity.HasOne(O => O.Product)
                .WithMany(P => P.Orders);

            // card
            OrderEntity.HasOne(O => O.Card);

            return modelBuilder;
        }
    }
}

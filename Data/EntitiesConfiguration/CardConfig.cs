
using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class CardConfig
    {
        public static ModelBuilder AddCardEntity(this ModelBuilder modelBuilder)
        {
            var CardEntity = modelBuilder.Entity<Card>();

            // User
            CardEntity.HasOne(C => C.User)
                .WithMany(U => U.Cards);

            // Code
            CardEntity.Property(C => C.Code)
                .IsRequired()
                .HasMaxLength(16)
                .IsFixedLength();

            CardEntity.HasIndex(C => C.Code)
                .IsUnique();

            // Password
            CardEntity.Property(C => C.Password)
                .IsRequired()
                .HasMaxLength(30);

            // paymentMethod
            CardEntity.HasOne(C => C.paymentMethod);

            return modelBuilder;
        }
    }
}

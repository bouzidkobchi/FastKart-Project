using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class PaymentMethodConfig
    {
        public static ModelBuilder AddPaymentEntity(this ModelBuilder modelBuilder)
        {
            var PaymentEntity = modelBuilder.Entity<paymentMethod>();

            // Name
            PaymentEntity.HasKey(P => P.Name);

            PaymentEntity.Property(P => P.Name)
                .HasMaxLength(30);

            // Cards
            PaymentEntity.HasMany(P => P.Cards)
                .WithOne(C => C.paymentMethod)
                .HasForeignKey(C => C.PaymentMethodName);

            return modelBuilder;
        }
    }
}

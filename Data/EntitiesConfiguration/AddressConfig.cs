using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class AddressConfig
    {
        public static ModelBuilder AddAddressEntity(this ModelBuilder modelBuilder)
        {
            var AddressEntity = modelBuilder.Entity<Address>();

            //AddressString
            AddressEntity.Property(A => A.AddressString)
                .HasMaxLength(50)
                .IsRequired();

            //Pincode
            AddressEntity.Property(A => A.PinCode)
                .HasMaxLength(5)
                .IsFixedLength()
                .IsRequired();

            //phone
            AddressEntity.Property(A => A.Phone)
                .HasMaxLength(12)
                .IsFixedLength()
                .IsRequired();

            return modelBuilder;
        }
    }
}

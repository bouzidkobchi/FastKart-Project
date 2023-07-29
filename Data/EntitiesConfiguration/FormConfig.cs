using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class FormConfig
    {
        public static ModelBuilder AddFormEntity(this ModelBuilder modelBuilder)
        {
            var FormEntity = modelBuilder.Entity<Form>();

            // Name
            FormEntity.HasKey(F => F.Name);

            FormEntity.Property(F => F.Name)
                .HasMaxLength(50);

            // Products
            FormEntity.HasMany(F => F.Products)
                .WithOne(P => P.Form);

            return modelBuilder;
        }
    }
}

using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class RoleConfig
    {
        public static ModelBuilder AddRoleEntity(this ModelBuilder modelBuilder)
        {
            var RoleEntity = modelBuilder.Entity<Role>();

            // Auther
            RoleEntity.HasOne(R => R.Auther)
                .WithMany(U => U.CreatedRoles)
                .HasForeignKey(R => R.AutherId);

            // Name
            RoleEntity.Property(R => R.Name)
                .IsRequired()
                .HasMaxLength(30);

            // Owners
            RoleEntity.HasMany(R => R.Owners)
                .WithMany(U => U.Roles);

            return modelBuilder;
        }
    }
}

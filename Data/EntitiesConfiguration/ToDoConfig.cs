using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class ToDoConfig
    {
        public static ModelBuilder AddToDoEntity(this ModelBuilder modelBuilder)
        {
            var ToDoEntity = modelBuilder.Entity<ToDo>();

            // Auther
            ToDoEntity.HasOne(T => T.Auther)
                .WithMany(U => U.ToDos)
                .HasForeignKey(T => T.AutherId);

            // Content
            ToDoEntity.Property(T => T.Content)
                .HasMaxLength(200)
                .IsRequired();

            return modelBuilder;
        }
    }
}

﻿using FastKart.Data.Entities;
using FastKart.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data
{
    public class AppDbContext : DbContext
    {
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
            modelBuilder.AddUserTable();
        }

    }
}

using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class MediaConfig
    {
        public static ModelBuilder AddMediaEntity(this ModelBuilder modelBuilder)
        {
            var MediaEntity = modelBuilder.Entity<Media>();

            int Mb = 1048576;

            MediaEntity.Property(M => M.Image)
                .HasColumnType("varbinary")
                .HasMaxLength(4 * Mb);

            return modelBuilder;
        }
    }
}

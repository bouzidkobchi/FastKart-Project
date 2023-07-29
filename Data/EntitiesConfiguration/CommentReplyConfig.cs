using FastKart.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastKart.Data.EntitiesConfiguration
{
    public static class CommentReplyConfig
    {
        public static ModelBuilder AddCommentReplyEntity(this ModelBuilder modelBuilder)
        {
            var ReplyEntity = modelBuilder.Entity<CommentReply>();

            // Auther
            ReplyEntity.HasOne(R => R.Auther);

            //Comment
            ReplyEntity.HasOne(R => R.Comment)
                .WithMany(C => C.Replies);

            //Content
            ReplyEntity.Property(R => R.Content)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode();

            return modelBuilder;
        }
    }
}

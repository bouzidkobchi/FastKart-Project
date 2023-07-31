using FastKart.Data.Entities;

namespace FastKart.Data.Interfaces
{
    public interface IBlogCommentRepository
    {
        // Read Part :
        int Count(Blog Blog);
        BlogComment GetById(int id);

        // Create Part :
        int AddComment(User Auther , Blog Blog , string Content);
        void ReplyOnComment(BlogComment Comment , string ReplyContent);
        void ReplyOnComment(int CommentId , string ReplyContent);

        // UpdatePart :
        void UpdateComment(int CommentId);
        void UpdateComment(BlogComment Comment);

        // Delete Part :
        void DeleteComment(int CommentId);
        void DeleteComment(BlogComment Comment);
    }
}

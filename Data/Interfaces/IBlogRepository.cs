using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IBlogRepository : IBasicRepository<Blog>
    {
        Blog? GetById(int id);
        Blog? GetByName(User Auther , string BlogName);
        IEnumerable<BlogComment>? GetComments(int BlogId);
        IEnumerable<BlogComment>? GetComments(Blog Blog);
        IEnumerable<BlogComment>? GetCommentsPaginate(int BlogId , int Page , int PageSize);
        IEnumerable<BlogComment>? GetCommentsPaginate(Blog Blog , int Page , int PageSize);

        int AddComment(User Auther, Blog Blog, string Content);
        int AddComment(User Auther, int BlogId, string Content);

        void DeleteComment(User Auther , int CommentId);
        void DeleteComment(User Auther , BlogComment Comment);

        void UpdateComment(User Auther, int CommentId , Action<BlogComment> action);

        void ReplyOnComment(User Auther , BlogComment Comment, string ReplyContent);
        void ReplyOnComment(User Auther , int CommentId, string ReplyContent);
    }
}
using FastKart.Data.Entities;

namespace FastKart.Data.Interfaces
{
    public interface IBlogRepository
    {
        // Read Part :
        int Count();
        Blog GetById(int id);
        Blog GetByName(User Auther , string BlogName);
        IEnumerable<BlogComment> GetComments(int BlogId);
        IEnumerable<BlogComment> GetComments(Blog Blog);
        IEnumerable<BlogComment> GetCommentsPaginate(int BlogId , int Page , int PerPage);
        IEnumerable<BlogComment> GetCommentsPaginate(Blog Blog , int Page , int PerPage);
        IEnumerable<Blog> GetBlogsByCategory(string BlogCategoryName);
        IEnumerable<Blog> GetBlogsByCategory(Category BlogCategory);
        IEnumerable<Blog> GetBlogsByAuther(int BlogAutherId);
        IEnumerable<Blog> GetBlogsByAuther(User BlogAuther);
        Dictionary<BlogCategory, int> BlogsPerCategory();
        IEnumerable<Blog> GetBlogsPaginate(int Page, int PerPage);
        IEnumerable<Blog> GetBlogsSummaryPaginate(int Page, int PerPage); // return blogTitle , date , picture

        // Create Part :
        int AddBlog(User Auther, string CategoryName, string Title, string SmallTitle, string Content, byte[] Wallpaper);

        // Update Part
        void UpdateBlog(Blog Blog , string? NewTitle , string? NewSmallTitle , string? NewContent , string? NewCategoryName , byte[] NewWallpaper);
        void UpdateBlog(int BlogId , string? NewTitle , string? NewSmallTitle , string? NewContent , string? NewCategoryName , byte[] NewWallpaper);

        // Delete Part
        void DeleteBlog(int BlogId);
        void DeleteBlog(Blog Blog);
        void DeleteByName(User Auther , string BlogName);

    }
}
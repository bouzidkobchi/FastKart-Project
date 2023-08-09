using FastKart.Data.Entities;
using FastKart.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastKart.Data.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        //private static AppDbContext _context
        //{
        //    get => new AppDbContext();
        //}
        private readonly AppDbContext _context;
        public BlogRepository(AppDbContext context) 
        {
            _context = context;
        }

        public int Add(Blog item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        public int AddComment(User Auther, Blog Blog, string Content)
        {
            var NewComment = new BlogComment { Content = Content, Auther = Auther  , Blog = Blog};
            _context.Add(NewComment);
            _context.SaveChanges();
            return NewComment.Id;
        }

        public int AddComment(User Auther, int BlogId, string Content)
        {
            var NewComment = new BlogComment { Content = Content, Auther = Auther  , BlogId = BlogId};
            _context.Add(NewComment);
            _context.SaveChanges();
            return NewComment.Id;
        }

        public void AddRange(IEnumerable<Blog> items)
        {
            _context.AddRange(items);
            _context.SaveChanges();
        }

        public int Count()
        {
            return _context.Blogs.Count();
        }

        public void Delete(Predicate<Blog>? Condition, int Count = 1)
        {
            if (Condition is not null)
            {
                var Records = _context.Blogs.Where(B => Condition(B));
                _context.RemoveRange(Records);
            }
            _context.SaveChanges();
        }

        public void Delete(Blog item)
        {
            _context.Remove(item);
            _context.SaveChanges();
        }

        public void DeleteComment(User Auther , int CommentId)
        {
            var Comment = _context.Comments.First(C => C.Id == CommentId);
            _context.Remove(Comment);
            _context.SaveChanges();
        }

        public void DeleteComment(User Auther , BlogComment Comment)
        {
            _context.Remove(Comment);
            _context.SaveChanges();
        }

        public IEnumerable<Blog> Filter(Predicate<Blog> Condition)
        {
            return _context.Blogs.Where(B => Condition(B));
        }

        public IEnumerable<Blog> FilterPage(Predicate<Blog> Condition, int page, int pageSize)
        {
            return Filter(Condition).Skip(page * pageSize).Take(pageSize);
        }

        public IEnumerable<Blog> GetAll()
        {
            return _context.Blogs;
        }

        public Blog? GetById(int id)
        {
            return _context.Blogs.Find(id);
        }

        public Blog? GetByName(User Auther, string BlogName)
        {
            return _context.Blogs.FirstOrDefault(B => B.Auther == Auther && B.Title == BlogName);
        }

        public IEnumerable<BlogComment>? GetComments(int BlogId)
        {
            return _context.Blogs.Find(BlogId)?.Comments;
        }

        public IEnumerable<BlogComment>? GetComments(Blog Blog)
        {
            return Blog.Comments;
        }

        public IEnumerable<BlogComment>? GetCommentsPaginate(int BlogId, int Page, int PageSize)
        {
            return GetComments(BlogId)?.Skip(Page).Take(PageSize);
        }

        public IEnumerable<BlogComment>? GetCommentsPaginate(Blog Blog, int Page, int PageSize)
        {
            return GetComments(Blog)?.Skip(Page * PageSize).Take(PageSize);
        }

        public IEnumerable<Blog> GetPage(int page, int pageSize)
        {
            return _context.Blogs.Skip(page * pageSize).Take(pageSize);
        }

        public void ReplyOnComment(User Auther, BlogComment Comment, string ReplyContent)
        {
            var Reply = new CommentReply { Auther = Auther , Comment = Comment , Content = ReplyContent };
            _context.Add(Reply);
            _context.SaveChanges();
        }

        public void ReplyOnComment(User Auther, int CommentId, string ReplyContent)
        {
            var Reply = new CommentReply { Auther = Auther, CommentId = CommentId, Content = ReplyContent };
            _context.Add(Reply);
            _context.SaveChanges();
        }

        public IEnumerable<TResult> Select<TResult>(Func<Blog, TResult> func)
        {
            return _context.Blogs.Select(B => func(B));
        }

        public IEnumerable<TResult> SelectPage<TResult>(Func<Blog, TResult> func, int page, int pageSize)
        {
            return Select(func).Skip(page * pageSize).Take(pageSize);
        }

        public void Update(Blog item, Action<Blog> action)
        {
            action(item);
            _context.SaveChanges();
        }

        public void UpdateComment(User Auther, int CommentId, Action<BlogComment> action)
        {
            var Comment = _context.Comments.Find(CommentId);
            if (Comment is not null)
                action(Comment);
            _context.SaveChanges();
        }
    }
}

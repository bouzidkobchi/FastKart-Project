namespace FastKart.Data.Entities
{
    // done
    public class BlogComment
    {
        public int Id { get; set; }
        public int AutherId { get; set; }
        public User Auther { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public string Content { get; set; }
        public List<CommentReply> Replies { get; set; }
    }
}

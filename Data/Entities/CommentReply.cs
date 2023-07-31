namespace FastKart.Data.Entities
{
    public class CommentReply
    {
        public int Id { get; set; }
        public int AutherId { get; set; }
        public User Auther { get; set; }
        public int CommentId { get; set; }
        public BlogComment Comment { get; set; }
        public string Content { get; set; }
    }
}

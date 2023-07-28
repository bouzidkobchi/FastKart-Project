namespace FastKart.Data.Entities
{
    // done
    public class Blog
    {
        public int Id { get; set; }
        public int AutherId { get; set; }
        public User Auther { get; set; }
        public string Title { get; set; }
        public string SmallTitle { get; set; }
        public string Content { get; set; }
        public int WelpaperId { get; set; }
        public Media Welpaper { get; set; }
        public List<BlogComment> Comments { get; set; }
    }
}

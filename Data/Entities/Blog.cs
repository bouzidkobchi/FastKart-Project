namespace FastKart.Data.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public int AutherId { get; set; }
        public User Auther { get; set; }
        public string? BlogCategoryName { get; set; }
        public BlogCategory BlogCategory { get; set; }
        public string Title { get; set; }
        public string SmallTitle { get; set; }
        public string Content { get; set; }
        public int WallpaperId { get; set; }
        public Media Wallpaper { get; set; }
        public List<BlogComment> Comments { get; set; }
    }
}

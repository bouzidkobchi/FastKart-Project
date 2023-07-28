namespace FastKart.Data.Entities
{
    public class ToDo
    {
        public int Id { get; set; }
        public int AutherId { get; set; }
        public User Auther { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

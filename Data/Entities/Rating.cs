namespace FastKart.Data.Entities
{
    public class Rating
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Stars { get; set; }
        public string Comment { get; set; }
    }
}

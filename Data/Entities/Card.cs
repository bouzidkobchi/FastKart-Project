namespace FastKart.Data.Entities
{
    // done
    public class Card
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
    }
}

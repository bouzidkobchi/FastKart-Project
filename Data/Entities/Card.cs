namespace FastKart.Data.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
        public string PaymentMethodName { get; set; }
        public paymentMethod paymentMethod { get; set; }
    }
}

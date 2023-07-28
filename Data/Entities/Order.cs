namespace FastKart.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PaymentMethodId { get; set; }
        //public PaymentMethod PaymentMethod { get; set; }
        //public OrderStatus MyProperty { get; set; }
        public float Amount { get; set; }
    }
}

using FastKart.Data.Enums;

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
        public int CardId { get; set; }
        public Card Card { get; set; }
        public float Amount { get; set; }
        public OrderDeliveryStatus DeliveryStatus { get; set; }
    }
}

namespace FastKart.Data.Entities
{
    // done
    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string AddressString { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
    }
}

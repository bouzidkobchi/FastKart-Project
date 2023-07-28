namespace FastKart.Data.Entities
{
    // done
    public class Manufactor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}

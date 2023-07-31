namespace FastKart.Data.Entities
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}

namespace FastKart.Data.Entities
{
    public class Store
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}

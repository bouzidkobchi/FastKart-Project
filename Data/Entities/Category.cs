namespace FastKart.Data.Entities
{
    // done
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ImageId { get; set; }
        public Media Image { get; set; }
        public int IconId { get; set; }
        public Media icon { get; set; }
        public List<Product> Products { get; set; }
    }
}

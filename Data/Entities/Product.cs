using FastKart.Data.Enums;

namespace FastKart.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Discription { get; set; }
        public float OldPrice { get; set; }
        public float CurrentPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int FormId { get; set; }
        public Form Form { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public string PackageInfo { get; set; }
        public int ManufactorId { get; set; }
        public Manufactor Manufactor { get; set; }
        public string PartNumber { get; set; }
        public int NetQuantity { get; set; }
        public decimal Amount { get; set; }
        public ProductStatus Status { get; set; }
        public float NetPrice { get; set; }
        public List<Media> ProductsPictures { get; set; }
        public List<User> Likers { get; set; }
        public List<Order> Orders { get; set; }
        public List<Rating> Ratings { get; set; }
        //weight choices
    }
}

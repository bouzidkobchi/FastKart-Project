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
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        public string BrandName { get; set; }
        public Brand Brand { get; set; }
        public string FormName { get; set; }
        public Form Form { get; set; }
        public string StoreName { get; set; }
        public Store Store { get; set; }
        public string PackageInfo { get; set; }
        public string ManufactorName { get; set; }
        public Manufactor Manufactor { get; set; }
        public string PartNumber { get; set; }
        public int NetQuantity { get; set; }
        public decimal Amount { get; set; }
        public ProductStatus Status { get; set; }
        public float NetPrice { get; set; }
        public List<Media> ProductPictures { get; set; }
        public List<User> Likers { get; set; }
        public List<Order> Orders { get; set; }
        public List<Rating> Ratings { get; set; }
        //weight choices
    }
}

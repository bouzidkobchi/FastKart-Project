﻿namespace FastKart.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public int ProfilePictureId {get; set;}
        public Media ProfilePicture { get; set; }
        public List<Product> WishList { get; set; }
        public List<Order> Orders { get; set; }
        public List<Role> Roles { get; set; }
        public List<Role> CreatedRoles { get; set; }
        public List<Blog> CreatedBlogs { get; set; }
        public List<BlogComment> Comments { get; set; }
        public List<Card> Cards { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Media> Pictures { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Coupon> Coupons { get; set; }
        public List<ToDo> ToDos { get; set; }

    }
}

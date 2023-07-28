using FastKart.Data.Enums;

namespace FastKart.Data.Entities
{
    public class Coupon
    {
        public string Code { get; set; }
        public int UserId { get; set; }
        public User Owner { get; set; }
        public string Title { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public CouponStatus Status { get; set; }
        public bool HasFreeShipping { get; set; }
        //public int Quantity { get; set; }
        //public  Dis { get; set; }
    }
}

namespace FastKart.Data.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public int AutherId { get; set; }
        public User Auther { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<User> Owners { get; set; }

    }
}


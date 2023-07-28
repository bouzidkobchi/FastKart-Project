namespace FastKart.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public int ProfilePictureId {get; set;}
    }
}

using System.ComponentModel.DataAnnotations;

namespace FastKart.Data.Dto
{
    public class UserBasicDto
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string phone { get; set; }
    }
}

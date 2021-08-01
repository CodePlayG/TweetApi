using System.ComponentModel.DataAnnotations;

namespace TweetApi.Models
{
    public class User
    {
        [Key]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string ContactNumber { get; set; }
    }
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

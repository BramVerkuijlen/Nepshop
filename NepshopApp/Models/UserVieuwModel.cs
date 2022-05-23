using System.ComponentModel.DataAnnotations;

namespace NepshopApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Username { get; set; }

        [Required]
        [MinLength(4)]
        public string Password { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Email { get; set; }

        public int Points { get; set; }
    }
}

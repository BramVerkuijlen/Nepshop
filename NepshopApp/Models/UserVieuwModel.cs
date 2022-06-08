using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NepshopApp.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Email { get; set; }

        [Range(0.0, int.MaxValue, ErrorMessage = "Amount must be 0 or greater")]
        public int Points { get; set; }

    }
}

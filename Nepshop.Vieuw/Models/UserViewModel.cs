namespace Nepshop.View.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Nepshop.Models
    {
        public class UserViewModel
        {
            public int Id { get; set; }

            [Required, Display(Name = "User name")]
            public string UserName { get; set; }

            [Required]
            public string Password { get; set; }

            [Required]
            public string Firstname { get; set; }

            [Required]
            public string Lastname { get; set; }

            [Required]
            public string Email { get; set; }

            [Required]
            public int Points { get; set; }
        }
    }
}

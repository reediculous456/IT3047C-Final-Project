using System.ComponentModel.DataAnnotations;

namespace HikingTrails.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter the hiker's last name.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter the hiker's first name.")]
        public string FirstName { get; set; }

        public string Bio { get; set; }

        public int Age { get; set; }
    }
}

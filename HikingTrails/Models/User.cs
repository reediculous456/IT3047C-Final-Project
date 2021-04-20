using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HikingTrails.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter the hiker's last name.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter the hiker's first name.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        public string Bio { get; set; }

        public int Age { get; set; }

        [NotMapped]
        [Display(Name = "Selected Hikes")]
        public ICollection<int> SelectedHikes { get; set; }
        public List<Hike> Hikes { get; set; }
    }
}

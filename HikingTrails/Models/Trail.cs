using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HikingTrails.Models
{
    public class Trail
    {
        public int TrailId { get; set; }

        [Required(ErrorMessage = "Please enter a trail name.")]
        [Display(Name = "Trail name")]
        public string TrailName { get; set; }

        [Required(ErrorMessage = "Please enter the trail location.")]
        public string Location { get; set; }

        public List<Hike> Hikes { get; set; }
    }
}

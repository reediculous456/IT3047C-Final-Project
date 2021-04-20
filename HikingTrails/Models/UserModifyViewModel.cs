using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace HikingTrails.Models
{
    public class UserModifyViewModel : PageModel
    {
        public UserModifyViewModel(User user, List<SelectListItem> trails)
        {
            User = user;
            Trails = trails;
        }

        public new User User { get; set; }
        public List<SelectListItem> Trails { get; set; }
    }
}

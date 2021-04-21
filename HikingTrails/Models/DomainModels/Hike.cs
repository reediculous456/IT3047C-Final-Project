using System;

namespace HikingTrails.Models
{
    public class Hike
    {
        public int HikeId { get; set; }

        public int TrailId { get; set; }    // FK 
        public string Trailname { get; set; }
        
        public int UserId { get; set; }     // FK
        public string Username { get; set; }

        public DateTime Date { get; set; }

       
    }
}

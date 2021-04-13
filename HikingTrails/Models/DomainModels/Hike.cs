namespace HikingTrails.Models
{
    public class Hike
    {
        public int HikeId { get; set; }

        public int TrailId { get; set; }    // FK 
        public Trail Trail { get; set; }

        public int UserId { get; set; }     // FK
        public User User { get; set; }
    }
}

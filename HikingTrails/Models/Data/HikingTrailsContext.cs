using Microsoft.EntityFrameworkCore;

namespace HikingTrails.Models
{
    public class HikingTrailsContext : DbContext
    {
        public HikingTrailsContext(DbContextOptions<HikingTrailsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TrailConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
        }

        public DbSet<User> User { get; set; }

        public DbSet<Trail> Trail { get; set; }
    }
}

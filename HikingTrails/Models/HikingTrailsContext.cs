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
            modelBuilder.Entity<Hike>().HasKey(h => new { h.UserId, h.TrailId });

            modelBuilder.Entity<Hike>()
                .HasOne(h => h.User)
                .WithMany(u => u.Hikes)
                .HasForeignKey(h => h.UserId);

            modelBuilder.Entity<Hike>()
                .HasOne(h => h.Trail)
                .WithMany(t => t.Hikes)
                .HasForeignKey(h => h.TrailId);

            modelBuilder.ApplyConfiguration(new TrailConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new HikeConfig());
        }

        public DbSet<User> User { get; set; }

        public DbSet<Trail> Trail { get; set; }

        public DbSet<Hike> Hike { get; set; }
    }
}

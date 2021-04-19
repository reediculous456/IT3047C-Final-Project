using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HikingTrails.Models
{
    internal class HikeConfig : IEntityTypeConfiguration<Hike>
    {
        public void Configure(EntityTypeBuilder<Hike> entity)
        {
            entity.HasData(
               new Hike { TrailId = 1, UserId = 1 },
               new Hike { TrailId = 1, UserId = 2 },
               new Hike { TrailId = 2, UserId = 3 },
               new Hike { TrailId = 2, UserId = 4 },
               new Hike { TrailId = 3, UserId = 5 }
            );
        }
    }
}

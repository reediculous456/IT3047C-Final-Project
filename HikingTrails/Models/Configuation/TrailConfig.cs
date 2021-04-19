using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HikingTrails.Models
{
    internal class TrailConfig : IEntityTypeConfiguration<Trail>
    {
        public void Configure(EntityTypeBuilder<Trail> entity)
        {
            entity.HasData(
               new Trail { TrailId = 1, TrailName = "Rowe Woods", Location = "Milford, OH" },
               new Trail { TrailId = 2, TrailName = "Long Branch Farm", Location = "Goshen, OH" },
               new Trail { TrailId = 3, TrailName = "Whispering Cave", Location = "Logan, OH" }
            );
        }
    }
}

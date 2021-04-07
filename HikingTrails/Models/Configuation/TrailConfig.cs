using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HikingTrails.Models.Configuation
{
    

        internal class TrailConfig : IEntityTypeConfiguration<Trail>
        {

            public void Configure(EntityTypeBuilder<Trail> entity)
            {
                entity.HasData(
                   new Trail { TrailId = 1, TrailName = "Rowe Woods", Location = "Milford, OH" },
                   new Trail { TrailId = 2, TrailName = "Long Branch Farm", Location = "Goshen, OH" }
                //  new Hiker { HikerId = 3, FirstName = "Jaime", LastName = "Escalante" }
                );
            }

        }

    
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HikingTrails.Models
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasData(
               new User { UserId = 1, FirstName = "Anthony", LastName = "Morgan" }
            //  ,
            //   new Hiker { HikerId = 2, FirstName = "Maria", LastName = "Montessori" },
            //  new Hiker { HikerId = 3, FirstName = "Jaime", LastName = "Escalante" }
            );
        }

    }
}

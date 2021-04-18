using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HikingTrails.Models
{
    internal class UserConfig : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasData(
               new User
               {
                   UserId = 1,
                   FirstName = "Anthony",
                   LastName = "Morgan"
               },
               new User
               {
                   UserId = 2,
                   FirstName = "Wesley",
                   LastName = "Reed",
                   Age = 20,
                   Bio = "Hello, my name is Wes and I'm a 3rd year IT student in the software and cyber tracks. I'm also in the IT accelerated program for my MSIT, and I play Trombone in the Bearcat Bands.",
               },
               new User
               {
                   UserId = 3,
                   FirstName = "Christian",
                   LastName = "Rosario",
                   Age = 23,
                   Bio = "Hello, my name is Christian and I'm a 3rd year IT student in the software development track. I don't go hiking regularly, but the few times I have gone were pretty fun."
               }
            );
        }

    }
}

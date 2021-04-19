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
                   LastName = "Morgan",
                   Age = 54,
                   Bio = "I'm a non-traditional student in the software development track. I have about 10 classes to go for my Bachelor's Degree. I got my Associate's Degree in Computer Engineering Technology in 1994 from Cincinnati Technical College.",
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
               },
               new User
               {
                   UserId = 4,
                   FirstName = "David",
                   LastName = "Stober",
                   Age = 21,
                   Bio = "I'm a fourth year IT student with tracks in software development as well as game design and simulation."
               }
            );
        }

    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace HikingTrails.Migrations
{
    public partial class _4192021164252 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "TrailId", "Location", "TrailName" },
                values: new object[] { 3, "Logan, OH", "Whispering Cave" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Age", "Bio" },
                values: new object[] { 54, "I'm a non-traditional student in the software development track. I have about 10 classes to go for my Bachelor's Degree. I got my Associate's Degree in Computer Engineering Technology in 1994 from Cincinnati Technical College." });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Age", "Bio", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 2, 20, "Hello, my name is Wes and I'm a 3rd year IT student in the software and cyber tracks. I'm also in the IT accelerated program for my MSIT, and I play Trombone in the Bearcat Bands.", "Wesley", "Reed" },
                    { 3, 23, "Hello, my name is Christian and I'm a 3rd year IT student in the software development track. I don't go hiking regularly, but the few times I have gone were pretty fun.", "Christian", "Rosario" },
                    { 5, 21, "Hello, my name is Robby and I'm a 3rd year IT student in the software development track, aswell as an ACCEND student, doing my MBA. I love hiking, camping and the outdoors in general, my favorite hiking spot around here is Glen Helen Trail up in Yellow Springs. My passion in life is Music and i hope to one day open a music school and create interactive software to both help people learn to play music and to help composers get out of creative block.", "Robby", "Hoover" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trail",
                keyColumn: "TrailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Age", "Bio" },
                values: new object[] { 0, null });
        }
    }
}

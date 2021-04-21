using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HikingTrails.Migrations
{
    public partial class _20210420 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hike",
                columns: table => new
                {
                    HikeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailId = table.Column<int>(nullable: false),
                    Trailname = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hike", x => x.HikeId);
                });

            migrationBuilder.CreateTable(
                name: "Trail",
                columns: table => new
                {
                    TrailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailName = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trail", x => x.TrailId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Bio = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "TrailId", "Location", "TrailName" },
                values: new object[,]
                {
                    { 1, "Milford, OH", "Rowe Woods" },
                    { 2, "Goshen, OH", "Long Branch Farm" },
                    { 3, "Logan, OH", "Whispering Cave" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Age", "Bio", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 54, "I'm a non-traditional student in the software development track. I have about 10 classes to go for my Bachelor's Degree. I got my Associate's Degree in Computer Engineering Technology in 1994 from Cincinnati Technical College.", "Anthony", "Morgan" },
                    { 2, 20, "Hello, my name is Wes and I'm a 3rd year IT student in the software and cyber tracks. I'm also in the IT accelerated program for my MSIT, and I play Trombone in the Bearcat Bands.", "Wesley", "Reed" },
                    { 3, 23, "Hello, my name is Christian and I'm a 3rd year IT student in the software development track. I don't go hiking regularly, but the few times I have gone were pretty fun.", "Christian", "Rosario" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hike");

            migrationBuilder.DropTable(
                name: "Trail");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

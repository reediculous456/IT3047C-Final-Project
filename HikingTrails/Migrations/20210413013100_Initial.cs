using Microsoft.EntityFrameworkCore.Migrations;

namespace HikingTrails.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trail",
                columns: table => new
                {
                    TrailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrailName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trail", x => x.TrailId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "TrailId", "Location", "TrailName" },
                values: new object[] { 1, "Milford, OH", "Rowe Woods" });

            migrationBuilder.InsertData(
                table: "Trail",
                columns: new[] { "TrailId", "Location", "TrailName" },
                values: new object[] { 2, "Goshen, OH", "Long Branch Farm" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Age", "FirstName", "LastName" },
                values: new object[] { 1, 0, "Anthony", "Morgan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trail");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}

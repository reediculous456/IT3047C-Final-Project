using Microsoft.EntityFrameworkCore.Migrations;

namespace HikingTrails.Migrations
{
    public partial class HikeRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hike",
                columns: table => new
                {
                    TrailId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hike", x => new { x.UserId, x.TrailId });
                    table.ForeignKey(
                        name: "FK_Hike_Trail_TrailId",
                        column: x => x.TrailId,
                        principalTable: "Trail",
                        principalColumn: "TrailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hike_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hike",
                columns: new[] { "TrailId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hike_TrailId",
                table: "Hike",
                column: "TrailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hike");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace REST_BOT.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "planners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    activity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    startTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    breakTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_planners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "planners");
        }
    }
}

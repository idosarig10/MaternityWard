using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class AddTableTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dasd",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    hourlyWage = table.Column<float>(type: "REAL", nullable: false),
                    workerType = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dasd", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dasd");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class ChangeMonthWorkHoursToKeyless2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthWorkHours",
                columns: table => new
                {
                    Hours = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthWorkHours");
        }
    }
}

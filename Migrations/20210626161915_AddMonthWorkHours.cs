using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class AddMonthWorkHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MonthWorkHours",
                columns: table => new
                {
                    MonthWorkHoursType = table.Column<float>(type: "REAL", nullable: false),
                    Hours = table.Column<float>(type: "REAL", nullable: false),
                    WorkerId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthWorkHours", x => x.MonthWorkHoursType);
                    table.ForeignKey(
                        name: "FK_MonthWorkHours_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MonthWorkHours_WorkerId",
                table: "MonthWorkHours",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthWorkHours");
        }
    }
}

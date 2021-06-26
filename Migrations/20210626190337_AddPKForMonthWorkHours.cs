using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class AddPKForMonthWorkHours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MonthWorkHours_WorkerId",
                table: "MonthWorkHours");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours");

            migrationBuilder.CreateIndex(
                name: "IX_MonthWorkHours_WorkerId",
                table: "MonthWorkHours",
                column: "WorkerId");
        }
    }
}

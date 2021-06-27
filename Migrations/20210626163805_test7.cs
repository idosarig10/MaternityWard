using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId1",
                table: "MonthWorkHours");

            migrationBuilder.DropIndex(
                name: "IX_MonthWorkHours_WorkerId1",
                table: "MonthWorkHours");

            migrationBuilder.DropColumn(
                name: "WorkerId1",
                table: "MonthWorkHours");

            migrationBuilder.AddColumn<string>(
                name: "WorkerId",
                table: "Workers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Workers_WorkerId",
                table: "Workers",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Workers_MonthWorkHours_WorkerId",
                table: "Workers",
                column: "WorkerId",
                principalTable: "MonthWorkHours",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_MonthWorkHours_WorkerId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorkerId",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Workers");

            migrationBuilder.AddColumn<string>(
                name: "WorkerId1",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MonthWorkHours_WorkerId1",
                table: "MonthWorkHours",
                column: "WorkerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId1",
                table: "MonthWorkHours",
                column: "WorkerId1",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

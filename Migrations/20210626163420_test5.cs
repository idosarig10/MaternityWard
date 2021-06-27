using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Workers_WorkerId",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Prices_WorkerId",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Prices");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WorkerId",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_MonthWorkHours_WorkerId",
                table: "MonthWorkHours",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId",
                table: "MonthWorkHours",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId",
                table: "MonthWorkHours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours");

            migrationBuilder.DropIndex(
                name: "IX_MonthWorkHours_WorkerId",
                table: "MonthWorkHours");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MonthWorkHours");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "MonthWorkHours");

            migrationBuilder.AddColumn<string>(
                name: "WorkerId",
                table: "Prices",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prices_WorkerId",
                table: "Prices",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Workers_WorkerId",
                table: "Prices",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

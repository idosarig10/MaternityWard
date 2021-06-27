using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class test9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workers_MonthWorkHours_WorkerId",
                table: "Workers");

            migrationBuilder.DropIndex(
                name: "IX_Workers_WorkerId",
                table: "Workers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours");

            migrationBuilder.DropColumn(
                name: "WorkerId",
                table: "Workers");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

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

            migrationBuilder.DropIndex(
                name: "IX_MonthWorkHours_WorkerId",
                table: "MonthWorkHours");

            migrationBuilder.AddColumn<string>(
                name: "WorkerId",
                table: "Workers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours",
                column: "WorkerId");

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
    }
}

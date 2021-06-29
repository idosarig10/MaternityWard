using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkerId1",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours",
                column: "WorkerId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId1",
                table: "MonthWorkHours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MonthWorkHours",
                table: "MonthWorkHours");

            migrationBuilder.DropIndex(
                name: "IX_MonthWorkHours_WorkerId1",
                table: "MonthWorkHours");

            migrationBuilder.DropColumn(
                name: "WorkerId1",
                table: "MonthWorkHours");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerId",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

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
    }
}

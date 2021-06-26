using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

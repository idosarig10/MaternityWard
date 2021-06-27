using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class AddWorkTime4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_Workers_WorkerId",
                table: "WorkTimes",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_Workers_WorkerId",
                table: "WorkTimes");
        }
    }
}

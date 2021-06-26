using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class AddWorkTime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkTimes_Workers_WorkerId",
                table: "WorkTimes");

            migrationBuilder.DropIndex(
                name: "IX_WorkTimes_WorkerId",
                table: "WorkTimes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkTimes",
                table: "WorkTimes",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkTimes",
                table: "WorkTimes");

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_WorkerId",
                table: "WorkTimes",
                column: "WorkerId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkTimes_Workers_WorkerId",
                table: "WorkTimes",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

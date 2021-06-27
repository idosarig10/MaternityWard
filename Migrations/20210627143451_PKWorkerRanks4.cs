using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class PKWorkerRanks4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkersRanks_WorkerId",
                table: "WorkersRanks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkersRanks",
                table: "WorkersRanks",
                columns: new[] { "WorkerId", "Rank" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersRanks",
                table: "WorkersRanks");

            migrationBuilder.CreateIndex(
                name: "IX_WorkersRanks_WorkerId",
                table: "WorkersRanks",
                column: "WorkerId");
        }
    }
}

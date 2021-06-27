using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class PKWorkerRanks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkersRanks_WorkerId_Rank",
                table: "WorkersRanks");

            migrationBuilder.CreateIndex(
                name: "IX_WorkersRanks_WorkerId",
                table: "WorkersRanks",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_WorkersRanks_WorkerId",
                table: "WorkersRanks");

            migrationBuilder.CreateIndex(
                name: "IX_WorkersRanks_WorkerId_Rank",
                table: "WorkersRanks",
                columns: new[] { "WorkerId", "Rank" },
                unique: true);
        }
    }
}

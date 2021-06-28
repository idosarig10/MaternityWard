using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class RemoveWorkerTypeRank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_workerTypeRanks",
                table: "workerTypeRanks");

            migrationBuilder.RenameTable(
                name: "workerTypeRanks",
                newName: "WorkerTypeRank");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkerTypeRank",
                table: "WorkerTypeRank",
                columns: new[] { "WorkerType", "Rank" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkerTypeRank",
                table: "WorkerTypeRank");

            migrationBuilder.RenameTable(
                name: "WorkerTypeRank",
                newName: "workerTypeRanks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_workerTypeRanks",
                table: "workerTypeRanks",
                columns: new[] { "WorkerType", "Rank" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class WorkerTypeRank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthMinimunWorkHours_Workers_WorkerId",
                table: "MonthMinimunWorkHours");

            migrationBuilder.DropTable(
                name: "WorkerRanks");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "MonthMinimunWorkHours",
                newName: "Rank");

            migrationBuilder.CreateTable(
                name: "workerTypeRanks",
                columns: table => new
                {
                    WorkerType = table.Column<string>(type: "TEXT", nullable: false),
                    Rank = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workerTypeRanks", x => new { x.WorkerType, x.Rank });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "workerTypeRanks");

            migrationBuilder.RenameColumn(
                name: "Rank",
                table: "MonthMinimunWorkHours",
                newName: "WorkerId");

            migrationBuilder.CreateTable(
                name: "WorkerRanks",
                columns: table => new
                {
                    WorkerId = table.Column<string>(type: "TEXT", nullable: false),
                    Rank = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerRanks", x => new { x.WorkerId, x.Rank });
                    table.ForeignKey(
                        name: "FK_WorkerRanks_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_MonthMinimunWorkHours_Workers_WorkerId",
                table: "MonthMinimunWorkHours",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

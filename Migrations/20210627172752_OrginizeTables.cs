using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class OrginizeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkersRanks_Workers_WorkerId",
                table: "WorkersRanks");

            migrationBuilder.DropTable(
                name: "MinimunMonthHours");

            migrationBuilder.DropTable(
                name: "RankBonuses");

            migrationBuilder.DropTable(
                name: "WorkTimes");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkersRanks",
                table: "WorkersRanks");

            migrationBuilder.DropColumn(
                name: "HourlyWage",
                table: "Workers");

            migrationBuilder.RenameTable(
                name: "WorkersRanks",
                newName: "WorkerRanks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkerRanks",
                table: "WorkerRanks",
                columns: new[] { "WorkerId", "Rank" });

            migrationBuilder.CreateTable(
                name: "Bonuses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    BonusPercentage = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HourlyRates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlyRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MonthActualWorkHours",
                columns: table => new
                {
                    WorkerId = table.Column<string>(type: "TEXT", nullable: false),
                    Hours = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthActualWorkHours", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_MonthActualWorkHours_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonthMinimunWorkHours",
                columns: table => new
                {
                    WorkerId = table.Column<string>(type: "TEXT", nullable: false),
                    Hours = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthMinimunWorkHours", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_MonthMinimunWorkHours_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_WorkerRanks_Workers_WorkerId",
                table: "WorkerRanks",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkerRanks_Workers_WorkerId",
                table: "WorkerRanks");

            migrationBuilder.DropTable(
                name: "Bonuses");

            migrationBuilder.DropTable(
                name: "HourlyRates");

            migrationBuilder.DropTable(
                name: "MonthActualWorkHours");

            migrationBuilder.DropTable(
                name: "MonthMinimunWorkHours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkerRanks",
                table: "WorkerRanks");

            migrationBuilder.RenameTable(
                name: "WorkerRanks",
                newName: "WorkersRanks");

            migrationBuilder.AddColumn<float>(
                name: "HourlyWage",
                table: "Workers",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkersRanks",
                table: "WorkersRanks",
                columns: new[] { "WorkerId", "Rank" });

            migrationBuilder.CreateTable(
                name: "MinimunMonthHours",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Hours = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MinimunMonthHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    PriceName = table.Column<string>(type: "TEXT", nullable: false),
                    PriceValue = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.PriceName);
                });

            migrationBuilder.CreateTable(
                name: "WorkTimes",
                columns: table => new
                {
                    WorkerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Hours = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkTimes", x => x.WorkerId);
                    table.ForeignKey(
                        name: "FK_WorkTimes_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RankBonuses",
                columns: table => new
                {
                    Rank = table.Column<string>(type: "TEXT", nullable: false),
                    BonusPercentages = table.Column<float>(type: "REAL", nullable: false),
                    PriceName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankBonuses", x => x.Rank);
                    table.ForeignKey(
                        name: "FK_RankBonuses_Prices_PriceName",
                        column: x => x.PriceName,
                        principalTable: "Prices",
                        principalColumn: "PriceName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RankBonuses_PriceName",
                table: "RankBonuses",
                column: "PriceName");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkersRanks_Workers_WorkerId",
                table: "WorkersRanks",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

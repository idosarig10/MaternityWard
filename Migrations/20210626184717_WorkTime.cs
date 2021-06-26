using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class WorkTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkTimes",
                columns: table => new
                {
                    WorkerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Hours = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_WorkTimes_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkTimes_WorkerId",
                table: "WorkTimes",
                column: "WorkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkTimes");
        }
    }
}

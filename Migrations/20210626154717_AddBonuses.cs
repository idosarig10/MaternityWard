using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class AddBonuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Worker",
                table: "Worker");

            migrationBuilder.RenameTable(
                name: "Worker",
                newName: "Workers");

            migrationBuilder.AddColumn<string>(
                name: "BonusBonousName",
                table: "Prices",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Workers",
                table: "Workers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Bonuses",
                columns: table => new
                {
                    BonousName = table.Column<string>(type: "TEXT", nullable: false),
                    PriceName = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bonuses", x => x.BonousName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prices_BonusBonousName",
                table: "Prices",
                column: "BonusBonousName");

            migrationBuilder.AddForeignKey(
                name: "FK_Prices_Bonuses_BonusBonousName",
                table: "Prices",
                column: "BonusBonousName",
                principalTable: "Bonuses",
                principalColumn: "BonousName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Bonuses_BonusBonousName",
                table: "Prices");

            migrationBuilder.DropTable(
                name: "Bonuses");

            migrationBuilder.DropIndex(
                name: "IX_Prices_BonusBonousName",
                table: "Prices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Workers",
                table: "Workers");

            migrationBuilder.DropColumn(
                name: "BonusBonousName",
                table: "Prices");

            migrationBuilder.RenameTable(
                name: "Workers",
                newName: "Worker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Worker",
                table: "Worker",
                column: "Id");
        }
    }
}

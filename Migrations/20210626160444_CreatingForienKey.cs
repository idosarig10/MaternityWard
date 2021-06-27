using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class CreatingForienKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prices_Bonuses_BonusBonousName",
                table: "Prices");

            migrationBuilder.DropIndex(
                name: "IX_Prices_BonusBonousName",
                table: "Prices");

            migrationBuilder.DropColumn(
                name: "BonusBonousName",
                table: "Prices");

            migrationBuilder.AddColumn<string>(
                name: "PriceName1",
                table: "Bonuses",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bonuses_PriceName1",
                table: "Bonuses",
                column: "PriceName1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonuses_Prices_PriceName1",
                table: "Bonuses",
                column: "PriceName1",
                principalTable: "Prices",
                principalColumn: "PriceName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonuses_Prices_PriceName1",
                table: "Bonuses");

            migrationBuilder.DropIndex(
                name: "IX_Bonuses_PriceName1",
                table: "Bonuses");

            migrationBuilder.DropColumn(
                name: "PriceName1",
                table: "Bonuses");

            migrationBuilder.AddColumn<string>(
                name: "BonusBonousName",
                table: "Prices",
                type: "TEXT",
                nullable: true);

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
    }
}

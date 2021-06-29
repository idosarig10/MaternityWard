using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class ChangeBonusName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BonousValuePrecent",
                table: "Bonuses",
                newName: "BonusPercentages");

            migrationBuilder.RenameColumn(
                name: "BonousName",
                table: "Bonuses",
                newName: "Rank");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BonusPercentages",
                table: "Bonuses",
                newName: "BonousValuePrecent");

            migrationBuilder.RenameColumn(
                name: "Rank",
                table: "Bonuses",
                newName: "BonousName");
        }
    }
}

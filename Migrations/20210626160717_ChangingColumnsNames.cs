using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class ChangingColumnsNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "PriceName",
                table: "Bonuses",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AddColumn<float>(
                name: "BonousValuePrecent",
                table: "Bonuses",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateIndex(
                name: "IX_Bonuses_PriceName",
                table: "Bonuses",
                column: "PriceName");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonuses_Prices_PriceName",
                table: "Bonuses",
                column: "PriceName",
                principalTable: "Prices",
                principalColumn: "PriceName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonuses_Prices_PriceName",
                table: "Bonuses");

            migrationBuilder.DropIndex(
                name: "IX_Bonuses_PriceName",
                table: "Bonuses");

            migrationBuilder.DropColumn(
                name: "BonousValuePrecent",
                table: "Bonuses");

            migrationBuilder.AlterColumn<float>(
                name: "PriceName",
                table: "Bonuses",
                type: "REAL",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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
    }
}

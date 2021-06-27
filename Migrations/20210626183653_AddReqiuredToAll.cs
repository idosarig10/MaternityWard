using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MaternityWard.Migrations
{
    public partial class AddReqiuredToAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bonuses_Prices_PriceName",
                table: "Bonuses");

            migrationBuilder.DropForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId",
                table: "MonthWorkHours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bonuses",
                table: "Bonuses");

            migrationBuilder.RenameTable(
                name: "Bonuses",
                newName: "RankBonuses");

            migrationBuilder.RenameIndex(
                name: "IX_Bonuses_PriceName",
                table: "RankBonuses",
                newName: "IX_RankBonuses_PriceName");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerType",
                table: "Workers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RankBonuses",
                table: "RankBonuses",
                column: "Rank");

            migrationBuilder.AddForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId",
                table: "MonthWorkHours",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RankBonuses_Prices_PriceName",
                table: "RankBonuses",
                column: "PriceName",
                principalTable: "Prices",
                principalColumn: "PriceName",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId",
                table: "MonthWorkHours");

            migrationBuilder.DropForeignKey(
                name: "FK_RankBonuses_Prices_PriceName",
                table: "RankBonuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RankBonuses",
                table: "RankBonuses");

            migrationBuilder.RenameTable(
                name: "RankBonuses",
                newName: "Bonuses");

            migrationBuilder.RenameIndex(
                name: "IX_RankBonuses_PriceName",
                table: "Bonuses",
                newName: "IX_Bonuses_PriceName");

            migrationBuilder.AlterColumn<string>(
                name: "WorkerType",
                table: "Workers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "MonthWorkHours",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bonuses",
                table: "Bonuses",
                column: "Rank");

            migrationBuilder.AddForeignKey(
                name: "FK_Bonuses_Prices_PriceName",
                table: "Bonuses",
                column: "PriceName",
                principalTable: "Prices",
                principalColumn: "PriceName",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonthWorkHours_Workers_WorkerId",
                table: "MonthWorkHours",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

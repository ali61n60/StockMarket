using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "stockSymbol",
                schema: "stock",
                table: "StocksInfo",
                newName: "symbolPersian");

            migrationBuilder.RenameColumn(
                name: "stockName",
                schema: "stock",
                table: "StocksInfo",
                newName: "symbolLatin");

            migrationBuilder.AddColumn<string>(
                name: "nameLatin",
                schema: "stock",
                table: "StocksInfo",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "namePersian",
                schema: "stock",
                table: "StocksInfo",
                maxLength: 150,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nameLatin",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.DropColumn(
                name: "namePersian",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.RenameColumn(
                name: "symbolPersian",
                schema: "stock",
                table: "StocksInfo",
                newName: "stockSymbol");

            migrationBuilder.RenameColumn(
                name: "symbolLatin",
                schema: "stock",
                table: "StocksInfo",
                newName: "stockName");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "boughtSymbolPricePerShare",
                schema: "stock",
                table: "StockExchange",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "soldSymbolPricePerShare",
                schema: "stock",
                table: "StockExchange",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "boughtSymbolPricePerShare",
                schema: "stock",
                table: "StockExchange");

            migrationBuilder.DropColumn(
                name: "soldSymbolPricePerShare",
                schema: "stock",
                table: "StockExchange");
        }
    }
}

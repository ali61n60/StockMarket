using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_StockName",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.AddForeignKey(
                name: "FK_Dividend_StockInfo",
                schema: "stock",
                table: "Dividend",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_StockInfo",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.AddForeignKey(
                name: "FK_Dividend_StockName",
                schema: "stock",
                table: "Dividend",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

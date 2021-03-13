using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StockTrading",
                schema: "stock",
                table: "StockTrading");

            migrationBuilder.RenameTable(
                name: "StockTrading",
                schema: "stock",
                newName: "Trades",
                newSchema: "stock");

            migrationBuilder.RenameIndex(
                name: "IX_StockTrading_symbolId",
                schema: "stock",
                table: "Trades",
                newName: "IX_Trades_symbolId");

            migrationBuilder.RenameIndex(
                name: "IX_StockTrading_shareholderId",
                schema: "stock",
                table: "Trades",
                newName: "IX_Trades_shareholderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trades",
                schema: "stock",
                table: "Trades",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Trades",
                schema: "stock",
                table: "Trades");

            migrationBuilder.RenameTable(
                name: "Trades",
                schema: "stock",
                newName: "StockTrading",
                newSchema: "stock");

            migrationBuilder.RenameIndex(
                name: "IX_Trades_symbolId",
                schema: "stock",
                table: "StockTrading",
                newName: "IX_StockTrading_symbolId");

            migrationBuilder.RenameIndex(
                name: "IX_Trades_shareholderId",
                schema: "stock",
                table: "StockTrading",
                newName: "IX_StockTrading_shareholderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockTrading",
                schema: "stock",
                table: "StockTrading",
                column: "id");
        }
    }
}

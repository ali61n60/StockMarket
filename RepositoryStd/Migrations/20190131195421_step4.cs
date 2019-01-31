using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CapitalIncrease_StocksName_stockId",
                schema: "stock",
                table: "CapitalIncrease");

            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_StockName",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeData_StocksName_stockId",
                schema: "stock",
                table: "TradeData");

            migrationBuilder.DropTable(
                name: "StocksName",
                schema: "stock");

            migrationBuilder.CreateTable(
                name: "StocksInfo",
                schema: "stock",
                columns: table => new
                {
                    stockId = table.Column<int>(nullable: false),
                    stockSymbol = table.Column<string>(maxLength: 150, nullable: false),
                    stockName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksInfo", x => x.stockId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CapitalIncrease_StocksInfo_stockId",
                schema: "stock",
                table: "CapitalIncrease",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dividend_StockName",
                schema: "stock",
                table: "Dividend",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeData_StocksInfo_stockId",
                schema: "stock",
                table: "TradeData",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CapitalIncrease_StocksInfo_stockId",
                schema: "stock",
                table: "CapitalIncrease");

            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_StockName",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeData_StocksInfo_stockId",
                schema: "stock",
                table: "TradeData");

            migrationBuilder.DropTable(
                name: "StocksInfo",
                schema: "stock");

            migrationBuilder.CreateTable(
                name: "StocksName",
                schema: "stock",
                columns: table => new
                {
                    stockId = table.Column<int>(nullable: false),
                    stockName = table.Column<string>(maxLength: 150, nullable: false),
                    stockSymbol = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksName", x => x.stockId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CapitalIncrease_StocksName_stockId",
                schema: "stock",
                table: "CapitalIncrease",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksName",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dividend_StockName",
                schema: "stock",
                table: "Dividend",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksName",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeData_StocksName_stockId",
                schema: "stock",
                table: "TradeData",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksName",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CapitalIncrease_StocksInfo_stockId",
                schema: "stock",
                table: "CapitalIncrease");

            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_StockInfo",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.DropForeignKey(
                name: "FK_StockListStockInfo_StocksInfo_stockInfoId",
                schema: "stock",
                table: "StockListStockInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTrading_StockInfo",
                schema: "stock",
                table: "StockTrading");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeData_StocksInfo_stockId",
                schema: "stock",
                table: "TradeData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StocksInfo",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.RenameTable(
                name: "StocksInfo",
                schema: "stock",
                newName: "Symbol",
                newSchema: "stock");

            migrationBuilder.RenameIndex(
                name: "IX_StocksInfo_groupId",
                schema: "stock",
                table: "Symbol",
                newName: "IX_Symbol_groupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Symbol",
                schema: "stock",
                table: "Symbol",
                column: "stockId");

            migrationBuilder.AddForeignKey(
                name: "FK_CapitalIncrease_Symbol_stockId",
                schema: "stock",
                table: "CapitalIncrease",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dividend_Symbol_stockId",
                schema: "stock",
                table: "Dividend",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockListStockInfo_Symbol_stockInfoId",
                schema: "stock",
                table: "StockListStockInfo",
                column: "stockInfoId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockTrading_Symbol_stockId",
                schema: "stock",
                table: "StockTrading",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeData_Symbol_stockId",
                schema: "stock",
                table: "TradeData",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CapitalIncrease_Symbol_stockId",
                schema: "stock",
                table: "CapitalIncrease");

            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_Symbol_stockId",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.DropForeignKey(
                name: "FK_StockListStockInfo_Symbol_stockInfoId",
                schema: "stock",
                table: "StockListStockInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTrading_Symbol_stockId",
                schema: "stock",
                table: "StockTrading");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeData_Symbol_stockId",
                schema: "stock",
                table: "TradeData");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Symbol",
                schema: "stock",
                table: "Symbol");

            migrationBuilder.RenameTable(
                name: "Symbol",
                schema: "stock",
                newName: "StocksInfo",
                newSchema: "stock");

            migrationBuilder.RenameIndex(
                name: "IX_Symbol_groupId",
                schema: "stock",
                table: "StocksInfo",
                newName: "IX_StocksInfo_groupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StocksInfo",
                schema: "stock",
                table: "StocksInfo",
                column: "stockId");

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
                name: "FK_Dividend_StockInfo",
                schema: "stock",
                table: "Dividend",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockListStockInfo_StocksInfo_stockInfoId",
                schema: "stock",
                table: "StockListStockInfo",
                column: "stockInfoId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockTrading_StockInfo",
                schema: "stock",
                table: "StockTrading",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "StocksInfo",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Restrict);

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
    }
}

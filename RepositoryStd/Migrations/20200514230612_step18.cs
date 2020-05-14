using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_StockTrading_Symbol_stockId",
                schema: "stock",
                table: "StockTrading");

            migrationBuilder.DropForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "Symbol");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeData_Symbol_stockId",
                schema: "stock",
                table: "TradeData");

            migrationBuilder.RenameColumn(
                name: "stockId",
                schema: "stock",
                table: "TradeData",
                newName: "symbolId");

            migrationBuilder.RenameIndex(
                name: "IX_TradeData_stockId",
                schema: "stock",
                table: "TradeData",
                newName: "IX_TradeData_symbolId");

            migrationBuilder.RenameColumn(
                name: "stockId",
                schema: "stock",
                table: "Symbol",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "stockId",
                schema: "stock",
                table: "StockTrading",
                newName: "symbolId");

            migrationBuilder.RenameIndex(
                name: "IX_StockTrading_stockId",
                schema: "stock",
                table: "StockTrading",
                newName: "IX_StockTrading_symbolId");

            migrationBuilder.RenameColumn(
                name: "stockId",
                schema: "stock",
                table: "Dividend",
                newName: "symbolId");

            migrationBuilder.RenameIndex(
                name: "IX_Dividend_stockId",
                schema: "stock",
                table: "Dividend",
                newName: "IX_Dividend_symbolId");

            migrationBuilder.RenameColumn(
                name: "stockId",
                schema: "stock",
                table: "CapitalIncrease",
                newName: "symbolId");

            migrationBuilder.RenameIndex(
                name: "IX_CapitalIncrease_stockId",
                schema: "stock",
                table: "CapitalIncrease",
                newName: "IX_CapitalIncrease_symbolId");

            migrationBuilder.AddForeignKey(
                name: "FK_CapitalIncrease_Symbol_symbolId",
                schema: "stock",
                table: "CapitalIncrease",
                column: "symbolId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dividend_Symbol",
                schema: "stock",
                table: "Dividend",
                column: "symbolId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StockTrading_Symbol",
                schema: "stock",
                table: "StockTrading",
                column: "symbolId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Symbol_SymbolGroup",
                schema: "stock",
                table: "Symbol",
                column: "groupId",
                principalSchema: "stock",
                principalTable: "SymbolGroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TradeData_Symbol_symbolId",
                schema: "stock",
                table: "TradeData",
                column: "symbolId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CapitalIncrease_Symbol_symbolId",
                schema: "stock",
                table: "CapitalIncrease");

            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_Symbol",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.DropForeignKey(
                name: "FK_StockTrading_Symbol",
                schema: "stock",
                table: "StockTrading");

            migrationBuilder.DropForeignKey(
                name: "FK_Symbol_SymbolGroup",
                schema: "stock",
                table: "Symbol");

            migrationBuilder.DropForeignKey(
                name: "FK_TradeData_Symbol_symbolId",
                schema: "stock",
                table: "TradeData");

            migrationBuilder.RenameColumn(
                name: "symbolId",
                schema: "stock",
                table: "TradeData",
                newName: "stockId");

            migrationBuilder.RenameIndex(
                name: "IX_TradeData_symbolId",
                schema: "stock",
                table: "TradeData",
                newName: "IX_TradeData_stockId");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "stock",
                table: "Symbol",
                newName: "stockId");

            migrationBuilder.RenameColumn(
                name: "symbolId",
                schema: "stock",
                table: "StockTrading",
                newName: "stockId");

            migrationBuilder.RenameIndex(
                name: "IX_StockTrading_symbolId",
                schema: "stock",
                table: "StockTrading",
                newName: "IX_StockTrading_stockId");

            migrationBuilder.RenameColumn(
                name: "symbolId",
                schema: "stock",
                table: "Dividend",
                newName: "stockId");

            migrationBuilder.RenameIndex(
                name: "IX_Dividend_symbolId",
                schema: "stock",
                table: "Dividend",
                newName: "IX_Dividend_stockId");

            migrationBuilder.RenameColumn(
                name: "symbolId",
                schema: "stock",
                table: "CapitalIncrease",
                newName: "stockId");

            migrationBuilder.RenameIndex(
                name: "IX_CapitalIncrease_symbolId",
                schema: "stock",
                table: "CapitalIncrease",
                newName: "IX_CapitalIncrease_stockId");

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
                name: "FK_StockTrading_Symbol_stockId",
                schema: "stock",
                table: "StockTrading",
                column: "stockId",
                principalSchema: "stock",
                principalTable: "Symbol",
                principalColumn: "stockId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "Symbol",
                column: "groupId",
                principalSchema: "stock",
                principalTable: "SymbolGroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

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
    }
}

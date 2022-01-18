using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_StockInfo",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.CreateIndex(
                name: "IX_StocksInfo_groupId",
                schema: "stock",
                table: "StocksInfo",
                column: "groupId");

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
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "StocksInfo",
                column: "groupId",
                principalSchema: "stock",
                principalTable: "StockGroup",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dividend_StockInfo",
                schema: "stock",
                table: "Dividend");

            migrationBuilder.DropForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.DropIndex(
                name: "IX_StocksInfo_groupId",
                schema: "stock",
                table: "StocksInfo");

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
    }
}

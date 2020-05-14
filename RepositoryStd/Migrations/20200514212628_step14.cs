using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StocksInfo_StockGroup_groupId",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StockGroup",
                schema: "stock",
                table: "StockGroup");

            migrationBuilder.RenameTable(
                name: "StockGroup",
                schema: "stock",
                newName: "SymbolGroup",
                newSchema: "stock");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SymbolGroup",
                schema: "stock",
                table: "SymbolGroup",
                column: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_StocksInfo_SymbolGroup_groupId",
                schema: "stock",
                table: "StocksInfo",
                column: "groupId",
                principalSchema: "stock",
                principalTable: "SymbolGroup",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StocksInfo_SymbolGroup_groupId",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SymbolGroup",
                schema: "stock",
                table: "SymbolGroup");

            migrationBuilder.RenameTable(
                name: "SymbolGroup",
                schema: "stock",
                newName: "StockGroup",
                newSchema: "stock");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockGroup",
                schema: "stock",
                table: "StockGroup",
                column: "groupId");

            migrationBuilder.AddForeignKey(
                name: "FK_StocksInfo_StockGroup_groupId",
                schema: "stock",
                table: "StocksInfo",
                column: "groupId",
                principalSchema: "stock",
                principalTable: "StockGroup",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

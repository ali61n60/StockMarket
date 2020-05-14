using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StocksInfo_SymbolGroup_groupId",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.RenameColumn(
                name: "groupId",
                schema: "stock",
                table: "SymbolGroup",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "StocksInfo",
                column: "groupId",
                principalSchema: "stock",
                principalTable: "SymbolGroup",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.RenameColumn(
                name: "id",
                schema: "stock",
                table: "SymbolGroup",
                newName: "groupId");

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
    }
}

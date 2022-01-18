using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "StocksInfo");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StocksInfo_StockGroup_groupId",
                schema: "stock",
                table: "StocksInfo");

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
    }
}

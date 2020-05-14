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

            migrationBuilder.DropTable(
                name: "StockGroup",
                schema: "stock");

            migrationBuilder.CreateTable(
                name: "SymbolGroup",
                schema: "stock",
                columns: table => new
                {
                    groupId = table.Column<int>(nullable: false),
                    groupName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymbolGroup", x => x.groupId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "StocksInfo",
                column: "groupId",
                principalSchema: "stock",
                principalTable: "SymbolGroup",
                principalColumn: "groupId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StockInfo_StockGroup",
                schema: "stock",
                table: "StocksInfo");

            migrationBuilder.DropTable(
                name: "SymbolGroup",
                schema: "stock");

            migrationBuilder.CreateTable(
                name: "StockGroup",
                schema: "stock",
                columns: table => new
                {
                    groupId = table.Column<int>(nullable: false),
                    groupName = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockGroup", x => x.groupId);
                });

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

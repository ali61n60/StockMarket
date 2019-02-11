using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockList",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockList", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "StockListStockInfo",
                schema: "stock",
                columns: table => new
                {
                    listId = table.Column<int>(nullable: false),
                    stockInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockListStockInfo", x => new { x.listId, x.stockInfoId });
                    table.ForeignKey(
                        name: "FK_StockListStockInfo_StockList_listId",
                        column: x => x.listId,
                        principalSchema: "stock",
                        principalTable: "StockList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockListStockInfo_StocksInfo_stockInfoId",
                        column: x => x.stockInfoId,
                        principalSchema: "stock",
                        principalTable: "StocksInfo",
                        principalColumn: "stockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockListStockInfo_stockInfoId",
                schema: "stock",
                table: "StockListStockInfo",
                column: "stockInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockListStockInfo",
                schema: "stock");

            migrationBuilder.DropTable(
                name: "StockList",
                schema: "stock");
        }
    }
}

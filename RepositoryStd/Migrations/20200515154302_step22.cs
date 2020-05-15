using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockListStockInfo",
                schema: "stock");

            migrationBuilder.DropTable(
                name: "StockList",
                schema: "stock");

            migrationBuilder.CreateTable(
                name: "CustomGroup",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customGroupMember",
                schema: "stock",
                columns: table => new
                {
                    groupId = table.Column<int>(nullable: false),
                    symbolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customGroupMember", x => new { x.groupId, x.symbolId });
                    table.ForeignKey(
                        name: "FK_customGroupMember_CustomGroup_groupId",
                        column: x => x.groupId,
                        principalSchema: "stock",
                        principalTable: "CustomGroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_customGroupMember_Symbol_symbolId",
                        column: x => x.symbolId,
                        principalSchema: "stock",
                        principalTable: "Symbol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customGroupMember_symbolId",
                schema: "stock",
                table: "customGroupMember",
                column: "symbolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customGroupMember",
                schema: "stock");

            migrationBuilder.DropTable(
                name: "CustomGroup",
                schema: "stock");

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
                        name: "FK_StockListStockInfo_Symbol_stockInfoId",
                        column: x => x.stockInfoId,
                        principalSchema: "stock",
                        principalTable: "Symbol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockListStockInfo_stockInfoId",
                schema: "stock",
                table: "StockListStockInfo",
                column: "stockInfoId");
        }
    }
}

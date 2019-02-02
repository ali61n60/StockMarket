using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shareholder",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shareholder", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "StockTrading",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    shareholderId = table.Column<int>(nullable: false),
                    stockId = table.Column<int>(nullable: false),
                    tradeType = table.Column<int>(nullable: false),
                    volume = table.Column<int>(nullable: false),
                    pricePerShare = table.Column<double>(nullable: false),
                    totalPrice = table.Column<double>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTrading", x => x.id);
                    table.ForeignKey(
                        name: "FK_StockTrading_Shareholder",
                        column: x => x.shareholderId,
                        principalSchema: "stock",
                        principalTable: "Shareholder",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTrading_StockInfo",
                        column: x => x.stockId,
                        principalSchema: "stock",
                        principalTable: "StocksInfo",
                        principalColumn: "stockId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockTrading_shareholderId",
                schema: "stock",
                table: "StockTrading",
                column: "shareholderId");

            migrationBuilder.CreateIndex(
                name: "IX_StockTrading_stockId",
                schema: "stock",
                table: "StockTrading",
                column: "stockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockTrading",
                schema: "stock");

            migrationBuilder.DropTable(
                name: "Shareholder",
                schema: "stock");
        }
    }
}

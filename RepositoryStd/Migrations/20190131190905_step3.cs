using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CapitalIncrease",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    stockId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    percent = table.Column<double>(nullable: false),
                    cashPercent = table.Column<double>(nullable: false),
                    savingPercent = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CapitalIncrease", x => x.id);
                    table.ForeignKey(
                        name: "FK_CapitalIncrease_StocksName_stockId",
                        column: x => x.stockId,
                        principalSchema: "stock",
                        principalTable: "StocksName",
                        principalColumn: "stockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dividend",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    stockId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    value = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dividend", x => x.id);
                    table.ForeignKey(
                        name: "FK_Dividend_StockName",
                        column: x => x.stockId,
                        principalSchema: "stock",
                        principalTable: "StocksName",
                        principalColumn: "stockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TradeData",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    stockId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    volume = table.Column<int>(nullable: false),
                    open = table.Column<double>(nullable: false),
                    close = table.Column<double>(nullable: false),
                    min = table.Column<double>(nullable: false),
                    max = table.Column<double>(nullable: false),
                    final = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeData", x => x.id);
                    table.ForeignKey(
                        name: "FK_TradeData_StocksName_stockId",
                        column: x => x.stockId,
                        principalSchema: "stock",
                        principalTable: "StocksName",
                        principalColumn: "stockId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CapitalIncrease_stockId",
                schema: "stock",
                table: "CapitalIncrease",
                column: "stockId");

            migrationBuilder.CreateIndex(
                name: "IX_Dividend_stockId",
                schema: "stock",
                table: "Dividend",
                column: "stockId");

            migrationBuilder.CreateIndex(
                name: "IX_TradeData_stockId",
                schema: "stock",
                table: "TradeData",
                column: "stockId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CapitalIncrease",
                schema: "stock");

            migrationBuilder.DropTable(
                name: "Dividend",
                schema: "stock");

            migrationBuilder.DropTable(
                name: "TradeData",
                schema: "stock");
        }
    }
}

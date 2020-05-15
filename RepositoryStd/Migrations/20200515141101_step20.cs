using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StockExchange",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    exchangeDate = table.Column<DateTime>(nullable: false),
                    soldSymbolId = table.Column<int>(nullable: false),
                    soldSymbolVolume = table.Column<int>(nullable: false),
                    boughtSymbolId = table.Column<int>(nullable: false),
                    boughtSymbolVolume = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockExchange", x => x.id);
                    table.ForeignKey(
                        name: "FK_StockExchageBought_Symbol",
                        column: x => x.boughtSymbolId,
                        principalSchema: "stock",
                        principalTable: "Symbol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockExchageSold_Symbol",
                        column: x => x.soldSymbolId,
                        principalSchema: "stock",
                        principalTable: "Symbol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockExchange_boughtSymbolId",
                schema: "stock",
                table: "StockExchange",
                column: "boughtSymbolId");

            migrationBuilder.CreateIndex(
                name: "IX_StockExchange_soldSymbolId",
                schema: "stock",
                table: "StockExchange",
                column: "soldSymbolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockExchange",
                schema: "stock");
        }
    }
}

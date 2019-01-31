using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numberOfDeals",
                schema: "stock",
                table: "TradeData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "value",
                schema: "stock",
                table: "TradeData",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberOfDeals",
                schema: "stock",
                table: "TradeData");

            migrationBuilder.DropColumn(
                name: "value",
                schema: "stock",
                table: "TradeData");
        }
    }
}

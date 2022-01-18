using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "groupId",
                schema: "stock",
                table: "StocksInfo",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockGroup",
                schema: "stock");

            migrationBuilder.DropColumn(
                name: "groupId",
                schema: "stock",
                table: "StocksInfo");
        }
    }
}










using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StockExchange",
                schema: "stock",
                table: "StockExchange");

            migrationBuilder.DropColumn(
                name: "id",
                schema: "stock",
                table: "StockExchange");

            migrationBuilder.AddColumn<int>(
                name: "id2",
                schema: "stock",
                table: "StockExchange",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockExchange",
                schema: "stock",
                table: "StockExchange",
                column: "id2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StockExchange",
                schema: "stock",
                table: "StockExchange");

            migrationBuilder.DropColumn(
                name: "id2",
                schema: "stock",
                table: "StockExchange");

            migrationBuilder.AddColumn<int>(
                name: "id",
                schema: "stock",
                table: "StockExchange",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StockExchange",
                schema: "stock",
                table: "StockExchange",
                column: "id");
        }
    }
}

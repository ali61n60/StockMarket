using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LiveDataUrl",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    url = table.Column<string>(maxLength: 500, nullable: false),
                    symbolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveDataUrl", x => x.id);
                    table.ForeignKey(
                        name: "FK_LiveDataUrl_Symbol_symbolId",
                        column: x => x.symbolId,
                        principalSchema: "stock",
                        principalTable: "Symbol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LiveDataUrl_symbolId",
                schema: "stock",
                table: "LiveDataUrl",
                column: "symbolId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LiveDataUrl",
                schema: "stock");
        }
    }
}

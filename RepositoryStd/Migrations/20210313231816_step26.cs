using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryStd.Migrations
{
    public partial class step26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductGroup",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    nameLatin = table.Column<string>(maxLength: 150, nullable: false),
                    namePersian = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGroup", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "stock",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    nameLatin = table.Column<string>(maxLength: 150, nullable: false),
                    namePersian = table.Column<string>(maxLength: 150, nullable: false),
                    groupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.id);
                    table.ForeignKey(
                        name: "FK_Product_ProductGroup",
                        column: x => x.groupId,
                        principalSchema: "stock",
                        principalTable: "ProductGroup",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_groupId",
                schema: "stock",
                table: "Product",
                column: "groupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product",
                schema: "stock");

            migrationBuilder.DropTable(
                name: "ProductGroup",
                schema: "stock");
        }
    }
}

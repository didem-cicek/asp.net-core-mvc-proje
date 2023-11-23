using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class DeleteCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_PageCategories_PageCategoryId",
                table: "Pages");

            migrationBuilder.DropTable(
                name: "PageCategories");

            migrationBuilder.DropIndex(
                name: "IX_Pages_PageCategoryId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "PageCategoryId",
                table: "Pages");

            migrationBuilder.AddColumn<string>(
                name: "LayoutName",
                table: "Pages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LayoutName",
                table: "Pages");

            migrationBuilder.AddColumn<int>(
                name: "PageCategoryId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PageCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_PageCategoryId",
                table: "Pages",
                column: "PageCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_PageCategories_PageCategoryId",
                table: "Pages",
                column: "PageCategoryId",
                principalTable: "PageCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

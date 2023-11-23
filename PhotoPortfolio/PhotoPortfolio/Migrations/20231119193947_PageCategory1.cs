using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class PageCategory1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_PageCategory_PageCategoryId",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PageCategory",
                table: "PageCategory");

            migrationBuilder.RenameTable(
                name: "PageCategory",
                newName: "PageCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PageCategories",
                table: "PageCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_PageCategories_PageCategoryId",
                table: "Pages",
                column: "PageCategoryId",
                principalTable: "PageCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_PageCategories_PageCategoryId",
                table: "Pages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PageCategories",
                table: "PageCategories");

            migrationBuilder.RenameTable(
                name: "PageCategories",
                newName: "PageCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PageCategory",
                table: "PageCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_PageCategory_PageCategoryId",
                table: "Pages",
                column: "PageCategoryId",
                principalTable: "PageCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

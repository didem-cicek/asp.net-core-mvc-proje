using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class PageCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PageCategoryId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PageCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_PageCategoryId",
                table: "Pages",
                column: "PageCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_PageCategory_PageCategoryId",
                table: "Pages",
                column: "PageCategoryId",
                principalTable: "PageCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_PageCategory_PageCategoryId",
                table: "Pages");

            migrationBuilder.DropTable(
                name: "PageCategory");

            migrationBuilder.DropIndex(
                name: "IX_Pages_PageCategoryId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "PageCategoryId",
                table: "Pages");
        }
    }
}

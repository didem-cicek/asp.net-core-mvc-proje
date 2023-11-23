using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class UserName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Pages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_AppUserId1",
                table: "Pages",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_AspNetUsers_AppUserId1",
                table: "Pages",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_AspNetUsers_AppUserId1",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_AppUserId1",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Pages");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhotoPortfolio.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Abouts_AboutId",
                table: "Pages");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Contacts_ContactId",
                table: "Pages");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_HomePages_HomePageId",
                table: "Pages");

            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Services_ServiceId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_AboutId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ContactId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_HomePageId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_ServiceId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "HomePageId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "ServiceId",
                table: "Pages");

            migrationBuilder.AddColumn<int>(
                name: "PagesId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagesId",
                table: "HomePages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagesId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PagesId",
                table: "Abouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_PagesId",
                table: "Services",
                column: "PagesId");

            migrationBuilder.CreateIndex(
                name: "IX_HomePages_PagesId",
                table: "HomePages",
                column: "PagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_PagesId",
                table: "Contacts",
                column: "PagesId");

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_PagesId",
                table: "Abouts",
                column: "PagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Abouts_Pages_PagesId",
                table: "Abouts",
                column: "PagesId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_Pages_PagesId",
                table: "Contacts",
                column: "PagesId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomePages_Pages_PagesId",
                table: "HomePages",
                column: "PagesId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Pages_PagesId",
                table: "Services",
                column: "PagesId",
                principalTable: "Pages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Abouts_Pages_PagesId",
                table: "Abouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_Pages_PagesId",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_HomePages_Pages_PagesId",
                table: "HomePages");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_Pages_PagesId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_PagesId",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_HomePages_PagesId",
                table: "HomePages");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_PagesId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Abouts_PagesId",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "PagesId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PagesId",
                table: "HomePages");

            migrationBuilder.DropColumn(
                name: "PagesId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "PagesId",
                table: "Abouts");

            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HomePageId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServiceId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_AboutId",
                table: "Pages",
                column: "AboutId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ContactId",
                table: "Pages",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_HomePageId",
                table: "Pages",
                column: "HomePageId");

            migrationBuilder.CreateIndex(
                name: "IX_Pages_ServiceId",
                table: "Pages",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Abouts_AboutId",
                table: "Pages",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Contacts_ContactId",
                table: "Pages",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_HomePages_HomePageId",
                table: "Pages",
                column: "HomePageId",
                principalTable: "HomePages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Services_ServiceId",
                table: "Pages",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

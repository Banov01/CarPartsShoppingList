using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsShoppingList.Infrastructure.Migrations
{
    public partial class ApplicationUserIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "shopping_list",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_shopping_list_ApplicationUserId",
                table: "shopping_list",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_shopping_list_AspNetUsers_ApplicationUserId",
                table: "shopping_list",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopping_list_AspNetUsers_ApplicationUserId",
                table: "shopping_list");

            migrationBuilder.DropIndex(
                name: "IX_shopping_list_ApplicationUserId",
                table: "shopping_list");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "shopping_list");
        }
    }
}

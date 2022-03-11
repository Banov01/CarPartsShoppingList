using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsShoppingList.Infrastructure.Migrations
{
    public partial class BaseModelIsCheckedChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "transmission",
                newName: "IsChecked");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "suspensions",
                newName: "IsChecked");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "shopping_list_items",
                newName: "IsChecked");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "shopping_list",
                newName: "IsChecked");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "engines",
                newName: "IsChecked");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "transmission",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "suspensions",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "shopping_list_items",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "shopping_list",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "engines",
                newName: "IsActive");
        }
    }
}

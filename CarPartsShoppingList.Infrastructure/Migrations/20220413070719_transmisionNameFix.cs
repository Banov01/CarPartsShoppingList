using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsShoppingList.Infrastructure.Migrations
{
    public partial class transmisionNameFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopping_list_items_transmission_TransmissionId",
                table: "shopping_list_items");

            migrationBuilder.RenameColumn(
                name: "TransmissionId",
                table: "shopping_list_items",
                newName: "TransmisionId");

            migrationBuilder.RenameIndex(
                name: "IX_shopping_list_items_TransmissionId",
                table: "shopping_list_items",
                newName: "IX_shopping_list_items_TransmisionId");

            migrationBuilder.AddForeignKey(
                name: "FK_shopping_list_items_transmission_TransmisionId",
                table: "shopping_list_items",
                column: "TransmisionId",
                principalTable: "transmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shopping_list_items_transmission_TransmisionId",
                table: "shopping_list_items");

            migrationBuilder.RenameColumn(
                name: "TransmisionId",
                table: "shopping_list_items",
                newName: "TransmissionId");

            migrationBuilder.RenameIndex(
                name: "IX_shopping_list_items_TransmisionId",
                table: "shopping_list_items",
                newName: "IX_shopping_list_items_TransmissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_shopping_list_items_transmission_TransmissionId",
                table: "shopping_list_items",
                column: "TransmissionId",
                principalTable: "transmission",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

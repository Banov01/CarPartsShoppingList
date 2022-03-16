using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarPartsShoppingList.Infrastructure.Migrations
{
    public partial class EngineCategoryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EngineCategory",
                table: "engines",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EngineCategory",
                table: "engines");
        }
    }
}

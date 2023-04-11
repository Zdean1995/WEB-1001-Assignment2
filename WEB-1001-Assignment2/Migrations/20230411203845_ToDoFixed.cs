using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WEB_1001_Assignment2.Migrations
{
    public partial class ToDoFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Todo",
                table: "ToDos",
                newName: "TodoText");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TodoText",
                table: "ToDos",
                newName: "Todo");
        }
    }
}

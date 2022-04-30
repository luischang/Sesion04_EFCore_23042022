using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sesion04_ConsoleEF.CodeFirst.Migrations
{
    public partial class AddattributeAgeinPlayerv2ultramejorada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Player");
        }
    }
}

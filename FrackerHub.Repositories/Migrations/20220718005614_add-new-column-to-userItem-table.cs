using Microsoft.EntityFrameworkCore.Migrations;

namespace FrackerHub.Repositories.Migrations
{
    public partial class addnewcolumntouserItemtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "UserItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "UserItems");
        }
    }
}

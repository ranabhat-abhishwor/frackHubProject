using Microsoft.EntityFrameworkCore.Migrations;

namespace FrackerHub.Repositories.Migrations
{
    public partial class update_user_table_columns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vooller",
                table: "AspNetUsers",
                newName: "DateOfBirth");

            migrationBuilder.AddColumn<string>(
                name: "BRP_No",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BRP_No",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "AspNetUsers",
                newName: "Vooller");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace FrackerHub.Repositories.Migrations
{
    public partial class Correctiontouserlogincolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserItems_AspNetUsers_UserLoginId",
                table: "UserItems");

            migrationBuilder.DropIndex(
                name: "IX_UserItems_UserLoginId",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "UserLoginId",
                table: "UserItems");

            migrationBuilder.AddColumn<string>(
                name: "UserLogin",
                table: "UserItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserLogin",
                table: "UserItems");

            migrationBuilder.AddColumn<int>(
                name: "UserLoginId",
                table: "UserItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserItems_UserLoginId",
                table: "UserItems",
                column: "UserLoginId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserItems_AspNetUsers_UserLoginId",
                table: "UserItems",
                column: "UserLoginId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

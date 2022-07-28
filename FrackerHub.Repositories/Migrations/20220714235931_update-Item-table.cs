using Microsoft.EntityFrameworkCore.Migrations;

namespace FrackerHub.Repositories.Migrations
{
    public partial class updateItemtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Category_CategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemType_itemTypeId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemType",
                table: "ItemType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "ItemType",
                newName: "ItemTypes");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddColumn<string>(
                name: "userEmail",
                table: "Items",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categories_CategoryId",
                table: "Items",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemTypes_itemTypeId",
                table: "Items",
                column: "itemTypeId",
                principalTable: "ItemTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categories_CategoryId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemTypes_itemTypeId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemTypes",
                table: "ItemTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "userEmail",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "ItemTypes",
                newName: "ItemType");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemType",
                table: "ItemType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Category_CategoryId",
                table: "Items",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemType_itemTypeId",
                table: "Items",
                column: "itemTypeId",
                principalTable: "ItemType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

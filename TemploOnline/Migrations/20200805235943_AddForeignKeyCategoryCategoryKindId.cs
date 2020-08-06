using Microsoft.EntityFrameworkCore.Migrations;

namespace TemploOnline.Migrations
{
    public partial class AddForeignKeyCategoryCategoryKindId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryKindId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryKindId",
                table: "Categories",
                column: "CategoryKindId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_CategoryKinds_CategoryKindId",
                table: "Categories",
                column: "CategoryKindId",
                principalTable: "CategoryKinds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryKinds_CategoryKindId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryKindId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryKindId",
                table: "Categories");
        }
    }
}

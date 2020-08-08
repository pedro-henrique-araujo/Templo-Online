using Microsoft.EntityFrameworkCore.Migrations;

namespace TemploOnline.Migrations
{
    public partial class DropTableCategoryKinds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_CategoryKinds_CategoryKindId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryKinds");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryKindId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryKindId",
                table: "Categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryKindId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryKinds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryKinds", x => x.Id);
                });

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
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TemploOnline.Migrations
{
    public partial class CreateTableClassrooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_TextBooks_TextBookId",
                table: "Lessons");

            migrationBuilder.RenameColumn(
                name: "TextBookId",
                table: "Lessons",
                newName: "TextbookId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_TextBookId",
                table: "Lessons",
                newName: "IX_Lessons_TextbookId");

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_TextBooks_TextbookId",
                table: "Lessons",
                column: "TextbookId",
                principalTable: "TextBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_TextBooks_TextbookId",
                table: "Lessons");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.RenameColumn(
                name: "TextbookId",
                table: "Lessons",
                newName: "TextBookId");

            migrationBuilder.RenameIndex(
                name: "IX_Lessons_TextbookId",
                table: "Lessons",
                newName: "IX_Lessons_TextBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_TextBooks_TextBookId",
                table: "Lessons",
                column: "TextBookId",
                principalTable: "TextBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

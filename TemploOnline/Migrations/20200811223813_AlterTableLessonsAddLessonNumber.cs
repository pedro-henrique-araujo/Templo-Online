using Microsoft.EntityFrameworkCore.Migrations;

namespace TemploOnline.Migrations
{
    public partial class AlterTableLessonsAddLessonNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LessonNumber",
                table: "Lessons",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LessonNumber",
                table: "Lessons");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TemploOnline.Migrations
{
    public partial class AlterTableClassroomAddCoverUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverUrl",
                table: "Classrooms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverUrl",
                table: "Classrooms");
        }
    }
}

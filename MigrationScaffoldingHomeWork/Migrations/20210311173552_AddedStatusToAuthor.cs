using Microsoft.EntityFrameworkCore.Migrations;

namespace MigrationScaffoldingHomeWork.Migrations
{
    public partial class AddedStatusToAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Author");
        }
    }
}

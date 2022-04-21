using Microsoft.EntityFrameworkCore.Migrations;

namespace BookDotNetCore.DAL.Migrations
{
    public partial class addednewcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookCategory",
                table: "bookDetails",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookCategory",
                table: "bookDetails");
        }
    }
}

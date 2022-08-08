using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLTE.MVC.Migrations
{
    public partial class AddAge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "tblemployees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "tblemployees");
        }
    }
}

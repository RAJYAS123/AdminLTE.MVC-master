using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminLTE.MVC.Migrations
{
    public partial class alltable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblcountries",
                columns: table => new
                {
                    cid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblcountries", x => x.cid);
                });

            migrationBuilder.CreateTable(
                name: "tblemployees",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    gender = table.Column<int>(nullable: false),
                    country = table.Column<int>(nullable: false),
                    state = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblemployees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tblgenders",
                columns: table => new
                {
                    gid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblgenders", x => x.gid);
                });

            migrationBuilder.CreateTable(
                name: "tblstates",
                columns: table => new
                {
                    sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cid = table.Column<int>(nullable: false),
                    sname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblstates", x => x.sid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblcountries");

            migrationBuilder.DropTable(
                name: "tblemployees");

            migrationBuilder.DropTable(
                name: "tblgenders");

            migrationBuilder.DropTable(
                name: "tblstates");
        }
    }
}

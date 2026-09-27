using Microsoft.EntityFrameworkCore.Migrations;

namespace atssistem.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bilgi",
                table: "ilanlar",
                newName: "departman");

            migrationBuilder.AddColumn<string>(
                name: "calismasekli",
                table: "ilanlar",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "calismasekli",
                table: "ilanlar");

            migrationBuilder.RenameColumn(
                name: "departman",
                table: "ilanlar",
                newName: "bilgi");
        }
    }
}

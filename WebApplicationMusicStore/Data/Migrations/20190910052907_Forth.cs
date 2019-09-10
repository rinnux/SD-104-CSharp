using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationMusicStore.Data.Migrations
{
    public partial class Forth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "profilePic",
                table: "Customers",
                newName: "ProfilePic");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfilePic",
                table: "Customers",
                newName: "profilePic");
        }
    }
}

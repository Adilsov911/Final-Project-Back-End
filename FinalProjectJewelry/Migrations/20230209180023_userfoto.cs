using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProjectJewelry.Migrations
{
    public partial class userfoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilImg",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilImg",
                table: "AspNetUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PodTalk.Migrations
{
    public partial class AddSocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialMediaAddress",
                table: "SocialMedia");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SocialMediaAddress",
                table: "SocialMedia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

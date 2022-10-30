using Microsoft.EntityFrameworkCore.Migrations;

namespace WebMVC.Migrations
{
    public partial class addStatusJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "JobProfiles",
                type: "bit",
                nullable: false,
                defaultValue: true);
        }
    }
}

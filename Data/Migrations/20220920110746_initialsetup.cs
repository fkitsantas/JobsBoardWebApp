using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsBoardWebApp.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    JobLocation = table.Column<string>(nullable: true),
                    JobCompanyName = table.Column<string>(nullable: true),
                    JobSalary = table.Column<int>(nullable: false),
                    JobEmailAddress = table.Column<string>(nullable: true),
                    JobTelephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Job");
        }
    }
}

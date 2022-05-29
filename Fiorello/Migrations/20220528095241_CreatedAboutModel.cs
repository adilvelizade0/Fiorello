using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiorello.Migrations
{
    public partial class CreatedAboutModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true),
                    Advantage1 = table.Column<string>(nullable: true),
                    Advantage2 = table.Column<string>(nullable: true),
                    Advantage3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}

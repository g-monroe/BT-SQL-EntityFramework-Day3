using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkStartingPoint.Migrations
{
    public partial class InitialMirgration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");

            migrationBuilder.CreateTable(
                name: "Heros",
                columns: table => new
                {
                    SuperheroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SuperheroName = table.Column<string>(maxLength: 50, nullable: false),
                    SecretIdentity = table.Column<string>(maxLength: 50, nullable: false),
                    AgeAtOrigin = table.Column<int>(nullable: true),
                    YearOfAppearance = table.Column<int>(nullable: false),
                    IsAlien = table.Column<bool>(nullable: false),
                    OriginStory = table.Column<string>(maxLength: 50, nullable: false),
                    UniverseId = table.Column<int>(nullable: false),
                    Abilities = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heros", x => x.SuperheroId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heros");

            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    ToDoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Title = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.ToDoId);
                });
        }
    }
}

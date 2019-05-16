using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkStartingPoint.Migrations
{
    public partial class InitialMirgration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universes",
                table: "Universes");

            migrationBuilder.RenameTable(
                name: "Universes",
                newName: "Universess");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universess",
                table: "Universess",
                column: "UniverseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universess",
                table: "Universess");

            migrationBuilder.RenameTable(
                name: "Universess",
                newName: "Universes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universes",
                table: "Universes",
                column: "UniverseId");
        }
    }
}

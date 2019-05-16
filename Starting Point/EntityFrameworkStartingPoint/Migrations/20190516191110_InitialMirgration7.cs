using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkStartingPoint.Migrations
{
    public partial class InitialMirgration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Univers",
                table: "Univers");

            migrationBuilder.RenameTable(
                name: "Univers",
                newName: "Universes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universes",
                table: "Universes",
                column: "UniverseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universes",
                table: "Universes");

            migrationBuilder.RenameTable(
                name: "Universes",
                newName: "Univers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Univers",
                table: "Univers",
                column: "UniverseId");
        }
    }
}

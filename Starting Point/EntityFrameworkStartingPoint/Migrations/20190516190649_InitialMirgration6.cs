using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkStartingPoint.Migrations
{
    public partial class InitialMirgration6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universess",
                table: "Universess");

            migrationBuilder.RenameTable(
                name: "Universess",
                newName: "Univers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Univers",
                table: "Univers",
                column: "UniverseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Univers",
                table: "Univers");

            migrationBuilder.RenameTable(
                name: "Univers",
                newName: "Universess");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universess",
                table: "Universess",
                column: "UniverseId");
        }
    }
}

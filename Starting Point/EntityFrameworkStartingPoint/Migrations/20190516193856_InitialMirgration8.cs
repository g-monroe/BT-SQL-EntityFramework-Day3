using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkStartingPoint.Migrations
{
    public partial class InitialMirgration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Heros_UniverseId",
                table: "Heros",
                column: "UniverseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Heros_Universes_UniverseId",
                table: "Heros",
                column: "UniverseId",
                principalTable: "Universes",
                principalColumn: "UniverseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heros_Universes_UniverseId",
                table: "Heros");

            migrationBuilder.DropIndex(
                name: "IX_Heros_UniverseId",
                table: "Heros");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkStartingPoint.Migrations
{
    public partial class AddUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedUserId",
                table: "ToDos",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_AssignedUserId",
                table: "ToDos",
                column: "AssignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_AssignedUserId",
                table: "ToDos",
                column: "AssignedUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_AssignedUserId",
                table: "ToDos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_AssignedUserId",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "ToDos");
        }
    }
}

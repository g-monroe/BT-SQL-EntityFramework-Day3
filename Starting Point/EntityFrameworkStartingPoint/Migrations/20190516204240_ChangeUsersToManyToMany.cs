using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFrameworkStartingPoint.Migrations
{
    public partial class ChangeUsersToManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_AssignedUserId",
                table: "ToDos");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_AssignedUserId",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "ToDos");

            migrationBuilder.CreateTable(
                name: "ToDoAssignedUsers",
                columns: table => new
                {
                    ToDoAssignedUsersId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ToDoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDoAssignedUsers", x => x.ToDoAssignedUsersId);
                    table.ForeignKey(
                        name: "FK_ToDoAssignedUsers_ToDos_ToDoId",
                        column: x => x.ToDoId,
                        principalTable: "ToDos",
                        principalColumn: "ToDoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ToDoAssignedUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDoAssignedUsers_ToDoId",
                table: "ToDoAssignedUsers",
                column: "ToDoId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDoAssignedUsers_UserId",
                table: "ToDoAssignedUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDoAssignedUsers");

            migrationBuilder.AddColumn<int>(
                name: "AssignedUserId",
                table: "ToDos",
                nullable: true);

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
    }
}

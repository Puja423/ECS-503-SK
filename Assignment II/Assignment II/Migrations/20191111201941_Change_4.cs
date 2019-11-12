using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_II.Migrations
{
    public partial class Change_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_FriendWith_FriendWithId",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_FriendWithId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "FriendWithId",
                table: "Person");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "FriendWith",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FriendWith_PersonId",
                table: "FriendWith",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendWith_Person_PersonId",
                table: "FriendWith",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendWith_Person_PersonId",
                table: "FriendWith");

            migrationBuilder.DropIndex(
                name: "IX_FriendWith_PersonId",
                table: "FriendWith");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "FriendWith");

            migrationBuilder.AddColumn<int>(
                name: "FriendWithId",
                table: "Person",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_FriendWithId",
                table: "Person",
                column: "FriendWithId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_FriendWith_FriendWithId",
                table: "Person",
                column: "FriendWithId",
                principalTable: "FriendWith",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_II.Migrations
{
    public partial class Change_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "_Location",
                table: "Post",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Post__Location",
                table: "Post",
                column: "_Location");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Location__Location",
                table: "Post",
                column: "_Location",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Location__Location",
                table: "Post");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Post__Location",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "_Location",
                table: "Post");
        }
    }
}

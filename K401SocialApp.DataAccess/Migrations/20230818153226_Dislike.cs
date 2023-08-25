using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace K401SocialApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Dislike : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Reactions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_UserId",
                table: "Reactions",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reactions_AppUser_UserId",
                table: "Reactions",
                column: "UserId",
                principalTable: "AppUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reactions_AppUser_UserId",
                table: "Reactions");

            migrationBuilder.DropIndex(
                name: "IX_Reactions_UserId",
                table: "Reactions");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reactions");
        }
    }
}

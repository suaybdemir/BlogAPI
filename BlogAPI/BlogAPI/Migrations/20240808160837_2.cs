using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogAPI.Migrations
{
    public partial class _2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComment_Comments_CommentId",
                table: "SubComment");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "SubComment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SubComment_Comments_CommentId",
                table: "SubComment",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubComment_Comments_CommentId",
                table: "SubComment");

            migrationBuilder.AlterColumn<int>(
                name: "CommentId",
                table: "SubComment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SubComment_Comments_CommentId",
                table: "SubComment",
                column: "CommentId",
                principalTable: "Comments",
                principalColumn: "Id");
        }
    }
}

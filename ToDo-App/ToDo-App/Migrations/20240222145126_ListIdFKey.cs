using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDo_App.Migrations
{
    public partial class ListIdFKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ListId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ListId",
                table: "Tasks",
                column: "ListId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Lists_ListId",
                table: "Tasks",
                column: "ListId",
                principalTable: "Lists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Lists_ListId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ListId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ListId",
                table: "Tasks");
        }
    }
}

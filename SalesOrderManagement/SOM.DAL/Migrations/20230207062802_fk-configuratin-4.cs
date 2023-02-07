using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOM.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fkconfiguratin4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_OrderWindow_WindowId",
                table: "OrderWindow",
                column: "WindowId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderWindow_Window_WindowId",
                table: "OrderWindow",
                column: "WindowId",
                principalTable: "Window",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderWindow_Window_WindowId",
                table: "OrderWindow");

            migrationBuilder.DropIndex(
                name: "IX_OrderWindow_WindowId",
                table: "OrderWindow");
        }
    }
}

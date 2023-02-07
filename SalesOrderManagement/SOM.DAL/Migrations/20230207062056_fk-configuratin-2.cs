using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOM.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fkconfiguratin2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SubElement",
                table: "Window",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Window",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_WindowElement_ElementId",
                table: "WindowElement",
                column: "ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_WindowElement_WindowId",
                table: "WindowElement",
                column: "WindowId");

            migrationBuilder.AddForeignKey(
                name: "FK_WindowElement_Element_ElementId",
                table: "WindowElement",
                column: "ElementId",
                principalTable: "Element",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WindowElement_Window_WindowId",
                table: "WindowElement",
                column: "WindowId",
                principalTable: "Window",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WindowElement_Element_ElementId",
                table: "WindowElement");

            migrationBuilder.DropForeignKey(
                name: "FK_WindowElement_Window_WindowId",
                table: "WindowElement");

            migrationBuilder.DropIndex(
                name: "IX_WindowElement_ElementId",
                table: "WindowElement");

            migrationBuilder.DropIndex(
                name: "IX_WindowElement_WindowId",
                table: "WindowElement");

            migrationBuilder.AlterColumn<int>(
                name: "SubElement",
                table: "Window",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Window",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}

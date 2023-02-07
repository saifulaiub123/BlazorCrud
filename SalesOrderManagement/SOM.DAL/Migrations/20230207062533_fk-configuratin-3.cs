using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOM.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fkconfiguratin3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Order",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Order",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_OrderWindow_OrderId",
                table: "OrderWindow",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderWindow_Order_OrderId",
                table: "OrderWindow",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderWindow_Order_OrderId",
                table: "OrderWindow");

            migrationBuilder.DropIndex(
                name: "IX_OrderWindow_OrderId",
                table: "OrderWindow");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}

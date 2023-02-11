using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOM.DAL.Migrations
{
    /// <inheritdoc />
    public partial class fkconfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElementType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Element_ElementTypeId",
                table: "Element",
                column: "ElementTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Element_ElementType_ElementTypeId",
                table: "Element",
                column: "ElementTypeId",
                principalTable: "ElementType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Element_ElementType_ElementTypeId",
                table: "Element");

            migrationBuilder.DropTable(
                name: "ElementType");

            migrationBuilder.DropIndex(
                name: "IX_Element_ElementTypeId",
                table: "Element");
        }
    }
}

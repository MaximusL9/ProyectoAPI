using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoAPI.Migrations
{
    /// <inheritdoc />
    public partial class Producto2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre_Produto",
                table: "Productos",
                newName: "Nombre_Producto");

            migrationBuilder.AlterColumn<double>(
                name: "Precio_Producto",
                table: "Productos",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre_Producto",
                table: "Productos",
                newName: "Nombre_Produto");

            migrationBuilder.AlterColumn<string>(
                name: "Precio_Producto",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}

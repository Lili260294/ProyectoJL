using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoJL.Migrations
{
    /// <inheritdoc />
    public partial class ProyectoJLContextProyectJLContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inventarios",
                columns: table => new
                {
                    IdInventario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDLibro = table.Column<int>(type: "int", nullable: false),
                    IDSucursal = table.Column<int>(type: "int", nullable: false),
                    Existencia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventarios", x => x.IdInventario);
                });

            migrationBuilder.CreateTable(
                name: "Libros",
                columns: table => new
                {
                    IDLibro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDEditorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Año = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    InventarioIdInventario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libros", x => x.IDLibro);
                    table.ForeignKey(
                        name: "FK_Libros_Inventarios_InventarioIdInventario",
                        column: x => x.InventarioIdInventario,
                        principalTable: "Inventarios",
                        principalColumn: "IdInventario");
                });

            migrationBuilder.CreateTable(
                name: "Sucursales",
                columns: table => new
                {
                    IDSucursal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombresucursal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombreencargado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InventarioIdInventario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sucursales", x => x.IDSucursal);
                    table.ForeignKey(
                        name: "FK_Sucursales_Inventarios_InventarioIdInventario",
                        column: x => x.InventarioIdInventario,
                        principalTable: "Inventarios",
                        principalColumn: "IdInventario");
                });

            migrationBuilder.CreateTable(
                name: "Editorials",
                columns: table => new
                {
                    IDEditorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEditorial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombrecontacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LibroIDLibro = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editorials", x => x.IDEditorial);
                    table.ForeignKey(
                        name: "FK_Editorials_Libros_LibroIDLibro",
                        column: x => x.LibroIDLibro,
                        principalTable: "Libros",
                        principalColumn: "IDLibro");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Editorials_LibroIDLibro",
                table: "Editorials",
                column: "LibroIDLibro");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_InventarioIdInventario",
                table: "Libros",
                column: "InventarioIdInventario");

            migrationBuilder.CreateIndex(
                name: "IX_Sucursales_InventarioIdInventario",
                table: "Sucursales",
                column: "InventarioIdInventario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Editorials");

            migrationBuilder.DropTable(
                name: "Sucursales");

            migrationBuilder.DropTable(
                name: "Libros");

            migrationBuilder.DropTable(
                name: "Inventarios");
        }
    }
}

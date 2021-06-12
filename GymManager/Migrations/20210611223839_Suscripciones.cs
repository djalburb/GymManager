using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.Migrations
{
    public partial class Suscripciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.IdCiudad);
                });

            migrationBuilder.CreateTable(
                name: "MetodosPagos",
                columns: table => new
                {
                    IdMetodoPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetodosPagos", x => x.IdMetodoPago);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    IdMoneda = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    Simbolo = table.Column<string>(maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.IdMoneda);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 150, nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    Cedula = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Correo = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Activo = table.Column<bool>(nullable: false),
                    IdCiudad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Ciudades_IdCiudad",
                        column: x => x.IdCiudad,
                        principalTable: "Ciudades",
                        principalColumn: "IdCiudad",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Planes",
                columns: table => new
                {
                    IdPlan = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion1 = table.Column<string>(maxLength: 100, nullable: false),
                    Descripcion2 = table.Column<string>(maxLength: 100, nullable: true),
                    CodigoAlterno = table.Column<string>(maxLength: 20, nullable: true),
                    DuracionDias = table.Column<int>(nullable: false),
                    Precio = table.Column<double>(nullable: false),
                    Descuento = table.Column<double>(nullable: false),
                    IdMoneda = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.IdPlan);
                    table.ForeignKey(
                        name: "FK_Planes_Monedas_IdMoneda",
                        column: x => x.IdMoneda,
                        principalTable: "Monedas",
                        principalColumn: "IdMoneda",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Suscripciones",
                columns: table => new
                {
                    IdSuscripcion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    Estado = table.Column<bool>(nullable: false),
                    IdMetodoPago = table.Column<int>(nullable: false),
                    IdPlan = table.Column<int>(nullable: false),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Cantidad = table.Column<int>(nullable: false),
                    PrecioUnit = table.Column<double>(nullable: false),
                    SubTotal = table.Column<double>(nullable: false),
                    Descuento = table.Column<double>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suscripciones", x => x.IdSuscripcion);
                    table.ForeignKey(
                        name: "FK_Suscripciones_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suscripciones_MetodosPagos_IdMetodoPago",
                        column: x => x.IdMetodoPago,
                        principalTable: "MetodosPagos",
                        principalColumn: "IdMetodoPago",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Suscripciones_Planes_IdPlan",
                        column: x => x.IdPlan,
                        principalTable: "Planes",
                        principalColumn: "IdPlan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_IdCiudad",
                table: "Clientes",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Planes_IdMoneda",
                table: "Planes",
                column: "IdMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_Suscripciones_IdCliente",
                table: "Suscripciones",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Suscripciones_IdMetodoPago",
                table: "Suscripciones",
                column: "IdMetodoPago");

            migrationBuilder.CreateIndex(
                name: "IX_Suscripciones_IdPlan",
                table: "Suscripciones",
                column: "IdPlan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Suscripciones");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "MetodosPagos");

            migrationBuilder.DropTable(
                name: "Planes");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Monedas");
        }
    }
}

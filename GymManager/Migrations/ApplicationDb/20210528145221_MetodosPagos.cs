using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.Migrations.ApplicationDb
{
    public partial class MetodosPagos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MetodosPagos");
        }
    }
}

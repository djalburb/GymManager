using Microsoft.EntityFrameworkCore.Migrations;

namespace GymManager.Migrations
{
    public partial class Planes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    Descuento = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planes", x => x.IdPlan);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planes");
        }
    }
}

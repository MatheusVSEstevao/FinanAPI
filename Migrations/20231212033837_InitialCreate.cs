using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinanAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_SALARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorLiquido = table.Column<double>(type: "float", nullable: false),
                    GastosObrigatorios = table.Column<double>(type: "float", nullable: false),
                    GastosLazer = table.Column<double>(type: "float", nullable: false),
                    ValorFinal = table.Column<double>(type: "float", nullable: false),
                    ValorGuardado = table.Column<double>(type: "float", nullable: false),
                    ValorEmergencial = table.Column<double>(type: "float", nullable: false),
                    Cargo = table.Column<int>(type: "int", nullable: false),
                    valor = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_SALARIOS", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TB_SALARIOS",
                columns: new[] { "Id", "Cargo", "GastosLazer", "GastosObrigatorios", "Nome", "ValorEmergencial", "ValorFinal", "ValorGuardado", "ValorLiquido", "valor" },
                values: new object[,]
                {
                    { 1, 5, 400.0, 600.0, "Matheus Estagiário", 100.0, 500.0, 400.0, 1500.0, 0.0 },
                    { 2, 4, 500.0, 600.0, "Matheus Trainee", 146.5, 746.5, 600.0, 1846.5, 0.0 },
                    { 3, 3, 700.0, 600.0, "Matheus Júnior", 200.0, 1200.0, 1000.0, 2500.0, 0.0 },
                    { 4, 2, 1500.0, 600.0, "Matheus Pleno", 400.0, 2900.0, 2500.0, 5000.0, 0.0 },
                    { 5, 1, 3000.0, 600.0, "Matheus Sênior", 900.0, 4400.0, 3500.0, 8000.0, 0.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_SALARIOS");
        }
    }
}

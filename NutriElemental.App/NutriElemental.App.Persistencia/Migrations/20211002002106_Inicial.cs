using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NutriElemental.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TarjetaProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HorasLaborales = table.Column<int>(type: "int", nullable: true),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroRethus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitud = table.Column<float>(type: "real", nullable: true),
                    Longitud = table.Column<float>(type: "real", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CoahId = table.Column<int>(type: "int", nullable: true),
                    NutricionistaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_CoahId",
                        column: x => x.CoahId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personas_Personas_NutricionistaId",
                        column: x => x.NutricionistaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Historias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteId = table.Column<int>(type: "int", nullable: true),
                    Diagnostico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Historias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Historias_Personas_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistroNutricionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hora_Registro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lugar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actividad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado_Animo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PacienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroNutricionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroNutricionales_Personas_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AntecedentesFamiliares",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Antecedente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntecedentesFamiliares", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AntecedentesFamiliares_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AntecedentesPersonales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Antecedente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AntecedentesPersonales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AntecedentesPersonales_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SugerenciasNutricionales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nombre_Sugerencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HistoriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SugerenciasNutricionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SugerenciasNutricionales_Historias_HistoriaId",
                        column: x => x.HistoriaId,
                        principalTable: "Historias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AntecedentesFamiliares_HistoriaId",
                table: "AntecedentesFamiliares",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_AntecedentesPersonales_HistoriaId",
                table: "AntecedentesPersonales",
                column: "HistoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Historias_PacienteId",
                table: "Historias",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CoahId",
                table: "Personas",
                column: "CoahId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_NutricionistaId",
                table: "Personas",
                column: "NutricionistaId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroNutricionales_PacienteId",
                table: "RegistroNutricionales",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_SugerenciasNutricionales_HistoriaId",
                table: "SugerenciasNutricionales",
                column: "HistoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AntecedentesFamiliares");

            migrationBuilder.DropTable(
                name: "AntecedentesPersonales");

            migrationBuilder.DropTable(
                name: "RegistroNutricionales");

            migrationBuilder.DropTable(
                name: "SugerenciasNutricionales");

            migrationBuilder.DropTable(
                name: "Historias");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiagnosticoGeneralEnfermedades",
                columns: table => new
                {
                    DiagnosticoGeneraEnfermedadesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagnosticoGeneralEnfermedades", x => x.DiagnosticoGeneraEnfermedadesID);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.PersonaID);
                });

            migrationBuilder.CreateTable(
                name: "Recetas",
                columns: table => new
                {
                    RecetaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaEmision = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recetas", x => x.RecetaID);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticos",
                columns: table => new
                {
                    DiagnosticoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Severidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendaciones = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiagnosticoGeneralEnfermedadesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticos", x => x.DiagnosticoID);
                    table.ForeignKey(
                        name: "FK_Diagnosticos_DiagnosticoGeneralEnfermedades_DiagnosticoGeneralEnfermedadesID",
                        column: x => x.DiagnosticoGeneralEnfermedadesID,
                        principalTable: "DiagnosticoGeneralEnfermedades",
                        principalColumn: "DiagnosticoGeneraEnfermedadesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    MedicoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonaID = table.Column<int>(type: "int", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.MedicoID);
                    table.ForeignKey(
                        name: "FK_Medicos_Personas_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Personas",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HistorialMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteID);
                    table.ForeignKey(
                        name: "FK_Pacientes_Personas_PersonaID",
                        column: x => x.PersonaID,
                        principalTable: "Personas",
                        principalColumn: "PersonaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleRecetas",
                columns: table => new
                {
                    DetalleRecetaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecetaID = table.Column<int>(type: "int", nullable: false),
                    Medicamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Frecuencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instrucciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleRecetas", x => x.DetalleRecetaID);
                    table.ForeignKey(
                        name: "FK_DetalleRecetas_Recetas_RecetaID",
                        column: x => x.RecetaID,
                        principalTable: "Recetas",
                        principalColumn: "RecetaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitaMedicas",
                columns: table => new
                {
                    CitaMedicaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicoID = table.Column<int>(type: "int", nullable: false),
                    PacienteID = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    RecetaID = table.Column<int>(type: "int", nullable: false),
                    CitaMedicaDiagnosticoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitaMedicas", x => x.CitaMedicaID);
                    table.ForeignKey(
                        name: "FK_CitaMedicas_Medicos_MedicoID",
                        column: x => x.MedicoID,
                        principalTable: "Medicos",
                        principalColumn: "MedicoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitaMedicas_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteID");
                    table.ForeignKey(
                        name: "FK_CitaMedicas_Recetas_RecetaID",
                        column: x => x.RecetaID,
                        principalTable: "Recetas",
                        principalColumn: "RecetaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignosVitales",
                columns: table => new
                {
                    SignosVitalesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pulso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrecuenciaCardiaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PresionArterial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PacienteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignosVitales", x => x.SignosVitalesID);
                    table.ForeignKey(
                        name: "FK_SignosVitales_Pacientes_PacienteID",
                        column: x => x.PacienteID,
                        principalTable: "Pacientes",
                        principalColumn: "PacienteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitaMedicaDiagnosticos",
                columns: table => new
                {
                    CitaMedicaDiagnosticoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitaMedicaID = table.Column<int>(type: "int", nullable: false),
                    DiagnosticoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitaMedicaDiagnosticos", x => x.CitaMedicaDiagnosticoID);
                    table.ForeignKey(
                        name: "FK_CitaMedicaDiagnosticos_CitaMedicas_CitaMedicaID",
                        column: x => x.CitaMedicaID,
                        principalTable: "CitaMedicas",
                        principalColumn: "CitaMedicaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitaMedicaDiagnosticos_Diagnosticos_DiagnosticoID",
                        column: x => x.DiagnosticoID,
                        principalTable: "Diagnosticos",
                        principalColumn: "DiagnosticoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicaDiagnosticos_CitaMedicaID",
                table: "CitaMedicaDiagnosticos",
                column: "CitaMedicaID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicaDiagnosticos_DiagnosticoID",
                table: "CitaMedicaDiagnosticos",
                column: "DiagnosticoID");

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicas_MedicoID",
                table: "CitaMedicas",
                column: "MedicoID");

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicas_PacienteID",
                table: "CitaMedicas",
                column: "PacienteID");

            migrationBuilder.CreateIndex(
                name: "IX_CitaMedicas_RecetaID",
                table: "CitaMedicas",
                column: "RecetaID");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleRecetas_RecetaID",
                table: "DetalleRecetas",
                column: "RecetaID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticos_DiagnosticoGeneralEnfermedadesID",
                table: "Diagnosticos",
                column: "DiagnosticoGeneralEnfermedadesID");

            migrationBuilder.CreateIndex(
                name: "IX_Medicos_PersonaID",
                table: "Medicos",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_PersonaID",
                table: "Pacientes",
                column: "PersonaID");

            migrationBuilder.CreateIndex(
                name: "IX_SignosVitales_PacienteID",
                table: "SignosVitales",
                column: "PacienteID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitaMedicaDiagnosticos");

            migrationBuilder.DropTable(
                name: "DetalleRecetas");

            migrationBuilder.DropTable(
                name: "SignosVitales");

            migrationBuilder.DropTable(
                name: "CitaMedicas");

            migrationBuilder.DropTable(
                name: "Diagnosticos");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Recetas");

            migrationBuilder.DropTable(
                name: "DiagnosticoGeneralEnfermedades");

            migrationBuilder.DropTable(
                name: "Personas");
        }
    }
}

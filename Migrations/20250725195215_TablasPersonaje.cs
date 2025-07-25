using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldaraaApi.Migrations
{
    /// <inheritdoc />
    public partial class TablasPersonaje : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    DadoGolpe = table.Column<int>(type: "INTEGER", nullable: true),
                    LanzadorConjuros = table.Column<bool>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Equipamientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<string>(type: "TEXT", nullable: true),
                    Propiedades = table.Column<string>(type: "TEXT", nullable: true),
                    Peso = table.Column<float>(type: "REAL", nullable: true),
                    Costo = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamientos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    HabilidadBase = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hechizos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: false),
                    Escuela = table.Column<string>(type: "TEXT", nullable: true),
                    TiempoConjuro = table.Column<string>(type: "TEXT", nullable: true),
                    Alcance = table.Column<string>(type: "TEXT", nullable: true),
                    Componentes = table.Column<string>(type: "TEXT", nullable: true),
                    Duracion = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hechizos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Razas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Razas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trasfondos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Caracteristica = table.Column<string>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trasfondos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subrazas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RazaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subrazas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subrazas_Razas_RazaId",
                        column: x => x.RazaId,
                        principalTable: "Razas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    NombreJugador = table.Column<string>(type: "TEXT", nullable: true),
                    RazaId = table.Column<int>(type: "INTEGER", nullable: true),
                    SubrazaId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClaseId = table.Column<int>(type: "INTEGER", nullable: true),
                    TrasfondoId = table.Column<int>(type: "INTEGER", nullable: true),
                    Alineamiento = table.Column<string>(type: "TEXT", nullable: true),
                    Nivel = table.Column<int>(type: "INTEGER", nullable: false),
                    Experiencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Inspiracion = table.Column<bool>(type: "INTEGER", nullable: false),
                    Edad = table.Column<int>(type: "INTEGER", nullable: true),
                    Genero = table.Column<string>(type: "TEXT", nullable: true),
                    Altura = table.Column<string>(type: "TEXT", nullable: true),
                    Peso = table.Column<string>(type: "TEXT", nullable: true),
                    ColorOjos = table.Column<string>(type: "TEXT", nullable: true),
                    ColorPiel = table.Column<string>(type: "TEXT", nullable: true),
                    ColorCabello = table.Column<string>(type: "TEXT", nullable: true),
                    Deidad = table.Column<string>(type: "TEXT", nullable: true),
                    HistoriaPersonal = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personajes_Clases_ClaseId",
                        column: x => x.ClaseId,
                        principalTable: "Clases",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personajes_Razas_RazaId",
                        column: x => x.RazaId,
                        principalTable: "Razas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personajes_Subrazas_SubrazaId",
                        column: x => x.SubrazaId,
                        principalTable: "Subrazas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personajes_Trasfondos_TrasfondoId",
                        column: x => x.TrasfondoId,
                        principalTable: "Trasfondos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AtributosPersonalizados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<string>(type: "TEXT", nullable: true),
                    Detalles = table.Column<string>(type: "TEXT", nullable: true),
                    Sistema = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtributosPersonalizados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtributosPersonalizados_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntradasLibres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Titulo = table.Column<string>(type: "TEXT", nullable: true),
                    Contenido = table.Column<string>(type: "TEXT", nullable: false),
                    CreadoEn = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ActualizadoEn = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntradasLibres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntradasLibres_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstadisticasCombate",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PuntosGolpeActuales = table.Column<int>(type: "INTEGER", nullable: false),
                    PuntosGolpeMaximos = table.Column<int>(type: "INTEGER", nullable: false),
                    Iniciativa = table.Column<int>(type: "INTEGER", nullable: false),
                    ClaseArmadura = table.Column<int>(type: "INTEGER", nullable: false),
                    Velocidad = table.Column<int>(type: "INTEGER", nullable: false),
                    DadosGolpe = table.Column<string>(type: "TEXT", nullable: true),
                    HabilidadLanzamientoConjuros = table.Column<string>(type: "TEXT", nullable: true),
                    DificultadSalvacionConjuros = table.Column<int>(type: "INTEGER", nullable: true),
                    BonoAtaqueConjuros = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadisticasCombate", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_EstadisticasCombate_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajesEquipamiento",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    EquipamientoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Equipado = table.Column<bool>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajesEquipamiento", x => new { x.PersonajeId, x.EquipamientoId });
                    table.ForeignKey(
                        name: "FK_PersonajesEquipamiento_Equipamientos_EquipamientoId",
                        column: x => x.EquipamientoId,
                        principalTable: "Equipamientos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajesEquipamiento_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajesHabilidad",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    HabilidadId = table.Column<int>(type: "INTEGER", nullable: false),
                    Competente = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajesHabilidad", x => new { x.PersonajeId, x.HabilidadId });
                    table.ForeignKey(
                        name: "FK_PersonajesHabilidad_Habilidades_HabilidadId",
                        column: x => x.HabilidadId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajesHabilidad_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonajesHechizo",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    HechizoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Preparado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonajesHechizo", x => new { x.PersonajeId, x.HechizoId });
                    table.ForeignKey(
                        name: "FK_PersonajesHechizo_Hechizos_HechizoId",
                        column: x => x.HechizoId,
                        principalTable: "Hechizos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonajesHechizo_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PuntuacionesHabilidades",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Fuerza = table.Column<int>(type: "INTEGER", nullable: false),
                    Destreza = table.Column<int>(type: "INTEGER", nullable: false),
                    Constitucion = table.Column<int>(type: "INTEGER", nullable: false),
                    Inteligencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Sabiduria = table.Column<int>(type: "INTEGER", nullable: false),
                    Carisma = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntuacionesHabilidades", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_PuntuacionesHabilidades_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RasgosPersonalidades",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Rasgo1 = table.Column<string>(type: "TEXT", nullable: true),
                    Rasgo2 = table.Column<string>(type: "TEXT", nullable: true),
                    Ideal = table.Column<string>(type: "TEXT", nullable: true),
                    Vinculo = table.Column<string>(type: "TEXT", nullable: true),
                    Defecto = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasgosPersonalidades", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_RasgosPersonalidades_Personajes_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtributosPersonalizados_PersonajeId",
                table: "AtributosPersonalizados",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_EntradasLibres_PersonajeId",
                table: "EntradasLibres",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_ClaseId",
                table: "Personajes",
                column: "ClaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_RazaId",
                table: "Personajes",
                column: "RazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_SubrazaId",
                table: "Personajes",
                column: "SubrazaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_TrasfondoId",
                table: "Personajes",
                column: "TrasfondoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajesEquipamiento_EquipamientoId",
                table: "PersonajesEquipamiento",
                column: "EquipamientoId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajesHabilidad_HabilidadId",
                table: "PersonajesHabilidad",
                column: "HabilidadId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonajesHechizo_HechizoId",
                table: "PersonajesHechizo",
                column: "HechizoId");

            migrationBuilder.CreateIndex(
                name: "IX_Subrazas_RazaId",
                table: "Subrazas",
                column: "RazaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtributosPersonalizados");

            migrationBuilder.DropTable(
                name: "EntradasLibres");

            migrationBuilder.DropTable(
                name: "EstadisticasCombate");

            migrationBuilder.DropTable(
                name: "PersonajesEquipamiento");

            migrationBuilder.DropTable(
                name: "PersonajesHabilidad");

            migrationBuilder.DropTable(
                name: "PersonajesHechizo");

            migrationBuilder.DropTable(
                name: "PuntuacionesHabilidades");

            migrationBuilder.DropTable(
                name: "RasgosPersonalidades");

            migrationBuilder.DropTable(
                name: "Equipamientos");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Hechizos");

            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Clases");

            migrationBuilder.DropTable(
                name: "Subrazas");

            migrationBuilder.DropTable(
                name: "Trasfondos");

            migrationBuilder.DropTable(
                name: "Razas");
        }
    }
}

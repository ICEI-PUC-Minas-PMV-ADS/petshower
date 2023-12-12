using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authen.Migrations
{
    /// <inheritdoc />
    public partial class addTosadorBanhista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Luffy");

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HorarioAgenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HorarioInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HorarioFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HorarioAgenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HorarioAgenda_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TosadorBanhista",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    AgendaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TosadorBanhista", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TosadorBanhista_Agenda_AgendaId",
                        column: x => x.AgendaId,
                        principalTable: "Agenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HorarioAgenda_AgendaId",
                table: "HorarioAgenda",
                column: "AgendaId");

            migrationBuilder.CreateIndex(
                name: "IX_TosadorBanhista_AgendaId",
                table: "TosadorBanhista",
                column: "AgendaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HorarioAgenda");

            migrationBuilder.DropTable(
                name: "TosadorBanhista");

            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.CreateTable(
                name: "Luffy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    raca = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Luffy", x => x.Id);
                });
        }
    }
}

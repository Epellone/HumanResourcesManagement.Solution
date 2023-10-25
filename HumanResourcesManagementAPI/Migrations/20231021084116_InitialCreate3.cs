using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourcesManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SediDipendenti");

            migrationBuilder.AddColumn<int>(
                name: "IDReferente",
                table: "Sedi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Sede_Dipendente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DipendenteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SedeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DipendenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sede_Dipendente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sede_Dipendente_Dipendenti_DipendenteID",
                        column: x => x.DipendenteID,
                        principalTable: "Dipendenti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sede_Dipendente_Dipendenti_DipendenteId",
                        column: x => x.DipendenteId,
                        principalTable: "Dipendenti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sede_Dipendente_Sedi_SedeID",
                        column: x => x.SedeID,
                        principalTable: "Sedi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Dipendente_DipendenteId",
                table: "Sede_Dipendente",
                column: "DipendenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Dipendente_DipendenteID",
                table: "Sede_Dipendente",
                column: "DipendenteID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sede_Dipendente_SedeID",
                table: "Sede_Dipendente",
                column: "SedeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sede_Dipendente");

            migrationBuilder.DropColumn(
                name: "IDReferente",
                table: "Sedi");

            migrationBuilder.CreateTable(
                name: "SediDipendenti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DipendenteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SedeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SediDipendenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SediDipendenti_Dipendenti_DipendenteID",
                        column: x => x.DipendenteID,
                        principalTable: "Dipendenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SediDipendenti_Sedi_SedeID",
                        column: x => x.SedeID,
                        principalTable: "Sedi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SediDipendenti_DipendenteID",
                table: "SediDipendenti",
                column: "DipendenteID");

            migrationBuilder.CreateIndex(
                name: "IX_SediDipendenti_SedeID",
                table: "SediDipendenti",
                column: "SedeID");
        }
    }
}

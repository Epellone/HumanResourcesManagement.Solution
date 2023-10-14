using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResourcesManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class ProvaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Benefits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Candidati",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecapitoTelefonico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comune = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDiNascita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ColloquioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EsperienzeLavorative",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataInizio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Azienda = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsperienzeLavorative", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Candidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivelliContrattuali",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivelliContrattuali", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mansioni",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mansioni", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Indirizzo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecapitoTel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailSede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipologieColloqui",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologieColloqui", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipologieContratti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologieContratti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipologieDocumenti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologieDocumenti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoftSkills",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoftSkills_Candidati_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TitoliDiStudio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitoliDiStudio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitoliDiStudio_Candidati_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidati",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CandidatiEsperienze",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsperienzeLavorativeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidatoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatiEsperienze", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidatiEsperienze_Candidati_CandidatoID",
                        column: x => x.CandidatoID,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatiEsperienze_EsperienzeLavorative_EsperienzeLavorativeID",
                        column: x => x.EsperienzeLavorativeID,
                        principalTable: "EsperienzeLavorative",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HardSkillsCandidati",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidatoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HardSkillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardSkillsCandidati", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardSkillsCandidati_Candidati_CandidatoID",
                        column: x => x.CandidatoID,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardSkillsCandidati_HardSkills_HardSkillID",
                        column: x => x.HardSkillID,
                        principalTable: "HardSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dipendenti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cognome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MansioneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dipendenti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dipendenti_Mansioni_MansioneID",
                        column: x => x.MansioneID,
                        principalTable: "Mansioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contratti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MansioneID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LivelloContrattualeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoContrattoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipologiaContrattoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipologiaDocumentoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contratti_LivelliContrattuali_LivelloContrattualeID",
                        column: x => x.LivelloContrattualeID,
                        principalTable: "LivelliContrattuali",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratti_Mansioni_MansioneID",
                        column: x => x.MansioneID,
                        principalTable: "Mansioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratti_TipologieContratti_TipologiaContrattoId",
                        column: x => x.TipologiaContrattoId,
                        principalTable: "TipologieContratti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contratti_TipologieDocumenti_TipologiaDocumentoID",
                        column: x => x.TipologiaDocumentoID,
                        principalTable: "TipologieDocumenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoftSkillsCandidati",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidatoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoftSkillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Descrizione = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftSkillsCandidati", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoftSkillsCandidati_Candidati_CandidatoID",
                        column: x => x.CandidatoID,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoftSkillsCandidati_SoftSkills_SoftSkillID",
                        column: x => x.SoftSkillID,
                        principalTable: "SoftSkills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TitoliDiStudioCandidati",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidatoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitoloDiStudioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitoliDiStudioCandidati", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TitoliDiStudioCandidati_Candidati_CandidatoID",
                        column: x => x.CandidatoID,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TitoliDiStudioCandidati_TitoliDiStudio_TitoloDiStudioID",
                        column: x => x.TitoloDiStudioID,
                        principalTable: "TitoliDiStudio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Colloqui",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataColloquio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SedeColloquioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DipendenteColloquioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DipendenteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipologiaColloquioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CandidatoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colloqui", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colloqui_Candidati_CandidatoID",
                        column: x => x.CandidatoID,
                        principalTable: "Candidati",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colloqui_Dipendenti_DipendenteId",
                        column: x => x.DipendenteId,
                        principalTable: "Dipendenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Colloqui_Sedi_SedeColloquioID",
                        column: x => x.SedeColloquioID,
                        principalTable: "Sedi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Colloqui_TipologieColloqui_TipologiaColloquioID",
                        column: x => x.TipologiaColloquioID,
                        principalTable: "TipologieColloqui",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SediDipendenti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DipendenteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SedeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "BenefitsContratti",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContrattoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BenefitsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Attivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitsContratti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BenefitsContratti_Benefits_BenefitsID",
                        column: x => x.BenefitsID,
                        principalTable: "Benefits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BenefitsContratti_Contratti_ContrattoID",
                        column: x => x.ContrattoID,
                        principalTable: "Contratti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BenefitsContratti_BenefitsID",
                table: "BenefitsContratti",
                column: "BenefitsID");

            migrationBuilder.CreateIndex(
                name: "IX_BenefitsContratti_ContrattoID",
                table: "BenefitsContratti",
                column: "ContrattoID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatiEsperienze_CandidatoID",
                table: "CandidatiEsperienze",
                column: "CandidatoID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatiEsperienze_EsperienzeLavorativeID",
                table: "CandidatiEsperienze",
                column: "EsperienzeLavorativeID");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_CandidatoID",
                table: "Colloqui",
                column: "CandidatoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_DipendenteId",
                table: "Colloqui",
                column: "DipendenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_SedeColloquioID",
                table: "Colloqui",
                column: "SedeColloquioID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Colloqui_TipologiaColloquioID",
                table: "Colloqui",
                column: "TipologiaColloquioID");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_LivelloContrattualeID",
                table: "Contratti",
                column: "LivelloContrattualeID");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_MansioneID",
                table: "Contratti",
                column: "MansioneID");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_TipologiaContrattoId",
                table: "Contratti",
                column: "TipologiaContrattoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratti_TipologiaDocumentoID",
                table: "Contratti",
                column: "TipologiaDocumentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Dipendenti_MansioneID",
                table: "Dipendenti",
                column: "MansioneID");

            migrationBuilder.CreateIndex(
                name: "IX_HardSkillsCandidati_CandidatoID",
                table: "HardSkillsCandidati",
                column: "CandidatoID");

            migrationBuilder.CreateIndex(
                name: "IX_HardSkillsCandidati_HardSkillID",
                table: "HardSkillsCandidati",
                column: "HardSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_SediDipendenti_DipendenteID",
                table: "SediDipendenti",
                column: "DipendenteID");

            migrationBuilder.CreateIndex(
                name: "IX_SediDipendenti_SedeID",
                table: "SediDipendenti",
                column: "SedeID");

            migrationBuilder.CreateIndex(
                name: "IX_SoftSkills_CandidatoId",
                table: "SoftSkills",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_SoftSkillsCandidati_CandidatoID",
                table: "SoftSkillsCandidati",
                column: "CandidatoID");

            migrationBuilder.CreateIndex(
                name: "IX_SoftSkillsCandidati_SoftSkillID",
                table: "SoftSkillsCandidati",
                column: "SoftSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_TitoliDiStudio_CandidatoId",
                table: "TitoliDiStudio",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_TitoliDiStudioCandidati_CandidatoID",
                table: "TitoliDiStudioCandidati",
                column: "CandidatoID");

            migrationBuilder.CreateIndex(
                name: "IX_TitoliDiStudioCandidati_TitoloDiStudioID",
                table: "TitoliDiStudioCandidati",
                column: "TitoloDiStudioID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenefitsContratti");

            migrationBuilder.DropTable(
                name: "CandidatiEsperienze");

            migrationBuilder.DropTable(
                name: "Colloqui");

            migrationBuilder.DropTable(
                name: "HardSkillsCandidati");

            migrationBuilder.DropTable(
                name: "SediDipendenti");

            migrationBuilder.DropTable(
                name: "SoftSkillsCandidati");

            migrationBuilder.DropTable(
                name: "TitoliDiStudioCandidati");

            migrationBuilder.DropTable(
                name: "Benefits");

            migrationBuilder.DropTable(
                name: "Contratti");

            migrationBuilder.DropTable(
                name: "EsperienzeLavorative");

            migrationBuilder.DropTable(
                name: "TipologieColloqui");

            migrationBuilder.DropTable(
                name: "HardSkills");

            migrationBuilder.DropTable(
                name: "Dipendenti");

            migrationBuilder.DropTable(
                name: "Sedi");

            migrationBuilder.DropTable(
                name: "SoftSkills");

            migrationBuilder.DropTable(
                name: "TitoliDiStudio");

            migrationBuilder.DropTable(
                name: "LivelliContrattuali");

            migrationBuilder.DropTable(
                name: "TipologieContratti");

            migrationBuilder.DropTable(
                name: "TipologieDocumenti");

            migrationBuilder.DropTable(
                name: "Mansioni");

            migrationBuilder.DropTable(
                name: "Candidati");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRestaurant.Migrations
{
    public partial class Finalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JedinicaKolicine",
                columns: table => new
                {
                    JedinicaKolicineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivJedinice = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JedinicaKolicine", x => x.JedinicaKolicineID);
                });

            migrationBuilder.CreateTable(
                name: "KategorijaProizvoda",
                columns: table => new
                {
                    KategorijaProizvodaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivKategorije = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijaProizvoda", x => x.KategorijaProizvodaID);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivKorisnika = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikID);
                });

            migrationBuilder.CreateTable(
                name: "MjestoPosluzivanja",
                columns: table => new
                {
                    MjestoPosluzivanjaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojMjestaPosluzivanja = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MjestoPosluzivanja", x => x.MjestoPosluzivanjaID);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaDetalji",
                columns: table => new
                {
                    NarudzbaDetaljiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Količina = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Placena = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaDetalji", x => x.NarudzbaDetaljiID);
                });

            migrationBuilder.CreateTable(
                name: "ProizvodDetalji",
                columns: table => new
                {
                    ProizvodDetaljiID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Opis = table.Column<string>(nullable: true),
                    KolicinaNaSkladistu = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProizvodDetalji", x => x.ProizvodDetaljiID);
                });

            migrationBuilder.CreateTable(
                name: "Skladiste",
                columns: table => new
                {
                    SkladisteID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivSkladista = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladiste", x => x.SkladisteID);
                });

            migrationBuilder.CreateTable(
                name: "StatusNarudzbe",
                columns: table => new
                {
                    StatusNarudzbeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivStatusa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusNarudzbe", x => x.StatusNarudzbeID);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivUloge = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaID);
                });

            migrationBuilder.CreateTable(
                name: "PodKategorijeProizvoda",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    KategorijaProizvodaID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PodKategorijeProizvoda", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PodKategorijeProizvoda_KategorijaProizvoda_KategorijaProizvodaID",
                        column: x => x.KategorijaProizvodaID,
                        principalTable: "KategorijaProizvoda",
                        principalColumn: "KategorijaProizvodaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NazivNarudzbe = table.Column<string>(nullable: true),
                    VrijemeKreiranjaNarudzbe = table.Column<DateTime>(nullable: false),
                    VrijemeOdgovoraNaNarudzbu = table.Column<DateTime>(nullable: false),
                    StatusNarudzbeID = table.Column<int>(nullable: false),
                    NarudzbaDetaljiID = table.Column<int>(nullable: false),
                    MjestoPosluzivanjaID = table.Column<int>(nullable: false),
                    ImeNarucioca = table.Column<string>(nullable: true),
                    AdresaNarucioca = table.Column<string>(nullable: true),
                    BrojTelefonaNarucioca = table.Column<string>(nullable: true),
                    Prihvacena = table.Column<bool>(nullable: false),
                    PrihvacenaNotifikacija = table.Column<bool>(nullable: false),
                    PromjenaStatusa = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaID);
                    table.ForeignKey(
                        name: "FK_Narudzba_MjestoPosluzivanja_MjestoPosluzivanjaID",
                        column: x => x.MjestoPosluzivanjaID,
                        principalTable: "MjestoPosluzivanja",
                        principalColumn: "MjestoPosluzivanjaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Narudzba_NarudzbaDetalji_NarudzbaDetaljiID",
                        column: x => x.NarudzbaDetaljiID,
                        principalTable: "NarudzbaDetalji",
                        principalColumn: "NarudzbaDetaljiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Narudzba_StatusNarudzbe_StatusNarudzbeID",
                        column: x => x.StatusNarudzbeID,
                        principalTable: "StatusNarudzbe",
                        principalColumn: "StatusNarudzbeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloga",
                columns: table => new
                {
                    KorisnikUlogaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisniciID = table.Column<int>(nullable: false),
                    UlogeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloga", x => x.KorisnikUlogaID);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_Korisnici_KorisniciID",
                        column: x => x.KorisniciID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikUloga_Uloge_UlogeID",
                        column: x => x.UlogeID,
                        principalTable: "Uloge",
                        principalColumn: "UlogaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    ProizvodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Cijena = table.Column<double>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    Količina = table.Column<double>(nullable: false),
                    Aktivan = table.Column<bool>(nullable: false),
                    JedinicaKolicineID = table.Column<int>(nullable: false),
                    PodKategorijeProizvodaID = table.Column<int>(nullable: false),
                    SkladisteID = table.Column<int>(nullable: false),
                    ProizvodDetaljiID = table.Column<int>(nullable: false),
                    IstekRoka = table.Column<DateTime>(nullable: false),
                    NabavnaCijena = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.ProizvodID);
                    table.ForeignKey(
                        name: "FK_Proizvod_JedinicaKolicine_JedinicaKolicineID",
                        column: x => x.JedinicaKolicineID,
                        principalTable: "JedinicaKolicine",
                        principalColumn: "JedinicaKolicineID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvod_PodKategorijeProizvoda_PodKategorijeProizvodaID",
                        column: x => x.PodKategorijeProizvodaID,
                        principalTable: "PodKategorijeProizvoda",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvod_ProizvodDetalji_ProizvodDetaljiID",
                        column: x => x.ProizvodDetaljiID,
                        principalTable: "ProizvodDetalji",
                        principalColumn: "ProizvodDetaljiID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proizvod_Skladiste_SkladisteID",
                        column: x => x.SkladisteID,
                        principalTable: "Skladiste",
                        principalColumn: "SkladisteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikNarudzba",
                columns: table => new
                {
                    NarudzbaKorisnikID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NarudzbaID = table.Column<int>(nullable: false),
                    KorisnikID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikNarudzba", x => x.NarudzbaKorisnikID);
                    table.ForeignKey(
                        name: "FK_KorisnikNarudzba_Korisnici_KorisnikID",
                        column: x => x.KorisnikID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikNarudzba_Narudzba_NarudzbaID",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikOcjena",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisniciID = table.Column<int>(nullable: false),
                    ProizvodID = table.Column<int>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikOcjena", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KorisnikOcjena_Korisnici_KorisniciID",
                        column: x => x.KorisniciID,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikOcjena_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaProizvod",
                columns: table => new
                {
                    NarudzbaProizvodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NarudzbaID = table.Column<int>(nullable: false),
                    ProizvodID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaProizvod", x => x.NarudzbaProizvodID);
                    table.ForeignKey(
                        name: "FK_NarudzbaProizvod_Narudzba_NarudzbaID",
                        column: x => x.NarudzbaID,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NarudzbaProizvod_Proizvod_ProizvodID",
                        column: x => x.ProizvodID,
                        principalTable: "Proizvod",
                        principalColumn: "ProizvodID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikNarudzba_KorisnikID",
                table: "KorisnikNarudzba",
                column: "KorisnikID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikNarudzba_NarudzbaID",
                table: "KorisnikNarudzba",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikOcjena_KorisniciID",
                table: "KorisnikOcjena",
                column: "KorisniciID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikOcjena_ProizvodID",
                table: "KorisnikOcjena",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_KorisniciID",
                table: "KorisnikUloga",
                column: "KorisniciID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloga_UlogeID",
                table: "KorisnikUloga",
                column: "UlogeID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_MjestoPosluzivanjaID",
                table: "Narudzba",
                column: "MjestoPosluzivanjaID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_NarudzbaDetaljiID",
                table: "Narudzba",
                column: "NarudzbaDetaljiID");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_StatusNarudzbeID",
                table: "Narudzba",
                column: "StatusNarudzbeID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaProizvod_NarudzbaID",
                table: "NarudzbaProizvod",
                column: "NarudzbaID");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaProizvod_ProizvodID",
                table: "NarudzbaProizvod",
                column: "ProizvodID");

            migrationBuilder.CreateIndex(
                name: "IX_PodKategorijeProizvoda_KategorijaProizvodaID",
                table: "PodKategorijeProizvoda",
                column: "KategorijaProizvodaID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_JedinicaKolicineID",
                table: "Proizvod",
                column: "JedinicaKolicineID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_PodKategorijeProizvodaID",
                table: "Proizvod",
                column: "PodKategorijeProizvodaID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_ProizvodDetaljiID",
                table: "Proizvod",
                column: "ProizvodDetaljiID");

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_SkladisteID",
                table: "Proizvod",
                column: "SkladisteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisnikNarudzba");

            migrationBuilder.DropTable(
                name: "KorisnikOcjena");

            migrationBuilder.DropTable(
                name: "KorisnikUloga");

            migrationBuilder.DropTable(
                name: "NarudzbaProizvod");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Proizvod");

            migrationBuilder.DropTable(
                name: "MjestoPosluzivanja");

            migrationBuilder.DropTable(
                name: "NarudzbaDetalji");

            migrationBuilder.DropTable(
                name: "StatusNarudzbe");

            migrationBuilder.DropTable(
                name: "JedinicaKolicine");

            migrationBuilder.DropTable(
                name: "PodKategorijeProizvoda");

            migrationBuilder.DropTable(
                name: "ProizvodDetalji");

            migrationBuilder.DropTable(
                name: "Skladiste");

            migrationBuilder.DropTable(
                name: "KategorijaProizvoda");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ajanscode.Eticaret.Web.Dal.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doviz",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DovizAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oran = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doviz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeoBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAdi = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnaMenu = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Sil = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sira = table.Column<int>(type: "int", nullable: false, defaultValue: 99999),
                    UstKategoriId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kategoriler_Kategoriler_UstKategoriId",
                        column: x => x.UstKategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Marka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StokKodu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MarkaId = table.Column<int>(type: "int", nullable: false),
                    DovizId = table.Column<int>(type: "int", nullable: false),
                    UrunSeoBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunSeoAciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stok = table.Column<int>(type: "int", nullable: false, defaultValueSql: "0"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vitrin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Sil = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    GuncellemeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    SilmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sira = table.Column<int>(type: "int", nullable: false, defaultValue: 99999)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urun_Doviz_DovizId",
                        column: x => x.DovizId,
                        principalTable: "Doviz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Urun_Marka_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Marka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KategoriUrun",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    UrunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategoriUrun", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KategoriUrun_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KategoriUrun_Urun_UrunId",
                        column: x => x.UrunId,
                        principalTable: "Urun",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler",
                column: "KategoriAdi",
                unique: true,
                filter: "[KategoriAdi] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_UstKategoriId",
                table: "Kategoriler",
                column: "UstKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_KategoriUrun_KategoriId_UrunId",
                table: "KategoriUrun",
                columns: new[] { "KategoriId", "UrunId" });

            migrationBuilder.CreateIndex(
                name: "IX_KategoriUrun_UrunId",
                table: "KategoriUrun",
                column: "UrunId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_DovizId",
                table: "Urun",
                column: "DovizId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_MarkaId",
                table: "Urun",
                column: "MarkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Urun_StokKodu",
                table: "Urun",
                column: "StokKodu",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KategoriUrun");

            migrationBuilder.DropTable(
                name: "Kategoriler");

            migrationBuilder.DropTable(
                name: "Urun");

            migrationBuilder.DropTable(
                name: "Doviz");

            migrationBuilder.DropTable(
                name: "Marka");
        }
    }
}

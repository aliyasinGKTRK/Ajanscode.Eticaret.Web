﻿// <auto-generated />
using System;
using Ajanscode.Eticaret.Web.Dal.Concreate.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ajanscode.Eticaret.Web.Dal.Migrations
{
    [DbContext(typeof(EticaretContext))]
    partial class EticaretContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Doviz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DovizAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Oran")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Doviz");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AnaMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("GuncellemeTarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Resim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeoBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("SilmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sira")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(99999);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UstKategoriId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KategoriAdi")
                        .IsUnique()
                        .HasFilter("[KategoriAdi] IS NOT NULL");

                    b.HasIndex("UstKategoriId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.KategoriUrun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<int>("UrunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrunId");

                    b.HasIndex("KategoriId", "UrunId");

                    b.ToTable("KategoriUrun");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Marka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Marka");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DovizId")
                        .HasColumnType("int");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("GuncellemeTarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MarkaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("Resim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Sil")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("SilmeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sira")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(99999);

                    b.Property<int>("Stok")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("0");

                    b.Property<string>("StokKodu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunSeoAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrunSeoBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vitrin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("DovizId");

                    b.HasIndex("MarkaId");

                    b.HasIndex("StokKodu")
                        .IsUnique();

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Kategori", b =>
                {
                    b.HasOne("Ajanscode.Eticaret.Web.Entities.Concrate.Kategori", null)
                        .WithMany("AltKategoriler")
                        .HasForeignKey("UstKategoriId")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.KategoriUrun", b =>
                {
                    b.HasOne("Ajanscode.Eticaret.Web.Entities.Concrate.Kategori", "Kategori")
                        .WithMany("KategoriUrunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ajanscode.Eticaret.Web.Entities.Concrate.Urun", "Urun")
                        .WithMany("KategoriUrun")
                        .HasForeignKey("UrunId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Urun", b =>
                {
                    b.HasOne("Ajanscode.Eticaret.Web.Entities.Concrate.Doviz", "Doviz")
                        .WithMany("Urunler")
                        .HasForeignKey("DovizId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ajanscode.Eticaret.Web.Entities.Concrate.Marka", "Marka")
                        .WithMany("Urunler")
                        .HasForeignKey("MarkaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doviz");

                    b.Navigation("Marka");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Doviz", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Kategori", b =>
                {
                    b.Navigation("AltKategoriler");

                    b.Navigation("KategoriUrunler");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Marka", b =>
                {
                    b.Navigation("Urunler");
                });

            modelBuilder.Entity("Ajanscode.Eticaret.Web.Entities.Concrate.Urun", b =>
                {
                    b.Navigation("KategoriUrun");
                });
#pragma warning restore 612, 618
        }
    }
}

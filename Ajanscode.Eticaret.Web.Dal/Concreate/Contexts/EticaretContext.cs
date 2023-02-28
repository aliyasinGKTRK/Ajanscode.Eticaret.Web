using Ajanscode.Eticaret.Web.Dal.Concreate.Mapping;
using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Contexts
{
    public class EticaretContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-OGP4U22;Database=Eticaret-Db;Trusted_Connection=True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new IlceMap());
            //modelBuilder.ApplyConfiguration(new SehirMap());
            //modelBuilder.ApplyConfiguration(new SemtMap());
            //modelBuilder.ApplyConfiguration(new UlkeMap());
            modelBuilder.ApplyConfiguration(new KategoriMap());
            modelBuilder.ApplyConfiguration(new KategoriUrunMap());
            modelBuilder.ApplyConfiguration(new UrunMap());
            //base.OnModelCreating(modelBuilder);
        }
        //public DbSet<Kullanici> Kullanicilar { get; set; }
        //public DbSet<KullaniciRol> KullaniciRoller { get; set; }
        //public DbSet<Rol> Roller { get; set; }
        //public DbSet<Ulke> Ulkeler { get; set; }
        //public DbSet<Sehir> Sehirler { get; set; }
        //public DbSet<Ilce> Ilceler { get; set; }
        //public DbSet<Semt> Semtler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        //public DbSet<KategoriUrun> KategoriUrunler { get; set; }
        //public DbSet<Urun> Urunler { get; set; }
        //public DbSet<Marka> Markalar { get; set; }
        //public DbSet<Ozellik> Ozellikler { get; set; }
        //public DbSet<UrunOzellik> UrunOzellikler { get; set; }
        //public DbSet<Ayar> Ayarlar { get; set; }
    }
}

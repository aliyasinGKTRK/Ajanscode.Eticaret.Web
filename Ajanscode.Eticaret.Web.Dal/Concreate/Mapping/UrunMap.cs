using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class UrunMap : IEntityTypeConfiguration<Urun>
    {
        public void Configure(EntityTypeBuilder<Urun> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasIndex(x => x.StokKodu).IsUnique();
            builder.Property(x => x.StokKodu).IsRequired();
            builder.Property(x => x.MarkaId).IsRequired();
            builder.Property(x => x.DovizId).IsRequired();
            builder.Property(x => x.UrunAdi).IsRequired();
            builder.Property(x => x.Resim).IsRequired();
            builder.Property(x => x.Fiyat).IsRequired();
            builder.Property(x => x.Stok).IsRequired().HasDefaultValueSql("0");
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.Vitrin).HasDefaultValue(0);
            builder.Property(x => x.Sil).HasDefaultValue(0);
            builder.Property(x => x.Vitrin).IsRequired();
            builder.Property(x => x.Sil).IsRequired();
            builder.Property(x => x.OlusturmaTarihi).HasDefaultValueSql("GetDate()").IsRequired();
            builder.Property(x => x.GuncellemeTarihi).HasDefaultValueSql("GetDate()").IsRequired();
            builder.Property(x => x.Sira).HasDefaultValue(99999);
            builder.HasOne(x => x.Doviz).WithMany(x => x.Urunler).HasForeignKey(x => x.DovizId);
            builder.HasOne(x => x.Marka).WithMany(x => x.Urunler).HasForeignKey(x => x.MarkaId);
            builder.HasMany(x => x.KategoriUrun).WithOne(x => x.Urun).HasForeignKey(x => x.UrunId);

    }
    }
}

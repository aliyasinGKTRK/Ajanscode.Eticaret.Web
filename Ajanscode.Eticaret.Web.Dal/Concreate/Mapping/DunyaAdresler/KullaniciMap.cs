using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.KullaniciAdi).IsUnique();
            builder.Property(x => x.UlkeId).IsRequired();
            builder.Property(x => x.SehirId).IsRequired();
            builder.Property(x => x.IlceId).IsRequired();
            builder.Property(x => x.SemtId).IsRequired();
            builder.Property(x => x.Adi).IsRequired();
            builder.Property(x => x.Adres).IsRequired();
            builder.Property(x => x.Eposta).IsRequired();
            builder.Property(x => x.Soyadi).IsRequired();
            builder.Property(x => x.KullaniciAdi).IsRequired();

        }
    }
}

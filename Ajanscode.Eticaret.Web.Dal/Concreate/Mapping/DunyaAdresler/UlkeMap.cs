using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class UlkeMap : IEntityTypeConfiguration<Ulke>
    {
        public void Configure(EntityTypeBuilder<Ulke> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IkiliKod).IsRequired();
            builder.Property(x => x.UcluKod).IsRequired();
            builder.Property(x => x.UlkeAdi).IsRequired();
            builder.Property(x => x.TelKodu).IsRequired();
            builder.HasMany(x => x.Sehirler).WithOne(x => x.Ulke).HasForeignKey(x => x.UlkeId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}

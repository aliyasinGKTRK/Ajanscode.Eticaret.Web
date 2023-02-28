using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class SehirMap : IEntityTypeConfiguration<Sehir>
    {
        public void Configure(EntityTypeBuilder<Sehir> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PlakaKodu).IsRequired();
            builder.Property(x => x.SehirAdi).IsRequired();
            builder.Property(x => x.Sira).IsRequired().HasDefaultValue(9999);
            builder.HasMany(x => x.Ilceler).WithOne(x => x.Sehir).HasForeignKey(x => x.SehirId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}

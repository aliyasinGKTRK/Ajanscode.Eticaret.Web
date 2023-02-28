using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class IlceMap : IEntityTypeConfiguration<Ilce>
    {
        public void Configure(EntityTypeBuilder<Ilce> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IlceAdi).IsRequired();
             builder.HasMany(x => x.Semtler).WithOne(x => x.Ilce).HasForeignKey(x => x.IlceId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}

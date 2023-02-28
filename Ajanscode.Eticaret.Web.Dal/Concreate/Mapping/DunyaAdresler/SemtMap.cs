using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class SemtMap : IEntityTypeConfiguration<Semt>
    {
        public void Configure(EntityTypeBuilder<Semt> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SemtAdi).IsRequired();
            builder.Property(x => x.PostaKodu).IsRequired();
        }
    }
}

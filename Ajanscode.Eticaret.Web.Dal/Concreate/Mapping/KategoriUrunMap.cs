using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class KategoriUrunMap : IEntityTypeConfiguration<KategoriUrun>
    {
        public void Configure(EntityTypeBuilder<KategoriUrun> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasIndex(x => new {x.KategoriId,x.UrunId });
        }
    }
}

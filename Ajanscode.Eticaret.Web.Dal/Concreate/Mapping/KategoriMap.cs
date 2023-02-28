using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.Mapping
{
    public class KategoriMap : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasIndex(x => x.KategoriAdi).IsUnique();
            builder.Property(x => x.Url).IsRequired();
            builder.Property(x => x.OlusturmaTarihi).HasDefaultValueSql("GetDate()").IsRequired();
            builder.Property(x => x.GuncellemeTarihi).HasDefaultValueSql("GetDate()").IsRequired();
            builder.HasOne<Kategori>().WithMany(x => x.AltKategoriler).HasForeignKey(x => x.UstKategoriId).OnDelete(DeleteBehavior.NoAction);
            builder.Property(x => x.Sil).HasDefaultValue(0);
            builder.Property(x => x.AnaMenu).HasDefaultValue(0);
            builder.Property(x => x.Sira).HasDefaultValue(99999);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class KategoriUrun:BaseEntity
    {
        public int KategoriId { get; set; }
        public int UrunId { get; set; }
        public Urun Urun { get; set; }
        public Kategori Kategori{ get; set; }
    }
}

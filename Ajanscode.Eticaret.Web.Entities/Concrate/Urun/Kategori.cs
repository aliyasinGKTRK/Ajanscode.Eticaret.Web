using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
   public class Kategori:BaseEntity
    {
        public string? SeoBaslik { get; set; }
        public string? SeoAciklama { get; set; }
        public string KategoriAdi { get; set; }
        public string? Icon { get; set; }
        public string? Resim { get; set; }
        public string? Aciklama { get; set; }
        public string Url { get; set; }
        public bool AnaMenu { get; set; }
        public bool Sil { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public DateTime? SilmeTarihi { get; set; }
        public int Sira { get; set; }
        public int? UstKategoriId { get; set; }
        public List<Kategori> AltKategoriler { get; set; }
        public List<KategoriUrun> KategoriUrunler { get; set; }
       
    }
}

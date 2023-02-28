using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class Urun : BaseEntity
    {
        public string StokKodu { get; set; }
        public int MarkaId { get; set; }
        public int DovizId { get; set; }
        public string UrunSeoBaslik { get; set; }
        public string UrunSeoAciklama { get; set; }
        public string UrunAdi { get; set; }
        public string Icon { get; set; }
        public string Resim { get; set; }
        public decimal Fiyat { get; set; }
        public int Stok { get; set; }
        public string Url { get; set; }
        public bool Vitrin { get; set; }
        public bool Sil { get; set; }
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public DateTime SilmeTarihi { get; set; }
        public int Sira { get; set; }
        public Marka Marka { get; set; }
        public Doviz Doviz { get; set; }
        public List<KategoriUrun> KategoriUrun { get; set; }
    }
}

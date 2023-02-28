using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class UrunOzellik : BaseEntity
    {
        public int UrunId { get; set; }
        public string StokKodu { get; set; }
        public int AnaOzellikId { get; set; }
        public int AltOzellikId { get; set; }
        public Urun Urun { get; set; }
        public Ozellik Anaozellik { get; set; }
        public Ozellik Altozellik { get; set; }
        public decimal Fiyat { get; set; }
        public string Resimler { get; set; }
        public int AnaUrunOzellikId { get; set; }

        public string Url { get; set; }
    }
}

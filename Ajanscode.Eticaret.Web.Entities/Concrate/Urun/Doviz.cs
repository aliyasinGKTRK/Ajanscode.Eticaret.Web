using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class Doviz : BaseEntity
    {
        public string DovizAdi { get; set; }
        public decimal Oran { get; set; }
        public decimal Fiyat { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class Sehir : BaseEntity
    {
        public string SehirAdi { get; set; }
        public string PlakaKodu { get; set; }
        public int Sira { get; set; }
        public int? UlkeId { get; set; }
        public Ulke Ulke { get; set; }
        public List<Ilce> Ilceler { get; set; }
    }
}

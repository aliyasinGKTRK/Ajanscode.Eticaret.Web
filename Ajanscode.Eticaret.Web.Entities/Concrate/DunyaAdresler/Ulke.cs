using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
  public  class Ulke:BaseEntity
    {
        public string IkiliKod { get; set; }
        public string UcluKod { get; set; }
        public string UlkeAdi { get; set; }
        public string TelKodu { get; set; }
        public List<Sehir> Sehirler { get; set; }
    }
}

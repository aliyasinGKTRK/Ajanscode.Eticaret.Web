using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
   public class Ilce:BaseEntity
    {
        public string IlceAdi { get; set; }
        public int? SehirId { get; set; }
        public Sehir Sehir { get; set; }
        public List<Semt> Semtler { get; set; }
    }
}

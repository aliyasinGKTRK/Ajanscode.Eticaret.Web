using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
   public class Semt:BaseEntity
    {
        public string SemtAdi { get; set; }
        public string PostaKodu { get; set; }
        public int? IlceId { get; set; }
        public Ilce Ilce { get; set; }
    }
}

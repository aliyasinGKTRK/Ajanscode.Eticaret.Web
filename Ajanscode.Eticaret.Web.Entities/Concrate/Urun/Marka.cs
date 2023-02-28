using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class Marka:BaseEntity
    {
        public string Adi { get; set; }
        public bool Active { get; set; }
        public List<Urun> Urunler { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
   public class Ozellik:BaseEntity
    {
        public string Adi { get; set; }
        public int UstOzellikId { get; set; }
        public List<Ozellik> AltOzelliker { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class Rol : BaseEntity
    {
        public int Adi { get; set; }
        public List<KullaniciRol> KullaniciRoller { get; set; }
    }
}

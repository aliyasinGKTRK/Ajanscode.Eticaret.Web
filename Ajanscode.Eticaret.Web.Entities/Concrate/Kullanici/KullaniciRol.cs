using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
    public class KullaniciRol : BaseEntity
    {
        public int KullaniciId { get; set; }
        public int RolId { get; set; }
        public Kullanici Kullanici { get; set; }
        public Rol Rol { get; set; }
    }
}

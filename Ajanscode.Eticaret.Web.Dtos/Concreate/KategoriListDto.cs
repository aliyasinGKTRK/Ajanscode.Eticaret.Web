using Ajanscode.Eticaret.Web.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dtos.Concreate
{
    public class KategoriListDto:BaseEntityDto
    {
        public string Adı { get; set; }
        public bool select { get; set; }
    }
}

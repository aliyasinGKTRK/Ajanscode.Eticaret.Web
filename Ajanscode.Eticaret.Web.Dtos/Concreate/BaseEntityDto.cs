using Ajanscode.Eticaret.Web.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dtos.Concreate
{
    public class BaseEntityDto : IDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

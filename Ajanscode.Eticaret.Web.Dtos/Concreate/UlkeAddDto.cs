using Ajanscode.Eticaret.Web.Dtos.Interfaces;

namespace Ajanscode.Eticaret.Web.Dtos.Concreate
{
    public class UlkeAddDto:IDTO
    {
        public string IkiliKod { get; set; }
        public string UcluKod { get; set; }
        public string UlkeAdi { get; set; }
        public string TelKodu { get; set; }
    }
}

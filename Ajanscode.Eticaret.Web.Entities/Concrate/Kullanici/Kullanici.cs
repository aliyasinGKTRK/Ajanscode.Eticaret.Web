using Ajanscode.Eticaret.Web.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ajanscode.Eticaret.Web.Entities.Concrate
{
  public  class Kullanici:BaseEntity
    {
        public string KullaniciAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Eposta { get; set; }
        public string SabitTel { get; set; }
        public string GsmTel { get; set; }
        public string Sifre { get; set; }
        public string Adres { get; set; }
        public int UlkeId { get; set; }
        public int SehirId { get; set; }
        public int IlceId { get; set; }
        public int SemtId { get; set; }
        public int CinsiyetId { get; set; }
        public Ulke Ulke { get; set; }
        public Sehir Sehir { get; set; }
        public Ilce Ilce { get; set; }
        public Semt Semtler { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public List<KullaniciRol> KullaniciRoller { get; set; }

    }
}

using Ajanscode.Eticaret.Web.Dtos.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ajanscode.Eticaret.Web.Dtos.Concreate
{
    public class KategoriAddDto : IDTO
    {
        public KategoriAddDto()
        {
            Kategoriler = new List<Kategori>();
        }
        [DisplayName("Seo Başlık")]
        public string SeoBaslik { get; set; }
        [DisplayName("Seo Açıklama")]
        public string SeoAciklama { get; set; }
        [DisplayName("Kategori Adı")]
        public string KategoriAdi { get; set; }
        [DisplayName("İcon")]
        public string Icon { get; set; }
        public string Resim { get; set; }
        [DisplayName("Kategori Açıklama")]
        public string Aciklama { get; set; }
        public string Url { get; set; }
        [DisplayName("Menü")]
        public bool AnaMenu { get; set; }
        [DisplayName("Sıra")]
        public int? Sira { get; set; }
        [DisplayName("Üst Kategori")]
        public int? UstKategoriId { get; set; }
      
        public List<Kategori> Kategoriler;
    }

  
}

using Ajanscode.Eticaret.Web.Business.Interfaces;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.B2B.Custom.TagHalpers
{

   

    [HtmlTargetElement("SelectUlke")]
   
    public class SelectUlke : TagHelper
    {
        private readonly IKategoriService _kategoriService;

        public SelectUlke(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var stringbuilder = new StringBuilder();
            string data = "<select asp-for='UstKategoriId' class='form-control'> <option value = '' >seçiniz</option>{0}</select>";
            string opt = "";
            foreach (var item in _kategoriService.GetAsync().Result)
            {
                opt += "<option value = '" + item.Id + "'>" + item.KategoriAdi + "</option>";
            }
            stringbuilder.AppendFormat(data, opt);
            output.Content.SetHtmlContent(stringbuilder.ToString());
            base.Process(context, output);
        }
    }
}

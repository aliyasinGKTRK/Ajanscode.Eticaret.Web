using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dtos.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.B2B.ViewCompanetler
{
    public class SelectKategoriler: ViewComponent
    {
        private readonly IKategoriService _kategoriService;

        public SelectKategoriler(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? UstkategoriId)
        {
            KategoriAddDto model = new KategoriAddDto();
            model.UstKategoriId = UstkategoriId;
            model.Kategoriler = await _kategoriService.GetAsync();
            return View("select",model);
        }
    }
}

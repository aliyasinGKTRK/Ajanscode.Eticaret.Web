using Ajanscode.Eticaret.Web.B2B.Custom.Filters;
using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dtos.Concreate;
using Ajanscode.Eticaret.Web.Entities.Concrate;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.B2B.Controllers
{

    public class KategorilerController : Controller
    {
        private readonly IMapper _Mapper;
        private readonly IKategoriService _kategoriService;

        public KategorilerController(IKategoriService kategoriService, IMapper Mapper)
        {

            _kategoriService = kategoriService;
            _Mapper = Mapper;
        }
        public async Task<IActionResult> Index()
        {
            var sonuc = await _kategoriService.GetAsync();

            return View("Kategoriler", sonuc);
        }
        public async Task<IActionResult> Add()
        {
            KategoriAddDto kategoriAdd = new KategoriAddDto();
            kategoriAdd.Kategoriler.AddRange(await _kategoriService.GetAsync());
         
          
            return View( kategoriAdd);
        }
        [HttpPost]
        [Validmodel]
        public async Task<IActionResult> Add(KategoriAddDto KategoriAddDto)
        {
            await _kategoriService.AddAsync(_Mapper.Map<Kategori>(KategoriAddDto));
            KategoriAddDto.Kategoriler.AddRange(await _kategoriService.GetAsync());
            return View(KategoriAddDto);
        } 
        
        public async Task<IActionResult> Update(int id)
        {
            KategoriAddDto kategoriAdd = new KategoriAddDto();
            kategoriAdd.Kategoriler.AddRange(await _kategoriService.GetAsync());
            return View( kategoriAdd);
        }
        //[HttpPost]
        ////[Validmodel]
        //public async Task<IActionResult> Update(KategoriUpdateDto KategoriAddDto)
        //{
        //    await _kategoriService.AddAsync(_Mapper.Map<Kategori>(KategoriAddDto));
        //    KategoriAddDto.Kategoriler.AddRange(await _kategoriService.GetAsync());
        //    return View(KategoriAddDto);
        //}
    }
}

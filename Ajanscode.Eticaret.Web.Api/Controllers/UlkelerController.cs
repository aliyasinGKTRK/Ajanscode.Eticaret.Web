using Ajanscode.Eticaret.Web.Api.CustomFilter;
using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dtos.Concreate;
using Ajanscode.Eticaret.Web.Entities.Concrate;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    public class UlkelerController : ControllerBase
    {
        public readonly IUlkeService _ulkeService;

        public UlkelerController(IUlkeService ulkeService)
        {
            _ulkeService = ulkeService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _ulkeService.GetAsync();
            return Ok(result);
        }
        [HttpPost]
        
        public async Task<IActionResult> Add(UlkeAddDto UlkeAddDto)
        {

            await _ulkeService.AddAsync(new Ulke { IkiliKod = UlkeAddDto.IkiliKod, TelKodu = UlkeAddDto.TelKodu, UcluKod = UlkeAddDto.UcluKod, UlkeAdi = UlkeAddDto.UlkeAdi });
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> Update(Ulke UlkeEkle)
        {
            var result = await _ulkeService.GetAsync();
            //await _ulkeService.AddAsync(UlkeEkle);
            return Ok();
        }
        [HttpDelete("{id}")]
        [ServiceFilter(typeof(ValidModel<Ulke>))]
        public async Task<IActionResult> Delete(int id)
        {
            //Ulke result = await _ulkeService.FirstFilterByIdAsync(id);
            await _ulkeService.RemoveAsync(new Ulke {Id=id });
            return Ok();
        }

    }
}

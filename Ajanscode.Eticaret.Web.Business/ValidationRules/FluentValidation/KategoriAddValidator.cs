using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dtos.Concreate;
using FluentValidation;

namespace Ajanscode.Eticaret.Web.Business.ValidationRules.FluentValidation
{
    public class KategoriAddValidator : AbstractValidator<KategoriAddDto>
    {
        private readonly IKategoriService _kategoriService;
        public KategoriAddValidator(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
            RuleFor(x => x.UstKategoriId).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.KategoriAdi).NotEmpty().NotNull().WithMessage("Boş Geçilemez");
            RuleFor(x => x.KategoriAdi).Must(KategoriAdiKontrol).WithMessage("Kategori Adı sistemde kayıtlı");
        }
        private bool KategoriAdiKontrol(string arg)
        {
            var d = _kategoriService.FirstFilterAsync(x => x.KategoriAdi == arg).Result;
            return d == null ? true : false;
        }
    }
}

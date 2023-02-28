using Ajanscode.Eticaret.Web.Dtos.Concreate;
using FluentValidation;

namespace Ajanscode.Eticaret.Web.Business.ValidationRules.FluentValidation
{
    public class UlkeAddValidator : AbstractValidator<UlkeAddDto>
    {
        public UlkeAddValidator()
        {
            RuleFor(x => x.IkiliKod).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.UcluKod).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.UlkeAdi).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.TelKodu).NotEmpty().WithMessage("Boş Geçilemez");
        }
    }
}

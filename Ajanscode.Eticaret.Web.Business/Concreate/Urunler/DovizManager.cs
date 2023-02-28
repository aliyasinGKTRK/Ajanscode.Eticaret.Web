using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class DovizManager : GenericManager<Doviz>, IDovizService
    {
        public DovizManager(IGenericDal<Doviz> genericDal) : base(genericDal)
        {
        }
    }
}

using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class SehirManager:GenericManager<Sehir>,ISehirService
    {
        public SehirManager(IGenericDal<Sehir> genericDal):base(genericDal)
        {

        }
    }
}

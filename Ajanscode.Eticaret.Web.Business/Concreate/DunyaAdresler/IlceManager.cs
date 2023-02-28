using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class IlceManager:GenericManager<Ilce>,IIlceService
    {
        public IlceManager(IGenericDal<Ilce> genericDal):base(genericDal)
        {
                
        }
    }
}

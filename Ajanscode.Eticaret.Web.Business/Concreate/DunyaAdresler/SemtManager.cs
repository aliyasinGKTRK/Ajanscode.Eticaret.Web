using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class SemtManager:GenericManager<Semt>,ISemtService
    {
        public SemtManager(IGenericDal<Semt> genericDal):base(genericDal)
        {
                
        }
    }
}

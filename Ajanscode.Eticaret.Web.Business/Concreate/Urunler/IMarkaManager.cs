using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class IMarkaManager : GenericManager<Marka>,IMarkaService
    {
        public IMarkaManager(IGenericDal<Marka> genericDal) : base(genericDal)
        {
        }
    }
}

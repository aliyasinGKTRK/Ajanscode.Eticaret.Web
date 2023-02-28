using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class UlkeManager:GenericManager<Ulke>,IUlkeService
    {
        public UlkeManager(IGenericDal<Ulke> genericDal):base(genericDal)
        {

        }
    }
}

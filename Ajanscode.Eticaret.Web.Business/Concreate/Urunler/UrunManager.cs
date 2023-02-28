using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public   class UrunManager:GenericManager<Urun>,IUrunService
    {
        public UrunManager(IGenericDal<Urun> genericDal):base(genericDal)
        {

        }
    }
}

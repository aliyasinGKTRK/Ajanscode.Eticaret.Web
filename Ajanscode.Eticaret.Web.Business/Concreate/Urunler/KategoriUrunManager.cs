using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class KategoriUrunManager : GenericManager<KategoriUrun>, IKategoriUrunService
    {
        public KategoriUrunManager(IGenericDal<KategoriUrun> genericDal) : base(genericDal)
        {
        }
    }
}

using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Concrate;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class KategoriManager : GenericManager<Kategori>, IKategoriService
    {
        public KategoriManager(IGenericDal<Kategori> genericDal) : base(genericDal)
        {

        }
    }
}

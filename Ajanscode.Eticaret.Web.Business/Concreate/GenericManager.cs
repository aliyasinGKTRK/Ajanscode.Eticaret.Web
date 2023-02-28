using Ajanscode.Eticaret.Web.Business.Interfaces;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.Business.Concreate
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        public readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task AddAsync(TEntity Tentity)
        {
            await _genericDal.AddAsync(Tentity);
        }
        public async Task<TEntity> FirstFilterAsync(Expression<Func<TEntity, bool>> Filter)
        {
          return await _genericDal.FirstFilterAsync(Filter);
        }
        public async Task<TEntity> FirstFilterByIdAsync(int id)
        {
            return await _genericDal.FirstFilterByIdAsync(id);
        }
        public async Task<List<TEntity>> GetAsync()
        {
            return await _genericDal.GetAsync();
        }
        public async Task<List<TEntity>> GetFilterAsync(Expression<Func<TEntity, bool>> Filter)
        {
            return await _genericDal.GetFilterAsync(Filter);
        }
        public async Task RemoveAsync(TEntity Tentity)
        {
           await _genericDal.RemoveAsync(Tentity);
        }
        public async Task UpdateAsync(TEntity Tentity)
        {
            await _genericDal.UpdateAsync(Tentity);
        }
    }
}

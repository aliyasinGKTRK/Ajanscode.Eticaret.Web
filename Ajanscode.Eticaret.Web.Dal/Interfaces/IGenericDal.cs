using Ajanscode.Eticaret.Web.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.Dal.Interfaces
{
   public interface IGenericDal<TEntity> where TEntity:class,ITable,new()
    {
         Task<List<TEntity>> GetAsync();
         Task<List<TEntity>> GetFilterAsync(Expression<Func<TEntity, bool>> Filter);
         Task<TEntity> FirstFilterAsync(Expression<Func<TEntity, bool>> Filter);
         Task<TEntity> FirstFilterByIdAsync(int id);
         Task AddAsync(TEntity Tentity);
         Task UpdateAsync(TEntity Tentity);
         Task RemoveAsync(TEntity Tentity);


    }
}

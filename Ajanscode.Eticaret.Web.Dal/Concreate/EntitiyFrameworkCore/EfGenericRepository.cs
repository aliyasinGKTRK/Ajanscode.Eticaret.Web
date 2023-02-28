using Ajanscode.Eticaret.Web.Dal.Concreate.Contexts;
using Ajanscode.Eticaret.Web.Dal.Interfaces;
using Ajanscode.Eticaret.Web.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ajanscode.Eticaret.Web.Dal.Concreate.EntitiyFrameworkCore
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task AddAsync(TEntity Tentity)
        {
            using var db = new EticaretContext();
            await db.AddAsync(Tentity);
            await db.SaveChangesAsync();
        }
        public async Task<TEntity> FirstFilterAsync(Expression<Func<TEntity, bool>> Filter)
        {
            using var db = new EticaretContext();
            return await db.Set<TEntity>().FirstOrDefaultAsync(Filter);
        }
        public async Task<TEntity> FirstFilterByIdAsync(int id)
        {
            using var db = new EticaretContext();
            return await db.Set<TEntity>().FindAsync(id);
        }
        public async Task<List<TEntity>> GetAsync()
        {
            using var db = new EticaretContext();
            return await db.Set<TEntity>().ToListAsync();
        }
        public async Task<List<TEntity>> GetFilterAsync(Expression<Func<TEntity, bool>> Filter)
        {
            using var db = new EticaretContext();
            return await db.Set<TEntity>().Where(Filter).ToListAsync();
        }
        public async Task RemoveAsync(TEntity Tentity)
        {
            using var db = new EticaretContext();
            db.Remove(Tentity);
            await db.SaveChangesAsync();
        }
        public async Task UpdateAsync(TEntity Tentity)
        {
            using var db = new EticaretContext();
            db.Update(Tentity);
            await db.SaveChangesAsync();
        }
    }
}

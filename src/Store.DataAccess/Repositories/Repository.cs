using Microsoft.EntityFrameworkCore;
using Store.Data.Models;
using Store.DataAccess.Context;
using Store.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Store.DataAccess.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly StoreContext context;
        protected readonly DbSet<TEntity> db;

        protected Repository(StoreContext context)
        {
            this.context = context;
            this.db = context.Set<TEntity>();
        }

        public virtual async Task Add(TEntity entity)
        {
            await db.AddAsync(entity);
            await SaveChanges();
        }

        public virtual async Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return await db.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            return await db.AsNoTracking().ToListAsync();
        }

        public virtual async Task<TEntity> GetById(Guid id)
        {
            return await db.AsNoTracking().Where(e => e.Id == id).FirstOrDefaultAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            db.Update(entity);
            await SaveChanges();
        }

        public virtual async Task Remove(Guid id)
        {
            var entity = await GetById(id);

            db.Remove(entity);

            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
        }
    }
}

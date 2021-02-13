using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EfEntityFramework
{
    public class EfEntityRepository<TEntity, TContext> :
        IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public async Task AddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task AddRangeAsync(IList<TEntity> entities)
        {
            using (var context = new TContext())
            {
                await context.AddRangeAsync(entities);
                await context.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                var result =  await context.Set<TEntity>().SingleOrDefaultAsync(filter);
                return result;
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }
        public async Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                     ? await context.Set<TEntity>().ToListAsync()
                     : await context.Set<TEntity>().Where(filter).ToListAsync();
            }
        }
        public async Task<IEnumerable<TEntity>> GetSqlAsync(string sql)
        {
            using (var context = new TContext())
            {
                return await context.Set<TEntity>().FromSqlRaw(sql).ToListAsync();
            }
        }
        public async Task UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
            }
        }
    }
}

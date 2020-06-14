using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Data
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected DbContext _dbContext { get; set; }
        protected internal DbSet<TEntity> _table;

        public RepositoryBase(DbContext context)
        {
            _dbContext = context;
            _table = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _table.AsNoTracking();
        }

        public async Task<TEntity> GetSingleEntityByCondition(Expression<Func<TEntity, bool>> expression)
        {
            return await _table.Where(expression).AsNoTracking().SingleOrDefaultAsync();
        }

        
        public async Task SaveAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _table.Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _table.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}

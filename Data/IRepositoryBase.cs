using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectManagement.WebAPI.Data
{
    public interface IRepositoryBase<TEntity>
    {
        IQueryable<TEntity> GetAll();
        Task<TEntity> GetSingleEntityByCondition(Expression<Func<TEntity, bool>> expression);
        Task SaveAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}

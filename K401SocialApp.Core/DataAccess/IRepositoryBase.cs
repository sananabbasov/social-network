using System;
using System.Linq.Expressions;

namespace K401SocialApp.Core.DataAccess
{
    public interface IRepositoryBase<TEntity>
        where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null);
    }
}


using EFatura.Core.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFatura.Core.RepositoryBase
{
    public interface IRepository<TEntity> where TEntity : class, IEntity, new()
    {

        TEntity Add(TEntity entity);

        bool AddMore(params TEntity[] entities/*IEnumerable<TEntity> listEntity*/);

        TEntity GetSingle(Expression<Func<TEntity, bool>> filter = null);

        IEnumerable<TEntity> GetAll();

        bool Update(TEntity entity);

        TEntity Delete(TEntity entity);

        long? GetMaxID();


        /*ASYNC METHODS*/

        Task<TEntity> AddAsync(TEntity entity);

        Task<bool> AddMoreAsync(params TEntity[] entities);

        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter = null);

        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<bool> UpdateAsync(TEntity entity);

        Task<TEntity> DeleteAsync(TEntity entity);

        Task<long?> GetMaxIDAsync();
    }
}

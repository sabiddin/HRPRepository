using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HRP.Contracts.DataContracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity FindById(int Id);
        Task<TEntity> FindByIdAsync(int Id);

        List<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        Task<List<TEntity>> FindByAsync(Expression<Func<TEntity, bool>> predicate);

        List<TEntity> FindAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}

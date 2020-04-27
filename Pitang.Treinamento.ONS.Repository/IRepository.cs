using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Treinamento.Pitang.ONS.Entities;

namespace Treinamento.Pitang.ONS.Repository
{
   public interface IRepository<T> where T : BaseEntity
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void Delete(T id);
        void UnDelete(T id);
        IEnumerable<T> FindAll();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
    }
}

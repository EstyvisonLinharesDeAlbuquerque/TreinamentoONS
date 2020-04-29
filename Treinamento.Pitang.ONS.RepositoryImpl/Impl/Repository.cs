using Microsoft.EntityFrameworkCore;
using Pitang.Treinamento.ONS.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Treinamento.Pitang.ONS.Entities;
using Treinamento.Pitang.ONS.Repository;

namespace Treinamento.Pitang.ONS.RepositoryImpl
{
    public abstract class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected DataContext _context;
        protected DbSet<T> _entities; 

        public Repository(DataContext dbContext)
        {
            _context = dbContext;
            _entities = _context.Set<T>();
        }

        public T Add(T entity)
        {
            _entities.Add(entity);
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _entities.AddAsync(entity);
            return entity;
        }

        public void Delete(T id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            var query = _entities.AsQueryable();
            query = query.Select(e => e);
            return await query.ToListAsync();
        }

        
        public async Task<IEnumerable<T>> FindBy(Expression<Func<T, bool>> predicate)
        {
            var query = _entities.AsQueryable();
            query = query.Where(predicate);
            return await query.ToListAsync();
        }
        public void UnDelete(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}




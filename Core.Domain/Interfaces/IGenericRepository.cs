using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        void Save();
    }
}

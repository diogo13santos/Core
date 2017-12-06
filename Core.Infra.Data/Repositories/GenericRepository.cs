using Core.Domain.Interfaces;
using Core.Infra.Data.Context;
using System.Linq;

namespace Core.Infra.Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CoreContext _context;

        public GenericRepository(CoreContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }

        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<System.Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query;
        }

        public IQueryable<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

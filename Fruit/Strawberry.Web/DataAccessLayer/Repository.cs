using Strawberry.Web.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Strawberry.Web.DataAccessLayer
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private MyContext _context;

        public Repository(MyContext context)
        {
            this._context = context;
        }

        public IEnumerable<T> All
        {
            get { return _context.Set<T>().ToList<T>(); }
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _context.Set<T>().Where(where).ToList();
        }

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _context.Set<T>().Attach(entity);
            _context.Set<T>().Remove(entity);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
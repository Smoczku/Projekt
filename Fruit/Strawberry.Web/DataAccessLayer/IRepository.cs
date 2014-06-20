using System;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace Strawberry.Web.DataAccessLayer
{
    public interface IRepository<T>  where T : class, new()
    {
        IEnumerable<T> All { get; }
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);
        void Delete(T entity);
        T Find(int id);
        void Insert(T entity);
        void Update(T entity);
    }
}

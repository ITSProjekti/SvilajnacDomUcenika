using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(T entities);

    }
}
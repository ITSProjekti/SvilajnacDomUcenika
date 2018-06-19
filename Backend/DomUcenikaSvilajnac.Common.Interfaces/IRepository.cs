using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// Genericki interfejs IRepository{T} sa metodama za klasu <"Repository">.
    /// Za uvid u implementaciju prikazanih metoda, pogledati /DAL/RepoPattern/Repository
    /// </summary>
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
         Task< IEnumerable<T>> GetAllAsync();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        Task<T> GetAsync(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(T entities);
    }
}
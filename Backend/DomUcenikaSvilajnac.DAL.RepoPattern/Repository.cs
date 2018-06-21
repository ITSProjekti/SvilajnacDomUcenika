using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DomUcenikaSvilajnac.Common.Interfaces;
using System.Threading.Tasks;
using DomUcenikaSvilajnac.ModelResources;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Genericka klasa Repository, koja implementira metode za rad sa bazom podataka iz IRepository generickog interfejsa.
    /// Pogledati /Common/Interfaces/IRepository
    /// </summary>
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// The database context 
        /// </summary>
        protected readonly DbContext _dbContext;

        /// <summary>
        /// Inicijalizacija instance Repository{T} klase.
        /// </summary>
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Dodavanje novog entiteta, univerzalno za sve entitete.
        /// </summary>
        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }

        /// <summary>
        /// Dodavanje vise novih entiteta, univerzalno za sve entitete.
        /// </summary>
        public void AddRange(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().AddRange(entities);
        }

        /// <summary>
        /// Pronalazenje entiteta po odredjenom kriterijumu, univerzalno.
        /// </summary>
        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate);
        }

        /// <summary>
        /// Get Id-a odredjenog entiteta.
        /// </summary>
        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        /// <summary>
        /// Get all, uzima sve enetitete i vraca listu.
        /// </summary>
        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        /// <summary>
        /// Get all, async metoda, vraca ListAsync.
        /// </summary>
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        /// <summary>
        /// Get Id-a odredjenog entiteta, async metoda.
        /// </summary>
        public async Task<T> GetAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        /// <summary>
        /// Uklanjanje odredjenog entiteta, univerzalno.
        /// </summary>
        public void Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        /// <summary>
        /// Uklanjanje vise odredjenih entiteta, univerzalno(za sve entitete).
        /// </summary>
        public void RemoveRange(T entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
        }


        
    }
}

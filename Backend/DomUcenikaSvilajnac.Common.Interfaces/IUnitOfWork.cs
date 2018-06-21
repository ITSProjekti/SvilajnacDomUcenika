using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using System.Linq;
using System.Threading.Tasks;
using DomUcenikaSvilajnac.ModelResources;

namespace DomUcenikaSvilajnac.Common.Interfaces
{
    /// <summary>
    /// IUnitOfWork interfejs za klasu UnitOfWork koja implementira navedene SaveChanges metode.
    /// Za uvid u implementaciju prikazanih metoda pogledati /DAL/RepoPattern/UnitOfWork
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IUcenikRepository Ucenici { get; }
        IMestoRepository Mesto{ get; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<IEnumerable<UcenikResource>> mestaUcenika();

    }
}
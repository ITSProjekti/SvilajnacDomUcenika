using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Interfaces;

using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Klasa UnitOfWork, koja implementira metode SaveChanges i iz IUnitOfWork interfejsa. Inicijalizuje sve kontekste.
    /// Pogledati /Common/Interfaces/IUnitOfWork
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// _context (instanca klase UcenikContext)
        /// </summary>
        protected readonly UcenikContext _context;

        /// <summary>
        /// Inicijalizacija instance "UnitOfWork" klase.
        /// </summary>
        public UnitOfWork(UcenikContext context)
        {
            _context = context;
            Ucenici = new UcenikRepository(_context);
            Mesto = new MestoRepository(_context);

        }

        /// <summary>
        /// Za deklarisanje konteksta u konstruktoru iznad.
        /// </summary>
        public IUcenikRepository Ucenici { get; private set; }

        public IMestoRepository Mesto { get; private set; }

        /// <summary>
        /// Izvršava zadatke definisane za aplikaciju povezane sa oslobađanjem, puštanjem ili poništavanjem nepovezanih resursa.
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

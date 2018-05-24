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
    public class UnitOfWork : IUnitOfWork
    {
       protected readonly UcenikContext _context;

        public UnitOfWork(UcenikContext context)
        {
            _context = context;
            Ucenici = new UcenikRepository(_context);
        }

        public IUcenikRepository Ucenici { get; private set; }
        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Interfaces;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UcenikContext _context;

        public UnitOfWork(UcenikContext context)
        {
            _context = context;
            Ucenici = new UcenikRepository(_context);
        }

        public IUcenikRepository Ucenici { get; private set; }

        // public IUcenikRepository Ucenici { get; private set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}

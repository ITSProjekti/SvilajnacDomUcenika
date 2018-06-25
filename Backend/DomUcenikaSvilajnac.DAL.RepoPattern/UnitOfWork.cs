using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Interfaces;

using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.AspNetCore.Mvc;

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
        public UnitOfWork(UcenikContext context, IMapper mapper)
        {
            _context = context;
            Mapper = mapper;
            Ucenici = new UcenikRepository(_context);
            Mesto = new MestoRepository(_context);
            Opstine = new OpstinaRepository(_context);

        }

        /// <summary>
        /// Za deklarisanje konteksta u konstruktoru iznad.
        /// </summary>
        public IUcenikRepository Ucenici { get; private set; }

        public IMestoRepository Mesto { get; private set; }

        public IOpstinaRepository Opstine { get; private set; }

        public IMapper Mapper { get; }

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

        public async Task<IEnumerable<UcenikResource>> mestaUcenika()
        {
            var neki = await _context.Uceniks.Include(m=> m.Mesto)
                .Include(o=> o.Opstina).ToListAsync();
            return Mapper.Map<List<Ucenik>, List<UcenikResource>>(neki);
        }
        public async Task<UcenikResource> mestaUcenikaById(int id)
        {
            var neki = await _context.Uceniks.Include(c => c.Mesto).SingleOrDefaultAsync(x => x.Id == id);
            return Mapper.Map<Ucenik, UcenikResource>(neki);
        }

        public async Task<UcenikResource> postUcenikSaMestom(UcenikResource ucenik)
        {
            var neki = await _context.Uceniks.Include(c => c.Mesto).SingleOrDefaultAsync(x => x.Id == ucenik.Id);

            return Mapper.Map<Ucenik, UcenikResource>(neki);
        }
    }
}

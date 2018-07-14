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
using DomUcenikaSvilajnac.Common.Models.ModelResources;

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
            Opstine = new OpstinaRepository(_context);
            Drzave = new DrzavaRepository(_context);
            Polovi = new PolRepository(_context);
            Telefoni = new TelefonRepository(_context);
            Brojevi = new PostanskiBrojRepository(_context);
            PrethodneSkole = new PrethodnaSkolaRepository(_context);
            UpisaneSkole = new UpisanaSkolaRepository(_context);
            Mesta = new MestoRepository(_context);
            Smerovi = new SmerRepository(_context);
            Razredi = new RazredRepository(_context);
            Roditelji = new RoditeljRepository(_context);
            Stepeni = new StepenStrucneSpremeRepository(_context);

    }

        /// <summary>
        /// Za deklarisanje konteksta u konstruktoru iznad.
        /// </summary>
        public IUcenikRepository Ucenici { get; private set; }
        public IOpstinaRepository Opstine { get; private set; }
        public IDrzavaRepository Drzave { get; private set; }
        public IPolRepository Polovi { get; set; }
        public ITelefonRepository Telefoni { get; set; }
        public IPostanskiBrojRepository Brojevi { get; set; }
        public IPrethodnaSkolaRepository PrethodneSkole { get; set; }
        public IUpisanaSkola UpisaneSkole { get; set; }
        public IMestoRepository Mesta { get; set; }
        public IMapper Mapper { get; }
        public ISmerRepository Smerovi { get; set; }
        public IRazredRpository Razredi { get; set; }
        public IRoditeljRepository Roditelji { get; set; }
        public IStepenStrucneSpremeRepository Stepeni { get; set; }

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

        public async Task<IEnumerable<OpstinaResource>> brojeviOpstine()
        {
            
         


            var nesto = await _context.Opstine
                .Include(k => k.PostanskiBrojevi)
                .ToListAsync();


            return Mapper.Map<List<Opstina>, List<OpstinaResource>>(nesto);

        }


        public async Task<IEnumerable<UcenikResource>> mestaUcenika()
        {


            var neki = await _context.Uceniks
                .Include(o => o.Opstina)
                .Include(d => d.DrzavaRodjenja)
                .Include(op => op.OpstinaPrebivalista)
                .Include(p => p.Pol)
                .Include(t => t.Telefon)
                .Include(pb => pb.PostanskiBroj)
                .Include(os => os.PrethodnaSkola)
                .Include(ss => ss.UpisanaSkola)
                .Include(mr => mr.MestoRodjenja)
                .Include(mr => mr.MestoPrebivalista)
                .Include(mzs => mzs.MestoZavrseneSkole)
                .Include(s => s.Smer)
                .ToListAsync();
            //var neki = await _context.Uceniks
            //    .FromSql(
            //    "select * from ucenici u  join opstine o  on o.id = u.opstinaId"

            //    )
                
                //.ToListAsync();
            return Mapper.Map<List<Ucenik>, List<UcenikResource>>(neki);
        }
        public async Task<UcenikResource> mestaUcenikaById(int id)
        {
            var neki = await _context.Uceniks
                  .Include(o => o.Opstina)
                .Include(d => d.DrzavaRodjenja)
                .Include(op => op.OpstinaPrebivalista)
                .Include(p => p.Pol)
                .Include(t => t.Telefon)
                .Include(pb => pb.PostanskiBroj)
                .Include(os => os.PrethodnaSkola)
                .Include(ss => ss.UpisanaSkola)
                .Include(mr => mr.MestoRodjenja)
                .Include(mr => mr.MestoPrebivalista)
                .Include(mzs => mzs.MestoZavrseneSkole)
                .Include(s => s.Smer)
                .SingleOrDefaultAsync(x => x.Id == id);
            return Mapper.Map<Ucenik, UcenikResource>(neki);
        }

        public async Task<UcenikResource> mapiranje(UcenikResource ucenik)
        {
            var neki = await _context.Uceniks
                 .Include(o => o.Opstina)
                .Include(d => d.DrzavaRodjenja)
                .Include(op => op.OpstinaPrebivalista)
                .Include(p => p.Pol)
                .Include(t => t.Telefon)
                .Include(pb => pb.PostanskiBroj)
                .Include(os => os.PrethodnaSkola)
                .Include(ss => ss.UpisanaSkola)
                .Include(mr => mr.MestoRodjenja)
                .Include(mr => mr.MestoPrebivalista)
                .Include(mzs => mzs.MestoZavrseneSkole)
                .Include(s => s.Smer)
                .SingleOrDefaultAsync(x => x.Id == ucenik.Id);

            return Mapper.Map<Ucenik, UcenikResource>(neki);

           
        }
        public void deleteTelefon(Telefon telefon)
        {
            _context.Telefoni.Remove(telefon);
        }

        public async Task<IEnumerable<RoditeljResource>> roditeljiUcenika(int UcenikId)
        {
            var nesto = await _context.Roditelji.
                FromSql(
                $"select *  from dbo.Roditelji  where UcenikId = {UcenikId}"
                )
                .ToListAsync();

            return  Mapper.Map<List<Roditelj>, List<RoditeljResource>>(nesto);
        }

        public async Task<IEnumerable<RoditeljResource>> brisanjeRoditelja(int UcenikId)
        {
            var nesto = await _context.Roditelji.
                FromSql(
                $"select *  from dbo.Roditelji  where UcenikId = {UcenikId}"
                )
                .ToListAsync();

            _context.RemoveRange(nesto);
            await SaveChangesAsync();

            return Mapper.Map<List<Roditelj>, List<RoditeljResource>>(nesto);
        }
    }
}


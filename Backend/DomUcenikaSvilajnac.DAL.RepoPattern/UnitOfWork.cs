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
using System.Collections.ObjectModel;

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
            Ucenici = new UcenikRepository(_context, mapper);
            Opstine = new OpstinaRepository(_context, mapper);
            Drzave = new DrzavaRepository(_context);
            Polovi = new PolRepository(_context);
            Telefoni = new TelefonRepository(_context, mapper);
            Brojevi = new PostanskiBrojRepository(_context);
            PrethodneSkole = new PrethodnaSkolaRepository(_context);
            UpisaneSkole = new UpisanaSkolaRepository(_context);
            Mesta = new MestoRepository(_context);
            Smerovi = new SmerRepository(_context);
            Razredi = new RazredRepository(_context);
            Roditelji = new RoditeljRepository(_context, mapper);
            Stepeni = new StepenStrucneSpremeRepository(_context);
            TipoviPorodice = new TipPorodiceRepository(_context);
            Staratelji = new StarateljRepository(_context, mapper);
            Pohvale = new PohvalaRepository(_context, mapper);
            VaspitneGrupe = new VaspitnaGrupaRepository(_context, mapper);
            Kazne = new KaznaRepository(_context, mapper);
            Vaspitaci = new VaspitacRepository(_context, mapper);
            Sastanci = new SastanakRepository(_context,mapper);
            Statistike = new StatistikaRepository(_context);
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
        public IUpisanaSkolaRepository UpisaneSkole { get; set; }
        public IMestoRepository Mesta { get; set; }
        public IMapper Mapper { get; }
        public ISmerRepository Smerovi { get; set; }
        public IRazredRepository Razredi { get; set; }
        public IRoditeljRepository Roditelji { get; set; }
        public IStepenStrucneSpremeRepository Stepeni { get; set; }
        public ITipPorodiceRepository TipoviPorodice { get; set; }
        public IStarateljRepository Staratelji { get; set; }
        public IPohvalaRepository Pohvale { get; set; }
        public IVaspitnaGrupaRepository VaspitneGrupe { get; set; }
        public IKaznaRepository Kazne { get; set; }
        public IVaspitacRepository Vaspitaci { get; set; }
        public ISastanakRepository Sastanci { get; set; }
        public IStatistikaRepository Statistike { get; set; }


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

        public async Task<IEnumerable<DeleteRoditeljaResource>> brisanjeRoditelja(int UcenikId)
        {
            var roditeljiUcenika = await _context.Roditelji.
                FromSql(
                $"select *  from dbo.Roditelji  where UcenikId = {UcenikId}"
                )
                .ToListAsync();

            _context.RemoveRange(roditeljiUcenika);
            await SaveChangesAsync();

            return Mapper.Map<List<Roditelj>, List<DeleteRoditeljaResource>>(roditeljiUcenika);
        }
    } 
}


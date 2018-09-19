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
            TipoviPorodice = new TipPorodiceRepository(_context);
            Staratelji = new StarateljRepository(_context);
            Pohvale = new PohvalaRepository(_context);
            VaspitneGrupe = new VaspitnaGrupaRepository(_context);
            Kazne = new KaznaRepository(_context);
            Vaspitaci = new VaspitacRepository(_context);
            Sastanci = new SastanakRepository(_context);
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
        public ITipPorodiceRepository TipoviPorodice { get; set; }
        public IStarateljRepository Staratelji { get; set; }
        public IPohvalaRepository Pohvale { get; set; }
        public IVaspitnaGrupaRepository VaspitneGrupe { get; set; }
        public IKaznaRepository Kazne { get; set; }
        public IVaspitacRepository Vaspitaci { get; set; }
        public ISastanakRepository Sastanci { get; set; }


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
        public async Task<IEnumerable<RoditeljResource>> spremaRoditelja()
        {
            var spremaRoditelja = await _context.Roditelji
                .Include(sss => sss.StepenObrazovanja)
                .ToListAsync();
            return Mapper.Map<List<Roditelj>, List<RoditeljResource>>(spremaRoditelja);

        }


        public async Task<IEnumerable<OpstinaResource>> podaciSaOpstinama()
        {

            var podaciSaOpstinama = await _context.Opstine
                .Include(k => k.PostanskiBrojevi)
                .Include(ss => ss.SrednjeSkole)
                .Include(os => os.OsnovneSkole)
                .ToListAsync();


            return Mapper.Map<List<Opstina>, List<OpstinaResource>>(podaciSaOpstinama);

        }


        public async Task<IEnumerable<UcenikResource>> podaciUcenika()
        {



            var podaciUcenika = await _context.Uceniks
                .Include(o => o.Opstina)
                .Include(d => d.DrzavaRodjenja)
                .Include(op => op.OpstinaPrebivalista)
                .Include(p => p.Pol)
                .Include(t => t.Telefon)
                .Include(pb => pb.PostanskiBroj)
                .Include(os => os.PrethodnaSkola)
                .Include(ss => ss.UpisanaSkola.Opstina)
                .Include(mr => mr.MestoRodjenja)
                .Include(mr => mr.MestoPrebivalista)
                .Include(mzs => mzs.MestoZavrseneSkole)
                .Include(s => s.Smer)
                .Include(r => r.Razred)
                .Include(rod => rod.Roditelji)
                .Include(tipP => tipP.TipPorodice)
                .Include(st => st.Staratelji)
                .Include(vg => vg.VaspitnaGrupa)
                .ToListAsync();

            foreach (var item in podaciUcenika)
            {
                if (item.Staratelji.Count == 0)
                    item.Staratelji = new Collection<Staratelj>() {
                        new Staratelj()
                        {
                            Id = 0,
                            Ime = "",
                            Prezime = "",
                            UcenikId = 0
                        }
                    };
            }

            return Mapper.Map<List<Ucenik>, List<UcenikResource>>(podaciUcenika);
        }
        public async Task<UcenikResource> podaciUcenikaById(int id)
        {
            var podaciUcenikaById = await _context.Uceniks
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
                .Include(r => r.Razred)
                .Include(rod => rod.Roditelji)
                 .Include(tipP => tipP.TipPorodice)
                 .Include(st => st.Staratelji)
                 .Include(vg => vg.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == id);
            return Mapper.Map<Ucenik, UcenikResource>(podaciUcenikaById);
        }
        public async Task<PutUcenikaResource> mapiranjeZaPutUcenika(int id)
        {
            var podaciUcenika = await _context.Uceniks
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
                .Include(r => r.Razred)
                .Include(rod => rod.Roditelji)
                .Include(tipP => tipP.TipPorodice)
                .Include(vg => vg.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == id);
            return Mapper.Map<Ucenik, PutUcenikaResource>(podaciUcenika);
        }

        public async Task<PostUcenikaResource> mapiranjeZaPostUcenika(PostUcenikaResource ucenik)
        {
            var podaciUcenika = await _context.Uceniks
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
                .Include(r => r.Razred)
                .Include(tipP => tipP.TipPorodice)
                .Include(vg => vg.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == ucenik.Id);

            return Mapper.Map<Ucenik, PostUcenikaResource>(podaciUcenika);


        }
        public async Task<UcenikResource> mapiranjeZaDeleteUcenika(UcenikResource ucenik)
        {


            var podaciUcenika = await _context.Uceniks
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
                .Include(r => r.Razred)
                .Include(rod => rod.Roditelji)
                .Include(tipP => tipP.TipPorodice)
                .Include(st => st.Staratelji)
                .Include(vg => vg.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == ucenik.Id);

            return Mapper.Map<Ucenik, UcenikResource>(podaciUcenika);

        }
        public void deleteTelefon(Telefon telefon)
        {
            _context.Telefoni.Remove(telefon);
        }

        public async Task<IEnumerable<RoditeljResource>> roditeljiUcenika(int UcenikId)
        {
            var roditeljiUcenika = await _context.Roditelji.
                FromSql(
                $"select *  from dbo.Roditelji  where UcenikId = {UcenikId}"
                )
                .ToListAsync();







            return Mapper.Map<List<Roditelj>, List<RoditeljResource>>(roditeljiUcenika);
        }

        public async Task<IEnumerable<PutRoditeljaResource>> roditeljiUcenikaZaPut(int UcenikId)
        {
            var roditeljiUcenika = await _context.Roditelji.
                FromSql(
                $"select *  from dbo.Roditelji  where UcenikId = {UcenikId}"
                )
                .ToListAsync();

            return Mapper.Map<List<Roditelj>, List<PutRoditeljaResource>>(roditeljiUcenika);
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

        public async Task<Staratelj> selektIdStarateljaUcenika(int UcenikId)
        {
            var nesto = await _context.Staratelji.SingleOrDefaultAsync(n => n.UcenikId == UcenikId);

            return nesto;
        }
        public async Task<IEnumerable<PohvalaResource>> pohvaleUcenikaById(int UcenikId)
        {
            var pohvaleUcenika = await _context.Pohvale.
                FromSql(
                $"select *  from dbo.Pohvale  where UcenikId = {UcenikId}"
                )
                .ToListAsync();

            return Mapper.Map<List<Pohvala>, List<PohvalaResource>>(pohvaleUcenika);
        }
        public async Task<IEnumerable<KaznaResource>> kazneUcenikaById(int UcenikId)
        {
            var kazneUcenika = await _context.Kazne.
                FromSql(
                $"select *  from dbo.Kazne  where UcenikId = {UcenikId}"
                )
                .ToListAsync();

            return Mapper.Map<List<Kazna>, List<KaznaResource>>(kazneUcenika);
        }

        public async Task<IEnumerable<VaspitnaGrupaResource>> vaspitneGrupe()
        {
            var podaciVaspitaca = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .ToListAsync();

            return Mapper.Map<List<VaspitnaGrupa>, List<VaspitnaGrupaResource>>(podaciVaspitaca);
        }

        public async Task<VaspitnaGrupaResource> vaspitneGrupeById(int id)
        {
            var vaspitnaGrupaById = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(vaspitnaGrupaById);
        }

        public async Task<VaspitnaGrupaResource> mapiranjeZaPostVaspitneGrupe(VaspitnaGrupaResource vaspitnaGrupa)
        {
            var podaciGrupe = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == vaspitnaGrupa.Id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(podaciGrupe);
        }

        public async Task<VaspitnaGrupaResource> mapiranjeZaPutGrupe(int id)
        {
            var podaciGrupe = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(podaciGrupe);
        }

        public async Task<VaspitnaGrupaResource> mapiranjeZaDeleteGrupe(VaspitnaGrupaResource vaspitnaGrupa)
        {
            var podaciGrupe = await _context.VaspitneGrupe
                .Include(v => v.Vaspitac)
                .SingleOrDefaultAsync(x => x.Id == vaspitnaGrupa.Id);

            return Mapper.Map<VaspitnaGrupa, VaspitnaGrupaResource>(podaciGrupe);
        }

        public async void updateVaspitneGrupeId(int IdObrisaneVaspitneGrupe)
        {
            var listaUcenikaIsteVaspitneGrupe = await _context.Uceniks.
            FromSql(
            $"select *  from dbo.Ucenici  where VaspitnaGrupaId = {IdObrisaneVaspitneGrupe}"
            )
            .ToListAsync();

            listaUcenikaIsteVaspitneGrupe.ForEach(a =>
            {
                a.VaspitnaGrupaId = 1;
            });

            _context.UpdateRange(listaUcenikaIsteVaspitneGrupe);
        }
    } 
}


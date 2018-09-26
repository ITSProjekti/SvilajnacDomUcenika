using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom Statistika i IStatistikaRepository interfejs
    /// Videti Repository i Statistika klasu i IStatistikaRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class StatistikaRepository : Repository<Statistika>, IStatistikaRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        public StatistikaRepository(UcenikContext context, IMapper mapper) : base(context)
        {
            _context = context;
            Mapper = mapper;
        }

        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }

        public IStatistikaRepository Statistike { get; set; }

        public async Task<IEnumerable<StatistikaResource>> podaciStatistike()
        {
            var statistika = await _context.Statistike.Include(vp => vp.VaspitnaGrupa).ToListAsync();

            return Mapper.Map<List<Statistika>, List<StatistikaResource>>(statistika);
        }

        public async Task<StatistikaResource> podaciStatistikeById(int id)
        {
            var statistika = await _context.Statistike
                .Include(vp => vp.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Mapper.Map<Statistika, StatistikaResource>(statistika);
        }

        public async Task<StatistikaResource> mapiranjeZaPostStatistike(StatistikaResource statistika)
        {
            var podaciStatistike = await _context.Statistike
                .Include(vp => vp.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == statistika.Id);

            return Mapper.Map<Statistika, StatistikaResource>(podaciStatistike);
        }

        public async Task<StatistikaResource> mapiranjeZaPutStatistike(int id)
        {
            var podaciStatistike = await _context.Statistike
                .Include(vp => vp.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Mapper.Map<Statistika, StatistikaResource>(podaciStatistike);
        }

        public async Task<StatistikaResource> mapiranjeZaDeleteStatistike(StatistikaResource statistika)
        {
            var podaciStatistike = await _context.Statistike
               .Include(vp => vp.VaspitnaGrupa)
               .SingleOrDefaultAsync(x => x.Id == statistika.Id);

            return Mapper.Map<Statistika, StatistikaResource>(podaciStatistike);
        }
        public async Task<IEnumerable<StatistikaResource>> uspehUcenikaPoVaspitnimGrupama()
        {

            /* linq koji vraca id-eve vaspitnih grupa u kojima se nalazi bar jedan ucenik, distinct sluzi
             * da nam vrati rezultat bez duplih id-eva */

            var grupeUcenika = await _context.Uceniks
                .Select(n => n.VaspitnaGrupaId)
                .Distinct().ToListAsync();


            /* linq koji vraca  redove iz statistike, onih vaspitnih grupa u kojima se nalazi bar jedan ucenik
             * koje smo prethodno selektovali sa gornjim upitom (grupeUcenika), time cemo biti sigurni da se ne selektuje
             * red u statistici cija vaspitna grupa jos nema ucenika u sebi    */

            var statistike = await _context.Statistike
                .Where(n=> grupeUcenika.Contains(n.VaspitnaGrupaId))
                .ToListAsync();

            /* linq koji vraca prosecni uspeh ucenika po vaspitnim grupama  */

            var uspehPoGrupama = _context.Uceniks
                .GroupBy(n => n.VaspitnaGrupaId)
                .Select(k => k.Average(p => p.PrethodniUspeh))
                .ToList();



            int i = 0;

            /* foreach-om prolazimo kroz sve selektovane redove iz tabele statistika
             * i propertiju UspehVaspitneGrupe dodeljuje prethodno izracunati prosek ucenika po vaspitnim grupama*/

            foreach (var item in statistike)
                item.UspehVaspitneGrupe = uspehPoGrupama[i++];
            
            return Mapper.Map<List<Statistika>, List<StatistikaResource>>(statistike);
        }







    }
}

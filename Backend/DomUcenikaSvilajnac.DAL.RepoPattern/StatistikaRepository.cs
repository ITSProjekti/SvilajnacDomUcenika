using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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






        }
}

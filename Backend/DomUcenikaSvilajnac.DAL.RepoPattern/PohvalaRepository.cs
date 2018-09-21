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
    /// Nasledjuje genericku klasu Repository sa tipom Pohvala i IPohvalaRepository interfejs
    /// Videti Repository i Pohvala klasu i IPohvalaRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class PohvalaRepository : Repository<Pohvala>, IPohvalaRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        public PohvalaRepository(UcenikContext context, IMapper mapper) : base(context)
        {
            _context = context;
            Mapper = mapper;
        }

        public IPohvalaRepository Pohvale { get; set; }

        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
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
    }
}

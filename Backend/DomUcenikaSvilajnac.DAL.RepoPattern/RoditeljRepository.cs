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
    /// Nasledjuje genericku klasu Repository sa tipom Roditelj i IRoditeljRepository interfejs
    /// Videti Repository i Roditelj klasu i IRoditeljRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class RoditeljRepository : Repository<Roditelj>, IRoditeljRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        
        public RoditeljRepository(UcenikContext context, IMapper mapper) : base(context)
        {
            _context = context;
            Mapper = mapper;
        }
        public IRoditeljRepository Roditelji { get; set; }

        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }

        public async Task<IEnumerable<RoditeljResource>> spremaRoditelja()
        {
            var spremaRoditelja = await _context.Roditelji
                .Include(sss => sss.StepenObrazovanja)
                .ToListAsync();
            return Mapper.Map<List<Roditelj>, List<RoditeljResource>>(spremaRoditelja);
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
    }
}

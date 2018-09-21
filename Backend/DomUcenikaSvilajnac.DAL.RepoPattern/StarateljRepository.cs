using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom Staratelj i IStarateljRepository interfejs
    /// Videti Repository i Staratelj klasu i IStarateljRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class StarateljRepository : Repository<Staratelj>, IStarateljRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        public StarateljRepository(UcenikContext context, IMapper mapper) : base(context)
        {
            _context = context;
            Mapper = mapper;
        }

        public IStarateljRepository Staratelji { get; set; }
        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }

        public async Task<Staratelj> selektIdStarateljaUcenika(int UcenikId)
        {
            var nesto = await _context.Staratelji.SingleOrDefaultAsync(n => n.UcenikId == UcenikId);

            return nesto;
        }
    }
}

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
    public class OpstinaRepository : Repository<Opstina>, IOpstinaRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        /// <summary>
        /// Nasledjuje genericku klasu Repository sa tipom Opstina i IOpstinaRepository interfejs
        /// Videti Repository i Opstina klasu i IOpstinaRepository interfejs radi dodatnog pojasnjena.
        /// </summary>
        public OpstinaRepository(UcenikContext context, IMapper mapper ) : base (context)
        {
            _context = context;
            Mapper = mapper;
        }

        public IOpstinaRepository Opstine { get; set; }
        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
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
    }
}

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
    /// Nasledjuje genericku klasu Repository sa tipom Sastanak i ISastanakRepository interfejs
    /// Videti Repository i Sastanak klasu i ISastanakRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class SastanakRepository : Repository<Sastanak>, ISastanakRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        public SastanakRepository(UcenikContext context, IMapper mapper) : base(context)
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


        public async Task<IEnumerable<SastanakResource>> sviSastanci()
        {
            var podaciSastanaka = await _context.Sastanci
                .Include(v => v.VaspitnaGrupa)
                .ToListAsync();

            return Mapper.Map<List<Sastanak>, List<SastanakResource>>(podaciSastanaka);
        }
        public async Task<SastanakResource> sastanakById(int id)
        {
            var podaciSastanak = await _context.Sastanci
                .Include(v => v.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == id);
            return Mapper.Map<Sastanak, SastanakResource>(podaciSastanak);
        }

        public async Task<SastanakResource> mapiranjeZaPostSastanka(SastanakResource sastanak)
        {
            var podaciSastanka = await _context.Sastanci
                .Include(v => v.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == sastanak.Id);

            return Mapper.Map<Sastanak, SastanakResource>(podaciSastanka);
        }
        public async Task<SastanakResource> mapiranjeZaPutSastanka(int id)
        {
            var podaciSastanka = await _context.Sastanci
                .Include(v => v.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == id);

            return Mapper.Map<Sastanak, SastanakResource>(podaciSastanka);
        }

        public async Task<SastanakResource> mapiranjeZaDeleteSastanka(SastanakResource sastanak)
        {
            var podaciSastanka = await _context.Sastanci
                .Include(v => v.VaspitnaGrupa)
                .SingleOrDefaultAsync(x => x.Id == sastanak.Id);

            return Mapper.Map<Sastanak, SastanakResource>(podaciSastanka);
        }
    }
}

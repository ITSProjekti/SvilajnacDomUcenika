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
   public class KaznaRepository : Repository<Kazna>, IKaznaRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        public KaznaRepository(UcenikContext context, IMapper mapper) : base(context)
        {
            _context = context;
            Mapper = mapper;
        }

        public IKaznaRepository Kazne { get; set; }

        public UcenikContext context
        {
            get { return context as UcenikContext; }
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
    }
}

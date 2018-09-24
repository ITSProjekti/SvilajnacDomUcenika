using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom Vaspitac i IVaspitacRepository interfejs
    /// Videti Repository i Vaspitac klasu i IVaspitacRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class VaspitacRepository : Repository<Vaspitac>, IVaspitacRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        public IVaspitnaGrupaRepository VaspitneGrupe { get; set; }

        public VaspitacRepository(UcenikContext context, IMapper mapper) : base(context)
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

        public async void updateVaspitaca(int ObrisanVaspitacId)
        {
            var vaspitnaGrupaObrisanogVaspitaca = await context.VaspitneGrupe.
                FromSql(
                $"select * from dbo.VaspitneGrupe where VaspitacId = {ObrisanVaspitacId}"
                ).ToListAsync();

            vaspitnaGrupaObrisanogVaspitaca.ForEach(v =>
            {
                v.VaspitacId = 1;
            });

            context.UpdateRange(vaspitnaGrupaObrisanogVaspitaca);
        }
    }
}

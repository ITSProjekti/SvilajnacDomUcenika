using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom Mesto i IMestoRepository interfejs
    /// Videti Repository i Mesto klasu i IMestoRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class MestoRepository : Repository<Mesto>, IMestoRepository
    {
       
        public MestoRepository(UcenikContext context) : base(context)
        {

        }

        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }

    }
}

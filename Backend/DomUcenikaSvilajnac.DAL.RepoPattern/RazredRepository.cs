using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom Razred i IRazredRepository interfejs
    /// Videti Repository i Razred klasu i IRazredRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    class RazredRepository : Repository<Razred>, IRazredRepository
    {
        
        public RazredRepository(UcenikContext context) : base(context)
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

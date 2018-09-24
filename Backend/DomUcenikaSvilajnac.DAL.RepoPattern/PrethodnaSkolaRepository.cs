using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom PrethodnaSkola i IPrethodnaSkolaRepository interfejs
    /// Videti Repository i PrethodnaSkola klasu i IPrethodnaSkolaRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class PrethodnaSkolaRepository : Repository<PrethodnaSkola>, IPrethodnaSkolaRepository
    {
        
        public PrethodnaSkolaRepository(UcenikContext context): base(context)
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

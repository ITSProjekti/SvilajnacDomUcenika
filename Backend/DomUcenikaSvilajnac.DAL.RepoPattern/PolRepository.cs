using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class PolRepository : Repository<Pol>, IPolRepository
    {
        /// <summary>
        /// Nasledjuje genericku klasu Repository sa tipom Pol i IPolRepository interfejs
        /// Videti Repository i Pol klasu i IPolRepository interfejs radi dodatnog pojasnjena.
        /// </summary>
        public PolRepository(UcenikContext context) : base(context)
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

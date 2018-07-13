using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class RoditeljRepository : Repository<Roditelj>, IRoditeljRepository
    {
        /// <summary>
        /// Nasledjuje genericku klasu Repository sa tipom Roditelj i IRoditeljRepository interfejs
        /// Videti Repository i Roditelj klasu i IRoditeljRepository interfejs radi dodatnog pojasnjena.
        /// </summary>
        public RoditeljRepository(UcenikContext context) : base(context)
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

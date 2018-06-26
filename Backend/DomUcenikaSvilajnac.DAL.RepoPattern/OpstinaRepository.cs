using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class OpstinaRepository : Repository<Opstina>, IOpstinaRepository
    {
        /// <summary>
        /// Nasledjuje genericku klasu Repository sa tipom Opstina i IOpstinaRepository interfejs
        /// Videti Repository i Opstina klasu i IOpstinaRepository interfejs radi dodatnog pojasnjena.
        /// </summary>
        public OpstinaRepository(UcenikContext context ) : base (context)
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

using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class UpisanaSkolaRepository : Repository<UpisanaSkola>, IUpisanaSkola
    {
        /// <summary>
        /// Nasledjuje genericku klasu Repository sa tipom UpisanaSkola i IUpisanaSkolaRepository interfejs
        /// Videti Repository i UpisanaSkola klasu i IUpisanaSkolaRepository interfejs radi dodatnog pojasnjena.
        /// </summary>
        public UpisanaSkolaRepository(UcenikContext context) : base(context)
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

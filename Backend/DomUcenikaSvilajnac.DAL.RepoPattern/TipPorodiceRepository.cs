using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom TipPorodice i ITipPorodiceRepository interfejs
    /// Videti Repository i TipPorodice klasu i ITipPorodiceRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class TipPorodiceRepository : Repository<TipPorodice>, ITipPorodiceRepository
    {
        public TipPorodiceRepository(UcenikContext context) : base(context)
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

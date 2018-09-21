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
    /// Nasledjuje genericku klasu Repository sa tipom StepenStrucneSpreme i IStepenStrucneSpremeRepository interfejs
    /// Videti Repository i StepenStrucneSpreme klasu i IStepenStrucneSpremeRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class StepenStrucneSpremeRepository : Repository<StepenStrucneSpreme>, IStepenStrucneSpremeRepository
    {
       
        public StepenStrucneSpremeRepository(UcenikContext context) : base(context)
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

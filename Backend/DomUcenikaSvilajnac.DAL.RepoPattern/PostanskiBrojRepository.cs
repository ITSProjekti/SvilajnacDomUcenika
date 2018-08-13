using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class PostanskiBrojRepository : Repository<PostanskiBroj>, IPostanskiBrojRepository
    {
        /// <summary>
        /// Nasledjuje genericku klasu Repository sa tipom PostanskiBroj i IPostanskiBrojRepository interfejs
        /// Videti Repository i PostanskiBroj klasu i IPostanskiBrojRepository interfejs radi dodatnog pojasnjena.
        /// </summary>
        public PostanskiBrojRepository(UcenikContext context) : base(context)
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

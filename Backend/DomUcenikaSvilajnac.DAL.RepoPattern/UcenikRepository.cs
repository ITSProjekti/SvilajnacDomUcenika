using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using System;
using System.Collections.Generic;
using System.Text;


namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    /// <summary>
    /// Nasledjuje genericku klasu Repository sa tipom Ucenik i IUcenikRepository interfejs
    /// Videti Repository i Ucenik klasu i IUcenikRepository interfejs radi dodatnog pojasnjena.
    /// </summary>
    public class UcenikRepository: Repository<Ucenik>,IUcenikRepository
    {
        /// <summary>
        /// Inicijalizacije instance klase UcenikRepository.
        /// </summary>
        public UcenikRepository(UcenikContext context):base(context)
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

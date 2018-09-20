using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public  class TelefonRepository : Repository<Telefon>, ITelefonRepository
    {
        protected readonly UcenikContext _context;
        public IMapper Mapper { get; }
        /// <summary>
        /// <summary>
        /// Nasledjuje genericku klasu Repository sa tipom Telefon i ITelefonRepository interfejs
        /// Videti Repository i Telefon klasu i ITelefonRepository interfejs radi dodatnog pojasnjena.
        /// </summary>
        public TelefonRepository(UcenikContext context, IMapper mapper) : base(context)
        {
            _context = context;
            Mapper = mapper;
        }

        public ITelefonRepository Telefoni { get; set; }

        /// <summary>
        /// Get the context.
        /// </summary>
        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }
        public void deleteTelefon(Telefon telefon)
        {
            _context.Telefoni.Remove(telefon);
        }
    }
}

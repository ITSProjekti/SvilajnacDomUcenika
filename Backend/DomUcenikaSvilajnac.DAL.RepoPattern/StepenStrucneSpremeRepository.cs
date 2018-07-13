using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class StepenStrucneSpremeRepository : Repository<StepenStrucneSpreme>, IStepenStrucneSpremeRepository
    {
        public StepenStrucneSpremeRepository(UcenikContext context) : base(context)
        {
        }

        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }
    }
}

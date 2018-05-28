using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using System;
using System.Collections.Generic;
using System.Text;


namespace DomUcenikaSvilajnac.DAL.RepoPattern
{
    public class UcenikRepository: Repository<Ucenik>,IUcenikRepository
    {
        public UcenikRepository(UcenikContext context):base(context)
        {

        }
        public UcenikContext context
        {
            get { return context as UcenikContext; }
        }
        

    }
}

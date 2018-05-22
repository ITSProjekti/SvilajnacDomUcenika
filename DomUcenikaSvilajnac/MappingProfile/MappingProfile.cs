using AutoMapper;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.ModelResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Ucenik, UcenikResource>();
        }
    }
}

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
            CreateMap<UcenikResource, Ucenik>()
                .ForMember(v => v.DatumRodjenja, opt => opt.MapFrom(src => new DateTime(src.Godina, src.Mesec, src.Dan+1).ToUniversalTime()));
            CreateMap<Ucenik, UcenikResource>()
                .ForMember(v => v.Godina, opt => opt.MapFrom(src => src.DatumRodjenja.Year))
                .ForMember(v => v.Dan, opt => opt.MapFrom(src => src.DatumRodjenja.Day))
                .ForMember(v => v.Mesec, opt => opt.MapFrom(src => src.DatumRodjenja.Month));



        }
    }
}

using AutoMapper;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.ModelResources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomUcenikaSvilajnac.Mapping
{
    /// <summary>
    /// Klasa za mapiranje.
    /// </summary>
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //mapira UcenikResource u Ucenik, odnosno omogucava da se datum unese putem jedne promenljive DatumRodjenja.
            CreateMap<UcenikResource, Ucenik>()
                .ForMember(v => v.DatumRodjenja, opt => opt.MapFrom(src => new DateTime(src.Godina, src.Mesec, src.Dan+1).ToUniversalTime()));
            //mapira Ucenik u UcenikResource, odnosno omogucava da se datum unese putem tri promenljive, Dan, Mesec, Godina.
            CreateMap<Ucenik, UcenikResource>()
                .ForMember(v => v.Godina, opt => opt.MapFrom(src => src.DatumRodjenja.Year))
                .ForMember(v => v.Dan, opt => opt.MapFrom(src => src.DatumRodjenja.Day))
                .ForMember(v => v.Mesec, opt => opt.MapFrom(src => src.DatumRodjenja.Month));


            //CreateMap<Ucenik, MestoResource>();

            //CreateMap<MestoResource, Ucenik>();
        }
    }
}

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
                .ForMember(v => v.DatumRodjenja, opt => opt.MapFrom(src => new DateTime(src.Godina, src.Mesec, src.Dan).ToUniversalTime()));
  

           // Mapper.CreateMap<enquiryListEntry, EnquiriesListViewModel>()
   // .ForMember(dest => dest.flightDate, opt.MapFrom(src => new DateTime(src.flightYear, src.flightMonth, src.flightDay)));
        }
    }
}

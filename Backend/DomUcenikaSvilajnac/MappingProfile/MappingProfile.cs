using AutoMapper;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
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
                .ForMember(v => v.DatumRodjenja, opt => opt.MapFrom(src => new DateTime(src.Godina, src.Mesec, src.Dan + 1).ToUniversalTime()));
            //mapira Ucenik u UcenikResource, odnosno omogucava da se datum unese putem tri promenljive, Dan, Mesec, Godina.
            CreateMap<Ucenik, UcenikResource>()
                .ForMember(v => v.Godina, opt => opt.MapFrom(src => src.DatumRodjenja.Year))
                .ForMember(v => v.Dan, opt => opt.MapFrom(src => src.DatumRodjenja.Day))
                .ForMember(v => v.Mesec, opt => opt.MapFrom(src => src.DatumRodjenja.Month));


            // CreateMap<OpstinaResource, Opstina>();


            CreateMap<PostanskiBrojResource, PostanskiBroj>();
            CreateMap<Razred, RazredResource>();



            CreateMap<RoditeljResource, Roditelj>()
               .ForMember(v => v.Ime, opt => opt.MapFrom(src => src.ImeOca))
               .ForMember(v => v.Prezime, opt => opt.MapFrom(src => src.PrezimeOca));

            CreateMap<Roditelj, RoditeljResource>()
              .ForMember(v => v.ImeOca, opt => opt.MapFrom(src => src.Ime))
              .ForMember(v => v.PrezimeOca, opt => opt.MapFrom(src => src.Prezime))
              .ForMember(v => v.ImeMajke, opt => opt.MapFrom(src => src.Ime))
              .ForMember(v => v.PrezimeMajke, opt => opt.MapFrom(src => src.Prezime));

            CreateMap<List<Roditelj>, RoditeljResource>()
                .ForMember(v => v.ImeOca, opt => opt.MapFrom(src => src[1].Ime))
             .ForMember(v => v.PrezimeOca, opt => opt.MapFrom(src => src[1].Prezime))
              .ForMember(v => v.ImeMajke, opt => opt.MapFrom(src => src[0].Ime))
             .ForMember(v => v.PrezimeMajke, opt => opt.MapFrom(src => src[0].Prezime))
            .ForMember(v => v.Id, opt => opt.MapFrom(src => src[1].Id))
            .ForMember(v => v.IdMajke, opt => opt.MapFrom(src => src[0].Id));


            CreateMap<List<Roditelj>, List<RoditeljResource>>()
            .AfterMap((roditelj, resurs) =>
            {
                for (int i = 0; i <= roditelj.Count-2; i++)
                {
                    for (int j = i; j <= i; j++)
                    {
                        if (i >= 1)
                        {
                            i++;
                            j++;
                        }
                        RoditeljResource nesto = new RoditeljResource()
                        {
                            IdMajke = roditelj[i].Id,
                            ImeMajke = roditelj[i].Ime,
                            PrezimeMajke = roditelj[i].Prezime,

                            Id = roditelj[j+1].Id,
                            ImeOca = roditelj[j+1].Ime,
                            PrezimeOca = roditelj[j+1].Prezime
                        };
                        resurs.Add(nesto);
                    }
                }
            });
        }
    }
}

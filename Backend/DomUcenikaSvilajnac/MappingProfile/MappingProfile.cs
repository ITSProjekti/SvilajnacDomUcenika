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
                .ForMember(v => v.DatumRodjenja, opt => opt.MapFrom(src => new DateTime(src.Godina, src.Mesec, src.Dan + 1).ToUniversalTime()))
                .ForMember(v => v.UpisanaSkola, opt => opt.MapFrom(src => new UpisanaSkola() { NazivSrednjeSkole = src.UpisanaSkola.NazivSrednjeSkole, Id = src.UpisanaSkola.Id, OpstinaId = src.UpisanaSkola.OpstinaId }))
                .ForMember(v => v.PrethodnaSkola, opt => opt.MapFrom(src => new PrethodnaSkola() { NazivPrethodneSkole = src.PrethodnaSkola.NazivPrethodneSkole, Id = src.PrethodnaSkola.Id, OpstinaId = src.PrethodnaSkola.OpstinaId }))
                .ForMember(v => v.PostanskiBroj, opt => opt.MapFrom(src => new PostanskiBroj() { Broj = src.PostanskiBroj.Broj, Id = src.PostanskiBroj.Id, OpstinaId = src.PostanskiBroj.Id }))
                .ForMember(v => v.Opstina, opt => opt.MapFrom(src => new Opstina() { NazivOpstine = src.Opstina.NazivOpstine, Id = src.Opstina.Id }))
                .ForMember(v => v.OpstinaPrebivalista, opt => opt.MapFrom(src => new Opstina() { NazivOpstine = src.OpstinaPrebivalista.NazivOpstine, Id = src.OpstinaPrebivalista.Id }))
                .ForMember(v => v.MestoRodjenja, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoRodjenja.Id, NazivMesta = src.MestoRodjenja.NazivMesta }))
                .ForMember(v => v.MestoPrebivalista, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoPrebivalista.Id, NazivMesta = src.MestoPrebivalista.NazivMesta }))
                .ForMember(v => v.MestoZavrseneSkole, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoZavrseneSkole.Id, NazivMesta = src.MestoZavrseneSkole.NazivMesta }))
                .ForMember(v => v.Pol, opt => opt.MapFrom(src => new Pol() { Id = src.Pol.Id, NazivPola = src.Pol.NazivPola }));
                




            //mapira Ucenik u UcenikResource, odnosno omogucava da se datum unese putem tri promenljive, Dan, Mesec, Godina.
            CreateMap<Ucenik, UcenikResource>()
                .ForMember(v => v.Godina, opt => opt.MapFrom(src => src.DatumRodjenja.Year))
                .ForMember(v => v.Dan, opt => opt.MapFrom(src => src.DatumRodjenja.Day))
                .ForMember(v => v.Mesec, opt => opt.MapFrom(src => src.DatumRodjenja.Month));

            CreateMap<Roditelj, RoditeljiUcenikaResource>();

            CreateMap<RoditeljiUcenikaResource, Roditelj>();





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
              .ForMember(v => v.PrezimeMajke, opt => opt.MapFrom(src => src.Prezime))
              .ForMember(v => v.UcenikId, opt => opt.MapFrom(src => src.UcenikId));

            CreateMap<List<Roditelj>, RoditeljResource>()
                .ForMember(v => v.ImeOca, opt => opt.MapFrom(src => src[1].Ime))
             .ForMember(v => v.PrezimeOca, opt => opt.MapFrom(src => src[1].Prezime))
              .ForMember(v => v.ImeMajke, opt => opt.MapFrom(src => src[0].Ime))
               .ForMember(v => v.UcenikId, opt => opt.MapFrom(src => src[0].UcenikId))
             .ForMember(v => v.PrezimeMajke, opt => opt.MapFrom(src => src[0].Prezime))
            .ForMember(v => v.Id, opt => opt.MapFrom(src => src[1].Id))
            .ForMember(v => v.IdMajke, opt => opt.MapFrom(src => src[0].Id))
             .ForMember(v => v.UcenikId, opt => opt.MapFrom(src => src[1].UcenikId));



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

                            Id = roditelj[j + 1].Id,
                            ImeOca = roditelj[j + 1].Ime,
                            PrezimeOca = roditelj[j + 1].Prezime,
                            UcenikId = roditelj[i].UcenikId
                        };
                        resurs.Add(nesto);
                    }
                }
            });
        }
    }
}

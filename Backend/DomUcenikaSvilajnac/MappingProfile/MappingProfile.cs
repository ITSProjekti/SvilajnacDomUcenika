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

            //mapira PostUcenikaResource u Ucenik, odnosno omogucava da se datum unese putem jedne promenljive DatumRodjenja.
            CreateMap<PostUcenikaResource, Ucenik>()
                .ForMember(v => v.DatumRodjenja, opt => opt.MapFrom(src => new DateTime(src.Godina, src.Mesec, src.Dan + 1).ToUniversalTime()))
                .ForMember(v => v.UpisanaSkola, opt => opt.MapFrom(src => new UpisanaSkola() { NazivSrednjeSkole = src.UpisanaSkola.NazivSrednjeSkole, Id = src.UpisanaSkola.Id, OpstinaId = src.UpisanaSkola.OpstinaId }))
                .ForMember(v => v.PrethodnaSkola, opt => opt.MapFrom(src => new PrethodnaSkola() { NazivPrethodneSkole = src.PrethodnaSkola.NazivPrethodneSkole, Id = src.PrethodnaSkola.Id, OpstinaId = src.PrethodnaSkola.OpstinaId }))
                .ForMember(v => v.PostanskiBroj, opt => opt.MapFrom(src => new PostanskiBroj() { Broj = src.PostanskiBroj.Broj, Id = src.PostanskiBroj.Id, OpstinaId = src.PostanskiBroj.Id }))
                .ForMember(v => v.Opstina, opt => opt.MapFrom(src => new Opstina() { NazivOpstine = src.Opstina.NazivOpstine, Id = src.Opstina.Id }))
                .ForMember(v => v.OpstinaPrebivalista, opt => opt.MapFrom(src => new Opstina() { NazivOpstine = src.OpstinaPrebivalista.NazivOpstine, Id = src.OpstinaPrebivalista.Id }))
                .ForMember(v => v.MestoRodjenja, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoRodjenja.Id, NazivMesta = src.MestoRodjenja.NazivMesta }))
                .ForMember(v => v.MestoPrebivalista, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoPrebivalista.Id, NazivMesta = src.MestoPrebivalista.NazivMesta }))
                .ForMember(v => v.MestoZavrseneSkole, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoZavrseneSkole.Id, NazivMesta = src.MestoZavrseneSkole.NazivMesta }))
                .ForMember(v => v.Pol, opt => opt.MapFrom(src => new Pol() { Id = src.Pol.Id, NazivPola = src.Pol.NazivPola }))
                .ForMember(v => v.Roditelji, opt => opt.Ignore());





            //mapira Ucenik u PostUcenikaResource, odnosno omogucava da se datum unese putem tri promenljive, Dan, Mesec, Godina.
            CreateMap<Ucenik, PostUcenikaResource>()
                .ForMember(v => v.Godina, opt => opt.MapFrom(src => src.DatumRodjenja.Year))
                .ForMember(v => v.Dan, opt => opt.MapFrom(src => src.DatumRodjenja.Day))
                .ForMember(v => v.Mesec, opt => opt.MapFrom(src => src.DatumRodjenja.Month))
                .ForMember(v => v.Roditelji, opt => opt.MapFrom(src => new PostRoditeljaResource() {
                                                                    Id = src.Roditelji[1].Id,
                                                                    IdMajke = src.Roditelji[0].Id,
                                                                    ImeMajke = src.Roditelji[0].Ime,
                                                                    PrezimeMajke = src.Roditelji[0].Prezime,
                                                                    BrojTelefonaMajke = src.Roditelji[0].BrojTelefona,
                                                                    UcenikId = src.Roditelji[0].UcenikId,
                                                                    StrucnaSpremaMajkeId = src.Roditelji[0].StepenObrazovanjaId,
                                                                    ImeOca = src.Roditelji[1].Ime,
                                                                    PrezimeOca = src.Roditelji[1].Prezime,
                                                                    BrojTelefonaOca = src.Roditelji[1].BrojTelefona,
                                                                    StrucnaSpremaOcaId = src.Roditelji[1].StepenObrazovanjaId,
                                                                       }
                ));




            CreateMap<PutUcenikaResource, Ucenik>()
                .ForMember(v => v.DatumRodjenja, opt => opt.MapFrom(src => new DateTime(src.Godina, src.Mesec, src.Dan + 1).ToUniversalTime()))
                .ForMember(v => v.UpisanaSkola, opt => opt.MapFrom(src => new UpisanaSkola() { NazivSrednjeSkole = src.UpisanaSkola.NazivSrednjeSkole, Id = src.UpisanaSkola.Id, OpstinaId = src.UpisanaSkola.OpstinaId }))
                .ForMember(v => v.PrethodnaSkola, opt => opt.MapFrom(src => new PrethodnaSkola() { NazivPrethodneSkole = src.PrethodnaSkola.NazivPrethodneSkole, Id = src.PrethodnaSkola.Id, OpstinaId = src.PrethodnaSkola.OpstinaId }))
                .ForMember(v => v.PostanskiBroj, opt => opt.MapFrom(src => new PostanskiBroj() { Broj = src.PostanskiBroj.Broj, Id = src.PostanskiBroj.Id, OpstinaId = src.PostanskiBroj.Id }))
                .ForMember(v => v.Opstina, opt => opt.MapFrom(src => new Opstina() { NazivOpstine = src.Opstina.NazivOpstine, Id = src.Opstina.Id }))
                .ForMember(v => v.OpstinaPrebivalista, opt => opt.MapFrom(src => new Opstina() { NazivOpstine = src.OpstinaPrebivalista.NazivOpstine, Id = src.OpstinaPrebivalista.Id }))
                .ForMember(v => v.MestoRodjenja, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoRodjenja.Id, NazivMesta = src.MestoRodjenja.NazivMesta }))
                .ForMember(v => v.MestoPrebivalista, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoPrebivalista.Id, NazivMesta = src.MestoPrebivalista.NazivMesta }))
                .ForMember(v => v.MestoZavrseneSkole, opt => opt.MapFrom(src => new Mesto() { Id = src.MestoZavrseneSkole.Id, NazivMesta = src.MestoZavrseneSkole.NazivMesta }))
                .ForMember(v => v.Pol, opt => opt.MapFrom(src => new Pol() { Id = src.Pol.Id, NazivPola = src.Pol.NazivPola }))
                .ForMember(v => v.Roditelji, opt => opt.Ignore())
                .ForMember(v => v.Telefon, opt => opt.Ignore());





            //mapira Ucenik u PostUcenikaResource, odnosno omogucava da se datum unese putem tri promenljive, Dan, Mesec, Godina.
            CreateMap<Ucenik, PutUcenikaResource>()
                .ForMember(v => v.Godina, opt => opt.MapFrom(src => src.DatumRodjenja.Year))
                .ForMember(v => v.Dan, opt => opt.MapFrom(src => src.DatumRodjenja.Day))
                .ForMember(v => v.Mesec, opt => opt.MapFrom(src => src.DatumRodjenja.Month))
                .ForMember(v => v.Roditelji, opt => opt.MapFrom(src => new PostRoditeljaResource()
                {
                    Id = src.Roditelji[1].Id,
                    IdMajke = src.Roditelji[0].Id,
                    ImeMajke = src.Roditelji[0].Ime,
                    PrezimeMajke = src.Roditelji[0].Prezime,
                    BrojTelefonaMajke = src.Roditelji[0].BrojTelefona,
                    UcenikId = src.Roditelji[0].UcenikId,
                    StrucnaSpremaMajkeId = src.Roditelji[0].StepenObrazovanjaId,
                    ImeOca = src.Roditelji[1].Ime,
                    PrezimeOca = src.Roditelji[1].Prezime,
                    BrojTelefonaOca = src.Roditelji[1].BrojTelefona,
                    StrucnaSpremaOcaId = src.Roditelji[1].StepenObrazovanjaId,
                }
                ));


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
             .ForMember(v => v.UcenikId, opt => opt.MapFrom(src => src[1].UcenikId))
             .ForMember(v => v.StrucnaSpremaMajke, opt => opt.MapFrom(src => src[0].StepenObrazovanja.Opis))
             .ForMember(v => v.StrucnaSpremaOca, opt => opt.MapFrom(src => src[1].StepenObrazovanja.Opis));



            CreateMap<List<Roditelj>, List<RoditeljResource>>()
            .AfterMap((roditelj, resurs) =>
            {
                for (int i = 0; i <= roditelj.Count - 2; i++)
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
                          StrucnaSpremaMajke = roditelj[i].StepenObrazovanja.Stepen,
                            BrojTelefonaMajke = roditelj[i].BrojTelefona,

                            Id = roditelj[j + 1].Id,
                            ImeOca = roditelj[j + 1].Ime,
                            PrezimeOca = roditelj[j + 1].Prezime,
                           StrucnaSpremaOca = roditelj[j + 1].StepenObrazovanja.Stepen,
                            UcenikId = roditelj[i].UcenikId,
                            BrojTelefonaOca = roditelj[j+1].BrojTelefona
                        };
                        resurs.Add(nesto);
                    }
                }
            });
            CreateMap<List<RoditeljResource>, List<Roditelj>>()
            .AfterMap((resurs, roditelj) =>
            {
                StepenStrucneSpreme stepenMajke = new StepenStrucneSpreme() { Id = resurs[0].IdMajke, Opis = resurs[0].StrucnaSpremaMajke };
                StepenStrucneSpreme stepenOca = new StepenStrucneSpreme() { Id = resurs[0].Id, Opis = resurs[0].StrucnaSpremaOca };


                Roditelj nesto = new Roditelj()
                {

                    Ime = resurs[0].ImeMajke,
                    Prezime = resurs[0].PrezimeMajke,
                    StepenObrazovanja = stepenMajke,
                    StepenObrazovanjaId = stepenMajke.Id,


                    UcenikId = resurs[0].UcenikId
                };
                Roditelj majka = new Roditelj()
                {

                    Ime = resurs[0].ImeOca,
                    Prezime = resurs[0].PrezimeOca,
                    StepenObrazovanja = stepenOca,
                    StepenObrazovanjaId = stepenOca.Id,
                    UcenikId = resurs[0].UcenikId
                };
                roditelj.Add(majka);
                roditelj.Add(nesto);

            });



            CreateMap<List<Roditelj>, List<DeleteRoditeljaResource>>()
           .AfterMap((roditelj, resurs) =>
           {
               for (int i = 0; i <= roditelj.Count - 2; i++)
               {
                   for (int j = i; j <= i; j++)
                   {
                       if (i >= 1)
                       {
                           i++;
                           j++;
                       }
                       DeleteRoditeljaResource nesto = new DeleteRoditeljaResource()
                       {
                           IdMajke = roditelj[i].Id,
                           ImeMajke = roditelj[i].Ime,
                           PrezimeMajke = roditelj[i].Prezime,
                            BrojTelefonaMajke = roditelj[i].BrojTelefona,

                           Id = roditelj[j + 1].Id,
                           ImeOca = roditelj[j + 1].Ime,
                           PrezimeOca = roditelj[j + 1].Prezime,
                            UcenikId = roditelj[i].UcenikId,
                           BrojTelefonaOca = roditelj[j + 1].BrojTelefona
                       };
                       resurs.Add(nesto);
                   }
               }
           });



            CreateMap<PostRoditeljaResource, Roditelj>()
             .ForMember(v => v.Ime, opt => opt.MapFrom(src => src.ImeOca))
             .ForMember(v => v.Prezime, opt => opt.MapFrom(src => src.PrezimeOca))
             .ForMember(v => v.StepenObrazovanjaId, opt => opt.MapFrom(src => src.StrucnaSpremaOcaId))
              .ForMember(v => v.BrojTelefona, opt => opt.MapFrom(src => src.BrojTelefonaOca));


            CreateMap<List<Roditelj>, PostRoditeljaResource>()
                 .ForMember(v => v.ImeOca, opt => opt.MapFrom(src => src[1].Ime))
             .ForMember(v => v.PrezimeOca, opt => opt.MapFrom(src => src[1].Prezime))
              .ForMember(v => v.ImeMajke, opt => opt.MapFrom(src => src[0].Ime))
               .ForMember(v => v.UcenikId, opt => opt.MapFrom(src => src[0].UcenikId))
             .ForMember(v => v.PrezimeMajke, opt => opt.MapFrom(src => src[0].Prezime))
            .ForMember(v => v.Id, opt => opt.MapFrom(src => src[1].Id))
            .ForMember(v => v.IdMajke, opt => opt.MapFrom(src => src[0].Id))
             .ForMember(v => v.UcenikId, opt => opt.MapFrom(src => src[1].UcenikId))
             .ForMember(v => v.StrucnaSpremaMajkeId, opt => opt.MapFrom(src => src[0].StepenObrazovanjaId))
             .ForMember(v => v.StrucnaSpremaOcaId, opt => opt.MapFrom(src => src[1].StepenObrazovanjaId))
             .ForMember(v => v.BrojTelefonaMajke, opt => opt.MapFrom(src => src[0].BrojTelefona))
             .ForMember(v => v.BrojTelefonaOca, opt => opt.MapFrom(src => src[1].BrojTelefona));


            CreateMap<PutRoditeljaResource, Roditelj>();
            CreateMap<Roditelj, PutRoditeljaResource>();
        }
    }
}

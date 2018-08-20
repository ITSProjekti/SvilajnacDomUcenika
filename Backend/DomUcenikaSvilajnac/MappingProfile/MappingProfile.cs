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

           

            //mapira Ucenik u UcenikResource, odnosno omogucava da se datum unese putem tri promenljive, Dan, Mesec, Godina.
            CreateMap<Ucenik, UcenikResource>()
                .ForMember(v => v.Godina, opt => opt.MapFrom(src => src.DatumRodjenja.Year))
                .ForMember(v => v.Dan, opt => opt.MapFrom(src => src.DatumRodjenja.Day))
                .ForMember(v => v.Mesec, opt => opt.MapFrom(src => src.DatumRodjenja.Month))
                 .ForMember(v => v.Staratelji, opt => opt.MapFrom(src => new StarateljResource()
                 {
                     Id = src.Staratelji[0].Id,
                     Ime = src.Staratelji[0].Ime,
                     Prezime = src.Staratelji[0].Prezime,
                     UcenikId = src.Staratelji[0].UcenikId
                 }));

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
           .ForMember(v => v.Pol, opt => opt.MapFrom(src => new Pol() { Id = src.Pol.Id, NazivPola = src.Pol.NazivPola }))
           .ForMember(v => v.VremeUpisa, opt => opt.Ignore())
           .ForMember(v => v.Staratelji, opt => opt.Ignore());
            ;


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
                .ForMember(v => v.Roditelji, opt => opt.Ignore())
                .ForMember(v => v.Opstina, opt => opt.Ignore())
                .ForMember(v => v.DrzavaRodjenja, opt => opt.Ignore())
                .ForMember(v => v.OpstinaPrebivalista, opt => opt.Ignore())
                .ForMember(v => v.Pol, opt => opt.Ignore())
                .ForMember(v => v.PostanskiBroj, opt => opt.Ignore())
                .ForMember(v => v.MestoPrebivalista, opt => opt.Ignore())
                .ForMember(v => v.MestoRodjenja, opt => opt.Ignore())
                .ForMember(v => v.MestoZavrseneSkole, opt => opt.Ignore())
                .ForMember(v => v.PrethodnaSkola, opt => opt.Ignore())
                .ForMember(v => v.UpisanaSkola, opt => opt.Ignore())
                .ForMember(v => v.Smer, opt => opt.Ignore())
                .ForMember(v => v.VremeUpisa, opt => opt.Ignore())
                .ForMember(v => v.Razred, opt => opt.Ignore())
                .ForMember(v => v.TipPorodice, opt => opt.Ignore())
                .ForMember(v => v.Staratelji, opt => opt.Ignore());

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
                ))
                .ForMember(v=> v.Staratelji, opt=> opt.MapFrom(src=> new StarateljResource() {
                    
                        Id = src.Staratelji[0].Id,
                       Ime = src.Staratelji[0].Ime,
                       Prezime = src.Staratelji[0].Prezime,
                       UcenikId = src.Staratelji[0].UcenikId
                }));




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
                .ForMember(v => v.Telefon, opt => opt.Ignore())
                .ForMember(v => v.Opstina, opt => opt.Ignore())
                .ForMember(v => v.DrzavaRodjenja, opt => opt.Ignore())
                .ForMember(v => v.OpstinaPrebivalista, opt => opt.Ignore())
                .ForMember(v => v.Pol, opt => opt.Ignore())
                .ForMember(v => v.PostanskiBroj, opt => opt.Ignore())
                .ForMember(v => v.MestoPrebivalista, opt => opt.Ignore())
                .ForMember(v => v.MestoRodjenja, opt => opt.Ignore())
                .ForMember(v => v.MestoZavrseneSkole, opt => opt.Ignore())
                .ForMember(v => v.PrethodnaSkola, opt => opt.Ignore())
                .ForMember(v => v.UpisanaSkola, opt => opt.Ignore())
                .ForMember(v => v.Smer, opt => opt.Ignore())
                .ForMember(v => v.VremeUpisa, opt => opt.Ignore())
                .ForMember(v => v.Razred, opt => opt.Ignore())
                .ForMember(v => v.TipPorodice, opt => opt.Ignore())
                  .ForMember(v => v.Staratelji, opt => opt.Ignore());





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
                ))
                .ForMember(v => v.Staratelji, opt => opt.MapFrom(src => new StarateljResource()
                {

                    Id = src.Staratelji[0].Id,
                    Ime = src.Staratelji[0].Ime,
                    Prezime = src.Staratelji[0].Prezime,
                    UcenikId = src.Staratelji[0].UcenikId
                }));



            CreateMap<Roditelj, RoditeljiUcenikaResource>();

            CreateMap<RoditeljiUcenikaResource, Roditelj>()
                .ForMember(v => v.StepenObrazovanja, v => v.Ignore())
                .ForMember(v => v.UcenikId, v => v.Ignore())
                .ForMember(v => v.Ucenik, v => v.Ignore());




            // CreateMap<OpstinaResource, Opstina>();


            CreateMap<PostanskiBrojResource, PostanskiBroj>();
            CreateMap<Razred, RazredResource>();


            CreateMap<RoditeljResource, Roditelj>()
             .ForMember(v => v.Ime, opt => opt.MapFrom(src => src.ImeOca))
             .ForMember(v => v.Prezime, opt => opt.MapFrom(src => src.PrezimeOca))
            .ForMember(v => v.StepenObrazovanja, v => v.Ignore())
            .ForMember(v => v.StepenObrazovanjaId, v => v.Ignore())
            .ForMember(v => v.BrojTelefona, v => v.Ignore())
            .ForMember(v => v.Ucenik, v => v.Ignore());


            CreateMap<Roditelj, RoditeljResource>()
              .ForMember(v => v.ImeOca, opt => opt.MapFrom(src => src.Ime))
              .ForMember(v => v.PrezimeOca, opt => opt.MapFrom(src => src.Prezime))
              .ForMember(v => v.ImeMajke, opt => opt.MapFrom(src => src.Ime))
              .ForMember(v => v.PrezimeMajke, opt => opt.MapFrom(src => src.Prezime))
              .ForMember(v => v.UcenikId, opt => opt.MapFrom(src => src.UcenikId))
              .ForMember(v => v.IdMajke, v => v.Ignore())
              .ForMember(v => v.StrucnaSpremaMajke, v => v.Ignore())
               .ForMember(v => v.StrucnaSpremaOca, v => v.Ignore())
              .ForMember(v => v.BrojTelefonaMajke, v => v.Ignore())
              .ForMember(v => v.BrojTelefonaOca, v => v.Ignore());

            //sa ovom mapom ispod je greska, zato nece unit testovi da prodju

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
             .ForMember(v => v.StrucnaSpremaOca, opt => opt.MapFrom(src => src[1].StepenObrazovanja.Opis))
             .ForMember(v => v.BrojTelefonaMajke, opt => opt.MapFrom(src => src[0].BrojTelefona))
             .ForMember(v => v.BrojTelefonaOca, opt => opt.MapFrom(src => src[1].BrojTelefona));


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
                            BrojTelefonaOca = roditelj[j + 1].BrojTelefona
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
             .ForMember(v => v.BrojTelefona, opt => opt.MapFrom(src => src.BrojTelefonaOca))
             .ForMember(v => v.Ucenik, opt => opt.Ignore())
             .ForMember(v => v.StepenObrazovanja, opt => opt.Ignore());


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


            //CreateMap<PutRoditeljaResource, Roditelj>();
            CreateMap<Roditelj, PutRoditeljaResource>()
                .ForMember(v => v.IdMajke, opt => opt.Ignore())
                .ForMember(v => v.ImeMajke, opt => opt.Ignore())
                .ForMember(v => v.PrezimeMajke, opt => opt.Ignore())
                .ForMember(v => v.ImeOca, opt => opt.Ignore())
                .ForMember(v => v.Id, opt => opt.Ignore())
                .ForMember(v => v.PrezimeOca, opt => opt.Ignore())
                .ForMember(v => v.StrucnaSpremaMajkeId, opt => opt.Ignore())
                .ForMember(v => v.StrucnaSpremaOcaId, opt => opt.Ignore())
                .ForMember(v => v.BrojTelefonaMajke, opt => opt.Ignore())
                .ForMember(v => v.BrojTelefonaOca, opt => opt.Ignore());




            ///////////


            CreateMap<List<Roditelj>, List<PutRoditeljaResource>>()
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
                        PutRoditeljaResource nesto = new PutRoditeljaResource()
                        {
                            IdMajke = roditelj[i].Id,
                            ImeMajke = roditelj[i].Ime,
                            PrezimeMajke = roditelj[i].Prezime,
                            StrucnaSpremaMajkeId = roditelj[i].StepenObrazovanjaId,
                            BrojTelefonaMajke = roditelj[i].BrojTelefona,

                            Id = roditelj[j + 1].Id,
                            ImeOca = roditelj[j + 1].Ime,
                            PrezimeOca = roditelj[j + 1].Prezime,
                            StrucnaSpremaOcaId = roditelj[i].StepenObrazovanjaId,
                            UcenikId = roditelj[i].UcenikId,
                            BrojTelefonaOca = roditelj[j + 1].BrojTelefona
                        };
                        resurs.Add(nesto);
                    }
                }
            });

            CreateMap<List<PutRoditeljaResource>, List<Roditelj>>()
            .AfterMap((resurs, roditelj) =>
            {
                StepenStrucneSpreme stepenMajke = new StepenStrucneSpreme() { Id = resurs[0].IdMajke };
                StepenStrucneSpreme stepenOca = new StepenStrucneSpreme() { Id = resurs[0].Id };


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


            ///////////////////////
            CreateMap<PutRoditeljaResource, Roditelj>()
             .ForMember(v => v.Ime, opt => opt.MapFrom(src => src.ImeOca))
             .ForMember(v => v.Prezime, opt => opt.MapFrom(src => src.PrezimeOca))
             .ForMember(v => v.StepenObrazovanjaId, opt => opt.MapFrom(src => src.StrucnaSpremaOcaId))
              .ForMember(v => v.BrojTelefona, opt => opt.MapFrom(src => src.BrojTelefonaOca))
              .ForMember(v => v.StepenObrazovanja, opt => opt.Ignore())
              .ForMember(v => v.Ucenik, opt => opt.Ignore());



            //oovo ispdo treba da se uradi
            CreateMap<MajkaResource, Roditelj>()
                .ForMember(v => v.Id, opt => opt.MapFrom(src => src.IdMajke))
             .ForMember(v => v.Ime, opt => opt.MapFrom(src => src.ImeMajke))
             .ForMember(v => v.Prezime, opt => opt.MapFrom(src => src.PrezimeMajke))
             .ForMember(v => v.StepenObrazovanjaId, opt => opt.MapFrom(src => src.StrucnaSpremaMajkeId))
              .ForMember(v => v.BrojTelefona, opt => opt.MapFrom(src => src.BrojTelefonaMajke))
              .ForMember(v => v.StepenObrazovanja, opt => opt.Ignore())
              .ForMember(v => v.Ucenik, opt => opt.Ignore());



            CreateMap<PutRoditeljaResource, MajkaResource>();
            CreateMap<MajkaResource, PutRoditeljaResource>();

            CreateMap<Staratelj, StarateljResource>();
            CreateMap<StarateljResource, Staratelj>()
                .ForMember(v => v.Ucenik, opt => opt.Ignore());
            
        }
    }
}

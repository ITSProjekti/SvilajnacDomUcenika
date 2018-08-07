using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using DomUcenikaSvilajnac.Mapping;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xunit;
namespace DomUcenikaSvilajnac.IntegratedTests
{
    /// <summary>
    /// Klasa za tesiranje metoda iz generickog repositorijuma.
    /// </summary>
    public class UcenikControllerTest
    {
        DrzavaResource dr = new DrzavaResource() { Id = 157 };

        MestoResource mr = new MestoResource() { Id = 333 };

        OpstinaUcenikaResource our = new OpstinaUcenikaResource() { Id = 11 };

        PolResource p = new PolResource() { Id = 1 };

        PostanskiBrojResource pbr = new PostanskiBrojResource() { Id = 111 };

        PrethodnaSkolaResource psr = new PrethodnaSkolaResource() { Id = 55 };

        PostRoditeljaResource prs = new PostRoditeljaResource() { ImeMajke = "Majka", PrezimeMajke = "PrezimeMajke", ImeOca = "Otac", PrezimeOca = "PrezimeOca", BrojTelefonaMajke = "12314567", BrojTelefonaOca = "1231567", StrucnaSpremaMajkeId = 6, StrucnaSpremaOcaId = 7 };

        RazredResource rr = new RazredResource() { Id = 4 };

        Telefon t = new Telefon() { Kucni = "011231258", Mobilni = "0628136986" };

        SmerResource sr = new SmerResource() { Id = 3 };

        UpisanaSkolaResource usr = new UpisanaSkolaResource() { Id = 333 };



        Collection<Roditelj> roditelji = new Collection<Roditelj>() {
            new Roditelj (){ Ime = "Otac", Prezime = "Prezime"},
            new Roditelj () {Ime = "Majka", Prezime = "Prezime"}
        };
        /// <summary>
        /// Metoda koja vraca objekat klase PostUcenikaResource, posto se podaci koriste vise puta, tj za vise testova.
        /// </summary>
        public PostUcenikaResource Ucenik()
        {
           

            return new PostUcenikaResource
            {
                Ime = "Pera",
                Prezime = "Pericc",
                JMBG = "1234567891234",
                Dan = 8,
                Godina = 1995,
                Mesec = 7,
                Adresa = "Milutina Milankovica 22",
                DrzavaRodjenja = dr,
                MestoRodjenja = mr,
                PrethodnaSkola = psr,
                MestoPrebivalista = mr,
                MestoZavrseneSkole = mr,
                Opstina = our,
                OpstinaPrebivalista = our,
                Pol = p,
                PostanskiBroj = pbr,
                Roditelji = prs,
                Razred = rr,
                Telefon = t,
                Smer = sr,
                UpisanaSkola = usr,
                PrethodniUspeh = 4.55f
                
                
            };
        }
        public Ucenik Ucenik2()
        {
            Ucenik ucenik = new Ucenik()
            {
                Ime = "Igor",
                Prezime = "Marjanovic",
                JMBG = "1234567891234",
                DatumRodjenja = DateTime.Now,
                DrzavaRodjenjaId = 1,
                Adresa = "Savnicka 25",
                MestoRodjenjaId = 5,
                MestoPrebivalistaId = 11,
                MestoZavrseneSkoleId = 4,
                PrethodnaSkolaId = 55,
                UpisanaSkolaId = 44,
                OpstinaId = 11,
                OpstinaPrebivalistaId = 33,
                PolId = 1,
                PostanskiBrojId = 55,
                RazredId = 4,
                SmerId = 1,
                PrethodniUspeh = 4.22f,
                Roditelji = roditelji
                


            };
            return ucenik;

        }

        /// <summary>
        /// Test proverava da li se ucenik uspesno dodaje u bazu.
        /// </summary>
        [Fact]
        public void CreateUcenik_ProveraDaLiSeUcenikUspesnoDodajeUBazi_ReturnsTrue()
        {
            Mapper.Reset();

            //upotreba funkcije UseInMemoryDatabase koju omogucava EF (EntityFramework), stvara fake bazu pomocu koje se vrsi provera rada odredjenih metoda.
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var ucenikUBazi = unitOfWork.Ucenici.Get(ucenikZaBazu.Id);

            Assert.Equal(ucenikUBazi, ucenikZaBazu);
         
        }

        /// <summary>
        ///  Test proverava broja elemenata u bazi.
        /// </summary>
        [Fact]
        public void GetAllUcenik_ProveraBrojaElemenataUBazi_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Ime = "Igor", Prezime = "Marjanovic" });
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();
            Assert.Equal(2, listaUcenika.Count);
        }
        
        /// <summary>
        /// Test proverava da li se dobro uzima ucenik tj podaci o uceniku na osnovu prosledjenog Id-a
        /// </summary>
        [Fact]
        public void GetUcenikById_ReturnTrue()
        {
            Mapper.Reset();
            //inicijalizacija privremene baze
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);
            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            ucenikZaBazu = unitOfWork.Ucenici.Get(1);
            
            Assert.Contains(ucenikZaBazu.Ime, "Pera");
        }

        /// <summary>
        /// Test proverava da li se updateuju podaci o uceniku.
        /// </summary>
        [Fact]
        public void UpdateUcenik_ProveraApdejtovanjaImenaUceniku_ReturnsTrue()
        {
            Mapper.Reset();
            PostUcenikaResource apdejtUcenik = new PostUcenikaResource() { Ime = "Mateja", Prezime = "Jovanovic", Dan = 5, Godina = 5, Mesec = 6 };

            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context,mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);

            var novi = Mapper.Map<PostUcenikaResource, Ucenik>(apdejtUcenik, ucenikZaBazu);

            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            //proverava da li je ime promenjeno u Mateija, tj da li je novi podatak Ime = Mateja
            Assert.Contains(novi.Ime, "Mateja");
        }

        /// <summary>
        /// Test proverava broj elemenata u bazi nakon brisanja ucenika.
        /// </summary>
        [Fact]
        public void RemoveUcenika_ProveraBrojaElemenataUBaziNakonBrisanjaUcenika_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context,mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Ime = "Igor", Prezime = "Marjanovic"});

            //testiranje metode za brisanje
            unitOfWork.Ucenici.Remove(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            //proverava da li je u bazi ostao 1 ucenik
            Assert.Single(listaUcenika);
        }

        /// <summary>
        /// Test proverava da li pronadjen odgovarajuci ucenik na osnovu atributa, uovom slucaju Imena.
        /// </summary>
        [Fact]
        public void FindUcenik_NalazenjeUcenikaPoAtributuIme()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var rezultat = unitOfWork.Ucenici.Find(m => m.Ime == "Pera").ToList();

            Assert.Contains(rezultat.First().Ime, "Pera");
        }

        /// <summary>
        /// Test proverava async metodu GetAllUceniks.
        /// </summary>
        [Fact]
        public async void GetAllAsync_ProveraAsihronihMetodeGetAllUceniks_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            await unitOfWork.SaveChangesAsync();

            var listaUcenika =  await unitOfWork.Ucenici.GetAllAsync();

            Assert.Contains(listaUcenika.First().Ime, "Pera");
        }

        /// <summary>
        /// Test proverava async modtud Get po Id-u, da li se vraca pravi ucenik na osnovu prosledjenog Id-a.
        /// </summary>
        [Fact]
        public async void GetAsyncById_ProveraAsihroneMetodeKojaVracaUcenikaPoId_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context,mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            await unitOfWork.SaveChangesAsync();

            ucenikZaBazu = await unitOfWork.Ucenici.GetAsync(1);

            Assert.Equal(1, ucenikZaBazu.Id);
        }

        [Fact]
        public void GetAllUcenik_UporedjivanjePodatakaIzBazeSaDodatimObjektima_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();


            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);

            unitOfWork.Ucenici.Add(Ucenik2());
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();


            //testiranje za prvog ucenika u bazi
            Assert.Equal(listaUcenika[0].Ime, primerUcenika.Ime);
            Assert.Equal(listaUcenika[0].Prezime, primerUcenika.Prezime);
            Assert.Equal(listaUcenika[0].JMBG, primerUcenika.JMBG);
            Assert.Equal(listaUcenika[0].DatumRodjenja.Day, primerUcenika.Dan);
            Assert.Equal(listaUcenika[0].DatumRodjenja.Month, primerUcenika.Mesec);
            Assert.Equal(listaUcenika[0].DatumRodjenja.Year, primerUcenika.Godina);
            Assert.Equal(listaUcenika[0].DrzavaRodjenjaId, primerUcenika.DrzavaRodjenja.Id);
            Assert.Equal(listaUcenika[0].MestoRodjenjaId, primerUcenika.MestoRodjenja.Id);
            Assert.Equal(listaUcenika[0].PrethodnaSkolaId, primerUcenika.PrethodnaSkola.Id);
            Assert.Equal(listaUcenika[0].MestoPrebivalistaId, primerUcenika.MestoPrebivalista.Id);
            Assert.Equal(listaUcenika[0].MestoZavrseneSkoleId, primerUcenika.MestoZavrseneSkole.Id);
            Assert.Equal(listaUcenika[0].OpstinaId, primerUcenika.Opstina.Id);
            Assert.Equal(listaUcenika[0].OpstinaPrebivalistaId, primerUcenika.OpstinaPrebivalista.Id);
            Assert.Equal(listaUcenika[0].PolId, primerUcenika.Pol.Id);
            Assert.Equal(listaUcenika[0].PostanskiBrojId, primerUcenika.PostanskiBroj.Id);
            Assert.Equal(listaUcenika[0].RazredId, primerUcenika.Razred.Id);
            Assert.Equal(listaUcenika[0].TelefonId, primerUcenika.Telefon.Id);
            Assert.Equal(listaUcenika[0].SmerId, primerUcenika.Smer.Id);
            Assert.Equal(listaUcenika[0].UpisanaSkolaId, primerUcenika.UpisanaSkola.Id);
            Assert.Equal(listaUcenika[0].PrethodniUspeh, primerUcenika.PrethodniUspeh);
         //   Assert.Equal(listaUcenika[0].Roditelji, primerUcenika.Roditelji);

            //testiranje za prvog ucenika u bazi

            Assert.Equal(listaUcenika[1].Ime, Ucenik2().Ime);
            Assert.Equal(listaUcenika[1].Prezime, Ucenik2().Prezime);
            Assert.Equal(listaUcenika[1].JMBG, Ucenik2().JMBG);
            //  Assert.Equal(listaUcenika[1].DatumRodjenja, Ucenik2().DatumRodjenja);
            Assert.Equal(listaUcenika[1].DrzavaRodjenjaId, Ucenik2().DrzavaRodjenjaId);
            Assert.Equal(listaUcenika[1].MestoRodjenjaId, Ucenik2().MestoRodjenjaId);
            Assert.Equal(listaUcenika[1].PrethodnaSkolaId, Ucenik2().PrethodnaSkolaId);
            Assert.Equal(listaUcenika[1].MestoPrebivalistaId, Ucenik2().MestoPrebivalistaId);
            Assert.Equal(listaUcenika[1].MestoZavrseneSkoleId, Ucenik2().MestoZavrseneSkoleId);
            Assert.Equal(listaUcenika[1].OpstinaId, Ucenik2().OpstinaId);
            Assert.Equal(listaUcenika[1].OpstinaPrebivalistaId, Ucenik2().OpstinaPrebivalistaId);
            Assert.Equal(listaUcenika[1].PolId, Ucenik2().PolId);
            Assert.Equal(listaUcenika[1].PostanskiBrojId, Ucenik2().PostanskiBrojId);
            Assert.Equal(listaUcenika[1].RazredId, Ucenik2().RazredId);
            Assert.Equal(listaUcenika[1].TelefonId, Ucenik2().TelefonId);
            Assert.Equal(listaUcenika[1].SmerId, Ucenik2().SmerId);
            Assert.Equal(listaUcenika[1].UpisanaSkolaId, Ucenik2().UpisanaSkolaId);
            Assert.Equal(listaUcenika[1].PrethodniUspeh, Ucenik2().PrethodniUspeh);




        }
    }
}

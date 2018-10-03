using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.Controllers;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using DomUcenikaSvilajnac.Mapping;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
namespace DomUcenikaSvilajnac.IntegratedTests
{
    /// <summary>
    /// Klasa za tesiranje metoda iz generickog repositorijuma.
    /// </summary>
    public class UcenikControllerTest
    {
        DataModels data = new DataModels();
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
            var primerUcenika = data.Ucenik();

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
        ///  Test proverava broj elemenata u bazi.
        /// </summary>
        [Fact]
        public void GetAllUcenik_ProveraBrojaElemenataUBazi_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = data.Ucenik();

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
            var primerUcenika = data.Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);
            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            Assert.Equal(unitOfWork.Ucenici.Get(1), ucenikZaBazu);
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
            var primerUcenika = data.Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context,mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);

            var novi = Mapper.Map<PostUcenikaResource, Ucenik>(apdejtUcenik, ucenikZaBazu);

            unitOfWork.SaveChanges();

            //proverava da li je ime promenjeno u Mateja, tj. da li je novi podatak Ime = Mateja
            Assert.Equal(novi.Ime, ucenikZaBazu.Ime);
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
            var primerUcenika = data.Ucenik();

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
            Assert.True(listaUcenika.Count == 1);
        }


        /// <summary>
        /// Test proverava da li pronadjen odgovarajuci ucenik na osnovu atributa, u ovom slucaju Imena.
        /// </summary>
        [Fact]
        public void FindUcenik_NalazenjeUcenikaPoAtributuIme()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = data.Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var rezultat = unitOfWork.Ucenici.Find(m => m.Ime == "Pera").ToList();

            Assert.Equal(rezultat.First().Ime, ucenikZaBazu.Ime);
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
            var primerUcenika = data.Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            await unitOfWork.SaveChangesAsync();

            var listaUcenika =  await unitOfWork.Ucenici.GetAllAsync();

            Assert.Equal(listaUcenika.First().Ime, ucenikZaBazu.Ime);
        }

        /// <summary>
        /// Test proverava async metodu Get po Id-u, da li se vraca pravi ucenik na osnovu prosledjenog Id-a.
        /// </summary>
        [Fact]
        public async void GetAsyncById_ProveraAsihroneMetodeKojaVracaUcenikaPoId_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = data.Ucenik();

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

        /// <summary>
        /// Test proverava metodu GetAll, proverava da li se u bazu dodaje sve kako treba.
        /// </summary>
        [Fact]
        public void GetAllUcenik_UporedjivanjePodatakaIzBazeSaDodatimObjektima_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = data.Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();


            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);

            unitOfWork.Ucenici.Add(data.Ucenik2());
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
    

            //testiranje za prvog ucenika u bazi

            Assert.Equal(listaUcenika[1].Ime, data.Ucenik2().Ime);
            Assert.Equal(listaUcenika[1].Prezime, data.Ucenik2().Prezime);
            Assert.Equal(listaUcenika[1].JMBG, data.Ucenik2().JMBG);
            Assert.Equal(listaUcenika[1].DrzavaRodjenjaId, data.Ucenik2().DrzavaRodjenjaId);
            Assert.Equal(listaUcenika[1].MestoRodjenjaId, data.Ucenik2().MestoRodjenjaId);
            Assert.Equal(listaUcenika[1].PrethodnaSkolaId, data.Ucenik2().PrethodnaSkolaId);
            Assert.Equal(listaUcenika[1].MestoPrebivalistaId, data.Ucenik2().MestoPrebivalistaId);
            Assert.Equal(listaUcenika[1].MestoZavrseneSkoleId, data.Ucenik2().MestoZavrseneSkoleId);
            Assert.Equal(listaUcenika[1].OpstinaId, data.Ucenik2().OpstinaId);
            Assert.Equal(listaUcenika[1].OpstinaPrebivalistaId, data.Ucenik2().OpstinaPrebivalistaId);
            Assert.Equal(listaUcenika[1].PolId, data.Ucenik2().PolId);
            Assert.Equal(listaUcenika[1].PostanskiBrojId, data.Ucenik2().PostanskiBrojId);
            Assert.Equal(listaUcenika[1].RazredId, data.Ucenik2().RazredId);
            Assert.Equal(listaUcenika[1].TelefonId, data.Ucenik2().TelefonId);
            Assert.Equal(listaUcenika[1].SmerId, data.Ucenik2().SmerId);
            Assert.Equal(listaUcenika[1].UpisanaSkolaId, data.Ucenik2().UpisanaSkolaId);
            Assert.Equal(listaUcenika[1].PrethodniUspeh, data.Ucenik2().PrethodniUspeh);
        }

        /// <summary>
        /// Test proverava metodu Remove, proverava se da li je baza osatala prazna nakon brisanja ucenika.
        /// </summary>
        [Fact]
        public void RemoveUcenika_ProveraBazeNakonBrisanjaUcenika_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = data.Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<PostUcenikaResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, PostUcenikaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();


            var listaUcenikaNakonDodavanjaUBazi = unitOfWork.Ucenici.GetAll().ToList();

            //testiranje metode za brisanje
            unitOfWork.Ucenici.Remove(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var listaUcenikaNakonBrisanja = unitOfWork.Ucenici.GetAll().ToList();

            //proverava da li je u bazi nakon brisanja ucenika ostalo
            if (!listaUcenikaNakonDodavanjaUBazi.Any())
                Assert.True(listaUcenikaNakonBrisanja.Count == 0);
        }

        /// <summary>
        /// Test proverava metodu Create, proverava se da li su roditelji uspesno dodati u bazu.
        /// </summary>
        [Fact]
        public void CreateRoditeljaUcenika_ProveraDaLiSeRoditeljiUcenikaUspesnoDodajuUBazi_ReturnsTrue()
        {
            Mapper.Reset();

            //upotreba funkcije UseInMemoryDatabase koju omogucava EF (EntityFramework), stvara fake bazu pomocu koje se vrsi provera rada odredjenih metoda.
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primeriRoditelja = data.roditeljResurs;

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var roditeljZaBazu1 = Mapper.Map<PostRoditeljaResource, Roditelj>(primeriRoditelja);
            Roditelj roditeljZaBazu2 = new Roditelj()
            {
                Id = 2,
                Ime = "Neko",
                Prezime = "Nesto",
                BrojTelefona = "1234567",
                StepenObrazovanjaId = 5,
                UcenikId = 1
            };
            List<Roditelj> listaRoditeljaZaBazu = new List<Roditelj>() {
                roditeljZaBazu1, roditeljZaBazu2
            };
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Roditelj, PostRoditeljaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Roditelji.AddRange(listaRoditeljaZaBazu);
            unitOfWork.SaveChanges();

            var roditeljiUBazi = unitOfWork.Roditelji.GetAll().ToList();

            Assert.Equal(listaRoditeljaZaBazu, roditeljiUBazi);

        }

        /// <summary>
        /// Test proverava metodu Remove, proverava se da li je baza osatala prazna nakon brisanja roditelja.
        /// </summary>
        [Fact]
        public void RemoveRoditeljaUcenika_ProveraDaLiSeRoditeljiUcenikaUspesnoObrisaoIzUBaze_ReturnsFalse()
        {
            Mapper.Reset();

            //upotreba funkcije UseInMemoryDatabase koju omogucava EF (EntityFramework), stvara fake bazu pomocu koje se vrsi provera rada odredjenih metoda.
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primeriRoditelja = data.roditeljResurs;

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var roditeljZaBazu = Mapper.Map<PostRoditeljaResource, Roditelj>(primeriRoditelja);
           
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Roditelj, PostRoditeljaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Roditelji.Add(roditeljZaBazu);
            unitOfWork.SaveChanges();

            var roditeljUBazi = unitOfWork.Roditelji.Get(1);

            unitOfWork.Roditelji.Remove(roditeljUBazi);
            unitOfWork.SaveChanges();
            var roditeljNakonBrisanja = unitOfWork.Roditelji.Get(1);

            Assert.False(roditeljNakonBrisanja != null);
        }

        /// <summary>
        /// Test proverava metodu GetById (za roditelje), proverava se da li je roditelj uspesno dodat u bazu.
        /// </summary>
        [Fact]
        public void RoditeljGetById_TestiranjeGetByIdMetode_ReturnsTrue()
        {
            Mapper.Reset();

            //upotreba funkcije UseInMemoryDatabase koju omogucava EF (EntityFramework), stvara fake bazu pomocu koje se vrsi provera rada odredjenih metoda.
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primeriRoditelja = data.roditeljResurs;

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var roditeljZaBazu = Mapper.Map<PostRoditeljaResource, Roditelj>(primeriRoditelja);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Roditelj, PostRoditeljaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Roditelji.Add(roditeljZaBazu);
            unitOfWork.SaveChanges();

            var roditeljUBazi = unitOfWork.Roditelji.Get(1);
            Assert.Equal(roditeljUBazi, roditeljZaBazu);
        }

        /// <summary>
        /// Test proverava metodu Put, proverava se da li su podaci o roditeljima uspesno promenjeni (updateovani).
        /// </summary>
        [Fact]
        public void PutRoditelja_TestiranjeUpdateMetode_ReturnsTrue()
        {
            Mapper.Reset();

            //upotreba funkcije UseInMemoryDatabase koju omogucava EF (EntityFramework), stvara fake bazu pomocu koje se vrsi provera rada odredjenih metoda.
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primeriRoditelja = data.roditeljResurs;

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var roditeljZaBazu1 = Mapper.Map<PostRoditeljaResource, Roditelj>(primeriRoditelja);
            Roditelj roditeljZaBazu2 = new Roditelj()
            {
                Id = 2,
                Ime = "Neko",
                Prezime = "Nesto",
                BrojTelefona = "1234567",
                StepenObrazovanjaId = 5,
                UcenikId = 1
            };
            List<Roditelj> listaRoditeljaZaBazu = new List<Roditelj>() {
                roditeljZaBazu1, roditeljZaBazu2
            };
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Roditelj, PostRoditeljaResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Roditelji.AddRange(listaRoditeljaZaBazu);
            unitOfWork.SaveChanges();
            var roditeljiUBazi1 = unitOfWork.Roditelji.GetAll().ToList();
         
            var roditeljiUBazi = context.Roditelji
                .Where(b => b.UcenikId == 1).ToList();

            PutRoditeljaResource roditeljUBaziResurs = new PutRoditeljaResource()
            {
                Id = roditeljiUBazi[0].Id,
                ImeOca = roditeljiUBazi[0].Ime,
                PrezimeOca = roditeljiUBazi[0].Prezime,
                BrojTelefonaOca = roditeljiUBazi[0].BrojTelefona,
                StrucnaSpremaOcaId = roditeljiUBazi[0].StepenObrazovanjaId,
                IdMajke = roditeljiUBazi[1].Id,
                ImeMajke = roditeljiUBazi[1].Ime,
                PrezimeMajke = roditeljiUBazi[1].Prezime,
                BrojTelefonaMajke = roditeljiUBazi[1].BrojTelefona,
                StrucnaSpremaMajkeId = roditeljiUBazi[1].StepenObrazovanjaId,
                UcenikId = 1
            };
            var stariOtac =  unitOfWork.Roditelji.Get(roditeljUBaziResurs.Id);
            var staraMajka = unitOfWork.Roditelji.Get(roditeljUBaziResurs.IdMajke);

            var majkaResurs = Mapper.Map<PutRoditeljaResource, MajkaResource>(data.putRoditeljaResurs);

            Mapper.Map<PutRoditeljaResource, Roditelj>(data.putRoditeljaResurs, stariOtac);
            Mapper.Map<MajkaResource, Roditelj>(majkaResurs, staraMajka);
            unitOfWork.SaveChanges();

            var roditeljiUBazi2 = unitOfWork.Roditelji.GetAll().ToList();

            PutRoditeljaResource apdejtovaniRoditelji = new PutRoditeljaResource()
            {
                Id = roditeljiUBazi2[0].Id,
                ImeOca = roditeljiUBazi2[0].Ime,
                PrezimeOca = roditeljiUBazi2[0].Prezime,
                BrojTelefonaOca = roditeljiUBazi2[0].BrojTelefona,
                StrucnaSpremaOcaId = roditeljiUBazi2[0].StepenObrazovanjaId,
                IdMajke = roditeljiUBazi2[1].Id,
                ImeMajke = roditeljiUBazi2[1].Ime,
                PrezimeMajke = roditeljiUBazi2[1].Prezime,
                BrojTelefonaMajke = roditeljiUBazi2[1].BrojTelefona,
                StrucnaSpremaMajkeId = roditeljiUBazi2[1].StepenObrazovanjaId,
                UcenikId = 1
            };
            
            Assert.NotEqual(roditeljUBaziResurs, apdejtovaniRoditelji);
        }

        /// <summary>
        /// Test proverava da li se vaspitac uspesno dodaje u bazu.
        /// </summary>
        [Fact]
        public void CreateVaspitaca_ProveraDaLiSeVaspitacUspesnoDodajeUBazu()
        {
            Mapper.Reset();

            //upotreba funkcije UseInMemoryDatabase koju omogucava EF (EntityFramework), stvara fake bazu pomocu koje se vrsi provera rada odredjenih metoda.
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerVaspitaca = data.vaspitac();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var vaspitacZaBazu = Mapper.Map<VaspitacResource, Vaspitac>(primerVaspitaca);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Vaspitaci.Add(vaspitacZaBazu);
            unitOfWork.SaveChanges();

            var vaspitacUBazi = unitOfWork.Vaspitaci.Get(vaspitacZaBazu.Id);

            Assert.Equal(vaspitacUBazi, vaspitacZaBazu);
        }

        /// <summary>
        ///  Test proverava broj elemenata u bazi.
        /// </summary>
        [Fact]
        public void GetAllVaspitac_ProveraBrojaElemenataUBazi_ReturnsTrue()
        {
            Mapper.Reset();

            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerVaspitaca = data.vaspitac();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var vaspitacZaBazu = Mapper.Map<VaspitacResource, Vaspitac>(primerVaspitaca);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Vaspitaci.Add(vaspitacZaBazu);
            unitOfWork.Vaspitaci.Add(new Vaspitac { Id= 2, Ime = "Ime", Prezime = "Prezime" });
            unitOfWork.SaveChanges();

            var listaVasptaca = unitOfWork.Vaspitaci.GetAll().ToList();
            Assert.Equal(2, listaVasptaca.Count);
        }

        /// <summary>
        /// Test proverava da li se dobro uzima vaspitac tj podaci o vaspitacu na osnovu prosledjenog Id-a
        /// </summary>
        [Fact]
        public void GetVaspitacById_ReturnTrue()
        {
            Mapper.Reset();
            //inicijalizacija privremene baze
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var context = new UcenikContext(options);
            var primerVaspitaca = data.vaspitac();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            var vaspitacZaBazu = Mapper.Map<VaspitacResource, Vaspitac>(primerVaspitaca);
            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Vaspitaci.Add(vaspitacZaBazu);
            unitOfWork.SaveChanges();

            Assert.Equal(unitOfWork.Vaspitaci.Get(1), vaspitacZaBazu);
        }

        /// <summary>
        /// Test proverava metodu Put, proverava se da li su podaci o vaspitacima uspesno promenjeni (updateovani).
        /// </summary>
        [Fact]
        public void PutVaspitaca_TestiranjeUpdateMetode_ReturnsTrue()
        {
            Mapper.Reset();
            VaspitacResource updateVaspitac = new VaspitacResource() { Ime = "Nikola", Prezime = "Petrovic", BrojTelefona = "06x555333", Slika = "slika" };
            
            //inicijalizacija privremene baze
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            var context = new UcenikContext(options);
            var primerVaspitaca = data.vaspitac();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var vaspitacZaBazu = Mapper.Map<VaspitacResource, Vaspitac>(primerVaspitaca);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            
            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Vaspitaci.Add(vaspitacZaBazu);

            var noviVaspitac = Mapper.Map<VaspitacResource, Vaspitac>(updateVaspitac, vaspitacZaBazu);

            unitOfWork.SaveChanges();

            Assert.Equal(noviVaspitac.Ime, vaspitacZaBazu.Ime);
        }

        /// <summary>
        /// Test proverava metodu remove, proverava se da li je baza osatala prazna nakon brisanja vaspitaca.
        /// </summary>
        [Fact] 
        public void RemoveVaspitaca_ProveraBazeNakonBrisanjaVaspitaca_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerVaspitaca = data.vaspitac();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var vaspitacZaBazu = Mapper.Map<VaspitacResource, Vaspitac>(primerVaspitaca);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Vaspitaci.Add(vaspitacZaBazu);
            unitOfWork.SaveChanges();

            var listaVaspitacaNakonDodavanjaUBazi = unitOfWork.Vaspitaci.GetAll().ToList();

            //testiranje metode za brisanje
            unitOfWork.Vaspitaci.Remove(vaspitacZaBazu);
            unitOfWork.SaveChanges();

            

            var listaVaspitacaNakonBrisanja = unitOfWork.Vaspitaci.GetAll().ToList();

            //proverava da li je u bazi nakon brisanja vaspitaca ostalo
            if (!listaVaspitacaNakonDodavanjaUBazi.Any())
                Assert.True(listaVaspitacaNakonBrisanja.Count == 1);
        }

        [Fact]
        public void sumaBodovaPohvale()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);


            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            List<Pohvala> pohvale = new List<Pohvala>()
            {
                data.pohvala(),
                new Pohvala() {Id =2, UcenikId =1, BodoviPohvale = 6,Opis = "Afekat"}
            };

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(data.Ucenik2());
            unitOfWork.VaspitneGrupe.Add(data.vaspitnaGrupa());
            unitOfWork.Pohvale.AddRange(pohvale);
            unitOfWork.Kazne.Add(data.kazna());
            unitOfWork.Statistike.Add(data.statistika());
            unitOfWork.SaveChangesAsync();

            var rezultat = unitOfWork.Statistike.bodoviPohvalaUcenikaPoGrupama();

            /* testira da li je rezultat funkcije bodoviPohvalaUcenikaPoGrupama tacno vratio sumu pohvala
             ucenika u vaspitnoj grupi sa id = 1 */
            Assert.Equal(11, Convert.ToDecimal( rezultat.Result.Select(n=> n.BodoviPohvalaGrupa).SingleOrDefault()));
        }

        [Fact]
        public void sumaBodovaKazne()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);


            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            List<Ucenik> ucenici = new List<Ucenik>()
            {
                data.Ucenik2(),
                new Ucenik() {Id = 2,
                PrethodniUspeh = 5,
                VaspitnaGrupaId =1}
            };

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.AddRange(ucenici);
            unitOfWork.VaspitneGrupe.Add(data.vaspitnaGrupa());
            unitOfWork.Statistike.Add(data.statistika());
            unitOfWork.SaveChangesAsync();

            var rezultat = unitOfWork.Statistike.uspehUcenikaPoVaspitnimGrupama();

            /* testira da li je rezultat funkcije uspehUcenikaPoVaspitnimGrupama tacno vratio prosek uspeha
             ucenika u vaspitnoj grupi sa id = 1 */
            Assert.Equal(Convert.ToDecimal(4.5), Convert.ToDecimal(rezultat.Result.Select(n => n.UspehVaspitneGrupe).SingleOrDefault()));
        }

        [Fact]
        public void posecenost()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);


            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Vaspitac, VaspitacResource>());
            var mapper = config.CreateMapper();

            List<Ucenik> ucenici = new List<Ucenik>()
            {
                data.Ucenik2(),
                new Ucenik() {Id = 2,            
                VaspitnaGrupaId =1}
            };

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.AddRange(ucenici);
            unitOfWork.VaspitneGrupe.Add(data.vaspitnaGrupa());
            unitOfWork.Sastanci.Add(data.sastanak());
            unitOfWork.Statistike.Add(data.statistika());
            unitOfWork.SaveChangesAsync();

            var rezultat = unitOfWork.Statistike.posecenostSastanaka();
            Assert.Equal("100%" ,Convert.ToString((rezultat.Result.Select(n => n.Posecenost).SingleOrDefault())));
        }
    }
}
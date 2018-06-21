using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using DomUcenikaSvilajnac.Mapping;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;
namespace DomUcenikaSvilajnac.IntegratedTests
{
    /// <summary>
    /// Klasa za tesiranje metoda iz generickog repositorijuma.
    /// </summary>
    public class UcenikControllerTest
    {

        /// <summary>
        /// Metoda koja vraca objekat klase UcenikResource, posto se podaci koriste vise puta, tj za vise testova.
        /// </summary>
        public UcenikResource Ucenik()
        {
            return new UcenikResource { Ime = "Ilhan", Prezime = "Kalac", JMBG = "1405997273013", Pol = "Zenski", Dan = 14, Godina = 1997, Mesec = 5 };
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
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            Assert.NotEmpty(listaUcenika);
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

            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Ime = "Igor", Prezime = "Marjanovic", Pol = "Muski" });
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

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);
            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            ucenikZaBazu = unitOfWork.Ucenici.Get(1);
            
            Assert.Contains(ucenikZaBazu.Ime, "Ilhan");
        }

        /// <summary>
        /// Test proverava da li se updateuju podaci o uceniku.
        /// </summary>
        [Fact]
        public void UpdateUcenik_ProveraApdejtovanjaImenaUceniku_ReturnsTrue()
        {
            Mapper.Reset();
            UcenikResource apdejtUcenik = new UcenikResource() { Ime = "Mateja", Prezime = "Jovanovic", Dan = 5, Godina = 5, Mesec = 6 };

            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context,mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);

            var novi = Mapper.Map<UcenikResource, Ucenik>(apdejtUcenik, ucenikZaBazu);

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
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context,mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Ime = "Igor", Prezime = "Marjanovic", Pol = "Muski" });

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
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var rezultat = unitOfWork.Ucenici.Find(m => m.Ime == "Ilhan").ToList();

            Assert.Contains(rezultat.First().Ime, "Ilhan");
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
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context, mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            await unitOfWork.SaveChangesAsync();

            var listaUcenika =  await unitOfWork.Ucenici.GetAllAsync();

            Assert.Contains(listaUcenika.First().Ime, "Ilhan");
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
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);

            var config = new MapperConfiguration(cfg => cfg.CreateMap<Ucenik, UcenikResource>());
            var mapper = config.CreateMapper();

            IUnitOfWork unitOfWork = new UnitOfWork(context,mapper);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            await unitOfWork.SaveChangesAsync();

            ucenikZaBazu = await unitOfWork.Ucenici.GetAsync(1);

            Assert.Equal(1, ucenikZaBazu.Id);
        }
    }
}

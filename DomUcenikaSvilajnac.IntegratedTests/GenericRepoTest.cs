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
    public class UcenikControllerTest
    {

        public UcenikResource Ucenik()
        {
            return new UcenikResource { Ime = "Ilhan", Prezime = "Kalac", JMBG = "1405997273013", Pol = "Zenski", Dan = 14, Godina = 1997, Mesec = 5 };
        }

      

        [Fact]
        public void CreateUcenik_ProveraDaLiSeUcenikUspesnoDodajeUBazi_ReturnsTrue()
        {
            Mapper.Reset();
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);


            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();


            Assert.NotEmpty(listaUcenika);
    
        }

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


            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Ime = "Igor", Prezime = "Marjanovic", Pol = "Muski" });
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            Assert.Equal(2, listaUcenika.Count);
          
        }
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


            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);
            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            ucenikZaBazu = unitOfWork.Ucenici.Get(1);

            //assert
            Assert.Contains(ucenikZaBazu.Ime, "Ilhan");
       
        }





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

            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);

            var novi = Mapper.Map<UcenikResource, Ucenik>(apdejtUcenik, ucenikZaBazu);


            unitOfWork.SaveChanges();


            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            Assert.Contains(novi.Ime, "Mateja");

        }

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


            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Ime = "Igor", Prezime = "Marjanovic", Pol = "Muski" });


            //testiranje metode za brisanje

            unitOfWork.Ucenici.Remove(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            //proverava da li je u bazi ostao 1 ucenik
            Assert.Single(listaUcenika);
      
        }

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

            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var rezultat = unitOfWork.Ucenici.Find(m => m.Ime == "Ilhan").ToList();


            Assert.Contains(rezultat.First().Ime, "Ilhan");


            

        }

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

            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            await unitOfWork.SaveChangesAsync();


            var listaUcenika =  await unitOfWork.Ucenici.GetAllAsync();

            Assert.Contains(listaUcenika.First().Ime, "Ilhan");

      
        }

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

            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            await unitOfWork.SaveChangesAsync();


            ucenikZaBazu = await unitOfWork.Ucenici.GetAsync(1);

            Assert.Equal(1, ucenikZaBazu.Id);

         
        }



    }
}

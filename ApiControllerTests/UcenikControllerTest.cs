using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using DomUcenikaSvilajnac.Mapping;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ApiControllerTests
{

    public class UcenikControllerTest
    {

        public UcenikResource Ucenik()
        {
            return new UcenikResource {Ime = "Ilhan", Prezime = "Kalac", JMBG = "1405997273013", Pol = "Zenski", Dan = 14, Godina = 1997, Mesec = 5 };
        }


        [Fact]
        public void CreateUcenik_ProveraDaLiSeUcenikUspesnoDodajeUBazi_ReturnsTrue()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);


            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Id = 2, Ime = "Igor", Prezime = "Marjanovic", Pol = "Muski" });
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();



            Assert.NotEmpty(listaUcenika);
            Mapper.Reset();
        }

        [Fact]
        public void GetAllUcenik_ProveraBrojaElemenataUBazi_ReturnsTrue()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

           
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);


            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Ime = "Igor", Prezime = "Marjanovic", Pol= "Muski" });
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            Assert.Equal(2, listaUcenika.Count);
            Mapper.Reset();
        }
        [Fact]
        public void GetUcenikById_ReturnTrue()
        {
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
            Mapper.Reset();
        }




    
        [Fact]
        public void UpdateUcenik_ProveraApdejtovanjaImenaUceniku_ReturnsTrue()
        {
            UcenikResource apdejtUcenik = new UcenikResource() { Ime = "Mateja", Prezime = "Jovanovic", Dan=5,Godina= 5, Mesec =6 };


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

            Mapper.Reset();
        }

        [Fact]
        public void RemoveUcenika_ProveraBrojaElemenataUBaziNakonBrisanjaUcenika_ReturnsTrue()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).EnableSensitiveDataLogging().Options;
            var context = new UcenikContext(options);
            var primerUcenika = Ucenik();

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenikZaBazu = Mapper.Map<UcenikResource, Ucenik>(primerUcenika);


            IUnitOfWork unitOfWork = new UnitOfWork(context);
            unitOfWork.Ucenici.Add(ucenikZaBazu);
            unitOfWork.Ucenici.Add(new Ucenik { Id = 2, Ime = "Igor", Prezime = "Marjanovic", Pol = "Muski" });


            //testiranje metode za brisanje

            unitOfWork.Ucenici.Remove(ucenikZaBazu);
            unitOfWork.SaveChanges();

            var listaUcenika = unitOfWork.Ucenici.GetAll().ToList();

            //proverava da li je u bazi ostao 1 ucenik
            Assert.Single(listaUcenika);
            Mapper.Reset();
        }

    }

}

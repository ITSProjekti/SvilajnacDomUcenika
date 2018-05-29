using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Controllers;
using DomUcenikaSvilajnac.DAL.Context;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using DomUcenikaSvilajnac.ModelResources;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiControllerTests
{

    public class UcenikControllerTest
    {
        public IMapper Mapper { get;  }
        public IUnitOfWork unitOfWork { get; }
        public UcenikResource Ucenik()
        {
            return new UcenikResource { Ime = "Ilhan", Prezime = "Kalac", JMBG = "1405997273013" };
        }
        
        
        [Fact]
        public void TestiranjeMetodeGetUceniks()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);

                     

        
            using (var controller = new UcenikController(Mapper, unitOfWork))
            {
                var rezultat = controller.GetUceniks();
                Assert.NotNull(rezultat);            
            }
        }
        [Fact]
        public void TestiranjeMetodeGetUcenikByID()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);

     
         
            using (var controller = new UcenikController(Mapper, unitOfWork))
            {
                var rezultat = controller.GetUcenik(5);
                Assert.NotNull(rezultat);
            }
        }

        [Fact]
        public void TestiranjeMetodePost()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);
        
            using (var controller = new UcenikController(Mapper, unitOfWork))
            {
                var rezultat = controller.PostUcenik(Ucenik());
                Assert.NotNull(rezultat);
            }
        }

        [Fact]
        public void TestiranjeMetodeRemove()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);

         
            using (var controller = new UcenikController(Mapper, unitOfWork))
            {
                var rezultat = controller.DeleteUcenik(5);
                var provera = controller.GetUcenik(5);

                if (provera != null)
                     Assert.NotNull(rezultat);
               
            }
        }

        [Fact]
        public void TestiranjeMetodedUGetUcenikByID()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);

            IUnitOfWork unitOfWork = new UnitOfWork(context);

            using (var controller = new UcenikController(Mapper, unitOfWork))
            {
                var rezultat = controller.GetUcenik(1);
                Assert.NotNull(rezultat);
            }
        }

        [Fact]
        public void TestiranjeMetodePut()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);

            IUnitOfWork unitOfWork = new UnitOfWork(context);

            var resource = new UcenikResource() { Ime = "Pavle", Prezime = "Lukic", JMBG = "1245656", Pol = "Muski", Dan = 2, Mesec = 5, Godina = 1997 };

            using (var controller = new UcenikController(Mapper, unitOfWork))
            {
                var rezultat = controller.PutUcenik(4, resource);
                Assert.NotNull(rezultat);
            }
        }
    }  
}

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

        //[Fact]
        //public async Task Test_Post()
        //{




        //    using (var client = new TestUcenikProvider().Client)
        //    {


        //        var response = await client.PostAsync("/api/Ucenik", new StringContent(
        //            JsonConvert.SerializeObject(new UcenikResource()
        //            {

        //                Ime = "Ilhan",
        //                Prezime = "Kalac",
        //                Pol = "Muski",
        //                JMBG = "1405997273013",
        //                Dan = 5,
        //                Godina = 5,
        //                Mesec = 2
        //            }), Encoding.UTF8, "application/json"));


        //        response.EnsureSuccessStatusCode();

        //        response.StatusCode.Should().Be(HttpStatusCode.OK);


        //    }


        //}
        //[Fact]
        //public async Task Test_GetAll_Ucenik()
        //{
        //    AutoMapper.Mapper.Reset();
        //    using (var client = new TestUcenikProvider().Client)
        //    {

        //        var response = await client.GetAsync("/api/Ucenik");

        //        response.EnsureSuccessStatusCode();

        //        response.StatusCode.Should().Be(HttpStatusCode.OK);


        //    }
        //}
        //[Fact]
        //public async Task Test_GetAll_UcenikById()
        //{
        //    AutoMapper.Mapper.Reset();
        //    using (var client = new TestUcenikProvider().Client)
        //    {

        //        var response = await client.GetAsync("/api/Ucenik/17");

        //        response.EnsureSuccessStatusCode();

        //        response.StatusCode.Should().Be(HttpStatusCode.OK);

        //    }
        //}



        public UcenikContext GetData()
        {

            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);
            var ucenik1 = new Ucenik { Ime = "Ilhan", Prezime = "Kalac", JMBG = "1405997273013" };
            var ucenik2 = new Ucenik { Ime = "Pavle", Prezime = "Lukic", JMBG = "1405997273013" };
            var ucenik3 = new Ucenik { Ime = "Igor", Prezime = "Marjanovic", JMBG = "1405997273013" };

            context.Uceniks.Add(ucenik1);
            context.Uceniks.Add(ucenik2);
            context.Uceniks.Add(ucenik3);
            return context;
        }

        
        [Fact]
        public void TestiranjeMetodeGetUceniks()
        {
            var options = new DbContextOptionsBuilder<UcenikContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var context = new UcenikContext(options);

            IUnitOfWork unitOfWork = new UnitOfWork(context);
                     

            using (var context1 = GetData())
            using (var controller = new UcenikController(Mapper, unitOfWork))
            {
                var rezultat = controller.GetUceniks();
                Assert.NotNull(rezultat);            
            }
        }
    }  
}

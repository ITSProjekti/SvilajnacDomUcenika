using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Controllers;
using DomUcenikaSvilajnac.ModelResources;
using FluentAssertions;
using Moq;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ApiControllerTests
{

    public class UcenikControllerTest
    {
        [Fact]
        public async Task Test_Post()
        {  
           
          


            using (var client = new TestUcenikProvider().Client)
            {
                

                var response = await client.PostAsync("/api/Ucenik", new StringContent(
                    JsonConvert.SerializeObject(new UcenikResource()
                    {

                        Ime = "Ilhan",
                        Prezime = "Kalac",
                        Pol = "Muski",
                        JMBG = "1405997273013",
                        Dan = 5,
                        Godina = 5,
                        Mesec = 2
                    }), Encoding.UTF8, "application/json"));


                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);


            }


        }
        [Fact]
        public async Task Test_GetAll_Ucenik()
        {
            AutoMapper.Mapper.Reset();
            using (var client = new TestUcenikProvider().Client)
            {

                var response = await client.GetAsync("/api/Ucenik");

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);

               
            }
        }
        [Fact]
        public async Task Test_GetAll_UcenikById()
        {
            AutoMapper.Mapper.Reset();
            using (var client = new TestUcenikProvider().Client)
            {

                var response = await client.GetAsync("/api/Ucenik/17");

                response.EnsureSuccessStatusCode();

                response.StatusCode.Should().Be(HttpStatusCode.OK);
             
            }
        }
       


    }
}

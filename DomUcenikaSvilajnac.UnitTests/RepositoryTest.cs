using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.DAL.RepoPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DomUcenikaSvilajnac.UnitTests
{
    [TestClass]
    public class RepositoryTest
    {
        private Mock<IRepository<Ucenik>> repoMock;

        [TestInitialize]
        public void Initialize()
        {
            repoMock = new Mock<IRepository<Ucenik>>();
        }

        [TestMethod]
        public async Task CanGetAllUceniks()
        {
            var listaUcenika = new List<Ucenik>();
            listaUcenika.Add(new Ucenik() { Ime = "Ilhan", Prezime = "Kalac", JMBG = "1234567890123", Pol = "Muski" });
            listaUcenika.Add(new Ucenik() { Ime = "Pavle", Prezime = "Lukic", JMBG = "2206997710228", Pol = "Muski" });
            repoMock.Setup(u => u.GetAllAsync()).ReturnsAsync(listaUcenika);

            Xunit.Assert.True(listaUcenika.Count > 1);
        }
    }
}

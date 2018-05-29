using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestoviIntegracioni
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
        public void CanGetAllUceniks()
        {
            var listaUcenika = new List<Ucenik>();
            listaUcenika.Add(new Ucenik() { Ime = "Ilhan", Prezime = "Kalac", JMBG = "1234567890123", Pol = "Muski" });
            listaUcenika.Add(new Ucenik() { Ime = "Pavle", Prezime = "Lukic", JMBG = "2206997710228", Pol = "Muski" });
            repoMock.Setup(u => u.GetAllAsync()).ReturnsAsync(listaUcenika);

            Xunit.Assert.True(listaUcenika.Count > 1);
        }

        [TestMethod]
        public void GetUcenikPoId()
        {
            int ucenikId = 5;

            var mock = new Mock<IRepository<Ucenik>>();
            mock.Setup(u => u.Get(z => z.ID))
        }
    }    
}


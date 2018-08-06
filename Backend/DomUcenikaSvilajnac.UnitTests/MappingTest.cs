using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.Mapping;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace DomUcenikaSvilajnac.UnitTests
{
    /// <summary>
    /// Klasa za testriranje mapiranja.
    /// </summary>
    [TestClass]
    public class MappingTest
    {

        /// <summary>
        /// Provera da li mapiranje radi kako treba kada se posalju potrebni podaci, a podaci o datumu u okviru promenljive DatumRodjenja.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ResursModelproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());


            Mapper.AssertConfigurationIsValid();
            Ucenik ucenik = new Ucenik()
            {
                Id = 1,
                Ime = "Pera",
                Prezime = "Peric",
                JMBG = "1231231231233",
                DatumRodjenja = new DateTime(1998, 04, 30),
                DrzavaRodjenjaId = 1,
                MestoPrebivalistaId = 1,
                MestoRodjenjaId = 1,
                MestoZavrseneSkoleId = 1,
                OpstinaPrebivalistaId = 1,
                PolId = 1,
                Adresa = "Milutaina Milankovica 74",
                TelefonId = 1,
                PostanskiBrojId = 1,
                UpisanaSkolaId = 1,
                SmerId = 1,
                RazredId = 1,
                PrethodnaSkolaId = 1,
                PrethodniUspeh = 4.55f

            };
            var result = Mapper.Map<Ucenik, UcenikResource>(ucenik);

            Assert.IsInstanceOfType(result, typeof(UcenikResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Provera da li mapiranje radi kako treba kada se posalju potrebni podaci, a podaci o datumu u vidu tri pormenljive dan, mesec, godina.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelResursproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            //Mapper.AssertConfigurationIsValid();
            UcenikResource ucenik = new UcenikResource()
            {
                Id = 1,
                Ime = "Pera",
                Prezime = "Peric",
                JMBG = "1231231231233",
                Dan = 5,
                Mesec = 11,
                Godina = 2001



            };
            var result = Mapper.Map<UcenikResource, Ucenik>(ucenik);

            Assert.IsInstanceOfType(result, typeof(Ucenik));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Provera da li mapiranje nece raditi kako treba kada se ne posalju svi podaci.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelResursproveraTipa_ReturnsFalseModel()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            UcenikResource ucenik = new UcenikResource()
            {
                Id = 1,
                Ime = "Pera",
                Prezime = "Peric",
                JMBG = "1231231231233",
                Dan = 5,
                Mesec = 11
            };

            try
            {
                var result = Mapper.Map<UcenikResource, Ucenik>(ucenik);

                Assert.Fail("OK");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is AutoMapperMappingException);
            }
            AutoMapper.Mapper.Reset();
        }
    }
}



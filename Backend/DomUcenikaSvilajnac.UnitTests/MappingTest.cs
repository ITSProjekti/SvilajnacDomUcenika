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
            Mapper.AssertConfigurationIsValid();
            UcenikResource ucenikResurs = new UcenikResource()
            {
                Id = 1,
                Ime = "Pera",
                Prezime = "Peric",
                JMBG = "1231231231233",
                Dan = 5,
                Mesec = 11,
                Godina = 2001
            };
            var result = Mapper.Map<UcenikResource, Ucenik>(ucenikResurs);

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
            UcenikResource ucenikResurs = new UcenikResource()
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
                var result = Mapper.Map<UcenikResource, Ucenik>(ucenikResurs);

                Assert.Fail("OK");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is AutoMapperMappingException);
            }
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja RoditeljResource u Roditelj, da li je objekat nakon mapiranja ocekivanog tipa.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelRoditeljResursproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            RoditeljResource roditeljiResurs = new RoditeljResource()
            {
                Id = 1,
                ImeMajke = "Majka",
                PrezimeMajke = "PrezimeMajke",
                ImeOca = "Otac",
                PrezimeOca = "PrezimeOca",
                UcenikId = 1,
                BrojTelefonaMajke = "123456",
                BrojTelefonaOca = "7891012"
            };
            var result = Mapper.Map<RoditeljResource, Roditelj>(roditeljiResurs);

            Assert.IsInstanceOfType(result, typeof(Roditelj));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja Roditelj u RoditeljResource, da li je objekat nakon mapiranja ocekivanog tipa.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelRoditeljproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            Roditelj roditelji = new Roditelj()
            {
                Id = 1,
                Ime = "Ime",
                Prezime = "Prezime",
                BrojTelefona = "123456789",
                StepenObrazovanjaId = 5,
                UcenikId = 1

            };
            var result = Mapper.Map<Roditelj, RoditeljResource>(roditelji);
            Assert.IsInstanceOfType(result, typeof(RoditeljResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja liste Roditelj u RoditeljResource, da li je objekat nakon mapiranja ocekivanog tipa.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelListaRoditeljaproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            List<Roditelj> listaRoditelja = new List<Roditelj>()
            {
                new Roditelj (){ Ime = "Otac", Prezime = "PrezimeOca", StepenObrazovanjaId = 5, BrojTelefona = "123456789"},
                new Roditelj (){ Ime = "Majka", Prezime = "PrezimeMajke", StepenObrazovanjaId = 5, BrojTelefona = "101112131415"},
            };
            var result = Mapper.Map<List<Roditelj>, RoditeljResource>(listaRoditelja);
            Assert.IsInstanceOfType(result, typeof(RoditeljResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja liste Roditelj u listu RoditeljResource, da li je objekat nakon mapiranja ocekivanog tipa (list<RoditeljResource>).
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelListaRoditeljaUListaRoditeljaResursproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            List<Roditelj> listaRoditelja = new List<Roditelj>()
            {
                new Roditelj (){ Ime = "Otac", Prezime = "PrezimeOca", StepenObrazovanjaId = 5, BrojTelefona = "123456789", UcenikId =1, Id = 1, StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Peti" } },
                new Roditelj (){ Ime = "Majka", Prezime = "PrezimeMajke", StepenObrazovanjaId = 5, BrojTelefona = "101112131415", UcenikId= 1, Id = 2,StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Sesti" }},
            };

            var result = Mapper.Map<List<Roditelj>, List<RoditeljResource>>(listaRoditelja);
            Assert.IsInstanceOfType(result, typeof(List<RoditeljResource>));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja liste RoditeljResource u listu Roditelj, da li je objekat nakon mapiranja ocekivanog tipa (list<Roditelj>).
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelListaRoditeljaResursUListaRoditeljaproveraTipa_ReturnsTrue()
        {

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            List<RoditeljResource> listaRoditeljiResurs = new List<RoditeljResource>()
            {
                new RoditeljResource (){ ImeOca = "Otac", PrezimeMajke = "PrezimeOca", StrucnaSpremaMajke = "5", BrojTelefonaMajke = "123456789"},
                new RoditeljResource (){ ImeMajke = "Majka", PrezimeMajke = "PrezimeMajke", StrucnaSpremaOca = "6", BrojTelefonaOca = "101112131415"},
            };

            var result = Mapper.Map<List<RoditeljResource>, List<Roditelj>>(listaRoditeljiResurs);
            Assert.IsInstanceOfType(result, typeof(List<Roditelj>));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja liste Roditelj u listu DeleteRoditeljResource, da li je objekat nakon mapiranja ocekivanog tipa (list<DeleteRoditeljaResource>).
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelListaRoditeljaUListaDeleteRoditeljaResursproveraTipa_ReturnsTrue()
        {

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            List<Roditelj> listaRoditelji = new List<Roditelj>()
            {
                new Roditelj (){ Ime = "Otac", Prezime = "PrezimeOca", StepenObrazovanjaId = 5, BrojTelefona = "123456789", UcenikId =1, Id = 1, StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Peti" } },
                new Roditelj (){ Ime = "Majka", Prezime = "PrezimeMajke", StepenObrazovanjaId = 5, BrojTelefona = "101112131415", UcenikId= 1, Id = 2,StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Sesti" }},
            };

            var result = Mapper.Map<List<Roditelj>, List<DeleteRoditeljaResource>>(listaRoditelji);
            Assert.IsInstanceOfType(result, typeof(List<DeleteRoditeljaResource>));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja PostRoditeljaResource u Roditelj, da li je objekat nakon mapiranja ocekivanog tipa.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelPostRoditeljaResursURoditeljproveraTipa_ReturnsTrue()
        {

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            PostRoditeljaResource postRoditeljaResurs = new PostRoditeljaResource()
            {
                Id = 1,
                ImeOca = "ImeOca",
                PrezimeOca = "PrezimeOca",
                BrojTelefonaOca = "123456789",
                IdMajke = 1,
                ImeMajke = "ImeMajke",
                PrezimeMajke = "PrezimeMajke",
                BrojTelefonaMajke = "123456789",
                StrucnaSpremaMajkeId = 5,
                StrucnaSpremaOcaId = 6,
                UcenikId = 1
            };
            var result = Mapper.Map<PostRoditeljaResource, Roditelj>(postRoditeljaResurs);
            Assert.IsInstanceOfType(result, typeof(Roditelj));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja liste Roditelj u PostRoditeljaResource, da li je objekat nakon mapiranja ocekivanog tipa.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelListaRoditeljaUPostRoditeljaResursproveraTipa_ReturnsTrue()
        {

            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();

            List<Roditelj> listaRoditelja = new List<Roditelj>()
            {
                new Roditelj (){ Ime = "Otac", Prezime = "PrezimeOca", StepenObrazovanjaId = 5, BrojTelefona = "123456789", UcenikId =1, Id = 1, StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Peti" } },
                new Roditelj (){ Ime = "Majka", Prezime = "PrezimeMajke", StepenObrazovanjaId = 5, BrojTelefona = "101112131415", UcenikId= 1, Id = 2,StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Sesti" }},
            };

            var result = Mapper.Map<List<Roditelj>, PostRoditeljaResource>(listaRoditelja);
            Assert.IsInstanceOfType(result, typeof(PostRoditeljaResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja Roditelj u PutRoditeljaResource, da li je objekat nakon mapiranja ocekivanog tipa.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelRoditeljUPutRoditeljaResursproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            Roditelj roditelji = new Roditelj()
            {
                Id = 1,
                Ime = "Ime",
                Prezime = "Prezime",
                BrojTelefona = "123456789",
                StepenObrazovanjaId = 5,
                UcenikId = 1

            };
            var result = Mapper.Map<Roditelj, PutRoditeljaResource>(roditelji);
            Assert.IsInstanceOfType(result, typeof(PutRoditeljaResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja Roditelj u listu PutRoditeljaResource, da li je objekat nakon mapiranja ocekivanog tipa (list<PutRoditeljaResource>).
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelListaRoditeljaUListuPutRoditeljaResursproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            List<Roditelj> listaRoditelja = new List<Roditelj>()
            {
                new Roditelj (){ Ime = "Otac", Prezime = "PrezimeOca", StepenObrazovanjaId = 5, BrojTelefona = "123456789", UcenikId =1, Id = 1, StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Peti" } },
                new Roditelj (){ Ime = "Majka", Prezime = "PrezimeMajke", StepenObrazovanjaId = 5, BrojTelefona = "101112131415", UcenikId= 1, Id = 2,StepenObrazovanja = new StepenStrucneSpreme(){ Opis= "Sesti" }},
            };

            var result = Mapper.Map<List<Roditelj>, List<PutRoditeljaResource>>(listaRoditelja);
            Assert.IsInstanceOfType(result, typeof(List<PutRoditeljaResource>));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja liste PutRoditeljaResource u listu Roditelj, da li je objekat nakon mapiranja ocekivanog tipa (list<Rodielj>).
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelListaPutRoditeljaResursUListuRoditeljaproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            List<PutRoditeljaResource> listaRoditeljaResurs = new List<PutRoditeljaResource>()
            {
                new PutRoditeljaResource (){  Id = 1,
                    ImeOca = "ImeOca",
                    PrezimeOca = "PrezimeOca",
                    BrojTelefonaOca = "123456789",
                    IdMajke = 1,
                    ImeMajke = "ImeMajke",
                    PrezimeMajke = "PrezimeMajke",
                    BrojTelefonaMajke = "123456789",
                    StrucnaSpremaMajkeId = 5,
                    StrucnaSpremaOcaId = 6,
                    UcenikId = 1},
                new PutRoditeljaResource (){
                    Id = 1,
                    ImeOca = "ImeOca",
                    PrezimeOca = "PrezimeOca",
                    BrojTelefonaOca = "123456789",
                    IdMajke = 1,
                    ImeMajke = "ImeMajke",
                    PrezimeMajke = "PrezimeMajke",
                    BrojTelefonaMajke = "123456789",
                    StrucnaSpremaMajkeId = 5,
                    StrucnaSpremaOcaId = 6,
                    UcenikId = 1
                }
            };

            var result = Mapper.Map<List<PutRoditeljaResource>, List<Roditelj>>(listaRoditeljaResurs);
            Assert.IsInstanceOfType(result, typeof(List<Roditelj>));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja PutRoditeljaResource u Roditelj, da li je objekat nakon mapiranja ocekivanog tipa. 
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelPutRoditeljaResursURoditeljproveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            PutRoditeljaResource putRoditeljaResurs = new PutRoditeljaResource()
            {
                Id = 1,
                ImeOca = "ImeOca",
                PrezimeOca = "PrezimeOca",
                BrojTelefonaOca = "123456789",
                IdMajke = 1,
                ImeMajke = "ImeMajke",
                PrezimeMajke = "PrezimeMajke",
                BrojTelefonaMajke = "123456789",
                StrucnaSpremaMajkeId = 5,
                StrucnaSpremaOcaId = 6,
                UcenikId = 1
            };
            var result = Mapper.Map<PutRoditeljaResource, Roditelj>(putRoditeljaResurs);
            Assert.IsInstanceOfType(result, typeof(Roditelj));
            AutoMapper.Mapper.Reset();
        }
    }
}



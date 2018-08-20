using AutoMapper;
using DomUcenikaSvilajnac.Common.Interfaces;
using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.IntegratedTests;
using DomUcenikaSvilajnac.Mapping;
using DomUcenikaSvilajnac.ModelResources;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DomUcenikaSvilajnac.UnitTests
{
    /// <summary>
    /// Klasa za testriranje mapiranja.
    /// </summary>
    [TestClass]
    public class MappingTest
    {
        DataModels dm = new DataModels();

        /// <summary>
        /// Provera da li mapiranje radi kako treba kada se posalju potrebni podaci, a podaci o datumu u okviru promenljive DatumRodjenja.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ResursModelProveraTipa_ReturnsTrue()
        {
            AutoMapper.Mapper.Reset();
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            var ucenik = dm.Ucenik2();
            var result = Mapper.Map<Ucenik, UcenikResource>(ucenik);

            Assert.IsInstanceOfType(result, typeof(UcenikResource));
        }

        /// <summary>
        /// Provera da li mapiranje radi kako treba kada se posalju potrebni podaci, a podaci o datumu u vidu tri pormenljive dan, mesec, godina.
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelResursProveraTipa_ReturnsTrue()
        {
            AutoMapper.Mapper.Reset();
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
        public void CreateMapMetode_ModelResursProveraTipa_ReturnsFalseModel()
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
        public void CreateMapMetode_ModelRoditeljResursProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelRoditeljProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelListaRoditeljaProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelListaRoditeljaUListaRoditeljaResursProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelListaRoditeljaResursUListaRoditeljaProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelListaRoditeljaUListaDeleteRoditeljaResursProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelPostRoditeljaResursURoditeljProveraTipa_ReturnsTrue()
        {
            AutoMapper.Mapper.Reset();
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
        public void CreateMapMetode_ModelListaRoditeljaUPostRoditeljaResursProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelRoditeljUPutRoditeljaResursProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelListaRoditeljaUListuPutRoditeljaResursProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelListaPutRoditeljaReusrsUListuRoditeljaProveraTipa_ReturnsTrue()
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
        public void CreateMapMetode_ModelPutRoditeljaResursURoditeljProveraTipa_ReturnsTrue()
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

        /// <summary>
        /// Proveravanje mapiranja MajkaResoruce u Roditelj, da li je objekat nakon mapiranja ocekivanog tipa. 
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelMajkaResursURoditeljProveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            MajkaResource majkaResurs = new MajkaResource()
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
            var result = Mapper.Map<MajkaResource, Roditelj>(majkaResurs);
            Assert.IsInstanceOfType(result, typeof(Roditelj));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja PutRoditeljaResource u MajkaResource, da li je objekat nakon mapiranja ocekivanog tipa. 
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelPutRoditeljaResursUMajkaResursProveraTipa_ReturnsTrue()
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
            var result = Mapper.Map<PutRoditeljaResource, MajkaResource>(putRoditeljaResurs);
            Assert.IsInstanceOfType(result, typeof(MajkaResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja MajkaResource u PutRoditeljResource, da li je objekat nakon mapiranja ocekivanog tipa. 
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelMajkaResursUPutRoditeljaResursProveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            MajkaResource majkaResurs = new MajkaResource()
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
            var result = Mapper.Map<MajkaResource, PutRoditeljaResource>(majkaResurs);
            Assert.IsInstanceOfType(result, typeof(PutRoditeljaResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja Staratelj u StarateljResource, da li je objekat nakon mapiranja ocekivanog tipa. 
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelStarateljUStarateljResursProveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            Staratelj staratelj = new Staratelj()
            {
                Id = 1,
                Ime = "Staratelj",
                Prezime = "Prezime",
                UcenikId = 1
            };
            var result = Mapper.Map<Staratelj, StarateljResource>(staratelj);
            Assert.IsInstanceOfType(result, typeof(StarateljResource));
            AutoMapper.Mapper.Reset();
        }

        /// <summary>
        /// Proveravanje mapiranja StarateljResource u Staratelj, da li je objekat nakon mapiranja ocekivanog tipa. 
        /// </summary>
        [TestMethod]
        public void CreateMapMetode_ModelStarateljResursUStarateljProveraTipa_ReturnsTrue()
        {
            Mapper.Initialize(m => m.AddProfile<MappingProfile>());
            Mapper.AssertConfigurationIsValid();
            StarateljResource starateljResurs = new StarateljResource()
            {
                Id = 1,
                Ime = "Staratelj",
                Prezime = "Prezime",
                UcenikId = 1
            };
            var result = Mapper.Map<StarateljResource, Staratelj>(starateljResurs);
            Assert.IsInstanceOfType(result, typeof(Staratelj));
            AutoMapper.Mapper.Reset();
        }
    }
}



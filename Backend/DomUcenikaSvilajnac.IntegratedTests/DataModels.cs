using DomUcenikaSvilajnac.Common.Models;
using DomUcenikaSvilajnac.Common.Models.ModelResources;
using DomUcenikaSvilajnac.ModelResources;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DomUcenikaSvilajnac.IntegratedTests
{
    public class DataModels
    {
        DrzavaResource dr = new DrzavaResource() { Id = 157 };

        MestoResource mr = new MestoResource() { Id = 333 };

        OpstinaUcenikaResource our = new OpstinaUcenikaResource() { Id = 11 };

        PolResource p = new PolResource() { Id = 1 };

        PostanskiBrojResource pbr = new PostanskiBrojResource() { Id = 111 };

        PrethodnaSkolaResource psr = new PrethodnaSkolaResource() { Id = 55 };

        PostRoditeljaResource prs = new PostRoditeljaResource() { ImeMajke = "Majka", PrezimeMajke = "PrezimeMajke", ImeOca = "Otac", PrezimeOca = "PrezimeOca", BrojTelefonaMajke = "12314567", BrojTelefonaOca = "1231567", StrucnaSpremaMajkeId = 6, StrucnaSpremaOcaId = 7 };

        RazredResource rr = new RazredResource() { Id = 4 };

        Telefon t = new Telefon() { Kucni = "011231258", Mobilni = "0628136986" };

        SmerResource sr = new SmerResource() { Id = 3 };

        UpisanaSkolaResource usr = new UpisanaSkolaResource() { Id = 333 };



        Collection<Roditelj> roditelji = new Collection<Roditelj>() {
            new Roditelj (){ Ime = "Otac", Prezime = "Prezime"},
            new Roditelj () {Ime = "Majka", Prezime = "Prezime"}
        };
        /// <summary>
        /// Metoda koja vraca objekat klase PostUcenikaResource, posto se podaci koriste vise puta, tj za vise testova.
        /// </summary>
        public PostUcenikaResource Ucenik()
        {


            return new PostUcenikaResource
            {
                Ime = "Pera",
                Prezime = "Pericc",
                JMBG = "1234567891234",
                Dan = 8,
                Godina = 1995,
                Mesec = 7,
                Adresa = "Milutina Milankovica 22",
                DrzavaRodjenja = dr,
                MestoRodjenja = mr,
                PrethodnaSkola = psr,
                MestoPrebivalista = mr,
                MestoZavrseneSkole = mr,
                Opstina = our,
                OpstinaPrebivalista = our,
                Pol = p,
                PostanskiBroj = pbr,
                Roditelji = prs,
                Razred = rr,
                Telefon = t,
                Smer = sr,
                UpisanaSkola = usr,
                PrethodniUspeh = 4.55f
            };
        }
        public Ucenik Ucenik2()
        {
            Ucenik ucenik = new Ucenik()
            {
                Ime = "Igor",
                Prezime = "Marjanovic",
                JMBG = "1234567891234",
                DatumRodjenja = DateTime.Now,
                DrzavaRodjenjaId = 1,
                Adresa = "Savnicka 25",
                MestoRodjenjaId = 5,
                MestoPrebivalistaId = 11,
                MestoZavrseneSkoleId = 4,
                PrethodnaSkolaId = 55,
                UpisanaSkolaId = 44,
                OpstinaId = 11,
                OpstinaPrebivalistaId = 33,
                PolId = 1,
                PostanskiBrojId = 55,
                RazredId = 4,
                SmerId = 1,
                PrethodniUspeh = 4.22f,
                Roditelji = roditelji
            };
            return ucenik;

        }
        public PostRoditeljaResource roditeljResurs = new PostRoditeljaResource()
        {
            Id = 1,
            IdMajke = 2,
            ImeMajke = "ImeMajke",
            PrezimeMajke = "PrezimeMajke",
            BrojTelefonaMajke = "123456789",
            StrucnaSpremaMajkeId= 1,
            ImeOca = "ImeOca",
            PrezimeOca = "PrezimeOca",
            BrojTelefonaOca = "123456789",
            StrucnaSpremaOcaId = 5,
            UcenikId = 1

        };
        public PutRoditeljaResource putRoditeljaResurs = new PutRoditeljaResource()
        {
            Id = 1,
            IdMajke = 2,
            ImeMajke = "ImeMajke2",
            PrezimeMajke = "PrezimeMajke2",
            BrojTelefonaMajke = "1234567892",
            StrucnaSpremaMajkeId = 2,
            ImeOca = "ImeOca2",
            PrezimeOca = "PrezimeOca2",
            BrojTelefonaOca = "1234567892",
            StrucnaSpremaOcaId = 6,
            UcenikId = 1
        };
    }
}

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

        TipPorodiceResource tp = new TipPorodiceResource() { Id = 4 };


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
                PrethodniUspeh = 4.55f,
                MaterijalniPrihodi = 15,
                TipPorodice = tp,
                Slika = "1010101010101"
            };
        }
        public Ucenik Ucenik2()
        {
            Ucenik ucenik = new Ucenik()
            {
                Id = 1,
                Ime = "Pera",
                Prezime = "Peric",
                JMBG = "1231231231233",
                DatumRodjenja = new DateTime(1998, 04, 30),
                DrzavaRodjenjaId = 1,
                //MestoPrebivalistaId = 1,
                //MestoRodjenjaId = 1,
                //MestoZavrseneSkoleId = 1,
                //OpstinaPrebivalistaId = 1,
                PolId = 1,
                Adresa = "Milutaina Milankovica 74",
                TelefonId = 1,
                PostanskiBrojId = 1,
                UpisanaSkolaId = 1,
                SmerId = 1,
                RazredId = 1,
                PrethodnaSkolaId = 1,
                PrethodniUspeh = 4.55f,
                Slika = "132312312321321",
                Staratelji = new Collection<Staratelj>()
                {
                    new Staratelj()
                    {
                        Id = 1,
                        Ime = "StarateljIme",
                        Prezime = "StarateljPrezime",
                        UcenikId = 1
                    }
                },
                MaterijalniPrihodi = 5,
                TipPorodiceId = 3,
                VaspitnaGrupaId =1
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

        public VaspitacResource vaspitac()
        {
            return new VaspitacResource
            {
                Id = 1,
                Ime = "ImeVaspitaca",
                Prezime = "PrezimeVaspitaca",
                BrojTelefona = "1234567",
                Slika = "101010101"
            };
        }

        public Vaspitac vaspitac1()
        {
            return new Vaspitac
            {
                Id = 1,
                Ime = "ImeVaspitaca",
                Prezime = "PrezimeVaspitaca",
                BrojTelefona = "1234567",
                Slika = "101010101"
            };
        }
        public Pohvala pohvala()
        {
            return new Pohvala
            {
                Id = 1,
                UcenikId = 1,
                VremeUpisa = DateTime.Now,
                Opis = "Istici se",
                BodoviPohvale = 5
            };
        }
    

        public Kazna kazna()
        {
            return new Kazna
            {
                Id = 1,
                UcenikId = 1,
                VremeUpisa = DateTime.Now,
                Opis = "Izbacen sa casa",
                BodoviKazne = 5
            };
        }

        public Statistika statistika()
        {
            return new Statistika
            {
                Id = 1,
                VaspitnaGrupaId = 1,
                Posecenost = "0",
                UspehVaspitneGrupe = 0,
                BodoviPohvalaGrupa = 0
            };
        }

        public VaspitnaGrupa vaspitnaGrupa()
        {
            return new VaspitnaGrupa
            {
                Id = 1,
                VaspitacId = 1,
                Naziv = "Test Grupa",
                BrojUcenika = 20
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models.ModelResources
{
    /// <summary>
    /// Prilikom put-ovanja (updateovanja) ucenika prosledjuju se podaci navedeni u klasi ispod.
    /// </summary>
    public class PutUcenikaResource
    {
        public int Id { get; set; }
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public PostanskiBrojResource PostanskiBroj { get; set; }
        public PolResource Pol { get; set; }
        public Telefon Telefon { get; set; }

        public int Dan { get; set; }
        public int Mesec { get; set; }

        public int Godina { get; set; }

        public OpstinaUcenikaResource Opstina { get; set; }
        public OpstinaUcenikaResource OpstinaPrebivalista { get; set; }

        public MestoResource MestoRodjenja { get; set; }
        public MestoResource MestoPrebivalista { get; set; }

        public MestoResource MestoZavrseneSkole { get; set; }

        public DrzavaResource DrzavaRodjenja { get; set; }

        public PrethodnaSkolaResource PrethodnaSkola { get; set; }
        public UpisanaSkolaResource UpisanaSkola { get; set; }

        public SmerResource Smer { get; set; }

        public RazredResource Razred { get; set; }

        //public List<RoditeljiUcenikaResource> Roditelji { get; set; }

        public PostRoditeljaResource Roditelji { get; set; }
        public float PrethodniUspeh { get; set; }
    }
}

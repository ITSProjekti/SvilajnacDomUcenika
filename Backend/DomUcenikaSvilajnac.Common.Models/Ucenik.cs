using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Ucenik, pravi tabelu "Ucenici" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Ucenici")]
    public class Ucenik
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Ime { get; set; }

        [Required]
        [StringLength(50)]
        public string Prezime { get; set; }

        [Required]
        [MaxLength(13), MinLength(13)]
        public string JMBG { get; set; }

        public string Adresa { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]


        public DateTime DatumRodjenja { get; set; }


        //================
        //propertiji za komentarisanje prije svake migracije
        public int OpstinaPrebivalistaId { get; set; }
        public int OpstinaId { get; set; }
        //================
        public Opstina Opstina { get; set; }
        public Opstina OpstinaPrebivalista { get; set; }
        //

        public string MestoRodjenja { get; set; }
        public string MestoPrebivalista { get; set; }

        public int DrzavaRodjenjaId { get; set; }
        public Drzava DrzavaRodjenja { get; set; }

        public string PrethodnaSkola { get; set; }
        public string MestoZavrseneSkole { get; set; }


        public int PolId { get; set; }

        public Pol Pol { get; set; }

        public int TelefonId { get; set; }
        public Telefon Telefon { get; set; }

        public int PostanskiBrojId { get; set; }
        public PostanskiBroj PostanskiBroj { get; set; }

        //public int UpisanaSkolaId { get; set; }
        //public UpisanaSkola UpisanaSkola { get; set; }


        public DateTime VremeUpisa { get; set; }
    }
}

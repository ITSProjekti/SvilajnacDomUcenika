using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(50)]
        public string Ime { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(MAX)")]
        [StringLength(50)]
        public string Prezime { get; set; }

        [Required]
        [MaxLength(13), MinLength(13)]
        public string JMBG { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string Adresa { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/mm/yyyy}")]


        public DateTime DatumRodjenja { get; set; }

        public int DrzavaRodjenjaId { get; set; }
        public Drzava DrzavaRodjenja { get; set; }

        //================
        // propertiji za komentarisanje prije svake migracije
        public int OpstinaPrebivalistaId { get; set; }
        public int OpstinaId { get; set; }
        //================
        public Opstina Opstina { get; set; }
        public Opstina OpstinaPrebivalista { get; set; }




        //================
        //propertiji za komentarisanje prije svake migracije
        public int MestoRodjenjaId { get; set; }
        public int MestoPrebivalistaId { get; set; }
        public int MestoZavrseneSkoleId { get; set; }
        //================



        public Mesto MestoRodjenja { get; set; }

        public Mesto MestoPrebivalista { get; set; }

        public Mesto MestoZavrseneSkole { get; set; }
        public int PolId { get; set; }

        public Pol Pol { get; set; }

        public int TelefonId { get; set; }
        public Telefon Telefon { get; set; }

  

        public int PrethodnaSkolaId { get; set; }

        public PrethodnaSkola PrethodnaSkola { get; set; }


        public int PostanskiBrojId { get; set; }
        public PostanskiBroj PostanskiBroj { get; set; }

        public int UpisanaSkolaId { get; set; }
        public UpisanaSkola UpisanaSkola { get; set; }

        public int SmerId { get; set; }
        public Smer Smer { get; set; }

        public int RazredId { get; set; }
        public Razred Razred { get; set; }


        public DateTime VremeUpisa { get; set; }

        public Collection<Roditelj> Roditelji { get; set; }
        public Collection<Staratelj> Staratelji { get; set; }
        public Collection<Pohvala> Pohvale { get; set; }
        public Collection<Kazna> Kazne { get; set; }

        public Ucenik()
        {

            Roditelji = new Collection<Roditelj>();
            Staratelji = new Collection<Staratelj>();
            Pohvale = new Collection<Pohvala>();
            Kazne = new Collection<Kazna>();


        }
        public float PrethodniUspeh { get; set; }
        public string Slika  { get; set; }


        public int TipPorodiceId { get; set; }
        public TipPorodice TipPorodice { get; set; }

        public int MaterijalniPrihodi { get; set; }


    


    }
}

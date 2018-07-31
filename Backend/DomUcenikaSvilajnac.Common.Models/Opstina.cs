using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomUcenikaSvilajnac.Common.Models
{
    /// <summary>
    /// Klasa Opstina, pravi tabelu "Opstine" u bazi podataka sa poljima koja su navedena kao property u datoj klasi.
    /// </summary>
    [Table("Opstine")]
    public class Opstina
    {
        public int Id { get; set; }

        [Column(TypeName = "NVARCHAR(MAX)")]
        public string NazivOpstine { get; set; }


        //Za spajanje dva puta na ucenika
        [InverseProperty("Opstina")]
        ICollection<Ucenik> Ucenici {get; set; }

        [InverseProperty("OpstinaPrebivalista")]
        ICollection<Ucenik> UceniciOpstine { get; set; }

        public ICollection<PostanskiBroj> PostanskiBrojevi { get; set; }

        public ICollection<UpisanaSkola> SrednjeSkole { get; set; }
        public ICollection<PrethodnaSkola> OsnovneSkole { get; set; }

        public Opstina()
        {
            Ucenici = new Collection<Ucenik>();
            UceniciOpstine = new Collection<Ucenik>();
            PostanskiBrojevi = new Collection<PostanskiBroj>();
            SrednjeSkole = new Collection<UpisanaSkola>();
            OsnovneSkole = new Collection<PrethodnaSkola>();


        }
    }
}
